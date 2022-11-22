<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebRegisterLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="main.css" />
    <title>Login</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bulma/0.9.4/css/bulma.min.css" integrity="sha512-HqxHUkJM0SYcbvxUw5P60SzdOTy/QVwA1JJrvaXJv4q7lmbDZCmZaqz01UPOaQveoxfYRv1tHozWGPMcuTBuvQ==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    <main class="main">
        <div class="ml-auto mr-auto">
            <form id="form1" class="form-container" runat="server">
                <div>
                    <h1 class="is-size-1 has-text-center">Welcome!</h1>
                    <p class="is-size-3 has-text-center">Enter your username and password to sign in</p>
                    <div class="field">
                        <label class="label">Username</label>
                        <div class="control">
                            <asp:TextBox CssClass="input" ID="TextBoxUsername" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="field">
                        <label class="label">Password</label>
                        <div class="control">
                            <asp:TextBox TextMode="Password" CssClass="input" ID="TextBoxPassword" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="field is-grouped">
                        <div class="control">
                            <asp:Button OnClick="ButtonSubmit_Click" ID="ButtonSubmit" AutoPostBack="true" CssClass="button is-link" runat="server" Text="Sign in" />
                        </div>
                        <div class="control">
                            <a href="Register.aspx" class="button is-link is-light">Register</a>
                        </div>
                    </div>
                </div>
                <div runat="server" id="modal" class="modal">
                    <div class="modal-background"></div>

                    <div class="modal-content">
                        <div class="box">
                            <h1 class="is-size-1 has-text-center is-danger">Error</h1>
                            <p class="is-size-3 has-text-center">Invalid credentials!</p>
                        </div>
                    </div>

                    <asp:Button OnClick="ButtonModalClose_Click" ID="ButtonModalClose" CssClass="modal-close is-large" runat="server" Text="Button" />
                </div>
            </form>
        </div>
    </main>
</body>
</html>
