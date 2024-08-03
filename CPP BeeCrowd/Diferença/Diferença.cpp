#include <iostream>

using namespace std;

int diff(int a, int b, int c, int d) {
	int diff;
	diff = (a * b) - (c * d);
	return diff;
}

int main() {
	int a, b, c, d, result;
	cin >> a >> b >> c >> d;
	result = diff(a, b, c, d);
	cout << "DIFERENCA = " << result << endl;
	return 0;
}