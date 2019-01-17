/*用一维数组计算并输出Fibonacci数列的前20项。
Fibonacci数列，按如下递归定义：
	F(1)=1;
	F(2)=1
    F(n)=F(n-1)+F(n-2)  n>2
*/
#include <stdio.h>
void main()
{
	int F[21],i;
   	F[1]=1;
	F[2]=1;

	for(i=3;i<21;i++)
	   F[i]=F[i-1]+F[i-2];
	for(i=1;i<21;i++)
	   printf("%5d",F[i]);
	   	
}
