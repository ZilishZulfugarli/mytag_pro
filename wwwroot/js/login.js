let registerClick = document.querySelector(".register-click");
let registerBox = document.querySelector(".register-box");

console.log(registerClick);

window.addEventListener("DOMContentLoaded", ()=>{
    register();
})

function register(){
    registerClick.addEventListener("click", ()=>{
        console.log("salam")
        registerBox.innerHTML = ``;

    
        registerBox.innerHTML += 
        `
        <h2>Welcome to XCOM</h2>
                <h4 id="login">Register</h4>
                <br>
                <div class="input-row">
                    <p>Name</p><input type="text" name="name" id="">
                </div>
                <div class="input-row">
                    <p>Email</p><input type="email" name="email" id="">
                </div>
                <div class="input-row">
                    <p>Password</p><input type="password" name="password" id="">
                </div>
                <p>You haven't profile yet? <a href="" id="register-click">Click for Register</a></p>
                <br>
                <button class="login-btn">Login</button>
        `

        
    })
}
