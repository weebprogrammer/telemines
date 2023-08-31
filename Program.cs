namespace telemines;

using telemines.Minesweeper;


class Program
{
    static void Main(string[] args)
    {
        try {
            var board = new Board(4,4);
            board.ForEachCell((cell) => {
                cell.type = CellType.Num;
                cell.value = 5;
                return cell;
            });

            board.ForEachCell((cell) => {
                
            });
        } catch(Exception e) {
            Console.WriteLine(e.ToString());
        }
    }
}
