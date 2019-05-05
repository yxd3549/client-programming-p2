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
    public partial class LabInformation : Form
    {
        Resources resources;
        public LabInformation(Resources resources)
        {
            this.resources = resources;
            InitializeComponent();
        }

        private void LabInformation_Load(object sender, EventArgs e)
        {
            TutorsAndLabInformation tutoring = resources.tutorsAndLabInformation;

            tutoringLabel.Text = tutoring.title;

            tutoringDescription.Text = tutoring.description;

            tutoringLink.LinkClicked += new LinkLabelLinkClickedEventHandler(tutoringHoursClicked);
        }

        private void tutoringHoursClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(resources.tutorsAndLabInformation.tutoringLabHoursLink);
        }
    }
}
