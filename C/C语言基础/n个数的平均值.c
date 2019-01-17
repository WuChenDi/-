#include<stdio.h>
void main()
{
    int i=1,n,s=0;
    float ave,m;
    printf ( "请输入一个整数n：\n" );
    scanf ( "%d",&n );
    while ( i<=n )
    {
        printf ( "请输入第%d个数字！\n",i+0 );
        scanf ( "%f",&m );
        s=s+m;
        i++;
        ave=s/n;
    }
    printf ( "%d个数的平均值是：%f\n",n,ave );
}

