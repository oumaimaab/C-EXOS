<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-default">
                    <div class="panel-heading"><h5 class="panel-title text-center">Real Time Converter</h5></div>
                    <div class="panel-body">
                            <div class="form-group col-md-6">
                                <label for="exampleInputPassword1">Choose Currency</label>
                                <asp:DropDownList  runat="server" ID="currencyFrom" class="form-control">
                                   <asp:ListItem Selected="True" Value=""> --Choose-- </asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="exampleInputPassword1">Choose Currency</label>
                                <asp:DropDownList  runat="server" ID="currencyTo" class="form-control">
                                   <asp:ListItem Selected="True" Value=""> --Choose-- </asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group col-md-12 text-center">
                                <asp:Button runat="server" OnClick="convert" AutoPostBack="false"  class="btn btn-primary" Text="Convert" />
                            </div>
                            <div class="form-group col-md-12 text-center">
                                <asp:Label ID="result" runat="server" Text="Hello world" ></asp:Label>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
