#include <iostream>
#include <fstream>
#include <string>
#include "FileProcessor.h"

using namespace std;

FileProcessor::FileProcessor(string path) {
	this->lineCount.open(path, ios::in);
	this->fileIn.open(path, ios::in);
	this->count = 0;
}
FileProcessor::~FileProcessor() { }

int FileProcessor::getLineCount() {
	// return line count in the sample employee data file
	return count;
}

void FileProcessor::populateEmployees() {
	string line1;

	// grab the line count of the file
	while(this->lineCount.good()) {
		getline(lineCount, line1);
		count++;
	}

	// init an array of Employee objects with a length of count value
	this->employees = new Employee[this->count];

	int i = 0;
	string line2;

	// grab one line, process it into an Employee object, add it to the array, and then repeat with next line
	while(this->fileIn.good()) {
		Employee employee;
		getline(this->fileIn, line2);
		employee.processData(line2);
		this->employees[i] = employee;
		i++;
	}
}

Employee * FileProcessor::getEmployees() {
	// return an array of Employee objects
	return this->employees;
}

void FileProcessor::dumparray(Employee *ary, int len, int field)
{
	// grab the field value as an index within the Employee's _listing array
    int i;
    for( i=0; i<len-1; i++ )
    {
		Employee employee = ary[i];
        cout << employee.findListingAt(field) << ",";
    }
	Employee employee = ary[i];
    cout << employee.findListingAt(field) << endl;
}

void FileProcessor::split(Employee *inarray, int size, 
           Employee *outarray1, int *outsize1,
           Employee *outarray2, int *outsize2, int field)
{
    int numSubFiles = 0;

    int in = 0;
    *outsize1 = 0;
    *outsize2 = 0;

    Employee curr;
    Employee next = inarray[in++];

    while( in <= size )
    {
        // find a pre-sorted sub-file
        do
        {
           curr = next;

           if( in < size )
           {
               next = inarray[in];
           }
           in++;

           if( numSubFiles % 2 == 0 )
           {
               // move into first temp file
               outarray1[(*outsize1)++] = curr;
           }
           else
           {
               // move into second temp file
               outarray2[(*outsize2)++] = curr;
           }
        }
        while( (curr.findListingAt(field) < next.findListingAt(field)) && (in <= size) );

        numSubFiles++;
    }
}

int FileProcessor::merge(Employee *outarray, int *outsize,
          Employee *inarray1, int insize1,
          Employee *inarray2, int insize2, int field)
{
    int subFiles = 0;

    int in1 = 0;
    int in2 = 0;
    *outsize = 0;

    Employee curr1;
    Employee curr2;

    Employee prev1;
    Employee prev2;

    // get first elements from each temp file
    curr1 = inarray1[in1++];
    curr2 = inarray2[in2++];

    // loop until we have hit the end of one of the temp files
    while( in1 <= insize1 && in2 <= insize2 )
    {
        bool endOfSub1 = false;
        bool endOfSub2 = false;

        // find subfile
        while( !endOfSub1 && !endOfSub2 )
        {
            if( curr1.findListingAt(field) < curr2.findListingAt(field) )
            {
                // temp file 1 element comes first
                outarray[(*outsize)++] = curr1;
                prev1 = curr1;
                if( in1 < insize1 )
                {
                    curr1 = inarray1[in1];
                }
                in1++;

                // was the end of a sub-file hit?
                if( (in1 > insize1) || (prev1.findListingAt(field) > curr1.findListingAt(field)) )
                {
                    endOfSub1 = true;
                }
            }

            if( curr2.findListingAt(field) < curr1.findListingAt(field) )
            {
                // temp file 2 element comes first
                outarray[(*outsize)++] = curr2;
                prev2 = curr2;
                if( in2 < insize2 )
                {
                    curr2 = inarray2[in2];
                }
                in2++;

                // was the end of a sub-file hit?
                if( (in2 > insize2) || (prev2.findListingAt(field) > curr2.findListingAt(field)) )
                {
                    endOfSub2 = true;
                }
            }

        }

        // dump remaining elements in temp 1 that exist in the sub-file
        while( !endOfSub1 )
        {
            outarray[(*outsize)++] = curr1;
            prev1 = curr1;
            if( in1 < insize1 )
            {
                curr1 = inarray1[in1];
            }
            in1++;

            if( (in1 > insize1) || (prev1.findListingAt(field) > curr1.findListingAt(field)) )
            {
                endOfSub1 = true;
            }
        }

        // dump remaining elements in temp 2 that exist in the sub-file
        while( !endOfSub2 )
        {
            outarray[(*outsize)++] = curr2;
            prev2 = curr2;
            if( in2 < insize2 )
            {
                curr2 = inarray2[in2];
            }
            in2++;

            if( (in2 > insize2) || (prev2.findListingAt(field) > curr2.findListingAt(field)) )
            {
                endOfSub2 = true;
            }
        }

		subFiles++;
    }


    // dump remaining elements from temp 1 into merged array
    while( in1 <= insize1 )
    {
        outarray[(*outsize)++] = curr1;
        prev1 = curr1;
        if( in1 < insize1 )
        {
            curr1 = inarray1[in1];
        }
        in1++;

        // keep track of any sub-files in remaining elements
        if( (in1 > insize1) || (prev1.findListingAt(field) > curr1.findListingAt(field)) )
        {
            subFiles++;
        }
    }

    // dump remaining elements from temp 2 into merged array
    while( in2 <= insize2 )
    {
        outarray[(*outsize)++] = curr2;
        prev2 = curr2;
        if( in2 < insize2 )
        {
            curr2 = inarray2[in2];
        }
        in2++;

        // keep track of any sub-files in remaining elements
        if( (in2 > insize2) || (prev2.findListingAt(field) > curr2.findListingAt(field)) )
        {
            subFiles++;
        }
    }

	cout << "subfiles: " << subFiles << endl;

    return subFiles;
}

void FileProcessor::mergeSort(Employee *ary, int len, int field)
{
    int subFiles = 0;
    Employee *temp1 = new Employee[len];
    Employee *temp2 = new Employee[len];
    int tempsize1;
    int tempsize2;

    do
    {
        split(ary, len, temp1, &tempsize1, temp2, &tempsize2, field);

        cout << "Split" << endl;
        cout << "temp1: ";
        dumparray(temp1, tempsize1, field);
        cout << "temp2: ";
        dumparray(temp2, tempsize2, field);

        subFiles = merge(ary, &len, temp1, tempsize1, temp2, tempsize2, field);

        cout << "Merge" << endl;
        dumparray(ary, len, field);
    }
    while( subFiles != 1 );

    delete [] temp1;
    delete [] temp2;
}