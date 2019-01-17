#include<stdio.h>
void main()
{
	char a='A';
	int b=20;
	printf("%d,%d\n",(a=a+1,a+b,b),sizeof(a+'a'-'A'));
}
