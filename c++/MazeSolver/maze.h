#ifndef _MAZE_H
#define _MAZE_H

#include <iostream>
#include "stack.h"

using namespace std;

const int GRID_X = 51;
const int GRID_Y = 51;

class Maze{
private:
	Stack stack;
protected:
	// load file that contains 25x25 maze into grid array
	char grid[GRID_X][GRID_Y];
	bool created;
public:
	// Maze constructor and destructor
	Maze();
    ~Maze();

	// function to load file into grid array
	void loadMaze(string file);
	
	// output operator to print maze
	void printMaze();

	// find path to end of maze
	void enterCoord(int x, int y);

	// return a boolean value for coordinates on the maze
	bool validCoordinates(int x, int y);

	// for testing filling whitespace only
	void fill();

	// for solving the maze
	void findPath();

	bool atEndOfPath();
};

#endif