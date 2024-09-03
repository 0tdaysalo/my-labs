//9.1
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#include <sys/time.h>

// Функция для выделения памяти под матрицу заданного размера
double** allocateMatrix_for_double(int rows, int columns) {
    double** matrix_double = (double**)malloc(rows * sizeof(double*));
    for (int i = 0; i < rows; i++) {
        matrix_double[i] = (double*)malloc(columns * sizeof(double));
    }
    return matrix_double;
}

// Функция для освобождения памяти, выделенной под матрицу
void freeMatrix_for_double(double** matrix_double, int rows, int columns) {
    for (int i = 0; i < rows; i++) {
        free(matrix_double[i]);
    }
    free(matrix_double);
}

// Функция для вывода матрицы в консоль
void printMatrix_for_double(double** matrix_double, int rows, int columns) {
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            printf("%f ", matrix_double[i][j]);
        }
        printf("\n");
    }
}

// Функция для вычисления обратной матрицы методом Ершова
double** inverseMatrix_for_double(double** matrix_double, int size) {
    double** inverse = allocateMatrix_for_double(size, size);
    double temp;

    // Инициализация единичной матрицы
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            inverse[i][j] = (i == j) ? 1.0 : 0.0;
        }
    }

    // Прямой проход
    for (int k = 0; k < size; k++) {
        temp = matrix_double[k][k];
        for (int j = 0; j < size; j++) {
            matrix_double[k][j] /= temp;
            inverse[k][j] /= temp;
        }
        for (int i = k + 1; i < size; i++) {
            temp = matrix_double[i][k];
            for (int j = 0; j < size; j++) {
                matrix_double[i][j] -= matrix_double[k][j] * temp;
                inverse[i][j] -= inverse[k][j] * temp;
            }
        }
    }

    // Обратный проход
    for (int k = size - 1; k > 0; k--) {
        for (int i = k - 1; i >= 0; i--) {
            temp = matrix_double[i][k];
            for (int j = 0; j < size; j++) {
                matrix_double[i][j] -= matrix_double[k][j] * temp;
                inverse[i][j] -= inverse[k][j] * temp;
            }
        }
    }

    return inverse;
}

long long mtime()
{
  struct timeval t;

  gettimeofday(&t, NULL);
  long long mt = (long long)t.tv_sec * 1000 + t.tv_usec / 1000;
  return mt;
}






//end

float** allocateMatrix_for_float(int rows, int columns) {
    float** matrix_float = (float**)malloc(rows * sizeof(float*));
    for (int i = 0; i < rows; i++) {
        matrix_float[i] = (float*)malloc(columns * sizeof(float));
    }
    return matrix_float;
}

// Функция для освобождения памяти, выделенной под матрицу
void freeMatrix_for_float(float** matrix_float, int rows, int columns) {
    for (int i = 0; i < rows; i++) {
        free(matrix_float[i]);
    }
    free(matrix_float);
}

// Функция для вывода матрицы в консоль
void printMatrix_for_float(float** matrix_float, int rows, int columns) {
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            printf("%f ", matrix_float[i][j]);
        }
        printf("\n");
    }
}

// Функция для вычисления обратной матрицы методом Ершова
float** inverseMatrix_for_float(float** matrix_float, int size) {
    float** inverse = allocateMatrix_for_float(size, size);
    float temp;

    // Инициализация единичной матрицы
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            inverse[i][j] = (i == j) ? 1.0 : 0.0;
        }
    }

    // Прямой проход
    for (int k = 0; k < size; k++) {
        temp = matrix_float[k][k];
        for (int j = 0; j < size; j++) {
            matrix_float[k][j] /= temp;
            inverse[k][j] /= temp;
        }
        for (int i = k + 1; i < size; i++) {
            temp = matrix_float[i][k];
            for (int j = 0; j < size; j++) {
                matrix_float[i][j] -= matrix_float[k][j] * temp;
                inverse[i][j] -= inverse[k][j] * temp;
            }
        }
    }

    // Обратный проход
    for (int k = size - 1; k > 0; k--) {
        for (int i = k - 1; i >= 0; i--) {
            temp = matrix_float[i][k];
            for (int j = 0; j < size; j++) {
                matrix_float[i][j] -= matrix_float[k][j] * temp;
                inverse[i][j] -= inverse[k][j] * temp;
            }
        }
    }

    return inverse;
}

