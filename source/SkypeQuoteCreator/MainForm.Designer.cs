﻿namespace SkypeQuoteCreator
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
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxMessageLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxMessage = new System.Windows.Forms.TextBox();
            this.uxTimestamp = new System.Windows.Forms.MaskedTextBox();
            this.uxTimestampLabel = new System.Windows.Forms.Label();
            this.uxCopyToClipboard = new System.Windows.Forms.Button();
            this.uxUseCurrentDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(12, 15);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(38, 13);
            this.uxNameLabel.TabIndex = 5;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxMessageLabel
            // 
            this.uxMessageLabel.AutoSize = true;
            this.uxMessageLabel.Location = new System.Drawing.Point(12, 70);
            this.uxMessageLabel.Name = "uxMessageLabel";
            this.uxMessageLabel.Size = new System.Drawing.Size(53, 13);
            this.uxMessageLabel.TabIndex = 7;
            this.uxMessageLabel.Text = "Message:";
            // 
            // uxName
            // 
            this.uxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxName.Location = new System.Drawing.Point(79, 12);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(271, 20);
            this.uxName.TabIndex = 0;
            // 
            // uxMessage
            // 
            this.uxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMessage.Location = new System.Drawing.Point(79, 67);
            this.uxMessage.Multiline = true;
            this.uxMessage.Name = "uxMessage";
            this.uxMessage.Size = new System.Drawing.Size(271, 118);
            this.uxMessage.TabIndex = 3;
            // 
            // uxTimestamp
            // 
            this.uxTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTimestamp.Location = new System.Drawing.Point(79, 40);
            this.uxTimestamp.Mask = "0000-00-00 00:00:00";
            this.uxTimestamp.Name = "uxTimestamp";
            this.uxTimestamp.Size = new System.Drawing.Size(156, 20);
            this.uxTimestamp.TabIndex = 1;
            // 
            // uxTimestampLabel
            // 
            this.uxTimestampLabel.AutoSize = true;
            this.uxTimestampLabel.Location = new System.Drawing.Point(12, 43);
            this.uxTimestampLabel.Name = "uxTimestampLabel";
            this.uxTimestampLabel.Size = new System.Drawing.Size(61, 13);
            this.uxTimestampLabel.TabIndex = 6;
            this.uxTimestampLabel.Text = "Timestamp:";
            // 
            // uxCopyToClipboard
            // 
            this.uxCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxCopyToClipboard.Location = new System.Drawing.Point(234, 188);
            this.uxCopyToClipboard.Name = "uxCopyToClipboard";
            this.uxCopyToClipboard.Size = new System.Drawing.Size(116, 23);
            this.uxCopyToClipboard.TabIndex = 4;
            this.uxCopyToClipboard.Text = "Copy to clipboard";
            this.uxCopyToClipboard.UseVisualStyleBackColor = true;
            this.uxCopyToClipboard.Click += new System.EventHandler(this.uxCopyToClipboard_Click);
            // 
            // uxUseCurrentDate
            // 
            this.uxUseCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxUseCurrentDate.Location = new System.Drawing.Point(241, 38);
            this.uxUseCurrentDate.Name = "uxUseCurrentDate";
            this.uxUseCurrentDate.Size = new System.Drawing.Size(109, 23);
            this.uxUseCurrentDate.TabIndex = 2;
            this.uxUseCurrentDate.Text = "Use current";
            this.uxUseCurrentDate.UseVisualStyleBackColor = true;
            this.uxUseCurrentDate.Click += new System.EventHandler(this.uxUseCurrentDate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 223);
            this.Controls.Add(this.uxUseCurrentDate);
            this.Controls.Add(this.uxCopyToClipboard);
            this.Controls.Add(this.uxTimestampLabel);
            this.Controls.Add(this.uxTimestamp);
            this.Controls.Add(this.uxMessage);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxMessageLabel);
            this.Controls.Add(this.uxNameLabel);
            this.Name = "MainForm";
            this.Text = "Skype Quote Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxMessageLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxMessage;
        private System.Windows.Forms.MaskedTextBox uxTimestamp;
        private System.Windows.Forms.Label uxTimestampLabel;
        private System.Windows.Forms.Button uxCopyToClipboard;
        private System.Windows.Forms.Button uxUseCurrentDate;

    }
}
