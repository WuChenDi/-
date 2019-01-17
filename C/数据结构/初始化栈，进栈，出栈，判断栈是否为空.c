#include<stdio.h>
#include<malloc.h>
#define MAXLEN 10
typedef int elementtype;
typedef struct 
{
	elementtype element[MAXLEN];
	int top;
 } SqStack;
 
 SqStack InitStack_sq()
 {
 	SqStack s;
 	s.top=-1;
 	return(s);
 }
 
 int Push_sq(SqStack *s,elementtype x)
 {
 	if(s->top=MAXLEN-1)
 	return(0);
 	s->top++;
 	s->element[s->top]=x;
 	return(1);
 }
 
 int Pop_sq(SqStack *s,elementtype *x)
 {
 	if(s->top==-1)
 	return(0);
 	*x=s->element[s->top];
 	s->top--;
 	return(1);
 }
 
 int Empty_sq(SqStack *s)
 {
 	return(s->top==-1);
 }
 
 void print(SqStack s)
 {
 	int i;
 	if(s.top !=-1)
 	{
 		printf("输出元素的堆栈:");
 		for(i=0;i<=s.top ;i++)
 		printf("%d",s.element [i]);
	 }
	 else
	 printf("栈是空的!!!");
	 printf("\n");
 }
 
 main()
 {
 	SqStack stack;
 	int i;
 	elementtype y;
 	elementtype z;
 	stack=InitStack_sq();
 	/*if(Empty_sq(&stack)!=0)
 	printf("\n栈是空的!");
 	else
 	printf("\n栈并不是空的!");*/
 	printf("\n把9个元素堆栈:");
 	for(i=1;i<=9;i++)
 	{
 		scanf("%d",&y);
 		Push_sq(&stack,y);
	 }
	 print(stack);
	 printf("出栈4个元素:");
	 for(i=6;i<=9;i++)
	 {
	 	Pop_sq(&stack,&z);
	 	printf("%d",z);
	 }
	 printf("\n");
	 print(stack);
	 if(Empty_sq(&stack)!=0)
	 printf("栈是空的!");
	 else
	 printf("栈并不是空的!");
 }
