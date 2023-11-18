let shop = document.querySelector(".shop");
let downgrade = document.getElementById("downgrade");
let main = document.querySelector(".main");

shop.addEventListener("mouseover", ()=>{
    downgrade.style.display = "block"
})

main.addEventListener("mouseover", ()=>{
    downgrade.style.display = "none"
})