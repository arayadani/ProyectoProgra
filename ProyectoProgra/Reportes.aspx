<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ProyectoProgra.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    ESTAMOS EN&nbsp; REPORTES.</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="correo" DataValueField="correo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoFinalUHConnectionString %>" SelectCommand="SELECT [correo] FROM [Usuarios] WHERE ([tipo] = @tipo)">
            <SelectParameters>
                <asp:Parameter DefaultValue="regular" Name="tipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Datos Usuarios" />
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Datos clientes" />
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" Text="Facturas" />
    </p>
    <p>
        <asp:Button ID="Button6" runat="server" Text="Direcciones" />
    </p>
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Rutinas" />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
