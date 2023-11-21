<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/UI/Cliente/MasterCliente.Master" AutoEventWireup="true" CodeBehind="factura.aspx.cs" Inherits="PresentacionWeb.UI.Cliente.factura"  %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container d-flex mt-3 flex-column  align-items-center">
        <h1 class=" text-uppercase text-success ">¡tu pago se ha realizado con exito! 🤑</h1>
        <h3 class="text-uppercase">aqui está tu factura</h3>
    </div>
    <div align="center" class=" container w-100 mt-4" >
            <rsweb:ReportViewer ShowParameterPrompts="true" ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="Gray" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="75%" ZoomMode="PageWidth">
                <LocalReport ReportPath="Reportes\factura.rdlc">
                </LocalReport>
            </rsweb:ReportViewer>   

    </div>
</asp:Content>
