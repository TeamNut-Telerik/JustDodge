namespace Assets.Scripts.Common
{
    using System.IO;

    public static class Stats
    {
        // 0 -> coins
        // 1 -> experience
        // 2 -> maximumspeedugprade
        // 3 -> coinspersecondupgrade
        public static void SaveStats(int coins, int exp)
        {
            using (var writer = new StreamWriter("Assets/stats.txt"))
	        {
                writer.WriteLine("{0} {1}", coins, exp);
	        }
        }

        public static int[] LoadStats()
        {
            int[] result = new int[4];
            using (var reader = new StreamReader("Assets/stats.txt"))
            {
                string[] stats = reader.ReadLine().Split(' ');

                for (int i = 0; i < stats.Length; i++)
                {
                    result[i] = int.Parse(stats[i]);
                }

                return result;
            }
        }
    }
}
