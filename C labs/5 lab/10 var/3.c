//5.3
#include<stdio.h>
#include<math.h>

double integral(double a, double b, double(*function)(double) )  
{
    unsigned N=35;
    double sum=0;
    double lenght=fabs(b-a)/N;
    
    for(double i=a; i<=b; i+=lenght)
    {
        sum+=function(i);                
    }
    
    return sum*lenght;
}

double function_1(double x)
{   
    return sin(pow(x, 3));
}

double function_2(double x)
{   
    return 1/(1-x);
}
 
int main() 
{   
    printf("значение интеграла 1-ой функции: %lf\n", integral(-3, 1.5, function_1));  
    printf("значение интеграла 2-ой функции: %lf", integral(-3.5, 0, function_2));
    
    return 0;
}