#include <iostream>
#include "SpellChecker.h"

using namespace std;

int main() {
	SpellChecker spellChecker;

	// test 1: add nodes to binary search tree
	spellChecker.BuildTree("dictionary.txt");

	cout << spellChecker.printTree() << endl;

	spellChecker.loadSampleData();
	spellChecker.loadMistakeData();

	cout << "SpellChecker will now check two files for any spelling errors..." << endl;
	cout << "\nChecking Sample Data (0:false, 1:true):" << endl;
	cout << spellChecker.spellCheckSample() << endl;
	cout << "\nChecking for misspelled words in Sample Data: " << endl;
	spellChecker.checkNonTreeItems();
	cout << "\nChecking Misspelled Data (0:false, 1:true):" << endl;
	cout << spellChecker.spellCheckMistake() << endl;
	cout << "\nChecking for misspelled words in Misspelled Data: " << endl;
	spellChecker.checkNonTreeItems();
	cin.get();

	return 0;
}