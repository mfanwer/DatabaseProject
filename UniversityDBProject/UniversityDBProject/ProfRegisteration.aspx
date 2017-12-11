<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ProfRegisteration.aspx.cs" Inherits="UniversityDBProject.ProfRegisteration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div id="div">
    
        Name
        <asp:TextBox ID="TextBox1" CssClass="TextBox" runat="server" required></asp:TextBox>
        <br />
        <br />
        UserName
        <asp:TextBox CssClass="TextBox" ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Password
        <asp:TextBox CssClass="TextBox" ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        Department
        <asp:DropDownList ID="DropDownList1" CssClass="DropDownList1" runat="server" AutoPostBack="True" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Subjects"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
       <br />
        <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Register" OnClick="Button1_Click"/>
    <br/>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    </form>
</asp:Content>
