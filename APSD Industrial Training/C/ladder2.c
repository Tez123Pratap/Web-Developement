#include <stdio.h>
#include <conio.h>
void main()
{
    char ch;
    printf("Enter any character b/w a to e:");
    scanf("%c", &ch);
    if (ch == 'a')
        printf("Apple");
    else if (ch == 'b')
        printf("boy");
    else if (ch == 'c')
        printf("cat");
    else if (ch == 'd')
        printf("dog");
    else if (ch == 'e')
        printf("Elephent");
    else
        printf("Invalid character.");
}