//visual studio 에서 scanf 함수 이용시 4996경고 무시
#pragma warning (disable:4996)
#include <stdio.h>
#include <windows.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>


int main(void)
{
	int array[3] = { 0,1,2 };
	printf("array의 값 : %d\n", array);
	printf("array의 주소 : %d\n", &array);
	printf("array + 1 : %d\n", array + 1);
	printf("&array + 1 : %d\n", &array + 1);
	for (int i = 0; i < 3; i++)
		printf("%d\n", array + i);
	return 0;
}

//int main(void)
//{
//	char str1[5] = "abcd";
//	char *str2 = "ABCD";
//
//	printf("%s \n", str1);
//	printf("%s \n", str2);
//
//	str1[0] = 'x';
//	
//	printf("%s \n", str1);
//	printf("%s \n", str2);
//}


//int main(void)
//{
//	int arr[3] = { 10, 20, 30 };
//	int* ptr = &arr[0];
//	printf("%d %3d \n", ptr[0], arr[0]);
//	printf("%d %3d \n", ptr[1], arr[1]);
//	printf("%d %3d \n", ptr[2], arr[2]);
//	printf("%d %3d \n", *ptr, *arr);
//	printf("%d %3d \n", *(ptr + 0), *(arr + 0));
//	printf("%d %3d \n", *(ptr + 1), *(arr + 1));
//	printf("%d %3d \n", *(ptr + 2), *(arr + 2));
//	return 0;
//}


//void swap(int a, int b);
//int main()
//{
//	int a = 3;
//	int b = 2;
//	swap(a, b);
//	printf("3. 함수호출 후 a : %d, b : %d\n", a, b);
//}
//
//void swap(int a, int b)
//{
//	int temp = 0;
//	printf("1. 변경전 a : %d, b : %d\n", a, b);
//	temp = a;
//	a = b;
//	b = temp;
//	printf("2. 변경후 a : %d, b : %d\n", a, b);
//}

//int main()
//{
//	int nData = 10;
//	int *pnData = &nData;
//
//	printf("%d, %d\n", nData, *pnData);
//	printf("%p, %p\n", &nData, pnData);
//	*pnData += 20;
//	printf("%d\n", nData);
//}


