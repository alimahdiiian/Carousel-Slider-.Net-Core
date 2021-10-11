// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



//Scroll to Top
//Get the button:
mybutton = document.getElementById("myBtn");

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
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}
//end of scroll to top




//Sweetalert2
function VisitMyWebSite() {
    Swal.fire({
        title: '<strong><u>Welcome</u>!</strong>',
        icon: 'info',
        html:
            'Would you like to visit my website? <b>Use the link</b>, ' +
            '<a href="https://alimahdian.com/">https://alimahdian.com/</a> ' +
            'or click the button below',
        showCloseButton: true,
        showCancelButton: true,
        focusConfirm: false,
        confirmButtonText:
            '<a href="https://alimahdian.com/">Yes <i class="fa fa-thumbs-up"></i> </a> ',
        confirmButtonAriaLabel: 'Thumbs up, great!',
        cancelButtonText:
            '<i class="fa fa-thumbs-down"></i>',
        cancelButtonAriaLabel: 'Thumbs down'
    })
}
//end of sweetalert2



//date picker 
$(function () {
    $("#stDate").datepicker();
});

$(function () {
    $("#enDate").datepicker();
});
//end of datepicker 


//image preview in createslider view & editslider view 
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

        reader.onload = function (e) {
            $('#imgPreview').attr('src', e.target.result);
                }

        reader.readAsDataURL(input.files[0]); // convert to base64 string
            }
        }

        $("#imgUp").change(function () {
            readURL(this);
        });

//end of image preview