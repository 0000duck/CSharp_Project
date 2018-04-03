<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="notify.aspx.cs" Inherits="Admin_notify" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    发布通知
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
			
				<div class="module_content">
						<fieldset>
							<label>标题</label>
							
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
						</fieldset>
						<fieldset>
							<label>内容</label>&nbsp;
                            <asp:TextBox ID="TextBox1" runat="server" Height="240px" Rows="12" MaxLength="8000" TextMode="MultiLine" style="resize:none" ></asp:TextBox>
						</fieldset>
						<fieldset style="width:48%; float:left; margin-right: 3%;"> <!-- to make two field float next to one another, adjust values accordingly -->
							<label>通知级别</label>&nbsp;
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>全校教师</asp:ListItem>
                                <asp:ListItem>管理员</asp:ListItem>
                                <asp:ListItem>院校领导</asp:ListItem>
                                <asp:ListItem>系辅导员</asp:ListItem>
                            </asp:DropDownList>
                            </fieldset>

						<div class="clear"></div>
				</div>
			<footer>
				<div class="submit_link">

					&nbsp;<asp:Button ID="Button1" runat="server" CssClass="alt_btn" Text="提交" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="重写" OnClick="Button2_Click" />
					&nbsp;</div>
			    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			    <asp:Label ID="Label1" runat="server" ForeColor="#00CC00"></asp:Label>
			    
			</footer>
		
</asp:Content>

