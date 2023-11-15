#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <malloc.h>
#include <windows.h>


typedef struct tagPERSON
{
	int name[10];
}PERSON;

int main()
{
	tagPERSON person;
	printf("회원가입을 시작합니다.\n");
	printf("가입하실 이름을 입력해주세요 (한글 5, 영문 10글자 이내)\n");
	scanf("%p", person.name);
	printf("학생의 이름 : %d\n", person.name);
}
