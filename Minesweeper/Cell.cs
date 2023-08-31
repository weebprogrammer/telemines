namespace telemines.Minesweper;


public enum CellType {
    Mine, 
    Num,
}

public struct Cell
{
    public CellType type;
    public int? value; 
}