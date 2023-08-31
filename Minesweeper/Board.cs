namespace telemines.Minesweeper;


class Board 
{
	private Cell[] cells;
	
	public int Height { get; }
	public int Width { get; }
	public int Length { get; }

	public Board(int x, int y) 
	{
		Height = x;
		Width = y;
		Length = Height * Width;

		cells = new Cell[Length];
	}
}
