#include <stdio.h>
void main()
{
	int  iA[10];				//定义10个int类型存储单元的数组iA
	int  i;

	for(i=0;i<10;i++)
	   iA[i] = i;				
	for(i=9;i>=0;i--)           //反序输出数组中的10个数
	   printf("%d  ",iA[i]); 
}
