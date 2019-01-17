#include <stdio.h>
#include<malloc.h>
void hanoi(int n,char one,char two,char three);
void move(char x,char y);

void hanoi(int n,char one,char two,char three)
{
	if(n==1)
	{
		move(one ,three);
	 } 
	 else
	 {
	 	hanoi(n-1,one,three,two);
	 	move(one,three);
	 	hanoi(n-1,two,one,three);
	 }
 } 
 void move(char x,char y)
 {
 	printf("%c--%c\n",x,y);
 }
 void main()
{
	int num;
	printf("please input a integer number:");
	scanf("%d",&num);
	hanoi(num,'A','B','C');
	return 0;
}
