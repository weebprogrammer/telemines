namespace Minesweeper;


class Board {
	private Cell[] cells;
	public int x_size;
	public int y_size;
	public int length;

	public Board(int x, int y) {
		x_size = x;
		y_size = y;
		length = x * y;

		cells = new Cell[length];
		
	}
}