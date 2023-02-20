#include <stdio.h>
#include <math.h>
void main()
{
    int num;
    printf("Enter  a number:");
    scanf("%d", &num);
    int res = sqrt(num);
    printf("Square root=%d", res);
}