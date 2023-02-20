#include <stdio.h>
#include <conio.h>
#include <math.h>
void main()
{
    int x, y;
    printf("Enter the value of x and y:");
    scanf("%d %d", &x, &y);
    int c = pow(x, y);
    printf("%d", c);
}