<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="ProyectoProgra.Facturacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>&nbsp;</h1>
    <p>
        <table border="2" style="width: 778px; height: 126px">
            <tr>
                <td class="auto-style3">Codigo</td>
                <td class="auto-style2"><strong>Producto</strong></td>
                <td class="auto-style2"><strong>Cantidad</strong></td>
                <td class="auto-style2"><strong>Precio</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="tcodigo" runat="server" OnTextChanged="tcodigo_TextChanged"></asp:TextBox>
                    &nbsp;&nbsp; </td>
                <td class="auto-style1">
                    <asp:TextBox ID="tnombre" runat="server" Enabled="False" Width="216px"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="tcantidad" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="tprecio" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Cliente</td>
                <td class="auto-style2"><strong>Fecha</strong></td>
                <td class="auto-style2"><strong>numero factura</strong></td>
                <td class="auto-style2"><strong>Sistema Ventas</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button button2" OnClick="Button1_Click" Text="INGRESAR" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AlternatingRowStyle-CssClass="alt" AutoGenerateColumns="False" CssClass="mGrid" GridLines="None" Height="84px" PagerStyle-CssClass="pgr" PageSize="7" style="margin-left: 0px" Width="792px">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                <asp:BoundField DataField="Subtotal" HeaderText="Subtotal" />
            </Columns>
        </asp:GridView>
    </p>
    <table border="1">
        <tr>
            <td class="auto-style1" style="height: 25px; width: 164px"><strong>SUBTOTAL</strong></td>
            <td class="auto-style1" style="height: 25px; width: 118px"><strong>IVA</strong></td>
            <td class="auto-style1" style="width: 663px; height: 25px;"><strong>TOTAL</strong></td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 164px; height: 26px">
                <asp:Label ID="LSB" runat="server" Font-Size="Large" Text="0"></asp:Label>
            </td>
            <td style="width: 118px; height: 26px">
                <asp:Label ID="LIVA" runat="server" Font-Size="Large" Text="0"></asp:Label>
            </td>
            <td class="auto-style1" style="width: 663px; height: 26px;">
                <asp:Label ID="LTOTAL" runat="server" Font-Size="Large" Text="0"></asp:Label>
            </td>
        </tr>
    </table>
    <p>
        <asp:Button ID="Bfacturar" runat="server" CssClass="button button3" OnClick="Bfacturar_Click" Text="FACTURAR" />
    </p>
</asp:Content>

