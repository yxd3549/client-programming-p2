using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace DiazP2
{
    public partial class Main : MaterialForm
    {
        REST rest;

        About about;
        Degrees degrees;
        Minors minors;
        Employment employment;
        People people;
        Dictionary<string, Faculty> facultyDictionary = new Dictionary<string, Faculty>();
        Dictionary<string, Staff> staffDictionary = new Dictionary<string, Staff>();
        Research research;
        Dictionary<string, ByInterestArea> interestAreaDictionary = new Dictionary<string, ByInterestArea>();
        Dictionary<string, ByFaculty> facultyResearchDictionary = new Dictionary<string, ByFaculty>();
        Resources resources;

        public Main()
        {
            this.rest = new REST("http://ist.rit.edu/api");

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildAbout();
            BuildDegrees();
            BuildMinors();
            BuildEmployment();
            BuildPeople();
            BuildResearch();
            BuildResources();
        }

        private void BuildAbout()
        {
            string jsonAbout = rest.getRESTDataJSON("/about/");

            about = JToken.Parse(jsonAbout).ToObject<About>();

            aboutTitle.Text = about.title;
            aboutTitle.Font = new Font(aboutTitle.Font.FontFamily, 10, FontStyle.Bold);

            aboutDescription.Text = about.description;

            aboutQuote.Text = about.quote + "\n -" + about.quoteAuthor;
            aboutQuote.Font = new Font(aboutQuote.Font.FontFamily, aboutQuote.Font.Size, FontStyle.Italic);

        }

        private void BuildDegrees()
        {
            string jsonDegrees = rest.getRESTDataJSON("/degrees/");

            degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();

            int y = 50;

            MaterialLabel undergraduteLabel = new MaterialLabel();
            undergraduteLabel.Size = new Size(undergraduteLabel.Size.Width + 20, undergraduteLabel.Size.Height);
            undergraduteLabel.Text = "Undergraduate";

            undergraduteLabel.Location = new Point(20, 20);
            degreesRadioButtons.Controls.Add(undergraduteLabel);


            foreach (Undergraduate degree in degrees.undergraduate)
            {
                MaterialRadioButton radio = new MaterialRadioButton();
                radio.Text = degree.degreeName;
                radio.AutoSize = false;
                radio.Size = new Size(230, 20);
                radio.CheckedChanged += new System.EventHandler(degreeChanged);
                radio.Location = new Point(20, y);
                y += 30;

                degreesRadioButtons.Controls.Add(radio);
            }

            MaterialLabel graduateLabel = new MaterialLabel();
            graduateLabel.Text = "Graduate";
            graduateLabel.Location = new Point(20, y);
            degreesRadioButtons.Controls.Add(graduateLabel);

            y += 30;

            foreach (Graduate degree in degrees.graduate)
            {
                MaterialRadioButton radio = new MaterialRadioButton();
                radio.Text = degree.degreeName;
                radio.AutoSize = false;
                radio.Size = new Size(230, 20);
                radio.CheckedChanged += new System.EventHandler(degreeChanged);
                radio.Location = new Point(20, y);
                y += 30;

                degreesRadioButtons.Controls.Add(radio);
            }

        }

        private void degreeChanged(object sender, EventArgs e)
        {
            MaterialRadioButton button = (MaterialRadioButton)sender;
            string degreeName = button.Text;
            Undergraduate undergraduateDegree = null;
            Graduate graduateDegree = null;

            foreach (Undergraduate degree in degrees.undergraduate)
            {
                if (degree.degreeName == degreeName)
                {
                    undergraduateDegree = degree;
                    break;
                }
            }

            foreach (Graduate degree in degrees.graduate)
            {
                if (degree.degreeName == degreeName)
                {
                    graduateDegree = degree;
                    break;
                }
            }

            degreeTitle.Visible = true;
            degreeTitle.Font = new Font(degreeTitle.Font.FontFamily, 10, FontStyle.Bold);

            degreeDescription.Visible = true;

            string list = "";
            if (undergraduateDegree != null)
            {
                degreeTitle.Text = undergraduateDegree.title;
                degreeDescription.Text = undergraduateDegree.description;

                list = "Concentrations: \n";
                foreach (string concentration in undergraduateDegree.concentrations)
                {
                    list += "    - " + concentration + "\n";
                }
                degreeList.Visible = true;

            }
            else if (graduateDegree != null && graduateDegree.availableCertificates == null)
            {
                degreeTitle.Text = graduateDegree.title;
                degreeDescription.Text = graduateDegree.description;
                list = "Concentrations: \n";
                foreach (string concentration in graduateDegree.concentrations)
                {
                    list += "    - " + concentration + "\n";
                }
                degreeList.Visible = true;
            }
            else
            {
                degreeTitle.Text = graduateDegree.degreeName;
                string description = "";
                foreach (string certificate in graduateDegree.availableCertificates)
                {
                    description += "    - " + certificate + "\n";
                }
                degreeDescription.Text = description;
            }

            degreeList.Text = list;

            degreeInfo.Controls.Add(degreeTitle);
        }

        private void BuildMinors()
        {
            string jsonMinors = rest.getRESTDataJSON("/minors/");

            minors = JToken.Parse(jsonMinors).ToObject<Minors>();

            int y = 50;

            Label minorsLabel = new Label();
            minorsLabel.Text = "Minors";
            minorsLabel.Location = new Point(20, 20);
            minorsList.Controls.Add(minorsLabel);

            foreach (UgMinor minor in minors.UgMinors)
            {
                MaterialRadioButton radio = new MaterialRadioButton();
                radio.Text = minor.name;
                radio.AutoSize = false;
                radio.Size = new Size(110, 20);
                radio.CheckedChanged += new System.EventHandler(minorChanged);
                radio.Location = new Point(20, y);
                y += 30;

                minorsList.Controls.Add(radio);
            }
        }

        private void minorChanged(object sender, EventArgs e)
        {
            MaterialRadioButton button = (MaterialRadioButton)sender;
            string ugMinorName = button.Text;
            UgMinor ugMinor = null;

            foreach (UgMinor minor in minors.UgMinors)
            {
                if (minor.name == ugMinorName)
                {
                    ugMinor = minor;
                    break;
                }
            }

            minorName.Visible = true;
            minorName.Font = new Font(degreeTitle.Font.FontFamily, 10, FontStyle.Bold);
            minorName.Text = ugMinor.title;

            minorDescription.Visible = true;
            minorDescription.Text = ugMinor.description;

            minorCourses.Visible = true;
            minorCourses.Font = new Font(minorCourses.Font.FontFamily, 10, FontStyle.Bold);

            int x = 10;

            courses.Controls.Clear();

            foreach (string course in ugMinor.courses)
            {
                LinkLabel courseLabel = new LinkLabel();
                courseLabel.Text = course;
                courseLabel.Location = new Point(x, 0);
                courseLabel.Size = new Size(70, 30);
                courseLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(courseClicked);
                x += 70;

                courses.Controls.Add(courseLabel);
            }

        }

        private void courseClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;
            string courseName = link.Text;

            string jsonCourse = rest.getRESTDataJSON("/course/courseID=" + courseName);
            Course course = JToken.Parse(jsonCourse).ToObject<Course>();

            CourseForm courseForm = new CourseForm(course.title + " (" + course.courseID + ")", course.description);

            courseForm.Show();

        }

        private void BuildEmployment()
        {
            string jsonEmployment = rest.getRESTDataJSON("/employment/");

            employment = JToken.Parse(jsonEmployment).ToObject<Employment>();

            employmentTitle.Visible = true;
            employmentTitle.Font = new Font(employmentTitle.Font.FontFamily, 10, FontStyle.Bold);
            employmentTitle.Text = employment.introduction.title;

            employmentSubTitle1.Text = employment.introduction.content[0].title;
            employmentSubTitle1.Font = new Font(employmentSubTitle1.Font.FontFamily, 10, FontStyle.Underline);
            employmentDescription1.Text = employment.introduction.content[0].description;
            employmentDescription1.Font = new Font(employmentSubTitle1.Font.FontFamily, 10, FontStyle.Regular);

            employmentSubtitle2.Text = employment.introduction.content[1].title;
            employmentSubtitle2.Font = new Font(employmentSubTitle1.Font.FontFamily, 10, FontStyle.Underline);
            employmentDescription2.Text = employment.introduction.content[1].description;
            employmentDescription2.Font = new Font(employmentSubTitle1.Font.FontFamily, 10, FontStyle.Regular);

            DegreeStatistics statistics = employment.degreeStatistics;
            statisticsTitle.Text = statistics.title;
            statisticsTitle.Font = new Font(employmentSubTitle1.Font.FontFamily, 10, FontStyle.Underline);

            int x = statisticsTitle.Location.X;
            int y = statisticsTitle.Location.Y + 25;

            foreach (Statistic statistic in statistics.statistics)
            {
                Label statisticValue = new Label();
                statisticValue.Text = statistic.value;
                statisticValue.Font = new Font(employmentTitle.Font.FontFamily, 10, FontStyle.Bold);
                statisticValue.Location = new Point(x, y);
                y += 20;

                Label statisticDescription = new Label();
                statisticDescription.Text = statistic.description;
                statisticDescription.AutoSize = false;
                statisticDescription.Size = new Size(statisticsTitle.Size.Width, statisticsTitle.Size.Height + 25);
                statisticDescription.Font = new Font(employmentTitle.Font.FontFamily, 10, FontStyle.Regular);
                statisticDescription.Location = new Point(x, y);
                y += 52;

                statisticsBox.Controls.Add(statisticValue);
                statisticsBox.Controls.Add(statisticDescription);
            }

            coopLink.LinkClicked += new LinkLabelLinkClickedEventHandler(coopLinkClicked);
            employmentLink.LinkClicked += new LinkLabelLinkClickedEventHandler(employmentLinkClicked);
        }

        private void coopLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;

            EmploymentWindow coopWindow = new EmploymentWindow("coop", employment);

            coopWindow.Show();

        }

        private void employmentLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;

            EmploymentWindow coopWindow = new EmploymentWindow("full-time", employment);

            coopWindow.Show();

        }

        private void BuildPeople()
        {
            string jsonPeople = rest.getRESTDataJSON("/people/");

            people = JToken.Parse(jsonPeople).ToObject<People>();

            peopleTitle.Text = people.title;
            peopleTitle.Font = new Font(peopleTitle.Font.FontFamily, 10, FontStyle.Bold);

            foreach (Faculty faculty in people.faculty)
            {
                LinkLabel person = new LinkLabel();
                person.Text = faculty.name;
                peoplePanel.Controls.Add(person);

                facultyDictionary.Add(faculty.name, faculty);
                person.LinkClicked += new LinkLabelLinkClickedEventHandler(personLinkClicked);
            }

            foreach (Staff staff in people.staff)
            {
                LinkLabel person = new LinkLabel();
                person.Text = staff.name;
                peoplePanel.Controls.Add(person);

                staffDictionary.Add(staff.name, staff);
                person.LinkClicked += new LinkLabelLinkClickedEventHandler(personLinkClicked);
            }
        }

        private void personLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;
            string name = link.Text;

            string url = "";
            string interest = "";
            string office = "";
            string email = "";
            string phone = "";
            string website = "";
            string twitter = "";
            string facebook = "";

            if (facultyDictionary.ContainsKey(name))
            {
                Faculty faculty = facultyDictionary[name];
                url = faculty.imagePath;
                personName.Text = faculty.name + " (" + faculty.username + ")";
                personName.Font = new Font(personName.Font.FontFamily, 9, FontStyle.Bold);
                personTitle.Text = faculty.title;
                interestAreas.Text = "Interest Areas:\n" + faculty.interestArea;
                officeL.Text = "Office: " + faculty.office;
                emailL.Text = "Email: " + faculty.email;
                phoneL.Text = "Phone: " + faculty.phone;
                websiteL.Text = "Website: " + faculty.website;
                twitterL.Text = "Twitter: " + faculty.twitter;
                facebookL.Text = "Facebook: " + faculty.facebook;
            }
            else
            {
                Staff staff = staffDictionary[name];
                url = staff.imagePath;
            }

            personPicture.Load(url);

        }

        private void BuildResearch()
        {
            string jsonResearch = rest.getRESTDataJSON("/research/");

            research = JToken.Parse(jsonResearch).ToObject<Research>();

            foreach (ByInterestArea interestArea in research.byInterestArea)
            {
                LinkLabel area = new LinkLabel();
                area.Text = interestArea.areaName;
                area.Size = new Size(area.Size.Width + 20, area.Size.Height);
                byInterestPanel.Controls.Add(area);
                interestAreaDictionary[interestArea.areaName] = interestArea;
                area.LinkClicked += new LinkLabelLinkClickedEventHandler(areaLinkClicked);
            }

            foreach (ByFaculty faculty in research.byFaculty)
            {
                LinkLabel area = new LinkLabel();
                area.Text = faculty.facultyName;
                area.Size = new Size(area.Size.Width + 20, area.Size.Height);
                byFacultyPanel.Controls.Add(area);
                facultyResearchDictionary[faculty.facultyName] = faculty;
                area.LinkClicked += new LinkLabelLinkClickedEventHandler(facultyResearchLinkClicked);
            }
        }

        private void areaLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;
            string area = link.Text;

            ResearchForm form = new ResearchForm(area + " Research", interestAreaDictionary[area].citations);
            form.Show();
        }

        private void facultyResearchLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;
            string faculty = link.Text;

            ResearchForm form = new ResearchForm(faculty + "'s research", facultyResearchDictionary[faculty].citations);
            form.Show();
        }

        private void BuildResources()
        {
            string jsonResources = rest.getRESTDataJSON("/resources/");

            resources = JToken.Parse(jsonResources).ToObject<Resources>();

            resourcesTitle.Text = resources.title;
            subtitleResources.Text = resources.subTitle;

            foreach(GraduateForm form in resources.forms.graduateForms)
            {
                LinkLabel link = new LinkLabel();
                link.Text = form.formName;
                link.Name = form.href;
                link.Size = new Size(link.Size.Width + 60, link.Size.Height);
                link.LinkClicked += new LinkLabelLinkClickedEventHandler(formLinkClicked);
                formsFlowPlane.Controls.Add(link);
            }

            foreach (UndergraduateForm form in resources.forms.undergraduateForms)
            {
                LinkLabel link = new LinkLabel();
                link.Text = form.formName;
                link.Name = form.href;
                link.Size = new Size(link.Size.Width + 60, link.Size.Height);
                link.LinkClicked += new LinkLabelLinkClickedEventHandler(formLinkClicked);
                formsFlowPlane.Controls.Add(link);
            }

            studyAbroadLink.LinkClicked += new LinkLabelLinkClickedEventHandler(studyAbroadClicked);
            studentServicesLink.LinkClicked += new LinkLabelLinkClickedEventHandler(studentResourcesClicked);
        }

        private void formLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;
            string formHref = link.Name;

            Console.WriteLine(formHref);
            System.Diagnostics.Process.Start("http://ist.rit.edu/" + formHref);

        }

        private void studyAbroadClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudyAbroadForm form = new StudyAbroadForm(resources);
            form.Show();
        }

        private void studentResourcesClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentResources form = new StudentResources(resources);
            form.Show();
        }
    }
}
