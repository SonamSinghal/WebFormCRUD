<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowAllStudentList.aspx.cs" Inherits="WebFormCRUD.ShowAllStudentList" %>
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

        <%--<div>
            <asp:Button ID="CreateStudent" runat="server" Text="Create Student" OnClick="CreateStudent_Click"/>
        </div>--%>
    </fieldset>
</asp:Content>
