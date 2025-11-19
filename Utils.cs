namespace software_lab7
{
    internal class Utils
    {
        private static Dictionary<int, string> dict;
        static Utils()
        {
            if (dict == null)
            {
                dict = new Dictionary<int, string>(5);
                dict.Add(0, "Продукты");
                dict.Add(1, "Бытовая химия");
                dict.Add(2, "Одежда");
                dict.Add(3, "Фрукты");
                dict.Add(4, "Полиграфия");
            }
        }
        public static string GetGroupByNumber(int number)
        {
            if (dict.ContainsKey(number))
            {
                return dict[number];
            }
            else
            {
                return "???";
            }
        }
    }
}
