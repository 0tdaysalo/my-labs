//2.5
#include <stdio.h>

int main()
{
    int a, b;
    
    printf("введите a: ");
    scanf("%d", &a);
    
    printf("введите b: ");
    scanf("%d", &b);
    
    if (a<10 || b<10)
    {
        printf("a или b меньше 10! ");
    }
    else 
    {   
        int check=1;
        
        printf("Числа, кратные a и b и меньшие a*b(%d):\n", a*b);
        while(check<a*b)
        {
            if (check%a==0 && check%b==0)
            {
                printf("%d\n", check);
            }
            check++;
        }
    }    
    
    return 0;
}