#include <stdio.h>
#include <stdlib.h>
 
#define MAXN 100//物品种类最大数量
 
int w[MAXN],V[MAXN];
int C;//最大容量
int n;//物品种类
int d[MAXN][MAXN];
int jMax;
 
int min(int,int);
//两数之间的最小值
int max(int,int);
//两数之间的最大值
void print_ans(int d[][MAXN],int,int);
//构造最优解并输出
 
int main()
{
    int i,j;
    printf("输入物品种类数n(1-100):\n");
    scanf("%d",&n);
    printf("输入每个种类的重量：\n");
    for(i=1; i<=n; i++)
    {
        scanf("%d",&w[i]);
    }
    printf("输入每个种类的价值：\n");
    for(i=1; i<=n; i++)
    {
        scanf("%d",&V[i]);
    }
    printf("输入背包的容量C：\n");
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
  
    
 
    printf("最大可容纳：%d\n",d[1][C]);
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

