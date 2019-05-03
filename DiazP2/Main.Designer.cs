using MaterialSkin;
using MaterialSkin.Controls;

namespace DiazP2
{
    partial class Main
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
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.aboutQuote = new MaterialSkin.Controls.MaterialLabel();
            this.aboutDescription = new MaterialSkin.Controls.MaterialLabel();
            this.aboutTitle = new MaterialSkin.Controls.MaterialLabel();
            this.TabsSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.DegreesTab = new System.Windows.Forms.TabPage();
            this.degreesRadioButtons = new System.Windows.Forms.GroupBox();
            this.degreeInfo = new System.Windows.Forms.GroupBox();
            this.EmploymentTab = new System.Windows.Forms.TabPage();
            this.PeopleTab = new System.Windows.Forms.TabPage();
            this.ResourcesTab = new System.Windows.Forms.TabPage();
            this.NewsTab = new System.Windows.Forms.TabPage();
            this.ContactTab = new System.Windows.Forms.TabPage();
            this.degreeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.degreeDescription = new MaterialSkin.Controls.MaterialLabel();
            this.degreeList = new MaterialSkin.Controls.MaterialLabel();
            this.AboutTab.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.DegreesTab.SuspendLayout();
            this.degreeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.aboutQuote);
            this.AboutTab.Controls.Add(this.aboutDescription);
            this.AboutTab.Controls.Add(this.aboutTitle);
            this.AboutTab.Location = new System.Drawing.Point(8, 39);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(1371, 656);
            this.AboutTab.TabIndex = 0;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // aboutQuote
            // 
            this.aboutQuote.AutoSize = true;
            this.aboutQuote.Depth = 0;
            this.aboutQuote.Font = new System.Drawing.Font("Roboto", 11F);
            this.aboutQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutQuote.Location = new System.Drawing.Point(30, 425);
            this.aboutQuote.MaximumSize = new System.Drawing.Size(1300, 300);
            this.aboutQuote.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutQuote.Name = "aboutQuote";
            this.aboutQuote.Size = new System.Drawing.Size(214, 37);
            this.aboutQuote.TabIndex = 2;
            this.aboutQuote.Text = "materialLabel1";
            // 
            // aboutDescription
            // 
            this.aboutDescription.AutoSize = true;
            this.aboutDescription.Depth = 0;
            this.aboutDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.aboutDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutDescription.Location = new System.Drawing.Point(30, 132);
            this.aboutDescription.MaximumSize = new System.Drawing.Size(1300, 300);
            this.aboutDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(214, 37);
            this.aboutDescription.TabIndex = 1;
            this.aboutDescription.Text = "materialLabel1";
            // 
            // aboutTitle
            // 
            this.aboutTitle.AutoSize = true;
            this.aboutTitle.Depth = 0;
            this.aboutTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.aboutTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutTitle.Location = new System.Drawing.Point(26, 30);
            this.aboutTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutTitle.Name = "aboutTitle";
            this.aboutTitle.Size = new System.Drawing.Size(214, 37);
            this.aboutTitle.TabIndex = 0;
            this.aboutTitle.Text = "materialLabel1";
            // 
            // TabsSelector
            // 
            this.TabsSelector.BaseTabControl = this.Tabs;
            this.TabsSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabsSelector.Depth = 0;
            this.TabsSelector.Location = new System.Drawing.Point(-1, 122);
            this.TabsSelector.Margin = new System.Windows.Forms.Padding(0);
            this.TabsSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabsSelector.Name = "TabsSelector";
            this.TabsSelector.Size = new System.Drawing.Size(1485, 57);
            this.TabsSelector.TabIndex = 1;
            this.TabsSelector.Text = "materialTabSelector1";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.AboutTab);
            this.Tabs.Controls.Add(this.DegreesTab);
            this.Tabs.Controls.Add(this.EmploymentTab);
            this.Tabs.Controls.Add(this.PeopleTab);
            this.Tabs.Controls.Add(this.ResourcesTab);
            this.Tabs.Controls.Add(this.NewsTab);
            this.Tabs.Controls.Add(this.ContactTab);
            this.Tabs.Depth = 0;
            this.Tabs.Location = new System.Drawing.Point(18, 206);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1387, 703);
            this.Tabs.TabIndex = 2;
            // 
            // DegreesTab
            // 
            this.DegreesTab.AutoScroll = true;
            this.DegreesTab.Controls.Add(this.degreesRadioButtons);
            this.DegreesTab.Controls.Add(this.degreeInfo);
            this.DegreesTab.Location = new System.Drawing.Point(8, 39);
            this.DegreesTab.Name = "DegreesTab";
            this.DegreesTab.Padding = new System.Windows.Forms.Padding(3);
            this.DegreesTab.Size = new System.Drawing.Size(1371, 656);
            this.DegreesTab.TabIndex = 0;
            this.DegreesTab.Text = "Degrees";
            this.DegreesTab.UseVisualStyleBackColor = true;
            // 
            // degreesRadioButtons
            // 
            this.degreesRadioButtons.Location = new System.Drawing.Point(49, 27);
            this.degreesRadioButtons.Name = "degreesRadioButtons";
            this.degreesRadioButtons.Size = new System.Drawing.Size(603, 583);
            this.degreesRadioButtons.TabIndex = 4;
            this.degreesRadioButtons.TabStop = false;
            // 
            // degreeInfo
            // 
            this.degreeInfo.Controls.Add(this.degreeList);
            this.degreeInfo.Controls.Add(this.degreeDescription);
            this.degreeInfo.Controls.Add(this.degreeTitle);
            this.degreeInfo.Location = new System.Drawing.Point(705, 27);
            this.degreeInfo.Name = "degreeInfo";
            this.degreeInfo.Size = new System.Drawing.Size(611, 583);
            this.degreeInfo.TabIndex = 3;
            this.degreeInfo.TabStop = false;
            // 
            // EmploymentTab
            // 
            this.EmploymentTab.Location = new System.Drawing.Point(8, 39);
            this.EmploymentTab.Name = "EmploymentTab";
            this.EmploymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmploymentTab.Size = new System.Drawing.Size(1371, 656);
            this.EmploymentTab.TabIndex = 1;
            this.EmploymentTab.Text = "Employment";
            this.EmploymentTab.UseVisualStyleBackColor = true;
            // 
            // PeopleTab
            // 
            this.PeopleTab.Location = new System.Drawing.Point(8, 39);
            this.PeopleTab.Name = "PeopleTab";
            this.PeopleTab.Padding = new System.Windows.Forms.Padding(3);
            this.PeopleTab.Size = new System.Drawing.Size(1371, 656);
            this.PeopleTab.TabIndex = 2;
            this.PeopleTab.Text = "People";
            this.PeopleTab.UseVisualStyleBackColor = true;
            // 
            // ResourcesTab
            // 
            this.ResourcesTab.Location = new System.Drawing.Point(8, 39);
            this.ResourcesTab.Name = "ResourcesTab";
            this.ResourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResourcesTab.Size = new System.Drawing.Size(1371, 656);
            this.ResourcesTab.TabIndex = 3;
            this.ResourcesTab.Text = "Resources";
            this.ResourcesTab.UseVisualStyleBackColor = true;
            // 
            // NewsTab
            // 
            this.NewsTab.Location = new System.Drawing.Point(8, 39);
            this.NewsTab.Name = "NewsTab";
            this.NewsTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewsTab.Size = new System.Drawing.Size(1371, 656);
            this.NewsTab.TabIndex = 4;
            this.NewsTab.Text = "News";
            this.NewsTab.UseVisualStyleBackColor = true;
            // 
            // ContactTab
            // 
            this.ContactTab.Location = new System.Drawing.Point(8, 39);
            this.ContactTab.Name = "ContactTab";
            this.ContactTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContactTab.Size = new System.Drawing.Size(1371, 656);
            this.ContactTab.TabIndex = 5;
            this.ContactTab.Text = "Contact ";
            this.ContactTab.UseVisualStyleBackColor = true;
            // 
            // degreeTitle
            // 
            this.degreeTitle.Depth = 0;
            this.degreeTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.degreeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.degreeTitle.Location = new System.Drawing.Point(30, 38);
            this.degreeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.degreeTitle.Name = "degreeTitle";
            this.degreeTitle.Size = new System.Drawing.Size(575, 55);
            this.degreeTitle.TabIndex = 0;
            this.degreeTitle.Text = "materialLabel1";
            this.degreeTitle.Visible = false;
            // 
            // degreeDescription
            // 
            this.degreeDescription.Depth = 0;
            this.degreeDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.degreeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.degreeDescription.Location = new System.Drawing.Point(30, 84);
            this.degreeDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.degreeDescription.Name = "degreeDescription";
            this.degreeDescription.Size = new System.Drawing.Size(575, 220);
            this.degreeDescription.TabIndex = 1;
            this.degreeDescription.Text = "materialLabel1";
            this.degreeDescription.Visible = false;
            // 
            // degreeList
            // 
            this.degreeList.Depth = 0;
            this.degreeList.Font = new System.Drawing.Font("Roboto", 11F);
            this.degreeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.degreeList.Location = new System.Drawing.Point(30, 302);
            this.degreeList.MouseState = MaterialSkin.MouseState.HOVER;
            this.degreeList.Name = "degreeList";
            this.degreeList.Size = new System.Drawing.Size(563, 263);
            this.degreeList.TabIndex = 2;
            this.degreeList.Text = "materialLabel1";
            this.degreeList.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1417, 921);
            this.Controls.Add(this.TabsSelector);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.Text = "INFORMATION SCIENCES & TECHNOLOGIES @ RIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.DegreesTab.ResumeLayout(false);
            this.degreeInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage AboutTab;
        private MaterialTabSelector TabsSelector;
        private MaterialTabControl Tabs;
        private System.Windows.Forms.TabPage DegreesTab;
        private System.Windows.Forms.TabPage EmploymentTab;
        private System.Windows.Forms.TabPage PeopleTab;
        private System.Windows.Forms.TabPage ResourcesTab;
        private System.Windows.Forms.TabPage NewsTab;
        private System.Windows.Forms.TabPage ContactTab;
        private MaterialLabel aboutTitle;
        private MaterialLabel aboutQuote;
        private MaterialLabel aboutDescription;
        private System.Windows.Forms.GroupBox degreesRadioButtons;
        private System.Windows.Forms.GroupBox degreeInfo;
        private MaterialLabel degreeTitle;
        private MaterialLabel degreeDescription;
        private MaterialLabel degreeList;
    }
}

