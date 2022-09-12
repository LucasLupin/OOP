namespace OOPRPG
{
    internal class Tools
    {
        public static void TextColor(int total, int min, int max)
        {
            if (total - min < (max - min) * 0.3) Console.ForegroundColor = ConsoleColor.Red;
            else if (total - min < (max - min) * 0.7) Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(total);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //TODO Show result bool?
        public static int RollDices(int dices, int sides, int dice)
        {
            Random random = new Random();
            int total = 0;
            if (dice == 1) total = random.Next(0, sides) + 1;
            else
            {
                for (int i = 0; i < dice; i++)
                {
                    int die = random.Next(0, sides) + 1;
                    Console.Write($" {die}");
                    total += die;
                }
                Console.Write(" = ");
            }
            Tools.TextColor(total, dice, dice * sides);
            return total;
        }

        internal static int RollDices(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
