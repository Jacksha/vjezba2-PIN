<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="vjezba2.Shop" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h4>Shop</h4>
        
        <asp:Label ID="Label1" runat="server" Text="Naziv:"></asp:Label>
        <asp:TextBox ID="tb_pime" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Naziv je obavezan podatak!" ForeColor="Red" ControlToValidate="tb_pime"></asp:RequiredFieldValidator><br />
        
        <asp:Label ID="Label4" runat="server" Text="Opis:"></asp:Label>        
        <asp:TextBox ID="tb_opis" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Opis je obavezan podatak!" ForeColor="Red" ControlToValidate="tb_opis"></asp:RequiredFieldValidator><br />
        
        <asp:Label ID="Label5" runat="server" Text="Kategorija:"></asp:Label>    
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Spremi" />
        <br />
        <br />

        <asp:GridView ID="gridProducts" runat="server">
        </asp:GridView>
    </div>
</asp:Content>
