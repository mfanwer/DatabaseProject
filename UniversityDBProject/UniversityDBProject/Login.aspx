<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UniversityDBProject.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
    <div id="div" style="width:70%;margin:auto;padding:10px;text-align:center">
    
        UserName
        <asp:TextBox ID="TextBox1"  CssClass="TextBox" runat="server"  required></asp:TextBox>
        <br />
        <br />
        Password
        <asp:TextBox ID="TextBox2" CssClass="TextBox"  runat="server" required></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Login" OnClick="Button1_Click" />
    <br/>
        <asp:Label ID="Label1" runat="server"></asp:Label>
  
    </div>
    </form>
</asp:Content>
