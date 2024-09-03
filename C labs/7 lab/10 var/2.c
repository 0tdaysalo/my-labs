//7.2
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAX_WORD_SIZE 100 
#define BUFFER_SIZE 256 

char** splitByDelimer(char* string, char* delimer, int* Wcount)
{
    char** words = malloc(sizeof(char*) * MAX_WORD_SIZE);
    int count = 0;
    char* token = strtok(string, delimer);
    while(token != NULL){
        words = realloc(words, (count + 1)*sizeof(char*));
        words[count] = malloc(strlen(token)*sizeof(char));
        strcpy(words[count], token);
        token = strtok(NULL, delimer);
        count++;
    }
    *Wcount = count;
    return words;
}

char* readString(FILE* file)
{

    char* str = malloc(sizeof(char) * BUFFER_SIZE);
    int count = 0;
    char buffer[BUFFER_SIZE];
    while (fgets(buffer, BUFFER_SIZE, file) != NULL){
        count += BUFFER_SIZE;
        str = realloc(str, count * sizeof(char));
        strcat(str, buffer);
    }
    return str;
}

void printfromtxt(char*** phrasesMatrix, int* phrasesLengthMetadata, int phrasesCount)
{
    printf("\n");
    for (int i = 0; i < phrasesCount; i++)
    {
        printf("|");
        for (int j = 0; j < phrasesLengthMetadata[i]; j++)
        {
            printf("%s", phrasesMatrix[i][j]);
            if (j < phrasesLengthMetadata[i] - 1)
            {
                printf("|");
            }
        
        }
        printf("|\n");
    }
    printf("\n");
}

double** matrix_hihi_haha_and_vivod(char*** phrasesMatrix, int* phrasesLengthMetadata, int phrasesCount)
{   
    double** matrix_A=calloc(phrasesCount, sizeof(double*));
    for(int k=0; k<phrasesCount; k++)
    {
        matrix_A[k]=calloc(phrasesLengthMetadata[0], sizeof(double*));   
    }


    for (int i = 0; i < phrasesCount; i++)
    {
        for (int j = 0; j < phrasesLengthMetadata[i]; j++)
        {
            matrix_A[i][j]=strtod(phrasesMatrix[i][j], NULL);
        }
    }
    for(int y=0; y<phrasesCount; y++) 
    {    
        printf("|");
        for(int x=0; x<phrasesLengthMetadata[0]; x++) 
        { 
            printf("%lf|", matrix_A[y][x]); 
        }  
        printf("\n"); 
    }
    return (double**)matrix_A;
}


int main(int argc, char *argv[])
{      
    
    int c = 0;
    char filename1[] = "matrix.txt";

    FILE* file = fopen(filename1, "r");

    char* str = readString(file);
    char** phrases = splitByDelimer(str, "\r\n", &c);
    char*** phrasesMatrix = malloc(sizeof(char**) * c);
    int* phrasesLengthMetadata = malloc(sizeof(int) * c);
    
    for (int i = 0; i < c; i++)
    {
        int n;
        phrasesMatrix[i] = splitByDelimer(phrases[i], " ", &n);
        phrasesLengthMetadata[i] = n; 
    }

    fclose(file);
    double** matrix_A = matrix_hihi_haha_and_vivod(phrasesMatrix, phrasesLengthMetadata, c);

    printf("\n");
    double matrix_A_new[c][phrasesLengthMetadata[0]+3];
    for(int y=0; y<c; y++) 
    {   
        double sum=0, min=999999999, max=-9999999;    
        for(int x=0; x<phrasesLengthMetadata[0]; x++) 
        { 
            sum+=matrix_A[y][x];

            if(matrix_A[y][x]<min)
            {
                min=matrix_A[y][x];
            }

            if(matrix_A[y][x]>max)
            {
                max=matrix_A[y][x];
            }
             matrix_A_new[y][x]=matrix_A[y][x];
                    
        }
        matrix_A_new[y][phrasesLengthMetadata[0]]=sum;
        matrix_A_new[y][phrasesLengthMetadata[0]+1]=min;
        matrix_A_new[y][phrasesLengthMetadata[0]+2]=max;
        printf("sum %lf, min %lf, max %lf\n", sum, min, max);        
    }

    for(int y=0; y<c; y++) 
    {   
        printf("|");  
        for(int x=0; x<phrasesLengthMetadata[0]+3; x++) 
        { 
            printf("%lf|", matrix_A_new[y][x]);     
        }
        printf("\n");    
    }

    file = fopen(filename1, "w+");
    for(int y=0; y<c; y++) 
        {    
            for(int x=0; x<phrasesLengthMetadata[0]+3; x++) 
            { 
                fprintf(file, "%lf ", matrix_A_new[y][x]);     
            }
            fprintf(file, "\n");    
        }


    fclose(file);
    // 1 2 3 
    // 4 5 6
    // 7 8 9

    // 1 2 3 6 3 1
    // 4 5 6 15 6 4 
    // 7 8 9 24 9 7


    return 0;
}