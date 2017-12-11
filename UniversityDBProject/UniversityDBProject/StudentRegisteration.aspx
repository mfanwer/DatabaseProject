<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="StudentRegisteration.aspx.cs" Inherits="UniversityDBProject.StudentRegisteration" %>
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

        Date of Birth 
        <asp:TextBox ID="TextBox2" CssClass="TextBox" runat="server"  TextMode="Date"></asp:TextBox>  
       
        <br />
         Address
        <textarea id="TextArea1"   cols="20" name="S1" rows="3"  runat="server" ></textarea><br />
        <br />
        Department
        <asp:DropDownList ID="DropDownList1" CssClass="DropDownList1" runat="server" AutoPostBack="True" AppendDataBoundItems="True" >
        </asp:DropDownList>
        <br />
        <br />
        Term
        <asp:DropDownList ID="DropDownList2" CssClass="DropDownList1"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Summer</asp:ListItem>
            <asp:ListItem>Spring</asp:ListItem>
            <asp:ListItem>Fall</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Subjects" Visible="False"></asp:Label><br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
       <br />
        <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Register" OnClick="Button1_Click"/>
    <br/>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    </form>

</asp:Content>
