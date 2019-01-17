#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#include <time.h>
#define SCREEN_WIDTH  40   /*��Ϸ��Ļ���*/ 
#define SCREEN_LENGTH 15   /*��Ϸ��Ļ����*/ 
#define START_X 16         /*��Ļ��ʼX����*/ 
#define START_Y 2          /*��Ļ��ʼy����*/

enum direc{up, down, left, right};  /*�ߵ��˶�����*/

typedef struct snake{               /*����ṹ��*/
	int x;
	int y;
	struct snake *next;
	struct snake *pre;
	struct snake *end;
}SNAKE;

typedef struct{                /*ʳ��*/
	int x;
	int y;
}FOOD;

void HideCursor()         /*���ع�꣬�õ���һЩCONSOLE API*/
{
	HANDLE hOut = GetStdHandle(STD_OUTPUT_HANDLE);
	CONSOLE_CURSOR_INFO cci;
	GetConsoleCursorInfo(hOut, &cci);
	cci.bVisible = FALSE;
	SetConsoleCursorInfo(hOut, &cci);
}

void GotoRood(int x, int y)    /*�����Ծ��ĳ��λ�ã����� CONSOLE API*/
{
	HANDLE hOut = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD cod;
	cod.X = x;
	cod.Y = y;
	SetConsoleCursorPosition(hOut, cod);
}
//  sleep()����delay  sleep(500)��ʾ�ӳ�500ms 

int Random(int n)          /*�������ʳ���λ��*/
{ 
    srand(time(NULL));
    return (rand() % n);
}

void BuildSnk(SNAKE *head)  /*��������*/
{
	SNAKE *p = head;
	while (p != NULL)
	{
	   GotoRood(p->x, p->y);
	   printf("#");
	   p = p->next;
	}
}

void RemoveSnk(SNAKE *head)   /*�������*/
{
	SNAKE *p = head;
	while (p != NULL)
	{
		GotoRood(p->x, p->y);
		printf(" ");
		p = p->next;
	}
}

void Move(int *d)  //�ƶ����򡣡��� ��������   �ϣ�72  �£�80 ��75 �ң�77
{
	char ch;
	while(_kbhit())
	{
		ch = getch();
		if (ch == 72)
		{
		  if ((*d == left || *d == right) && *d != down)
		    *d = up;
		}
	    else if (ch == 80)
        {
	      if ((*d == left || *d == right) && *d != up)
		      *d = down;
        }
	    else if (ch == 75)
	    {
		  if ((*d == up || *d == down) && *d != right) 
		     *d = left;
	    }
		else if (ch == 77)
	    {
    	  if ((*d == up || *d == down) && *d != left)
  			 *d = right;
  		}
	}
}

void IniScreen(SNAKE *head)   /*��ʼ����Ļ*/
{
	int i,j;
	SNAKE *p1, *p2; 
	
	HideCursor();
	GotoRood(START_X,START_Y);
	/*-------------����Ϸ�߿�---------------*/ 
	for (i = 0; i < SCREEN_WIDTH + 2; i++)
	  printf("-");
    for (j = 1; j <= SCREEN_LENGTH; j++)
	{
		GotoRood(START_X + SCREEN_WIDTH + 1, START_Y + j);
		printf("|");
	} 
	GotoRood(START_X, START_Y + SCREEN_LENGTH + 1);
	for (i = 0; i < SCREEN_WIDTH + 2; i++)
      printf("-");
    for (j = 1; j <= SCREEN_LENGTH; j++)
    {
    	GotoRood(START_X,START_Y + j);
    	printf("|");
    }
    GotoRood(START_X + 20, START_Y - 1);
    printf("CopyRight@11�ƿ� �����"); 
    GotoRood(0,START_Y + 2);
    printf("��Ϸ˵����\n\n�����õȼ�\n\n�����س�����ʼ\n\n��������\n���Ʒ���\n");
/*--------------������-------------------*/    
    head->x = START_X + SCREEN_WIDTH / 2;
	head->y = START_Y + 8;
	head->pre = NULL;
	p1 = head;
	i = 0;
	while (++i < 3)
	{
		
		p2 = p1;
		p1 = (SNAKE *)malloc(sizeof(SNAKE));
		p1->x = START_X + SCREEN_WIDTH / 2;
     	p1->y = START_Y + 8 + i;
     	p1->end = NULL;
		p2->next = p1;
		p1->pre = p2;  /////////////////
	}
	p1->next = NULL;
	head->end = p1;
	BuildBody(head);
}

void CreatFood(FOOD *fd, SNAKE *snk)  /*���Եģ��ǵ�����һ�����ܾ�����ʳ�ﲻ�������ͻ*/ 
{
	SNAKE *p = snk;
	int clash = 0;    /*���ʳ��λ���Ƿ���߷�����ͻ*/
	while(1)
	{
	  clash = 0;
	  fd->x = START_X + 1 + Random(SCREEN_WIDTH);  /* x�����ڱ߿��� */
	  fd->y = START_Y + 1 + Random(SCREEN_LENGTH);  /* y�����ڱ䳤�� */
	  for (;p != NULL ;p = p->next)
	    if (fd->x == p->x && fd->y == p->y)
        {
	       clash = 1;
	       break;
        }
      if (clash == 0)
       break;
	}
	GotoRood(fd->x, fd->y);
	printf("*");
}

