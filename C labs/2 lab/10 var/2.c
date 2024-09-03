//2.2
#include <stdio.h>
#include <math.h>

int main()
{
    int a1, a2, x;
    double B;
    
    printf("введите значение a1: ");
    scanf("%d", &a1);
    
    printf("введите значение a2: ");
    scanf("%d", &a2);
    
    printf("введите значение x: ");
    scanf("%d", &x);

    if((a1*pow(sin(2*x)*x, 2) + (x + a2)*exp((-2)*x)) < 0 || (a1*a1 + a2*a2) < 0 || (x + (a1*a1 + a2*a2)) != 0)
    {
        printf("1 или несколько из введённых значений не пренадлежит области определения выражения!");
    }
    else
    {
        B = ( sqrt(a1*pow(sin(2*x)*x, 2) + (x+a2)*exp((-2)*x)) ) / ( x + sqrt(a1*a1+a2*a2) );
        printf("%f", B);
    }
    
    return 0;
}