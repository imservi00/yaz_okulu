<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YazOkulu.Dersler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br/>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br/>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click" />
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
            <Columns>
                <asp:BoundField DataField="OgrAd" HeaderText="Öğrenci Adı" />
                <asp:BoundField DataField="OgrSoyad" HeaderText="Öğrenci Soyadı" />
                <asp:BoundField DataField="DersAd" HeaderText="Ders Adı" />
            </Columns>
        </asp:GridView>

    </form>
</asp:Content>
