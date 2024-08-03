#include <iostream>

using namespace std;

int sum(int x, int y) {
    int sum;
    sum = x + y;
    return sum;
}

int main()
{
    int x, y, result;
    cin >> x;
    cin >> y;
    result = sum(x, y);
    cout << "SOMA = " << result << endl;
    return 0;
}