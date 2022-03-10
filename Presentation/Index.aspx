<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label7" runat="server" Text="Tipos de Hamburguesa 1.Sencilla 2.Doble 3.Triple"></asp:Label><br />
            <asp:Label ID="Label1" runat="server" Text="Ingrese un tipo de Hamburguesa "></asp:Label>
            <asp:TextBox ID="TBTipoHam" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Ingrese la cantidad "></asp:Label>
            <asp:TextBox ID="TBCant" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label8" runat="server" Text="Tipos de Pagos 1.Efectivo 2.Tarjeta "></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Ingrese el tipo de Pago "></asp:Label>
            <asp:TextBox ID="TBTipoPago" runat="server"></asp:TextBox><br />
            <asp:Button ID="BtnPagar" runat="server" Text="Pagar" OnClick="BtnPagar_Click"/><br />
            <asp:Label ID="Label9" runat="server" Text="Cantidad "></asp:Label>
            <asp:Label ID="LblCant" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text="Total sin impuesto "></asp:Label>
            <asp:Label ID="LblTotalSinImpu" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label6" runat="server" Text="Impuesto "></asp:Label>
            <asp:Label ID="LblImpuesto" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text="Total a pagar"></asp:Label>
            <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
