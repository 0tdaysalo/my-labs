//2.7
#include <stdio.h>
#include <math.h>

int main()
{   
    int n=0, y;
    double x, sum,  k=1;
    
    printf("введите x: ");
    scanf("%lf", &x);
    
    if (1<=x && x<=2)
    {  
        //нам нужен цикл который будет считать сумму и прибавлять выражение к конечной сумме пока член ряда не будет < 0.0001
        while (k>=1e-4)
        {   
            //цикл для факториала
            int fact=1;
            while (y > 0)
            {
                fact *= y;
                y -= 1;
            }
            
            k=pow(x, n)/fact;
            sum+=k;
            n++;
            y=n;
        }
        
        printf("Значение суммы ряда: %.4lf\n", sum);
        printf("Значение для проверки: %.4lf\n", exp(x));
    }
    else
    {
        printf("x<1 или x>2");        
    }
    
    //подробнее некоторые штуки расписаны в 2.8

    return 0;
}