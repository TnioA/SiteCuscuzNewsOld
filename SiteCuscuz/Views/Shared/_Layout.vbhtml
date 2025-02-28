﻿@*<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Meu Aplicativo ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Nome do aplicativo", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Início", "Index", "Home")</li>
                    <li>@Html.ActionLink("Sobre", "About", "Home")</li>
                    <li>@Html.ActionLink("Contato", "Contact", "Home")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Meu Aplicativo ASP.NET</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>*@





<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="description" content="">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- The above 4 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <!-- Title -->
    <title>Cuscuz News</title>

    <!-- Favicon -->
    <link rel="icon" href="Template/img/core-img/favicon.ico">

    <!-- Stylesheet -->
    <link rel="stylesheet" href="Template/style.css">

</head>

<body>
    <iframe src="https://player.painelvox.com/player-barra/8164/000000" frameborder="0" width="100%" height="31"></iframe>
    @RenderBody()

    <!-- ##### Footer Area End ##### -->
    <!-- ##### All Javascript Script ##### -->
    <!-- jQuery-2.2.4 js -->
    <script src="Template/js/jquery/jquery-2.2.4.min.js"></script>
    <!-- Popper js -->
    <script src="Template/js/bootstrap/popper.min.js"></script>
    <!-- Bootstrap js -->
    <script src="Template/js/bootstrap/bootstrap.min.js"></script>
    <!-- All Plugins js -->
    <script src="Template/js/plugins/plugins.js"></script>
    <!-- Active js -->
    <script src="Template/js/active.js"></script>
</body>

</html>