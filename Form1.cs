using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace StuntGP_widescreen
{
    public struct sequence
    {
        public byte[] byteSequence;
        public int offset;

        public sequence(byte[] byteSequence, int offset)
        {
            this.byteSequence = byteSequence;
            this.offset = offset;
        }
    }


    public partial class Form1 : Form
    {
        static string _GamesExecutable = "StuntGP_D3D.exe";
        static string _GamesExecutableBackup = "StuntGP_D3D.bak";
        static string PCGW_URL = "http://pcgamingwiki.com/";
        static string donationURL = "https://www.twitchalerts.com/donate/suicidemachine";

        int width = 1280;
        int height = 720;
        float aspectRatio = 1.7777777f;

        List<sequence> sequences = new List<sequence>()
        {
            new sequence(new byte[] { 0x80, 0xDC, 0x00, 0x00, 0x00, 0xBE, 0x9F, 0xAA, 0x3F, 0xC7, 0x80, 0xE0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x3F }, 5),
            new sequence(new byte[] { 0x80, 0xBC, 0x00, 0x00, 0x00, 0xBE, 0x9F, 0xAA, 0x3F, 0xC7, 0x80, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x3F }, 5)
        };

        byte[] AspectAsArray = new byte[4];
        byte[] data;
        int adress = 0;

        bool autoCalculate = true;

        public Form1()
        {
            InitializeComponent();
            if(!File.Exists(_GamesExecutable))
            {
                MessageBox.Show("No executable found. Please place the file in a folder with a game.");
                Close();
            }
            else
            {
                data = GetBytesFromAFile(_GamesExecutable);

                string s = BitConverter.ToString(data);

                for(int i=0; i<sequences.Count; i++)
                {
                    adress = findSequence(data, sequences[i]);
                    if (adress != -1)
                        break;
                }


                if (adress == -1)
                {
                    MessageBox.Show("Nothing found in the file. Sorry.");
                    Close();
                }
                else
                {
                    Trace.WriteLine("Found address: 0x" + adress.ToString("X4"));
                    aspectRatio = BitConverter.ToSingle(data, adress);
                    TB_AspectRatio.Text = aspectRatio.ToString();
                }
            }
        }

        #region FindAdress
        private int findSequence(byte[] source, sequence _sequence)
        {
            for (int tempAdress = 0; tempAdress < source.Length; tempAdress++)
            {
                if(compareByteArrays(_sequence, source, tempAdress))
                {
                    return tempAdress + _sequence.offset;
                }
            }
            return -1;
        }

        private bool compareByteArrays(sequence _sequence, byte[] dataArray, int dataOffset)
        {
            byte[] sequenceArray = _sequence.byteSequence;
            int offset = _sequence.offset;

            if (dataArray.Length-dataOffset > sequenceArray.Length)
            {
                for (int i = 0; i<sequenceArray.Length; i++)
                {
                    if (i == offset)
                    {
                        i += 3;
                        continue;
                    }


                    if(sequenceArray[i]!=dataArray[dataOffset+i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
#endregion

        #region Buttons_Lables_and_Stuff
        private void TB_ResX_TextChanged(object sender, EventArgs e)
        {
            var temp = 1280;
            if (int.TryParse(TB_ResX.Text, out temp))
            {
                width = temp;
            }
            else
                width = 1280;

            if (autoCalculate)
            {
                aspectRatio = CalculateAspect(width, height);
                TB_AspectRatio.Text = aspectRatio.ToString();
            }
        }

        private void TB_ResY_TextChanged(object sender, EventArgs e)
        {
            var temp = 720;
            if (int.TryParse(TB_ResY.Text, out temp))
            {
                height = temp;
            }
            else
                height = 720;

            if (autoCalculate)
            {
                aspectRatio = CalculateAspect(width, height);
                TB_AspectRatio.Text = aspectRatio.ToString();
            }
        }

        float CalculateAspect(int X, int Y)
        {
            float outputValue = X*1.0f / Y*1.0f;
            return outputValue;
        }

        private void C_AutomaticAspect_CheckedChanged(object sender, EventArgs e)
        {
            if (C_AutomaticAspect.Checked)
            {
                autoCalculate = true;
                TB_AspectRatio.Enabled = false;
                aspectRatio = CalculateAspect(width, height);
                TB_AspectRatio.Text = aspectRatio.ToString();
            }
            else
            {
                autoCalculate = false;
                TB_AspectRatio.Enabled = true;
            }
        }


        private void getArray()
        {
            AspectAsArray = BitConverter.GetBytes(aspectRatio);
            L_Byte0.Text = AspectAsArray[0].ToString("X2");
            L_Byte1.Text = AspectAsArray[1].ToString("X2");
            L_Byte2.Text = AspectAsArray[2].ToString("X2");
            L_Byte3.Text = AspectAsArray[3].ToString("X2");
        }

        private void TB_AspectRatio_TextChanged(object sender, EventArgs e)
        {
            if(!autoCalculate)
            {
                var temp = 1.333f;
                if(float.TryParse(TB_AspectRatio.Text, out temp))
                {
                    aspectRatio = temp;
                }
            }
            getArray();
        }
        #endregion

        #region Load_Save
        private byte[] GetBytesFromAFile(string filename)
        {
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(filename);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return bytes;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        private bool WriteBytesToAFile(string filename, byte[] usedData)
        {
            try
            {
                File.WriteAllBytes(filename, usedData);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }
        }

        private void B_WriteToAFile_Click(object sender, EventArgs e)
        {
            //Replacing bytes
            data[adress + 0] = AspectAsArray[0];
            data[adress + 1] = AspectAsArray[1];
            data[adress + 2] = AspectAsArray[2];
            data[adress + 3] = AspectAsArray[3];

            //Backup
            if (!File.Exists(_GamesExecutableBackup))
            {
                File.Copy(_GamesExecutable, _GamesExecutableBackup);
            }

            bool success = true;
            success = WriteBytesToAFile(_GamesExecutable, data);

            if (!success)
                MessageBox.Show("There was an error writting to a file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Successfully made the changes!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void LL_PCGW_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(PCGW_URL);
        }

        private void donateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(donationURL);
        }
    }
}
