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
    public partial class CoopEnrollmentForm : Form
    {
        Resources resources;
        public CoopEnrollmentForm(Resources resources)
        {
            this.resources = resources;
            InitializeComponent();
        }

        private void CoopEnrollmentForm_Load(object sender, EventArgs e)
        {
            CoopEnrollment coopEnrollment = resources.coopEnrollment;
            coopTitle.Text = coopEnrollment.title;

            foreach(EnrollmentInformationContent content in coopEnrollment.enrollmentInformationContent)
            {
                Label sectionTitle = new Label();
                sectionTitle.Text = content.title;
                sectionTitle.Size = new Size(sectionTitle.Size.Width + 240, sectionTitle.Size.Height);
                sectionTitle.Font = new Font(sectionTitle.Font.FontFamily, sectionTitle.Font.Size, FontStyle.Bold);
                flowLayoutPanel1.Controls.Add(sectionTitle);

                Label section = new Label();
                section.Text = content.description;
                section.Size = new Size(sectionTitle.Size.Width + 240, sectionTitle.Size.Height + content.description.Length/10);
                flowLayoutPanel1.Controls.Add(section);
            }
        }
    }
}
