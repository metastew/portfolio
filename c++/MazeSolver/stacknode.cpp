#include <iostream>
#include "stacknode.h"

using namespace std;

StackNode::StackNode() : _next(NULL), _prev(NULL), _x(-1), _y(-1) {}

int StackNode::get_X() 
{
	return _x;
}

void StackNode::set_X(int x)
{
	_x = x;
}

int StackNode::get_Y() 
{
	return _y;
}

void StackNode::set_Y(int y)
{
	_y = y;
}

StackNode *StackNode::get_Next()
{
	return _next;
}

void StackNode::set_Next( StackNode *next)
{
	_next = next;
}

StackNode *StackNode::get_Prev()
{
	return _prev;
}

void StackNode::set_Prev( StackNode *prev)
{
	_prev = prev;
}