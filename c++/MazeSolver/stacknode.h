#ifndef _STACKNODE_H
#define _STACKNODE_H

class StackNode
{
private:
	int _x;
	int _y;
	StackNode *_next;
	StackNode *_prev;
	
public:
	StackNode();
	
	int get_X();
	void set_X(int x);
	
	int get_Y();
	void set_Y(int x);

	StackNode *get_Next();
	void set_Next( StackNode *next);
	
	StackNode *get_Prev();
	void set_Prev( StackNode *prev);
};

#endif