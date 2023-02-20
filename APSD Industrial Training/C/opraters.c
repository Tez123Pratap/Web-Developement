#include <stdio.h>
void main()
{
    int a, b;
    printf("Enter two number:");
    scanf("%d%d", &a, &b);
    printf("Sum of %d and %d = %d\n", a, b, a + b);
    printf("Substraction of %d and %d = %d\n", a, b, a - b);
    printf("multiply of %d and %d = %d\n", a, b, a + b);
    printf("Division of %d and %d = %d\n", a, b, a / b);
    printf("modulus of %d and %d = %d\n", a, b, a % b);
}