@code
    Dim altText As String = ViewData("PageHeader")
    Dim folder As String = ViewData("Message")
    Dim videoFilename As String = "/Content/Catagories/Gallery/Videos/01/000001.mp4#t=2.5"
End Code

<!-- Video Container -->
<div id="RightContainer" class="col-lg-7 pt-2 pb-3" >

     <div class="ratio ratio-16x9" >

        <div id="trailer" class="section d-flex justify-content-center embed-responsive embed-responsive-4by3">
            <video class="myvideo embed-responsive-item" controls autoplay loop muted>
                <source src="@videoFilename" type="video/mp4">
                Your browser does not support the video tag.
            </video>
        </div>
    </div>

</div>