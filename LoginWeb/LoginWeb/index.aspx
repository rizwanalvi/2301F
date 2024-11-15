<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LoginWeb.index"  UnobtrusiveValidationMode="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
               <div class="col-md-4"></div>
                 <div class="col-md-4">
                     <div class="form-group">
                         <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                         <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="User Name Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                     </div>
                      <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                         <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Password Required" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                     </div>
                        <div class="form-group">
                         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" CssClass="btn btn-success" />
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                         <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" CssClass="btn btn-success" />

                        </div>
                 </div>
                 <div class="col-md-4"></div>
            </div>
           
        </div>
    </form>
</body>
</html>
