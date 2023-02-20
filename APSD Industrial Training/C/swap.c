#include <stdio.h>
void main()
{
    int a, b;
    printf("Enter two number:");
    scanf("%d%d", &a, &b);
    printf("Before swapping:\na=%d  b=%d", a, b);
    a = a + b;
    b = a - b;
    a = a - b;
    printf("\nBefore swapping:\na=%d  b=%d", a, b);
}