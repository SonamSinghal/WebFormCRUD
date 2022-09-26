<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowStudents.aspx.cs" Inherits="WebFormCRUD.ShowStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset style="background-color:#ffffcc">
        <legend><b>Create New Student!</b></legend>
        <div>
            <div>
                <asp:Label ID="NameLbl" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="NameTxt" CssClass="form-control" runat="server"></asp:TextBox><br/>
                <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" 
                    ControlToValidate="NameTxt"
                    ErrorMessage="Name Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="EmailLbl" runat="server" Text="Email: "></asp:Label>
                <asp:TextBox ID="EmailTxt" CssClass="form-control" runat="server"></asp:TextBox> <br/>
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server"
                    ControlToValidate="EmailTxt"
                    ErrorMessage="Email Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="GenderLbl" runat="server" Text="Label"></asp:Label>
                <asp:RadioButton ID="MaleGender" CssClass="form-control" runat="server" Text="Male" GroupName="Gender" />
                <asp:RadioButton ID="FemaleGender" CssClass="form-control" runat="server" Text="Female" GroupName="Gender" />
            </div>
        </div>

        <div>
            <asp:Button ID="CreateStudent" runat="server" Text="Craete Student" OnClick="CreateStudent_Click"/>
        </div>
    </fieldset>

    <asp:Repeater ID="StudentsList" runat="server">
        <HeaderTemplate>
            <table class="table">
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Gender</th>
                    <th></th>
                    <th></th>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><asp:Label ID="StudentId" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.Id")%>'></asp:Label></td>
                    <td><%# DataBinder.Eval(Container,"DataItem.Name")%> </td>
                    <td><%# DataBinder.Eval(Container,"DataItem.Email")%> </td>
                    <td><%# DataBinder.Eval(Container,"DataItem.Gender")%> </td>
                    <td><asp:Button ID="EditButton" runat="server" Text="Edit" data-toggle="modal" data-target="#editModal" Onclick="GetStudent_Click"  /></td>
                    <td><asp:Button ID="DeleteButton" runat="server" Text="Edit" Onclick="DeleteButton_Click" /></td>
                </tr>
            </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>


    <div class="modal fade" id="editModal" tabindex="-1" role="dialog" aria-labelledby="editModalLabel" aria-hidden="true">
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="editModalLabel">Edit Student</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <div>
                <label>Name: </label>
                <asp:TextBox ID="NameTxtEdit" runat="server" Text="<%# Student.Name %>"></asp:TextBox>

            </div>
              <div>
                <label>Email: </label>
                  <asp:TextBox ID="EmailTxtEdit" runat="server" Text="<%# Student.Email %>"></asp:TextBox>
            </div>
              <div>
                  <label>Select a Category: </label>
                  <asp:RadioButtonList ID="GenderRadioList" runat="server" SelectedValue="<%# Student.Gender %>">
                      <asp:ListItem Value="Male">Male</asp:ListItem>
                      <asp:ListItem Value="Female">Female</asp:ListItem>
                  </asp:RadioButtonList>
              </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
              <asp:Button ID="SaveChanges" runat="server" Text="Save Changes" Onclick="EditButton_Click" />
          </div>
        </div>
      </div>
    </div>

</asp:Content>
