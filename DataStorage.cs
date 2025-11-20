using System.Text;

namespace software_lab7
{
    internal class DataStorage
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }

        private List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private char devider = '*';
        public DataStorage() { }

        private bool InitData(string datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        BuildingType = items[0].Trim(),
                        RoomCount = Convert.ToInt32(items[1].Trim()),
                        Area = Convert.ToSingle(items[2].Trim()),
                        Price = Convert.ToSingle(items[3].Trim())
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummary();
            }
            catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        private void BuildSummary()
        {
            var summaryDict = new Dictionary<string, SummaryDataItem>();

            foreach (var item in rawdata)
            {
                if (summaryDict.ContainsKey(item.BuildingType))
                {
                    summaryDict[item.BuildingType].TotalPrice += item.Price;
                    summaryDict[item.BuildingType].ObjectCount += 1;
                }
                else
                {
                    summaryDict[item.BuildingType] = new SummaryDataItem()
                    {
                        BuildingType = item.BuildingType,
                        TotalPrice = item.Price,
                        ObjectCount = 1
                    };
                }
            }

            sumdata = summaryDict.Values.ToList();
        }

        public static DataStorage DataCreator(String path)
        {

            DataStorage d = new DataStorage();
            if (d.InitData(path))
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public List<RawDataItem> GetRawData()
        {

            if (this.IsReady)
            {
                return rawdata;
            }
            else
            {
                return null;
            }
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
            {
                return sumdata;
            }
            else
            {
                return null;
            }
        }
    }
}
