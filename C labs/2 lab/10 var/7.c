//2.7
#include <stdio.h>
#include <math.h>

int main()
{
    double x=M_PI/3, sum=0, term=M_PI/3;
    int n=1;
    
    while (fabs(term)>=1e-6)
    {
        sum+=term;
        term=((-1)*term*x*x) / ( (2*n+1)*(2*n) );
        n++;
    }
    
    printf("Значение суммы ряда: %.6lf\n", sum);
    printf("Значение для проверки: %.6lf", sin(x));
    
    return 0;
}