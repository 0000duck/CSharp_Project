<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="TeacherStatus.aspx.cs" Inherits="Admin_TeacherStatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>教师情况</strong>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <div class="tab_container">			
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			<thead>                   
			</thead>  
                <tbody>
                    <tr>
                        <td>查询范围:<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                        <td><asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" /></td>                        
                    </tr>
                    <tr>
                        <td colspan="3"><asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" CssClass="tablesorter">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="TeacherID" HeaderText="教工号" />
                                <asp:BoundField DataField="TeacherName" HeaderText="姓名" />
                                <asp:BoundField DataField="TrueWeek" HeaderText="周次" />
                                <asp:BoundField DataField="Weeks" HeaderText="星期" />
                                <asp:BoundField DataField="Times" HeaderText="节次" />
                                <asp:BoundField DataField="Course" HeaderText="课程" />
                                <asp:BoundField DataField="IsaAttendance" HeaderText="考勤情况" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </td>
                    </tr>
                </tbody>      
			</table>
			</div>			
		</div>
</asp:Content>


