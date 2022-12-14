@code
    Dim siteName = "Avon Park Nazarene Church"
    Dim copyright As String = "Copyright © " + Date.Now.Year.ToString + " " + siteName


    ' Keep Current Menu Selection Active (Highlighted)
    Dim choice01 As String = ""
    Dim choice02 As String = ""
    Dim choice03 As String = ""
    Dim choice04 As String = ""
    Dim choice05 As String = ""
    Dim choice06 As String = ""
    Dim choice07 As String = ""
    Dim choice08 As String = ""

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
        choice05 = "active"
    End If
    If ViewData("message") = "Gallery" Then
        choice06 = "active"
    End If
    If ViewData("message") = "Privacy" Then
        choice07 = "active"
    End If
    If ViewData("message") = "TOS" Then
        choice08 = "active"
    End If

End Code
<footer class="navbar navbar-dark border-top box-shadow pt-0" style="background-color: #4A4B4C;" role="contentinfo" aria-label="Site footer">

    <div class="flex-grow-0 text-right" style="width: 90%;">

        <div class="row px-2">

            <div class="col-4  ps-2">
                <h6 class="navbar-text text-white mb-0">Info</h6>
                <ul class="navbar-nav ms-auto flex-nowrap ps-2">
                    <li class="nav-item  text-light">
                        <a class="nav-link @choice01" style="font-size: 12px;" href="~/Info/About">About Us</a>
                    </li>
                    <li class="nav-item text-light">
                        <a class="nav-link @choice02" style="font-size: 12px;" href="~/Info/Contact">Contact Us</a>
                    </li>
                    <li class="nav-item text-light">
                        <a class="nav-link @choice07" style="font-size: 12px;" href="~/Info/Privacy">Privacy Policy</a>
                    </li>
                    <li class="nav-item text-light">
                        <a class="nav-link text-nowrap @choice08" style="font-size: 12px;" href="~/Info/TOS">Terms of Service</a>
                    </li>
                </ul>
            </div>

            <div class="col-4">
                <h6 class="navbar-text text-white mb-0">Features</h6>
                <ul class="navbar-nav ms-auto flex-nowrap ps-2">
                    <li class="nav-item text-light">
                        <a class="nav-link @choice04" style="font-size: 12px;" href="https://backtothebible.app/library/p/apnazarene" target="_blank">Worship</a>
                    </li>
                    <li class="nav-item text-light">
                        <a class="nav-link @choice03" style="font-size: 12px;" href="http://apnazarene.org/offsite/code/" target="_blank">Calendar</a>
                    </li>
                    <li class="nav-item text-light">
                        <a class="nav-link @choice05" style="font-size: 12px;" href="https://apnaz.churchtrac.com/">Members</a>
                    </li>
                    <li class="nav-item text-light">
                        <a class="nav-link @choice06" style="font-size: 12px;" href="~/Gallery/Gallery">Gallery</a>
                    </li>
                </ul>
            </div>

            <div class="col-4 pe-0">
                <h6 class="navbar-text text-white mb-0">Members</h6>
            </div>

        </div>
    </div>
    <div class="p-0 m-0 w-100 bg-secondary text-white">
        <h6 class="text-center m-0 py-2" style="font-size: 10px;">@siteName &copy; @DateTime.Now.Year All Rights Reserved.</h6>
    </div>

</footer>


