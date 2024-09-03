//5.2
#include<stdio.h>

int fiend_min_array(int array_A[10])
{   
    int min_elements_array=2100000000;
    for(int x=0; x<10; x++)
    {
        if(array_A[x]>0 && array_A[x]<min_elements_array)
        {
            min_elements_array=array_A[x];
        }
    }
    return min_elements_array;
}

int fiend_min_matrix(int matrix_B[2][3])
{   
    int min_elements_matrix=2100000000;
    for(int y=0; y<2; y++) 
    {    
        for(int x=0; x<3; x++) 
        { 
            if(matrix_B[y][x]>0 && matrix_B[y][x]<min_elements_matrix)
            {
                min_elements_matrix=matrix_B[y][x];
            }  
        }   
    }
    return min_elements_matrix;    
}

int main()
{   
    
    //объявление и заполнение
    int array_A [10], matrix_B[2][3] ;
    printf("заполните массив:\n");
    
    for(int x ; x<10 ; x++ )
    {   
        printf("введите %d элемент массива: ", x);
        scanf("%d", &array_A[x]);
    }
    printf("\nзаполните матрицу:\n");
    for(int y=0; y<2; y++) 
    {    
        for(int x=0; x<3; x++) 
        { 
            printf("введите значение [%d][%d]: ", y, x); 
            scanf("%d", &matrix_B[y][x]) ;    
        }   
    }
    
    //вывод/проверка
    printf("\n");
    printf("ваш массив: \n");
    for(int x ; x<10 ; x++ )
    {   
        printf("%d ", array_A[x]);
    }
    printf("\n");
    printf("\n");
    printf("ваша матрица: \n");
    for(int y=0; y<2; y++) 
    {   
        printf("|");
        for(int x=0; x<3; x++) 
        { 
            printf("%d|", matrix_B[y][x]); 
        }  
        printf("\n"); 
    }
    
    //вывод/проверка выполнения функций
    int min_array_A=fiend_min_array(array_A);
    int min_matrix_B=fiend_min_matrix(matrix_B);
    printf("\nминимальное значение массива: %d\n", min_array_A);
    printf("минимальное значение матрицы: %d", min_matrix_B);
    printf("\n");
    int copy_min_array=0;
    int copy_min_matrix=0;
    
    
    //выполнение условия
    for(int x ; x<10 ; x++ )
    {   
        if(array_A[x]==min_array_A)
        {
            copy_min_array=min_array_A;
        }
    }
    for(int y=0; y<2; y++) 
    {   
        for(int x=0; x<3; x++) 
        { 
            if(matrix_B[y][x]==min_matrix_B)
            {
                copy_min_matrix=min_matrix_B;
            }    
        }  
    }
    for(int x ; x<10 ; x++ )
    {   
        if(array_A[x]==min_array_A)
        {
            array_A[x]=copy_min_matrix;
        }
    }
    for(int y=0; y<2; y++) 
    {   
        for(int x=0; x<3; x++) 
        { 
            if(matrix_B[y][x]==min_matrix_B)
            {
                matrix_B[y][x]=min_array_A;
            }    
        }  
    }
    
    //конечный вывод
    printf("\n");
    printf("ваш изменённый массив: \n");
    for(int x ; x<10 ; x++ )
    {   
        printf("%d ", array_A[x]);
    }
    printf("\n");
    printf("\n");
    printf("ваша изменённая матрица: \n");
    for(int y=0; y<2; y++) 
    {   
        printf("|");
        for(int x=0; x<3; x++) 
        { 
            printf("%d|", matrix_B[y][x]); 
        }  
        printf("\n"); 
    }
    
    return 0;
}