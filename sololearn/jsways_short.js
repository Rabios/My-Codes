//Created By Rabia Alhaffar In 16/December/2019
//Hi Devs,I'm Back Again!!!
//Ok,In This Code I'll Talk About How To Make Codes Smaller,Better For Reading!!!
//Let's Take This One:
var a = 6;
var b = 5;
if(a > b)
{
    console.log("Bigger!!!");    
}
else
{
    console.log("Smaller!!!");    
}

//It Is Better If We Written This:
var a = 6,b = 5;
if(a > b) console.log("Bigger!!!"); //Use This Way If You Have Only One Statment To Run,If More You Should Use Curly Brackets!!!
else console.log("Smaller!!!"); //The Same With Line Above!!!
//Yeah,We Written First One In 3 Lines Instead Of 10


//Ok,Let's Go To Another One:
console.log(Number("6")); //Converts "6" String To Int,To 6 As Number
//There Is Easier Way:
console.log(+ "6"); //Advanced Way!!!


//Advance To Next Level:
var a = 6;
var b = 5;
if(a > b)
{
    console.log("Bigger!!!");    
}
else
{
    console.log("Smaller!!!");    
}
//Easier(With Ternary Operator):
var a = 6,b = 5;
var c = (a > b) ? console.log("Bigger!!!") : console.log("Smaller!!!");


//Let's Go To Things That Are Sad:
function Go()
{
    console.log("GO!!!");    
}
Go();
//It Can Be Easier(Through Arrow Functions):
var Go = () => console.log("GO!!!");
Go();
//If You Want To Execute Your Function Code At Starting Compiling,Instead Of Calling Or window.onload,Try This:
;(function()
{
    console.log("GO!!!");    
})();


//Go Now:
function Go(x,y)
{
    console.log("GO!!!");
    console.log(x * y);
}
Go(6,5);
// Instead:
;(function()
{
    console.log("GO!!!");    
;(function(x,y)
{
    console.log(x * y);  
})(6,5);
})();


//Operators Awesome Use:
var d = 6;
var e = 6;
var d_equals_e;
if(d == e)
{
    d_equals_e = true;    
}
else
{
    d_equals_e = false;    
}
if(d_equals_e == true)
{
    console.log("d Equals e!!!");    
}
//Better:
var d,e = 6; //Assigning One Value To More Than One Variable!!!
var d_equals_e = (d == e); //Returns True!!! 
//I Added Brackets Between d == e For Referencing,You Can Remove Them To Become var d_equals_e = d == e;
if(d_equals_e) console.log("d Equals e!!!");
//Or Simpler:
var d,e = 6;
var d_equals_e = (d == e) ? console.log("d Equals e!!!") : console.log("d Not Equals e!!!");
//Or Much Simpler:
var d,e = 6,d_equals_e = (d == e) ? console.log("d Equals e!!!") : console.log("d Not Equals e!!!");
/*
Tips For Javascript/Web Developers:
- Use Firefox Developer Edition,As It Adds APIs With Each Update,Making Javascript Awesome To Use!!!
- Use Firefox Instead Of Chrome For More Javascript Features!!!
- See Babel Javascript,It Is Makes Javascript Code Easier To Use,It Is Awesome!!!,See Here: https://babeljs.io/
*/
//To Here,We Finished So Hope You Liked The Code!!!
//My Motto Is: Speak Less,Do More!!!
//Happy Coding!!!