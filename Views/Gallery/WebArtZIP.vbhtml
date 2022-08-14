<button onclick="topFunction()" id="my-button" title="Go to top">Top</button>

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 my-3">
        <h3 class="text-center">
            <img class="my-card-image" src="~/Content/Catagories/Svg/Artwork.svg" />
            <span class="text-white">WebArt:</span><span class="text-light fs-4"> .Zip</span>
        </h3>
        <p class="text-center text-light">Master Bulldog .Zip files for printing.</p>
        <p class="text-center text-light">Contains .AI .EPS, .PDF, .SVG, and .PNG formats.</p>

        <!-- Button Row-->
        <div class="row gx-1 gx-lg-5">

            <!-- Back Button -->
            <div class="col-2 mb-2">
                <div class="h-100 text-center text-white">
                    <a class="btn btn-danger text-sucess btn-sm my-group-buttons-webart" href="~/Gallery/Gallery">
                        <img class="my-back-button-image" src="~/Content/Catagories/Svg/backspace.svg" />
                    </a>
                </div>
            </div>

            <!-- Group 01 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-primary btn-sm my-group-buttons-webart" href="~/Gallery/WebArtSVG">.Svg</a>
                </div>
            </div>

            <!-- Group 02 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-primary btn-sm my-group-buttons-webart" href="~/Gallery/WebArtPNG">.Png</a>
                </div>
            </div>

            <!-- Group 03 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-primary btn-sm my-group-buttons-webart" href="~/Gallery/WebArtJPG">.Jpg</a>
                </div>
            </div>

            <!-- Group 04 Button -->
            <div class="col-2 mb-2">
                <div class="h-100 w-100 text-center">
                    <a class="btn btn-dark btn-sm my-group-buttons-webart" href="~/Gallery/WebArtZip">.Zip</a>
                </div>
            </div>

        </div>

        <!-- Image List -->
        <div class="row gx-1 gx-lg-5">

            <!-- AP Logo Round -->
            <div class="container col-sm-12 col-md-6 col-lg-4 col-xl-4 mb-0 p-1">
                <a class="my-auto-margin nav-link bg-light text-center text-black py-2 border border-2 border-dark rounded shadow px-2 py-2" onclick="download_1()" id="newTab" href="#">
                    <img class="my-download-image" src="/Content/Catagories/Gallery/WebArt/Zip/AP-Logo-Round.svg"/><br /><h6>Download<br />AP-Logo-Round.zip</h6>
                </a>
            </div>

            <!-- Bird Black -->
            <div class="container col-sm-12 col-md-6 col-lg-4 col-xl-4 mb-0 p-1">
                <a class="my-auto-margin nav-link bg-light text-center text-black py-2 border border-2 border-dark rounded shadow px-2 py-2" onclick="download_2()" id="newTab" href="#">
                    <img class="my-download-image" src="/Content/Catagories/Gallery/WebArt/Zip/Bird-Black.svg"/><br /><h6>Download<br />Bird-Black.zip</h6>
                </a>
            </div>

            <!-- Bird White -->
            <div class="container col-sm-12 col-md-6 col-lg-4 col-xl-4 mb-0 p-1">
                <a class="my-auto-margin nav-link bg-light text-center text-black py-2 border border-2 border-dark rounded shadow px-2 py-2" onclick="download_3()" id="newTab" href="#">
                    <img class="my-download-image" src="/Content/Catagories/Gallery/WebArt/Zip/Bird-White.svg"/><br /><h6>Download<br />Bird-White.zip</h6>
                </a>
            </div>

            <!-- Bird-Bible Black -->
            <div class="container col-sm-12 col-md-6 col-lg-4 col-xl-4 mb-0 p-1">
                <a class="my-auto-margin nav-link bg-light text-center text-black py-2 border border-2 border-dark rounded shadow px-2 py-2" onclick="download_4()" id="newTab" href="#">
                    <img class="my-download-image" src="/Content/Catagories/Gallery/WebArt/Zip/Bird-Bible-Black.svg"/><br /><h6>Download<br />Bird-Bible-Black.zip</h6>
                </a>
            </div>

            <!-- Bird-Bible White -->
            <div class="container col-sm-12 col-md-6 col-lg-4 col-xl-4 mb-0 p-1">
                <a class="my-auto-margin nav-link bg-light text-center text-black py-2 border border-2 border-dark rounded shadow px-2 py-2" onclick="download_5()" id="newTab" href="#">
                    <img class="my-download-image" src="/Content/Catagories/Gallery/WebArt/Zip/Bird-Bible-White.svg"/><br /><h6>Download<br />Bird-Bible-White.zip</h6>
                </a>
            </div>

            <!-- Seal English Gold -->
            <div class="container col-sm-12 col-md-6 col-lg-4 col-xl-4 mb-0 p-1">
                <a class="my-auto-margin nav-link bg-light text-center text-black py-2 border border-2 border-dark rounded shadow px-2 py-2" onclick="download_6()" id="newTab" href="#">
                    <img class="my-download-image" src="/Content/Catagories/Gallery/WebArt/Zip/Seal-English-Gold.svg"/><br /><h6>Download<br />Seal-English-Gold.zip</h6>
                </a>
            </div>

            <!-- Jesus-Fish -->
            <div class="container col-sm-12 col-md-6 col-lg-4 col-xl-4 mb-0 p-1" ">
                <a class="my-auto-margin nav-link bg-light text-center text-black py-2 border border-2 border-dark rounded shadow px-2 pt-2 pb-5" onclick="download_7()" id="newTab" href="#">
                    <img class="my-download-image" src="/Content/Catagories/Gallery/WebArt/Zip/Jesus-Fish.svg"/><br /><h6>Download<br />Jesus-Fish.zip</h6>
                </a>                
            </div>

        </div>
    </div>
