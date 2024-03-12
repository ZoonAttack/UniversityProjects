#pragma once
using namespace std;
#include <iostream>
#include <string>
#include <queue>
#include <stack>
template <typename T>
class StackArithmetic {
	stack<T> expStack;
	T left;
	T right;
	char operatorSign;
	int precedence(char operators) { // for precedence of operators
		switch (operators)
		{
		case '+':
		case '-':
			return 1;
		case '*':
		case '/':
			return 2;
		case '(':
		case ')':
			return 3;
		default:
			return -1;
		}
	}
	bool isOperator(char operators)
	{
		return(operators == '+' || operators == '-' || operators == '*' || operators == '/' || operators == '(' || operators == ')');
	}
	string to_postfix(string exp) { //this algorithm converts infix to postfix expression
		string postfix = "";
		stack<char> op; //this stack will be used to organize operators by precedence
		for (int i = 0, j = 0; i < exp.length(); i++)
		{
			
			if (isalpha(exp[i])) throw current_exception();
			if (exp[i] == ' ') continue;
			if (isdigit(exp[i]))

				postfix += exp[i]; //if a number is encountered we just concatenate it to the postfix string

			else if (exp[i] == '(') // The open parantheses is considered to ignore the prior operator's precedence.
				op.push('(');		// like having a new separate stack
			else if (exp[i] == ')') { //when we encounter a closed parantheses
				while (op.top() != '(') { //we keep popping till we meet the open parantheses
					postfix += op.top(); 
					op.pop(); 
				}
				op.pop(); // and pop it aswell. leaving us with the operator that was left before the open parantheses
			}
		
			else if (isOperator(exp[i])) {
					while (!op.empty() && op.top() != '(' && (precedence(exp[i]) <= precedence(op.top())))
					{
						postfix += op.top(); //if an operator is faced and its precedence is lower than the one inside the stack
						op.pop(); //we add the one in the stack first to the postfix string and pop it from the stack
					}
					op.push(exp[i]); //then we push the operator that had a lower precedence in the stack
			}
		}
		
		while (!op.empty()) {
			postfix += op.top(); // at the end add the remaining operators of low precedence  and empty the stack
			op.pop();
		}
		return postfix; // return the new postfix expression
	}
	T evaluate() {
		switch (operatorSign)
		{
		case '+':
			return left + right;
		case '-':
			return left - right;
		case '*':
			return left * right;
		case '/':
			return left / right;
		default:
			return NULL;
		}
	}
public: 
	StackArithmetic() : left(0), right(0), operatorSign('\0') {}; // Constructor 

	T expression_eval(string given_expression) { // a function made to evaluate the given expression

		string expression = to_postfix(given_expression); //the machine can not deal with an infix expression so 
														  // i converted it to a postfix expression!
		if (expression.empty()) throw exception("Empty expression");
		
		for (int i = 0; i < expression.length(); i++)
		{
			if (isdigit(expression[i])) //Check if the character is a number
			{
				char num = expression[i] - '0'; // 0 in ascii is 48. we use it to get the actual value of the number!
				expStack.push(num); //push it into the stack
			}
			else if (isOperator(expression[i])) { // check if the character is an operator "+/*-"
				operatorSign = expression[i]; //if it is then we assign the operator to "operatorSign"
				right = expStack.top(); //then pop the top most value of the stack and assign it to the right
				expStack.pop();
				left = expStack.top(); // after we remove the "right" operand we remove the top most value and assign it to left
				expStack.pop(); 
				expStack.push(evaluate()); //then push the new value to continue evaluating
			}
		}
		T result = expStack.top();
		expStack.pop();
		return result; // return the finalized value
	}
};
