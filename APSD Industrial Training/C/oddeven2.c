#include <stdio.h>
void main()
{
    printf("\nEven number\n");
    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0)
            printf("%d\t", i);
    }
    printf("\nOdd number\n");
    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 != 0)
            printf("%d\t", i);
    }
}