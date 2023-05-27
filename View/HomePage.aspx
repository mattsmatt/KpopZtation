<%@ Page Title="Home" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>KpopZtation - Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" margin: 1rem 2rem; display:flex; flex-direction:column; gap:10px; align-items:center">
        <h1>Home Page</h1>
        <asp:GridView ID="artistTable" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="artistTable_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="ArtistID" CellPadding="5" OnRowUpdating="artistTable_RowUpdating">
            <Columns>
                <asp:BoundField DataField="ArtistID" HeaderText="ArtistID" InsertVisible="False" ReadOnly="True" SortExpression="ArtistID" />
                <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="imageControl" runat="server" Height="100" Width="100" ImageUrl='<%# "~/Assets/Artist/"+ Eval("ArtistImage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField CommandName="Update" Text="View Discography" />
            </Columns>
        </asp:GridView>

  
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Artist]"></asp:SqlDataSource>--%>

            
    <div style="display:flex; gap:10px">
    <% foreach(var artist in artistList)
        {%>
        <div style="border:1px solid black; width:max-content; padding:10px 20px;">
            <a href="ArtistDetailPage.aspx?ArtistID=<%= artist.ArtistID%>">
            <% GetImageUrl(artist); %>
            <asp:Image ID="Image1" runat="server"  Height="100" Width="100" />
            <p>ArtistID <%= artist.ArtistID %></p>
            <p><%= artist.ArtistName %></p>
            </a>
        </div>
    <% 
        }%>
    </div>

        <div id="AdminHome" runat="server">
            <asp:Label ID="LblSelectedArtistID" runat="server" Text="Artist ID"></asp:Label>
            <asp:TextBox ID="TxtSelectedArtistID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LblSelectedArtistName" runat="server" Text="Artist Name"></asp:Label>
            <asp:TextBox ID="TxtSelectedArtistName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="BtnInsert" runat="server" Text="Insert Artist" OnClick="BtnInsert_Click" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Update Artist" OnClick="BtnUpdate_Click" />
            <asp:Button ID="BtnDelete" runat="server" Text="Delete Artist" OnClick="BtnDelete_Click" />
        </div>
    </div>
</asp:Content>
