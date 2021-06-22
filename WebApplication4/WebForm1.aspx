<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" EnableTheming="False" Height="43px" Width="444px" Enabled="False">0</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 輸入中的數字:<asp:Label ID="lable" runat="server" EnableTheming="True"></asp:Label>
        &nbsp; 上一個數字 :<asp:Label ID="lable0" runat="server" EnableTheming="True">0</asp:Label>
           確認是否初次輸入:<asp:Label ID="lable1" runat="server" EnableTheming="True">0</asp:Label>
        &nbsp; 儲存運算:
            <asp:Label ID="lable2" runat="server" EnableTheming="True">0</asp:Label>
        &nbsp;是否使用過等於:<asp:Label ID="lable3" runat="server" EnableTheming="True">0</asp:Label>
        &nbsp;是否使用過運算 :<asp:Label ID="lable4" runat="server" EnableTheming="True">0</asp:Label>
           連續運算<asp:Label ID="lable5" runat="server" EnableTheming="True">0</asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click" Text="1" Width="83px" />
            <asp:Button ID="Button2" runat="server" Height="47px" OnClick="Button2_Click" Text="2" Width="83px" />
            <asp:Button ID="Button3" runat="server" Height="47px" OnClick="Button3_Click" Text="3" Width="83px" />
            <asp:Button ID="Button13" runat="server" Height="47px" OnClick="Button13_Click" Text="*" Width="83px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p>
            <asp:Button ID="Button4" runat="server" Height="47px" Text="4" OnClick="Button4_Click" Width="83px" />
            <asp:Button ID="Button5" runat="server" Height="47px" Text="5" OnClick="Button5_Click"  Width="83px" />
            <asp:Button ID="Button6" runat="server" Height="47px" Text="6" OnClick="Button6_Click" Width="83px" />
            <asp:Button ID="Button14" runat="server" Height="47px" Text="/" OnClick="Button14_Click" Width="83px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button16" runat="server" Height="47px" Text="儲存" Width="83px" OnClick="Button16_Click" />
        </p>
        <p>
            <asp:Button ID="Button7" runat="server" Height="47px" Text="7" OnClick="Button7_Click"  Width="83px" />
            <asp:Button ID="Button8" runat="server" Height="47px" Text="8" OnClick="Button8_Click" Width="83px" />
            <asp:Button ID="Button9" runat="server" Height="47px" Text="9" OnClick="Button9_Click" Width="83px" />
            <asp:Button ID="Button15" runat="server" Height="47px" Text="=" OnClick="Button15_Click" Width="83px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button17" runat="server" Height="47px" Text="貼上" Width="83px" OnClick="Button17_Click" />
        </p>
        <p>
            <asp:Button ID="Button10" runat="server" Height="47px" Text="+" OnClick="Button10_Click" Width="83px" />
            <asp:Button ID="Button11" runat="server" Height="47px" Text="0" OnClick="Button11_Click" Width="83px" />
            <asp:Button ID="Button12" runat="server" Height="47px" Text="-" OnClick="Button12_Click" Width="83px" />
            <asp:Button ID="Button18" runat="server" Height="47px" Text="重製" OnClick="Button18_Click" Width="83px" />
        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 儲存值:<asp:Label ID="Label2" runat="server"> </asp:Label>
        </p>
           <p>
               使用紀錄: <asp:Label ID="Label3" runat="server"> </asp:Label>
        </p>
        <br />
    </form>
</body>
</html>
