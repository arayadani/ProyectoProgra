<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ProyectoProgra.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>&nbsp;</h1>
    <h1><span style="font-weight: normal; color: #FF0066"><strong>ESTAMOS EN USUARIOS :)</strong></span></h1>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>Correo:</p>
    <p>
        <asp:TextBox ID="tcorreoUSU" runat="server" ></asp:TextBox>
    </p>
    <p>Contraseña:</p>
    <p>
        <asp:TextBox ID="TclaveUSU" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>Tipo:</p>
    <asp:TextBox ID="TtipoUSU" runat="server"></asp:TextBox>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" />
    </p>
    <asp:Button ID="Button2" runat="server" Text="Borrar" OnClick="Button2_Click" />
    <p>
        <asp:Button ID="Button4" runat="server" Text="Modificar" OnClick="Button4_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
