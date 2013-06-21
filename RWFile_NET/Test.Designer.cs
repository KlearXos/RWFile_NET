namespace RWFile_NET
{
    partial class Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.chkFlash = new System.Windows.Forms.CheckBox();
            this.chkRam = new System.Windows.Forms.CheckBox();
            this.chkSD = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            // 
            // chkFlash
            // 
            this.chkFlash.Location = new System.Drawing.Point(56, 13);
            this.chkFlash.Name = "chkFlash";
            this.chkFlash.Size = new System.Drawing.Size(157, 20);
            this.chkFlash.TabIndex = 1;
            this.chkFlash.Text = "Flash (IPSM/FMD)";
            this.chkFlash.CheckStateChanged += new System.EventHandler(this.chkStateChanged);
            // 
            // chkRam
            // 
            this.chkRam.Location = new System.Drawing.Point(56, 39);
            this.chkRam.Name = "chkRam";
            this.chkRam.Size = new System.Drawing.Size(157, 20);
            this.chkRam.TabIndex = 2;
            this.chkRam.Text = "Ram (Object Store)";
            // 
            // chkSD
            // 
            this.chkSD.Location = new System.Drawing.Point(56, 65);
            this.chkSD.Name = "chkSD";
            this.chkSD.Size = new System.Drawing.Size(157, 20);
            this.chkSD.TabIndex = 3;
            this.chkSD.Text = "Storage Card";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(268, 141);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSD);
            this.Controls.Add(this.chkRam);
            this.Controls.Add(this.chkFlash);
            this.Controls.Add(this.button1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkFlash;
        private System.Windows.Forms.CheckBox chkRam;
        private System.Windows.Forms.CheckBox chkSD;
        private System.Windows.Forms.Label label1;
    }
}

