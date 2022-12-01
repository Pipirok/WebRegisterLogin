<%@ Page Language="C#" EnableViewState="true" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebRegisterLogin.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="main.css" />
    <title>Register</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bulma/0.9.4/css/bulma.min.css" integrity="sha512-HqxHUkJM0SYcbvxUw5P60SzdOTy/QVwA1JJrvaXJv4q7lmbDZCmZaqz01UPOaQveoxfYRv1tHozWGPMcuTBuvQ==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    <main class="main">
        <div class="ml-auto mr-auto">
            <form id="form1" class="form-container" runat="server">
                <div>
                    <h1 class="is-size-1 has-text-center">Register</h1>
                    <p class="is-size-3 has-text-center">Fill the fields below to create an account</p>
                    <div class="field">
                        <label class="label">Username</label>
                        <div class="control">
                            <asp:TextBox OnTextChanged="TextBoxUsername_TextChanged" AutoPostBack="true" CssClass="input" ID="TextBoxUsername" runat="server"></asp:TextBox>
                        </div>
                        <asp:Label ID="LabelUsernameFlavourText" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="field">
                        <label class="label">First name</label>
                        <div class="control">
                            <asp:TextBox OnTextChanged="TextBoxFirstName_TextChanged" AutoPostBack="true" CssClass="input" ID="TextBoxFirstName" runat="server"></asp:TextBox>
                        </div>
                        <asp:Label ID="LabelFirstNameFlavourText" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="field">
                        <label class="label">Last name</label>
                        <div class="control">
                            <asp:TextBox OnTextChanged="TextBoxLastName_TextChanged" AutoPostBack="true" CssClass="input" ID="TextBoxLastName" runat="server"></asp:TextBox>
                        </div>
                        <asp:Label ID="LabelLastNameFlavourText" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="field">
                        <label class="label">Password</label>
                        <div class="control">
                            <asp:TextBox OnTextChanged="TextBoxPassword_TextChanged" AutoPostBack="true" CssClass="input" ID="TextBoxPassword" runat="server"></asp:TextBox>
                        </div>
                        <asp:Label ID="LabelPasswordFlavourText" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="field">
                        <label class="label">Password (repeat)</label>
                        <div class="control">
                            <asp:TextBox OnTextChanged="TextBoxPasswordRepeat_TextChanged" AutoPostBack="true" CssClass="input" ID="TextBoxPasswordRepeat" runat="server"></asp:TextBox>
                        </div>
                        <asp:Label ID="LabelPasswordRepeatFlavourText" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="field is-grouped">
                        <div class="control">
                            <asp:Button OnClick="ButtonSubmit_Click" ID="ButtonSubmit" AutoPostBack="true" CssClass="button is-link" runat="server" Text="Create account" Enabled="True" />
                        </div>
                        <div class="control">
                            <a href="Login.aspx" class="button is-link is-light">Login</a>
                        </div>
                    </div>
                </div>
                <div id="modal" runat="server" class="modal">
                    <div class="modal-background"></div>

                    <div class="modal-content">
                        <div class="box">
                            <h1 class="is-size-1 has-text-center is-danger">Error</h1>
                            <p class="is-size-3 has-text-center">An uknown error while creating the account</p>
                        </div>
                    </div>
                    <asp:Button OnClick="Button1_Click" CssClass="modal-close is-large" ID="Button1" runat="server" Text="X" />
                </div>
            </form>
        </div>
    </main>
</body>
</html>
