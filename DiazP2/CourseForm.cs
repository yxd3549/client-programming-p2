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
    public partial class CourseForm : Form
    {
        string name;
        string descripton;
        public CourseForm(string name, string description)
        {
            this.name = name;
            this.descripton = description;
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            courseName.Text = name;
            courseName.Font = new Font(courseName.Font.FontFamily, 10, FontStyle.Bold);
            courseDescription.Text = descripton;
        }
    }
}
