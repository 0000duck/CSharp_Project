#include <stdio.h>
void main() 
{
	double height, weight;
	double standardweight = height - 110;
	printf("���������:\n");
	scanf("%f",&height);
	printf("����������:\n");
	scanf("%f",&weight);
	if (weight=standardweight) 
	{
		printf("�������غܱ�׼������ĳ�~~~");
	}
	else if (weight-standardweight>=5) 
	{
		printf("���������е�С�֣��ü�������~~~");
	}
	else 
	{
		printf("��������ƫ�ݣ��Ͻ�����ȥ��~~~");
	}
	system("pause");
}