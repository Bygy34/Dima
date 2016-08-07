<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>









<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <link rel="stylesheet" type="text/css" href="Content/Style1.css" />
        <link href="css/bootstrap.min.css" rel="stylesheet" />
   
        <div>
            <asp:Panel ID="tecnicaPanel" runat="server" ></asp:Panel>
        </div>

</asp:Content>


<asp:Content ID="LeftContent" ContentPlaceHolderID="ContentLeft" runat="server">
      <h2>Здесь можно добавлять разные устройства</h2>
     <asp:DropDownList ID="dropDownTecnicaList" runat="server">
                <asp:ListItem>Холодильник</asp:ListItem>
                <asp:ListItem>Магнитофон</asp:ListItem>
                <asp:ListItem>Телевизор</asp:ListItem>
                <asp:ListItem>Кондиционер</asp:ListItem>
                <asp:ListItem>Вентиляция</asp:ListItem>
                <asp:ListItem>Люстра</asp:ListItem>
            </asp:DropDownList>
    <br />
            <asp:Button ID="addTecnicaButton" runat="server" Text="Добавить" class="btn bottonos" />
            <br />
</asp:Content>




<asp:Content ID="RightContent" ContentPlaceHolderID="ContentRight" runat="server">

    <h2>Общие настройки</h2>
    <asp:Button ID="ToWork" runat="server" Text="На работу" CssClass="btn btn-primary bottonos" /><br />
    <asp:Button ID="FromWork" runat="server" Text="С работы" CssClass="btn btn-primary bottonos"  /><br />
    <asp:Button ID="Day" runat="server" Text="День" CssClass="btn btn-primary bottonos" /><br />
    <asp:Button ID="Night" runat="server" Text="Ночь" Cssclass="btn btn-primary bottonos" /><br />
    <asp:Button ID="SwitchOff" runat="server" Text="Отключит всё"  CssClass="btn btn-primary bottonos" />
 </asp:Content>