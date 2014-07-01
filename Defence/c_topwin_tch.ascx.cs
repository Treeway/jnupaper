using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Defence
{
    public partial class c_topwin_tch : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void m_tchReleaseTitleButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("TchReleaseTitleForm.aspx");
        }
        protected void m_tchTitleSelectButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("TchPaperReviewForm.aspx");
        }
        protected void m_onlineTeachButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("TchOnlineTeachForm.aspx");
        }
        protected void m_tchStuDefenceButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("TchStuDefenceForm.aspx");
        }
        protected void m_tchGradeManageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("TchGradeManageForm.aspx");
        }
        protected void m_tchAccountManageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("TchAccountManageForm.aspx");
        }
        protected void m_exitLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LandForm.aspx");
        }
       
    }
}