</div>

<script>
    function download_1() {
        var txt;
        var r = confirm("OK to Download 'AP-Logo-Round.zip'?");
        if (r == true) {
            window.open("http://APNazarene.illustrate.net/Content/Catagories/Gallery/WebArt/Zip/AP-Logo-Round.zip")
        } else { }
    }

    function download_2() {
        var txt;
        var r = confirm("OK to Download 'Bird-Black.zip'?");
        if (r == true) {
            window.open("http://APNazarene.illustrate.net/Content/Catagories/Gallery/WebArt/Zip/Bird-Black.zip")
        } else { }
    }

    function download_3() {
        var txt;
        var r = confirm("OK to Download 'Bird-White.zip'?");
        if (r == true) {
            window.open("http://APNazarene.illustrate.net/Content/Catagories/Gallery/WebArt/Zip/Bird-White.zip")
        } else { }
    }

    function download_4() {
        var txt;
        var r = confirm("OK to Download 'Bird-Bible-Black.zip'?");
        if (r == true) {
            window.open("http://APNazarene.illustrate.net/Content/Catagories/Gallery/WebArt/Zip/Bird-Bible-Black.zip")
        } else { }
    }

    function download_5() {
        var txt;
        var r = confirm("OK to Download 'Bird-Bible-White.zip'?");
        if (r == true) {
            window.open("http://APNazarene.illustrate.net/Content/Catagories/Gallery/WebArt/Zip/Bird-Bible-White.zip")
        } else { }
    }
    
    function download_6() {
        var txt;
        var r = confirm("OK to Download 'Seal-English-Gold.zip'?");
        if (r == true) {
            window.open("http://APNazarene.illustrate.net/Content/Catagories/Gallery/WebArt/Zip/Seal-English-Gold.zip")
        } else { }
    }

    function download_7() {
        var txt;
        var r = confirm("OK to Download 'Jesus-Fish.zip'?");
        if (r == true) {
            window.open("http://APNazarene.illustrate.net/Content/Catagories/Gallery/WebArt/Zip/Jesus-Fish.zip")
        } else { }
    }
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