namespace Minesweeper;


class Board 
{
	private Cell[] cells;
	
	public int X { get; }
	public int Y { get; }
	public int Length { get; }

	public Board(int x, int y) 
	{
		X = x;
		Y = y;
		Length = X * Y;

		cells = new Cell[Length];
	}
}
