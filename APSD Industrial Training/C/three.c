#include <stdio.h>
#include <conio.h>
void main()
{
    int a, b, c;
    printf("Enter 1st number:");
    scanf("%d", &a);
    printf("Enter 2nd number:");
    scanf("%d", &b);
    c = a + b;
    printf("Sum of %d and %d is : %d", a, b, c);
}