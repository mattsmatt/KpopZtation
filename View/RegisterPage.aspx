<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="KpopZtation.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>KpopZtation - Register</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>REGISTER</h1>

        <div>
            <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="LblGender" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="RBLGender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div>
            <asp:Label ID="LblAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div>
            <asp:CheckBox ID="CBTerms" runat="server" Text="I Agree to the Terms and Conditions" />
        </div>

        <div>
            <asp:Label ID="LblError" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>

        <div>
            <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click" />
        </div>
    </div>
</asp:Content>
