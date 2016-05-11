<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="NhapHocSinh.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="toptext">
<img src="../icon/settings.png" alt="IMG" style="margin-left: 20px;"/>
    <span>
        <asp:Label ID="lbllink" runat="server" Text="Quản lý học sinh"></asp:Label>
    </span>
</div>
<div class="right-nd">    
    <div class="text1">    
        <hr />
         <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Lớp học</label>
                <div class="col-sm-4">
                    <asp:TextBox runat="server" class="form-control" id="txtmahs" 
                    Width="60%" Enabled="false"/>
                    </div>
                    <div class="col-sm-4">
                    <asp:Button ID="btnAdd" runat="server" style="margin-left: 170px" Text="Thêm" 
                    Width="65px"  class="btn btn-primary"/>
                </div>
            </div>
    </div>
</div>
</asp:Content>

