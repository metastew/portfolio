#include <iostream>
#include <fstream>
#include "maze.h"

using namespace std;

int main() {

	Maze maze;
	
	maze.loadMaze("files/maze.txt");
	
	maze.printMaze();

	maze.findPath();
	
	maze.printMaze();

	cin.ignore();
	cin.get();

	return 0;
}