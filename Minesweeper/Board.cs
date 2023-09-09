namespace telemines.Minesweeper;


public class Board 
{
	private Cell[] cells;
	
	public int Height { get; init; }
	public int Width { get; init; }

	public Board(int x, int y) 
	{
		Height = x;
		Width = y;

		cells = new Cell[Height * Width];
	}

	public Cell GetCellPosition(int x, int y)
	{
		return cells[(x * Width)+y];
	}

	public void SetCellPosition(int x, int y, CellType type, int? value = null)
	{
		cells[x * Width)+y].type = type;
		cells[x * Width)+y].value = value;
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
