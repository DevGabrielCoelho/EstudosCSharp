#include <iomanip>
#include <iostream>
#include <cmath>

using namespace std;

float circleAreaCalculation(float x) 
{
    float area;
    area = pow(x, 2);
    area = area * 3.14159;
    return area;
}

int main()
{
    float radius, area;
    cin >> radius;
    area = circleAreaCalculation(radius);
    cout << fixed << setprecision(4);
    cout << "A=" << area << endl;
    return 0;
}
