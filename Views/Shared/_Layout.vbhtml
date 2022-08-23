@code
    Dim siteName As String = "Avon Park Nazarene Church"
    Dim pageMessage As String = ViewData("message")
    Dim siteURL As String = "http://APNazarene.illustrate.net/"
    Dim siteDescription As String = ViewData("PageTitle")
    Dim linkShareImage As String = siteURL + "Content/LinkShares/1200x630-Linkshare-01.jpg"

    Dim ogType As String = "website"
    Dim ogSite_Name As String = "Nazarene Church"
    Dim ogTitle As String = siteName
    Dim ogURL As String = siteURL
    Dim canonical As String = siteURL
    Dim ogImage As String = linkShareImage
    Dim ogImageWidth As String = "600"
    Dim ogImageHeight As String = "600"
    Dim ogDescription As String = siteDescription

    ' Relevant Title and Link Share changes based on the page shown.
    Select Case pageMessage

        Case "About"
            ogTitle = siteName
            ogDescription = "This web site is dedicated to the Nazarene Life!"

            ogImage = "http://apnazarene.illustrate.net/content/linkshares/About-1200x630.jpg"
            ogImageWidth = "1200"
            ogImageHeight = "630"

            canonical = siteURL + "Info/" + pageMessage

        Case "Contact"
            ogTitle = pageMessage + " - " + siteName
            ogDescription = pageMessage + " - " + siteName

            ogImage = "http://apnazarene.illustrate.net/content/linkshares/Jesus-fish-White-600x600.jpg"
            ogImageWidth = "600"
            ogImageHeight = "600"

            canonical = siteURL + "Info/" + pageMessage

        Case "Privacy", "TOS", "Gallery"
            ogTitle = pageMessage + " - " + siteName
            ogDescription = pageMessage + " - " + siteName

            ogImage = "http://apnazarene.illustrate.net/content/linkshares/AP-Logo-Black-600x600.jpg"
            ogImageWidth = "600"
            ogImageHeight = "600"

            canonical = siteURL + "Info/" + pageMessage
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
    <title>Avon Park Nazarene Church</title>

    <!-- FavIcon(s) - (all your Logo) -->
    <link rel="apple-touch-icon" sizes="180x180" href="~/Content/Icons/apple-touch-icon.png">
    <link rel="apple-touch-icon" type="image/pgn" href="~/Content/Icons/android-chrome-192x192.png" />
    <link rel="icon" type="image/png" sizes="512x512" href="~/Content/Icons/android-chrome-512x512.png">
    <link rel="icon" type="image/png" sizes="16x16" href="~/Content/Icons/favicon-16x16.png">
    <link rel="icon" type="image/png" sizes="32x32" href="~/Content/Icons/favicon-32x32.png">
    <link rel="icon" type="image/x-icon" href="~/Content/Icons/favicon.ico" />
    <link rel="icon" type="image/x-icon" href="~/Content/Icons/favicon.v1.ico" />
    <link rel="manifest" href="~/Content/Icons/site.webmanifest">

    <!-- Fonts (add more fonts here) -->
    <link href='https://fonts.googleapis.com/css?family=Lato:300, 400, 500, 600' rel='stylesheet' type='text/css'>

    <!-- FB App ID unused -->
    <meta property="fb:app_id" content="966242223397117" />

    <!-- Link Share Setup -->
    <!-- This info is used for the card shown when you share a link on the web (I call it "Link Share"). -->
    <!-- (more info here: https://ogp.me/) -->

    <meta property="og:type" content="website" />
    <meta property="og:locale" content="en_US" />
    <meta property="og:title" content="@ogTitle" />
    <meta property="og:determiner" content="The" />
    <meta property="og:description" content="@ogDescription" />
    <meta property="og:site_name" content="@ogSite_Name" />
    <meta property="og:url" content="@ogURL" />
    <meta property="og:image:url" content="@ogImage" />
    <meta property="og:image:alt" content="Logo Image" />
    <meta property="og:image:type" content="image/jpeg" />
    <meta property="og:image:width" content=@ogImageWidth />
    <meta property="og:image:height" content=@ogImageHeight />

    <!-- Twitter Link Share Setup -->
    <!-- (more info here: https://developer.twitter.com/en/docs/twitter-for-websites/cards/overview/markup) -->
    
    <meta name="twitter:card" content="photo" />
    <meta name="twitter:title" content="@ogTitle" />
    <meta name="twitter:image" content="@ogImage" />
    <meta name="twitter:image:width" content=@ogImageWidth />
    <meta name="twitter:image:height" content=@ogImageHeight />

    <!-- Website Setup -->
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="@ogDescription" />

    <link rel="canonical" href="@canonical" />

    <!-- Site Stuff - must be before sitescript.js -->
    @Styles.Render("~/Css/css")
    @Scripts.Render("~/bundles/modernizr")

    <!-- Site Local Scripts -->
    <script src="~/Scripts/sitescripts.js"></script>

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



