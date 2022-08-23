//***********************************************//
//  Function used to open Web Page in new Tab    //
//***********************************************//
function newTab(tabURL) {
    let newWindowTab = window.open(tabURL);
};

//***********************************************//
//  Create Folder List of File Items             //
//***********************************************//
function createFolderList(folderURL, filecount, extension) {    

    extension = extension.toLowerCase();
        
    let filename = "";
    let htmlstring = "";
    let altText = "";

    let i = filecount;
    if (i > 0) {
   
        while (i > 0) {

            filename = folderURL.concat("000000".concat(i).slice(-6)) + extension;
            

            if (extension == ".mp4") {

                // Display Video
                htmlstring += "<div class='container col-lg-6 mb-0 p-1 h-100 bg-transparent rounded'>" +
                    "<video width='100%' controls autoplay muted>" +
                    "<source src='" + filename + "#t = 2.5' type='video/mp4'>" +
                    "</video>" +
                    "</div>";
            } else {

                // Display Picture
                htmlstring += "<div class='container col-md-3 mb-0 p-1 h-100 bg-transparent rounded'>" +
                    "<a href='" + filename + "' target='_blank'>" +
                    "<img class='img-thumbnail img-fluid p-0' src='" + filename + "' alt='" + altText.concat("000000".concat(i).slice(-6)) + "' />" +
                    "</a>" +
                    "</div>";
            }
             i--;
        };

        document.getElementById("imagelist").innerHTML = htmlstring;

    };    

}

//***********************************************//
//  Create Image List of Carousel Items          //
//***********************************************//
function createImageList(imageLocation, altText, imageCount) {
        
    altText = "";
    var i = imageCount;

    // Create the needed "active" element
    var text = "<div class='carousel-item active'><img class='d-block w-100' src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(imageCount).slice(-6)) + "' /></div>";
    i--;

    // Add the rest of the elements
    while (i > 0) {
        text += "<div class='carousel-item'><img class='d-block w-100' src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(i).slice(-6)) + "' /></div>";
        i--;
    }

    document.getElementById("CarouselItems").innerHTML = text;
     
}

//***********************************************//
//  Change background                            //
//***********************************************//
function changeBackground(newBackground) {
    $('body').css('background-image', newBackground);
}