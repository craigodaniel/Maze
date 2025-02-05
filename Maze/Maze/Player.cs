using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Maze
{
    public class Player
    {
        public bool IsAlive { get; set; }
        public ConsoleColor PlayerColor { get; set; }
        public ConsoleColor PathColor { get; set; }
        public List<Coordinate> MoveList { get; set; }
        public List<Coordinate> VisitedCells { get; set; }
        
        

    }
}
