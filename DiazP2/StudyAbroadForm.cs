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
    public partial class StudyAbroadForm : Form
    {
        private Resources resources;
        public StudyAbroadForm(Resources resources)
        {
            this.resources = resources;
            InitializeComponent();
        }

        private void StudyAbroadForm_Load(object sender, EventArgs e)
        {
            StudyAbroad studyAbroad = resources.studyAbroad;
            label1.Text = studyAbroad.title;
            label2.Text = studyAbroad.description;

            foreach(Place place in studyAbroad.places)
            {
                Label name = new Label();
                name.Text = place.nameOfPlace;
                name.Font = new Font(name.Font.FontFamily, 9, FontStyle.Bold);
                name.Size = new Size(name.Size.Width + 450, name.Size.Height);
                flowLayoutPanel1.Controls.Add(name);

                Label description = new Label();
                description.Text = place.description;
                description.Font = new Font(name.Font.FontFamily, 9, FontStyle.Regular);
                description.Size = new Size(description.Size.Width + 450, description.Size.Height + 60);
                flowLayoutPanel1.Controls.Add(description);

            }
        }
    }
}
