#include<stdio.h>
void main()
{
    int i=1,n,s=0;
    float ave,m;
    printf ( "������һ������n��\n" );
    scanf ( "%d",&n );
    while ( i<=n )
    {
        printf ( "�������%d�����֣�\n",i+0 );
        scanf ( "%f",&m );
        s=s+m;
        i++;
        ave=s/n;
    }
    printf ( "%d������ƽ��ֵ�ǣ�%f\n",n,ave );
}

