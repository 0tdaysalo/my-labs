//7.1
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<locale.h>
#define MAX_WORD_SIZE 100 // Максимальный размер слова
#define BUFFER_SIZE 256 // Размер буфера чтения файла
/*
    Функция разделения строки по раделителям

        Параметры:
         - char** string - входная строка
         - char* delimer - строка(массив) разделителей
         - int* Wcount - указатель на переменную в которую будет записана длинна получившегося массива

*/
char** splitByDelimer(char* string, char* delimer, int* Wcount){
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

/*
    Функция чтения текстового файла в строку

        Параметры:
         - FILE* file - указатель на файл

*/
char* readString(FILE* file){
    char* str = malloc(sizeof(char) * BUFFER_SIZE);
    int count = 0;
    char buffer[BUFFER_SIZE];
    while (fgets(buffer, BUFFER_SIZE, file) != NULL){
        count += BUFFER_SIZE;
        str = realloc(str, count * sizeof(char));
        strcat(str, buffer);
    }
    // for(int count; fgets(buffer, BUFFER_SIZE, file) != NULL; count += BUFFER_SIZE )
    // {
    //     str = realloc(str, count * sizeof(char));
    //     strcat(str, buffer);    
    // }
    return str;
}

/*
    Функция очистки строки от '\r\n' 

        Параметры:
         - char* str - строка типо, чё ещё надо то

*/
void clearString(char* str){
    while(strchr(str, '\n') != NULL){
        char *p = strchr(str, '\n');
        *p = ' ';
        p = strchr(str, '\r');
        *p = ' ';
    }
}

/*
    Функция вывода матрицы фраз

        Параметры:
         - char*** phrasesMatrix - сама матрица фраз
         - int* phrasesLengthMetadata - матрица метаданных длинны строк матрицы фраз
         - int phrasesCount - количество столбцов матрицы фраз
*/
void printPhrases(char*** phrasesMatrix, int* phrasesLengthMetadata, int phrasesCount){
    printf("\n");
    for (int i = 0; i < phrasesCount; i++){
        printf(" | ");
        for (int j = 0; j < phrasesLengthMetadata[i]; j++){
            printf("%s ", phrasesMatrix[i][j]);
            if (j < phrasesLengthMetadata[i] - 1) printf("|");
        }
        printf("|\n");
    }
    printf("\n");
}


int find_glass(char point)
{   
    char array_glas[9]={'у', 'е', 'ы', 'а', 'о', 'э', 'я','и','ю'};
    //char array_glas[6]={'a', 'e', 'i', 'u', 'y', 'o'}; для англ
    for(int i=0; i<9; i++)
    {
        if(array_glas[i]==point)
        {
            return i;
        }
    }
    return -1;   
}
//для англ вариации нужно все 9 заменить на 6
//если нужно переделать задание на создачу нового файла и запись в него txt то нужно расскомент 114 118 182 183 189
int main(int argc, char *argv[])
{      
    // Здесь будет лежать длинна разделёного массива
    int c = 0;
    // Имя файла
    char filename1[] = "71.txt";
    // char filename2[]="71new.txt";
    setlocale(LC_ALL, "en_US.UTF-8");
    // Открываем файл
    FILE* file = fopen(filename1, "r");
    // FILE* file2 = fopen(filename2, "w+b");
    // Помещение данных
    // Читаем всё в одну строку
    char* str = readString(file);
    // Чистим строку
    clearString(str);
    // Делим строку по точкам и записываем длинну в с
    char** phrases = splitByDelimer(str, ".", &c);
    // Создаём матрицу фраз
    char*** phrasesMatrix = malloc(sizeof(char**) * c);
    // Создаём массив с данными по длинне каждой строки матрицы (для рабочего вывода)
    int* phrasesLengthMetadata = malloc(sizeof(int) * c);
    // Проходимся по фразам и делим их, но теперь по пробелам
    for (int i = 0; i < c; i++){
        int n;
        phrasesMatrix[i] = splitByDelimer(phrases[i], " ", &n);
        phrasesLengthMetadata[i] = n; 
    }
    fclose(file);
    //printPhrases(phrasesMatrix, phrasesLengthMetadata, c);

    // for(int i=0; i<c; i++)
    // {

    //     for(int j=0; j<phrasesLengthMetadata[i] ; j++)    
    //         {

    //             //printf("%s ",phrasesMatrix[i][j]);
    //         }
    //             printf("\n");
    // }
    // printf("\n");

    file = fopen(filename1, "w+");
    for(int i=0; i<c; i++)
    {
        for(int j=0; j<phrasesLengthMetadata[i]; j++)
        {   
            int array_glas_check[9]={0, 0, 0, 0, 0, 0, 0, 0, 0};
            //int array_glas_check[6]={0, 0, 0, 0, 0, 0}; для англ
            for(int k=0; k<strlen(phrasesMatrix[i][j]) ; k++)
            {   
                if(find_glass(phrasesMatrix[i][j][k])!=-1)
                {
                    array_glas_check[find_glass(phrasesMatrix[i][j][k])]++;
                }
            }
            int sum=0;
            int check=0;
            for(int q=0; q<9; q++)
            {
                sum+=array_glas_check[q];
            }
            for(int a=0; a<9; a++)
            {
                if(array_glas_check[a]>1)
                {   
                    check=1;    
                }
            }
            if(sum>=4 && !check)
            {   
                fprintf(file, phrasesMatrix[i][j] );
                fprintf(file, " ");
                // fprintf(file2, phrasesMatrix[i][j] );
                // fprintf(file2, " ");
                //printf("%s ",phrasesMatrix[i][j]);
            }
        }
    }
    fclose(file);
    //fclose(file2);
    return 0;
}