#include <stdio.h>
void main()
{
    int op;
    int a, b;
    printf("1 for addition.\n");
    printf("2 for Substraction.\n");
    printf("3 for multiply.\n");
    printf("4 for divide.\n");
    printf("Choose your operation b/w 1 to 4:\n");

    scanf("%d", &op);

    switch (op)
    {
    case 1:
        printf("Enter two number:");
        scanf("%d%d", &a, &b);
        // printf("Enter second number:");
        // scanf("%d", &b);
        printf("Sum of %d and %d is %d", a, b, a + b);
        break;
    case 2:
        printf("Enter two number:");
        scanf("%d%d", &a, &b);
        printf("Substraction of %d and %d is %d", a, b, a - b);
        break;
    case 3:
        printf("Enter two number:");
        scanf("%d%d", &a, &b);
        printf("Multiplication of %d and %d is %d", a, b, a * b);
        break;
    case 4:
        printf("Enter two number:");
        scanf("%d%d", &a, &b);
        printf("Division of %d and %d is %d", a, b, a / b);
        break;

    default:
        printf("Invalid case!");
        break;
    }
}