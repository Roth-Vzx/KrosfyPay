const scaleUpElements = document.querySelectorAll(".scale-up-hidden");
const slideRightElements = document.querySelectorAll(".slide-right-hidden");

const observerScaleUp = new IntersectionObserver(
    elementos => {
        elementos.forEach(
            elemento => {
                if (elemento.isIntersecting) {
                    elemento.target.classList.add("scale-up-center");
                }
        }
        )
    })

const observerSlideRight = new IntersectionObserver(
    elementos => {
        elementos.forEach(
            elemento => {
                if (elemento.isIntersecting)
                {
                    elemento.target.classList.add("slide-right");
                }
        }
        )
    })



scaleUpElements.forEach(el => observerScaleUp.observe(el))
slideRightElements.forEach(el => observerSlideRight.observe(el))