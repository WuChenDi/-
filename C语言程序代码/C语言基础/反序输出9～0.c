#include <stdio.h>
void main()
{
	int  iA[10];				//����10��int���ʹ洢��Ԫ������iA
	int  i;

	for(i=0;i<10;i++)
	   iA[i] = i;				
	for(i=9;i>=0;i--)           //������������е�10����
	   printf("%d  ",iA[i]); 
}
