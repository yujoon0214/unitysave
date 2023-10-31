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

#define LEFT			75
#define RIGHT			77
#define UP				72
#define DOWN			80

int snakeX[MAX_LENGTH], snakeY[MAX_LENGTH];
int bodyLength;
int foodX, foodY;
int dir;
int speed;
int isStart;
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
void Initialized()
{
	system("cls");
	isStart = false;
	bodyLength = 4;
	speed = 300;
	dir = RIGHT;
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

}
void KeyProcess()
{
	int key = 0;
	//키보드 입력
	if (_kbhit())
	{
		isStart = true;
		key = _getch();
		if (key == 224)
			key = _getch();
		if (dir == LEFT && key != RIGHT ||
			dir == RIGHT && key != LEFT ||
			dir == UP && key != DOWN ||
			dir == DOWN && key != UP)
			dir = key;
	}
}
void GameProcess()
{
	int isTry = 0;
	//게임 연산 처리
		//먹이를 먹었을 경우
	if (snakeX[HEAD] == foodX && snakeY[HEAD] == foodY)
	{
		bodyLength++;
		speed -= 5;
		if (speed <= 100)
			speed = 100;

		snakeX[bodyLength - 1] = snakeX[bodyLength - 2];
		snakeY[bodyLength - 1] = snakeY[bodyLength - 2];

		do {
			isTry = false;
			foodX = rand() % (MAP_WIDTH - 2) + 1;
			foodY = rand() % (MAP_HEIGHT - 2) + 1;
			for (int i = 0; i < bodyLength; i++)
			{
				if (foodX == snakeX[i] && foodY == snakeY[i])
				{
					isTry = true;
					break;
				}
			}
		} while (isTry);
		GotoXY(foodX, foodY);
		printf("♥");
	}
	//게임오버
	if (snakeY[HEAD] <= 0 || snakeY[HEAD] >= MAP_HEIGHT - 1 ||
		snakeX[HEAD] <= 0 || snakeX[HEAD] >= MAP_WIDTH - 1)
	{
		Initialized();
	}
	for (int i = 1; i < bodyLength; i++)
	{
		if (snakeX[HEAD] == snakeX[i] && snakeY[HEAD] == snakeY[i])
		{
			Initialized();
		}
	}
}
void DrawSnake()
{
	//스네이크 그리기
	GotoXY(snakeX[HEAD], snakeY[HEAD]);
	printf("◎");
	GotoXY(snakeX[bodyLength - 1], snakeY[bodyLength - 1]);
	printf("  ");
	for (int i = bodyLength - 1; i > 0; i--)
	{
		snakeX[i] = snakeX[i - 1];
		snakeY[i] = snakeY[i - 1];
	}
	switch (dir)
	{
	case LEFT:
		snakeX[HEAD]--;
		break;
	case RIGHT:
		snakeX[HEAD]++;
		break;
	case UP:
		snakeY[HEAD]--;
		break;
	case DOWN:
		snakeY[HEAD]++;
		break;
	default:
		break;
	}
	GotoXY(snakeX[HEAD], snakeY[HEAD]);
	printf("◈");
}
int Max(int a, int b)
{
	if (a > b)
		return a;
	return b;

}
int main()
{
	Initialized();
	SetCursorType(NO_CURSOR);
	while (true)
	{
		KeyProcess();
		if (!isStart)
			continue;
		GameProcess();
		DrawSnake();
		Sleep(speed);
	}
}