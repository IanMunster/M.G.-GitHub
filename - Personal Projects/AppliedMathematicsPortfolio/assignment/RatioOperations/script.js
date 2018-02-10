var content = document.getElementById("Content"),
a1 = document.getElementById("divid1"),
a2 = document.getElementById("divis1"),
b1 = document.getElementById("divid2"),
b2 = document.getElementById("divis2"),
ans1 = document.getElementById("ans1"),
ans2 = document.getElementById("ans2"),
button = document.getElementById("submit"),
	a,b,ans;

button.addEventListener("click",()=>{
	a = new Ratio(a1.value,a2.value);
	b = new Ratio(b1.value,b2.value);
	ans = a.add(b);
	ans1.value = ans.dividend;
	ans2.value = ans.divisor;
});