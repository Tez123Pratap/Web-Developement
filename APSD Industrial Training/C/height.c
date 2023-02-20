#include <stdio.h>
void main()
{
    int height;
    printf("Enter your height in centimeter:");
    scanf(" %d", &height);
    // float foot=height/30.48;
    if (height > 153)
    {
        printf("You are Taller!");
    }
    else
    {
        printf("You are Smaller!");
    }
}