//2.8
#include <stdio.h>
#include <math.h>

int main()
{   
    double x;
    
    printf("введите x: ");
    scanf("%lf", &x);
    
    if (-1<x && x<=1)
    {	
	    double term=x; 
        double sum=0;
        double precision=1e-7;
        int n=1;
        
        while (fabs(term)>=precision)
        {
            term=(pow(-1, n-1))*(pow(x, n)/n);
            sum+=term;
            n++;
        }

        printf("Значение суммы ряда: %lf\n", sum);
        printf("Значение для проверки: %lf", log(1+x));
    }
    else
    {
        printf("неверные данные для входа в программу!");
    }
    
    return 0;
}