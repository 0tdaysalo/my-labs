//4.3
#include <stdio.h> 
#include <stdlib.h> 
 
int main() 
{ 
    // объявление 
    int N = 3, K = 2; 
    int matrix_B[K][N]; 
     
    // заполнение 
    for(int y=0; y<K; y++) 
    {    
        for(int x=0; x<N; x++) 
        { 
            printf("введите значение [%d][%d]: ", y, x); 
            scanf("%d", &matrix_B[y][x]) ;    
        }   
    } 
    
    printf("\n"); 
    printf("ваша матрица: \n"); 
    
    // вывод/проверка 
    for(int y=0; y<K; y++) 
    {    
        for(int x=0; x<N; x++) 
        { 
            printf("%d|", matrix_B[y][x]); 
        }  
        printf("\n"); 
    }     
    printf("\n"); 
    
    //выполнение нужного условия  
    //в массиве сменить знак максиамального(по модулю элемента на противоположный) 
    for(int y=0; y<K; y++) 
    {    
        int max_element=0; 
        for(int x=0; x<N; x++) 
        { 
            if(max_element<abs(matrix_B[y][x])) 
            { 
                max_element=abs(matrix_B[y][x]);    
            } 
        } 
        for(int x=0; x<N; x++) 
        { 
            if(max_element==abs(matrix_B[y][x])) 
            { 
                matrix_B[y][x]*=-1;    
            } 
        } 
    } 
     
    //конечный вывод
    printf("\n"); 
    printf("матрица после изменений по условию: \n"); 
    for(int y=0; y<K; y++) 
    {    
        for(int x=0; x<N; x++) 
        { 
            printf("%d|", matrix_B[y][x]); 
        }  
        printf("\n"); 
    } 
 
    return 0; 
}