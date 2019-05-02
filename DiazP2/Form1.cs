using System;
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
    public partial class Form1 : MaterialForm
    {
        REST rest;
        public Form1()
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

        }

        private void BuildAbout()
        {
            string jsonAbout = rest.getRESTDataJSON("/about/");

            About about = JToken.Parse(jsonAbout).ToObject<About>();

            aboutTitle.Text = about.title;
            aboutTitle.Font = new Font("Arial", aboutTitle.Font.Size + 3, FontStyle.Bold);

            aboutDescription.Text = about.description;

            aboutQuote.Text = about.quote + "\n -" + about.quoteAuthor;
            aboutQuote.Font = new Font("Arial", aboutQuote.Font.Size, FontStyle.Italic);

        }

        private void TabsSelector_Click(object sender, EventArgs e)
        {

        }

        private void AboutTab_Click(object sender, EventArgs e)
        {

        }
    }
}
