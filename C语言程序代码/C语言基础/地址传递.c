#include<stdio.h>
void swap(int *x,int *y)
{
	int temp;
	temp=*x;*x=*y;*y=temp;
 } 
 void main()
 {
 	int a,b;
 	a=4,b=6;
 	swap(&a,&b);
 	printf("a=%d,b=%d\n",a,b);
 }
