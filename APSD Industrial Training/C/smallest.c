#include <stdio.h>
#include <conio.h>
void main()
{
    int a, b, c;
    printf("Enter three number:");
    scanf("%d %d %d", &a, &b, &c);
    printf("Smallest number is %d ", a < b ? a < c ? a : c : b < c ? b
                                                                   : c);
}