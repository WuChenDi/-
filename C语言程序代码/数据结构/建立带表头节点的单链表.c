#include<stdio.h>
#include<malloc.h>
typedef struct node
{
    int data;
    struct node *next;
}NODE;

NODE *create()                        /*�˺������ú���뷽ʽ����������������һ��ָ�������ͷ��ָ��*/
{
    NODE *head,*q,*p;                 /*����ָ�����*/
    char ch;
    int a;
    head=(NODE*)malloc(sizeof(NODE));  /*�����µĴ洢�ռ䣬������ͷ���*/
    q=head;
    ch='*';
    printf("\nInput the list :");
    while(ch!='?')                        /*"ch"Ϊ�Ƿ����½��ı�־����"ch"Ϊ"?"���������*/
    {
	      scanf("%d",&a);                  /*������Ԫ��*/
	      p=(NODE*)malloc(sizeof(NODE));
        p->data=a;
        q->next=p;
        q=p;
        ch=getchar();                     /*�����������ı�־*/
    }
    q->next=NULL;
    return(head);                         /*���ر�ͷָ��head*/
}

main()
{
    int i;
    NODE *a;
    a=create();
    printf("output the list:");
    a=a->next;
    while(a!=NULL)
    {
	     printf("%d ",a->data);             /*��������Ԫ��*/
        a=a->next;
    }
}
