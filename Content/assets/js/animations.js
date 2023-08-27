const scaleUpElements = document.querySelectorAll(".scale-up-hidden");
const slideRightElements = document.querySelectorAll(".slide-right-hidden");

const observerScaleUp = new IntersectionObserver(
    elementos => {
        elementos.forEach(
            elemento => {

            elemento.target.classList.add("scale-up-center", elemento.isIntersecting)
        }
        )
    })

const observerSlideRight = new IntersectionObserver(
    elementos => {
        elementos.forEach(
            elemento => {
    
            elemento.target.classList.add("slide-right", elemento.isIntersecting)
        }
        )
    })



scaleUpElements.forEach(el => observerScaleUp.observe(el))
slideRightElements.forEach(el => observerSlideRight.observe(el))