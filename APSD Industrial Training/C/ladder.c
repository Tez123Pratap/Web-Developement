#include <stdio.h>
#include <conio.h>
void main()
{
    int phy, che, bio, math, eng, per;
    printf("Enter your mark of physic:");
    scanf("%d", &phy);
    printf("Enter your mark of Chemistry:");
    scanf("%d", &che);
    printf("Enter your mark of biology:");
    scanf("%d", &bio);
    printf("Enter your mark of math:");
    scanf("%d", &math);
    printf("Enter your mark of english:");
    scanf("%d", &eng);
    per = (phy + che + bio + math + eng) * 100 / 500;
    if (per >= 90 && per <= 100)
        printf("Your grade is A");
    else if (per >= 80 && per < 90)
        printf("Your grade is B");
    else if (per >= 70 && per < 80)
        printf("Your grade is C");
    else if (per >= 60 && per < 70)
        printf("Your grade is D");
    else if (per >= 40 && per < 60)
        printf("Your grade is E");
    else
        printf("Your grade is F(Fail)");
}