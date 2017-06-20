namespace COMView
{
    partial class MainForm
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
            this.btnscan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.portno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnscan
            // 
            this.btnscan.BackgroundImage = global::COMView.Properties.Resources.scan;
            this.btnscan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnscan.Location = new System.Drawing.Point(290, 12);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(30, 30);
            this.btnscan.TabIndex = 58;
            this.btnscan.UseVisualStyleBackColor = true;
            this.btnscan.Click += new System.EventHandler(this.btnscan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Port No:";
            // 
            // portno
            // 
            this.portno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.portno.FormattingEnabled = true;
            this.portno.Location = new System.Drawing.Point(108, 18);
            this.portno.MaxDropDownItems = 15;
            this.portno.Name = "portno";
            this.portno.Size = new System.Drawing.Size(161, 21);
            this.portno.TabIndex = 59;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 58);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.portno);
            this.Controls.Add(this.btnscan);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnscan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox portno;
    }
}

