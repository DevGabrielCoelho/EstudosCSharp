#include <iostream>;
#include <iomanip>;

using namespace std;

double average(double a, double b, double c) {
	double average;
	average = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / (2.0 + 3.0 + 5.0);
	return average;
}

int main() {
	double a, b, c, result;
	cin >> a >> b >> c;
	result = average(a, b, c);
	cout << fixed << setprecision(1);
	cout << "MEDIA = " << result << endl;
	return 0;
}