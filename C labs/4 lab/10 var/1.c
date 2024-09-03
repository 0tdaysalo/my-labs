//4.1
#include <stdio.h>
#include <stdlib.h>

int main()
{
    unsigned int array1 [10];
    
    printf("заполните массив:\n");

    for(int x ; x<=9 ; x++ )
    {   
        printf("введите %d элемент массива: ", x);
        scanf("%d", &array1[x]);
    }   
    
    int min_diff=9999;
    int min_index;
    
    for(int x=1 ; x<9 ; x++ )
    {
        int sum_left=0;
        int sum_right=0;
        

        for(int m=x-1; m>=0; m--)
        {
          sum_left+=array1[m];
        }
        
        for(int k=x+1; k<=9; k++)
        {
          sum_right+=array1[k];
        }
        
        int diff=abs(sum_right-sum_left);
        
        if (diff<min_diff)
        {
            min_diff=diff;
            min_index=x;
        }
    }

    printf("%d", min_index);

    return 0;
}
