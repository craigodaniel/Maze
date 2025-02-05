using Maze.Music;
using Maze.Maze;

Console.WriteLine("Welcome to MAZE!");
Console.WriteLine();
Console.WriteLine("1 - Generate/Solve New Maze");
Console.WriteLine("2 - Fight!");
Console.WriteLine();

while (true)
{
    string input = Console.ReadLine();
    if (input == "1")
    {
        Console.WriteLine("Generating a new maze...");
        Console.WriteLine();

        while (true)
        {
            Console.Clear();
            MazeGenerator.Reset();
            //int[,] maze = MazeGenerator.GenerateMaze(36, 135);
            int[,] maze = MazeGenerator.GenerateMazeGame();
            Console.Beep();
            MazeSolver.WallFollower(maze, MazeSolver.GetTopRightCorner(maze), MazeSolver.GetBottomLeftCorner(maze));
            Console.Beep();

        }
        
    }
    else if (input == "2")
    {
        while (true)
        {
            Console.Clear();
            GameController.NewGame();
            Console.Beep();
        }
        
    }
    //Easter Eggs
    else if (input == "MARY")
    {
        Mary.Main();
    }
    else if (input == "ODE")
    {
        OdeToJoy.Main();
    }
    else if (input == "KING")
    {
        MountainKing.Main();
    }
    else
    {
        Console.WriteLine(input);
    }


}



