using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace Defence.aspx
{
    public partial class TchReportDetailForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string paperId = Request.QueryString["P_id"];
            string stuName = Request.QueryString["Sname"];
            string commandText = "select distinct Paper.P_id, Paper.Title, Stu.S_id, Stu.Name, Stu.Specialty from Paper, Stu_Topic, Stu " 
                + "where Stu.Name='" + stuName + "' and Stu.S_id=Stu_Topic.S_id and Stu_Topic.P_id='" + paperId + "' and Stu_Topic.P_id=Paper.P_id";
            DataTable dt = m_sqlHelper.Query(commandText);
            if (dt.Rows.Count != 0)
            {
                m_Report_TitleIdLabel.Text = dt.Rows[0][0].ToString();
                m_Report_TitleNameLabel.Text = dt.Rows[0][1].ToString();
                m_Report_StuIdLabel.Text = dt.Rows[0][2].ToString();
                m_Report_StuNameLabel.Text = dt.Rows[0][3].ToString();
                m_Report_StuSpecialtyLabel.Text = dt.Rows[0][4].ToString();
            }

        }

        protected void Report_DownloadButton_Click(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string paperId = Request.QueryString["P_id"];
            string stuName = Request.QueryString["Sname"];
            string commandText = "select distinct Stu_Topic.Op_report from Paper, Stu_Topic, Stu "
                + "where Stu.Name='" + stuName + "' and Stu.S_id=Stu_Topic.S_id and Stu_Topic.P_id='" + paperId + "'";
            DataTable dt = m_sqlHelper.Query(commandText);
            string text = dt.Rows[0][0].ToString();
            string path = "E:\\report\\report_" + paperId + ".txt";
            WriteFile(text, path);

            System.IO.FileInfo file = new System.IO.FileInfo(path);
            Response.Clear();
            Response.Charset = "GB2312";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            // 添加头信息，为"文件下载/另存为"对话框指定默认文件名 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode(file.Name));
            // 添加头信息，指定文件大小，让浏览器能够显示下载进度 
            Response.AddHeader("Content-Length", file.Length.ToString());

            // 指定返回的是一个不能被客户端读取的流，必须被下载 
            Response.ContentType = "application/ms-excel";

            // 把文件流发送到客户端 
            Response.WriteFile(file.FullName);
            // 停止页面的执行 

            Response.End();
        }
        protected void Report_ReviewButton_Click(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string paperId = Request.QueryString["P_id"];
            string stuName = Request.QueryString["Sname"];
            int stateindex = m_Report_ReviewList.SelectedIndex;
            string state = "";
            if (stateindex == 0) state = "审核中";
            else if (stateindex == 1) state = "已选";
            else if (stateindex == 2) state = "拒绝";

            //0为未审核 1为通过 -1为不通过
            string commandText = "select S_id from Stu where Stu.Name='" + stuName + "'";
            DataTable dt = m_sqlHelper.Query(commandText);
            string sid = (string)dt.Rows[0][0];

            commandText = "update Stu_Topic set Result='" + state + "' where P_id='" + paperId + "' and S_id='" + sid + "'";
            m_sqlHelper.Update(commandText);
            //通过，添加入论文表
            if (stateindex == 1)
            {
                commandText = "Insert into Stu_Paper(S_id, P_id) values('" + sid + "', '" + paperId + "')";
                m_sqlHelper.Update(commandText);
            }
            
            //Response.Write("<script>alert('审核成功！')</script>");
            Response.Redirect("TchReportReviewForm.aspx");
        }

        protected void m_returnButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchReportReviewForm.aspx");
        }

        public void WriteFile(string Content, string FileSavePath)
        {
            if (File.Exists(FileSavePath))
            {
                File.Delete(FileSavePath);
            }
            FileStream fs = File.Create(FileSavePath);
            Byte[] bContent = System.Text.Encoding.UTF8.GetBytes(Content);
            fs.Write(bContent, 0, bContent.Length);
            fs.Close();
            fs.Dispose();
        }
    }
}