namespace DiazP2
{
    partial class ResearchForm
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
            this.researchFormTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // researchFormTitle
            // 
            this.researchFormTitle.AutoSize = true;
            this.researchFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchFormTitle.Location = new System.Drawing.Point(36, 28);
            this.researchFormTitle.Name = "researchFormTitle";
            this.researchFormTitle.Size = new System.Drawing.Size(92, 31);
            this.researchFormTitle.TabIndex = 0;
            this.researchFormTitle.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1284, 732);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ResearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 890);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.researchFormTitle);
            this.Name = "ResearchForm";
            this.Text = "ResearchForm";
            this.Load += new System.EventHandler(this.ResearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label researchFormTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}