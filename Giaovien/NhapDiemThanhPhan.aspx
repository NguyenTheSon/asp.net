<%@ Page Title="" Language="C#" MasterPageFile="~/Giaovien/GiaoVienMaster2.master" AutoEventWireup="true" CodeFile="NhapDiemThanhPhan.aspx.cs" Inherits="Giaovien_NhapDiemThanhPhan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .mahs {
            width: 100px;
            height: 30px;
            text-align: center;
        }

        .hoten {
            width: auto;
            height: 30px;
            text-align: center;
        }

        .cotdiem {
            width: 55px;
            height: 30px;
            text-align: center;
        }

        .auto-style8 {
              margin: 30px auto 30px 70px;
           
        }

       

        .auto-style9 {
            text-align: center;
        }

       

        </style>
    <script src="../JavaScript.js"></script>
    <link href="../Styles/css/DinhDangTable.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3 style="margin: 30px;">Nhập điểm thành phần lớp
        <asp:Label ID="lbTenLop" runat="server" Text=""></asp:Label>
    </h3>
    
     <h3 style="margin: 30px;">Môn học
        <asp:Label ID="lbMonHoc" runat="server" Text=""></asp:Label>
    </h3>
  
   

    <asp:Button ID="btnLuu" runat="server" Text="Lưu bảng điểm" CssClass="auto-style8" Width="150px" OnClick="btnLuu_Click" Height="40px" />
    <asp:Button ID="btnHuy" runat="server" Text="Quay về trang danh sách lớp" CssClass="auto-style8" Width="300px" Height="40px" OnClick="btnHuy_Click" />


    <table style="width: 90%;" class="loptable">

        <tr style="background-color: #00ffff;">
            <td class="mahs" rowspan="2">Ma SV</td>
            <td class="hoten" rowspan="2">Ho ten</td>
            <td class="hoten" colspan="3">Điểm miệng</td>
            <td class="hoten" colspan="4">Điểm KT 15p</td>
            <td class="hoten" colspan="3">Điểm KT 45p</td>
            <td class="cotdiem" rowspan="2">Điểm Thi</td>
        </tr>
        <tr style="background-color: #00ffff;">
            <td class="cotdiem">1</td>
            <td class="cotdiem">2</td>
            <td class="cotdiem">3</td>
            <td class="cotdiem">1</td>
            <td class="cotdiem">2</td>
            <td class="cotdiem">3</td>
            <td class="cotdiem">4</td>
            <td class="cotdiem">1</td>
            <td class="cotdiem">2</td>
            <td class="cotdiem">3</td>
        </tr>
    </table>
    <asp:DataList Style="width: 90%; margin: auto" ID="DSHocSinh" runat="server">
        <ItemTemplate>
            <table style="width: 100%;" class="loptable">
                <tr>
                    <td class="mahs">
                        <asp:Label ID="lbMasv" runat="server" Text='<%#Eval("MaHS")%>'></asp:Label></td>
                    <td class="hoten">
                        <asp:Label ID="lbHoten" runat="server" Text='<%#Eval("HoTenHS")%>'></asp:Label></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txtMieng1" Text='<%#Eval("Mieng1")%>' runat="server" Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txtMieng2" Text='<%#Eval("Mieng2")%>' runat="server"  Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txtMieng3" Text='<%#Eval("Mieng3")%>' runat="server" Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txt15p1"  Text='<%#Eval("Diem15p1")%>' runat="server"  Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txt15p2" Text='<%#Eval("Diem15p2")%>' runat="server" Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txt15p3" Text='<%#Eval("Diem15p3")%>' runat="server" Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txt15p4" Text='<%#Eval("Diem15p4")%>' runat="server"  Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txt45p1" Text='<%#Eval("Diem45p1")%>' runat="server" Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txt45p2" Text='<%#Eval("Diem45p2")%>' runat="server" Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txt45p3" Text='<%#Eval("Diem45p3")%>' runat="server"  Width="90%" Height="90%"></asp:TextBox></td>
                    <td class="cotdiem">
                        <asp:TextBox ID="txtHocky" Text='<%#Eval("DiemHK")%>' runat="server"  Width="90%" Height="90%"></asp:TextBox></td>
                </tr>

            </table>
        </ItemTemplate>
    </asp:DataList>
    <br />
</asp:Content>


