#include<stdio.h>
#include<malloc.h>
typedef struct node                      /*������Ĵ洢�ṹ*/
{
    int data;
    struct node *next;
}NODE;

NODE *create()                        /*�˺������ú���뷽ʽ����������������һ��ָ�������ͷ��ָ��*/
{
    NODE *head,*q,*p;                 /*����ָ�����*/
    int a,n;
    head=(NODE*)malloc(sizeof(NODE));  /*�����µĴ洢�ռ䣬������ͷ���*/
    q=head;
    printf("\nInput number of the list: ");
    scanf("%d",&n);                          /*���뵥�����������*/
    if(n>0)                                  /*��n<=0������������ͷ���Ŀձ�*/
    {
printf("Input the list :");
        while(n>0)
        {
	          scanf("%d",&a);                  /*������Ԫ��*/
            p=(NODE*)malloc(sizeof(NODE));
            p->data=a;
            q->next=p;
            q=p;
            n--;
        }
    }
    q->next=NULL;
    return(head);                           /*���ر�ͷָ��head*/
}

void insert(NODE *p,int x)             /*�������p���λ�ú�������Ԫ��x*/
{
    NODE *q;
    q=(NODE*)malloc(sizeof(NODE));  /*�����µĴ洢�ռ�*/
    q->data=x;
    q->next=p->next;                 /*ʵ��ͼ2.9(b)�Ģ�*/
    p->next=q;                      /*ʵ��ͼ2.9(b)�Ģڣ����½��q���ӵ�p���֮��*/
}

main()                  /*������*/
{
   int x,position;         /*xΪ�������Ԫ�أ�positionΪ����λ�õ����*/
   int i=0,j=0;
   NODE *c,*d;
   c=create();           /*������������*/
   d=c->next;
   while(d!=NULL)      /*ͳ�Ƶ��������н��������j��*/
   {
       d=d->next;
       j++;
   }
   d=c;
   do
   {
       printf("Input position (again):");
       scanf("%d",&position);         /*position��Ϊ0����ʾ��ͷ���*/
   }while((position>j)||position<0);     /*positionֵ��������������������������*/
   printf("Input x:");
   scanf("%d",&x);
   while(i!=position)                 /*��positionֵȷ�����ڵ��������е�λ��d*/
   {
       d=d->next;
       i++;
   }
   insert(d,x);
   printf("Output the list:");
   while(c->next!=NULL)            /*�������x��ĵ��������Ԫ��*/
   {
       c=c->next;
       printf("%5d",c->data);
   }
   printf("  ok");
}
