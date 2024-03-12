//Implementing a hand-made class for evaluation a string mathematical expression
// This project took me roughly 4 hours to figure out the whole algorithm and how to go by it
// then the actual bugs and debugging took more.
//Operands are in between (-infinity, 0] and [0,9]. 2 digits do not work
#include <iostream>
#include "Math.h"

using namespace std;
int main()
{
    StackArithmetic<double> stack;
    string exp;
    cout << "Please enter an expression: " << endl;
    getline(cin, exp);
    double answer = stack.expression_eval(exp);
    cout << answer << endl;
}