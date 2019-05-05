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
    public partial class EmploymentWindow : Form
    {
        private string table;
        private Employment employment;
        public EmploymentWindow(string table, Employment employment)
        {
            this.table = table;
            this.employment = employment;
            InitializeComponent();
        }

        private void EmploymentWindow_Load(object sender, EventArgs e)
        {
            if (table == "coop")
            {
                tableTitle.Text = employment.coopTable.title;

                dataTable.ColumnCount = 4;
                dataTable.Columns[0].Name = "Employer";
                dataTable.Columns[1].Name = "Degree";
                dataTable.Columns[2].Name = "City";
                dataTable.Columns[3].Name = "Term";

                foreach (CoopInformation coopInformation in employment.coopTable.coopInformation)
                {
                    string[] row = { coopInformation.employer, coopInformation.degree, coopInformation.city, coopInformation.term };
                    dataTable.Rows.Add(row);
                }

            }
            else
            {
                tableTitle.Text = employment.employmentTable.title;

                dataTable.ColumnCount = 5;
                dataTable.Columns[0].Name = "Employer";
                dataTable.Columns[1].Name = "Degree";
                dataTable.Columns[2].Name = "City";
                dataTable.Columns[3].Name = "Title";
                dataTable.Columns[4].Name = "Start Date";


                foreach (ProfessionalEmploymentInformation information in employment.employmentTable.professionalEmploymentInformation)
                {
                    string[] row = { information.employer, information.degree, information.city, information.title, information.startDate };
                    dataTable.Rows.Add(row);
                }
            }


        }
    }
}
