#include <stdio.h>
#include <conio.h>
void main()
{
    int num;
    printf("Enter any number:");
    scanf("%d", &num);
    if (num % 5 == 0 && num % 11 == 0)
    {
        printf("%d is divisible by 5 and 11", num);
    }
    else if (num % 5 == 0)
    {
        printf("%d is divisible by 5 but not divisible by 11", num);
    }
    else
    {
        printf("%d is divisible by 11 but not divisible by 5", num);
    }

    // if (num % 5 == 0)
    // {
    //     printf("%d is divisible by 5\n", num);
    //     if (num % 11 == 0)
    //         printf("%d is divisible by 11\n", num);
    //     else
    //         printf("%d is not divisible by 11\n", num);
    // }
    // else
    // {
    //     printf("%d is not divisible by 5\n", num);
    //     if (num % 11 == 0)
    //         printf("%d is divisible by 11\n", num);
    //     else
    //         printf("%d is not divisible by 11", num);
    // }
}