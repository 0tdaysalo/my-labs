//6.1
#include<stdio.h>
#include<string.h>

int main()
{   
    char str1[99]="qwerty 123 234 345", str2[99]="qwerty 123 567 789", result[100];
    char* word1, word2; //массив указателей на указатели на чар
    
    word1=strtok(str1, " ");
    
    while (word1)
    {
        if (strstr(str2, word1))
        {
            strcat(result, word1); //добавляем слово в третью строку
            strcat(result, " "); //добавляем пробел между словами
        }
        
        word1 = strtok(NULL, " "); //долучаем следующее слово в первой строке
    }
    
    printf("Третья строка из слов, имеющихся в обеих строках: %s\n", result);
    
    return 0;
}
