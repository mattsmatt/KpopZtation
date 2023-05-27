<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertAlbumPage.aspx.cs" Inherits="KpopZtation.View.InsertAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>INSERT ALBUM</h1>

        <asp:Label ID="LblAlbumName" runat="server" Text="Album Name"></asp:Label>
        <asp:TextBox ID="TxtAlbumName" runat="server"></asp:TextBox>

        <asp:Label ID="lblAlbumDesc" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
</asp:Content>
