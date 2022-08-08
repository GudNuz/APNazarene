﻿@code

    ' Get Site Info From SiteHelers class where it is stored.
    Dim siteURL As String = SiteHelpers.GetSiteInfo("SiteURL")
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteDescription As String = "Dedicated to the Nazarene life"
    Dim linkShareImage As String = "https://illustrate.net/APNazarene/Content/Catagories/LinkShares/1200x630-Linkshare-01.jpg"

    ' Set og Stuff
    Dim canonical As String = siteURL
    Dim ogTitle As String = siteName
    Dim ogType As String = "website"
    Dim ogURL As String = siteURL
    Dim ogImage As String = linkShareImage
    Dim ogSite_Name As String = siteName
    Dim ogDescription As String = siteDescription

    ' Link Share Setup
    Select Case ViewData("Message")

        ' Example: Change Image and Discription as needed per page,
        ' or let them default to the site LinkShare.
        Case "About", "Contact", "Events", "Store"
            ogTitle = siteName
            ogDescription = siteDescription
            ogImage = linkShareImage ' cusustomize here  = "https://illustrate.net/APNazarene/Content/Catagories/LinkShares/1200x630-Linkshare-01.jpg"
            canonical = siteURL + "/Info/" + ViewData("Message")

        Case "Privacy Policy", "Terms of Service", "Contact"
            ogTitle = ViewData("Message") + " " + siteName
            ogDescription = ViewData("Message")
            ogImage = linkShareImage
            canonical = siteURL + "/Info/" + ViewData("Message")
    End Select

    ogURL = canonical
End Code

<!DOCTYPE html>
<html lang="en" itemscope itemtype="http://schema.org/WebPage">

<!-- Header -->
<head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb#">

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Site Name -->
    <title>@siteName</title>

    <!-- FavIcon(s) -->
    <link rel="apple-touch-icon" sizes="180x180" href="~/Content/Catagories/Icons/APNazarene/apple-touch-icon.png">
    <link rel="apple-touch-icon" type="image/pgn" href="~/Content/Images/Site/Catagories/Icons/APNazarene/android-chrome-192x192.png" />
    <link rel="icon" type="image/png" sizes="512x512" href="~/Content/Catagories/Icons/APNazarene/android-chrome-512x512.png">
    <link rel="icon" type="image/png" sizes="16x16" href="/~/Content/Catagories/Icons/APNazarene/favicon-16x16.png">
    <link rel="icon" type="image/png" sizes="32x32" href="/~/Content/Catagories/Icons/APNazarene/favicon-32x32.png">
    <link rel="icon" type="image/x-icon" href="~/Content/Catagories/Icons/APNazarene/favicon.ico" />
    <link rel="icon" type="image/x-icon" href="~/Content/Catagories/Icons/APNazarene/favicon.v1.ico" />
    <link rel="manifest" href="/site.webmanifest">

    <!-- Fonts -->
    <link href='https://fonts.googleapis.com/css?family=Lato:300, 400, 500, 600' rel='stylesheet' type='text/css'>

    <!-- Link Share Setup -->
    <link rel="canonical" href="@canonical" />
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="@ogDescription" />
    <meta property="og:type" content="website" />
    <meta property="og:site_name" content="@ogSite_Name" />
    <meta property="og:url" content="@ogURL" />
    <meta property="og:image:url" content="@ogImage" />
    <meta property="og:image:type" content="image/jpeg" />
    <meta property="og:image:width" content="1200" />
    <meta property="og:image:height" content="600" />
    <meta property="og:title" content="@ogTitle" />
    <meta property="og:description" content="@ogDescription" />
    <meta property="og:locale" content="en_US" />
    <meta name="twitter:card" content="photo" />
    <meta name="twitter:site" content="@ogSite_Name" />
    <meta name="twitter:title" content="@ogTitle" />
    <meta name="twitter:image" content="@ogImage" />
    <meta name="twitter:image:width" content="1200" />
    <meta name="twitter:image:height" content="600" />

    @Styles.Render("~/Css/css")
    @Scripts.Render("~/bundles/modernizr")

    <!-- Jquery -->
    <script src="~/Scripts/jquery-3.6.0.min.js"></script>

    <!-- Bootstrap Css and Scripts -->
    <script src="~/Scripts/bootstrap.min.js"></script>
    <link href="~/Css/bootstrap.min.css" rel="stylesheet" />

    <!-- Site Local Css and Scripts -->
    <script src="~/Scripts/sitescripts.js"></script>
    <link href="~/Css/site.css" rel="stylesheet" />

</head>

    <body>

        <!-- NavBar -->
        @Html.Partial("_Navbar")

        <!-- Body -->
        <div class="container body-content px-0">
            @RenderBody()
        </div>

        <!-- Footer Menu -->
        @Html.Partial("_Footer")

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)

    </body>
</html>



