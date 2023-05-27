<%@ Page Title="Artist Detail" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetailPage.aspx.cs" Inherits="KpopZtation.View.ArtistDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:1rem 2rem; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">
        <h1>Artist Detail Page</h1>
        <asp:Image ID="Image1" runat="server" Height="100" Width="100" />
        <p>Artist Name : <%= artistObject.ArtistName %></p>
    </div>
</asp:Content>
