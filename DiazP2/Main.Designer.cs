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
            this.TabsSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.minorsTa = new System.Windows.Forms.TabPage();
            this.ContactTab = new System.Windows.Forms.TabPage();
            this.NewsTab = new System.Windows.Forms.TabPage();
            this.ResourcesTab = new System.Windows.Forms.TabPage();
            this.PeopleTab = new System.Windows.Forms.TabPage();
            this.minorsTab = new System.Windows.Forms.TabPage();
            this.minorInfo = new System.Windows.Forms.GroupBox();
            this.minorName = new MaterialSkin.Controls.MaterialLabel();
            this.minorDescription = new MaterialSkin.Controls.MaterialLabel();
            this.minorCourses = new MaterialSkin.Controls.MaterialLabel();
            this.minorsList = new System.Windows.Forms.GroupBox();
            this.DegreesTab = new System.Windows.Forms.TabPage();
            this.degreeInfo = new System.Windows.Forms.GroupBox();
            this.degreeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.degreeDescription = new MaterialSkin.Controls.MaterialLabel();
            this.degreeList = new MaterialSkin.Controls.MaterialLabel();
            this.degreesRadioButtons = new System.Windows.Forms.GroupBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.aboutTitle = new MaterialSkin.Controls.MaterialLabel();
            this.aboutDescription = new MaterialSkin.Controls.MaterialLabel();
            this.aboutQuote = new MaterialSkin.Controls.MaterialLabel();
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.courses = new System.Windows.Forms.Panel();
            this.minorsTab.SuspendLayout();
            this.minorInfo.SuspendLayout();
            this.DegreesTab.SuspendLayout();
            this.degreeInfo.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
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
            this.TabsSelector.Size = new System.Drawing.Size(1675, 57);
            this.TabsSelector.TabIndex = 1;
            this.TabsSelector.Text = "materialTabSelector1";
            // 
            // minorsTa
            // 
            this.minorsTa.Location = new System.Drawing.Point(8, 39);
            this.minorsTa.Name = "minorsTa";
            this.minorsTa.Padding = new System.Windows.Forms.Padding(3);
            this.minorsTa.Size = new System.Drawing.Size(1628, 656);
            this.minorsTa.TabIndex = 3;
            this.minorsTa.Text = "Minors";
            this.minorsTa.UseVisualStyleBackColor = true;
            // 
            // ContactTab
            // 
            this.ContactTab.Location = new System.Drawing.Point(8, 39);
            this.ContactTab.Name = "ContactTab";
            this.ContactTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContactTab.Size = new System.Drawing.Size(1628, 656);
            this.ContactTab.TabIndex = 6;
            this.ContactTab.Text = "Contact ";
            this.ContactTab.UseVisualStyleBackColor = true;
            // 
            // NewsTab
            // 
            this.NewsTab.Location = new System.Drawing.Point(8, 39);
            this.NewsTab.Name = "NewsTab";
            this.NewsTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewsTab.Size = new System.Drawing.Size(1628, 656);
            this.NewsTab.TabIndex = 5;
            this.NewsTab.Text = "News";
            this.NewsTab.UseVisualStyleBackColor = true;
            // 
            // ResourcesTab
            // 
            this.ResourcesTab.Location = new System.Drawing.Point(8, 39);
            this.ResourcesTab.Name = "ResourcesTab";
            this.ResourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResourcesTab.Size = new System.Drawing.Size(1628, 656);
            this.ResourcesTab.TabIndex = 4;
            this.ResourcesTab.Text = "Resources";
            this.ResourcesTab.UseVisualStyleBackColor = true;
            // 
            // PeopleTab
            // 
            this.PeopleTab.Location = new System.Drawing.Point(8, 39);
            this.PeopleTab.Name = "PeopleTab";
            this.PeopleTab.Padding = new System.Windows.Forms.Padding(3);
            this.PeopleTab.Size = new System.Drawing.Size(1628, 656);
            this.PeopleTab.TabIndex = 3;
            this.PeopleTab.Text = "People";
            this.PeopleTab.UseVisualStyleBackColor = true;
            // 
            // minorsTab
            // 
            this.minorsTab.Controls.Add(this.minorsList);
            this.minorsTab.Controls.Add(this.minorInfo);
            this.minorsTab.Location = new System.Drawing.Point(8, 39);
            this.minorsTab.Name = "minorsTab";
            this.minorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.minorsTab.Size = new System.Drawing.Size(1628, 656);
            this.minorsTab.TabIndex = 1;
            this.minorsTab.Text = "Minors";
            this.minorsTab.UseVisualStyleBackColor = true;
            // 
            // minorInfo
            // 
            this.minorInfo.Controls.Add(this.minorCourses);
            this.minorInfo.Controls.Add(this.courses);
            this.minorInfo.Controls.Add(this.minorDescription);
            this.minorInfo.Controls.Add(this.minorName);
            this.minorInfo.Location = new System.Drawing.Point(300, 6);
            this.minorInfo.Name = "minorInfo";
            this.minorInfo.Size = new System.Drawing.Size(1322, 658);
            this.minorInfo.TabIndex = 5;
            this.minorInfo.TabStop = false;
            // 
            // minorName
            // 
            this.minorName.Depth = 0;
            this.minorName.Font = new System.Drawing.Font("Roboto", 11F);
            this.minorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minorName.Location = new System.Drawing.Point(30, 37);
            this.minorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.minorName.Name = "minorName";
            this.minorName.Size = new System.Drawing.Size(1009, 63);
            this.minorName.TabIndex = 0;
            this.minorName.Text = "materialLabel1";
            this.minorName.Visible = false;
            // 
            // minorDescription
            // 
            this.minorDescription.Depth = 0;
            this.minorDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.minorDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minorDescription.Location = new System.Drawing.Point(30, 90);
            this.minorDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.minorDescription.Name = "minorDescription";
            this.minorDescription.Size = new System.Drawing.Size(1286, 513);
            this.minorDescription.TabIndex = 1;
            this.minorDescription.Text = "materialLabel1";
            this.minorDescription.Visible = false;
            // 
            // minorCourses
            // 
            this.minorCourses.Depth = 0;
            this.minorCourses.Font = new System.Drawing.Font("Roboto", 11F);
            this.minorCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minorCourses.Location = new System.Drawing.Point(30, 603);
            this.minorCourses.MouseState = MaterialSkin.MouseState.HOVER;
            this.minorCourses.Name = "minorCourses";
            this.minorCourses.Size = new System.Drawing.Size(162, 44);
            this.minorCourses.TabIndex = 2;
            this.minorCourses.Text = "Courses:";
            this.minorCourses.Visible = false;
            // 
            // minorsList
            // 
            this.minorsList.Location = new System.Drawing.Point(11, 6);
            this.minorsList.Name = "minorsList";
            this.minorsList.Size = new System.Drawing.Size(283, 658);
            this.minorsList.TabIndex = 6;
            this.minorsList.TabStop = false;
            // 
            // DegreesTab
            // 
            this.DegreesTab.AutoScroll = true;
            this.DegreesTab.Controls.Add(this.degreesRadioButtons);
            this.DegreesTab.Controls.Add(this.degreeInfo);
            this.DegreesTab.Location = new System.Drawing.Point(8, 39);
            this.DegreesTab.Name = "DegreesTab";
            this.DegreesTab.Padding = new System.Windows.Forms.Padding(3);
            this.DegreesTab.Size = new System.Drawing.Size(1628, 656);
            this.DegreesTab.TabIndex = 0;
            this.DegreesTab.Text = "Degrees";
            this.DegreesTab.UseVisualStyleBackColor = true;
            // 
            // degreeInfo
            // 
            this.degreeInfo.Controls.Add(this.degreeList);
            this.degreeInfo.Controls.Add(this.degreeDescription);
            this.degreeInfo.Controls.Add(this.degreeTitle);
            this.degreeInfo.Location = new System.Drawing.Point(593, 27);
            this.degreeInfo.Name = "degreeInfo";
            this.degreeInfo.Size = new System.Drawing.Size(971, 583);
            this.degreeInfo.TabIndex = 3;
            this.degreeInfo.TabStop = false;
            // 
            // degreeTitle
            // 
            this.degreeTitle.Depth = 0;
            this.degreeTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.degreeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.degreeTitle.Location = new System.Drawing.Point(30, 38);
            this.degreeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.degreeTitle.Name = "degreeTitle";
            this.degreeTitle.Size = new System.Drawing.Size(909, 55);
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
            this.degreeDescription.Size = new System.Drawing.Size(909, 122);
            this.degreeDescription.TabIndex = 1;
            this.degreeDescription.Text = "materialLabel1";
            this.degreeDescription.Visible = false;
            // 
            // degreeList
            // 
            this.degreeList.Depth = 0;
            this.degreeList.Font = new System.Drawing.Font("Roboto", 11F);
            this.degreeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.degreeList.Location = new System.Drawing.Point(30, 206);
            this.degreeList.MouseState = MaterialSkin.MouseState.HOVER;
            this.degreeList.Name = "degreeList";
            this.degreeList.Size = new System.Drawing.Size(909, 263);
            this.degreeList.TabIndex = 2;
            this.degreeList.Text = "materialLabel1";
            this.degreeList.Visible = false;
            // 
            // degreesRadioButtons
            // 
            this.degreesRadioButtons.Location = new System.Drawing.Point(49, 27);
            this.degreesRadioButtons.Name = "degreesRadioButtons";
            this.degreesRadioButtons.Size = new System.Drawing.Size(523, 583);
            this.degreesRadioButtons.TabIndex = 4;
            this.degreesRadioButtons.TabStop = false;
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.aboutQuote);
            this.AboutTab.Controls.Add(this.aboutDescription);
            this.AboutTab.Controls.Add(this.aboutTitle);
            this.AboutTab.Location = new System.Drawing.Point(8, 39);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(1628, 656);
            this.AboutTab.TabIndex = 0;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
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
            // aboutDescription
            // 
            this.aboutDescription.Depth = 0;
            this.aboutDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.aboutDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutDescription.Location = new System.Drawing.Point(26, 85);
            this.aboutDescription.MaximumSize = new System.Drawing.Size(1500, 300);
            this.aboutDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Size = new System.Drawing.Size(1500, 248);
            this.aboutDescription.TabIndex = 1;
            this.aboutDescription.Text = "materialLabel1";
            // 
            // aboutQuote
            // 
            this.aboutQuote.Depth = 0;
            this.aboutQuote.Font = new System.Drawing.Font("Roboto", 11F);
            this.aboutQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aboutQuote.Location = new System.Drawing.Point(26, 333);
            this.aboutQuote.MaximumSize = new System.Drawing.Size(1500, 300);
            this.aboutQuote.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutQuote.Name = "aboutQuote";
            this.aboutQuote.Size = new System.Drawing.Size(1500, 203);
            this.aboutQuote.TabIndex = 2;
            this.aboutQuote.Text = "materialLabel1";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.AboutTab);
            this.Tabs.Controls.Add(this.DegreesTab);
            this.Tabs.Controls.Add(this.minorsTab);
            this.Tabs.Controls.Add(this.PeopleTab);
            this.Tabs.Controls.Add(this.ResourcesTab);
            this.Tabs.Controls.Add(this.NewsTab);
            this.Tabs.Controls.Add(this.ContactTab);
            this.Tabs.Controls.Add(this.minorsTa);
            this.Tabs.Depth = 0;
            this.Tabs.Location = new System.Drawing.Point(18, 206);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1644, 703);
            this.Tabs.TabIndex = 2;
            // 
            // courses
            // 
            this.courses.Location = new System.Drawing.Point(168, 607);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(1113, 40);
            this.courses.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1674, 921);
            this.Controls.Add(this.TabsSelector);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.Text = "INFORMATION SCIENCES & TECHNOLOGIES @ RIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.minorsTab.ResumeLayout(false);
            this.minorInfo.ResumeLayout(false);
            this.DegreesTab.ResumeLayout(false);
            this.degreeInfo.ResumeLayout(false);
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabSelector TabsSelector;
        private MaterialTabControl Tabs;
        private System.Windows.Forms.TabPage AboutTab;
        private MaterialLabel aboutQuote;
        private MaterialLabel aboutDescription;
        private MaterialLabel aboutTitle;
        private System.Windows.Forms.TabPage DegreesTab;
        private System.Windows.Forms.GroupBox degreesRadioButtons;
        private System.Windows.Forms.GroupBox degreeInfo;
        private MaterialLabel degreeList;
        private MaterialLabel degreeDescription;
        private MaterialLabel degreeTitle;
        private System.Windows.Forms.TabPage minorsTab;
        private System.Windows.Forms.GroupBox minorsList;
        private System.Windows.Forms.GroupBox minorInfo;
        private MaterialLabel minorCourses;
        private MaterialLabel minorDescription;
        private MaterialLabel minorName;
        private System.Windows.Forms.TabPage PeopleTab;
        private System.Windows.Forms.TabPage ResourcesTab;
        private System.Windows.Forms.TabPage NewsTab;
        private System.Windows.Forms.TabPage ContactTab;
        private System.Windows.Forms.TabPage minorsTa;
        private System.Windows.Forms.Panel courses;
    }
}

