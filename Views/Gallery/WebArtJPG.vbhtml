@Code

    ViewData("Title") = ViewData("PageTitle")

    Dim folder As String = "/Content/Gallery/WebArt/Jpg/"
    Dim extension As String = ".jpg"
    Dim filecount As Integer = SiteHelpers.ImageCount(folder, extension)

End Code

<button onclick="topFunction()" id="my-button" title="Go to top">Top</button>

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 my-3">
        <h3 class="text-center">
            <img class="my-card-image" src="~/Content/Svg/Artwork.svg" />
            <span class="text-white">WebArt:</span><span class="text-light fs-4"> Jpg</span>
        </h3>
        <p class="text-center text-light">A collection images used by us.</p>
    </div>

    <!-- Button Row-->
    <div class="row gx-1 gx-lg-5">

        <!-- Back Button -->
        <div class="col-2 mb-2">
            <div class="h-100 text-center text-white">
                <a class="btn btn-danger text-sucess btn-sm my-group-buttons-webart" href="~/Gallery/Gallery">
                    <img class="my-back-button-image" src="~/Content/Svg/backspace.svg" />
                </a>
            </div>
        </div>

        <!-- Group 01 Button -->
        <div class="col-2 mb-2">
            <div class="h-100 text-center text-white">
                <a class="btn btn-primary btn-sm my-group-buttons-webart" href="~/Gallery/WebArtSVG">.Svg</a>
            </div>
        </div>

        <!-- Group 02 Button -->
        <div class="col-2 mb-2">
            <div class="h-100 text-center text-white">
                <a class="btn btn-primary btn-sm my-group-buttons-webart" href="~/Gallery/WebArtPNG">.Png</a>
            </div>
        </div>

        <!-- Group 03 Button -->
        <div class="col-2 mb-2">
            <div class="h-100 text-center text-white">
                <a class="btn btn-dark btn-sm my-group-buttons-webart" href="~/Gallery/WebArtJPG">.Jpg</a>
            </div>
        </div>

        <!-- Group 04 Button -->
        <div class="col-2 mb-2">
            <div class="h-100 w-100 text-center">
                <a class="btn btn-primary btn-sm my-group-buttons-webart" href="~/Gallery/WebArtZip">.Zip</a>
            </div>
        </div>
    </div>

    <!-- Image List -->
    <div class="row gx-1 gx-lg-5" id="imagelist">
        <!-- Script places stuff here -->
    </div>

</div>

<script>
    createFolderList("@folder", "@filecount", "@extension");
</script>

<script>

    // Add a "Top" button to page so we can get back to the top of the page.

    //Get the button
    var mybutton = document.getElementById("my-button");

    // When the user scrolls down 20px from the top of the document, show the button
    window.onscroll = function () { scrollFunction() };

    function scrollFunction() {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
            mybutton.style.display = "block";
        } else {
            mybutton.style.display = "none";
        }
    }

    // When the user clicks on the button, scroll to the top of the document
    function topFunction() {
        document.body.scrollTop = 0;
        document.documentElement.scrollTop = 0;
    }

</script>
