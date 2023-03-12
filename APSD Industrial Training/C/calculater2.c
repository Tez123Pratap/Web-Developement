#include <stdio.h>
void main()
{
    int op;
    int a, b;
    printf("1 for addition.\n");
    printf("2 for Substraction.\n");
    printf("3 for odd or even.\n");
    printf("Choose your operation b/w 1 to 3:\n");
    scanf("%d", &op);
    switch (op)
    {
    case 1:
        printf("Enter two number:");
        scanf("%d %d", &a, &b);
        printf("Sum of %d and %d is %d\n", a, b, a + b);
        break;
    case 2:
        printf("Enter two number:");
        scanf("%d %d", a, b, a + b);
        printf("Substraction of %d and %d is %d", a, b, a + b);
        break;
    case 3:
        printf("Enter a number:");
        scanf("%d", &a);
        if (a % 2 == 0)
            printf("Even");
        else
            printf("odd");
        break;

    default:
        printf("Invalid number!please enter a valid number.");
        break;
    }
}