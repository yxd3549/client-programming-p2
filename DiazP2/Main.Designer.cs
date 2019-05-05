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
            this.statisticsTitle = new System.Windows.Forms.Label();
            this.employmentBox = new System.Windows.Forms.GroupBox();
            this.coopLink = new System.Windows.Forms.LinkLabel();
            this.employmentLink = new System.Windows.Forms.LinkLabel();
            this.employmentDescription2 = new System.Windows.Forms.Label();
            this.employmentSubtitle2 = new System.Windows.Forms.Label();
            this.employmentDescription1 = new System.Windows.Forms.Label();
            this.employmentSubTitle1 = new System.Windows.Forms.Label();
            this.employmentTitle = new System.Windows.Forms.Label();
            this.PeopleTab = new System.Windows.Forms.TabPage();
            this.researchTab = new System.Windows.Forms.TabPage();
            this.resourcesTab = new System.Windows.Forms.TabPage();
            this.minorsTa = new System.Windows.Forms.TabPage();
            this.peoplePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.personData = new System.Windows.Forms.GroupBox();
            this.personPicture = new System.Windows.Forms.PictureBox();
            this.peopleTitle = new System.Windows.Forms.Label();
            this.personName = new System.Windows.Forms.Label();
            this.personTitle = new System.Windows.Forms.Label();
            this.interestAreas = new System.Windows.Forms.Label();
            this.officeL = new System.Windows.Forms.Label();
            this.emailL = new System.Windows.Forms.Label();
            this.phoneL = new System.Windows.Forms.Label();
            this.websiteL = new System.Windows.Forms.Label();
            this.twitterL = new System.Windows.Forms.Label();
            this.facebookL = new System.Windows.Forms.Label();
            this.researchTitle = new System.Windows.Forms.Label();
            this.byInterestPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.byFacultyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.byAreaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resourcesTitle = new System.Windows.Forms.Label();
            this.studyAbroadLink = new System.Windows.Forms.LinkLabel();
            this.subtitleResources = new System.Windows.Forms.Label();
            this.studentServicesLink = new System.Windows.Forms.LinkLabel();
            this.labsLink = new System.Windows.Forms.LinkLabel();
            this.ambassadorsLink = new System.Windows.Forms.LinkLabel();
            this.coopEnrollmentLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formsFlowPlane = new System.Windows.Forms.FlowLayoutPanel();
            this.Tabs.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.DegreesTab.SuspendLayout();
            this.degreeInfo.SuspendLayout();
            this.minorsTab.SuspendLayout();
            this.minorInfo.SuspendLayout();
            this.employmentTab.SuspendLayout();
            this.statisticsBox.SuspendLayout();
            this.employmentBox.SuspendLayout();
            this.PeopleTab.SuspendLayout();
            this.researchTab.SuspendLayout();
            this.resourcesTab.SuspendLayout();
            this.personData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // Tabs
            // 
            this.Tabs.Controls.Add(this.AboutTab);
            this.Tabs.Controls.Add(this.DegreesTab);
            this.Tabs.Controls.Add(this.minorsTab);
            this.Tabs.Controls.Add(this.employmentTab);
            this.Tabs.Controls.Add(this.PeopleTab);
            this.Tabs.Controls.Add(this.researchTab);
            this.Tabs.Controls.Add(this.resourcesTab);
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
            this.degreesRadioButtons.Location = new System.Drawing.Point(30, 27);
            this.degreesRadioButtons.Name = "degreesRadioButtons";
            this.degreesRadioButtons.Size = new System.Drawing.Size(542, 594);
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
            this.degreeInfo.Size = new System.Drawing.Size(1014, 584);
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
            // statisticsTitle
            // 
            this.statisticsTitle.Location = new System.Drawing.Point(16, 25);
            this.statisticsTitle.Name = "statisticsTitle";
            this.statisticsTitle.Size = new System.Drawing.Size(437, 53);
            this.statisticsTitle.TabIndex = 0;
            this.statisticsTitle.Text = "label1";
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
            // employmentDescription2
            // 
            this.employmentDescription2.Location = new System.Drawing.Point(22, 373);
            this.employmentDescription2.Name = "employmentDescription2";
            this.employmentDescription2.Size = new System.Drawing.Size(1048, 261);
            this.employmentDescription2.TabIndex = 9;
            this.employmentDescription2.Text = "label1";
            // 
            // employmentSubtitle2
            // 
            this.employmentSubtitle2.Location = new System.Drawing.Point(22, 319);
            this.employmentSubtitle2.Name = "employmentSubtitle2";
            this.employmentSubtitle2.Size = new System.Drawing.Size(563, 44);
            this.employmentSubtitle2.TabIndex = 8;
            this.employmentSubtitle2.Text = "label1";
            // 
            // employmentDescription1
            // 
            this.employmentDescription1.Location = new System.Drawing.Point(22, 134);
            this.employmentDescription1.Name = "employmentDescription1";
            this.employmentDescription1.Size = new System.Drawing.Size(1048, 164);
            this.employmentDescription1.TabIndex = 7;
            this.employmentDescription1.Text = "label1";
            // 
            // employmentSubTitle1
            // 
            this.employmentSubTitle1.Location = new System.Drawing.Point(22, 77);
            this.employmentSubTitle1.Name = "employmentSubTitle1";
            this.employmentSubTitle1.Size = new System.Drawing.Size(549, 46);
            this.employmentSubTitle1.TabIndex = 6;
            this.employmentSubTitle1.Text = "label1";
            // 
            // employmentTitle
            // 
            this.employmentTitle.Location = new System.Drawing.Point(22, 32);
            this.employmentTitle.Name = "employmentTitle";
            this.employmentTitle.Size = new System.Drawing.Size(992, 53);
            this.employmentTitle.TabIndex = 5;
            this.employmentTitle.Text = "label1";
            // 
            // PeopleTab
            // 
            this.PeopleTab.Controls.Add(this.peopleTitle);
            this.PeopleTab.Controls.Add(this.personData);
            this.PeopleTab.Controls.Add(this.peoplePanel);
            this.PeopleTab.Location = new System.Drawing.Point(8, 39);
            this.PeopleTab.Name = "PeopleTab";
            this.PeopleTab.Padding = new System.Windows.Forms.Padding(3);
            this.PeopleTab.Size = new System.Drawing.Size(1628, 656);
            this.PeopleTab.TabIndex = 4;
            this.PeopleTab.Text = "People";
            this.PeopleTab.UseVisualStyleBackColor = true;
            // 
            // researchTab
            // 
            this.researchTab.Controls.Add(this.label1);
            this.researchTab.Controls.Add(this.byAreaLabel);
            this.researchTab.Controls.Add(this.byFacultyPanel);
            this.researchTab.Controls.Add(this.byInterestPanel);
            this.researchTab.Controls.Add(this.researchTitle);
            this.researchTab.Location = new System.Drawing.Point(8, 39);
            this.researchTab.Name = "researchTab";
            this.researchTab.Padding = new System.Windows.Forms.Padding(3);
            this.researchTab.Size = new System.Drawing.Size(1628, 656);
            this.researchTab.TabIndex = 5;
            this.researchTab.Text = "Research";
            this.researchTab.UseVisualStyleBackColor = true;
            // 
            // resourcesTab
            // 
            this.resourcesTab.Controls.Add(this.groupBox2);
            this.resourcesTab.Controls.Add(this.groupBox1);
            this.resourcesTab.Location = new System.Drawing.Point(8, 39);
            this.resourcesTab.Name = "resourcesTab";
            this.resourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.resourcesTab.Size = new System.Drawing.Size(1628, 656);
            this.resourcesTab.TabIndex = 6;
            this.resourcesTab.Text = "Resources";
            this.resourcesTab.UseVisualStyleBackColor = true;
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
            // peoplePanel
            // 
            this.peoplePanel.AutoScroll = true;
            this.peoplePanel.Location = new System.Drawing.Point(26, 82);
            this.peoplePanel.Name = "peoplePanel";
            this.peoplePanel.Size = new System.Drawing.Size(939, 568);
            this.peoplePanel.TabIndex = 0;
            // 
            // personData
            // 
            this.personData.Controls.Add(this.facebookL);
            this.personData.Controls.Add(this.twitterL);
            this.personData.Controls.Add(this.websiteL);
            this.personData.Controls.Add(this.phoneL);
            this.personData.Controls.Add(this.emailL);
            this.personData.Controls.Add(this.officeL);
            this.personData.Controls.Add(this.interestAreas);
            this.personData.Controls.Add(this.personTitle);
            this.personData.Controls.Add(this.personName);
            this.personData.Controls.Add(this.personPicture);
            this.personData.Location = new System.Drawing.Point(987, 25);
            this.personData.Name = "personData";
            this.personData.Size = new System.Drawing.Size(614, 625);
            this.personData.TabIndex = 1;
            this.personData.TabStop = false;
            // 
            // personPicture
            // 
            this.personPicture.Location = new System.Drawing.Point(39, 98);
            this.personPicture.Name = "personPicture";
            this.personPicture.Size = new System.Drawing.Size(270, 270);
            this.personPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personPicture.TabIndex = 0;
            this.personPicture.TabStop = false;
            // 
            // peopleTitle
            // 
            this.peopleTitle.AutoSize = true;
            this.peopleTitle.Location = new System.Drawing.Point(21, 25);
            this.peopleTitle.Name = "peopleTitle";
            this.peopleTitle.Size = new System.Drawing.Size(70, 25);
            this.peopleTitle.TabIndex = 0;
            this.peopleTitle.Text = "label1";
            // 
            // personName
            // 
            this.personName.Location = new System.Drawing.Point(34, 44);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(535, 32);
            this.personName.TabIndex = 1;
            // 
            // personTitle
            // 
            this.personTitle.Location = new System.Drawing.Point(336, 98);
            this.personTitle.Name = "personTitle";
            this.personTitle.Size = new System.Drawing.Size(238, 23);
            this.personTitle.TabIndex = 2;
            // 
            // interestAreas
            // 
            this.interestAreas.Location = new System.Drawing.Point(336, 151);
            this.interestAreas.Name = "interestAreas";
            this.interestAreas.Size = new System.Drawing.Size(238, 73);
            this.interestAreas.TabIndex = 3;
            // 
            // officeL
            // 
            this.officeL.Location = new System.Drawing.Point(336, 236);
            this.officeL.Name = "officeL";
            this.officeL.Size = new System.Drawing.Size(238, 23);
            this.officeL.TabIndex = 4;
            // 
            // emailL
            // 
            this.emailL.Location = new System.Drawing.Point(336, 286);
            this.emailL.Name = "emailL";
            this.emailL.Size = new System.Drawing.Size(238, 23);
            this.emailL.TabIndex = 5;
            // 
            // phoneL
            // 
            this.phoneL.Location = new System.Drawing.Point(336, 331);
            this.phoneL.Name = "phoneL";
            this.phoneL.Size = new System.Drawing.Size(238, 23);
            this.phoneL.TabIndex = 6;
            // 
            // websiteL
            // 
            this.websiteL.Location = new System.Drawing.Point(39, 402);
            this.websiteL.Name = "websiteL";
            this.websiteL.Size = new System.Drawing.Size(238, 23);
            this.websiteL.TabIndex = 7;
            // 
            // twitterL
            // 
            this.twitterL.Location = new System.Drawing.Point(39, 445);
            this.twitterL.Name = "twitterL";
            this.twitterL.Size = new System.Drawing.Size(238, 23);
            this.twitterL.TabIndex = 8;
            // 
            // facebookL
            // 
            this.facebookL.Location = new System.Drawing.Point(39, 486);
            this.facebookL.Name = "facebookL";
            this.facebookL.Size = new System.Drawing.Size(238, 23);
            this.facebookL.TabIndex = 9;
            // 
            // researchTitle
            // 
            this.researchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchTitle.Location = new System.Drawing.Point(27, 12);
            this.researchTitle.Name = "researchTitle";
            this.researchTitle.Size = new System.Drawing.Size(464, 48);
            this.researchTitle.TabIndex = 0;
            this.researchTitle.Text = "Research";
            // 
            // byInterestPanel
            // 
            this.byInterestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.byInterestPanel.Location = new System.Drawing.Point(27, 135);
            this.byInterestPanel.Name = "byInterestPanel";
            this.byInterestPanel.Size = new System.Drawing.Size(426, 515);
            this.byInterestPanel.TabIndex = 1;
            // 
            // byFacultyPanel
            // 
            this.byFacultyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.byFacultyPanel.Location = new System.Drawing.Point(481, 135);
            this.byFacultyPanel.Name = "byFacultyPanel";
            this.byFacultyPanel.Size = new System.Drawing.Size(1119, 515);
            this.byFacultyPanel.TabIndex = 2;
            // 
            // byAreaLabel
            // 
            this.byAreaLabel.AutoSize = true;
            this.byAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byAreaLabel.Location = new System.Drawing.Point(27, 75);
            this.byAreaLabel.Name = "byAreaLabel";
            this.byAreaLabel.Size = new System.Drawing.Size(209, 31);
            this.byAreaLabel.TabIndex = 4;
            this.byAreaLabel.Text = "By Interest Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "By Faculty";
            // 
            // resourcesTitle
            // 
            this.resourcesTitle.AutoSize = true;
            this.resourcesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourcesTitle.Location = new System.Drawing.Point(21, 46);
            this.resourcesTitle.Name = "resourcesTitle";
            this.resourcesTitle.Size = new System.Drawing.Size(154, 31);
            this.resourcesTitle.TabIndex = 0;
            this.resourcesTitle.Text = "Resources";
            // 
            // studyAbroadLink
            // 
            this.studyAbroadLink.AutoSize = true;
            this.studyAbroadLink.Location = new System.Drawing.Point(22, 206);
            this.studyAbroadLink.Name = "studyAbroadLink";
            this.studyAbroadLink.Size = new System.Drawing.Size(142, 25);
            this.studyAbroadLink.TabIndex = 1;
            this.studyAbroadLink.TabStop = true;
            this.studyAbroadLink.Text = "Study Abroad";
            // 
            // subtitleResources
            // 
            this.subtitleResources.Location = new System.Drawing.Point(22, 111);
            this.subtitleResources.Name = "subtitleResources";
            this.subtitleResources.Size = new System.Drawing.Size(333, 80);
            this.subtitleResources.TabIndex = 2;
            this.subtitleResources.Text = "label3";
            // 
            // studentServicesLink
            // 
            this.studentServicesLink.AutoSize = true;
            this.studentServicesLink.Location = new System.Drawing.Point(22, 262);
            this.studentServicesLink.Name = "studentServicesLink";
            this.studentServicesLink.Size = new System.Drawing.Size(175, 25);
            this.studentServicesLink.TabIndex = 3;
            this.studentServicesLink.TabStop = true;
            this.studentServicesLink.Text = "Student Services";
            // 
            // labsLink
            // 
            this.labsLink.AutoSize = true;
            this.labsLink.Location = new System.Drawing.Point(22, 321);
            this.labsLink.Name = "labsLink";
            this.labsLink.Size = new System.Drawing.Size(168, 25);
            this.labsLink.TabIndex = 4;
            this.labsLink.TabStop = true;
            this.labsLink.Text = "Tutors and Labs";
            // 
            // ambassadorsLink
            // 
            this.ambassadorsLink.AutoSize = true;
            this.ambassadorsLink.Location = new System.Drawing.Point(22, 376);
            this.ambassadorsLink.Name = "ambassadorsLink";
            this.ambassadorsLink.Size = new System.Drawing.Size(223, 25);
            this.ambassadorsLink.TabIndex = 5;
            this.ambassadorsLink.TabStop = true;
            this.ambassadorsLink.Text = "Student Ambassadors";
            // 
            // coopEnrollmentLink
            // 
            this.coopEnrollmentLink.AutoSize = true;
            this.coopEnrollmentLink.Location = new System.Drawing.Point(22, 434);
            this.coopEnrollmentLink.Name = "coopEnrollmentLink";
            this.coopEnrollmentLink.Size = new System.Drawing.Size(171, 25);
            this.coopEnrollmentLink.TabIndex = 6;
            this.coopEnrollmentLink.TabStop = true;
            this.coopEnrollmentLink.Text = "Coop Enrollment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resourcesTitle);
            this.groupBox1.Controls.Add(this.coopEnrollmentLink);
            this.groupBox1.Controls.Add(this.studyAbroadLink);
            this.groupBox1.Controls.Add(this.ambassadorsLink);
            this.groupBox1.Controls.Add(this.subtitleResources);
            this.groupBox1.Controls.Add(this.labsLink);
            this.groupBox1.Controls.Add(this.studentServicesLink);
            this.groupBox1.Location = new System.Drawing.Point(53, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 561);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.formsFlowPlane);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(457, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 561);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Forms";
            // 
            // formsFlowPlane
            // 
            this.formsFlowPlane.Location = new System.Drawing.Point(20, 111);
            this.formsFlowPlane.Name = "formsFlowPlane";
            this.formsFlowPlane.Size = new System.Drawing.Size(418, 422);
            this.formsFlowPlane.TabIndex = 8;
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
            this.PeopleTab.ResumeLayout(false);
            this.PeopleTab.PerformLayout();
            this.researchTab.ResumeLayout(false);
            this.researchTab.PerformLayout();
            this.resourcesTab.ResumeLayout(false);
            this.personData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TabPage PeopleTab;
        private System.Windows.Forms.TabPage researchTab;
        private System.Windows.Forms.TabPage resourcesTab;
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
        private System.Windows.Forms.GroupBox personData;
        private System.Windows.Forms.PictureBox personPicture;
        private System.Windows.Forms.FlowLayoutPanel peoplePanel;
        private System.Windows.Forms.Label peopleTitle;
        private System.Windows.Forms.Label personName;
        private System.Windows.Forms.Label facebookL;
        private System.Windows.Forms.Label twitterL;
        private System.Windows.Forms.Label websiteL;
        private System.Windows.Forms.Label phoneL;
        private System.Windows.Forms.Label emailL;
        private System.Windows.Forms.Label officeL;
        private System.Windows.Forms.Label interestAreas;
        private System.Windows.Forms.Label personTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label byAreaLabel;
        private System.Windows.Forms.FlowLayoutPanel byFacultyPanel;
        private System.Windows.Forms.FlowLayoutPanel byInterestPanel;
        private System.Windows.Forms.Label researchTitle;
        private System.Windows.Forms.LinkLabel coopEnrollmentLink;
        private System.Windows.Forms.LinkLabel ambassadorsLink;
        private System.Windows.Forms.LinkLabel labsLink;
        private System.Windows.Forms.LinkLabel studentServicesLink;
        private System.Windows.Forms.Label subtitleResources;
        private System.Windows.Forms.LinkLabel studyAbroadLink;
        private System.Windows.Forms.Label resourcesTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel formsFlowPlane;
    }
}

