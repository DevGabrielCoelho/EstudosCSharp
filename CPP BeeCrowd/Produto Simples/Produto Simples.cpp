#include <iostream>

using namespace std;

int prod(int x, int y) {
	int prod;
	prod = x * y;
	return prod;
}

int main() {
	int x, y, result;
	cin >> x;
	cin >> y;
	result = prod(x, y);
	cout << "PROD = " << result << endl;
	return 0;
}