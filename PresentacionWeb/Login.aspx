<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentacionWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
        <div class="container h-100 d-flex w-100 align-items-center flex-column mt-5">
            <div class="w-100 d-flex align-items-center flex-column">
                <img src="images/logo1.png" alt="Logo señal tv" class="rounded img-fluid" height="100" width="100" />
                <h2 style="color:#EB4D80">Señal Tv</h2>
            </div>
            <div class=" mt-3 card w-50 ms-5 me-5">
                <div class="card-header pt-4 pb-4">
                    <h1 class ="w-100 text-uppercase text-center">Inicio de sesion</h1>
                </div>
              <div class="card-body ">
                  <div class="mt-3">
                      <asp:TextBox ID="tbUser" runat="server" CssClass="form-control" placeholder="Nombre de usuario"></asp:TextBox>
                  </div>
                  <div class="mt-3">
                      <asp:TextBox ID="tbPswrd" runat="server" CssClass="form-control" type="password" placeholder="Contraseña"></asp:TextBox>
                  </div>
                  <div class="mt-3  d-flex justify-content-end me-2">
                      <asp:Button ID="btnEntrar" runat="server" Text="Ingresar"  CssClass="btn btn-outline-dark" OnClick="btnEntrar_Click"/>
                  </div>
              </div>
            </div>
        </div>
    </form>
</body>
</html>
