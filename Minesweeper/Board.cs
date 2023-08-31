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
