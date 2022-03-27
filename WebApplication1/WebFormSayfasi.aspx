<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSayfasi.aspx.cs" Inherits="WebApplication1.WebFormSayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="BtnGonder" runat="server" BackColor="Red" BorderColor="#333333" ForeColor="White" OnClick="BtnGonder_Click" Text="Gönder" />
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Kabul Ediyorum" />
            <input id="Checkbox1" type="checkbox" />
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Onay</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Bootstrap</asp:ListItem>
                <asp:ListItem>Html</asp:ListItem>
                <asp:ListItem>Css</asp:ListItem>
                <asp:ListItem>Js</asp:ListItem>
                <asp:ListItem>Jquery</asp:ListItem>
            </asp:DropDownList>
            <hr />
            <select name="DropDownList2" id="DropDownList2">
                <option value="Bootstrap">Bootstrap</option>
                <option value="Html">Html</option>
                <option value="Css">Css</option>
                <option value="Js">Js</option>
                <option value="Jquery">Jquery</option>
            </select>
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <hr />
            <input id="File1" type="file" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label Kontrolü"></asp:Label>
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>Yazılım</asp:ListItem>
                <asp:ListItem>Veritabanı</asp:ListItem>
                <asp:ListItem>Tasarım</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Literal ID="Literal1" runat="server" Text="Literal ekrana html tag siz yazı yazar"></asp:Literal>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Onaylıyorum" />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Onay</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Bolum_No" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Bolum_No" HeaderText="Bolum_No" InsertVisible="False" ReadOnly="True" SortExpression="Bolum_No" />
                    <asp:BoundField DataField="Bolum_Adi" HeaderText="Bolum_Adi" SortExpression="Bolum_Adi" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BilisimConnectionString %>" SelectCommand="SELECT * FROM [Bolumler]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
