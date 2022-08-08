@code
    ' Keep Current Menu Selection Active (Highlighted)
    Dim choice01 As String = ""
    Dim choice02 As String = ""
    Dim choice03 As String = ""
    Dim choice04 As String = ""
    Dim choice05 As String = ""
    Dim choice06 As String = ""

    If ViewData("message") = "About" Then
        choice01 = "active"
    End If
    If ViewData("message") = "Contact" Then
        choice02 = "active"
    End If
    If ViewData("message") = "Worship" Then
        choice03 = "active"
    End If
    If ViewData("message") = "Calendar" Then
        choice04 = "active"
    End If
    If ViewData("message") = "Members" Then
        choice04 = "active"
    End If
    If ViewData("message") = "Gallery" Then
        choice06 = "active"
    End If

    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteNameShort As String = SiteHelpers.GetSiteInfo("SiteNameShort")
    ' Page Images
    Dim smallLogo = SiteHelpers.GetSiteInfo("SmallLogo")
End Code

<nav class="navbar navbar-expand-lg navbar-dark border-bottom box-shadow mb-sm-0 px-sm-0 mb-lg-3 px-lg-2" style="background-color: #4A4B4C;">
    <!--mb-sm-0 px-sm-0-->
    <div class="d-flex flex-grow-1">

        <!-- Hidden Space -->
        <span class="w-100 d-lg-none d-block">
            <!-- hidden spacer to center brand on mobile -->
        </span>

        <!-- Set to show on lg -->
        <a class="navbar-brand d-none d-lg-inline-block" href="~/Info/About"><img class="my-small-logo" src=@smallLogo alt="brand small logo">@siteName</a>

        <!-- Set to show on sm -->
        <a class="navbar-brand d-lg-none d-inline-block w-100" href="~/Info/About">@siteNameShort<img class="my-small-logo-2" src=@smallLogo alt="brand my-small-logo-2"></a>

        <!-- Toggle Button -->
        <div class="text-left pe-2 pt-1">
            <button class="navbar-toggler pe-2" type="button" data-bs-toggle="collapse" data-bs-target="#navbarToggler" aria-controls="navbarToggler" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        </div>

    </div>

    <!-- Selection Choices -->
    <div class="collapse navbar-collapse flex-grow-1 text-right" id="navbarToggler">

        <ul class=" ps-4 navbar-nav ms-auto flex-nowrap">

            <li class="nav-item">
                <a class="nav-link @choice01" aria-current="page" href="~/Info/About">About</a>
            </li>
            <li class="nav-item">
                <a class="nav-link @choice02" href="~/Info/Contact">Contact</a>
            </li>
            <li class="nav-item">
                <a class="nav-link @choice03" href="https://backtothebible.app/library/p/apnazarene" target="_blank">Worship</a>
            </li>
            <li class="nav-item">
                <a class="nav-link @choice04" href="http://apnazarene.org/offsite/code/" target="_blank">Calendar</a>
            </li>
            <li class="nav-item">
                <a class="nav-link @choice05" href="https://apnaz.churchtrac.com/" target="_blank">Members</a>
            </li>
            <li class="nav-item">
                <a class="nav-link @choice06" href="~/Gallery/Gallery">Gallery</a>
            </li>

        </ul>

        @*@If Request.IsAuthenticated Then

                @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})

                    @Html.AntiForgeryToken()

                    @<ul class="nav navbar-nav navbar-right">
                        <li class="nav-item">
                            <a class="nav-link" href="Manage/Index">Manage</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="javascript:document.getElementById('logoutForm').submit()">Log off</a>
                        </li>
                    </ul>

                End Using

            Else

                @<ul class="nav navbar-nav navbar-right">
                    <li class="nav-item">
                        <a class="nav-link" href="~/Account/Register">Register</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="~/Account/Login">Log In</a>
                    </li>
                </ul>

            End If*@

    </div>

</nav>