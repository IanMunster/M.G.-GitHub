class NumberPair {
    constructor(a, b) {
      //  console.log("agd", a, b);
        this.a = a;
        this.b = b;
    };

	//Simple sum
    sum() {
        return this.a + this.b;
    };

	//Divide
    longDivision() {
        let ans,
			dividend = this.a,
			divisor = this.b,
			quotient = Math.floor(dividend/divisor),
			rest = dividend % divisor,
			rests = [],
			quotients = [];
        
        ans = quotient + ".";
        
        while(rests.indexOf(rest) == -1){
            rests.push(rest);
            dividend = rest *10;
            quotient = Math.floor(dividend/divisor);
            rest = dividend%divisor;
            ans = ans + quotient;
            quotients.push(quotient);
        }
        quotients.splice(rests.indexOf(rest),0,"[");
        quotients.push("]");
        ans += quotients.join(""); 
        return ans;
    };
	
	//GREATEST COMMON DIVISOR
	gcd() {
		let ans,
			a= this.a,
			b = this.b, 
			t;
		while(b != 0){
			t = b;
			b = a % b;
			a = t;
		}
		ans = a;
		return ans;
	}
}

class Ratio extends NumberPair {
	constructor(a,b){
		super(a,b);
		this.dividend = a;
		this.divisor = b;
	}
	
	add(ratio){
		let dividend = this.dividend * ratio.divisor + ratio.dividend * this.divisor,
			divisor = this.divisor * ratio.divisor,
			ans = new Ratio(dividend,divisor);
		return ans;
	}
	
	simplify(){
		let dividend = this.dividend / this.gcd(),
			divisor = this.divisor / this.gcd(),
			ans = new Ratio(dividend,divisor);
		return ans;
	}
}