//2.9
#include <stdio.h>
#include <math.h>
#include <stdbool.h>

int main()
{
    int a, b;
    
    printf("введите число a: ");
    scanf("%d", &a);
    
    printf("введите число b: ");
    scanf("%d", &b);
    
    if (a<b)
    {  
        for(unsigned int p=a+1; p<b; p++)
        {
            bool t_for_p=false;

            for(unsigned int x=2; x<p; x++)
                {
                    if(p%x==0)
                    {
                        t_for_p=true; 
                    }
            
                }

            if(t_for_p==false)
            {
                printf("%d\n", p);
            }
        }   
    }
    else
    {
        printf("неверные данные для входа в программу");
    }
    
    return 0;
}
