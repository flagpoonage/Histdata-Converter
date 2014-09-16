using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricData
{
    public class DataReader
    {
        public StorageStructure Storage { get; set; }

        public DataReader(StorageStructure structure)
        {
            this.Storage = structure;
        }

        private BarData[] ReadData(string directory)
        {
            var dList = new List<BarData>();
            var files = Directory.GetFiles(directory, "*.csv");

            foreach (var file in files)
            {
                using (var sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        var row = sr.ReadLine();
                        var data = new BarData(row);

                        if(data.IsValid)
                        {
                            dList.Add(data);
                        }
                    }
                }
            }

            return dList.ToArray();
        }

        public BarData[] ReadM1Data()
        {
            return this.ReadData(this.Storage.M1Directory);
        }

        public BarData[] ReadM2Data()
        {
            return this.ReadData(this.Storage.M2Directory);
        }

        public BarData[] ReadM3Data()
        {
            return this.ReadData(this.Storage.M3Directory);
        }

        public BarData[] ReadM4Data()
        {
            return this.ReadData(this.Storage.M4Directory);
        }

        public BarData[] ReadM5Data()
        {
            return this.ReadData(this.Storage.M5Directory);
        }

        public BarData[] ReadM10Data()
        {
            return this.ReadData(this.Storage.M10Directory);
        }

        public BarData[] ReadM15Data()
        {
            return this.ReadData(this.Storage.M15Directory);
        }

        public BarData[] ReadM30Data()
        {
            return this.ReadData(this.Storage.M30Directory);
        }

        public BarData[] ReadH1Data()
        {
            return this.ReadData(this.Storage.H1Directory);
        }

        public BarData[] ReadH2Data()
        {
            return this.ReadData(this.Storage.H2Directory);
        }

        public BarData[] ReadH4Data()
        {
            return this.ReadData(this.Storage.H4Directory);
        }

        public BarData[] ReadH6Data()
        {
            return this.ReadData(this.Storage.H6Directory);
        }

        public BarData[] ReadH8Data()
        {
            return this.ReadData(this.Storage.H8Directory);
        }

        public BarData[] ReadH12Data()
        {
            return this.ReadData(this.Storage.H12Directory);
        }

        public BarData[] ReadD1Data()
        {
            return this.ReadData(this.Storage.D1Directory);
        }

        public BarData[] ReadW1Data()
        {
            return this.ReadData(this.Storage.W1Directory);
        }

        public BarData[] ReadMData()
        {
            return this.ReadData(this.Storage.MDirectory);
        }
    }
}
