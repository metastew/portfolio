#include <iostream>
#include "stack.h"

using namespace std;

Stack::Stack() : _first(NULL), _last(NULL) {}
	
Stack::~Stack() {
	while(_first != NULL) {
		Pop();
	}
}

StackNode *Stack::get_First()
{
	return _first;
}

void Stack::set_First(StackNode *first)
{
	_first = first;
}

StackNode *Stack::get_Last()
{
	return _last;
}

void Stack::set_Last(StackNode *last)
{
	_last = last;
}

void Stack::Push(int x, int y) 
{
	StackNode *newNode = new StackNode();
	newNode->set_X(x);
	newNode->set_Y(y);
	newNode->set_Prev(_last);

	if(_first == NULL) 
	{
		// first node in the Stack
		_first = newNode;
	}
	else 
	{
		// other node in the Stack
		_last->set_Next(newNode);
	}
	// re-point to the new last node
	_last = newNode;
}

void Stack::Pop()
{
	// verify a node exist to pop off
	if(_first != NULL)
	{
		StackNode *node = _last;

		// change last pointer to point to new last node in list
		_last = _last->get_Prev();

		// verify the first pointer is actually pointing 
		// to a node if we are removing the last node,
		// there won't be anything before it
		if(_last != NULL)
		{
			_last->set_Next(NULL);
		}

		// if i am deleting the first and only node
		// make sure the first pointer is reset
		if(node == _first) 
		{
			_first = NULL;
		}

		delete node;
	}
}

ostream& operator << (ostream &output, Stack &stack)
{
	StackNode* node = stack._first;

	while(node != NULL)
	{
		output << node->get_X() << ", " << node->get_Y() << endl;

		node = node->get_Next();
	}

	return output;
}