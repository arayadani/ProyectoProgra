<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="ProyectoProgra.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
</p>
ESTAMOS EN PRODUCTOS<br />
<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
<br />
<br />
<br />
Nombre del producto:<asp:TextBox ID="Tnombrepro" runat="server"></asp:TextBox>
<br />
<br />
Precio:<asp:TextBox ID="Tpreciopro" runat="server"></asp:TextBox>
<br />
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
<asp:Button ID="Button2" runat="server" Text="Borrar" OnClick="Button2_Click" />
<asp:Button ID="Button3" runat="server" Text="Modificar precio" OnClick="Button3_Click" />
</asp:Content>
