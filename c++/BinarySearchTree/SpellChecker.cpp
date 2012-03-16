#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include "SpellChecker.h"
#include "BST.h"

using namespace std;

SpellChecker::SpellChecker() {}
SpellChecker::~SpellChecker() {}

void SpellChecker::BuildTree(string path) {
	fstream file = loadFile(path);
	string line;
	int i = 0;

	// grab words from the dictionary file and insert into
	// an array
	while(file.good()) {
		getline(file, line);
		this->arrDictionary[i] = line;
		i++;
	}

	// build a tree with the array
	this->tree = this->setTree(arrDictionary, i);
}

void SpellChecker::loadSampleData() {
	//first we'll load sample data file
	fstream fileSample = loadFile("sample.txt");
	string line;
	int i = 0;
	
	while(fileSample.good()) {
		getline(fileSample, line); // grab line from file buffer
		sanitizeLine(line); // remove special characters
		istringstream word(line); // split up the line into individual words
		do {
			string sub; // string buffer
			word >> sub; // 
			arrSample[i] = stringToLower(sub);
			i++;
		} while(word);
		arrSample[i+1] = "\0"; 
	}
}

void SpellChecker::loadMistakeData() {
	//first we'll load sample data file
	fstream fileMistake = loadFile("mispelled.txt");
	string line;
	int i = 0;
	
	while(fileMistake.good()) {
		getline(fileMistake, line); // grab line from file buffer
		sanitizeLine(line); // remove special characters
		istringstream word(line); // split up the line into individual words
		do {
			string sub; // string buffer
			word >> sub; // 
			arrMistake[i] = stringToLower(sub);
			i++;
		} while(word);
		arrMistake[i+1] = "\0";
	}
}

fstream SpellChecker::loadFile(string path) {
	return fstream(path, ios::in);
}

BST SpellChecker::setTree(string dictionary[], int length) {
	return BST(dictionary, length); // return a tree object
}

BST SpellChecker::printTree() {
	return this->tree;
}

bool SpellChecker::spellCheckSample() {
	bool correct = true;
	
	int i = 0;
	int j = 0;

	while(arrSample[i] != "\0") { // while index hasn't reached the '\0' element
		if(!isNumber(arrSample[i])) { // skip if this element is a number
			if(this->tree.searchTree(arrSample[i]) == false) { 
				// if this tree can't find the value in this element, we've found a misspelling.
				correct = false; // return false
				this->arrNonTreeItems[j] = arrSample[i]; // add this misspelled word to the array
				j++; // increment 
			}
			
		}
		i++;
		arrNonTreeItems[j+1] = "\0"; // add the '\0' to the last element of the arrNonTreeItem array.
	}
	return correct;
}

bool SpellChecker::spellCheckMistake() {
	bool correct = true;
	
	int i = 0;
	int j = 0;

	while(arrMistake[i] != "\0") { // while index hasn't reach the '\0' element
		if(!isNumber(arrMistake[i])) { // skip if this element is a number
			if(this->tree.searchTree(arrMistake[i]) == false) { 
				// if this tree can't find the value in this element, set to false and add to arrNonTreeItems
				correct = false;
				this->arrNonTreeItems[j] = arrMistake[i];
				j++;
			}
			
		}
		arrNonTreeItems[j+1] = "\0";
		i++;
	}
	return correct;
}

string SpellChecker::sanitizeLine(string& line) {
	size_t special_character;
	string arrSpecialChars[7] = {"#","(",")","&","\"",",","."}; // array of special characters to ignore
	int i = 0;

	// find the special characters and replace them with a blank character
	while(i < 7) {
		do {
			// find the position of the special character
			special_character = line.find(arrSpecialChars[i]);
			if(special_character != string::npos) {
				// replace the special character with a blank character
				line.replace(special_character, 1, "");
			}
			// keep looping until we find no more instance of the special character
		} while(special_character != string::npos);
		i++;
	}

	// return the sanitized line
	return line;
}

string SpellChecker::stringToLower(string strToConvert)
{//change each element of the string to lower case
   for(unsigned int i=0;i<strToConvert.length();i++)
   {
      strToConvert[i] = tolower(strToConvert[i]);
   }
   return strToConvert;//return the converted string
}

bool SpellChecker::isNumber(string test) {
	istringstream ss(test); // string buffer
	int num; // int variable
	if(ss >> num) { // if the string can be assigned to int num, then its a number.
		return true;
	}
	return false;
}

void SpellChecker::checkNonTreeItems() {
	int i = 0;

	while(arrNonTreeItems[i] != "\0") { 
		cout << arrNonTreeItems[i] << endl;
		i++;
	}
}

void SpellChecker::clearNonTreeItems() {
	int i = 0;

	// clear out the array
	while(arrNonTreeItems[i] != "\0") {
		arrNonTreeItems[i] = "";
		i++;
	}
	arrNonTreeItems[i+1] = ""; // get rid of \0
}