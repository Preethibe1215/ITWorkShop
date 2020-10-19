<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="WorkShop.aspx.cs" Inherits="WebApplication1.Admin.WorkShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="text-align: right; font-weight: 700;">WorkShopTitle: </td>
            <td>
                <asp:TextBox runat="server" ID="txtWorkShopTitle"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700;">WorkShopDate:</td>
            <td>
                <asp:TextBox runat="server" ID="txtWorkShopDate"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700;">WorkShopDuration:</td>
            <td>
                <asp:TextBox runat="server" ID="txtWorkShopDuration"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td style="text-align: right; font-weight: 700;">WorkShopTopics:</td>
            <td>
                <asp:TextBox runat="server" ID="txtWorkShopTopics" Height="67px" TextMode="MultiLine"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td style="text-align: right"></td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                 <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                 <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </td>
            
               
            
               
            
        </tr>
    </table>
    <asp:GridView runat="server" ID="gridviewWorkShop" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridviewWorkShop_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="WorkShopId">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
