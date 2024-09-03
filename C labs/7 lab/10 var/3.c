//7.3
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void createBinFile(void)
{
    srand(time(NULL));
    printf("Запись рандомных цифр: ");
    FILE *fptr = fopen("3.bin", "wb");
    for (int i = 0; i < 5; i++)
    {
        int s = rand() % 100 - 50;
        printf("%d ", s);
        fwrite(&s, sizeof(int), 1, fptr);
    }
    printf("\n");
    fflush(fptr);
    fclose(fptr);
}

int *readBinFile(FILE *file, int *arrayLength)
{
    int *array = calloc(1, sizeof(int));
    int n = 0;
    int current = 0;
    while (fread(&current, sizeof(int), 1, file) >= 1)
    {
        ++n;
        array = realloc(array, sizeof(int) * n);
        array[n - 1] = current;
    }
    *arrayLength = n;
    return array;
}

void writeBinFile(FILE *file, int *array, int arrayLength)
{
    for (int i = 0; i < arrayLength; i++)
    {
        fwrite(&array[i], sizeof(int), 1, file);
    }
    fflush(file);
}

int main()
{         
    //войнушка с бинарным файлом 3d
    int length=0;
    createBinFile();
    char filename1[] = "3.bin";
    FILE* file = fopen(filename1, "rb");
    int *array = readBinFile(file, &length);

    //логика
    //обработка 1-ой части
    int find_first_positive = 0, find_second_positive = 0, count=0, check_first=0, check_second=0;
    for (int x=0; x<length; x++)
    {   
        count++;
        if (array[x]>0)
        {
            find_first_positive=array[x];
            check_first=x;
            break;
        }

    }
    //обработка 2-ой части
    for (int x=length-1; x!=-1; x--)
    {   
        count++;
        if (array[x]>0)
        {
            find_second_positive=array[x];
            check_second=x;
            break;
        }    
    }    
    //логика для записи 1-ой части
    //printf("\n_1_ = %d, _2_ = %d, count = %d\n",   find_first_positive, find_second_positive, count);
    int array_new[count], x = 0;
    while(x!=check_first+1)
    {
        array_new[x]=array[x];
        x++;
    }
    //логика для записи 2-ой части
    for(int w=check_second; w!=length; w++)
    {
        array_new[x]=array[w];
        x++;
    }
    //вывод
    for(int q=0; q<count; q++)
    {
        printf("%d ", array_new[q]);

    }
    //конец логики
    FILE* file2 = fopen("3out.bin", "wb");
    writeBinFile(file2, array_new, count);
    fclose(file2);
    return 0;
}