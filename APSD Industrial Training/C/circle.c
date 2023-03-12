#include <stdio.h>
#include <conio.h>
void main()
{
    int radius;
    printf("Enter the radius of circle:");
    scanf("%d", &radius);
    printf("area of circle is %.2f", (float)(3.14 * radius * radius));
}