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
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.aboutQuote = new MaterialSkin.Controls.MaterialLabel();
            this.aboutDescription = new MaterialSkin.Controls.MaterialLabel();
            this.aboutTitle = new MaterialSkin.Controls.MaterialLabel();
            this.DegreesTab = new System.Windows.Forms.TabPage();
            this.degreesRadioButtons = new System.Windows.Forms.GroupBox();
            this.degreeInfo = new System.Windows.Forms.GroupBox();
            this.degreeList = new MaterialSkin.Controls.MaterialLabel();
            this.degreeDescription = new MaterialSkin.Controls.MaterialLabel();
            this.degreeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.minorsTab = new System.Windows.Forms.TabPage();
            this.minorsList = new System.Windows.Forms.GroupBox();
            this.minorInfo = new System.Windows.Forms.GroupBox();
            this.minorCourses = new MaterialSkin.Controls.MaterialLabel();
            this.courses = new System.Windows.Forms.Panel();
            this.minorDescription = new MaterialSkin.Controls.MaterialLabel();
            this.minorName = new MaterialSkin.Controls.MaterialLabel();
            this.employmentTab = new System.Windows.Forms.TabPage();
            this.statisticsBox = new System.Windows.Forms.GroupBox();
            this.employmentBox = new System.Windows.Forms.GroupBox();
            this.ResourcesTab = new System.Windows.Forms.TabPage();
            this.NewsTab = new System.Windows.Forms.TabPage();
            this.ContactTab = new System.Windows.Forms.TabPage();
            this.minorsTa = new System.Windows.Forms.TabPage();
            this.employmentTitle = new System.Windows.Forms.Label();
            this.employmentSubTitle1 = new System.Windows.Forms.Label();
            this.employmentDescription1 = new System.Windows.Forms.Label();
            this.employmentSubtitle2 = new System.Windows.Forms.Label();
            this.employmentDescription2 = new System.Windows.Forms.Label();
            this.statisticsTitle = new System.Windows.Forms.Label();
            this.employmentLink = new System.Windows.Forms.LinkLabel();
            this.coopLink = new System.Windows.Forms.LinkLabel();
            this.Tabs.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.DegreesTab.SuspendLayout();
            this.degreeInfo.SuspendLayout();
            this.minorsTab.SuspendLayout();
            this.minorInfo.SuspendLayout();
            this.employmentTab.SuspendLayout();
            this.statisticsBox.SuspendLayout();
            this.employmentBox.SuspendLayout();
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
            this.TabsSelector.Click += new System.EventHandler(this.TabsSelector_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.AboutTab);
            this.Tabs.Controls.Add(this.DegreesTab);
            this.Tabs.Controls.Add(this.minorsTab);
            this.Tabs.Controls.Add(this.employmentTab);
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
            // degreesRadioButtons
            // 
            this.degreesRadioButtons.Location = new System.Drawing.Point(49, 27);
            this.degreesRadioButtons.Name = "degreesRadioButtons";
            this.degreesRadioButtons.Size = new System.Drawing.Size(523, 583);
            this.degreesRadioButtons.TabIndex = 4;
            this.degreesRadioButtons.TabStop = false;
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
            // minorsList
            // 
            this.minorsList.Location = new System.Drawing.Point(11, 6);
            this.minorsList.Name = "minorsList";
            this.minorsList.Size = new System.Drawing.Size(283, 658);
            this.minorsList.TabIndex = 6;
            this.minorsList.TabStop = false;
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
            // courses
            // 
            this.courses.Location = new System.Drawing.Point(168, 607);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(1113, 40);
            this.courses.TabIndex = 3;
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
            // employmentTab
            // 
            this.employmentTab.Controls.Add(this.statisticsBox);
            this.employmentTab.Controls.Add(this.employmentBox);
            this.employmentTab.Location = new System.Drawing.Point(8, 39);
            this.employmentTab.Name = "employmentTab";
            this.employmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.employmentTab.Size = new System.Drawing.Size(1628, 656);
            this.employmentTab.TabIndex = 3;
            this.employmentTab.Text = "Employment";
            this.employmentTab.UseVisualStyleBackColor = true;
            // 
            // statisticsBox
            // 
            this.statisticsBox.Controls.Add(this.statisticsTitle);
            this.statisticsBox.Location = new System.Drawing.Point(1117, 10);
            this.statisticsBox.Name = "statisticsBox";
            this.statisticsBox.Size = new System.Drawing.Size(496, 640);
            this.statisticsBox.TabIndex = 1;
            this.statisticsBox.TabStop = false;
            // 
            // employmentBox
            // 
            this.employmentBox.Controls.Add(this.coopLink);
            this.employmentBox.Controls.Add(this.employmentLink);
            this.employmentBox.Controls.Add(this.employmentDescription2);
            this.employmentBox.Controls.Add(this.employmentSubtitle2);
            this.employmentBox.Controls.Add(this.employmentDescription1);
            this.employmentBox.Controls.Add(this.employmentSubTitle1);
            this.employmentBox.Controls.Add(this.employmentTitle);
            this.employmentBox.Location = new System.Drawing.Point(21, 3);
            this.employmentBox.Name = "employmentBox";
            this.employmentBox.Size = new System.Drawing.Size(1090, 647);
            this.employmentBox.TabIndex = 0;
            this.employmentBox.TabStop = false;
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
            // employmentTitle
            // 
            this.employmentTitle.Location = new System.Drawing.Point(22, 32);
            this.employmentTitle.Name = "employmentTitle";
            this.employmentTitle.Size = new System.Drawing.Size(992, 53);
            this.employmentTitle.TabIndex = 5;
            this.employmentTitle.Text = "label1";
            // 
            // employmentSubTitle1
            // 
            this.employmentSubTitle1.Location = new System.Drawing.Point(22, 77);
            this.employmentSubTitle1.Name = "employmentSubTitle1";
            this.employmentSubTitle1.Size = new System.Drawing.Size(549, 46);
            this.employmentSubTitle1.TabIndex = 6;
            this.employmentSubTitle1.Text = "label1";
            // 
            // employmentDescription1
            // 
            this.employmentDescription1.Location = new System.Drawing.Point(22, 134);
            this.employmentDescription1.Name = "employmentDescription1";
            this.employmentDescription1.Size = new System.Drawing.Size(1048, 164);
            this.employmentDescription1.TabIndex = 7;
            this.employmentDescription1.Text = "label1";
            // 
            // employmentSubtitle2
            // 
            this.employmentSubtitle2.Location = new System.Drawing.Point(22, 319);
            this.employmentSubtitle2.Name = "employmentSubtitle2";
            this.employmentSubtitle2.Size = new System.Drawing.Size(563, 44);
            this.employmentSubtitle2.TabIndex = 8;
            this.employmentSubtitle2.Text = "label1";
            // 
            // employmentDescription2
            // 
            this.employmentDescription2.Location = new System.Drawing.Point(22, 373);
            this.employmentDescription2.Name = "employmentDescription2";
            this.employmentDescription2.Size = new System.Drawing.Size(1048, 261);
            this.employmentDescription2.TabIndex = 9;
            this.employmentDescription2.Text = "label1";
            // 
            // statisticsTitle
            // 
            this.statisticsTitle.Location = new System.Drawing.Point(16, 25);
            this.statisticsTitle.Name = "statisticsTitle";
            this.statisticsTitle.Size = new System.Drawing.Size(437, 53);
            this.statisticsTitle.TabIndex = 0;
            this.statisticsTitle.Text = "label1";
            // 
            // employmentLink
            // 
            this.employmentLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employmentLink.Location = new System.Drawing.Point(831, 77);
            this.employmentLink.Name = "employmentLink";
            this.employmentLink.Size = new System.Drawing.Size(220, 46);
            this.employmentLink.TabIndex = 10;
            this.employmentLink.TabStop = true;
            this.employmentLink.Text = "Employer Table";
            // 
            // coopLink
            // 
            this.coopLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coopLink.Location = new System.Drawing.Point(877, 317);
            this.coopLink.Name = "coopLink";
            this.coopLink.Size = new System.Drawing.Size(174, 46);
            this.coopLink.TabIndex = 11;
            this.coopLink.TabStop = true;
            this.coopLink.Text = "Co-op Table";
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
            this.Tabs.ResumeLayout(false);
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.DegreesTab.ResumeLayout(false);
            this.degreeInfo.ResumeLayout(false);
            this.minorsTab.ResumeLayout(false);
            this.minorInfo.ResumeLayout(false);
            this.employmentTab.ResumeLayout(false);
            this.statisticsBox.ResumeLayout(false);
            this.employmentBox.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage employmentTab;
        private System.Windows.Forms.TabPage ResourcesTab;
        private System.Windows.Forms.TabPage NewsTab;
        private System.Windows.Forms.TabPage ContactTab;
        private System.Windows.Forms.TabPage minorsTa;
        private System.Windows.Forms.Panel courses;
        private System.Windows.Forms.GroupBox statisticsBox;
        private System.Windows.Forms.GroupBox employmentBox;
        private System.Windows.Forms.Label employmentTitle;
        private System.Windows.Forms.Label employmentDescription2;
        private System.Windows.Forms.Label employmentSubtitle2;
        private System.Windows.Forms.Label employmentDescription1;
        private System.Windows.Forms.Label employmentSubTitle1;
        private System.Windows.Forms.Label statisticsTitle;
        private System.Windows.Forms.LinkLabel employmentLink;
        private System.Windows.Forms.LinkLabel coopLink;
    }
}

