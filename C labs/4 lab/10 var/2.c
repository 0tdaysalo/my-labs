//4.2
#include <stdio.h>
#include <stdlib.h>

int main()
{   
    unsigned int count_elements_array;
    
    printf("введите количество элементов в массиве: ");
    scanf("%u", &count_elements_array);
    
    int prev_len=count_elements_array;
    
    int* array1=calloc(count_elements_array, sizeof(int));
    
    for(int x=0; x<count_elements_array; x++)
    {   
        printf("введите %d элемент массива: ", x);
        scanf("%d",  &array1[x]);    
    }
    
    for(int x=0; x<count_elements_array; x++)
    {
        if(array1[x]<0)
        {   
            for (int y=x; y<count_elements_array-1; y++)
            {
                int temp=array1[y+1];
                array1[y+1]=array1[y];
                array1[y]=temp;
            }
            count_elements_array--;
            array1=realloc(array1, count_elements_array);
            break;    
        }
    }
    
    // if (count_elements_array==prev_len)
    // {
    // printf("массив некорректен!");
    // return 0;
    // }
    
    for(int x; x<count_elements_array; x++)
    {
        printf("%d\n",  array1[x]);    
    }
    
    return 0;
}