//Name: Craig Cannon
//Date: Sept. 30, 2011
//Desc: Pong Assignment for Prog4010 Java Programming (Topics: Abstract Class, Object Instances, 2D Array, For Loops, Collision Detection)
//Teacher:  Andrew Mooney
//Course: 702
//File(s) required: Pong.java, Paddle.java, Ball.java, PongObjs.java

import java.util.Random;

public class Pong{

	public static void main(String[] args) throws Throwable {
		Pong p = new Pong();
		p.runStage();
	}

	public void runStage() throws Throwable {
		
		//initalize variables to hold values for position & length of the paddle 
		//and position X & Y of the ball
		int padLen;
		int padPos;
		int ballX;
		int ballY;
		
		//initalize collision message
		String[] collision = {"K", "a","-","P","i","n","g","!"};
		
		//initalize a random object
		Random r = new Random();

		//looping the stage with new random numbers each time
		for(int y=0;y<100;y++) {
			Paddle p = new Paddle((r.nextInt(43)+5), r.nextInt(8)+1);
			Ball b = new Ball(r.nextInt(43)+5, r.nextInt(8)+1);

			//get position and length of paddle
			padLen = p.getLength();
			padPos = p.getPosition();

			//get position X & Y of ball
			ballX = b.getPositionX();
			ballY = b.getPositionY();

			//check to make sure paddle doesn't go out of bound
			if(padPos < 3 || padPos > 50 || ballX < 0 || ballY > 8)  {
				throw new Exception();
			}

			//setting the stage with hardcoded height and width
			String[][] stage = new String[10][50]; 

			//Draw the stage with paddle and ball
			for(int row = 0; row < 10; row++) {
				if(row == 0) {

					//draw the boundary on first row
					for(int col=0; col < 50; col++) {
						stage[row][col] = "=";
					}
				}

				//fill the row with blanks
				else if(row == 2){
					for(int col = 0; col < 50; col++) {
						stage[row][col] = " ";
					}

					//add the paddle to this row
					for(int padDraw = padPos; padDraw < padPos+padLen; padDraw++) {
						stage[row][padDraw] = "X";
					}
				}

				else if(row == 9) {
					//draw the boundary on last row
					for(int col = 0; col < 50; col++) {
						stage[row][col] = "=";
					}
				}
				
				else {
					//fill in the blanks everywhere else
					for(int col=0; col < 50; col++) {
						stage[row][col] = " ";
					}
				}

				//First verify if the ball doesn't occupy the same spot with the paddle, then draw the ball
				if(stage[ballY][ballX] != "X") {
					stage[ballY][ballX] = "O";
				}
				
				else {
					//move the ball one row down
					b.setPositionY(3);
					ballY = b.getPositionY();

					//and display the Ka-Ping! message
					for(int z=0;z<8;z++){
						stage[ballY+1][ballX-3+z] = collision[z];
					}
				}

				//check for collision.... if true, then display Ka-Ping! under the ball
				if(ballY == 3) {
					for(int x=padPos;x<padPos+padLen;x++) {
						if(ballX == x) {
							for(int z=0;z<8;z++){
								stage[ballY+1][ballX-3+z] = collision[z];
							}
						}
					}
				}
			}


			//Print the stage and stats of paddle/ball
			System.out.println("Loop #" + y);
			for(int row = 0; row < 10; row++) {
				for(int col = 0; col < 49; col++) {
					System.out.print(stage[row][col]);
				}
				System.out.print("\n");
			}

			System.out.println("Pad Position: " + padPos + ", Pad Length: " + padLen);
			System.out.println("Ball PosX: " + b.getPositionX() + ", Ball PosY: " + b.getPositionY());
			System.out.print("\n\n\n");
		}
	}
}