#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <vector>

#include "Employee.h"
#include "FileProcessor.h"

using namespace std;

int main(int argc, char* argv[])
{
	// parse command line parameters
	int field;

	if(argv > 0 && argv[1] == "-field") {

		if(argv[2]) {
			// create buffer for field parameter
			stringstream number(argv[2]);

			// if number can be inserted into field, it is a number
			if(number >> field) {
				if(field > 0 && field < 16) {
					// for zero-indexing purpose
					field -= 1;
				} else {
					// if field is out of bound
					cout << "Invalid parameter, must be between 1-15!" << endl;
					return -1;
				}
			} else {
				// if field isn't a number
				cout << "Invalid parameter, must be an number between 1-15!!" << endl;
				return -1;
			}
		} else {
			// if field parameter isn't supplied
			cout << "Missing parameter, must supply a number!" << endl;
			return -1;
		}
	} else {
		// if field parameter isn't set, default to 0 for first field
		field = 10;
	}

	// process data
    FileProcessor fileP("employee_sample_data1.txt");
	fileP.populateEmployees();
	Employee *employees = fileP.getEmployees();

	// output the array contents
	for(int k = 0; k < fileP.getLineCount(); k++) {
		cout << employees[k].getListing() << endl;
	}

	// sort file
	fileP.mergeSort(employees, fileP.getLineCount(), field);

	fileP.dumparray(employees, fileP.getLineCount(), field);

	cin.get();
	
	return 0;
}
