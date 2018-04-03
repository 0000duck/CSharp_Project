<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="TeacherList.aspx.cs" Inherits="Admin_TeacherList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>本校教师</strong>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="tablesorter" cellspacing="0"> 
			<thead> 
				<tr> 
   					<th class="header">查询范围</th>
                    <th class="header">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="All">所有记录</asp:ListItem>
                            <asp:ListItem Value="TeacherID">按教师工号查询</asp:ListItem>
                            <asp:ListItem Value="TeacherName">按教师姓名查询</asp:ListItem>
                            <asp:ListItem Value="TeacherRole">按权限查询</asp:ListItem>
                            <asp:ListItem>按部门查询</asp:ListItem>
                        </asp:DropDownList></th> 
                    <th class="header">查询条件</th>
                    <th class="header">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></th> 
                    <th class="header">
                        <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" /></th>
				</tr> 
			</thead> 
        </table>

        <asp:GridView ID="GridView1" runat="server" CellPadding="4" CssClass="tablesorter" ForeColor="#333333" GridLines="Vertical" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleted="GridView1_RowDeleted" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        
        <Columns>
            <asp:BoundField HeaderText="系部" DataField="Department"/>
            <asp:BoundField DataField="UserID" HeaderText="工号" />
            <asp:BoundField DataField="UserName" HeaderText="姓名" />
            <asp:BoundField DataField="Role" HeaderText="权限" />
            
            <asp:CommandField ShowEditButton="True" HeaderText="编辑" ButtonType="Button" />
            <asp:CommandField ShowDeleteButton="True" HeaderText="删除" ButtonType="Button" />
        </Columns>
        
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    
    </asp:Content>

