/* ��1��n�Ľ׳���� */
#include <stdio.h>
 
int main(void) {
    int i, j;
    int n = 0;
    int sum = 0;
    int product;
    printf("������n:");
    scanf("%d", &n);
    /* ���ѭ�����׳���� */
    for (i = 1; i <= n; ++i) { /* ʹ��i��Ϊ���ѭ�������� */
        /* �ڲ�ѭ������i�Ľ׳� */
        for (j = 1, product = 1; j <= i; ++j) { /* ʹ��j��Ϊ�ڲ�ѭ�������� */
            product *= j; /* productΪ1��i�Ļ� */
        }
        sum += product; /* sumΪ�׳˵ĺ� */
    }
    printf("sum=%d\n", sum); /* �����͵Ľ�� */
    return 0;
}

