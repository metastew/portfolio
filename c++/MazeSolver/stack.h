#ifndef _STACK_H
#define _STACK_H

#include <iostream>
#include "stacknode.h"

using namespace std;

class Stack
{
private:
	StackNode *_first;
	StackNode *_last;

public:
	Stack();
	virtual ~Stack();

	StackNode *get_First();
	void set_First(StackNode *first);
	
	StackNode *get_Last();
	void set_Last(StackNode *last);
	
	void Push(int x, int y);
	void Pop();
	
	friend ostream& operator << (ostream &output, Stack &stack);
};

#endif