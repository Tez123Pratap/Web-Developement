#include <stdio.h>
#include <conio.h>
void main()
{
    int num1, num2, num3;
    printf("Enter three number:");
    scanf("%d%d%d", &num1, &num2, &num3);
    if (num1 > num2)
    {
        if (num1 > num3)
        {
            printf("num1=%d is greatest!", num1);
        }
        else
        {

            printf("num3=%d is greatest!", num3);
        }
    }
    else
    {
        if (num2 > num3)
        {
            printf("num2=%d is greatest!", num2);
        }
        else
        {
            printf("num3=%d is greatest!", num3);
        }
    }
}