#include <stdio.h>
#define MAXLEN 100                /*MAXLENҪ����ʵ�����Ա�ĳ���*/
typedef int elementtype;         /*������Ҫ��elementtypeҲ���Զ���Ϊ�����κ�����*/
typedef struct                  /*�������Ա�*/
{
    elementtype s[MAXLEN];   /*�������Ա���Ԫ�أ�MAXLENΪ���Ա���������*/
    int len;                   /*�������Ա�ı�*/
}SqList;

int delsqlist(int i,SqList *sql)     /*ɾ��˳���(*sql)�ĵ�i��Ԫ��*/
{
    int j;
    if((i<1)||(i>sql->len))       /*iֵ�Ƿ�������ֵΪ0*/
         return(0);
    else
    {
	      for(j=i+1;j<=sql->len;j++)
             sql->s[j-1]=sql->s[j];    /*��ǰ�ƶ����ݣ�����ǰһ����*/
         (sql->len)--;               /*���ȼ�1*/
         return(1);                 /*ɾ���ɹ�������ֵΪ1*/
    }
}

main()                            /*������*/
{
    int b=4,c,k;
    SqList a={0,1,2,3,4,5,6,7,8};     /*�����Ա��Ԫ�س�ֵ��Ϊ��ǰ��������һ�£�a.s[0]���ò���*/
    a.len=8;                      /*�����Ա���ֵ*/
    for(k=1;k<=a.len;k++)
    {
	printf("%3d",a.s[k]);         /*���ɾ��ǰ���*/
    }
    printf("\n");
    c=delsqlist(b,&a);              /*����ɾ������*/
    if(c==0)
        printf("error\n");
    else
    {
	for(k=1;k<=a.len;k++)
	        printf("%3d",a.s[k]);     /*���ɾ������*/
    }
    printf("\n");
}
