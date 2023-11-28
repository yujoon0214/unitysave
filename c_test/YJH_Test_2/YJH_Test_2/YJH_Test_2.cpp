#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Product
{
	char Name[10];
	int Price;
	double Point;
};


Product product[5]{ {"니콘", 1000000, 4.5},
{"캐논", 1000354, 4.2},
{"소니", 1234500, 3.8},
{"라이카", 2123500, 4.0},
{"삼성", 1427560, 5.0}
};

int inputNum;
int isDesc;
int outputIndex;
int nSortType;


void Print(Product cams[]) {//Camera 구조체 배열을 출력하는 함수

	system("cls");//콘솔창 지우기
	isDesc = inputNum % 2;//0 => 오름차순, 1 => 내림차순
	printf("------------------------------------------------\n");
	printf("번호         상품명         가격         평점   \n");
	printf("------------------------------------------------\n");
	for (int i = 0; i < 5; i++)
	{
		if (isDesc == 1)//내림차순
			outputIndex = 5 - i - 1;
		else//오름차순
			outputIndex = i;
		printf("[%2d]       [%7s]      [%7d]      [%.3lf]\n",
			i + 1, cams[outputIndex].Name, cams[outputIndex].Price, cams[outputIndex].Point);
	}
	printf("------------------------------------------------\n");
}

//정렬의 기본은 오름차순

void NameSort() {//이름순 정렬
	Product tmpNameCamera;
	for (int i = 0; i < 5; i++) {
		for (int j = i; j < 5; j++) {
			if (strcmp(product[i].Name, product[j].Name) > 0) {
				tmpNameCamera = product[i];
				product[i] = product[j];
				product[j] = tmpNameCamera;
			}
		}
	}
	Print(product);
}


void PriceSort() {//가격순 정렬

	Product tmpSortCamera;
	for (int i = 0; i < 5; i++) {
		for (int j = i; j < 5; j++) {
			if (product[i].Price > product[j].Price) {
				tmpSortCamera = product[i];
				product[i] = product[j];
				product[j] = tmpSortCamera;
			}
		}
	}
	Print(product);
}


void AvgPointSort() {//평점순 정렬
	Product tmpAvgCamera;
	for (int i = 0; i < 5; i++) {
		for (int j = i; j < 5; j++) {
			if (product[i].Point > product[j].Point) {
				tmpAvgCamera = product[i];
				product[i] = product[j];
				product[j] = tmpAvgCamera;
			}
		}
	}
	Print(product);
}

void PreSort() {//정렬 전 메뉴
	while (true) {

		printf("------------------------------------------------\n");
		printf("1. 이름 내림차순                2. 이름 오름차순\n");
		printf("3. 가격 내림차순                4. 가격 오름차순\n");
		printf("5. 평점 내림차순                6. 평점 오름차순\n");
		printf("7. 종료\n\n");
		printf("선택 ==> ");
		scanf("%d", &inputNum);
		printf("------------------------------------------------\n");
		nSortType = (inputNum + 1) / 2;
		switch (nSortType)
		{
		case 1:
			NameSort();
			break;
		case 2:
			PriceSort();
			break;
		case 3:
			AvgPointSort();
			break;
		case 4:
			exit(0);
		default:
			break;
		}
	}
}

int main()
{
	PreSort();
	return 0;
}
