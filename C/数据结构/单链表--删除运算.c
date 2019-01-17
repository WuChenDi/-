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
    scanf("%d",&n);                    /*���뵥�����������*/
    if(n>0)                            /*��n<=0������������ͷ���Ŀձ�*/
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
    return(head);                     /*���ر�ͷָ��head*/
}

void delete(NODE *head,int x)          /*ɾ�������еĸ���Ԫ��x*/
{
   NODE *p,*q;
   q=head;
   p=q->next;
   while((p!=NULL)&&(p->data!=x))   /*����Ҫɾ����Ԫ��*/
   {
       q=p;
       p=p->next;
   }
   if(p==NULL)
       printf("%d not found.\n",x);     /*x���δ�ҵ�*/
   else
   {
       q->next=p->next;             /*����xֱ�Ӻ�̽��*/
   }
}

main()                              /*������*/
{
   int x;
   NODE *a,*b;
   a=create();
   printf("Input x :");
   scanf("%5d",&x);
   delete(a,x);
   b=a;
   b=b->next;
   printf("Output the list:");
   while(b!=NULL)
   {
       printf("%5d",b->data);      /*���ɾ��x��ĵ�������*/
       b=b->next;
   }
}
