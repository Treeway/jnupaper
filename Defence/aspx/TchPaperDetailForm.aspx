<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TchPaperDetailForm.aspx.cs" Inherits="Defence.aspx.TchPaperDetailForm" %>
<%@ Register TagPrefix="topwin" TagName="c_topwin" Src="/c_topwin_tch.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Report_BrowseTextBox {
            width: 418px;
        }
        .auto-style1 {
            width: 215px;
        }
    </style>
    <link href="../css/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <link href="../css/GridViewStyleSheet2.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="../css/TableStyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; top: -4px; left: -33px; height: 717px;">
        <topwin:c_topwin runat="server" id="c_topwin2"/>
        <asp:Panel ID="m_stuTitleReportPanel" runat="server" style="position: absolute; top: 225px; left: 397px; height: 475px; width: 600px;">
            &nbsp;<div style="height: 57px; margin-left: 6px">
                    &nbsp;
                    <br />
                    <br />
                    <asp:Button ID="m_returnButton" runat="server" OnClick="m_returnButton_Click" Text="返回" />
                </div>
            &nbsp;&nbsp;<br /> 
            <br />
            &nbsp;<table style="width: 522px; height: 85px;" class="t2">
                <tr class="th">
                    <td class="auto-style1"><b>详细信息</b></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">选题编号：</td>
                    <td>
                        <asp:Label ID="m_Paper_TitleIdLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">选题题目：</td>
                    <td>
                        <asp:Label ID="m_Paper_TitleNameLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">学生学号：</td>
                    <td>
                        <asp:Label ID="m_Paper_StuIdLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">学生姓名：</td>
                    <td>
                        <asp:Label ID="m_Paper_StuNameLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">学生专业：</td>
                    <td>
                        <asp:Label ID="m_Paper_StuSpecialtyLabel" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="m_Paper_DownloadButton" runat="server" Text="下载论文" OnClick="Paper_DownloadButton_Click"></asp:Button>
            <br />
            <br />
            <b>成绩：</b>
            <asp:TextBox ID="m_scoreTextBox" runat="server" Width="100px" Height="15px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="m_scoreConfirmButton" runat="server" Text="确认" OnClick="Paper_ScoreConfirmButton_Click"></asp:Button>
            </asp:Panel>
    </div>
    </form>
</body>
</html>
