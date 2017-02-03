#include <iostream>
using namespace std;

int height(int n) {
	if (n == 0) return 1;
	else if (n % 2 == 1) return 2 * height(n - 1);
	else return height(n - 1) + 1;
}
int main() {
	int T;
	cin >> T;
	while (T--) {
		int n;
		cin >> n;
		cout << height(n) << endl;
	}
}