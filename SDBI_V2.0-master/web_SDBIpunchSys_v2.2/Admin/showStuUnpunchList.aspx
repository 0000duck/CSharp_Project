<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="showStuUnpunchList.aspx.cs" Inherits="Admin_showStuUnpunchList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>缺勤汇总</strong>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="tab_container">			
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			              
			 <tbody>
                  <tr>
                      <td>
                          <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="tablesorter" AutoGenerateColumns="False">
                              <AlternatingRowStyle BackColor="White" />
                              <Columns>
                                  <asp:BoundField DataField="TeacherName" HeaderText="教师姓名" />
                                  <asp:BoundField DataField="StuDepartment" HeaderText="学生系别" />
                                  <asp:BoundField DataField="Class" HeaderText="班级" />
                                  <asp:BoundField DataField="StuID" HeaderText="学号" />
                                  <asp:BoundField DataField="StuName" HeaderText="姓名" />
                                  <asp:BoundField DataField="Cource" HeaderText="课程" />
                                  <asp:BoundField DataField="Type" HeaderText="缺勤状态" />
                                  <asp:BoundField DataField="Weeks" HeaderText="周次" />
                                  <asp:BoundField DataField="ranges" HeaderText="节次" />
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
                      </td>
                      
                  </tr>             
			</tbody> 
			</table>
			</div>			
		</div>
</asp:Content>

