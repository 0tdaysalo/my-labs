//3.2
#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int *p, c;
    int *a, b;
    float *x, y = 3.5;
    double *m, n;
    a = &b;
    printf(" Enter b = ");
    scanf("%d", a);
    printf("a=%p\t*a=%d\tb=%d\n", a, *a, b);
    p=a;
    c=*p;
    *p=*(p+3);
    *(p+3)=c;
    printf("p=%p\tc=%d\ta=%p\tb=%d\n", p, c, a, b);
    x = &y;
    printf("x=%p\t*x=%f\ty=%f\n", x, *x, y);
    a=(int*)x;
    *a = *x;
    printf("a=%p\t*a=%d\tx=%p\t*x=%f\ty=%f\n",
     a, *a, x, *x, y);
    a = &b;
    y = 12345,6789;
    printf("x=%p\t*x=%f\ty=%f\n", x, *x, y);
    p = (int*)x;
    c=*p;
    *p=*(p+3);
    *(p+3)=c;
    printf("p=%p\tc=%d\tx=%p\ty=%f\n", p, c, x, y);
    m = &n;
    printf("m=%p\t*m=%lf\tn=%lf\n", m, *m, n);
    n = 5.5;
    printf("m=%p\t*m=%lf\tn=%lf\n", m, *m, n);
    b = n = y = 1.7;
    printf("b=%d\ty=%f\tn=%lf\n", b, y, n);
    printf("*a=%d\t*x=%f\t*m=%lf\n", *a, *x, *m);
    m += 2;
    printf("n=%lf\tn=%p\tm=%p\n", n, &n, m);
    *m = (float)*a - n + (int)*x;
    printf("m=%p\t*m=%lf\n", m, *m);
    system("pause");

    return 0;
}