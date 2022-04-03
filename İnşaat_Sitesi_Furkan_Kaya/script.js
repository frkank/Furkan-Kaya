const slide = document.querySelectorAll(".slide");
let slideNo=0;
function slideShow(slideNumber){
    slideNo=slideNumber;
    if(slideNumber<0)
    {
        slideNo=slide.length-1;
    }else if(slideNumber>=slide.length){
        slideNo=0;
    }
    for(let i=0; i< slide.length; i++){
        slide[i].style.display="none";
    }
    slide[slideNo].style.display="block";
}

function nextSlide() {
    slideNo++;
    slideShow(slideNo);
}

function previousSlide() {
    slideNo--;
    slideShow(slideNo);
}
slideShow(slideNo);


const mainPopup = document.querySelector(".main-popup");

var tikla = document.getElementsByClassName("card");
var tiklaNo = tikla.length;
for (var i = 0; i < tiklaNo; i++) {
    tikla[i].addEventListener('click', ()=>{
        mainPopup.style.display="block";
    });
  }

mainPopup.addEventListener("click", e =>{
    if(e.target.className=="main-popup" || e.target.className=="close-popup"){
        mainPopup.style.display="none";
    }
})

const submit = document.querySelector(".content-popup button");
submit.addEventListener("click",()=>{alert("En kısa sürede size ulaşacağız, ilginiz için teşekkürler.")});