namespace DiazP2
{
    partial class CoopEnrollmentForm
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
            this.coopTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // coopTitle
            // 
            this.coopTitle.AutoSize = true;
            this.coopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coopTitle.Location = new System.Drawing.Point(29, 38);
            this.coopTitle.Name = "coopTitle";
            this.coopTitle.Size = new System.Drawing.Size(92, 31);
            this.coopTitle.TabIndex = 0;
            this.coopTitle.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1196, 813);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CoopEnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 995);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.coopTitle);
            this.Name = "CoopEnrollmentForm";
            this.Text = "CoopEnrollmentForm";
            this.Load += new System.EventHandler(this.CoopEnrollmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coopTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}