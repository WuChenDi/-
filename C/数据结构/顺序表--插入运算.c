#include <stdio.h>
#define MAXLEN 100            /*MAXLENҪ����ʵ�����Ա�ĳ���*/
typedef int elementtype;           /*������Ҫ��elementtypeҲ���Զ���Ϊ�����κ�����*/
typedef struct                    /*�������Ա�*/
{
    elementtype s[MAXLEN];     /*�������Ա���Ԫ�أ�MAXLENΪ���Ա���������*/
    int len;                     /*�������Ա�ı�*/
}SqList;

int insertsqlist(int i,elementtype x,SqList *sql)
{                              /*��˳���(*sql)�ĵ�i��Ԫ��֮ǰ����һ����Ԫ��x*/
    int j;
    if((i<1)||(i>sql->len))          /*iֵ�Ƿ�������ֵΪ0*/
       return(0);
    else
    {
	     for(j=sql->len;j>=i;j--)
	        sql->s[j+1]=sql->s[j];   /*����ƶ����ݣ��ڳ�Ҫ����Ŀ�λ*/
	     sql->s[j+1]=x;            /*��������λ��Ϊj+1������Ԫ�ز��뵽
s[j+1]λ��*/
	     (sql->len)++;             /*����1*/
	     return(1);                /*����ɹ�������ֵΪ1*/
    }
}

main()                           /*������*/
{
    int b=3,c,k;
    elementtype d=9;
    SqList a={0,1,2,3,4,5,6,7,8};     /*�����Ա��Ԫ�س�ֵ��Ϊ��ǰ������
��һ�£�a.s[0]���ò���*/
    a.len=8;                      /*�����Ա���ֵ*/
    for(k=1;k<=a.len;k++)
    {
	     printf("%3d",a.s[k]);         /*�������ǰ���*/
    }
    printf("\n");
    c=insertsqlist(b,d,&a);           /*���ò��뺯��*/
    if(c==0)
        printf("error");
    else
    {
	    for(k=1;k<=a.len;k++)
	       printf("%3d",a.s[k]);        /*����������*/
    }
    printf("\n");
}
