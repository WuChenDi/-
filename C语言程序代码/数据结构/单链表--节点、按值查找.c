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
    char ch;
    int a;
    head=(NODE*)malloc(sizeof(NODE));  /*�����µĴ洢�ռ䣬������ͷ���*/
    q=head;
    ch='*';
    printf("\nInput the list :");
    while(ch!='?')                          /*"ch"Ϊ�Ƿ����½��ı�־����"ch"Ϊ"?"���������*/
    {
	      scanf("%d",&a);                    /*������Ԫ��*/
	      p=(NODE*)malloc(sizeof(NODE));
        p->data=a;
        q->next=p;
        q=p;
        ch=getchar();                       /*�����������ı�־*/
    }
    q->next=NULL;
    return(head);                           /*���ر�ͷָ��head*/
}

NODE *locate(NODE *head,int x)            /*����֪�����в��Ҹ�����ֵx*/
{
    NODE *p;
    p=head->next;
    while((p!=NULL)&&(p->data!=x))       /*δ����β��δ�ҵ���������*/
        p=p->next;                       /*ָ����һ��Ԫ��*/
    return(p);
}

main()                                  /*������*/
{
   int y;
   NODE *a,*b;
   a=create();
   printf("Input x: ");
   scanf("%d",&y);
   b=locate(a,y);
   if(b!=NULL)
   {   
printf("find:");
       printf("%5d",b->data);              /*���ҳɹ�*/
   }
   else
      printf("error");                     /*����ʧ��*/
} 
