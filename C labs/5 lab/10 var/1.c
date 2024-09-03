//5.1
#include<stdio.h>
#include<stdlib.h>

int max(unsigned int count_elements_array, int array1[])
{
    int max_element=0;
    int max_id; 
        for(int x=0; x<count_elements_array; x++) 
        { 
            if(max_element<array1[x]) 
            { 
                max_element=array1[x];
                max_id=x;    
            }
             
        }
    return max_id;        
}

int min(unsigned int count_elements_array, int array1[])
{
    int min_element=101;
    int min_id; 
        for(int x=0; x<count_elements_array; x++) 
        { 
            if(min_element>array1[x]) 
            { 
                min_element=array1[x];
                min_id=x;    
            }
             
        }
    return min_id;
}

void print_Array(int k, int array1[])
{   
    for(int x=0; x<k; x++)
    {
        printf("%d ", array1[x]);
    }
    printf("\n");
}

float avg(int k, int array1[])
{   
    float sum=0, count_even_num=0;
    for(int x=0; x<k; x++)
    {
        if(array1[x]%2==0)
        {
            count_even_num++;
            sum+=array1[x];
        }
    }
    return sum/count_even_num;
}

int main()
{   
    unsigned int count_elements_array;
    
    printf("введите количество элементов в массиве: ");
    scanf("%u", &count_elements_array);

    int array1[count_elements_array];

    //запись
    for(int x=0 ; x<count_elements_array ; x++ )
    {   
        //array1[x]=rand()%100;
        
        printf("введите %d элемент массива: ", x);
        scanf("%d",  &array1[x]);   
    }
    int max_id=max(count_elements_array, array1);
    int min_id=min(count_elements_array, array1);

    //проверка/вывод
    printf("\n");
    print_Array(count_elements_array, array1);   
    printf("\nмаксимальный индекс:%d", max_id);
    printf("\nминимальный индекс:%d\n", min_id);

    int first_id, last_id;
    if(max_id>min_id)
    {
        first_id=min_id;
        last_id=max_id;
    }
    else
    {
        first_id=max_id;
        last_id=min_id;
    }

    int array2[first_id+1], array3[last_id-first_id-1], array4[count_elements_array-last_id-1];
    for(int i=0; i<=first_id; i++)
    {
        array2[i]=array1[i];
    }
    for(int i=first_id+1, j=0; i<last_id ; i++, j++)
    {
        array3[j]=array1[i];
        
    }
    for(int i=last_id, j=0; i<=count_elements_array; i++,  j++)
    {
        array4[j]=array1[i];
    }
    printf("массив 2:\n");
    print_Array(first_id+1, array2);

    printf("массив 3:\n");
    print_Array(last_id-first_id-1, array3);

    printf("массив 4:\n");
    print_Array(count_elements_array-last_id, array4);
    
    
    printf("среднее для 1 части: %f\n", avg(first_id+1, array2));
    printf("среднее для 2 части: %f\n", avg(last_id-first_id-1, array3));
    printf("среднее для 3 части: %f", avg(count_elements_array-last_id, array4));

    return 0;
}