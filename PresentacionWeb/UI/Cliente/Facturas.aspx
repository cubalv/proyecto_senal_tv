<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Cliente/MasterCliente.Master" AutoEventWireup="true" CodeBehind="Facturas.aspx.cs" Inherits="PresentacionWeb.UI.Cliente.Facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container col w-100 mt-4">
        <div class="w-100">
            <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="False" Width="441px" CssClass="table table-striped table-hover table-responsive w-100 mt-3" AllowPaging="True" PageSize="5" AutoGenerateSelectButton="True" OnSelectedIndexChanged="grid1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                    <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="nit" HeaderText="NIT" />
                    <asp:BoundField DataField="monto" HeaderText="Monto" />
                    <asp:BoundField DataField="mora" HeaderText="Mora" />
                    <asp:BoundField DataField="total" HeaderText="Total" />
                </Columns>
            </asp:GridView>
        </div>        
        <div class="w-100 d-flex justify-content-end flex-wrap">
            <div class ="w-100"><p class=" fw-bold me-4 d-flex flex-row align-items-center">Codigo: <asp:Label ID="lblCodigo" runat="server" Text="0" CssClass="fw-light ms-2"></asp:Label></p></div>
            <div class ="w-100 mt-3"><p class=" fw-bold me-3 mb-0">Direccion</p><asp:TextBox ID="tbDireccion" runat="server" CssClass="form-control" TextMode="MultiLine" ReadOnly="True"></asp:TextBox></div>
            <div class ="w-100 mt-3"><p class=" fw-bold me-3 mb-0">Monto del plan</p><asp:TextBox ID="tbMonto" runat="server" CssClass="form-control text-end" ReadOnly="True"></asp:TextBox></div>
            <div class ="w-100 mt-3"><p class=" fw-bold me-3 mb-0">Mora acumulada</p><asp:TextBox ID="tbMora" runat="server" CssClass="form-control text-end" ReadOnly="True"></asp:TextBox></div>
            <div class ="w-100 mt-3"><p class=" fw-bold me-3 mb-0">Total</p><asp:TextBox ID="tbTotal" runat="server" CssClass="form-control text-end" ReadOnly="True"></asp:TextBox></div>
        </div>
        <div class=" d-flex justify-content-end mt-3">            
            <asp:Button runat="server" Text="Pagar" CssClass="btn btn-warning" OnClick="Unnamed1_Click"/>
            <asp:Button runat="server" Text="Cancelar" CssClass="btn btn-outline-secondary ms-2" OnClick="btnCancelar_click"/>
        </div>
    </div>
</asp:Content>