void CollisionTest(SNAKE *head)
{
	if (head->x == START_X)  /*һͷײ����ǽ��.....*/ 
	   head->x = START_X + SCREEN_WIDTH;   /*��...�Ǵ��ұ߳�����*/
    else if (head->x == START_X + SCREEN_WIDTH + 1) /*..�����������ײ....*/
       head->x = START_X + 1;
    else if (head->y == START_Y)     /*...������ײ...*/
       head->y = START_Y + SCREEN_LENGTH;
    else if (head->y == START_Y + SCREEN_LENGTH + 1)    /*����Ҳ���ܷŹ�...*/
       head->y = START_Y + 1; 
}

int Eated(SNAKE *head, FOOD *fd)            /*....��ľ�гԵ�ʳ��*/
{
	if (head->x == fd->x && head->y == fd->y)
	  return 1;
    return 0;
}

int GameOver(SNAKE *head)      /*�ж���Ϸ������û.*/
{
	SNAKE *p;
	for(p = head->next; p != NULL; p = p->next)
	{
		if (head->x == p->x && head->y == p->y)
		   return 1;
	}
	return 0;
}

void gameing()   /*��Ϸ����*/
{
	int i = 0, eat = 0, rank, scorelimit = 0, score = 0;
	int direct = up;   /*  ��ʼ����Ϊ���� */
	time_t grade = 2;      /*  ��ʼ�ȼ�Ϊ2 */ 
	FOOD *fd;
	SNAKE *head, *ptemp, *pnew;  /*����3������ + 1����ͷ��ʱ��Ż�ҡ�   �о���C++�ĳ����������һЩ����*/
	
	head = (SNAKE *)malloc(sizeof(SNAKE));
	fd = (FOOD *)malloc(sizeof(FOOD));
	GotoRood(START_X, START_Y - 1);
	printf("Grade: %d", grade);
	GotoRood(START_X + 10, START_Y - 1);
	printf("Score: %-3d", score);
	IniScreen(head);
	CreatFood(fd, head);
	while(rank = getch())      /*���ܰ���...�����õȼ����ո񡿿�ʼ��Ϸ*/
	{
		if (rank == 72)
        {
		  grade = ++grade % 10;
		  if (grade == 0)
		    grade = 1;
		  GotoRood(START_X, START_Y - 1);
	      printf("Grade: %d", grade);
        }
        else if (rank == 13)
		 break; 
	}
	while (1)   
	{
		RemoveSnk(head);             
		ptemp = (SNAKE *)malloc(sizeof(SNAKE));   /*��ʱ�ģ������������ߵ�ͷ��*/
		Move(&direct);   /*....�����û�ѡ���ߵ��˶�����*/
		switch(direct)
		{
			case up: ptemp->x = head->x;
			         ptemp->y = head->y - 1;
			         break;
            case down: ptemp->x = head->x;
			           ptemp->y = head->y + 1;
                       break;
			case left: ptemp->x = head->x - 1;
			           ptemp->y = head->y;
			           break;
			case right: ptemp->x = head->x + 1;
			            ptemp->y = head->y; 
			            break;
		}
		if (!eat)    /*���û�Ե�������Ȼ�����ߵĳ���*/
        {
       	   ptemp->end = head->end->pre;   /*���ߵ�β��λ�øı䣬��Ϊ�����ڶ���*/
   	       head->end->pre->next = NULL;  /*��������...*/
		   free(head->end);              
		   head->end = NULL;
        }
        else
 	    {
           ptemp->end = head -> end;/*�Ե��ˡ�����ԭ�еĻ����ϻ�һ��ͷ�������Ͷ���һ��*/
 	    }
		head->pre = ptemp;          /*������������*/
		ptemp->next = head;
		ptemp->pre = NULL;
		head = ptemp;
		if (eat = Eated(head, fd))  
        {
		  CreatFood(fd,head);
		  score += grade;     /*�Ե��ˣ��ͼӷ�*/
		  scorelimit += grade;   
		  if (scorelimit / 50 && grade <= 10)  /*����������ӵȼ���*/
          {                                    /*ÿ��һ��50��,�ȼ�����һ�Σ�10��������..�ٺ�*/
             GotoRood(START_X, START_Y - 1);
	         printf("Grade: %d", ++grade);
	         scorelimit = score % 50;
          }
		  GotoRood(START_X + 10, START_Y - 1);
          printf("Score: %-3d", score);
        }
        if (GameOver(head))   /*��Ϸ�Ƿ����....*/
        {
        	BuildSnk(head);   /*��������Ӣ�ˡ������Ի�����..*/
        	GotoRood(START_X + SCREEN_WIDTH / 2, START_Y + SCREEN_LENGTH / 2);
        	puts("Game Over!\n");
        	return;
        }
		CollisionTest(head);   /*��ײ����*/
		BuildSnk(head);
		Sleep((10 - grade) * 50);  /*��ʱ...�������ͣ(10 - grade)*50ms ��ʱ��, windows.h��ĺ���*/
	}
} 

int main()
{
	gameing();
	return 0;
}
