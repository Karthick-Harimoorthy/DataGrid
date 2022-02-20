<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="DataGrid.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HomaePage</title>
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/WebForms/GridView.js"></script>
    <script src="DataGridView.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <style>
        #navbar {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            background-color: #ff5349;
        }

        .navbar-text {
            color: white;
            text-align: center;
            margin-top: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="navbar">
            <h3 class="navbar-text">Home Page</h3>
        </div>
        <br />
        <br />
 
        <div id="Hompagebtn" class="col-md-12">
            <button type="button" class="btn btn-primary"  id="DataGrid">&nbsp;&nbsp;DataGrid View&nbsp;&nbsp;</button>
        </div>

    </form>
</body>
</html>
