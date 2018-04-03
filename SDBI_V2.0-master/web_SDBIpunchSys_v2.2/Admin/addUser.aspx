<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="addUser.aspx.cs" Inherits="Admin_addUser" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>新增教师</strong>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <div class="tab_container">
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			<thead> 
				<tr> 
   					<th></th> 
    				<th>教师类型</th> 
    				<th>所属部门</th> 
    				<th>教师工号</th> 
    				<th>教师姓名</th>
                    <th>密码</th>
                    <th>性别</th>
                    <th>权限</th> 
				</tr> 
			</thead> 
			<tbody> 
				<tr>
                     <td>

                    </td>
                    <td><asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="TabTeachers">本校教师</asp:ListItem>
                        <asp:ListItem Value="TabOtherTeachers">外聘教师</asp:ListItem>
                        </asp:DropDownList></td>
                    <td><asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>安全保卫处</asp:ListItem>
                        <asp:ListItem>办公室</asp:ListItem>
                        <asp:ListItem>财务审计处</asp:ListItem>
                        <asp:ListItem>成人教育处</asp:ListItem>
                        <asp:ListItem>会计系</asp:ListItem>
                        <asp:ListItem>机械工程系</asp:ListItem>
                        <asp:ListItem>基础教学部</asp:ListItem>
                        <asp:ListItem>建筑工程系</asp:ListItem>
                        <asp:ListItem>教务处</asp:ListItem>
                        <asp:ListItem>教学研究室</asp:ListItem>
                        <asp:ListItem>经济管理系</asp:ListItem>
                        <asp:ListItem>商务外语系</asp:ListItem>
                        <asp:ListItem>实训中心</asp:ListItem>
                        <asp:ListItem>食品工程系</asp:ListItem>
                        <asp:ListItem>宿舍管理中心</asp:ListItem>
                        <asp:ListItem>图书馆</asp:ListItem>
                        <asp:ListItem>网络信息中心</asp:ListItem>
                        <asp:ListItem>校领导</asp:ListItem>
                        <asp:ListItem>信息工程系</asp:ListItem>
                        <asp:ListItem>学生工作处</asp:ListItem>
                        <asp:ListItem>饮食服务中心</asp:ListItem>
                        <asp:ListItem>招生就业办公室</asp:ListItem>
                        <asp:ListItem>总务处</asp:ListItem>
                        <asp:ListItem>组织人事处</asp:ListItem>
                        </asp:DropDownList></td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td><asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                        </asp:DropDownList></td>  
                    <td><asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList></td>
                   
				</tr>
                <tr>
                    <td></td><td></td><td></td><td></td><td></td><td></td>
                    <td><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td>
                    <td><asp:Label ID="Label1" runat="server" ForeColor="#009900"></asp:Label></td>
                    
                </tr>
			</tbody> 
			</table>

			</div>
			
		</div>
		
		
</asp:Content>

