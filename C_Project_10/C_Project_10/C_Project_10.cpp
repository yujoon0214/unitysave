//visual studio 에서 scanf 함수 이용시 4996경고 무시
#pragma warning (disable:4996)
#include <stdio.h>
#include <windows.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>

#define	MAP_WIDTH		19
#define MAP_HEIGHT		17

#define MAX_LENGTH		255
#define HEAD			0
enum CURSOR_TYPE {
	NO_CURSOR,
	SOLID_CURSOR,
	NORMAL_CURSOR
};
void GotoXY(int x, int y)
{
	COORD pos = { 2 * x, y };
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
}
void SetCursorType(CURSOR_TYPE c)
{
	CONSOLE_CURSOR_INFO cursorInfo;
	switch (c)
	{
	case NO_CURSOR:
		cursorInfo.dwSize = 1;
		cursorInfo.bVisible = FALSE;
		break;
	case SOLID_CURSOR:
		cursorInfo.dwSize = 100;
		cursorInfo.bVisible = TRUE;
		break;
	case NORMAL_CURSOR:
		cursorInfo.dwSize = 20;
		cursorInfo.bVisible = TRUE;
		break;
	}
	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &cursorInfo);
}
int main()
{
	int snakeX[MAX_LENGTH] = { 0 }, snakeY[MAX_LENGTH] = { 0 };
	int bodyLength = 4;
	int foodX = 0, foodY = 0;
	//맵 그리기
	for (int x = 0; x < MAP_WIDTH; x++)
	{
		GotoXY(x, 0);
		printf("■");

		GotoXY(x, MAP_HEIGHT - 1);
		printf("■");
	}
	for (int y = 1; y < MAP_HEIGHT - 1; y++)
	{
		GotoXY(0, y);
		printf("■");
		GotoXY(MAP_WIDTH - 1, y);
		printf("■");
	}
	//스네이크 그리기
	snakeX[HEAD] = MAP_WIDTH / 2 - 4;
	snakeY[HEAD] = MAP_HEIGHT / 2;
	GotoXY(snakeX[HEAD], snakeY[HEAD]);
	printf("◈");
	for (int i = 1; i < bodyLength; i++)
	{
		snakeX[i] = snakeX[HEAD] - i;
		snakeY[i] = snakeY[HEAD];
		GotoXY(snakeX[i], snakeY[i]);
		printf("◎");
	}
	foodX = MAP_WIDTH / 2 + 4;
	foodY = MAP_HEIGHT / 2;
	GotoXY(foodX, foodY);
	printf("♥");
	GotoXY(0, MAP_HEIGHT);

}
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
