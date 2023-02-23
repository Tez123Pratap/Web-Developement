#include <stdio.h>
void main()
{
    int temp, forn;
    int res;
    printf("Enter the temprature in celcius:");
    scanf("%d", &temp);
    res = (temp * 1.8) + 32;
    printf("%d in Forenheit", res);
    printf("\nEnter the temprature in Forenheit:");
    scanf("%d in celcius", &forn);
    res = ((forn - 32) / 1.8) + 1;
    printf("%d", res);
}