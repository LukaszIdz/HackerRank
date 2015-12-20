#include <iostream>

using namespace std;

int main(void)
{
	int n, t, k1,k2, min;
	int widthArray[100000];
	int resultArray[1000];

	cin >> n;
	cin >> t;

	for (int i = 0; i < n; ++i)
	{
		cin >> widthArray[i];
	}

	for (int i = 0; i < t; ++i)
	{
		cin >> k1;
		cin >> k2;
		min = 3;

		for (int j = k1; j <= k2; ++j)
		{
			if (min == 1) break;
			else if (widthArray[j] < min) min = widthArray[j];
		}

		resultArray[i] = min;
	}

	for (int i = 0; i < t; ++i)
	{
		cout << resultArray[i] << "\n";
	}

	return 0;
}