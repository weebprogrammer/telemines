namespace telemines.Minesweeper;


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

	public Cell GetCellAtPosition(int x_position, int y_position)
	{
		return cells[x_position * y_position];
	}

	public void SetCellAtPosition(int x_position, int y_position, CellType type, int? value = null)
	{
		cells[x_position * y_position].type = type;
		cells[x_position * y_position].value = value;
	}
}
