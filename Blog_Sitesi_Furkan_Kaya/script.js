window.onscroll = function() {myFunction()};

var baslik = document.getElementById("basligim");

var sticky = baslik.offsetTop;

function myFunction() {
  if (window.pageYOffset > sticky) {
    baslik.classList.add("sticky");
  } else {
    baslik.classList.remove("sticky");
  }
}
