<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/MasterPage.master" AutoEventWireup="true" CodeFile="showMasage.aspx.cs" Inherits="Teacher_showMasage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><strong>未读消息</strong></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Repeater ID="repeater1" runat="server" OnItemCommand="repeater1_ItemCommand">
        <HeaderTemplate>
            <header><h3>Messages</h3></header>
			<div class="message_list">
				<div class="module_content">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="message">
                <p><h5><asp:Label ID="lblTitle" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"title")%>></asp:Label></h5></p>
                <p><asp:Label ID="lblMesage" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"Message")%>></asp:Label></p>
			    <p><strong>
                    <asp:Label ID="lblTime" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"MessageTime")%>></asp:Label>
			       </strong>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="bt1" runat="server" Text="已读" />

			    </p>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
			</div>
        </FooterTemplate>
    </asp:Repeater>
			
					
		
			
		
</asp:Content>

