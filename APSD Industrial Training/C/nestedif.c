#include <stdio.h>
#include <conio.h>
void main()
{
    int n1, n2;
    printf("Enter two number:");
    scanf("%d%d", &n1, &n2);
    if (n1 != n2)
    {
        printf("n1 is not equal n2\n");
        if (n1 > n2)
        {
            printf("n1 is greater than n2\n");
        }
        else
        {
            printf("n2 is greater than n1\n");
        }
    }
    else
    {
        printf("n1 is equal to n2");
    }
}