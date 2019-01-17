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
	printf("请输入第%d个学生的信息，依次输入学号，姓名，三个成绩，各数据之间用，隔开\n",i);
	{
		scanf("%1d,%s,%f,%f,%f",&stu[i].number,&stu[i].name,&stu[i].score[0],stu[i].score[1],stu[i].score[2]);
		stu[i].score[3]=stu[i].score[0]+stu[i].score[1]+stu[i].score[2];
		if(max<stu[i].score[3])
		max=stu[i].score[3],max_i=i;
	}
	printf("总分最高分的学号是:%1d,姓名是：%s,总分是:%f\n",stu[max_i].number,stu[max_i].name,stu[max_i].score[3]);
}
