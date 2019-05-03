﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void BuildAbout()
        {
            string jsonAbout = rest.getRESTDataJSON("/about/");

            about = JToken.Parse(jsonAbout).ToObject<About>();

            aboutTitle.Text = about.title;
            aboutTitle.Font = new Font("Arial", aboutTitle.Font.Size + 3, FontStyle.Bold);

            aboutDescription.Text = about.description;

            aboutQuote.Text = about.quote + "\n -" + about.quoteAuthor;
            aboutQuote.Font = new Font("Arial", aboutQuote.Font.Size, FontStyle.Italic);

        }

        private void BuildDegrees()
        {
            string jsonDegrees = rest.getRESTDataJSON("/degrees/");

            degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();

            int y = 50;

            Label undergraduteLabel = new Label();
            undergraduteLabel.Text = "Undergraduate";
            undergraduteLabel.Location = new Point(20, 20);
            degreesRadioButtons.Controls.Add(undergraduteLabel);


            foreach(Undergraduate degree in degrees.undergraduate)
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

            Label graduateLabel = new Label();
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
            
            foreach(Graduate degree in degrees.graduate)
            {
                if (degree.degreeName == degreeName)
                {
                    graduateDegree = degree;
                    break;
                }
            }

            degreeTitle.Visible = true;
            degreeTitle.Font = new Font(degreeTitle.Font.FontFamily, 9, FontStyle.Bold);

            degreeDescription.Visible = true;
            degreeDescription.AutoSize = true;
            degreeDescription.MaximumSize = new Size(280, 300);

            string list = "";
            if (undergraduateDegree != null) {
                degreeTitle.Text = undergraduateDegree.title;
                degreeDescription.Text = undergraduateDegree.description;

                list = "Concentrations: \n";
                foreach(string concentration in undergraduateDegree.concentrations)
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
            minorName.Font = new Font(degreeTitle.Font.FontFamily, 9, FontStyle.Bold);
            minorName.Text = ugMinor.title;

            minorDescription.Visible = true;
            minorDescription.Text = ugMinor.description;

            minorCourses.Visible = true;
            minorCourses.Font = new Font(minorCourses.Font.FontFamily, 9, FontStyle.Bold);

            int x = 0;

            courses.Controls.Clear();

            foreach(string course in ugMinor.courses)
            {
                LinkLabel courseLabel = new LinkLabel();
                courseLabel.Text = course;
                courseLabel.Location = new Point(x, 0);
                courseLabel.Size = new Size(70, 30);
                x += 70;

                courses.Controls.Add(courseLabel);
            }

        }
    }
}
