#include <stdio.h>
void main() 
{
	double height, weight;
	double standardweight = height - 110;
	printf("请输入身高:\n");
	scanf("%f",&height);
	printf("请输入体重:\n");
	scanf("%f",&weight);
	if (weight=standardweight) 
	{
		printf("您的体重很标准，请放心吃~~~");
	}
	else if (weight-standardweight>=5) 
	{
		printf("您的体重有点小胖，该减肥了呦~~~");
	}
	else 
	{
		printf("您的体重偏瘦，赶紧补补去吧~~~");
	}
	system("pause");
}