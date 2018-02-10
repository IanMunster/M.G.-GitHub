//Check if the num is a integer
Number.prototype.isInteger = function () {
	let ans = false;		//the answer is false
	if(this % 1 == 0){		//if the num is dividable by 1 its an integer
		ans = true;			//so the answer is true
	}
	return ans;				//return the answer
};

//Check if the num is a divisor
Number.prototype.isDivisor = function(num){
	let ans = false;				//the answer is false
	if((this/num).isInteger()){		//if the number is dividable and is an integer
		ans = true;					//the answer is true
	}
	return ans;						//return the answer
};

//Check the possible dividers
Number.prototype.divisors = function(){
	let ans = [];
	let max = this;
	for(i=1;i<=max/2;i++){
		if(max.isDivisor(i)){
			ans.push(i);
		}
	}
	ans.push(max.valueOf());
	return ans;
};


//Prime Number Factorization
Number.prototype.primeFactorization = function(){
	let ans = [],
		primes = [],
		temp = this;
	for(let i=2; i <= temp/2; i++){
		 if(i.divisors().length == 2){
			 primes.push(i);
		 }
	}
	for(let i=0; i<primes.length; i++){
		while(temp.isDivisor(primes[i])){
			ans.push(primes[i]);
			temp = temp/primes[i];
		}
	}
	return ans;
}