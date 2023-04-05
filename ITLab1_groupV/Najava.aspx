<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="ITLab1_groupV.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-bottom: 10px;">
        <div style="display: inline-block; width : 100px;">
            <asp:Label ID="lblName" runat="server" Text="Име"></asp:Label>
        </div>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator1"
            runat="server"
            ErrorMessage="Внесете име"
            class="text-danger"
            ControlToValidate="name">

        </asp:RequiredFieldValidator>
    </div>

    <div style="margin-bottom: 10px;">
        <div style="display: inline-block; width : 100px;">
            <asp:Label ID="lblPassword" runat="server" Text="Лозинка"></asp:Label>
        </div>
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator2"
            runat="server"
            ErrorMessage="Внесете лозинка"
            class="text-danger"
            ControlToValidate="password">

        </asp:RequiredFieldValidator>
    </div>

    <div style="margin-bottom: 10px;">
        <div style="display: inline-block; width : 100px;">
            <asp:Label ID="lblEmail" runat="server" Text="е-адреса"></asp:Label>
        </div>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator3"
            runat="server"
            ErrorMessage="Внесете е-адреса"
            class="text-danger"
            ControlToValidate="email">

        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator
            ID="RegularExpressionValidator1"
            runat="server"
            ErrorMessage="Невалиден формат"
            class="text-danger"
            ControlToValidate="email"
            ValidationExpression="[\w.-]+\@\w+\.[\w.-]+"></asp:RegularExpressionValidator>
    </div>

    <div style="margin-left: 105px; margin-top: 10px;">
        <asp:Button ID="btnLogin" runat="server" Text="Најавете се" OnClick="btnLogin_Click" />
    </div>
</asp:Content>
