using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC3
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_Clothes = 300;
            int i_Hat = 350;
            int i_Pants = 400;
            int s;
            s = (i_Clothes * 7) + (i_Hat * 8) + (i_Pants * 9); 
            Response.Write(s);
        }
    }
}