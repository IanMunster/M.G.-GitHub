#include <stdio.h>
#include <stdlib.h>
/// <summary>
/// SCRIPT NAME: Account Information Structure
/// DESCRIPTION: This Script asks for your personal information and saves it in your own Account Info. Afterwards it prints its values back to you.
/// </summary>
//Declaration of the Account Info Structure;
struct AccountInfo{
    int     accountID;
    char    firstname[20];
    char    surname[20];
    float   age;
    char    eMail[50];
    char    adress[50];
    char    city[50];
};

int main() {
    void BuildStruct(void);
    BuildStruct();
    return 0;
}

void BuildStruct(){
    //New instance of the AccountInfo Structure
    struct AccountInfo _account1; //New 1 Account of type AccountInfo
    struct AccountInfo _account2; //New 2 Account of type AccountInfo
    //Account 1 Specifications
    _account1.accountID = 001;
    printf("What is your First name? \n");
    scanf("%s", &_account1.firstname);
    printf("What is your Surname? \n");
    scanf("%s", &_account1.surname);
    printf("What is your Age? \n");
    scanf("%f", &_account1.age);
    printf("What is your Email? \n");
    scanf("%s",&_account1.eMail);
    printf("What is your Adress? \n");
    scanf("%s",&_account1.adress);
    printf("In what City do you live? \n");
    scanf("%s",&_account1.city);
    //Account 1 End
    printf("\n");
    printf(" Thank you for you cooperation. Please let your partner fill in the next form: \n");
    printf("\n");
    //Account 2 Specifications
    _account2.accountID = 002;
    printf("What is your First name? \n");
    scanf("%s", &_account2.firstname);
    printf("What is your Surname? \n");
    scanf("%s", &_account2.surname);
    printf("What is your Age? \n");
    scanf("%f", &_account2.age);
    printf("What is your Email? \n");
    scanf("%s", &_account2.eMail);
    printf("What is your Adress? \n");
    scanf("%s", &_account2.adress);
    printf("In what City do you live? \n");
    scanf("%s", &_account2.city);
    //Account 2 End
    printf("\n");
    printf("Thank you for filling in the forms, please make sure the information is correct: \n");
    printf("\n");
    //Print out the values
    printf("Account ID: %d \n", _account1.accountID);
    printf("Name: %s ",       _account1.firstname);
    printf("%s \n",             _account1.surname);
    printf("Age: %f \n",        _account1.age);
    printf("Email: %s \n",      _account1.eMail);
    printf("Adress: %s \n",     _account1.adress);
    printf("City: %s \n",       _account1.city);

    printf("\n");

    printf("Account ID: %d \n", _account2.accountID);
    printf("Name: %s ",       _account2.firstname);
    printf("%s \n",             _account2.surname);
    printf("Age: %f \n",        _account2.age);
    printf("Email: %s \n",      _account2.eMail);
    printf("Adress: %s \n",     _account2.adress);
    printf("City: %s \n",       _account2.city);

    printf("\n");
    printf("Thank you for using our Service! \n");
}
