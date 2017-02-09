#ifndef _NODE_H
#define _NODE_H

#include <iostream>

using namespace std;

class Node;

typedef Node * NodePtr;

class Node{
public:
	string data;
	NodePtr left;
	NodePtr right;
	NodePtr parent;

	Node();
	virtual ~Node();
};

#endif