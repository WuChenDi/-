#include<stdio.h>
#include<malloc.h>
typedef struct node                       /*������Ĵ洢�ṹ*/
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

void print(NODE *head)          /*������������Ԫ�أ���3����Ҳ�õ��˺���*/
{
    NODE *p;
    p=head->next;
    printf("Output the list:");
    while(p!=NULL)
    {
	      printf("%3d",p->data);
        p=p->next;
    }
}

main()
{
   NODE *a;
   a=create();
   print(a);
}
