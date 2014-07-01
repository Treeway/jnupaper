<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuTitleSelectForm.aspx.cs" Inherits="Defence.StuTitleSelectForm" %>
<%@ Register TagPrefix="topwin" TagName="c_topwin" Src="/c_topwin.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; top: -4px; left: -33px; height: 717px;">
        <topwin:c_topwin runat="server" id="c_topwin1"/>
        <asp:Panel ID="m_stuTitleSelectPanel" runat="server" style="position: absolute; top: 241px; left: 302px; height: 396px; width: 885px;">
            &nbsp;&nbsp;<asp:Button ID="m_availableTitleButton" runat="server" Text="可选题目" OnClick="m_availableTitleButton_Click" />
            &nbsp;<asp:Button ID="m_myTitleButton" runat="server" Text="我的选题" OnClick="m_myTitleButton_Click" />
            <br />
            <br />
            <asp:Table ID="m_availableTitleTable" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CellPadding="0" CellSpacing="0" HorizontalAlign="Center" 

Height="25px" >
                <asp:TableRow ID="TableRow1" runat="server" HorizontalAlign="Center">
                    <asp:TableCell ID="TableCell1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="50px">
                        <asp:Button ID="Button1" runat="server" Text="选题" />
                    
</asp:TableCell>
                    <asp:TableCell ID="TableCell2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="80px">选题编号</asp:TableCell>
                    <asp:TableCell ID="TableCell3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="270px">选题题目</asp:TableCell>
                    <asp:TableCell ID="TableCell4" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="270px">选题简介</asp:TableCell>
                    <asp:TableCell ID="TableCell5" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="80px">指导老师</asp:TableCell>
                    <asp:TableCell ID="TableCell6" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="80px">专业</asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <asp:Table ID="m_myTitleTable" runat="server" style="position: absolute; top: 43px; left: 20px;" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CellPadding="0" 

CellSpacing="0" HorizontalAlign="Center" Height="25px" Visible="False">
                <asp:TableRow ID="TableRow2" runat="server" HorizontalAlign="Center">
                    <asp:TableCell ID="TableCell7" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="100px">学号</asp:TableCell>
                    <asp:TableCell ID="TableCell8" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="70px">姓名</asp:TableCell>
                    <asp:TableCell ID="TableCell9" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="100px">学院</asp:TableCell>
                    <asp:TableCell ID="TableCell10" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="80px">专业</asp:TableCell>
                    <asp:TableCell ID="TableCell11" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="80px">选题编号</asp:TableCell>
                    <asp:TableCell ID="TableCell12" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="270px">选题题目</asp:TableCell>
                    <asp:TableCell ID="TableCell13" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="70px">指导老师</asp:TableCell>
                    <asp:TableCell ID="TableCell14" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="70px">选题状态</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
