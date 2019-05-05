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
    public partial class ResearchForm : Form
    {
        private string title;
        private List<string> citations;
        public ResearchForm(string title, List<string> citations)
        {
            this.title = title;
            this.citations = citations;
            InitializeComponent();
        }

        private void ResearchForm_Load(object sender, EventArgs e)
        {
            researchFormTitle.Text = title;
            foreach(string citation in citations)
            {
                Label c = new Label();
                c.Text = citation;
                c.Size = new Size(600, c.Size.Height * 2);
                flowLayoutPanel1.Controls.Add(c);
            }
        }
    }
}
