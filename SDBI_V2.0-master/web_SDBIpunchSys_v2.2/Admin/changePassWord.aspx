<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="changePassWord.aspx.cs" Inherits="Admin_changePassWord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong>修改密码</strong>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="tab_container">			
			<div id="tab2" class="tab_content">
			<table class="tablesorter" cellspacing="0"> 
			<thead>                   
			</thead> 
                <tbody>
                    <tr>
                        <td>
                            教师工号
                        </td>
                        <td>
                            <asp:TextBox ID="tx1" runat="server" placehoder="工号"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="seach" runat="server" Text="查询" OnClick="seach_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2"> 
                            <asp:Label ID="lbl1" runat="server" Text="教师信息"></asp:Label>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            新密码
                        </td>
                        <td>
                            <asp:TextBox ID="newPassword" runat="server" placehoder="新密码"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            确认新密码
                        </td>
                        <td>
                            <asp:TextBox ID="repeatPassword" runat="server" placehoder="重复新密码"></asp:TextBox>
                            <asp:Label ID="Label4" runat="server" ForeColor="#00CC00"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="bt" runat="server" Text="修改" OnClick="bt_Click" />
                            <asp:Label ID="Label5" runat="server" ForeColor="#00CC00"></asp:Label>
                        </td>
                    </tr>
                </tbody>       
			</table>
			</div>			
		</div>

</asp:Content>

