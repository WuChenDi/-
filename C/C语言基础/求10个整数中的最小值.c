#include<stdio.h>
void main()
{
	int  a[10]={0,1,2,3,4,5,6,7,8,9};
    int i,min=a[0];
	for(i=1;i<10;i++)
	{
		if(a[i]<min)min=a[i];
	}
    printf("×îÐ¡Öµ=%d\n",min);
}
