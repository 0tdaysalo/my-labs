//4.4
#include <stdio.h>
#include <stdlib.h>

int main()
{
    //объявление столбцов и строк
    unsigned int Y, X;
    printf("введите количество столбцов: ");
    scanf("%u", &Y);
    
    
    printf("введите количество строк: ");
    scanf("%u", &X);
    
    
    int** array1=calloc(Y, sizeof(int*));
    
    for(int k=0; k<Y; k++)
    {
    array1[k]=calloc(X, sizeof(int));   
    }
    
    for(int y=0; y<Y; y++) 
    {    
        for(int x=0; x<X; x++) 
        { 
            printf("введите значение [%d][%d]: ", y, x); 
            scanf("%d", &array1[y][x]) ;    
        }   
    }
    
    printf("\n"); 
    printf("ваша матрица: \n"); 
    
    // вывод/проверка 
    for(int y=0; y<Y; y++) 
    {   
        printf("|");
        for(int x=0; x<X; x++) 
        { 
            printf("%d|", array1[y][x]); 
        }  
        printf("\n"); 
    }
    
    //организовать динамическую матрицу, используя динамическое выделение памяти
    //отсортировать элементы каждого столбца матрицы в порядке возрастания 
    //сортировка
        for(int y=0; y<Y; y++) 
    {    
        for(int i=1; i<X; i++) 
        {   
            for(int j=0; j<X-i; j++)
            {
                if(array1[y][j]>array1[y][j+1])
                {
                int test=array1[y][j];
                array1[y][j]=array1[y][j+1];
                array1[y][j+1]=test;
                }
            }
            // printf("%d|", array1[y][x]); 
        }  
        printf("\n"); 
    } 
    
    
    // конечный вывод
    printf("ваша отсортированная матрица: \n"); 
    for(int y=0; y<Y; y++) 
    {    
        printf("|");
        for(int x=0; x<X; x++) 
        { 
            printf("%d|", array1[y][x]); 
        }  
        printf("\n"); 
    }
    
    return 0;
}