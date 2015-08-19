namespace StuntGP_widescreen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ResX = new System.Windows.Forms.TextBox();
            this.TB_ResY = new System.Windows.Forms.TextBox();
            this.TB_AspectRatio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.C_AutomaticAspect = new System.Windows.Forms.CheckBox();
            this.B_WriteToAFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Byte3 = new System.Windows.Forms.Label();
            this.L_Byte2 = new System.Windows.Forms.Label();
            this.L_Byte1 = new System.Windows.Forms.Label();
            this.L_Byte0 = new System.Windows.Forms.Label();
            this.LL_PCGW_link = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution:";
            // 
            // TB_ResX
            // 
            this.TB_ResX.Location = new System.Drawing.Point(3, 19);
            this.TB_ResX.Name = "TB_ResX";
            this.TB_ResX.Size = new System.Drawing.Size(84, 20);
            this.TB_ResX.TabIndex = 1;
            this.TB_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResX.TextChanged += new System.EventHandler(this.TB_ResX_TextChanged);
            // 
            // TB_ResY
            // 
            this.TB_ResY.Location = new System.Drawing.Point(109, 19);
            this.TB_ResY.Name = "TB_ResY";
            this.TB_ResY.Size = new System.Drawing.Size(84, 20);
            this.TB_ResY.TabIndex = 2;
            this.TB_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResY.TextChanged += new System.EventHandler(this.TB_ResY_TextChanged);
            // 
            // TB_AspectRatio
            // 
            this.TB_AspectRatio.Enabled = false;
            this.TB_AspectRatio.Location = new System.Drawing.Point(3, 58);
            this.TB_AspectRatio.Name = "TB_AspectRatio";
            this.TB_AspectRatio.Size = new System.Drawing.Size(190, 20);
            this.TB_AspectRatio.TabIndex = 3;
            this.TB_AspectRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_AspectRatio.TextChanged += new System.EventHandler(this.TB_AspectRatio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aspect ratio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            // 
            // C_AutomaticAspect
            // 
            this.C_AutomaticAspect.AutoSize = true;
            this.C_AutomaticAspect.Checked = true;
            this.C_AutomaticAspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.C_AutomaticAspect.Location = new System.Drawing.Point(6, 110);
            this.C_AutomaticAspect.Name = "C_AutomaticAspect";
            this.C_AutomaticAspect.Size = new System.Drawing.Size(73, 17);
            this.C_AutomaticAspect.TabIndex = 6;
            this.C_AutomaticAspect.Text = "Automatic";
            this.C_AutomaticAspect.UseVisualStyleBackColor = true;
            this.C_AutomaticAspect.CheckedChanged += new System.EventHandler(this.C_AutomaticAspect_CheckedChanged);
            // 
            // B_WriteToAFile
            // 
            this.B_WriteToAFile.Location = new System.Drawing.Point(91, 134);
            this.B_WriteToAFile.Name = "B_WriteToAFile";
            this.B_WriteToAFile.Size = new System.Drawing.Size(90, 23);
            this.B_WriteToAFile.TabIndex = 7;
            this.B_WriteToAFile.Text = "Write to a file";
            this.B_WriteToAFile.UseVisualStyleBackColor = true;
            this.B_WriteToAFile.Click += new System.EventHandler(this.B_WriteToAFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LL_PCGW_link);
            this.panel1.Controls.Add(this.L_Byte3);
            this.panel1.Controls.Add(this.L_Byte2);
            this.panel1.Controls.Add(this.L_Byte1);
            this.panel1.Controls.Add(this.L_Byte0);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.B_WriteToAFile);
            this.panel1.Controls.Add(this.TB_ResX);
            this.panel1.Controls.Add(this.C_AutomaticAspect);
            this.panel1.Controls.Add(this.TB_ResY);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_AspectRatio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 174);
            this.panel1.TabIndex = 8;
            // 
            // L_Byte3
            // 
            this.L_Byte3.AutoSize = true;
            this.L_Byte3.Location = new System.Drawing.Point(109, 84);
            this.L_Byte3.Name = "L_Byte3";
            this.L_Byte3.Size = new System.Drawing.Size(19, 13);
            this.L_Byte3.TabIndex = 11;
            this.L_Byte3.Text = "00";
            // 
            // L_Byte2
            // 
            this.L_Byte2.AutoSize = true;
            this.L_Byte2.Location = new System.Drawing.Point(78, 84);
            this.L_Byte2.Name = "L_Byte2";
            this.L_Byte2.Size = new System.Drawing.Size(19, 13);
            this.L_Byte2.TabIndex = 10;
            this.L_Byte2.Text = "00";
            // 
            // L_Byte1
            // 
            this.L_Byte1.AutoSize = true;
            this.L_Byte1.Location = new System.Drawing.Point(41, 84);
            this.L_Byte1.Name = "L_Byte1";
            this.L_Byte1.Size = new System.Drawing.Size(19, 13);
            this.L_Byte1.TabIndex = 9;
            this.L_Byte1.Text = "00";
            // 
            // L_Byte0
            // 
            this.L_Byte0.AutoSize = true;
            this.L_Byte0.Location = new System.Drawing.Point(9, 84);
            this.L_Byte0.Name = "L_Byte0";
            this.L_Byte0.Size = new System.Drawing.Size(19, 13);
            this.L_Byte0.TabIndex = 8;
            this.L_Byte0.Text = "00";
            // 
            // LL_PCGW_link
            // 
            this.LL_PCGW_link.AutoSize = true;
            this.LL_PCGW_link.Location = new System.Drawing.Point(6, 139);
            this.LL_PCGW_link.Name = "LL_PCGW_link";
            this.LL_PCGW_link.Size = new System.Drawing.Size(78, 13);
            this.LL_PCGW_link.TabIndex = 12;
            this.LL_PCGW_link.TabStop = true;
            this.LL_PCGW_link.Text = "PCGamingWiki";
            this.LL_PCGW_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_PCGW_link_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 193);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "StuntGP Widescreen fixer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ResX;
        private System.Windows.Forms.TextBox TB_ResY;
        private System.Windows.Forms.TextBox TB_AspectRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox C_AutomaticAspect;
        private System.Windows.Forms.Button B_WriteToAFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_Byte3;
        private System.Windows.Forms.Label L_Byte2;
        private System.Windows.Forms.Label L_Byte1;
        private System.Windows.Forms.Label L_Byte0;
        private System.Windows.Forms.LinkLabel LL_PCGW_link;
    }
}

