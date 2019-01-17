/*���������Ա�A��B������ѭ������洢�ṹ����������ͷָ��ֱ�Ϊhead1��head2����B�������ӵ�A����ĺ��棬�ϲ���һ������*/ 
#include<stdio.h>
#include<malloc.h>
typedef struct node                    /*������Ĵ洢�ṹ*/
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

NODE *connect(NODE *head1,NODE *head2)
{ /*��ѭ������A��B�ϲ���һ��ѭ������head1��head2�ֱ�Ϊ����ѭ�������ͷָ��*/
    NODE *p,*q;
    p=head1->next;
    while(p->next!=head1)                   /*��head1�����һ�����*/
        p=p->next; 
    q=head2->next;
    while(q->next!=head2)                   /*��head2�����һ�����*/
        q=q->next;
    p->next=head2->next;                    /*A,B��������*/
    q->next=head1;
    free(head2);                            /*�ͷ�B���ͷ���*/ 
    return(head1);
}

main()                       /*������*/
{
    NODE *a,*b,*c,*d;
    a=create_circular();        /*����create_circular()��������������ѭ������A*/
    b=create_circular();        /*����create_circular()��������������ѭ������B*/
    c=connect(a,b);           /*����connect����,��ѭ������A��B�ϲ���һ��ѭ������*/
    d=c; 
    printf("\nOutput the list: ");  /*������Ӻ����������*/  
    while(d->next!=c) 
    {
        d=d->next;
        printf("%3d",d->data);
    }
}
