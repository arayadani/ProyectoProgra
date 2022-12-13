<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="RutinaAdmin.aspx.cs" Inherits="ProyectoProgra.RutinaAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    ESTAMOS EN RUTINAS ADMINISTRACION
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
<p>
    Nombre de la rutina:<asp:TextBox ID="NombreRuti" runat="server"></asp:TextBox>
</p>
<asp:Button ID="AgregarRuti" runat="server" Text="Agregar" OnClick="AgregarRuti_Click" />
<p>
    <asp:Button ID="ModificarRuti" runat="server" Text="Modificar" OnClick="ModificarRuti_Click" />
</p>
<asp:Button ID="BorrarRuti" runat="server" OnClick="Button3_Click" Text="Borrar" />
</asp:Content>
