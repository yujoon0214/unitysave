#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <malloc.h>
#include <windows.h>



typedef struct tagPERSON 
{
 
    char name[10];

} PERSON;

int main(void) 
{
    int isTry = 0;
    PERSON person;

    printf("회원가입을 시작합니다.\n");
    printf("가입하실 이름을 입력해주세요 (한글 5, 영문 10글자 이내)\n");
    do {
        scanf("%s", person.name);
        if (strlen(person.name) < 3) {
            printf("이름이 너무 짧습니다, 다시 입력하세요.\n");
            isTry = 1;s
        }else if (strlen(person.name) > 10) {
            printf("이름이 너무 깁니다, 다시 입력하세요.\n");
            isTry = 1;
        }else
        {
            isTry = 0;
        }
    } while (isTry);
    printf("가입하실 아이디를 email 주소로 입력하세요. \n");



}