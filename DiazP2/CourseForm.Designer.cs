namespace DiazP2
{
    partial class CourseForm
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
            this.courseName = new MaterialSkin.Controls.MaterialLabel();
            this.courseDescription = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.Depth = 0;
            this.courseName.Font = new System.Drawing.Font("Roboto", 11F);
            this.courseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseName.Location = new System.Drawing.Point(24, 53);
            this.courseName.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(972, 59);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "materialLabel1";
            // 
            // courseDescription
            // 
            this.courseDescription.Depth = 0;
            this.courseDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.courseDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseDescription.Location = new System.Drawing.Point(24, 112);
            this.courseDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Size = new System.Drawing.Size(1153, 496);
            this.courseDescription.TabIndex = 1;
            this.courseDescription.Text = "materialLabel2";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 636);
            this.Controls.Add(this.courseDescription);
            this.Controls.Add(this.courseName);
            this.Name = "CourseForm";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel courseName;
        private MaterialSkin.Controls.MaterialLabel courseDescription;
    }
}