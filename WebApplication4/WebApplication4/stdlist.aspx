<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stdlist.aspx.cs" Inherits="WebApplication4.stdlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <div class="row row-cols-2 row-cols-md-4">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="col mb-4">
    <div class="card">
      <img src='<%# Eval("IMGPATH") %>' class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title"><%# Eval("STDNAME") %></h5>
        <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
      </div>
    </div>
  </div>
                </ItemTemplate>
                <FooterTemplate>
                    </div>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
