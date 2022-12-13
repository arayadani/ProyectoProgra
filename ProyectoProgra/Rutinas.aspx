<%@ Page Title="" Language="C#" MasterPageFile="~/regular.Master" AutoEventWireup="true" CodeBehind="Rutinas.aspx.cs" Inherits="ProyectoProgra.Rutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>
    <br />
</p>
<p>
    ESTAS EN TUS RUTINAS &lt;3</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
        </p>
    <br />
    Consultar Rutina:
    <asp:TextBox ID="Trutina" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoFinalUHConnectionString %>" SelectCommand="SELECT [id_rutina] FROM [rutinas]"></asp:SqlDataSource>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="CONSULTAR" OnClick="Button1_Click" />
    <br />
    <br />
&nbsp;
    <br />
    <br />
    <br />
    &nbsp;<br />
    <asp:Button ID="Button2" runat="server" Text="MODIFICAR" OnClick="Button2_Click" />
    <br />
<p>
    <asp:DropDownList ID="Rutinas_DD" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_rutina" DataValueField="id_rutina" >
    </asp:DropDownList>
    </p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</form>
</asp:Content>
