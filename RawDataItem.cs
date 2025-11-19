namespace software_lab7
{
    internal class RawDataItem
    {
        public String name { get; set; }
        public int Group { get; set; }
        public String Part { get; set; }
        public float Price { get; set; }
        public float Count { get; set; }
        public float Summ
        {
            get { return Count * Price; }
        }
    }
}
