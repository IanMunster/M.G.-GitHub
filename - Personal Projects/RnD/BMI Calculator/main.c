#include <stdio.h>
#include <stdlib.h>
/// <summary>
/// SCRIPT NAME: The Body Mass Index Calculator
/// DESCRIPTION: This Script asks your Name, Age, Weight and Length and calculates you BMI. Depending on your BMI it gives you advise.
/// </summary>
float CalculateBMI(float weight, float length) {    //The Calculate function
    float _bmi = weight / (length*length);          //Calculate the BMI
    _bmi = round(_bmi*10.0f)/10.0f;                 //Round the BMI to a whole Integer
    return _bmi;                                    //return the BMI;
}

void CheckBMI(float bmi, char name[20]){             //The BMI healthiness Check
    if(bmi < 18.5){                                  //When your BMI is too low, show:
        printf("%s watch out, your weight is too low!",name); }
    if(bmi >= 18.5 && bmi < 25){                    //When BMI is perfect, show:
        printf("%s this is a perfect BMI!",name); }
    if(bmi >= 25 && bmi< 30){                       //When BMI is a bit too high, show:
        printf("%s you have a slight overweight, so keep an eye out!",name); }
    if(bmi >=30 && bmi < 40){                       //When BMI is too high, show:
        printf("%s you are overweighted, you have a potential risk of Diabetes, heart disease and back pains! Advised is a loss of 5 to 10Kg ",name); }
    if(bmi >= 40){                                  //When BMI is way too high, show:
        printf("Beware %s! you are seriously overweighted! See a doctor or make an appointment with a dietitian, you have a high risk of complications and heart failure",name); }
    printf("\n");                                   //Add a new line
}

//The main function
int main() {
    float weight;                                   //The weight of the person
    float length;                                   //The length of the person
    float bmi;                                      //The BMI = weight / length^2
    int age;                                        //The age of the person
    char name[20];                                  //The name of the person
    int repeatAnswer;                               //Does the user want to calculate another BMI? 1=YES 0=NO

    repeatAll:                                      //Repeat all of this:
        printf("What is your name? \n");            //Ask for the Name
        scanf("%s", &name);                         //Save Name in name variable
        printf("What is your age? \n");             //Ask for the Age
        scanf("%d", &age);                          //Save Age in age variable
        printf("What is your weight in kilograms? \n");//Ask for the Weight
        scanf("%f", &weight);                       //Save weight in weight variable
        printf("What is your height in meters? \n");//Ask for the Height
        scanf("%f", &length);                       //Save the Height in height variable
        bmi = CalculateBMI(weight, length);         //Call the Calculate function
        printf("%s you are %d years old and your BMI is %f", name, age, bmi);   //Show the results of the Input
        printf("\n");                               //Add a newline
        CheckBMI(bmi, name);                        //Call the BMI healthiness Check
        printf("do you want to check your BMI? Yes = 1/No = 0 \n"); //Ask if want to calculate again?
        scanf("%d", &repeatAnswer);                 //Save the answer in repeatAnswer variable
        switch(repeatAnswer){                       //Switch for YES=1 or NO=0
            case 1: goto repeatAll;                 //On YES=1, repeatAll
        }
        printf("Thanks for using our service. Stay healthy!\n");    //Else show last text:
    return 0;
}
