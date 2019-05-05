using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiazP2
{
    public partial class StudentResources : Form
    {
        Resources resources;
        public StudentResources(Resources resources)
        {
            this.resources = resources;
            InitializeComponent();
        }

        private void StudentResources_Load(object sender, EventArgs e)
        {
            StudentServices studentServices = resources.studentServices;

            advisingLabel.Text = studentServices.title;

            academicAdvisingLabel.Text = studentServices.academicAdvisors.title;
            academicAdvisingDescription.Text = studentServices.academicAdvisors.description;

            facultyAdvisorLabel.Text = studentServices.facultyAdvisors.title;
            facultyAdvisorDescription.Text = studentServices.facultyAdvisors.description;

            academicAdvisorsLabel.Text = studentServices.professonalAdvisors.title;

            foreach (AdvisorInformation advisor in studentServices.professonalAdvisors.advisorInformation)
            {
                Label name = new Label();
                name.Text = advisor.name;
                name.Font = new Font(name.Font.FontFamily, name.Font.Size, FontStyle.Bold);
                name.Size = new Size(flowLayoutPanel1.Size.Width, name.Size.Height);
                flowLayoutPanel1.Controls.Add(name);

                Label department = new Label();
                department.Text = "Department: " + advisor.department;
                department.Size = new Size(flowLayoutPanel1.Size.Width, name.Size.Height);
                flowLayoutPanel1.Controls.Add(department);

                Label email = new Label();
                email.Text = "Email: " + advisor.email;
                email.Size = new Size(flowLayoutPanel1.Size.Width, name.Size.Height);
                flowLayoutPanel1.Controls.Add(email);
            }

            foreach(MinorAdvisorInformation advisor in studentServices.istMinorAdvising.minorAdvisorInformation)
            {
                Label name = new Label();
                name.Text = advisor.advisor + " (" + advisor.email + ")";
                name.Font = new Font(name.Font.FontFamily, name.Font.Size, FontStyle.Bold);
                name.Size = new Size(flowLayoutPanel1.Size.Width, name.Size.Height-5);
                flowLayoutPanel2.Controls.Add(name);

                Label department = new Label();
                department.Text = "Minor: " + advisor.title;
                department.Size = new Size(flowLayoutPanel1.Size.Width, name.Size.Height-5);
                flowLayoutPanel2.Controls.Add(department);
            }

            minorAdvisorsLabel.Text = studentServices.istMinorAdvising.title;
        }
    }
}
