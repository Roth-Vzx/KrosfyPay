const scaleUpElements = document.querySelectorAll(".scale-up-hidden");
const slideRightElements = document.querySelectorAll(".slide-right-hidden");

const observerScaleUp = new IntersectionObserver(
    elementos => {
        elementos.forEach(
            elemento => {

            elemento.target.classList.toggle("scale-up-center", elemento.isIntersecting)
        }
        )
    })

const observerSlideRight = new IntersectionObserver(
    elementos => {
        elementos.forEach(
            elemento => {
    
            elemento.target.classList.toggle("slide-right", elemento.isIntersecting)
        }
        )
    })



scaleUpElements.forEach(el => observerScaleUp.observe(el))
slideRightElements.forEach(el => observerSlideRight.observe(el))