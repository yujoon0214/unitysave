//﻿visual studio 에서 scanf 함수 이용시 4996경고 무시
#pragma warning (disable:4996)
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <malloc.h>
#include <windows.h>



int main()
{
	FILE* fp;
	BITMAPFILEHEADER bfh;
	BITMAPINFOHEADER bih;
	fp = fopen("img.bmp", "rb");
	fread(&bfh, sizeof(BITMAPFILEHEADER), 1, fp);
	if (bfh.bfType != 'MB')
	{
		printf("비트맵 파일이 아닙니다.\n");
		fclose(fp);
		return 0;
	}
	else
	{
		printf("비트맵 파일이 맞습니다.\n");
	}
	printf("비트맵 타입 확인 : %c%c\n", bfh.bfType, bfh.bfType>>8);
	printf("비트맵 파일 크기 : %.2fMB", bfh.bfSize / 1024.0f / 1024.0f);
	fread(&bfh, sizeof(BITMAPINFOHEADER), 1, fp);
	printf("비트맵 비트수 : %2dbit\n", bih.biBitCount);
	printf("비트맵 넓이 : %dpixel\n", bih.biWidth);
	printf("비트맵 높아 : %dpixel\n", bih.biHeight);
	fclose(fp);
}

// C언어 파일 입출력

//typedef struct tagHERO
//{
//	char name[20];
//	int hp;
//	int mp;
//	int att;
//	int def;
//	int exp;
//}HERO;
//
//int main()
//{
//	HERO hero = { "유준헌", 200, 100, 15, 32, 3200 };
//	HERO tmphero;
//	FILE* fp = fopen("save.dat", "wb");
//	fwrite((void*)&hero, sizeof(HERO), 1, fp);
//	fclose(fp);
//	fp = fopen("save.dat", "rb");
//	fread((void*)&tmphero, sizeof(HERO), 1, fp);
//	fclose(fp);
//	printf("주인공 이름 : %s\n", tmphero.name);
//	printf("주인공 생명력 : %d\n", tmphero.hp);
//	printf("주인공 마법력 : %d\n", tmphero.mp);
//	printf("주인공 공격력 : %d\n", tmphero.att);
//	printf("주인공 방어력 : %d\n", tmphero.def);
//	printf("주인공 경험치 : %d\n", tmphero.exp);
//	return 0;
//}

//#define _CRT_SECURE_NO_WARNINGS

//typedef struct tagPERSON
//{
//	char name[10];
//	char age;
//	float weight;
//}PERSON;
//
//int main()
//{
//	PERSON person = { 0 };
//	PERSON tmpperson;
//	FILE *fp;
//	fp = fopen("person.txt", "wb+");
//	if (fp == NULL)
//	{
//		printf("파일을 여는데 실패하셨습니다.");
//		return 0;
//	}
//	printf("이름을 입력 하세요 : ");
//	scanf("%s", person.name);
//	printf("나이을 입력 하세요 : ");
//	scanf("%d", person.age);
//	printf("몸무게를 입력 하세요 : ");
//	scanf("%f", person.weight);
//	fwrite((void*)&person, sizeof(person), 1, fp);
//	fseek(fp, 0, SEEK_SET);
//	fread((void*)&tmpperson, sizeof(tmpperson), 1, fp);
//	printf("이름 : %s, 나이 : %d, 몸무게 : %.2f\n", tmpperson.name, tmpperson.age, tmpperson.weight);
//	fclose(fp);
//	return 0;
//}
//int main()
//{
//	FILE *fp;
//	int num1 = 0, num2 = 0, result = 0;
//	char ch1, ch2;
//	fp = fopen("multiple_table.txt", "wt");
//	if (fp == NULL)
//	{
//		printf("파일을 여는데 실패하였습니다.");
//		return 0;
//	}
//	for (int i = 1; i < 10; i++)
//		fprintf(fp, "2 * %d = %d\n", i, 2 * i);
//	fclose(fp);
//	fp = fopen("multiple_table.txt", "rt");
//	if (fp == NULL)
//	{
//		printf("파일을 여는데 실패했습니다.");
//		return 0;
//	}
//	for (int i = 1; i < 10; i++)
//	{
//		fscanf(fp, "%d %c %d %c %d", &num1, &ch1, &num2, &ch2, &result);
//		printf("%d %c %d %c %d\n", num1, ch1, num2, ch2, result);
//	}
//	fclose(fp);
//	return 0;
//}


