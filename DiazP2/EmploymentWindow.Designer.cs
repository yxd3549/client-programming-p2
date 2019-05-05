namespace DiazP2
{
    partial class EmploymentWindow
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.tableTitle = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(13, 62);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowTemplate.Height = 33;
            this.dataTable.Size = new System.Drawing.Size(1040, 549);
            this.dataTable.TabIndex = 0;
            // 
            // tableTitle
            // 
            this.tableTitle.AutoSize = true;
            this.tableTitle.Depth = 0;
            this.tableTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.tableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableTitle.Location = new System.Drawing.Point(13, 13);
            this.tableTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableTitle.Name = "tableTitle";
            this.tableTitle.Size = new System.Drawing.Size(214, 37);
            this.tableTitle.TabIndex = 1;
            this.tableTitle.Text = "materialLabel1";
            // 
            // EmploymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 640);
            this.Controls.Add(this.tableTitle);
            this.Controls.Add(this.dataTable);
            this.Name = "EmploymentWindow";
            this.Text = "EmploymentWindow";
            this.Load += new System.EventHandler(this.EmploymentWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private MaterialSkin.Controls.MaterialLabel tableTitle;
    }
}