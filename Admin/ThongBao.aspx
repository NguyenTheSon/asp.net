<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ThongBao.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="toptext">
<img src="../icon/settings.png" alt="IMG" style="margin-left: 20px;"/>
    <span>
        <asp:Label ID="lbllink" runat="server" Text="Quản lý thông báo"></asp:Label>
    </span>
</div>
<div class="right-nd">    
    <div class="text1">    
        <hr />
        <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Mã thông báo</label>
                <div class="col-sm-9">
                    <asp:TextBox runat="server" class="form-control" id="txtmatb" 
                    Width="60%"/>
                </div>
            </div>
            <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Ngày thông báo</label>
                <div class="col-sm-9">
                    <asp:TextBox runat="server" class="form-control" id="txtntb" Width="60%"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtntb" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Tên thông báo</label>
                <div class="col-sm-9">
                    <asp:TextBox runat="server" class="form-control" id="txttentb" Width="60%"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txttentb" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Nội dung</label>
                <div class="col-sm-6">                        
                          <asp:TextBox id="txtnd" class="form-control" TextMode="multiline" Columns="10" Rows="5" runat="server" />
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtnd" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <asp:Button ID="btnAdd" runat="server" style="margin-left: 170px" Text="Thêm" 
                    Width="65px"  class="btn btn-primary" onclick="btnAdd_Click"/>
                <asp:Button ID="btnSave" runat="server" style="margin-left: 39px" Text="Lưu" 
                        Width="65px" class="btn btn-success" onclick="btnSave_Click"/>
                <asp:Button ID="btnEdit" runat="server"  style="margin-left: 39px" Text="Sửa" 
                        Width="65px" class="btn btn-info" onclick="btnEdit_Click"/>
                <asp:Button ID="btnHuy" runat="server" Text="Hủy bỏ" style="margin-left: 39px" 
                Width="65px" class="btn btn-danger" onclick="btnHuy_Click"/>
            </div>
            <h3>Danh sách thông báo</h3>
            <asp:DataGrid ID="GridView1" runat="server"
	    AutoGenerateColumns="False" Width="97%" CellPadding="2" ForeColor="#333333" 
            GridLines="Vertical" BorderColor="White" AllowCustomPaging="True" CssClass="text-center">
            <AlternatingItemStyle BackColor="White" />
            <Columns>
                <asp:BoundColumn DataField="MaTB" HeaderText="Mã thông báo" />
                <asp:BoundColumn DataField="TenTB" HeaderText="Tên thông báo" />
                <asp:BoundColumn DataField="NgayTB" HeaderText="Ngày thông báo" />
                <asp:BoundColumn DataField="NoiDung" HeaderText="Nội dung" />
                <asp:BoundColumn DataField="TaiKhoan" HeaderText="Tài khoản" />          
                <asp:HyperLinkColumn DataNavigateUrlField="matb" DataNavigateUrlFormatString="ThongBao.aspx?matb={0}&action=edit"
                    Text="Chọn" HeaderText="Chọn"></asp:HyperLinkColumn>
            </Columns>
            <EditItemStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataGrid>
        <br />
        <br />
    </div>        
    </div> 
</asp:Content>

