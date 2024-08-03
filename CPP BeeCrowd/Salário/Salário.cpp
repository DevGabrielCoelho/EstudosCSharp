#include <iostream>
#include <iomanip>

using namespace std;

double calcSalary(int hours, double salaryPerHour) {
	double dhours, salary;
	dhours = hours + 0.0;
	salary = salaryPerHour * dhours;
	return salary;
}

int main() {
	int number, hours;
	double salaryPerHours, result;

	cin >> number >> hours >> salaryPerHours;

	result = calcSalary(hours, salaryPerHours);

	cout << fixed << setprecision(2);
	cout << "NUMBER = " << number << "\nSALARY = U$ " << result << endl;

	return 0;
}