int main() {
    long long start_double, finish_double;
    long long duration_double;
    // Размер матрицы (можно изменить)
    start_double=mtime();
    int size = 1000;
    unsigned long long x;
    // while(x<30000000)
    // {
    //     x++;
    // }
    // Выделение памяти под матрицу и инициализация ее значениями
    double** matrix_double = allocateMatrix_for_double(size, size);
    for(int i=0; i<size; i++)
    {
        for(int j=0; j<size; j++)
        {   
            matrix_double[i][j]=rand()/100;
        }
    }
    // matrix_double[0][0] = 1; matrix_double[0][1] = 2; matrix_double[0][2] = 3;
    // matrix_double[1][0] = 4; matrix_double[1][1] = 5; matrix_double[1][2] = 6;
    // matrix_double[2][0] = 7; matrix_double[2][1] = 8; matrix_double[2][2] = 10;
    // matrix_double[2][3] = 11; matrix_double[2][4] = 12; matrix_double[3][0] = 13;
    // matrix_double[3][1] = 14; matrix_double[3][2] = 15; matrix_double[3][3] = 16;
    // printf("Исходная матрица double:\n");
    // printMatrix_for_double(matrix_double, size, size);
    // Вычисление обратной матрицы
    double** inverse_double = inverseMatrix_for_double(matrix_double, size);

    // Вывод исходной и обратной матрицы


    // printf("\nОбратная матрица double:\n");
    // printMatrix_for_double(inverse_double, size, size);

    // Освобождение памяти
    freeMatrix_for_double(matrix_double, size, size);
    freeMatrix_for_double(inverse_double, size, size);

    finish_double=mtime();
    duration_double = (long long)(finish_double - start_double);
    printf("\nTIME FOR RAUL GIL DOUBLE: %lld", duration_double);






    printf("\n\n\n");
    //value 100000000
    //raul gill last laba






    long long start_float, finish_float;
    long long duration_float;
    // Размер матрицы (можно изменить)
    start_float=mtime();
    int size1 = 1000;
    unsigned long long y;
    // while(y<30000000)
    // {
    //     y++;
    // }
    // Выделение памяти под матрицу и инициализация ее значениями
    float** matrix_float = allocateMatrix_for_float(size1, size1);
    for(int i=0; i<size1; i++)
    {
        for(int j=0; j<size1; j++)
        {   
            matrix_float[i][j]=rand()/100;
        }
    }
    // matrix_float[0][0] = 1; matrix_float[0][1] = 2; matrix_float[0][2] = 3;
    // matrix_float[1][0] = 4; matrix_float[1][1] = 5; matrix_float[1][2] = 6;
    // matrix_float[2][0] = 7; matrix_float[2][1] = 8; matrix_float[2][2] = 10;

    // Вычисление обратной матрицы
    float** inverse_float = inverseMatrix_for_float(matrix_float, size1);

    // Вывод исходной и обратной матрицы
    // printf("Исходная матрица float:\n");
    // printMatrix_for_float(matrix_float, size1, size1);

    // printf("\nОбратная матрица float:\n");
    // printMatrix_for_float(inverse_float, size1, size1);

    // Освобождение памяти
    freeMatrix_for_float(matrix_float, size1, size1);
    freeMatrix_for_float(inverse_float, size1, size1);

    finish_float=mtime();
    duration_float = (long long)(finish_float - start_float);
    printf("\nTIME FOR RAUL GIL FLOAT: %lld", duration_float);

    return 0;
}