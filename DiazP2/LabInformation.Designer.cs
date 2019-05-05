namespace DiazP2
{
    partial class LabInformation
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
            this.tutoringLabel = new System.Windows.Forms.Label();
            this.tutoringDescription = new System.Windows.Forms.Label();
            this.tutoringLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tutoringLabel
            // 
            this.tutoringLabel.AutoSize = true;
            this.tutoringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutoringLabel.Location = new System.Drawing.Point(23, 27);
            this.tutoringLabel.Name = "tutoringLabel";
            this.tutoringLabel.Size = new System.Drawing.Size(92, 31);
            this.tutoringLabel.TabIndex = 0;
            this.tutoringLabel.Text = "label1";
            // 
            // tutoringDescription
            // 
            this.tutoringDescription.Location = new System.Drawing.Point(24, 96);
            this.tutoringDescription.Name = "tutoringDescription";
            this.tutoringDescription.Size = new System.Drawing.Size(988, 152);
            this.tutoringDescription.TabIndex = 1;
            this.tutoringDescription.Text = "label1";
            // 
            // tutoringLink
            // 
            this.tutoringLink.AutoSize = true;
            this.tutoringLink.Location = new System.Drawing.Point(24, 223);
            this.tutoringLink.Name = "tutoringLink";
            this.tutoringLink.Size = new System.Drawing.Size(196, 25);
            this.tutoringLink.TabIndex = 2;
            this.tutoringLink.TabStop = true;
            this.tutoringLink.Text = "Tutoring Lab Hours";
            // 
            // LabInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 283);
            this.Controls.Add(this.tutoringLink);
            this.Controls.Add(this.tutoringDescription);
            this.Controls.Add(this.tutoringLabel);
            this.Name = "LabInformation";
            this.Text = "LabInformation";
            this.Load += new System.EventHandler(this.LabInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tutoringLabel;
        private System.Windows.Forms.Label tutoringDescription;
        private System.Windows.Forms.LinkLabel tutoringLink;
    }
}