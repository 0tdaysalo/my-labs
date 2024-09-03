//2.1
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int s, t;
    double f;
    
    printf("введите значение s: ");
    scanf("%d", &s);
    
    printf("введите значение t: ");
    scanf("%d", &t);
    
    // if (s>4)
    // {
    //     f=3*t-1;
    // }
    // else if (s<=4 & t!=0)
    // {
    //     f=sqrt(abs(t-s));
    // }
    // else
    // {
    //     f=s+2; 
    // }
    
    f = (s>4)?  (3*t-1): (s<=4 & t!=0) ? sqrt(abs(t-s)): s+2;
    printf("%f", f);
    
    return 0;
}
