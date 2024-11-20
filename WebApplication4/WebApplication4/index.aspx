<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication4.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="row">
                <div class="col-md-4"></div>
                 <div class="col-md-4">
                      <div class="form-group">
                          <label>Student Name</label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                     <div class="form-group">
                         <asp:FileUpload ID="FileUpload1" runat="server" />
                     </div>
                       <div class="form-group">
                           <asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn btn-success" OnClick="Button1_Click" />
                           </div>
                 </div>
                 <div class="col-md-4"></div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="STUDENT ID" />
                                <asp:BoundField DataField="STDNAME" HeaderText="STUDENT NAME" />
                                <asp:ImageField DataImageUrlField="IMGPATH" ControlStyle-CssClass="img-thumbnail">
                                </asp:ImageField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
        </div>
    </form>
</body>
</html>
