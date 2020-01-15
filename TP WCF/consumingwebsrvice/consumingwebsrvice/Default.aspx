<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <div class="row">
        <div class="col-md-4">
            <h2>Convertisseur</h2>
            <asp:Label ID="Label1" runat="server" Text="Label">Choisir une devise</asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
       
    </div>
    
</asp:Content>
