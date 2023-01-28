<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="vjezba2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <h3>Odaberi:</h3>
    <br />
    <div>
            <asp:Button ID="btnRegistracija" runat="server" OnClick="btnRegistracija_Click" Text="Registracija" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </div>
   

</asp:Content>
