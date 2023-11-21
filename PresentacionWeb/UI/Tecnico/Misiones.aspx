<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Master.Master" AutoEventWireup="true" CodeBehind="Misiones.aspx.cs" Inherits="PresentacionWeb.UI.Tecnico.Misiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container col w-100 mt-4">
        <div>
            <asp:Button runat="server" Text="Imprimir Listado" CssClass="btn btn-outline-primary" />
        </div>
        <div class="w-100">
            <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" Width="441px" CssClass="table table-striped table-hover table-responsive w-100 mt-3" AllowPaging="True" PageSize="5" OnSelectedIndexChanged="grid1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                    
                    <asp:BoundField DataField="concepto" HeaderText="Concepto" />
                    <asp:BoundField DataField="fechaProg" HeaderText="Fecha Programada" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="w-100 d-flex justify-content-end flex-wrap">
            <p class=" fw-bold me-4">Codigo: <asp:Label ID="lblCodigo" runat="server" Text="0" CssClass="fw-light"></asp:Label></p>
            <asp:TextBox ID="tbconcepto" runat="server" CssClass="form-control" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
        </div>
        <div class=" d-flex justify-content-end mt-3">            
            <asp:Button runat="server" Text="Completar" CssClass="btn btn-outline-primary" OnClick="btnImprimirDetalle_click"/>
            <asp:Button runat="server" Text="Cancelar" CssClass="btn btn-outline-secondary ms-2" OnClick="btnCancelar_Click" />
        </div>
    </div>
</asp:Content>
