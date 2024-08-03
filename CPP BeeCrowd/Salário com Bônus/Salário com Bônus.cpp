#include <iostream>
#include <iomanip>

using namespace std;

double calcSalary(double salary, double sales) {
	double result;
	result = salary + (sales * 0.15);
	return result;
}

int main() {
	string name;
	double salary, sales, result;
	cin >> name >> salary >> sales;
	result = calcSalary(salary, sales);
	cout << fixed << setprecision(2);
	cout << "TOTAL = R$ " << result << endl;
	return 0;
}