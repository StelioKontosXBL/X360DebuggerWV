﻿namespace X360DebuggerWV
{
    partial class WinLog
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
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb1
            // 
            this.rtb1.DetectUrls = false;
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.rtb1.Location = new System.Drawing.Point(0, 0);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(638, 439);
            this.rtb1.TabIndex = 1;
            this.rtb1.Text = "";
            this.rtb1.WordWrap = false;
            // 
            // WinLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 439);
            this.ControlBox = false;
            this.Controls.Add(this.rtb1);
            this.Name = "WinLog";
            this.Text = "Log Output";
            this.Load += new System.EventHandler(this.WinLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb1;
    }
}