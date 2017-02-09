public class Ball extends PongObjs{
	
	//override PongObjs' methods
	public void setPositionX(int x) {
		this.setPosition(x);
	}
	
	public int getPositionX() {
		return this.getPosition();
	}
	
	public void setPositionY(int x) {
		this.setLength(x);
	}
	
	public int getPositionY() {
		return this.getLength();
	}
	
	public Ball(int X, int Y){
		this.setPositionX(X);
		this.setPositionY(Y);
	}
}
