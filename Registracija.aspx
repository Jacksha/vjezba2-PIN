<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="vjezba2.Registracija" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <h4>Registriraj se</h4>
            <asp:Label ID="Label1" runat="server" Text="Korisničko ime:"></asp:Label>
            <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Korisničko ime je obavezan podatak!" ForeColor="Red" ControlToValidate="tb_kime"></asp:RequiredFieldValidator><br />
            <asp:Label ID="Label4" runat="server" Text="Puno ime:"></asp:Label>
            <asp:TextBox ID="tb_punoime" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Lozinka:"></asp:Label>
            <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Ponovljena lozinka:"></asp:Label>
            <asp:TextBox ID="tb_lozinka2" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Registriraj" OnClick="Button1_Click" />

        </div>
</asp:Content>
