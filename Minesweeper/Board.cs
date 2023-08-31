namespace telemines.Minesweeper;


public class Board 
{
	private Cell[] cells;
	
	public int Height { get; }
	public int Width { get; }

	public Board(int x, int y) 
	{
		Height = x;
		Width = y;

		cells = new Cell[Height * Width];
	}

	public Cell GetCellAtPosition(int x_position, int y_position)
	{
		return cells[(x_position * y_position)-1];
	}

	public void SetCellAtPosition(int x_position, int y_position, CellType type, int? value = null)
	{
		cells[(x_position * y_position)-1].type = type;
		cells[(x_position * y_position)-1].value = value;
	}

	public void ForEachCell(Func<Cell, Cell> Action)
	{
		for(int i = 0; i < cells.Length; ++i) {
			c = cells[i];
			var newCell = Action(c);
			cells[i] = newCell;
		}
	}
}
