#include<stdio.h>
#include<malloc.h>
typedef struct DuLNode 
{  
   int data;  
   struct DuLNode *prior;
   struct DuLNode *next;  
}DuLNode;  

DuLNode * InitList()  
{  
   DuLNode *head,*p,*q;  
   int a;  
   printf("����һ������\n");  
   head=(DuLNode *)malloc(sizeof(DuLNode));  
   head->next=NULL;                                   
   head->prior=NULL;  
   p=head;                                              
   scanf("%d",&a);  
while(a<=0)  
{  
   printf("�����������������,����������\n");  
   scanf("%d",&a);  
}  
while(a>0)  
{  
   q=(DuLNode *)malloc(sizeof(DuLNode));  
   //q->next=NULL;  
   q->data=a;  
   q->prior=p;                                     
   p->next=q;  
   p=p->next;  
   //scanf("%d",&a);   
}  
return head;  
}  
void insert(DuLNode *p,DuLNode *q)
{
	q->prior=p;
	q->next=p->next;
	(p->next)->prior=q;
	p->next=q;
}
void delete (DuLNode *p)
{
	(p->prior)->next=p->next;
	(p->next)->prior=p->prior;
}
main()
{
	struct DuLNode *a;
	a=InitList();
	printf("����б�");
	a=a->next;
	while(a!=NULL)
	{
		printf ("%d",a->data );
		a=a->next ; 
	}
}
