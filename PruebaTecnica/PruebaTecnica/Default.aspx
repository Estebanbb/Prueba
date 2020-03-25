<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PruebaTecnica._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel"  runat="server">
        <ContentTemplate>
            <table class="maintable">
                <tr>
                    <td colspan="8" style="text-align:center">
                        <h2>Ensamblaje de Computadoras</h2>
                    </td>
                </tr>
                <tr>
                    <td colspan="8"><br /></td>
                </tr>
                <tr>
                    <td colspan="8" style="text-align:right">
                        <asp:Button ID="BtnSave" runat="server" Text="Guardar" />
                        <asp:Button ID="BtnEdit" runat="server" Text="Editar" />
                        <asp:Button ID="BtnSearch" runat="server" Text="Buscar" />
                        <asp:Button ID="BtnRefresh" runat="server" Text="Limpiar" />
                    </td>
                </tr>
                <tr>
                    <td colspan="8"><br /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblId" runat="server" Text="N° Cliente: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblEstado" runat="server" Text="Estado: "></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="CmbEstado" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                     <td>
                        <asp:Label ID="lblApellido" runat="server" Text="Apellido: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                     <td>
                        <asp:Label ID="lblIdentificacion" runat="server" Text="Identificacion: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblPais" runat="server" Text="Pais: "></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="CmbPais" AutoPostBack="true" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="lblCiudad" runat="server" Text="Ciudad: "></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="CmbCiudad" runat="server"></asp:DropDownList>
                    </td>
                   
                </tr>
                <tr>
                     <td>
                        <asp:Label ID="lblNumeroCompras" runat="server" Text="N° Compras: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNumeroCompras" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCodigo" runat="server" Text="Codigo Cliente: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblRedSocial" runat="server" Text="Red Social: "></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txtRedSocial" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblEdad" runat="server" Text="Edad: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:10%"></td>
                    <td style="width:16%"></td>
                    <td style="width:10%"></td>
                    <td style="width:16%"></td>
                    <td style="width:10%"></td>
                    <td style="width:16%"></td>
                    <td style="width:10%"></td>
                    <td style="width:16%"></td>
                </tr>
            </table>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
