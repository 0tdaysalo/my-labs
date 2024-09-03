//8.1
#include <stdio.h>
#include <stdlib.h>
#include <sys/time.h>
// Максимальное количество итераций
#define N 1000000

long long mtime()
{
    struct timeval t;

    gettimeofday(&t, NULL);
    long long mt = (long long)t.tv_sec * 1000 + t.tv_usec / 1000;
    return mt;
}

// Функция для сортировки методом сортировки вставками (линейной)
void linearInsertionSort(int arr[], int n)
{
    int i, key, j, hui = 0;
    for (i = 1; i < n; i++)
    {
        key = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
            hui += 1;
        }
        arr[j + 1] = key;
    }
    printf("%d итерации(ий) в линейной сортировке ", hui);
}
// N^2

// Функция для сортировки методом сортировки вставками (двоичной)
void binaryInsertionSort(int arr[], int n)
{
    int i, key, j, hui = 0;
    for (i = 1; i < n; i++)
    {
        key = arr[i];
        int left = 0;
        int right = i - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (key < arr[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
            hui += 1;
        }

        for (j = i - 1; j >= left; j--)
        {
            arr[j + 1] = arr[j];
            hui += 1;
        }

        arr[left] = key;
    }
    printf("%d итерации(ий) в бинарной сортировке ", hui);
}
// N^2

// Функция для сортировки методом сортировки вставками (центрированной)
void centeredInsertionSort(int arr[], int n)
{
    int i, j, k, temp, hui = 0;
    int left = 0, right = n - 1;
    for (i = left; i < right; i++)
    {
        temp = arr[i + 1];

        // Сортируем подмассивы в массивах от i до left и от right до i+1
        for (j = i; j >= left && arr[j] > temp; j--)
        {
            arr[j + 1] = arr[j];
            hui += 1;
        }
        arr[j + 1] = temp;

        // Сортируем подмассивы в массивах left...i-1 и i+2...right
        temp = arr[right - 1];
        for (j = right - 1; j > i && arr[j - 1] > temp; j--)
        {
            arr[j] = arr[j - 1];
            hui += 1;
        }
        arr[j] = temp;

        left++;
        right--;
    }
    printf("%d итерации(ий) в центрированной сортировке ", hui);
}
// N^2

int main()
{
    system("clear");
    long long s1,s2,s3,e1,e2,e3;
    
    int arr[] = {5, 2, 7, 1, 9};
    int arr2[] = {5, 2, 7, 1, 9};
    int arr3[] = {5, 2, 7, 1, 9};

    int n = sizeof(arr) / sizeof(arr[0]);
    s1 = mtime();
    printf("Исходный массив: ");
    for (int i = 0; i < n; i++)
    {
        printf("%d ", arr[i]);
    }
    printf("\n");
    int x; while(x<N) x++;
    linearInsertionSort(arr, n);

    printf("Массив после сортировки вставками (линейной): ");
    for (int i = 0; i < n; i++)
    {
        printf("%d ", arr[i]);
    }
    printf("\n");
    e1 = mtime();
    printf("Время выполнения: %lld\n", e1-s1); 
    s2 = mtime();
    binaryInsertionSort(arr2, n);

    int z; while(z<N) z++;
    printf("Массив после сортировки вставками (двоичной): ");
    for (int i = 0; i < n; i++)
    {
        printf("%d ", arr2[i]);
    }
    printf("\n");
    e2 = mtime();
    printf("Время выполнения: %lld\n", e2-s2); 
    s3 = mtime();
    centeredInsertionSort(arr3, n);

    printf("Массив после сортировки вставками (центрированной): ");
    for (int i = 0; i < n; i++)
    {
        printf("%d ", arr3[i]);
    }
    int y; while(y<N) y++;
    printf("\n");
    e3 = mtime();
    printf("Время выполнения: %lld\n", e3-s3); // Эхх...

    return 0;
}