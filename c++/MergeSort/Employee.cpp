#include "Employee.h"
#include <iostream>
#include <string>
#include <sstream>

using namespace std;

Employee::Employee() { }
Employee::~Employee() { }

string Employee::getListing() {
	// format _listing array values and return it as a string 
	int index = 1;
	string line = _listing[0];
	while(index < 15) {
		line += "\t" + this->_listing[index];
		index++;
	}

	return line;
}

void Employee::processData(string line) {
	// load line into stringstream buffer
	stringstream linestream(line);
	// init string buffer for value
	string value;
	// init counter for listing
	int index = 0;

	// check for tab, then grab the string value before each tab character, and add them into _listing array
	while(getline(linestream, value, '\t')) {
		this->_listing[index] = value;
		index++;
	}
}

string Employee::findListingAt(int index) {
	// return the field value within _listing[index]
	return this->_listing[index];
}