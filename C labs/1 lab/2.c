//1.2
#include <stdio.h>

int main ()
{
    float a, b;
    int c, d;
    a=5;
    c=5;
    
    printf("введите значение b: ");
    scanf("%f", &b);

    printf("введите значение d: ");
    scanf("%d", &d);

    a=a+b-2;
    printf("1) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    c=c+1;
    printf("2) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    d=c-a+d;
    printf("3) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    a=a*c; 
    printf("4) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    c=c-1;
    printf("5) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    a=a/10;
    printf("6) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    c=c/2;
    printf("7) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    b=b-1; 
    printf("8) a=%f, b=%f, c=%d, d=%d \n", a, b, c, d);

    d=d*(c+b+a);
    printf("итог: a=%f, b=%f, c=%d, d=%d", a, b, c, d);

    return 0;
}