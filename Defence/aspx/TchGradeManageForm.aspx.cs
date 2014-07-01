using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Defence
{
    public partial class TchGradeManageForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string id = Session["Id"].ToString();
            string commandText = " select distinct Paper.P_id as 选题编号,Paper.Title as 选题题目,Stu.S_id as 学生学号,Stu.Name as 学生姓名,Stu.Specialty as 专业,Stu.Grade as 年级,Stu_Paper.P_score as 论文成绩,Stu_Paper.RP_score as 答辩成绩,Stu_Paper.Total_score as 总成绩" +
                                 " from Paper, Stu_Paper, Stu " +
                                 " where Paper.T_id = '" + id + "' and Paper.P_id = Stu_Paper.P_id and Stu_Paper.S_id = Stu.S_id";

            DataTable dt = m_sqlHelper.Query(commandText);
            m_GradeManagementGridView.DataSource = dt;
            m_GradeManagementGridView.DataBind();

            this.c_topwin18.m_tchTitleSelectButton.Click += new ImageClickEventHandler(m_tchTitleSelectButton_Click);
            this.c_topwin18.m_tchReleaseTitleButton.Click += new ImageClickEventHandler(m_tchReleaseTitleButton_Click);
            this.c_topwin18.m_tchStuDefenceButton.Click += new ImageClickEventHandler(m_tchStuDefenceButton_Click);
            this.c_topwin18.m_onlineTeachButton.Click += new ImageClickEventHandler(m_onlineTeachButton_Click);
            this.c_topwin18.m_tchAccountManageButton.Click += new ImageClickEventHandler(m_tchAccountManageButton_Click);
        }
        void m_tchTitleSelectButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchTitleSelectForm.aspx");
        }
        void m_tchReleaseTitleButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchReleaseTitleForm.aspx");
        }
        void m_tchStuDefenceButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchStuDefenceForm.aspx");
        }
        void m_onlineTeachButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchOnlineTeachForm.aspx");
        }
        void m_tchAccountManageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchAccountManageForm.aspx");
        }
    }
}