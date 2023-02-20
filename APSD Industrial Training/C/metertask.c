#include <stdio.h>
#include <conio.h>
void main()
{
    long long int cm;
    printf("Enter the length in centimeter:");
    scanf("%lld", &cm);
    long long int m = cm / 100;
    printf("%lld m", m);
    long double km = cm / 100000;
    printf("\n%lf km", km);
}