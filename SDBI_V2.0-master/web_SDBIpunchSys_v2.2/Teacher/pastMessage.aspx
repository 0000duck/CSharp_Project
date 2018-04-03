<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/MasterPage.master" AutoEventWireup="true" CodeFile="pastMessage.aspx.cs" Inherits="Teacher_pastMessage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><strong>历史消息</strong></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <asp:Repeater ID="repeater1" runat="server">
        <HeaderTemplate>
            <header><h3>Messages</h3></header>
			<div class="message_list">
				<div class="module_content">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="message">
                <p><h5><asp:Label ID="lblTitle" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"title")%>></asp:Label></h5></p>
                <p><asp:Label ID="lblMesage" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"Mesage")%>></asp:Label></p>
			    <p><strong>
                    <asp:Label ID="lblTime" runat="server" Text=<%#DataBinder.Eval(Container.DataItem,"Time")%>></asp:Label>
			       </strong>
			    </p>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
			</div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

