namespace telemines.Minesweper;


enum CellType {
    Mine, 
    Num,
}

struct Cell
{
    public CellType type;
    public int? value; 
}