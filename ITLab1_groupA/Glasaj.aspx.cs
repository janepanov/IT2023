using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITLab1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void vote_Click(object sender, EventArgs e)
        {            
            Response.Redirect("UspesnoGlasanje.aspx");
        }

        protected void subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(subjects.SelectedItem.Value == "IT")
            {
                professor.Text = "д-р Гоце Арменски";
            }

            if(subjects.SelectedItem.Value == "I")
            {
                professor.Text = "д-р Александра Дединец";

            }

            if(subjects.SelectedItem.Value == "DE")
            {
                professor.Text = "д-р Моника Симјаноска";
            }
        }
    }
}