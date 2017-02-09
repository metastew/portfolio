main.o: main.cpp
	cl main.cpp /Fomain.o
	
FileProcessor.o: FileProcessor.cpp
	cl FileProcessor.cpp /FoFileProcessor.o
	
Employee.o: Employee.cpp
	cl Employee.cpp /FoEmployee.o

makesort.exe: main.o FileProcessor.o Employee.o
	cl main.o FileProcessor.o Employee.o /Fomergesort.exe