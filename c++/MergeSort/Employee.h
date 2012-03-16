#ifndef _EMPLOYEE_H
#define _EMPLOYEE_H

#include <iostream>

using namespace std;

class Employee {
private:
	string _listing[15];

public:
	Employee();
	~Employee();

	string getListing();
	string findListingAt(int index);
	void processData(string line);
	
};

#endif