namespace telemines.Minesweeper;


class Board 
{
	private Cell[] cells;
	
	public int Height { get; }
	public int Width { get; }
	public int Length { get; }

	public Board(int x, int y) 
	{
		X = x;
		Y = y;
		Length = X * Y;

		cells = new Cell[Length];
	}
}
