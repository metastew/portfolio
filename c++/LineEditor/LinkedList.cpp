#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <iterator>
#include <algorithm>
#include <vector>

using namespace std;

class Node {
public:
	string data;	
	Node *next;

	//Default Constructor
	Node() : data(""), next(NULL) {}
};

class LinkedList {
private:
	Node *start;
public:
	LinkedList() : start(NULL) {}

	void Add(string data) {
		Node *newNode = new Node();
		newNode->data = data;

		if(start == NULL) {
			// case where no node exist
			start = newNode;
		} else {
			Node *node = start;
			Node *prev = NULL;

			while( node != NULL) {
				prev = node;
				node = node->next;
			}

			prev->next = newNode;
		}
	}

	void Delete(int index) {
		// delete the line at line n
		Node *node = start;
		Node *prev = NULL;

		int count = 1;
		while(node != NULL) {
			if(count == index) {
				break;
			} else {
				count++;
			}
		
			prev = node;
			node = node->next;
		}
		

		if(node != NULL) {
			if(prev == NULL) {
				//at start node
				start = node->next;
			} else {
				//not the start node
				prev->next = node->next;
			}

			delete node;
		}
	}

	void Delete(int index, int range) {
		// overloaded Delete function if two parameters are given 
		// this function isn't working at the moment
		Node *node = start;
		Node *prev = NULL;

		int count = index;
		int i = 0;

		while(node != NULL) {
			if(i == count) {
				while(count < (index+range)) {
					if(node != NULL) {
						if(prev == NULL) {
							//at start node
							start = node->next;
						} else {
							//not the start node
							prev->next = node->next;
						}

						delete node;

						prev = node;
						node = node->next;

						count++;
					} 
				}
			} else {
				// if i isn't within range, keep running
				i++;
				prev = node;
				node = node->next;
				if(node == NULL) {
					// if i has reached end of range, break
					break;
				}	
			}
		}
	}
				

	
	void Insert(string data, int index) {
		// function for inserting a node at a specific spot in the Linked List
		Node *newNode = new Node();
		newNode->data = data;

		Node *node = start;
		Node *prev = NULL;

		int counter = 1;

		while (node != NULL) {
			if(counter == index) {
				break;
			} else {
				counter++;
			}

			prev = node;
			node = node->next;
		}

		if( node != NULL) {
			if( prev == NULL) {
				newNode->next = start;
				start = newNode;
			} else {
				newNode->next = prev->next;
				prev->next = newNode;
			}
		}
	}

	int Size() {
		// return the size of the linked list
		Node *node = start;

		int count = 1;
		while(node != NULL) {
			count++;
			node = node->next;
		}

		return count;
	}

	void Listing() {
		// display all the nodes
		Node *node = start; 

		int count = 1;
		while(node != NULL) {
			cout << count << ">" << node->data << endl;
			node = node->next;
			count++;
		}
	}

	void Listing(int index) {
		// overloaded Listing function to search for a specific Listing
		Node *node = start;

		int count = 0; 
		while(node != NULL) {
			if(count == index) {
				cout << count << ">" << node->data << endl;
			}

			count++;
			node = node->next;
		}
	}

	void Listing(int index, int range) {
		// overloaded Listing function to search within a range of Listing
		Node *node = start;

		int count = index; 
		while(node != NULL) {
			if(count <= index+range) {
				cout << count << ">" << node->data << endl;
				count++;
			}

			node = node->next;
		}
	}

	void Write(string filename) {
		Node *node = start;
		fstream file(filename, ios::out);
		
		// open the file and add the list per line
		cout << "Saving to file..." << endl;
		while(file && node != NULL) {
			if(file.is_open()) {
				
				file << node->data << endl;
				node = node->next;
			} else {
				cout << "Error Opening file" << endl;
			}
		}
	}

	friend ostream& operator<<( ostream& output, LinkedList& list);

};

ostream& operator<<(ostream& output, LinkedList& list) {
	// format the output to show all nodes in a linked list
	Node *node = list.start;

	while(node != NULL) {
		output << node->data << endl;

		node = node->next;
	}

	return output;
}

vector<string> splitSentence(string input) {
	//this function returns a vector
	vector<string> cmd;
	istringstream issInput(input);
	//extract one word at a time, using whitespace as a delimiter, and insert them into a vector.
	copy(istream_iterator<string>(issInput), istream_iterator<string>(),back_inserter<vector<string> >(cmd));

	return cmd;
}