//int main()
//{
//	FILE *fp;
//	fp = fopen("test.txt", "r");
//	if (fp == NULL)printf("파일 열기 실패\n");
//	fclose(fp);
//
//	return 0;
//}
//

// C언어 구조체
 
//typedef struct tagVALUE {
//	char a;
//	char b;
//	int c;
//}VALUE;
//
//typedef struct tagVALUE2 {
//	char a;
//	int b;
//	char c;
//}VALUE2;
//
//int main()
//{
//	VALUE val;
//	VALUE2 val2;
//	printf("구조체 VALUE 크기 %d\n", sizeof(val));
//	printf("구조체 VALUE2 크기 %d\n", sizeof(val2));
//	return 0;
//}

//typedef struct tagName
//{
//	char first[10];
//	char last[10];
//}NAME;
//
//typedef struct tagSTUDENT
//{
//	int num;
//	int cls;
//	NAME name;
//}STUDENT;
//
//int main()
//{
//	STUDENT me = { 1,2,"준헌","유" };
//	printf("번호 : %d, 반 : %d 이름 : %s, 성 %s\n", me.num, me.cls, me.name.first, me.name.last);
//	return 0;
//}

//struct STUDENT
//{
//	int name[10];
//	char kp;
//	char ep;
//	char mp;
//};
//
//int main()
//{
//	STUDENT std[3];
//
//	for (int i = 0; i < 3; i++)
//	{
//		printf("학생의 이름을 입력해주세요.\n");
//		scanf("%s", std[i].name);
//		printf("학생의 국어 성적을 입력해주세요.\n");
//		scanf("%d", std[i].kp);
//		printf("학생의 영어 성적을 입력해주세요.\n");
//		scanf("%f", std[i].ep);
//		printf("학생의 수학 성적을 입력해주세요.\n");
//		scanf("%g", std[i].mp);
//	}
//	for (int i = 0; i < 3; i++)
//	{
//		printf("학생의 이름 : %d\n", std[i].name);
//		printf("국어성적 : %d\n",std[i].kp);
//		printf("영어성적 : %d\n", std[i].ep);
//		printf("수학성적 : %d\n", std[i].mp);
//		printf("\n");
//	}
//}

//struct PERSON
//{
//	char name[10];
//	char age;
//	float weight;
//};
//int main()
//{
//	// struct는 있어도 없어도 상관이 없다
//	/*struct*/ PERSON person = { "유준헌", 17, 56.0f };
//	printf("이름 : %s\n", person.name);
//	printf("나이 : %d\n", person.age);
//	printf("무게 : %.2f\n", person.weight);
//	return 0;
//}


//int main()
//{
//	struct Hero
//	{
//		int hp;
//	};
//	struct Monster
//	{
//		int hp;
//		char name;
//		char lv;
//		float atk;
//		float def;
//	};
//	Monster mon;
//	Hero hero;
//	hero.hp = 200;
//	mon.hp = 100;
//	mon.lv = 99;
//
//}

//int main(void)
//{
//	int* ptr = NULL;
//	int size = 10;
//
//	ptr = (int *)malloc(sizeof(int) * size);
//	if (ptr != NULL)
//	{
//		memset(ptr, 0, sizeof(int) * size);
//		for (int i = 0; i < size; i++)
//		{
//			printf("%d : %d \n", i + 1, *ptr++);
//		}
//		//Error
//		free(ptr);
//	}
//	return 0;
//}
