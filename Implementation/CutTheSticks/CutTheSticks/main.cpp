#include <iostream>
#include <vector>
#include <algorithm>
#include <functional>

using namespace std;

void cutSticks(vector <int> Arr)
{
	int last = 0, length = 0;
	sort(Arr.begin(), Arr.end(), greater <int>());

	while (Arr.size() > 0)
	{
		length = Arr.size();
		cout << length << "\n";
		last = Arr.back();
		Arr.pop_back();
		--length;

		while (length > 0 && Arr[length - 1] <= last)
		{
			Arr.pop_back();
			--length;
		}
	}
}

int main(void)
{
	vector <int> arr;
	int length, x;
	cin >> length;
	for (int i = 0; i < length; ++i)
	{
		cin >> x;
		arr.push_back(x);
	}
	cutSticks(arr);

	return 0;
}