int main() {

	LinkedList list;
	string input;
	string filename;
	string line;
	fstream file;
	bool menu = false;

	do{
		// stay in limbo until 'EDIT' is input
		getline(cin, input);

		//initialize a vector to accept parameters
		vector<string> cmd;

		//spliting the input using whitespace as a delimiter into a string vector of parameters
		cmd = splitSentence(input);

		//initalizing iterator for the vector cmd
		vector<string>::iterator i;

		//cout << "cmd contains: ";
		if(cmd[0] == "EDIT") {
			if(cmd.size() > 1) {
				filename = cmd[1];

				// try to open an existing file
				file.open(filename, ios::in);

				// check file status
				if(!file.is_open()) {
					// create a new file
					file.open(filename, ios::out);
					cout << "Creating New File" << endl;
				} else {
					// extract lines from the existing file
					cout << "Existing file found" << endl;
					while(file.good()) {
						getline(file, line);
						list.Add(line);
					}
				}

				// close the file since we already extracted all the lines from it
				file.close();

				bool submenu = false;
				string subInput = "";
				vector<string> subCmd;

				do{

					// loop EDIT mode
					cout << list.Size() << ">";
					getline(cin, subInput);

					// no need to use subCmd if input is blank
					if(subInput != "") {
						// initalize a vector to accept commands and parameter in EDIT mode
						subCmd = splitSentence(subInput);

						if(subCmd[0] == "I") {
							if(subCmd.size() == 1) {
								// insert into current line
								cout << list.Size() << ">";
								getline(cin, subInput);
								list.Insert(subInput, list.Size());
							} else if(subCmd.size() == 2) {
								// initialize a integer variable
								int numberInput;
								// create a buffer for integer conversion
								stringstream buffer(subCmd[1]);
								// if buffer is validated as an integer, proceed to insert a line at n, otherwise break
								if(buffer >> numberInput) {
									if(numberInput < list.Size()) {
										// insert into line n
										cout << numberInput << ">";
										getline(cin, subInput);
										list.Insert(subInput, numberInput);
									} else {
										cout << "This line doesn't exist!" << endl;
									}
								} else {
									// if no command is detected, create a node and add the string input
									list.Add(subInput);
								}
							} else if(subCmd.size() > 2) {
								// throw an error when too many parameters is entered for 'I'
								list.Add(subInput);
							}
						} else if(subCmd[0] == "L") {
							// Listing Command
							if(subCmd.size() == 3) {
								// initialize integer variables
								int numberInput1;
								int numberInput2;
								// create buffers for integer conversion
								stringstream buffer1(subCmd[1]);
								stringstream buffer2(subCmd[2]);
								// if buffers are validated as integers and numberInputs aren't out of bounds with Linked List, proceed to insert a line at n, otherwise break
								if(buffer1 >> numberInput1) {
									if(buffer2 >> numberInput2) {
										if(numberInput1 < list.Size() && numberInput1 < numberInput2) {
											if(numberInput2 <= list.Size()) {
												list.Listing(numberInput1, numberInput2 - numberInput1);
											} else {
												// throw an error when numberInput2 exceeds the size of Linked List
												cout << "The parameter " << numberInput2 << " is out of bounds with Linked List" << endl;
												cout << endl;
											}
										} else {
											// throw an error when numberInput1 exceeds the size of Linked List
											cout << "The parameter " << numberInput1 << " is either out of bounds with Linked List or is greater than the 2nd parameter" << endl;
											cout << endl;
										}
									} else {
										// if no command is detected, create a node and add the string input
										list.Add(subInput);
									}
								} else {
									// if no command is detected, create a node and add the string input
									list.Add(subInput);
								}
							} else if(subCmd.size() == 2) {
								// initialize a integer variable
								int numberInput;
								// create a buffer for integer conversion
								stringstream buffer(subCmd[1]);
								// if buffer is validated as an integer, proceed to insert a line at n, otherwise break
								if(buffer >> numberInput) {
									if(numberInput <= list.Size()) {
										list.Listing(numberInput);
									} else {
										// throw an error when numberInput exceeds the size of Linked List
										cout << "The parameter " << numberInput << " is out of bounds with Linked List" << endl;
										cout << endl;
									}
								} else {

									list.Add(subInput);
								}
							} else if(subCmd.size() == 1) {
								list.Listing();
							}
						} else if(subCmd[0] == "D") {
							// Delete Command
							if(subCmd.size() == 3) {
								// initialize integer variables
								int numberInput1;
								int numberInput2;
								// create buffers for integer conversion
								stringstream buffer1(subCmd[1]);
								stringstream buffer2(subCmd[2]);
								// validate the 2 parameters as integer first, then check if they are out of bounds in linked list, then proceed if everything checks out fine.
								if(buffer1 >> numberInput1) {
									if(buffer2 >> numberInput2) {
										if(numberInput1 < list.Size() && numberInput1 < numberInput2) {
											if(numberInput2 <= list.Size()) {
												//list.Delete(numberInput1, numberInput2-numberInput1);
												cout << "This functionality has been temporarily disabled" << endl;
											} else {
												// throw an error when numberInput2 exceeds the size of Linked List
												cout << "The parameter " << numberInput2 << " is out of bounds with Linked List" << endl;
												cout << endl;
											}
										} else {
											// throw an error when numberInput1 exceeds the size of Linked List
											cout << "The parameter " << numberInput1 << " is out of bounds with Linked List or is greater than the 2nd parameter" << endl;
											cout << endl;
										}
									} else {
										// if no command is detected, create a node and add the string input
										list.Add(subInput);
									}
								} else {
									// if no command is detected, create a node and add the string input
									list.Add(subInput);
								}
							} else if(subCmd.size() == 2) {
								// initialize a integer variable
								int numberInput;
								// create a buffer for integer conversion
								stringstream buffer(subCmd[1]);
								// if buffer is validated as an integer, proceed to insert a line at n, otherwise break
								if(buffer >> numberInput) {
									if(numberInput <= list.Size()) {
										// delete the line at n
										list.Delete(numberInput);
									} else {
										// throw an error when numberInput exceeds the size of Linked List
										cout << "The parameter " << numberInput << " is out of bounds with Linked List" << endl;
										cout << endl;
									}
								} else {
									// command isn't recognized in this input
									list.Add(subInput);
								} 
							} else if(subCmd.size() == 1) {
								// delete the current line
								list.Delete(list.Size()-1);
							} 
						} else if(subCmd[0] == "E") {
							// save the list to a file
							list.Write(filename);
							// break out of both loops to exit the program
							submenu = true;
							menu = true;
						} else {
							// if no command is detected, create a node and add the string input
							list.Add(subInput);
						}
					} else {
						// if no command is detected, create a node and add the string input
						list.Add(subInput);
					}

				} while(!submenu);

			} else {
				cout << "You must supply a file pathname!" << endl;		
			}

		} else {
			cout << "Invalid command!" << endl;
		}
	} while(!menu);

	cin.sync();
	cin.get();

	return 0;
}