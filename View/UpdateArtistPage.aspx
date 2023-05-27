<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateArtistPage.aspx.cs" Inherits="KpopZtation.View.UpdateArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Page</h1>
    <div>
        <h2>Artist Data</h2>
        <asp:Label ID="LblNameBefore" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:Label ID="LblImageBefore" runat="server" Text="Image"></asp:Label>
        <br />

        <h2>New Artist Data</h2>
        <asp:Label ID="LblArtistName" runat="server" Text="Artist Name"></asp:Label>
        <asp:TextBox ID="TxtArtistName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LblArtistImage" runat="server" Text="Artist Image"></asp:Label>
        <br />
        <asp:FileUpload ID="ArtistImageFileUpload" runat="server" />
        <br />
        <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
        <br />

        <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
    </div>
</asp:Content>
