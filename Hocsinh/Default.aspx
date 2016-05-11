<%@ Page Title="" Language="C#" MasterPageFile="~/Hocsinh/Hocsinh.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Hocsinh_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">
    $(document).ready(function () {
        function activeTab(obj) {
            $('.tab-wrapper ul li').removeClass('active');
            $(obj).addClass('active');
            var id = $(obj).find('a').attr('href');
            $('.tab-item').hide();
            $(id).show();
        }
        $('.nav li').click(function () {
            activeTab(this);
            return false;
        });
        activeTab($('.nav li:first-child'));
    });
</script>
<div class="tab-wrapper">
    <ul class="nav nav-tabs" role="tablist">
      <li>
            <a href="#tab-main-info">Điểm theo môn học</a>
        </li>
        <li>
            <a href="#tab-image">Điểm tất cả các môn</a>
        </li>
    </ul>
    <div class="tab">
        <div class="tab-item form-horizontal" id="tab-main-info">
            <h4 style="text-align: center">Tra cứu điểm theo môn học</h4>
            <div class="form-group">
                <label for="input" class="col-sm-4 control-label">Môn học</label>
                <div class="col-sm-8">                
                    <asp:DropDownList CssClass="form-control" ID="ddlmonhoc" runat="server" 
                    Width="40%" >
                    </asp:DropDownList>
                </div> 
            </div>
            <div class="form-group">
            <label for="input" class="col-sm-4 control-label" style="padding-left: 175px; line-height: 30px;" >Lớp</label> 
                <div class="col-sm-4">                
                    <asp:DropDownList ID="drLop" class="form-control" runat="server" Width="190px">
                </asp:DropDownList>
                </div>
                <div class="col-sm-4">
                    <asp:Button ID="btnkq" runat="server" Text="Xem kết quả" 
                    Width="100px"  class="btn btn-primary" onclick="btnkq_Click"/>
                </div>
            </div>
        </div>
        <div class="tab-item" id="tab-image">
            <h4 style="text-align: center">Tra cứu điểm tất cả các môn</h4>
            <div class="form-group">
            <label for="input" class="col-sm-4 control-label" style="padding-left: 120px; line-height: 30px;" >Mã học sinh</label> 
                <div class="col-sm-4">                
                    <asp:TextBox runat="server"  class="form-control" id="txths" placeholder="Mã học sinh" />
                </div>
                <div class="col-sm-4">
                    <asp:Button ID="btnketqua" runat="server" Text="Xem kết quả" 
                    Width="100px"  class="btn btn-primary" onclick="btnketqua_Click"/>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>

