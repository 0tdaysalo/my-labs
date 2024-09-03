//2.6
#include <stdio.h>

int main()
{   
    int n;
    unsigned long long int p=1;
    //от 0 до 18446744073709551615==2**64-1

    printf("введите n: ");
    scanf("%d", &n);
    
    int copy_n=n;
    
    printf("%d!=", copy_n);

    while(n>0)
    {
        p*=n;
        n--;
    }
    printf("%lld", p);

    return 0;
}