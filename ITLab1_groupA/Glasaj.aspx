<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="ITLab1.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Image ID="logo" runat="server" ImageUrl="/Лого-ФИНКИ.jpg" />
    </div>

    <br />

    <div class="row">
        <asp:Label ID="professor" runat="server" Text="Проф. д-р Гоце Арменски"></asp:Label>
    </div>

    <br />

    <div style="display: inline-block">
        <asp:ListBox ID="subjects" runat="server" OnSelectedIndexChanged="subjects_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="IT" Selected="True">Интернет технологии</asp:ListItem>
            <asp:ListItem Value="I">Интернет</asp:ListItem>
            <asp:ListItem Value="DE">Дигитална електроника</asp:ListItem>
        </asp:ListBox>
    </div>

    <div style="display: inline-block">
        <asp:ListBox ID="credits" runat="server">
            <asp:ListItem Value="6" Selected="True">6</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
            <asp:ListItem>5.5</asp:ListItem>
        </asp:ListBox>
    </div>

    <br />
    <br />

    <div>
        <asp:Button ID="vote" runat="server" Text="Гласајте" OnClick="vote_Click" />
    </div>
</asp:Content>
