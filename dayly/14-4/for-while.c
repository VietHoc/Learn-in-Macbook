#include <stdio.h>
int main() {
   for (int i = 0; i < 10; i++)
    {
        printf("%d : %d  |", &i, i);
    }
    printf("\n");
    int j = 0;
    while (j < 10) {
        printf("%d : %d  |" , &j, j);
        j++;
    }
   return 0;
}