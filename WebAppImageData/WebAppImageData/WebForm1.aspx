<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppImageData.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="Student Id" />
                    <asp:BoundField DataField="STDNAME" HeaderText="Student Name" />
                    <asp:ImageField DataImageUrlField="IMGPATH" HeaderText="Picture">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
