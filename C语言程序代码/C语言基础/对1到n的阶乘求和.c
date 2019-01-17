/* 对1到n的阶乘求和 */
#include <stdio.h>
 
int main(void) {
    int i, j;
    int n = 0;
    int sum = 0;
    int product;
    printf("请输入n:");
    scanf("%d", &n);
    /* 外层循环：阶乘求和 */
    for (i = 1; i <= n; ++i) { /* 使用i作为外层循环变量名 */
        /* 内层循环：求i的阶乘 */
        for (j = 1, product = 1; j <= i; ++j) { /* 使用j作为内层循环变量名 */
            product *= j; /* product为1到i的积 */
        }
        sum += product; /* sum为阶乘的和 */
    }
    printf("sum=%d\n", sum); /* 输出求和的结果 */
    return 0;
}

