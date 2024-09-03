//7.4
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

char* trains[3]={"EXPRESS", "FAST", "PASSANGERS"};
char* points[8]={"MOSCOW", "SAMARA", "UFA", "OREL", "KAZAN", "KIYV", "SPB", "UST_KUIGA"};

enum TRAIN_TYPE
{
    EXPRESS, FAST, PASSANGERS
};

enum CITIES
{
    MOSCOW, SAMARA, UFA, OREL, KAZAN, KIYV, SPB, UST_KUIGA 
};

struct Time_S
{
    int hours;
    int minuts;
};

typedef struct Time_S Time;

// S_S
struct Schedule_Entry
{
    enum TRAIN_TYPE train_type;
    enum CITIES start_point;
    enum CITIES end_point;
    Time start_time;
    Time end_time;
};

typedef struct Schedule_Entry Schedule;

void beautiful_print_for_raul_gri(Schedule* array, int N)
{
    printf("\n");
    for(int x=0; x<200; x++)
    {   
        printf("%d) %s ПОЕЗД %s - %s отправляется в %.2d:%.2d и прибудет в %.2d:%.2d \n", x,
            trains[array[x].train_type],
            points[array[x].start_point],
            points[array[x].end_point], 
            array[x].start_time.hours,
            array[x].start_time.minuts,
            array[x].end_time.hours,
            array[x].end_time.minuts);
    }
    printf("\n");
}

Schedule* create_data_base()
{
    FILE* file = fopen("Schedule.bin", "wb");
    Schedule* array = malloc(sizeof(Schedule) * 200);

    srand(time(0));
    for(int x=0; x<200; x++)
    {
        array[x] = (Schedule){rand()%3, rand()%8, rand()%8, (Time){rand()%24, rand()%60},  (Time){rand()%24, rand()%60} };
    }

    beautiful_print_for_raul_gri(array, 200);    

    fwrite(array, sizeof(Schedule), 200, file);
    fflush(file);
    fclose(file);
    return array;
}

int main()
{       
    Schedule* array=create_data_base();

    int hours, minuts, hours_2, minuts_2;
    //1-ая часть задания 
    printf("введите желаемое время ОТ: ");
    scanf("%d:%d", &hours, &minuts);
    if(minuts>60 || hours>24)
    {
        return 0;
    }

    printf("введите желаемое время ДО: ");
    scanf("%d:%d", &hours_2, &minuts_2);
    if(minuts_2>60 || hours_2>24)
    {
        return 0;
    }

    printf("\nпоезда отправляющиеся c %.2d:%.2d до %.2d:%.2d до Москвы:", hours, minuts, hours_2, minuts_2 );
    printf("\n");
    printf("\n");

    for(int x=0; x<200; x++)
    {   
        if(array[x].start_time.hours*60+array[x].start_time.minuts>hours*60+minuts
         && array[x].start_time.hours*60+array[x].start_time.minuts<hours_2*60+minuts_2
         && array[x].end_point==0)
        {
            printf("%s ПОЕЗД %s - %s отправляется в %.2d:%.2d и прибудет в %.2d:%.2d \n",
            trains[array[x].train_type],
            points[array[x].start_point],
            points[array[x].end_point], 
            array[x].start_time.hours,
            array[x].start_time.minuts,
            array[x].end_time.hours,
            array[x].end_time.minuts);
        }
    }

    //2-ая часть поиск минимального времени и типа поезда для ласт условия 
    int q=0, min_find=9999999, type_train_main;
    printf("\n\n\n\n\nсамый быстрый поезд в типе который вы сейчас введёте \n\n");

    printf("введите тип поезда который вас интересует:\n 0 - EXPRESS\n 1 - FAST \n 2 - PASSANGERS \n");
    scanf("%d", &type_train_main);

    for(int x=0; x<200; x++)
    {   
        int check_minutes = abs(array[x].end_time.hours*60+array[x].end_time.minuts - array[x].start_time.hours*60+array[x].start_time.minuts);

        if(check_minutes < min_find && array[x].train_type==type_train_main && array[x].end_point==0)
        {
            min_find=check_minutes;
            q=x;
        }
    }

    //вывод ласт условия
    printf("\n%s ПОЕЗД %s - %s отправляется в %.2d:%.2d и прибудет в %.2d:%.2d \n",
        trains[array[q].train_type],
        points[array[q].start_point],
        points[array[q].end_point], 
        array[q].start_time.hours,
        array[q].start_time.minuts,
        array[q].end_time.hours,
        array[q].end_time.minuts);

    return 0;
}