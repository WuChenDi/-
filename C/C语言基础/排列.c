#include<stdio.h>
#include<stdlib.h>
main()
{
	int a[10],i,k,j;
	for(i=0;i<10;i++)
	a[i]=rand()%100;
	printf("排序之前的数据");
	for(i=0;i<10;i++)
	printf("%d\n",a[i]);
	putchar('\n');
	for(i=0;i<9;i++)
	for(j=i+1;j<10;j++)
	if(a[i]>a[j])
	{
		k=a[i];a[i]=a[j];a[j]=k;
	}
		for(i=0;i<10;i++)
		printf("%d\n",a[i]);
		putchar('\n');
	
}
