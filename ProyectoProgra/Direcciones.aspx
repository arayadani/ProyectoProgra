<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Direcciones.aspx.cs" Inherits="ProyectoProgra.Direcciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        ESTAMOS EN DIRECCIONES</p>
    <p>
        &nbsp;</p>
    <p>
        Provincias:
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
    <p>
        Districtos:&nbsp;<asp:GridView ID="GridView3" runat="server">
        </asp:GridView>
</p>
    <p>
        Canton:<asp:GridView ID="GridView2" runat="server" Height="152px">
        </asp:GridView>
</p>
    <p>
        Direcciones:<asp:GridView ID="GridView4" runat="server">
        </asp:GridView>
</p>
    <p>
        Codigo Direccion a modificar:<asp:TextBox ID="TcodigoDire" runat="server"></asp:TextBox>
</p>
    <p>
        Codigo Provincia:<asp:TextBox ID="Tprovincia" runat="server"></asp:TextBox>
</p>
    <p>
        Codigo Cliente:<asp:TextBox ID="Tcliente" runat="server"></asp:TextBox>
</p>
    <p>
        Codigo Districto:<asp:TextBox ID="Tdistricto" runat="server"></asp:TextBox>
</p>
    <p>
        Codigo Canton:<asp:TextBox ID="Tcanton" runat="server"></asp:TextBox>
</p>
    <p>
        Comentarios:<asp:TextBox ID="Tcomentarios" runat="server" Width="656px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
</p>
<p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Borrar" />
</p>
<p>
    <asp:Button ID="Modificar" runat="server" OnClick="Modificar_Click" Text="Modificar" />
</p>
<p>
</p>
<p>
</p>
</asp:Content>
