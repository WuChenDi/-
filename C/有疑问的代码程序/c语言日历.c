#include<stdio.h>
#include<malloc.h>
int main ( void )
{
    char *weeks[7]={"������","����һ","���ڶ�","������","������","������","������"};
    char *ss[7]={"��","һ","��","��","��","��","��"};
 
    int year;
    int month;
    int day;
    int week;
    int monthday;
    int allday;
 
    allday=0;
 
    int i;
    int k;
    int h;
 
    h=0;
 
    printf ( "�����ѯʱ�ڣ�" );
 
    scanf ( "%d %d %d",&year,&month,&day );
 
 
    for ( i=1900; i<=allday;i++) 
{
    allday=allday+365;
    if ( ( i%4==0 ) && ( i%100!=0 ) || ( i%400==0 ) )
        {
            allday++;
        }
 
    }
 
    switch ( month )
{
case 1:
    monthday=31;
    break;
case 2:
    allday+=31;
    monthday=28;
    break;
case 3:
    allday+=31+28;
    monthday=31;
    break;
case 4:
    allday+=31+28+31;
    monthday=30;
    break;
case 5:
    allday+=31+28+31+30;
    monthday=31;
    break;
case 6:
    allday+=31+28+31+30+31;
    monthday=30;
    break;
case 7:
    allday+=31+28+31+30+31+30;
    monthday=31;
    break;
case 8:
    allday+=31+28+31+30+31+30+31;
    monthday=31;
    break;
case 9:
    allday+=31+28+31+30+31+30+31+31;
    monthday=30;
    break;
case 10:
    allday+=31+28+31+30+31+30+31+31+30;
    monthday=31;
    break;
case 11:
    allday+=31+28+31+30+31+30+31+31+30+31;
    monthday=30;
    break;
case 12:
    allday+=31+28+31+30+31+30+31+31+30+31+30;
    monthday=31;
    break;
 
}
if ( ( year%4==0 ) && ( year%100!=0 ) || ( year%400==0 ) )
{
    if ( month==2 ) monthday=29;
        if ( month>2 ) allday++;
    }
 
    int echo= ( allday+1 ) %7; //ÿ��1�ţ������ڼ�
 
    allday+=day;
 
    week=allday%7;  //��ѯ���ڣ������ڼ�
 
    printf ( "\n��1900��1��1��: %d��  ",allday-1 );
 
    if ( ( year%4==0 ) && ( year%100!=0 ) || ( year%400==0 ) )
    printf ( "����  \n" );
    else
        printf ( "ƽ��  \n" );
 
        printf ( "\n%d�� %d�� %d ��  %s\n\n",year,month,day,weeks[week] );
 
 
        for ( i=0; i<7; i++ )
        {
            printf ( "%s\t",ss[i] );
 
            }
 
    printf ( "\n\n" );
 
    for ( k=0; k
{
    printf ( "  \t" );
        h++;
    }
 
    int d;
 
    for ( d=1; d<=monthday; d++ )
{
    printf ( "%d\t",d );
        h++;
        if ( h>6 )
        {
            h=0;
            printf ( "\n" );
        }
 
    }
 
 
    return 0;
}

