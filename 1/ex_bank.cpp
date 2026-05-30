#include <stdio.h>

float account = 10;

void Deposit(float amount){
    account += amount;
}

void Withdraw(float amount){
    account -= amount;
}

int main()
{
    Deposit(5);
    printf("%f \n",account);
    Withdraw(10);
    printf("%f",account);
    return account;
}