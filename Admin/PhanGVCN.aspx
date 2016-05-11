<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="PhanGVCN.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="toptext">
<img src="../icon/settings.png" alt="IMG" style="margin-left: 20px;"/>
    <span>
        <asp:Label ID="lbllink" runat="server" Text="Phân công chủ nhiệm"></asp:Label>
    </span>
</div>
<div class="right-nd">    
    <div class="text1">    
        <hr />
        <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Mã lớp</label>
                <div class="col-sm-9">
                    <asp:DropDownList ID="ddlmalop" class="form-control" runat="server" Width="60%">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Năm học</label>
                <div class="col-sm-9">
                    <asp:TextBox runat="server" class="form-control" id="txtnamhoc" 
                    Width="60%"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtnamhoc" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Học kỳ</label>
                <div class="col-sm-9">
                    <asp:TextBox runat="server" class="form-control" id="txthk" 
                    Width="60%"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txthk" Display="Dynamic" 
                            ErrorMessage="Không được để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <label for="input" class="col-sm-3 control-label">Giáo viên</label>
                <div class="col-sm-9">
                    <asp:DropDownList ID="ddlmagv" class="form-control" runat="server" Width="60%">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <asp:Button ID="btnAdd" runat="server" 
                    style="margin-left: 200px; height: 36px;" Text="Thêm" 
                    Width="65px"  class="btn btn-primary" onclick="btnAdd_Click"/>
                <asp:Button ID="btnSave" runat="server" style="margin-left: 39px" Text="Lưu" 
                        Width="65px" class="btn btn-success" onclick="btnSave_Click"/>
                <asp:Button ID="btnHuy" runat="server" Text="Hủy bỏ" style="margin-left: 39px" 
                Width="65px" class="btn btn-danger" onclick="btnHuy_Click"/>
                
            </div>
            <h3>Danh sách phân công chủ nghiệm</h3>
            <asp:DataGrid ID="GridView1" runat="server"
	    AutoGenerateColumns="False" Width="97%" CellPadding="2" ForeColor="#333333" 
            GridLines="Vertical" BorderColor="White" AllowCustomPaging="True" CssClass="text-center">
            <AlternatingItemStyle BackColor="White" />
            <Columns>
                <asp:BoundColumn DataField="MaLop" HeaderText="Mã lớp" />
                <asp:BoundColumn DataField="NamHoc" HeaderText="Năm học" />
                <asp:BoundColumn DataField="HocKy" HeaderText="Học kỳ" />
                <asp:BoundColumn DataField="MaGV" HeaderText="Mã giáo viên" />          
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

