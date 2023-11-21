<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Cliente/MasterCliente.Master" AutoEventWireup="true" CodeBehind="realizar_pago.aspx.cs" Inherits="PresentacionWeb.UI.Cliente.realizar_pago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container h-100 d-flex w-100 align-items-center flex-column mt-5">
        <div class=" mt-3 card w-50 ms-5 me-5">
            <div class="card-header pt-4 pb-4">
                <h1 class="w-100 text-uppercase text-center">realizar pago</h1>
            </div>
            <div class="card-body ">
                <div class="w-100">
                    <p class=" form-text mb-0">Numero de tarjeta</p>
                    <input type="text" class="form-control" placeholder="Ej: 9874-4567-3214-1234"/>
                </div>
                <div class="w-100 d-flex flex-row mt-3">
                    <div class=" w-50 me-2">
                        <p class=" form-text mb-0">Vigencia</p>
                        <input type="text" class="form-control" placeholder="Ej: 01/23" />
                    </div>
                    <div class="w-50">
                        <p class=" form-text mb-0">CVV</p>
                        <input type="text" class="form-control" placeholder="Ej: 123/1234" />
                    </div>
                </div>
                <div class =" d-flex flex-row justify-content-end mt-3">
                     <asp:Button ID="btnPagar" runat="server" Text="Pagar"  CssClass="btn btn-outline-success me-3" OnClick="btnPagar_Click"/>
                     <asp:Button ID="btnCancelar" runat="server" Text="Cancelar"  CssClass="btn btn-outline-secondary" OnClick="btnCancelar_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