//int main()
//{
//	int a = 10;
//	char b = 'A';
//	double c = 1234.56f;
//	int *ptr1 = &a;
//	char *ptr2 = &b;
//	double *ptr3 = &c;
//
//	printf("int형 a의 값 %d , 주소 %d, 크기 %d\n", a, &a, sizeof(a));
//	printf("char형 b의 값 %c , 주소 %d, 크기 %d\n", b, &b, sizeof(b));
//	printf("double형 c의 값 %f , 주소 %d, 크기 %d\n", c, &c, sizeof(c));
//	printf("int형 포인터 ptr1의 값 %d , 주소 %d, 크기 %d\n", ptr1, &ptr1, sizeof(ptr1));
//	printf("char형 포인터 ptr2의 값 %d , 주소 %d, 크기 %d\n", ptr2, &ptr2, sizeof(ptr2));
//	printf("double형 포인터 ptr3의 값 %d , 주소 %d, 크기 %d\n", ptr3, &ptr3, sizeof(ptr3));
//}
//
//int global = 300;
//int main()
//{
//	static int a = 20;
//	int b = 30;
//	int * p = (int *)malloc(sizeof(int));
//	*p = 150;
//	printf("전역변수 global=%3d, &global=%d\n", global, &global);
//	printf("정적변수 a=%d, &a=%d\n", a, &a);
//	printf("지역변수 b=%3d, &b=%d\n", b, &b);
//	printf("포인터 *p=%3d, p=%d\n", *p, p);
//	printf("포인터 *p=%3d, &p=%d\n", *p, &p);
//}
//
//#define P printf
//#define CAR
//#define BUS
//int main()
//{
//#ifdef CAR
//	P("나는 자동차로 출근합니다.\n");
//#endif
//#ifndef BUS
//	P("나는 버스로 출근하지 않습니다.\n");
//#endif
//	return 0;
//}
//
//#define SQUARE1(a) a * a
//#define SQUARE2(a) ((a)*(a))
//#define P printf
//
//int square(int a)
//{
//	return a * a;
//}
//int main()
//{
//	P("SQUARE1(10) = %d\n", SQUARE1(10));
//	P("SQUARE2(10) = %d\n", SQUARE2(10));
//	P("square(10) = %d\n", square(10));
//	P("\n");
//	P("SQUARE1(3+7) = %d\n", SQUARE1(3 + 7));
//	P("SQUARE2(3+7) = %d\n", SQUARE2(3 + 7));
//	P("square(3+7) = %d\n", square(3 + 7));
//	return 0;
//}
//
//#define	MAP_WIDTH		19
//#define MAP_HEIGHT		17
//
//#define MAX_LENGTH		255
//#define HEAD			0
//
//#define LEFT			75
//#define RIGHT			77
//#define UP				72
//#define DOWN			80
//
//int snakeX[MAX_LENGTH], snakeY[MAX_LENGTH];
//int bodyLength;
//int foodX, foodY;
//int dir;
//int speed;
//int isStart;
//enum CURSOR_TYPE {
//	NO_CURSOR,
//	SOLID_CURSOR,
//	NORMAL_CURSOR
//};
//void GotoXY(int x, int y)
//{
//	COORD pos = { 2 * x, y };
//	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
//}
//void SetCursorType(CURSOR_TYPE c)
//{
//	CONSOLE_CURSOR_INFO cursorInfo;
//	switch (c)
//	{
//	case NO_CURSOR:
//		cursorInfo.dwSize = 1;
//		cursorInfo.bVisible = FALSE;
//		break;
//	case SOLID_CURSOR:
//		cursorInfo.dwSize = 100;
//		cursorInfo.bVisible = TRUE;
//		break;
//	case NORMAL_CURSOR:
//		cursorInfo.dwSize = 20;
//		cursorInfo.bVisible = TRUE;
//		break;
//	}
//	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &cursorInfo);
//}
//void Initialized()
//{
//	system("cls");
//	isStart = false;
//	bodyLength = 4;
//	speed = 300;
//	dir = RIGHT;
//	//맵 그리기
//	for (int x = 0; x < MAP_WIDTH; x++)
//	{
//		GotoXY(x, 0);
//		printf("■");
//
//		GotoXY(x, MAP_HEIGHT - 1);
//		printf("■");
//	}
//	for (int y = 1; y < MAP_HEIGHT - 1; y++)
//	{
//		GotoXY(0, y);
//		printf("■");
//		GotoXY(MAP_WIDTH - 1, y);
//		printf("■");
//	}
//	//스네이크 그리기
//	snakeX[HEAD] = MAP_WIDTH / 2 - 4;
//	snakeY[HEAD] = MAP_HEIGHT / 2;
//	GotoXY(snakeX[HEAD], snakeY[HEAD]);
//	printf("◈");
//	for (int i = 1; i < bodyLength; i++)
//	{
//		snakeX[i] = snakeX[HEAD] - i;
//		snakeY[i] = snakeY[HEAD];
//		GotoXY(snakeX[i], snakeY[i]);
//		printf("◎");
//	}
//	foodX = MAP_WIDTH / 2 + 4;
//	foodY = MAP_HEIGHT / 2;
//	GotoXY(foodX, foodY);
//	printf("♥");
//
//}
//void KeyProcess()
//{
//	int key = 0;
//	//키보드 입력
//	if (_kbhit())
//	{
//		isStart = true;
//		key = _getch();
//		if (key == 224)
//			key = _getch();
//		if (dir == LEFT && key != RIGHT ||
//			dir == RIGHT && key != LEFT ||
//			dir == UP && key != DOWN ||
//			dir == DOWN && key != UP)
//			dir = key;
//	}
//}
//void GameProcess()
//{
//	int isTry = 0;
//	//게임 연산 처리
//		//먹이를 먹었을 경우
//	if (snakeX[HEAD] == foodX && snakeY[HEAD] == foodY)
//	{
//		bodyLength++;
//		speed -= 5;
//		if (speed <= 100)
//			speed = 100;
//
//		snakeX[bodyLength - 1] = snakeX[bodyLength - 2];
//		snakeY[bodyLength - 1] = snakeY[bodyLength - 2];
//
//		do {
//			isTry = false;
//			foodX = rand() % (MAP_WIDTH - 2) + 1;
//			foodY = rand() % (MAP_HEIGHT - 2) + 1;
//			for (int i = 0; i < bodyLength; i++)
//			{
//				if (foodX == snakeX[i] && foodY == snakeY[i])
//				{
//					isTry = true;
//					break;
//				}
//			}
//		} while (isTry);
//		GotoXY(foodX, foodY);
//		printf("♥");
//	}
//	//게임오버
//	if (snakeY[HEAD] <= 0 || snakeY[HEAD] >= MAP_HEIGHT - 1 ||
//		snakeX[HEAD] <= 0 || snakeX[HEAD] >= MAP_WIDTH - 1)
//	{
//		Initialized();
//	}
//	for (int i = 1; i < bodyLength; i++)
//	{
//		if (snakeX[HEAD] == snakeX[i] && snakeY[HEAD] == snakeY[i])
//		{
//			Initialized();
//		}
//	}
//}
//void DrawSnake()
//{
//	//스네이크 그리기
//	GotoXY(snakeX[HEAD], snakeY[HEAD]);
//	printf("◎");
//	GotoXY(snakeX[bodyLength - 1], snakeY[bodyLength - 1]);
//	printf("  ");
//	for (int i = bodyLength - 1; i > 0; i--)
//	{
//		snakeX[i] = snakeX[i - 1];
//		snakeY[i] = snakeY[i - 1];
//	}
//	switch (dir)
//	{
//	case LEFT:
//		snakeX[HEAD]--;
//		break;
//	case RIGHT:
//		snakeX[HEAD]++;
//		break;
//	case UP:
//		snakeY[HEAD]--;
//		break;
//	case DOWN:
//		snakeY[HEAD]++;
//		break;
//	default:
//		break;
//	}
//	GotoXY(snakeX[HEAD], snakeY[HEAD]);
//	printf("◈");
//}
//int Max(int a, int b)
//{
//	if (a > b)
//		return a;
//	return b;
//
//}
//int main()
//{
//	Initialized();
//	SetCursorType(NO_CURSOR);
//	while (true)
//	{
//		KeyProcess();
//		if (!isStart)
//			continue;
//		GameProcess();
//		DrawSnake();
//		Sleep(speed);
//	}
//}
//
//
//int main() {
//	int x = 5;
//	int y = 1;
//	for (int i = 0; i < 17; i++)
//	{
//		for (int j = 0; j < 19; j++)
//		{
//			if (map[i][j] == 1)
//			{
//				printf("□");
//			}
//			else if (map[i][j] == 1)
//			{
//				printf("  ");
//			}
//		}
//		printf("\n");
//	}
//}
//
//
//
//#define LEFT 75 
//#define RIGHT 77
//#define UP 72 
//#define DOWN 80 
//#define SPACE 32
//#define ESC 27 
//
//#define MAP_WIDTH 10
//#define MAP_HEIGHT 10
//enum OBJECT { ROAD, WALL, GEM = 3 };
//char map[MAP_HEIGHT][MAP_WIDTH] = {
//	{ 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
//	{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
//	{ 1, 1, 1, 1, 1, 1, 1, 0, 0, 1 },
//	{ 1, 0, 0, 0, 0, 0, 1, 1, 0, 1 },
//	{ 1, 0, 0, 0, 3, 0, 1, 1, 0, 1 },
//	{ 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 },
//	{ 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
//	{ 1, 1, 1, 1, 1, 1, 1, 0, 0, 1 },
//	{ 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
//	{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
//};
////커서 타입 정의
//typedef enum { NO_CURSOR, SOLIDCURSOR, NORMALCURSOR } CURSOR_TYPE;
//
//void gotoxy(int x, int y);
//void setcursortype(CURSOR_TYPE c);
//void Title();
//void GameClear();
//void DrawMap();
//void keyProcess();
//void DrawSentTime(int x, int y, clock_t start);
//int stage = 1;
//int key = 0;
//
//int hero_x = 0;
//int hero_y = 0;
//clock_t start;
//int main(void)
//{
//	int direction = 0;
//	setcursortype(NO_CURSOR);
//	while (true)
//	{
//		direction = keyProcess
//		keyProcess();
//		DrawMap();
//	}
//
//	return 0;
//}
//
//void DrawMap()
//{
//	int x = 5;
//	int y = 1;
//	gotoxy(x + MAP_WIDTH, y); printf(" Stage %2d ", stage);
//	DrawSentTime(x + MAP_WIDTH, y + 1, start);
//	for (int i = 0; i < MAP_HEIGHT; i++)
//	{
//		for (int j = 0; j < MAP_WIDTH; j++)
//		{
//			if (map[i][j] == GEM)
//			{
//				gotoxy(x + j, y + i); printf("☆");
//			}
//			else if (map[i][j] == ROAD)
//			{
//				gotoxy(x + j, y + i);
//				if (hero_x == j && hero_y == i)	printf("A");
//				else printf("▩");
//			}
//			else
//			{
//				gotoxy(x + j, y + i); printf("□");
//			}
//		}
//	}
//}
//void keyProcess() {
//	key = 0;
//	if (kbhit()) {
//		key = getch();
//		if (key == 224) {
//			key = getch();
//			switch (key) {
//			case LEFT:
//				if (hero_x - 1 > 0)
//				{
//					if (map[hero_y][hero_x - 1] == GEM) {
//						GameClear();
//						hero_x = hero_y = 0;
//					}
//					else if (map[hero_y][hero_x - 1] == ROAD)	hero_x--;
//				}
//				break;
//			case RIGHT:
//				if (hero_x + 1 <= 10)
//				{
//					if (map[hero_y][hero_x + 1] == GEM) {
//						GameClear();
//						hero_x = hero_y = 0;
//					}
//					else if (map[hero_y][hero_x + 1] == ROAD)	hero_x++;
//				}
//				break;
//			case DOWN:
//				if (hero_y + 1 < MAP_HEIGHT)
//				{
//					if (map[hero_y + 1][hero_x] == GEM) {
//						GameClear();
//						hero_x = hero_y = 0;
//					}
//					else if (map[hero_y + 1][hero_x] == ROAD)	hero_y++;
//				}
//				break;
//			case UP:
//				if (hero_y - 1 >= 0)
//				{
//					if (map[hero_y - 1][hero_x] == GEM) {
//						GameClear();
//						hero_x = hero_y = 0;
//					}
//					else if (map[hero_y - 1][hero_x] == ROAD)	hero_y--;
//				}
//				break;
//			}
//		}
//		else { //방향키가 아닌경우 
//			switch (key) {
//			case ESC: //ESC눌렀을때 
//				system("cls"); //화면을 지우고 
//				printf("게임을 종료합니다.\n");
//				exit(0); //게임종료 
//			}
//		}
//	}
//	while (kbhit()) getch(); //키버퍼를 비움 
//}
//void DrawSentTime(int x, int y, clock_t start)
//{
//	int msecPerMinute = CLOCKS_PER_SEC * 60;
//	int msecPerHour = msecPerMinute * 60;
//	int msecPerDay = msecPerHour * 24;
//
//	int sec, min, hour, day;
//	clock_t current = clock() - start;
//	day = current / msecPerDay;
//	hour = current / msecPerHour;
//	current = current - (hour * msecPerHour);
//
//	min = current / msecPerMinute;
//	current = current - (min * msecPerMinute);
//
//	sec = current / CLOCKS_PER_SEC;
//
//	gotoxy(x, y); printf("%02d min, %02d sec", min, sec);
//}
//void gotoxy(int x, int y) { //gotoxy함수 
//	COORD pos = { 2 * x,y };
//	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
//}
//void setcursortype(CURSOR_TYPE c) { //커서숨기는 함수 
//	CONSOLE_CURSOR_INFO CurInfo;
//
//	switch (c) {
//	case NOCURSOR:
//		CurInfo.dwSize = 1;
//		CurInfo.bVisible = FALSE;
//		break;
//	case SOLIDCURSOR:
//		CurInfo.dwSize = 100;
//		CurInfo.bVisible = TRUE;
//		break;
//	case NORMALCURSOR:
//		CurInfo.dwSize = 20;
//		CurInfo.bVisible = TRUE;
//		break;
//	}
//	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &CurInfo);
//}
//
