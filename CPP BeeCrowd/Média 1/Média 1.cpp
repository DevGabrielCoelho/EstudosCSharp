#include <iostream>
#include <iomanip>

using namespace std;

double average(double x, double y) {
	double average;
	average = ((x * 3.5) + (y * 7.5)) / (3.5 + 7.5);
	return average;
}

int main() {
	double x, y, result;
	cin >> x;
	cin >> y;
	result = average(x, y);
	cout << fixed << setprecision(5);
	cout << "MEDIA = " << result << endl;
	return 0;
}