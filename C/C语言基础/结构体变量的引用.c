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
 	printf("������ѧ��1����Ϣ��ѧ�ţ���������ѧ�����ģ�Ӣ�:\n");
 	scanf("%1d%s%f%f%f",&stu1.no,stu1.name,&stu1.math,&stu1.yw,&stu1.eng);
 	stu1.sum=stu1.math+stu1.yw,stu1.eng;
 	printf("������ѧ��2����Ϣ��ѧ�ţ���������ѧ�����ģ�Ӣ�:\n");
 	scanf("%1d%s%f%f%f",&stu2.no,stu2.name,&stu2.math,&stu2.yw,&stu2.eng);
 	stu2.sum=stu2.math+stu2.yw,stu2.eng;
 	printf("�ֽܷϸߵ�ѧ����Ϣ��:\n");
 	if(stu1.sum>stu2.sum)
 	printf("%-61d,%s,%-5.1f,%-5.1f,%-5.1f,%-5.1f\n",stu1.no,stu1.name,stu1.math,stu1.yw,stu1.eng,stu1.sum);
 	else
 	printf("%-61d,%s,%-5.1f,%-5.1f,%-5.1f,%-5.1f\n",stu2.no,stu2.name,stu2.math,stu2.yw,stu2.eng,stu2.sum);
 }
