#include"stdio.h"
#include"stddef.h"
#include"stddef.h"
#include"string.h"
#include"malloc.h"
#include"stdlib.h"
//#include"cindata.h"
//#include"insert.h"
#define MAX 10
typedef struct student 
{
    char name[MAX];
    int num[MAX];
    char sex[MAX];
    int chinese;
    int mathematic;
    int english;
    int computer;
    struct student *next;
} stu;
stu *head;
void print() 
{
    system("cls");
    printf("\t\t\tScore Manage System\n");
    printf("<1>Enter Record\t");
    printf("<2>Display\t");
    printf("<3>Insert\t");
    printf("<4>Quest\t");
    printf("<5>Update\t");
    printf("<6>Save\t");
    printf("<7>Fresh\t");
    printf("<8>Chinese Average\t");
    printf("<9>Math Average\t");
    printf("<10>English Average\t");
    printf("<11>Computer Average\t");
    printf("<12>Quit\t\n");
}
 
void cin(stu *p1) 
{
    printf("Enter name:\n");
    scanf("%s", &p1->name);
    printf("Enter num:\n");
    scanf("%d", &p1->num);
    printf("Enter sex:\n");
    scanf("%s", &p1->sex);
    printf("Enter score:\n");
    printf("Enter chinese:\n");
    scanf("%d", &p1->chinese);
    printf("Enter math:\n");
    scanf("%d", &p1->mathematic);
    printf("Enter English:\n");
    scanf("%d", &p1->english);
    printf("Enter Computer:\n");
    scanf("%d", &p1->computer);
}
stu *cindata() 
{
    stu *p1, *p2;
    int i = 1;
    char ch;
    p1 = (stu *)malloc(sizeof(stu));
    head = p1;
    while(i) 
	{
        cin(p1);
        printf("你想要继续吗?是或否");
        ch = getchar();
        ch = getchar();
        if(ch == 'n' || ch == 'N') 
		{
            i = 0;
            p1->next = NULL;
        } 
		else 
		{
            p2 = p1;
            p1 = (stu *)malloc(sizeof(stu));
            p2->next = p1;
        }
    }
    return(p1->next);
}
 
 
void lookdata(stu *p1) 
{
    while(p1 != NULL) 
	{
        printf("Num:%d\t", p1->num);
        printf("Name:%s\t", p1->name);
        printf("Sex:%s\t", p1->sex);
        printf("\n");
        printf("Chinese:%d\t", p1->chinese);
        printf("Math:%d\t", p1->mathematic);
        printf("English:%d\t", p1->english);
        printf("Computer:%d\t", p1->computer);
        printf("\n");
        p1 = p1->next;
    }
 
}
 
 
 
void insert(stu *p2) 
{
    stu *p1, *p3;
    char ch;
    int i = 1;
    p3 = (stu *)malloc(sizeof(stu));
    p1 = p2;
    while(i) 
	{
        cin(p3);
        printf("再次输入吗?是或否");
        ch = getchar();
        ch = getchar();
        if(ch == 'n' || ch == 'N') 
		{
            i = 0;
            p3->next = NULL;
        } 
		else 
		{
            while(p1 != NULL)
                p1 = p1->next;
            p3 = (stu *)malloc(sizeof(stu));
            p1->next = p3;
        }
    }
 
}
 
 
 
