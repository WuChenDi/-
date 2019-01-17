#include<stdio.h>
#include<malloc.h>
typedef struct node                 /*������ջ���*/
{
    int data;                      /*��������������Ϊ��*/
    struct node*next;               /*ָ������,�����һ������ַ*/
}NODE;
NODE *crea_linkstack()             /*������ջ*/
{
    NODE *top,*p;                /*����ջ��ָ��top*/
    int a,n;
    top=NULL;
    printf("\nInput number of push linkstack : ");
    scanf("%d",&n);                        /*����ջ��Ԫ�ظ���*/
    if(n>0)                               /*��n<=0,������ջ*/
    {
	      printf("Input %d elements of push linkstack : ",n);
        while(n>0)
        {
	          scanf("%d",&a);               /*������Ԫ��*/
            p=(NODE*)malloc(sizeof(NODE));
            p->data=a;
            p->next=top;
            top=p;
            n--;
        }
    }
    return(top);                     /*����ջ��ָ��*/
}    
NODE *pushstack(NODE *top,int x)    /*��ջ����*/
{
    NODE *p;
    p=(NODE*)malloc(sizeof(NODE));
    p->data=x;                     /*��Ҫ���������x�洢�����p����������*/ 
    p->next=top;                   /*��p��������ͷ��,����ջ����*/ 
    top=p;
    return(top);
}
void print(NODE *top)              /*�����ջ�и�Ԫ��*/
{
    NODE *p;
    p=top;
    if(p!=NULL)
    {
        printf("Output the linkstack : ");
        while(p!=NULL)
        {
      	     printf("%3d",p->data);
            p=p->next;
        }
    }
    else
        printf("\nThe stack is empty!!!");
}
main()                      /*������*/
{
    int y;                  /*����ջ��Ԫ��*/
    NODE *a; 
    a=crea_linkstack();       /*������ջ*/
    print(a);                                    /*���������ջ*/
    printf("\nPush a element to linkstack : ");
    scanf("%d",&y);                             /*�����ջԪ��y*/
    a=pushstack(a,y);                             /*y��ջ*/
    print(a);                                     /*���������ջ*/
}
