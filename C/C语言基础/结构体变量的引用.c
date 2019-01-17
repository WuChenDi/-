#include<stdio.h>
struct student
{
	long no;
	char name[16];
	float math;
	float yw;
	float eng;
	float sum;
 } ;
 void main()
 {
 	struct student stu1,stu2;
 	printf("请输入学生1的信息（学号，姓名，数学，语文，英语）:\n");
 	scanf("%1d%s%f%f%f",&stu1.no,stu1.name,&stu1.math,&stu1.yw,&stu1.eng);
 	stu1.sum=stu1.math+stu1.yw,stu1.eng;
 	printf("请输入学生2的信息（学号，姓名，数学，语文，英语）:\n");
 	scanf("%1d%s%f%f%f",&stu2.no,stu2.name,&stu2.math,&stu2.yw,&stu2.eng);
 	stu2.sum=stu2.math+stu2.yw,stu2.eng;
 	printf("总分较高的学生信息是:\n");
 	if(stu1.sum>stu2.sum)
 	printf("%-61d,%s,%-5.1f,%-5.1f,%-5.1f,%-5.1f\n",stu1.no,stu1.name,stu1.math,stu1.yw,stu1.eng,stu1.sum);
 	else
 	printf("%-61d,%s,%-5.1f,%-5.1f,%-5.1f,%-5.1f\n",stu2.no,stu2.name,stu2.math,stu2.yw,stu2.eng,stu2.sum);
 }
