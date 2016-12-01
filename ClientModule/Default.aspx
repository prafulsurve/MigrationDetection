<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Async="true"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    
        <div style="margin-left">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Set Ping Counter:&nbsp;&nbsp;
            <asp:TextBox ID="setPC1" runat="server" Height="34px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Threshold Vector:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="text_threshold" runat="server" Height="35px"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Avg. Latency1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text=" T. min"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text=" T.max"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Avg. Latency2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
            <br />
&nbsp;&nbsp; LM1:
            <asp:TextBox ID="text_LM1" runat="server" Width="261px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="avgLatency11" runat="server" Width="135px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="tmin1" runat="server" Width="70px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tmax1" runat="server" Width="70px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="avgLatency21" runat="server" Width="135px" Height="40px" AutoPostBack="True"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CalcLatency" runat="server" OnClick="Button1_Click" Text="Calcualte Latency" Width="287px" Height="49px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp; LM2:
            <asp:TextBox ID="textLM2" runat="server" Width="261px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="avgLatency12" runat="server" Width="135px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tmin2" runat="server" Width="70px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tmax2" runat="server" Width="70px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="avgLatency22" runat="server" Width="135px" Height="40px" AutoPostBack="True"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp;&nbsp; LM3:
            <asp:TextBox ID="textLM3" runat="server" Width="257px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="avgLatency13" runat="server" Width="135px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tmin3" runat="server" Width="70px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tmax3" runat="server" Width="70px" Height="40px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="avgLatency23" runat="server" Width="135px" Height="40px" AutoPostBack="True"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Re-Calcualte Latencies" Width="220px" Height="50px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Set Ping Counter:
            <asp:TextBox ID="setPC2" runat="server" Width="67px" Height="39px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Radio_automatic" runat="server" OnCheckedChanged="Radio_automatic_CheckedChanged" Text="Automatic" GroupName = "recalc" AutoPostBack="True"/>
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Radio_manual" runat="server" OnCheckedChanged="Page_Load" Text="Manual" GroupName = "recalc" />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></i></span>Time Interval&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="text_timeInterval" runat="server" Height="24px" Width="58px"></asp:TextBox>
            &nbsp;
            <br />
        </div>
    
  
    </form>
</body>
</html>
