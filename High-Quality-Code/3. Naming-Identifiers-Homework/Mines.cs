using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
	public class Mines
    {
        public static void Main()
		{
            const int emptyFields = 35;
            string command = string.Empty;
			char[,] field = createGamingField();
			char[,] bombs = putBombs();
			int counter = 0;
			bool hitBomb = false;
			List<Score> champions = new List<Score>(6);
			int row = 0;
			int col = 0;
            bool isSGameOver = true;
			bool isGameEnd = false;

			do
			{
                if (isSGameOver)
				{
                    Console.WriteLine("Let's play “Minesweeper”. Try your luck to find all fields without mines." +
					"Command 'top' shows ranking, 'restart' start new game, 'exit' quit game and bye-bye!");
					dump(field);
                    isSGameOver = false;
				}
                Console.Write("Write row and column: ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out col) &&
						row <= field.GetLength(0) && col <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						Ranking(champions);
						break;
					case "restart":
						field = createGamingField();
						bombs = putBombs();
						dump(field);
						hitBomb = false;
                        isSGameOver = false;
						break;
					case "exit":
						Console.WriteLine("Bye-bye!");
						break;
					case "turn":
						if (bombs[row, col] != '*')
						{
							if (bombs[row, col] == '-')
							{
								tisinahod(field, bombs, row, col);
								counter++;
							}
							if (emptyFields == counter)
							{
                                isGameEnd = true;
							}
							else
							{
								dump(field);
							}
						}
						else
						{
							hitBomb = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Invalid command\n");
						break;
				}
				if (hitBomb)
				{
					dump(bombs);
					Console.Write("\nHrrrrrr! Game over! {0} points. " +
						"Write your alias: ", counter);
					string alias = Console.ReadLine();
					Score rank = new Score(alias, counter);
					if (champions.Count < 5)
					{
                        champions.Add(rank);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
							if (champions[i].Points < rank.Points)
							{
								champions.Insert(i, rank);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
                    champions.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
					Ranking(champions);

					field = createGamingField();
					bombs = putBombs();
					counter = 0;
					hitBomb = false;
                    isSGameOver = true;
				}
                if (isGameEnd)
				{
					Console.WriteLine("\n Congratulations! You open 35 fields.");
					dump(bombs);
					Console.WriteLine("Write your alias: ");
					string alias = Console.ReadLine();
                    Score rank = new Score(alias, counter);
                    champions.Add(rank);
					Ranking(champions);
					field = createGamingField();
					bombs = putBombs();
					counter = 0;
                    isGameEnd = false;
                    isSGameOver = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("Bye-bye!");
			Console.Read();
		}

		private static void Ranking(List<Score> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} points",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty ranking\n");
			}
		}

		private static void tisinahod(char[,] field, char[,] bomb, int row, int col)
		{
			char bombAmount = showMinesAmount(bomb, row, col);
            bomb[row, col] = bombAmount;
            field[row, col] = bombAmount;
		}

		private static void dump(char[,] board)
		{
			int maxRow = board.GetLength(0);
			int maxCol = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
            for (int i = 0; i < maxRow; i++)
			{
				Console.Write("{0} | ", i);
                for (int j = 0; j < maxCol; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] createGamingField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] putBombs()
		{
			int maxRows = 5;
			int maxCols = 10;
            char[,] gamingField = new char[maxRows, maxCols];

			for (int row = 0; row < maxRows; row++)
			{
				for (int col = 0; col < maxCols; col++)
				{
                    gamingField[row, col] = '-';
				}
			}

			List<int> mapBombs = new List<int>();
			while (mapBombs.Count < 15)
			{
				Random random = new Random();
				int randomLocation = random.Next(50);
                if (!mapBombs.Contains(randomLocation))
				{
                    mapBombs.Add(randomLocation);
				}
			}

			foreach (int bompPlace in mapBombs)
			{
                int col = (bompPlace / maxCols);
                int row = (bompPlace % maxCols);
                if (row == 0 && bompPlace != 0)
				{
					col--;
					row = maxCols;
				}
				else
				{
					row++;
				}
                gamingField[col, row - 1] = '*';
			}

            return gamingField;
		}

        private static char showMinesAmount(char[,] field, int row, int col)
		{
			int amount = 0;
			int maxRows = field.GetLength(0);
			int maxCols = field.GetLength(1);

			if (row - 1 >= 0)
			{
				if (field[row - 1, col] == '*')
				{
                    amount++; 
				}
			}
			if (row + 1 < maxRows)
			{
				if (field[row + 1, col] == '*')
				{
                    amount++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (field[row, col - 1] == '*')
				{
                    amount++;
				}
			}
            if (col + 1 < maxCols)
			{
				if (field[row, col + 1] == '*')
				{
                    amount++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (field[row - 1, col - 1] == '*')
				{
                    amount++; 
				}
			}
            if ((row - 1 >= 0) && (col + 1 < maxCols))
			{
				if (field[row - 1, col + 1] == '*')
				{
                    amount++; 
				}
			}
			if ((row + 1 < maxRows) && (col - 1 >= 0))
			{
				if (field[row + 1, col - 1] == '*')
				{
                    amount++; 
				}
			}
            if ((row + 1 < maxRows) && (col + 1 < maxCols))
			{
				if (field[row + 1, col + 1] == '*')
				{
                    amount++; 
				}
			}
            return char.Parse(amount.ToString());
		}
	}
}
