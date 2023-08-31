using telemines.Minesweper;

namespace telemines;

class Program
{
    static void Main(string[] args)
    {
        try {
            var board = new Board(4, 4);
            for (int i = 0; i < board.Width; ++i) {
                for (int j = 0; i < board.Height; ++i) {
                    board.SetCellAtPosition(i, j, CellType.Num, 4);
                }
            }

            for (int i = 0; i < board.Width; ++i) {
                for (int j = 0; i < board.Height; ++i) {
                    Cell cell = board.GetCellAtPosition(i, j);
                    Console.Writeline("{0}", cell.value);
                }
            }
        } catch(Exception e) {
            Console.Writeline(e.ToString());
        }
    }
}
