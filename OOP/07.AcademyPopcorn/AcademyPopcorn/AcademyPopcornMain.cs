using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startRow; i < startRow+3; i++)
            {
                for (int j = startCol; j < endCol; j++)
                {
                    Block currBlock;
                    if ((i == startRow+3) && (j == startCol+3))
                    {
                        // 10. Test ExplodingBlock
                        currBlock = new ExplodingBlock(new MatrixCoords(i, j));
                    }
                    else if ((i == startRow + 3) && (j == endCol - 3))
                    {
                        // 12. Test the Gift and GiftBlock classes
                        currBlock = new GiftBlock(new MatrixCoords(i, j));
                    }
                    else
                    {
                        currBlock = new Block(new MatrixCoords(i, j));
                    }
                    engine.AddObject(currBlock);
                }
            }

            // Is comment to test Meteorite Ball
            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));
            //engine.AddObject(theBall);

            // Is comment to test Unstoppable Ball
            // 7. Test the MeteoriteBall by replacing the normal ball 
            Ball theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theMeteoriteBall);

            // Is commented to test ExplodingBlocks
            // 9. Test the UnpassableBlock and the UnstoppableBall
            //Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theUnstopableBall);

            //for (int col = WorldCols / 2; col < WorldCols; col++)
            //{
            //    engine.AddObject(new UnpassableBlock(new MatrixCoords(4, col)));
            //}
            
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);

            // 1. The AcademyPopcorn class contains an IndestructibleBlock class. 
            // Use it to create side and ceiling walls to the game. 
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock leftWallBlock = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(leftWallBlock);
                IndestructibleBlock rightWallBlock = new IndestructibleBlock(new MatrixCoords(row, WorldCols-1));
                engine.AddObject(rightWallBlock);
            }
            for (int col = 0; col < WorldCols; col++)
            {
                IndestructibleBlock upWallBlock = new IndestructibleBlock(new MatrixCoords(0, col));
                engine.AddObject(upWallBlock);
            }

            // 5. Then test the TrailObject by adding an instance of it in the engine through the AcademyPopcornMain.cs file.
            //char[,] symbol = new char[1,1];
            //symbol[0, 0] = '*';
            //TrailObject trail = new TrailObject(new MatrixCoords(5,5), symbol, 10);
            //engine.AddObject(trail);
        }

        static void Main(string[] args)
        {
            // 2. User input speed 
            Console.WriteLine("Enter speed: ");
            int speed = int.Parse(Console.ReadLine());

            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            
            Engine gameEngine = new Engine(renderer, keyboard, speed);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
