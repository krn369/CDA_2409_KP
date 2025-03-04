/*
    

const product = {
    title : "Ball Pen",
    rating : 4.5,
    offer : "Buy 1 get 1 free",
    price : 10
};

console.log(product);


const profile = {
    fullName : "Karan PARIYAR",
    age : 26,
    address : "Mulhouse, France",
    isStudent : true,
    isEmployed : false,
    hobbies : ["Reading", "Coding", "Gaming"],
    contact : {
        email : "karan123@hub.com",
        phone : "1234567890"
    }
}

console.log(profile);
console.log(profile.contact.email);
console.log(profile.hobbies[1]);
console.log(typeof profile["contact"]);
console.log(typeof profile.contact.email);


// Arthemetic Operators

let a = 5;
let b = 2;
let c = 10;

c = c+1;
c++;
c--;

console.log("a + b = ", a + b);
console.log("a - b = ", a - b);
console.log("a * b = ", a * b);
console.log("a / b = ", a / b);
console.log("a % b = ", a % b);
console.log("a ** b = ", a ** b);  // Exponential Operator 5^2 = 25	

console.log("c = ", ++c)



// Assignment Operators

let a = 5;
let b = 2;  

a += 4; // a = a + 4
b **= 5; // b = b ** 5
console.log("a = ", a);
console.log("b = ", b);

// Comparison Operators

let a = 5;  
let b = 2;
let c = "5";

console.log("a == b : ", a == b);
console.log("a != b : ", a != b);
console.log("a == c : ", a == c);
console.log("a === c : ", a === c);
console.log("a !== c : ", a !== c);
console.log("a > b : ", a > b);
console.log("a <= b : ", a <= b);


// Logical Operators

let d = 6;
let e = 9;

console.log("cond1 && cond2 : ", d < e && d === 6);
console.log("cond1 && cond2 : ", d > e || d < e);
console.log("!(cond1 && cond2) : ", !(d < e && d === 6));



// Conditional Statements

let age = 16;

if (age >= 18) {
    console.log("You are eligible to vote.");
}   else {
    console.log("You are not eligible to vote.");
}


let mode = "light";
let color;

if (mode === "light") {
    color = "white";
}   else {
    color = "black";
}
 
console.log("Color is : ", color);


// Odd or Even

let num = 99;

if (num % 2 === 0) {
    console.log(num, "is an even number.");
}   else {
    console.log(num, "is an odd number.");
}


//else if

let age1 = 66;

if (age1 < 18){
    console.log("You are a minor.");
}
else if (age1 > 60){
    console.log("You are a senior citizen.");
}   else {
    console.log("You are an adult.");
}

// Ternary Operator

let age2 = 26;  

let message = (age2 >= 18) ? "You are eligible to drink alcohol." : "You are not eligible to drink  alcohol.";
console.log(message);



 alert("Hello! Welcome to my website."); // Alert Box One time pop up

  let fullName = prompt("Hello! What is your name?");
 console.log("Welcome", fullName);


let number = prompt("Enter a number : ");
if (number % 5 === 0){
    console.log(number, "is divisible by 5.");
}else{
    console.log(number, "is not divisible by 5.");
}



let finalScore = prompt("Enter your final score : ");
if (finalScore >= 90 && finalScore <= 100){
    console.log("BRAVO !, You got an A grade.");
}

else if (finalScore >= 80 && finalScore < 90){  
    console.log("CONGRATS !, You got a B grade.");
}

else if (finalScore >= 70 && finalScore < 80){
    console.log("WELL DONE !, You got a C grade.");
}

else if (finalScore >= 60 && finalScore < 70){
    console.log("GOOD JOB !, You got a D grade.");
}

else if (finalScore < 60 && finalScore >= 0){
    console.log("SORRY !, You got an F grade.");
}

else{
    console.log("Invalid Input.");
}

console.log("Thank you for using our grading system.");



// LOOPS in JS 

for(let i = 1; i <= 5; i++){
    console.log("Hello Karan", i);
}


let sum = 0;
for(let i = 1; i <= 5; i++){
    sum += i;
    console.log(i, sum);
}
console.log("Sum of first 5 numbers is : ", sum);

console.log("Loop Ended.");

let i = 1;
while (i <= 5){
    console.log("Hello Darling", i);
    i++;
}

let j = 1;
do {
    console.log("Hello Rosy !", j);
    j++;
} while (j <= 5);

// for-of Loop used for iterating over an array or string

let size = 0;

let str = "Hello World";

for (let val of str){
    console.log("val = ", val);
    size++;
}

console.log("string size = ", size);

// for-in Loop used for iterating over an object

let student = {
    name : "Karan",
    age : 26,
    city : "Mulhouse",
    course : "Engineering",
    isPassed : true
};

for (let key in student){   
    console.log("key = ", key, ", value = ", student[key]);
}

// Print all the even numbers from 0 to 100.

for (let i = 0; i <= 100; i++){
    if (i % 2 === 0){
        console.log(i);
    }
}



// Create a game where you start with any random game number.Ask the user to keep guessing the number until the user guesses the correct number. If the user enters a number which is greater than the actual number, print "Your guess is too high." If the user enters a number which is less than the actual number, print "Your guess is too low." If the user enters the correct number, print "Congratulations! You have guessed the correct number."

let gameNumber = Math.floor(Math.random() * 100) + 1;
let userNumber;

do {
    userNumber = parseInt(prompt("Enter your guess : "));
    if (userNumber > gameNumber){
        console.log("Your guess is  high.");
    } else if (userNumber < gameNumber){
        console.log("Your guess is  low.");
    } else {
        console.log("Congratulations! You have guessed the correct number.");
    }
} while (userNumber !== gameNumber);

*/


// Strings in JS

let str = "Hello World";
console.log(str);
console.log(str.length);
console.log(str[8]);


// Template Literals

let specialString = `This is a template literal string.`;
console.log(specialString);
console.log(typeof specialString);


let output = `The cost of the `
