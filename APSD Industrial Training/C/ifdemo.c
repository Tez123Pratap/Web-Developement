#include <stdio.h>
void main()
{
    int age;
    printf("Enter Your age:");
    scanf("%d", &age);
    if (age >= 18)
        printf("You are eligible for vote!");
    else
        printf("you are not eligble for vote!");
}