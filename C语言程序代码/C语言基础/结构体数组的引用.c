#include<stdio.h>
#define N 3
struct student
{
	long number;
	char name[10];
	float score[N+1];
}
stu[N];
main()
{
	float max=0;
	int i,j,max_i=0;
	for(i=0;i<N;i++)
	printf("�������%d��ѧ������Ϣ����������ѧ�ţ������������ɼ���������֮���ã�����\n",i);
	{
		scanf("%1d,%s,%f,%f,%f",&stu[i].number,&stu[i].name,&stu[i].score[0],stu[i].score[1],stu[i].score[2]);
		stu[i].score[3]=stu[i].score[0]+stu[i].score[1]+stu[i].score[2];
		if(max<stu[i].score[3])
		max=stu[i].score[3],max_i=i;
	}
	printf("�ܷ���߷ֵ�ѧ����:%1d,�����ǣ�%s,�ܷ���:%f\n",stu[max_i].number,stu[max_i].name,stu[max_i].score[3]);
}
