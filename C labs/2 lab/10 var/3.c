//2.3
#include <stdio.h>

int main()
{
    while(1)
    {
        int number, number_copy, digit_1, digit_2, digit_3, three_digit_check[3];
        
        printf("Введите трехзначное число: ");
        scanf("%d", &number);
        
        //нужно сохранить куда то ориг числа чтобы потом использовать его в дальнейших исч
        number_copy=number;
        
        
        // Получаем цифры числа и записываем их в массив(для того чтобы определить трёзначное число или нет)
        three_digit_check[0]=number/100;;
        three_digit_check[1]=(number/10)%10;
        three_digit_check[2]=number%10;
        
        
        //проверка на трёзначность, если нет, то алг стопает
        if (three_digit_check[0]==0 || three_digit_check[1]==0 || three_digit_check[0]==0)
        {
            printf("это не трехзначное число!");
        }
        else
        {
            // Получаем цифры числа
            digit_1 = number % 10;
            number /= 10;
            digit_2 = number % 10;
            number /= 10;
            digit_3 = number % 10;
            //условие на одинаковые числа(1усл)
            if (digit_1==digit_2 && digit_2==digit_3)
            {
                printf("%d\n", number_copy);
            }
            else
            {
                //условие на два одинаковых числа(3усл)
                if (digit_1==digit_2 || digit_2==digit_3)
                {
                    printf("%d", digit_1);
                    printf("%d", digit_2);  
                    printf("%d\n", digit_3);  
                }
                else
                {   
                    //условие на разность чисел(2усл)
                    if (digit_1 < digit_2 && digit_1 < digit_3)
                    {
                        digit_1 = 0;
                    }
                    else if(digit_2 < digit_1 && digit_2 < digit_3)
                    {
                        digit_2 = 0;
                    }
                    else
                    {
                        digit_3 = 0;
                    }
                    
                    printf("%d", digit_3);
                    printf("%d", digit_2);  
                    printf("%d\n", digit_1);  
                }
            }
        }
    }

    return 0;
}