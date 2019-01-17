#include <stdio.h>
#include <stdlib.h>
 
#define MAXN 100//��Ʒ�����������
 
int w[MAXN],V[MAXN];
int C;//�������
int n;//��Ʒ����
int d[MAXN][MAXN];
int jMax;
 
int min(int,int);
//����֮�����Сֵ
int max(int,int);
//����֮������ֵ
void print_ans(int d[][MAXN],int,int);
//�������ŽⲢ���
 
int main()
{
    int i,j;
    printf("������Ʒ������n(1-100):\n");
    scanf("%d",&n);
    printf("����ÿ�������������\n");
    for(i=1; i<=n; i++)
    {
        scanf("%d",&w[i]);
    }
    printf("����ÿ������ļ�ֵ��\n");
    for(i=1; i<=n; i++)
    {
        scanf("%d",&V[i]);
    }
    printf("���뱳��������C��\n");
    scanf("%d",&C);
	  
    jMax=min(C,w[n]-1);
    for(j=0; j<=jMax; j++)
        d[n][j]=0;
    for(j=w[n]; j<=C; j++)
        d[n][j]=V[n];
 
    for(i=n-1; i>1; i--)
    {
        jMax=min(C,w[i]-1);
        for(j=0; j<=jMax; j++)
            d[i][j]=d[i+1][j];
        for(j=w[i]; j<=C; j++)
            d[i][j]=max(d[i+1][j],d[i+1][j-w[i]]+V[i]);
    }
    d[1][C]=d[2][C];
    if(C>=w[i])
        d[1][C]=max(d[1][C],d[2][C-w[i]]+V[1]);
  
    
 
    printf("�������ɣ�%d\n",d[1][C]);
    return 0;
}
 
int min(int x,int y)
{
    if(x>y)
        return y;
    else
        return x;
}
 
int max(int x,int y)
{
    if(x<y)
        return y;
    else
        return x;
}

