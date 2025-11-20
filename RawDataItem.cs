namespace software_lab7
{
    internal class RawDataItem
    {
        public string BuildingType { get; set; }
        public int RoomCount { get; set; }
        public float Area { get; set; }
        public float Price { get; set; }
        public float PricePerSquareMeter
        {
            get { return Area > 0 ? Price / Area : 0; }
        }
    }
}
