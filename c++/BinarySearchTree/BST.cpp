#include <iostream>
#include "BST.h"
#include "Node.h"
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;

BST::BST() : root(NULL) {}
BST::BST(string dictionary[], int end) : root(createTree(dictionary, 0, end)) {}
BST::~BST() {}

void BST::insert( string value) {
	insert( value, root, NULL);
}

void BST::insert(string value, NodePtr &node, NodePtr parent) {
	if(node == NULL) {
		// found end of tree
		node = new Node();
		node->data = value;
		node->parent = parent;
	} else if(value < node->data) {
		// travel down the left path of the tree
		insert(value, node->left, node);
	} else if(value > node->data) {
		// travel down the right path of the tree
		insert(value, node->right, node);
	} else {
		// node already exists
		cout << "Node value " << node->data << " already exists." << endl;
	}
}

void BST::remove(string value) {
	bool found = false;

	NodePtr node = root;
	NodePtr parent = NULL;

	// traverse until node is found
	while(!found && (node != NULL))
	{
		if(value < node->data)
		{
			// traverse the left tree
			parent = node;
			node = node->left;
		}
		else if(value > node->data)
		{
			// traverse the right tree
			parent = node;
			node = node->right;
		}
		else
		{
			// found him!
			found = true;
		}
	}

	// node doesn't exist in tree
	if(!found)
	{
		return;
	}

	// find the successor, if two children exist
	if((node->left != NULL) && (node->right != NULL))
	{
		// find leftmost node in right tree
		NodePtr successor = node->right;

		parent = node;
		while(successor->left != NULL)
		{
			parent = successor;
			successor = successor->left;
		}

		// swap values with successor
		node->data = successor->data;

		// node I want to delete is successor now
		node = successor;
	}

	// now we can delete a node with either one child
	// or no children

	NodePtr subtree = node->left;

	// if nothing left, look right for child
	if(subtree == NULL)
	{
		subtree = node->right;
	}

	if(parent == NULL)
	{
		// deleting the root node
		root = subtree;
	}
	else if(parent->left == node)
	{
		// deleting a node with a left subtree
		parent->left = subtree;
	}
	else
	{
		// deleting a node with a right subtree
		parent->right = subtree;
	}

	delete node;
}

void BST::printTree(ostream &output, NodePtr node, int indent) {
	if( node != NULL) {
		printTree(output, node->right, indent + 8);

		output << setw(indent) << node->data << endl;

		printTree( output, node->left, indent + 8);
	}
}

bool BST::searchTree(string key) {
	return searchTree(root, key);
}

// if key exists in the tree, return true
// else if key doesn't exist in tree, return false
bool BST::searchTree(NodePtr node, string key) {
	if(node == NULL) return false;

	if(key < node->data) return searchTree(node->left, key);
	else if(key > node->data) return searchTree(node->right, key);
	else return true;
}

// recursive function that takes a sorted array of strings, grab the middlemost string in the vector
// and use it as root, then recursively use the same function for both side of vectors, continually
// dividing it until length of substrings are less than 1, then finally return the root node of the new tree
NodePtr BST::createTree(string dictionary[], int start, int end) {
	
	// if end is less than start, set node to NULL
	if(end < start) return NULL;

	// grab the middlemost index
	int mid = (start + end) / 2;

	// create a new node, then use this recursive function to create child node(s), if any
	NodePtr node = new Node;
	node->data = dictionary[mid];
	node->left = createTree(dictionary, start, mid-1);
	node->right = createTree(dictionary, mid+1, end);

	// return the root node
	return node;
}

ostream& operator<<(ostream &output, BST &bst){
	bst.printTree(output, bst.root, 0);

	return output;
}