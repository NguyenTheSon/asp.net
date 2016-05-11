<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoVien/GiaoVienMaster2.master" AutoEventWireup="true" CodeFile="NhapDiemHangNgay.aspx.cs" Inherits="GiaoVien_NhapDiem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../JavaScript.js"></script>
    <link href="../Styles/css/DinhDangTable.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style5 {
            text-align: center;
            margin-top:30px;
        }

        .auto-style6 {
            text-align: center;
            height: 21px;
        }
        .auto-style7 {
            margin-left: 40px;
        }
        .auto-style8 {
            margin-left: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3 style="margin:30px;">
       Nhập điểm thành phần cho học sinh : <asp:Label ID="lbMaHS" runat="server"></asp:Label>
    </h3>
    
</asp:Content>

