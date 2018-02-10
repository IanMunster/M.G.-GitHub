
var inputBox = document.getElementById("inputBox"),
	myButton = document.getElementById("inputButton"),
	myImage = document.getElementById("myImage");

myButton.addEventListener('click',()=>{
	let source = inputBox.value;
	myImage.src = source;
	
	myImage.addEventListener("load",()=>{
		ratio = new Ratio(myImage.height, myImage.width);
		console.log(ratio.simplify());
	})
})

//let ratio = new Ratio(1920,1080);
//console.log(ratio.simplify());

//let ab = new NumberPair(1920,1080);
//console.log(ab.gcd());