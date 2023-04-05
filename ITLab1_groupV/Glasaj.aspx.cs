using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLab1_groupV
{
    public partial class Glasaj : System.Web.UI.Page
    {
        string [] professorsDB = new string[]
        {
                "д-р Гоце Арменски",
                "д-р Александра Дединец",
                "д-р Моника Симјаноска"
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string [] subjectsDB = new string[]
                {
                    "Интернет технологии",
                    "Интернет",
                    "Дигитална електроника"
                };

                foreach(string s in subjectsDB)
                {
                    listSubjects.Items.Add(s);
                }

                string[] creditsDB = new string[]
                {
                    "6",
                    "5.5",
                    "5.5"
                };

                for(int i = 0; i < creditsDB.Length; i++)
                {
                    listCredits.Items.Add(creditsDB[i]);
                }

                listSubjects.SelectedIndex = 0;
                listCredits.SelectedIndex = 0;
            }
        }

        protected void btnAddSubject_Click(object sender, EventArgs e)
        {
            ListItem newSubject = new ListItem(addSubject.Text);
            ListItem newCredit = new ListItem(addCredit.Text);

            if(newSubject.Text != "" && newCredit.Text != "")
            {
                listSubjects.Items.Add(newSubject);
                listCredits.Items.Add(newCredit);
                addSubject.Text = "";
                addCredit.Text = "";
            }
        }

        protected void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if(listSubjects.SelectedIndex != -1)
            {
                int i = listSubjects.SelectedIndex;
                listSubjects.Items.RemoveAt(i);
                listCredits.Items.RemoveAt(i);
            }
        }

        protected void btnVote_Click(object sender, EventArgs e)
        {
            Response.Redirect("UspeshnoGlasanje.aspx");
        }

        protected void listSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCredits.SelectedIndex = listSubjects.SelectedIndex;

            if(listSubjects.SelectedIndex >= professorsDB.Length)
            {
                lblProfessor.Text = "проф. по " + listSubjects.Text;
            }

            else
            {
                lblProfessor.Text = professorsDB[listSubjects.SelectedIndex];
            }
        }
    }
}