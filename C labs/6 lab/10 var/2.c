//6.2
#include<stdio.h>
#include<string.h>
#include<stdlib.h>

int main()
{   
    char str1[11];
    char str2[11];
    
    printf("Введите первое число: ");
    scanf("%s", str1);
    
    printf("Введите второе число: ");
    scanf("%s", str2);
    
    int result = strtol(str1, NULL, 10) > strtol(str2,NULL, 10);
    
    if (result==1)
    {
        printf("%s больше, чем %s\n", str1, str2);
    }
    else if (result == 0)
    {
        printf("%s больше, чем %s\n", str2, str1);
    }
    else if( str1==str2)
    {
        printf("%s равно %s\n", str1, str2);
    }

    return 0;
}