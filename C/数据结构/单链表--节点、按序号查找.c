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
    while(ch!='?')                      /*"ch"Ϊ�Ƿ����½��ı�־����"ch"Ϊ"?"���������*/
    {
	    scanf("%d",&a);                /*������Ԫ��*/
	    p=(NODE*)malloc(sizeof(NODE));
        p->data=a;
        q->next=p;
        q=p;
        ch=getchar();                    /*�����������ı�־*/
    }
    q->next=NULL;
    return(head);                        /*���ر�ͷָ��head*/
}

NODE *find(NODE *head,int i)           /*����֪�����в��Ҹ�����ֵi*/
{
    int j=1;
    NODE *p;
    p=head->next;
    while((p!=NULL)&&(j<i))           /*δ����β��δ�ҵ���������*/
    {
        p=p->next;                    /*ָ����һ��Ԫ��*/
        j++;
    }    
    return(p);
}

main()                             /*������*/
{
   int i;
   NODE *a,*b;
   a=create();
   printf("Input i: ");
   scanf("%d",&i);
   b=find(a,i);
   if(b!=NULL)
   {  
       printf("find:");
       printf("%5d",b->data);        /*���ҳɹ�*/
   }
   else
      printf("error");               /*����ʧ��*/
}
