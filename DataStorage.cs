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
        private char devider = '%';
        public DataStorage() { }

        private bool InitData(String datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        name = items[0].Trim(),
                        Part = items[1].Trim(),
                        Group = Convert.ToInt32(items[2].Trim()),
                        Price = Convert.ToSingle(items[3].Trim()),
                        Count = Convert.ToSingle(items[4].Trim())
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
            Dictionary<int, float> tmp = new Dictionary<int, float>();
            foreach (var item in rawdata)
            {
                if (tmp.ContainsKey(item.Group))
                {
                    tmp[item.Group] += item.Summ;
                }
                else
                {
                    tmp[item.Group] = item.Summ;
                }
            }

            sumdata = new List<SummaryDataItem>();
            foreach (var item in tmp)
            {
                sumdata.Add(new SummaryDataItem()
                {
                    GroupName = Utils.GetGroupByNumber(item.Key),
                    GroupSumm = item.Value,
                });
            }
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
