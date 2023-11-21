<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Cliente/MasterCliente.Master" AutoEventWireup="true" CodeBehind="servicios.aspx.cs" Inherits="PresentacionWeb.UI.Cliente.servicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container col w-100 mt-4">
        <div class="w-100">
            <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="False" Width="441px" CssClass="table table-striped table-hover table-responsive w-100 mt-3" AllowPaging="True" PageSize="5" AutoGenerateSelectButton="True" OnSelectedIndexChanged="grid1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                    <asp:BoundField DataField="fechaContra" HeaderText="Fecha contratado" />
                    <asp:BoundField DataField="plan" HeaderText="Plan contratado" />
                    <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="detalles" HeaderText="Detalles" />
                </Columns>
            </asp:GridView>
        </div>            
        <div class=" d-flex justify-content-end mt-3 flex-column">
            <div class ="w-100"><p class=" fw-bold me-4 d-flex flex-row align-items-center">Codigo: <asp:Label ID="lblCodigo" runat="server" Text="0" CssClass="fw-light ms-2"></asp:Label></p></div>
            <div class ="w-100"><p class=" fw-bold me-3 mb-0">Plan</p><asp:TextBox ID="tbPlan" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox></div>
            <div class ="w-100 mt-3"><p class=" fw-bold me-3 mb-0">Fecha contratacion</p><asp:TextBox ID="tbFechaContratacion" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox></div>
            <div class ="w-100 mt-3"><p class=" fw-bold me-3 mb-0">Direccion</p><asp:TextBox ID="tbDireccion" runat="server" CssClass="form-control"  ReadOnly="True"></asp:TextBox></div>
            <div class ="w-100 mt-3"><p class=" fw-bold me-3 mb-0">Detalles</p><asp:TextBox ID="tbDetalle" runat="server" CssClass="form-control" ReadOnly="True" TextMode="MultiLine"></asp:TextBox></div>
        </div>
        <div class=" d-flex justify-content-end mt-3">            
            <asp:Button ID="btnReportarError" runat="server" Text="Programar revision" CssClass="btn btn-outline-info ms-2" OnClick="btnReportarError_Click" />
        </div>
    </div>
</asp:Content>
