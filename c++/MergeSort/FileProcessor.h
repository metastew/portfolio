#ifndef _FILEPROCESSOR_H
#define _FILEPROCESSOR_H

#include <iostream>
#include <fstream>
#include "Employee.h"

using namespace std;

class FileProcessor {
private:
	fstream lineCount;
	fstream fileIn;
	int count;
	Employee *employees;

public:
	FileProcessor(string path);
	~FileProcessor();

	int getLineCount();
	void populateEmployees();
	Employee * getEmployees();

	void dumparray(Employee *ary, int len, int field);
	int merge(Employee *outarray, int *outsize,
			  Employee *inarray1, int insize1,
			  Employee *inarray2, int insize2, int field);
	void split(Employee *inarray, int size, 
		       Employee *outarray1, int *outsize1,
               Employee *outarray2, int *outsize2, int field);
	void mergeSort(Employee *ary, int len, int field);
};

#endif