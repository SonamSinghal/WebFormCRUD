<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="ShowStudents.aspx.cs" Inherits="WebFormCRUD.ShowStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset style="background-color:#ffffcc; padding:10px;">
        <legend><b>Create New Student!</b></legend>
        <div>
            <div>
                <asp:Label ID="NameLbl" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="NameTxt" CssClass="form-control" runat="server"></asp:TextBox><br/>
                <%--<asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" 
                    ControlToValidate="NameTxt"
                    ErrorMessage="Name Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            </div>
            <div>
                <asp:Label ID="EmailLbl" runat="server" Text="Email: "></asp:Label>
                <asp:TextBox ID="EmailTxt" CssClass="form-control" runat="server"></asp:TextBox> <br/>
               <%-- <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server"
                    ControlToValidate="EmailTxt"
                    ErrorMessage="Email Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            </div>
            <div>
                <asp:Label ID="GenderLbl" runat="server" Text="Gender: "></asp:Label>
                <asp:RadioButton ID="MaleGender" CssClass="form-check-input" runat="server" Text="Male" GroupName="Gender" />
                <asp:RadioButton ID="FemaleGender" CssClass="form-check-input" runat="server" Text="Female" GroupName="Gender" />
            </div>
        </div>
        <div class="mt-3">
            <asp:Button ID="CreateStudent" runat="server" CssClass="btn btn-primary" Text="Create Student" OnClick="CreateStudent_Click"/>
        </div>
    </fieldset>

    <fieldset>
        <legend>Apply a Filter!</legend>
        <div>
            Enter the University:
            <asp:TextBox ID="UniFilter" runat="server"></asp:TextBox>
        </div>
         <div>
            Enter the Gender: 
            <asp:TextBox ID="GenderFilter" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ApplyFilter" runat="server" Text="Apply Filter" OnClick="ApplyFilter_Click" />
        </div>
    </fieldset>

    <asp:Repeater ID="StudentsList" runat="server" OnItemCommand="StudentsList_ItemCommand">
        <HeaderTemplate>
            <table class="table">
                <tr>
                    <%--<th>Id</th>--%>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Gender</th>
                    <th>Course</th>
                    <th></th>
                    <th></th>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <%--<td><asp:Label ID="StudentId" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.Id")%>'></asp:Label></td>--%>
                    <td><%# DataBinder.Eval(Container,"DataItem.Name")%> </td>
                    <td><%# DataBinder.Eval(Container,"DataItem.Email")%> </td>
                    <td><%# DataBinder.Eval(Container,"DataItem.GenderTitle")%> </td>
                    <td><%# DataBinder.Eval(Container,"DataItem.CourseTitle")%> </td>
                    <td><asp:LinkButton ID="EditButton" runat="server" CssClass="btn btn-info editButton" CommandName="Update" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.Id") %>'>Edit</asp:LinkButton></td>
                    <td><asp:LinkButton ID="DeleteButton" runat="server" CssClass="btn btn-danger" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.Id") %>'>Delete</asp:LinkButton></td>
                </tr>
            </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>


</asp:Content>
