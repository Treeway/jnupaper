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
    public partial class TchPaperDetailForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string paperId = Request.QueryString["P_id"];
            string sid = Request.QueryString["S_id"];
            string commandText = "select distinct Paper.P_id, Paper.Title, Stu.S_id, Stu.Name, Stu.Specialty from Paper, Stu, Stu_Paper"
                + " where Paper.P_id='" + paperId + "' and Paper.P_id=Stu_Paper.P_id and Stu_Paper.S_id='" + sid + "' and Stu_paper.S_id=Stu.S_id";
            DataTable dt = m_sqlHelper.Query(commandText);
            if (dt.Rows.Count != 0)
            {
                m_Paper_TitleIdLabel.Text = dt.Rows[0][0].ToString();
                m_Paper_TitleNameLabel.Text = dt.Rows[0][1].ToString();
                m_Paper_StuIdLabel.Text = dt.Rows[0][2].ToString();
                m_Paper_StuNameLabel.Text = dt.Rows[0][3].ToString();
                m_Paper_StuSpecialtyLabel.Text = dt.Rows[0][4].ToString();
            }
        }

        protected void Paper_DownloadButton_Click(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string paperId = Request.QueryString["P_id"];
            string stuId = Request.QueryString["S_id"];
            string commandText = "select P_content from Stu_Paper where P_id='" + paperId + "' and S_id='" + stuId + "'";
            DataTable dt = m_sqlHelper.Query(commandText);
            string text = dt.Rows[0][0].ToString();
            string path = "E:\\paper\\paper_" + paperId + ".txt";
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

        protected void Paper_ScoreConfirmButton_Click(object sender, EventArgs e)
        {
            SqlHelper m_sqlHelper = new SqlHelper();
            string paperId = Request.QueryString["P_id"];
            string sid = Request.QueryString["S_id"];
            int score = System.Int32.Parse(m_scoreTextBox.Text);
            string commandText = "update Stu_Paper set P_score=" + score + " where P_id='" + paperId + "' and S_id='" + sid + "'";
            m_sqlHelper.Update(commandText);
            Response.Redirect("TchPaperReviewForm.aspx");
        }
        protected void m_returnButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TchPaperReviewForm.aspx");
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