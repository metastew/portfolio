#include <iostream>
#include <fstream>
#include <string>

#include "maze.h"

using namespace std;

Maze::Maze() {
}

Maze::~Maze() {
	delete [] grid;
}

void Maze::loadMaze(string filePath) {
	// initialize a file buffer
	fstream input;
	string strLine;
	created = false;

	// load maze into the file buffer
	input.open(filePath);

	/* 
	if file doesn't exist, abort.
	Otherwise, load the maze one line at a time
	into the grid array, validating each line to 
	make sure each have 51 chars. 
	*/
	if(!input) {
		cout << "File not found!" << endl;
	} else {
		int count = 0;
		while(input.good()) {
			getline(input, strLine);
			if(strLine.length() == 51) {
				//char *getLine = new char[strLine.size()];
				//copy(strLine.begin(), strLine.end(), getLine);
				//getLine[strLine.size()] = '\0';

				for(int x = 0; x < 51; x++){
					grid[x][count] = strLine[x];
				}
				count++;
			} else {
				cout << "One or more strings are less than or exceeds the 51 char limit." << endl;
				break;
			}
			created = true;
		}
	}
}

void Maze::printMaze() {
	// print the maze
	if(created) {
		for(int y=0; y < 51; y++) {
			for(int x =0; x <= 50; x++) {
				cout << grid[x][y];
			}
			cout << endl;
		}
	} else {
		cout << "Maze hasn't been initalized yet." << endl;
	}
}

//void Maze::enterCoord(int x, int y) {
//	/*
//	put '#' at coordinate x,y
//	only odd numbers are valid as coordinates
//	*/
//	if(x >= 0 && x <= 50 && y >= 0 && y <= 51) {
//		if(x % 2 != 0 && y % 2 != 0) {
//			if(grid[x][y] != '|' && grid[x][y] != '-' && grid[x][y] != '+') {
//				grid[x][y] = '#';
//			} else {
//				cout << "Error, this space is occupied by a wall." << endl;
//			}
//		} else {
//			cout << "Error, one or more of your coordinates aren't odd numbers" << endl;
//		}
//	} else {
//		cout << "Error, your coordinates are out of bounds." << endl;
//	}
//}

bool Maze::validCoordinates(int x, int y) {
	if(grid[x][y] == ' ') {
		if(x % 2 != 0 && y % 2 != 0) {
			return true;
		} else return false;
	} else return false;
}

// testing logic
void Maze::fill() {
	for(int y = 0; y < 51; y++) {
		for(int x = 0; x < 50; x++) {
			if(x % 2 != 0 && y % 2 != 0) {
				if(grid[x][y] == ' ') {
					grid[x][y] = '#';
				}
			}
		}
	}
}

void Maze::findPath() {
	if(stack.get_First() == NULL) {
		//push (1,1) to stack, since the path always start from top-right
		stack.Push(1,1);
		grid[1][1] = '#';
	}

	bool done = false;
	StackNode initial = *stack.get_First();
	StackNode recent = *stack.get_Last();

	//starting from 1,1 
	int x =1;
	int y =1;	
	do{

		// go right
		while(grid[x+1][y] != '|' && grid[x+1][y] != '#' &&x < 50) {
			if(x % 2 != 0) {
				grid[recent.get_X()][recent.get_Y()] = '#';
				stack.Push(recent.get_X(), recent.get_Y());
			}

			recent.set_X(recent.get_X()+1);
			recent.set_Y(recent.get_Y());

			x = recent.get_X();
			y = recent.get_Y();
			
		}
		
		// then go down
		while(grid[x][y+1] != '-' && grid[x][y+1] != '+' && grid[x][y+1] != '#' && y < 51) {
			if(y % 2 != 0) {
				grid[recent.get_X()][recent.get_Y()] = '#';
				stack.Push(recent.get_X(), recent.get_Y());
			}

			recent.set_X(recent.get_X());
			recent.set_Y(recent.get_Y()+1);

			x = recent.get_X();
			y = recent.get_Y();
			
		}

		// then left
		while(grid[x-1][y] != '|' && grid[x-1][y] != '#' && x > 0) {
			if(x % 2 != 0) {
				grid[recent.get_X()][recent.get_Y()] = '#';
				stack.Push(recent.get_X(), recent.get_Y());
			}

			recent.set_X(recent.get_X()-1);
			recent.set_Y(recent.get_Y());

			x = recent.get_X();
			y = recent.get_Y();
			
		}

		// then up
		while(grid[x][y-1] != '-' && grid[x][y-1] != '+' && grid[x][y-1] != '#' && y > 0) {
			if(y % 2 != 0) {
				grid[recent.get_X()][recent.get_Y()] = '#';
				stack.Push(recent.get_X(), recent.get_Y());
			}

			recent.set_X(recent.get_X());
			recent.set_Y(recent.get_Y()-1);

			x = recent.get_X();
			y = recent.get_Y();
			
		}
		cout << stack << endl;
		done = true;
	}while(!done);
}

bool Maze::atEndOfPath() {
	if(grid[50][50] == '#') {
		return true;
	} else return false;
}