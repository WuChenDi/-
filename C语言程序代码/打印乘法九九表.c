#include <stdio.h>
int main() 
{
    int i, j; 
    printf("%6c |", '*'); /* �����һ�� */
    for (i = 1; i <= 9; ++i) 
	{
        printf("%6d", i);
    } 
    printf("\n     --+----------------------"
            "---------------------------------\n");/* ����ָ��� */    
    for (i = 1; i <= 9; ++i)  /* ��������� */
	{       
        printf("%6d |", i); /* ���һ�л� */
        for (j = 1; j <= 9; ++j) 
		{
            printf("%6d", i * j);
        }
        printf("\n");
    } 
    return 0;
}

