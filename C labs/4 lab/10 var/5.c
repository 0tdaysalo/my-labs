//4.5
#include <stdio.h>
#include <stdlib.h> 
#include <time.h> 

int main() 
{ 
    srand(time(NULL));
    // объявление 
    int korobka[2][6][5][6];
    int count_broken_egg=0;
    //int korobka[w][z][y][x]
    //2 стопки
    //6 лотков
    //1 лоток 5х6
     
    // заполнение 
    for(int w=0; w<2; w++) 
    {    
        for(int z=0; z<6; z++) 
        {
            for(int y=0; y<5; y++) 
            {
                for(int x=0; x<6; x++) 
                {
                    korobka[w][z][y][x]=rand()%2;
                }
            }
        }   
    } 
    
    printf("яйцо цело - 1\n");
    printf("яйцо разбито - 0\n\n\n\n\n");
    // вывод/проверка 
    
    for(int w=0; w<2; w++) 
    {
        printf("в стопке %d: \n", w+1);
        for(int z=0; z<6; z++) 
        {
            printf("\tв лотке %d: \n", z+1);
            for(int y=0; y<5; y++) 
            {   
                
                printf("\t\t|");
                for(int x=0; x<6; x++) 
                {   
                    printf("%d|", korobka[w][z][y][x]);
                }
                printf("\n");
                
            }
            printf("\n");
        }
        printf("\n");
    }
    
    //проверука яиц на целостность
    for(int w=0; w<2; w++) 
    {    
        for(int z=0; z<6; z++) 
        {
            for(int y=0; y<5; y++) 
            {
                for(int x=0; x<6; x++) 
                {
                    if(korobka[w][z][y][x]==0)
                    {
                        printf("в стопке %d, в лотке %d, в ряду %d, %d яйцо разбито\n", w+1, z+1, y+1, x+1 );
                        count_broken_egg++;                       
                    }
                    
                }
            }
        }   
    }
    
    printf("\nпроцент разбитых яиц %.2f%%", (count_broken_egg/360.)*100);
    
    return 0; 
}
