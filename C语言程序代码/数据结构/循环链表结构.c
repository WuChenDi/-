/*��һ���ڵ��ǰ������������*/ 
#include<stdio.h>
#include<malloc.h>
typedef struct node                     /*������Ĵ洢�ṹ*/
{
    int data;
    struct node *next;
}NODE;

NODE *create_circular()                 /*�˺������ú���뷽ʽ��������ѭ������������һ��ָ�������ͷ��ָ��*/
{
    NODE *head,*q,*p;                 /*����ָ�����*/
    int a,n;
    head=(NODE*)malloc(sizeof(NODE));  /*�����µĴ洢�ռ䣬������ͷ���*/
    q=head;
    printf("\nInput number of the list: ");
    scanf("%d",&n);                          /*���뵥�����������*/
    head->data=n;                            /*��ͷ��㸳ֵn�������н�����*/
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
    q->next=head;
    return(head);                           /*���ر�ͷָ��head*/
}

NODE *prior(NODE *p)
{
   NODE *q;
   q=p->next;
   while(q->next!=p)
       q=q->next;
   return(q);
}

main()                     /*������*/
{
   NODE *a,*c,*p;
   int i,j;
   a=create_circular();    /*��������ѭ������*/
   printf("Input j:");      /*��������ѭ�������еĽ����ţ���ͷ������Ϊ0*/
   scanf("%d",&j);       /*j��ȡֵΪ��0�����еĽ�����*/
   p=a;
   for(i=0;i<j;i++)
       p=p->next;       /*�����ȷ��һ��p���*/
   c=prior(p);
   printf("prior of %d is : %d",p->data,c->data);
}
