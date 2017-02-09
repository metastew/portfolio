#ifndef _SPELLCHECKER_H
#define _SPELLCHECKER_H

#include <iostream>
#include "BST.h"
#include <fstream>

using namespace std;

class SpellChecker {
private:
	BST tree;
	string arrDictionary[256];
	string arrSample[256];
	string arrMistake[256];
	string arrNonTreeItems[256];
public:
	fstream file;

	SpellChecker();
	virtual ~SpellChecker();

	void BuildTree(string path);
	fstream loadFile(string path);
	void loadSampleData();
	void loadMistakeData();
	bool spellCheckSample();
	bool spellCheckMistake();
	BST setTree(string dictionary[], int length);
	BST printTree();
	string sanitizeLine(string& line);
	string stringToLower(string strToConvert);
	bool isNumber(string test);
	void checkNonTreeItems();
	void clearNonTreeItems();
};

#endif