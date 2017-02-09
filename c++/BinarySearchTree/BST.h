#ifndef _BST_H
#define _BST_H

#include <iostream>
#include <vector>
#include "Node.h"

using namespace std;

class BST {
private:
	NodePtr root;

public:
	BST();
	BST(string dictionary[], int end);
	virtual ~BST();

	void insert(string value);
	void insert(string value, NodePtr &node, NodePtr parent);
	void remove(string value);
	void printTree(ostream &output, NodePtr node, int indent);
	bool searchTree(string key);
	bool searchTree(NodePtr node, string key);
	NodePtr createTree(string dictionary[], int start, int end);
	friend ostream& operator<<(ostream &output, BST &bst);
};

#endif