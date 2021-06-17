<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculater.aspx.cs" Inherits="_3HW.calculater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculater</title>
    <style type="text/css">
        .ControlTextPosition {
            padding: 2%;
            text-align:right
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="width:420px; height:80px">
                <div style="float:left; width:20px; height:100%">
                    <asp:Panel ID="pn_Operate" runat="server" Width="100%" Height="100%" BackColor="Silver">
                        <asp:Label ID="lb_Operate" runat="server" Text=""></asp:Label>
                    </asp:Panel>
                </div>
                <div style="float:left; width:400px; height:100%">
                    <asp:Panel ID="pn_Screen" runat="server" Width="100%" Height="100%" BackColor="Silver">
                        <asp:Label ID="lb_Result" runat="server" Font-Size="28pt" Width="95%" Height="70%" Text="" CssClass="ControlTextPosition"></asp:Label>
                    </asp:Panel>
                </div>
            </div>

            <div style="width:420px;height:50px">
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_Add" runat="server" Text="+" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_Add_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_7" runat="server" Text="7" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_7_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_8" runat="server" Text="8" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_8_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_9" runat="server" Text="9" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_9_Click"/>
                </div>
            </div>

            <div style="width:420px;height:50px">
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_Miuns" runat="server" Text="-" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_Miuns_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_4" runat="server" Text="4" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_4_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_5" runat="server" Text="5" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_5_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_6" runat="server" Text="6" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_6_Click"/>
                </div>
            </div>

            <div style="width:420px;height:50px">
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_Product" runat="server" Text="*" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_Product_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_1" runat="server" Text="1" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_1_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_2" runat="server" Text="2" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_2_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_3" runat="server" Text="3" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_3_Click"/>
                </div>
            </div>

            <div style="width:420px;height:50px">
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_Divide" runat="server" Text="/" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_Divide_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_0" runat="server" Text="0" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_0_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_Clear" runat="server" Text="CE" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_Clear_Click"/>
                </div>
                <div style="float:left; width:25%; height:100%;">
                    <asp:Button ID="bt_Equals" runat="server" Text="=" Width="100%" Height="100%" Font-Bold="True" Font-Size="20pt" OnClick="bt_Equals_Click"/>
                </div> 
            </div>

        </div>
    </form>
</body>
</html>
