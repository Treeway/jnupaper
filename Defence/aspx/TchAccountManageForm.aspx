<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TchAccountManageForm.aspx.cs" Inherits="Defence.TchAccountManageForm" %>
<%@ Register TagPrefix="topwin" TagName="c_topwin" Src="/c_topwin_tch.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link rel="stylesheet" href="../css/TableStyleSheet1.css">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        
        .auto-style12 {
            width: 270px;
            height: 31px;
        }
        .auto-style17 {
            width: 178px;
            height: 31px;
        }
        .auto-style24 {
            width: 178px;
            height: 38px;
        }
        .auto-style25 {
            width: 270px;
            height: 38px;
        }
        .auto-style26 {
            width: 178px;
            height: 16px;
        }
        .auto-style27 {
            width: 270px;
            height: 16px;
        }
        .auto-style28 {
            width: 178px;
            height: 20px;
        }
        .auto-style29 {
            width: 270px;
            height: 20px;
        }
        .auto-style30 {
            width: 178px;
            height: 22px;
        }
        .auto-style31 {
            width: 270px;
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position: absolute; top: -4px; left: -33px; height: 717px;">
            <topwin:c_topwin runat="server" ID="c_topwin19" />
            <asp:Panel ID="m_tchAccountManagePanel" runat="server" Style="position: absolute; top: 261px; left: 535px; height: 255px; width: 452px; margin-left: 0px; margin-bottom: 17px;" Font-Size="11pt">
                <table style="width: 100%; margin-top: 0px; height: 254px;" class="login-help">
                    <tr class="tr">
                        <td class="td">&nbsp;&nbsp;&nbsp;&nbsp; 工号:</td>
                        <td class="td">
                            <asp:Label ID="m_Account_TchIdLabel" runat="server" Font-Size="11pt"></asp:Label>
                        </td>
                    </tr>
                    <tr class="tr">
                        <td class="td">请输入原密码：</td>
                        <td class="td">
                            <asp:TextBox ID="m_Account_OriginalPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr class="tr">
                        <td class="td">请输入新密码：</td>
                        <td class="td">
                            <asp:TextBox ID="m_Account_NewPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr class="tr">
                        <td class="td">请确认新密码：</td>
                        <td class="td">
                            <asp:TextBox ID="m_Account_ConfirmNewPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr class="tr">
                        <td class="td"></td>
                        <td class="td">
                            <asp:Button ID="m_TchAccount_ConfirmButton" runat="server" Height="25px" Text="确定" Width="65px" OnClick="TchAccount_ConfirmButton_Click" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                &nbsp;&nbsp;</asp:Panel>
        </div>
    </form>
</body>
</html>
