#include <iostream>

using namespace std;

int sum(int x, int y) {
    int result;
    result = x + y;
    return result;
}

int main()
{
    int a;
    int b;
    int result;
    cin >> a;
    cin >> b;
    result = sum(a, b);
    cout << "X = " << result << "\n";
    return 0;
}