find(stu *p2) 
{
    char name[20];
    int b = 0;
    printf("输入你想找到学生的名字:");
    scanf("%s", name);
    while(p2 != NULL) 
	{
        if(strcmp(name, p2->name) == 0) 
		{
            printf("你想要的数据已经被发现\n");
            printf(" Name:%s\t", p2->name);
            printf("Num:%d\t", p2->num);
            printf("sex%s\t", p2->sex);
            printf("\n");
            printf("Chinese:%d\t", p2->chinese);
            printf("Math:%d\t", p2->mathematic);
            printf("English:%d\t", p2->english);
            printf("Computer:%d\t", p2->computer);
            printf("\n");
 
            b = 1;
        } else if(b == 0)
            printf("对不起，没有找到你要找的数据");
        p2 = p2->next;
    }
 
    if(b == 1) {
        print();
        printf("找到一个\n");
    } else {
        print();
        printf("没有找到\n");
 
    }
}
 
 
void caverage(stu *p2) 
{
    stu *p1;
    int i;
    float max = 0.0, min = 200.0;
    float sum = 0.0, aver = 0;
    p1 = p2;
    if(p1 == NULL)
        printf("没有数据!");
    else
        for(i = 0; p1 != NULL; i++, p1 = p1->next)
            sum += p1->chinese;
    aver /= i;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(max < p1->chinese)
            max = p1->chinese;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(min < p1->chinese)
            min = p1->chinese;
    printf("Chinese Average:%f", aver);
    printf("Chinese Max:%f", max);
    printf("Chinese Min:%f", min);
}
 
 
 
 
void maverage(stu *p2) 
{
    stu *p1;
    int i;
    float max = 0.0, min = 200.0;
    float sum = 0.0, aver = 0;
    p1 = p2;
    if(p1 == NULL)
        printf("没有数据!");
    else
        for(i = 0; p1 != NULL; i++, p1 = p1->next)
            sum += p1->mathematic;
    aver /= i;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(max < p1->mathematic)
            max = p1->mathematic;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(min < p1->mathematic)
            min = p1->mathematic;
    printf("Math Average:%f", aver);
    printf("Math Max:%f", max);
    printf("Math Min:%f", min);
}
 
 
void eaverage(stu *p2) 
{
    stu *p1;
    int i;
    float max = 0.0, min = 200.0;
    float sum = 0.0, aver = 0;
    p1 = p2;
    if(p1 == NULL)
        printf("没有数据!");
    else
        for(i = 0; p1 != NULL; i++, p1 = p1->next)
            sum += p1->english;
    aver /= i;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(max < p1->english)
            max = p1->english;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(min < p1->english)
            min = p1->english;
    printf("English avergre:%f", aver);
    printf("English Max:%f", max);
    printf("English Min:%f", min);
}
 
 
void comaverage(stu *p2) 
{
    stu *p1;
    int i;
    float max = 0.0, min = 200.0;
    float sum = 0.0, aver = 0;
    p1 = p2;
    if(p1 == NULL)
        printf("没有数据!");
    else
        for(i = 0; p1 != NULL; i++, p1 = p1->next)
            sum += p1->computer;
    aver /= i;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(max < p1->computer)
            max = p1->computer;
    for(i = 0; p1 != NULL; i++, p1 = p1->next)
        if(min < p1->computer)
            min = p1->computer;
    printf("Computer Averger:%f", aver);
    printf("Computer Max:%f", max);
    printf("Computer Min:%f", min);
}
 
 
update(stu *p2) 
{
    char name[10];
    int b = 0;
    printf("输入名称");
    scanf("%s", name);
 
    while(p2 != NULL) {
        if(strcmp(name, p2->name) == 0) 
		{
            printf("Find you data\n");
            scanf("Name:%s", p2->name);
            scanf("Num:%s", p2->num);
            scanf("Sex:%s", p2->sex);
            scanf("Chinese:%d", p2->chinese);
            scanf("Math:%d", p2->mathematic);
            scanf("english:%d", p2->english);
            scanf("Computer:%d", p2->computer);
            printf("Success!");
 
            b = 1;
        } else if(b == 0)
            printf("抱歉没有找到数据!");
        p2 = p2->next;
    }
    if(b == 0) 
	{
        print();
        printf("抱歉没有找到数据!");
    } else {
        print();
        printf("找到了!");
    }
}
 
 
 
save(stu *p2) 
{
    FILE *fp;
    char file[10];
    printf("输入文件名称");
    scanf("%s", file);
    fp = fopen(file, "w");
    while(p2 != NULL) 
	{
        fprintf(fp, "%s", p2->name);
        fprintf(fp, "%s", p2->num);
        fprintf(fp, "%s", p2->sex);
        fprintf(fp, "%d", p2->chinese);
        fprintf(fp, "%d", p2->mathematic);
        fprintf(fp, "%d", p2->english);
        fprintf(fp, "%d", p2->computer);
        p2 = p2->next;
    }
    fclose(fp);
}
 
 
char password[7] = "123456";
 
 
void main() 
{
    int choice;
    stu *p2;
    char s[8];
    int flag = 0, i;
    int n = 3;
    do {
        printf("输入密码:\n");
        scanf("%s", s);
        if(!strcmp(s, password)) 
		{
            printf("PASS\n\n\n");
            flag = 1;
            break;
        } 
		else 
		{
            printf("再次输入错误:\n");
            n--;
        }
    } while(n > 0);
    if(!flag) 
	{
        printf("你输入3次!");
        exit(0);
    }
 
 
    printf("~~~~~~~~~~\t\t\t~~~~~~~~~~~~\n");
    printf("\t\t欢迎到管理信息系统\n");
    printf("Author:-----\tClass:------\tNum:------\n");
    printf("Adress:HG\n");
    printf("%%%%%%%%%%%%%%%%%%%%%%%%%%%\n");
    printf("\t\tEnter OP:\n");
    printf("\n\n\n\n");
    printf("==============\t\t==============\n");
    printf("==============\t\t==============\n");
    printf("\t\t进入管理信息系统是或否\n");
 
    scanf("%d", &choice);
    if(choice == 'n' || choice == 'N')
        exit(1);
 
    print();
    while(1) 
	{
        printf("输入选择:");
        scanf("%d", &i);
        if(i < 1 || i > 8) 
		{
            printf("进入num从1到8:\n");
            exit(1);
        }
 
        switch(i) 
		{
        case 1:
            p2 = cindata();
            break;
        case 2:
            lookdata(head);
            break;
        case 3:
            insert(p2);
            break;
        case 4:
            find(head);
            break;
        case 5:
            update(head);
            break;
        case 6:
            save(head);
            break;
        case 7:
            print();
            break;
        case 8:
            caverage(head);
            break;
        case 9:
            maverage(head);
            break;
        case 10:
            eaverage(head);
            break;
        case 11:
            comaverage(head);
            break;
        case 12:
            ;
        case 13:
            exit(1);
            break;
        }
        scanf("%d", &i);
    }
}

