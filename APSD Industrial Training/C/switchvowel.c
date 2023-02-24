#include <stdio.h>
#include <conio.h>
void main()
{
    char ch;
    printf("Enter a character:");
    scanf("%c", &ch);
    switch (ch)
    {
    case 'A':
    case 'a':
    case 'E':
    case 'e':
    case 'i':
    case 'I':
    case 'o':
    case 'O':
    case 'U':
    case 'u':
        printf("%c is vowel!", ch);
        break;

    default:
        printf("%c is Constent!", ch);
    }
}