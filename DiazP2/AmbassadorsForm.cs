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
    public partial class AmbassadorsForm : Form
    {
        Resources resources;
        public AmbassadorsForm(Resources resources)
        {
            this.resources = resources;
            InitializeComponent();
        }

        private void AmbassadorsForm_Load(object sender, EventArgs e)
        {
            StudentAmbassadors ambassadors = resources.studentAmbassadors;

            ambassadorsTitle.Text = ambassadors.title;
            ambassadorsPicture.Load(ambassadors.ambassadorsImageSource);

            ambassadorMissionLabel.Text = ambassadors.subSectionContent[0].title;
            ambassadorMissionDescription.Text = ambassadors.subSectionContent[0].description;

            overview.Text = ambassadors.subSectionContent[1].title;
            overviewDescription.Text = ambassadors.subSectionContent[1].description;

            criteria.Text = ambassadors.subSectionContent[2].title;
            criteriaDescription.Text = ambassadors.subSectionContent[2].description;

            duties.Text = ambassadors.subSectionContent[3].title;
            dutiesDescription.Text = ambassadors.subSectionContent[3].description;

            expectations.Text = ambassadors.subSectionContent[4].title;
            expectationsDescription.Text = ambassadors.subSectionContent[4].description;

            perks.Text = ambassadors.subSectionContent[5].title;
            perksDescription.Text = ambassadors.subSectionContent[5].description;

        }
    }
}
