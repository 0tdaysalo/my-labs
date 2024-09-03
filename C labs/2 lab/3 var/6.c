//2.6
#include <stdio.h>

int main()
{   
    // unsigned int буквально с англ беззнаковый int то есть у него столько же значений сколько и у обычного int но они все+
    //т.к по заданию нужно натуральное число, то берём именно его
    unsigned int num;
    
    printf("Введите натуральное число: ");
    scanf("%u", &num);
    
    unsigned int first_digit=num;
    
    //берем последнюю цифру числа остатком от деления на 10 
    unsigned int last_digit=num%10;
    
    //цикл для поиска первой цифры любого числа
    //идём по циклу пока число не будет 1-го порядка и так мы получим 1-ую цифру числа
    while (first_digit>=10)
    {
        first_digit/=10;
    }
    
    //условия сравнения и дальнейший вывод по результамам сравнения (по заданию)
    if (first_digit>last_digit)
    {
        printf("Цифра старшего разряда %u больше цифры младшего разряда %u\n", first_digit, last_digit);
    }
    
    else if (first_digit<last_digit)
    {
        printf("Цифра старшего разряда %u меньше цифры младшего разряда %u\n", first_digit, last_digit);
    }
    
    else
    {
        printf("Цифра старшего разряда %u равна цифре младшего разряда %u\n", first_digit, last_digit);
    }

    return 0;
}
