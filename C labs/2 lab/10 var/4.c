//2.4
#include <stdio.h>
#include <math.h>

int main()
{
    int N;
    float multiplication, a, k=1;
    
    printf("введите N: ");
    scanf("%d", &N);
    
    for (int i=0; i!=N; i++)
    {
        multiplication = 1+(1/pow(i+1, 2));
        k*=multiplication;
    }

    printf("произведение = %f\n", k);
    
    return 0;
}