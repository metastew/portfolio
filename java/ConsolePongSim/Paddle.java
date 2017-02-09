public class Paddle extends PongObjs{
	//will use the methods from PongObjs class
	public Paddle(int position, int length){
		this.setPosition(position);
		this.setLength(length);
		if((this.getPosition() + this.getLength()) > 50) {
			this.setPosition(position - length);
		}
	}
	
//	public String drawPaddle(){
//		String paddle="";
//		for(int x=0;0<=this.getPosition();x++){//this gets the number of spaces you need
//			paddle+=" ";
//		}
//		for(int x=0;0<=this.getLength();x++){//this gets the number of X's for the paddle you need
//			paddle+="X";
//		}
//	return paddle;
//	}
}
