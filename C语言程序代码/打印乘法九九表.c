#include <stdio.h>
int main() 
{
    int i, j; 
    printf("%6c |", '*'); /* 输出第一行 */
    for (i = 1; i <= 9; ++i) 
	{
        printf("%6d", i);
    } 
    printf("\n     --+----------------------"
            "---------------------------------\n");/* 输出分隔线 */    
    for (i = 1; i <= 9; ++i)  /* 输出表内容 */
	{       
        printf("%6d |", i); /* 输出一行积 */
        for (j = 1; j <= 9; ++j) 
		{
            printf("%6d", i * j);
        }
        printf("\n");
    } 
    return 0;
}

