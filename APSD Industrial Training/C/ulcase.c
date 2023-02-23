#include <stdio.h>
#include <conio.h>
void main()
{
    char ch;
    printf("Enter a character:");
    scanf("%c", &ch);
    if (ch >= 'a' && ch <= 'z')
        printf("%c is lowercase!", ch);
    else
        printf("%c is uppercase!", ch);
}