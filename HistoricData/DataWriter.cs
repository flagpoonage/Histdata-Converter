using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricData
{
    public class DataWriter
    {
        public StorageStructure Storage { get; set; }

        public DataWriter(StorageStructure structure)
        {
            this.Storage = structure;
        }

        public void WriteData(string directory, BarData[] data)
        {
            using(var sw = new StreamWriter(Path.Combine(directory, "data.csv"), false))
            {
                foreach(var d in data)
                {
                    sw.WriteLine(d.ToString());
                }
            }
        }

        public void WriteM1Data(BarData[] data)
        {
            this.WriteData(this.Storage.M1Directory, data);
        }

        public void WriteM2Data(BarData[] data)
        {
            this.WriteData(this.Storage.M2Directory, data);
        }

        public void WriteM3Data(BarData[] data)
        {
            this.WriteData(this.Storage.M3Directory, data);
        }

        public void WriteM4Data(BarData[] data)
        {
            this.WriteData(this.Storage.M4Directory, data);
        }

        public void WriteM5Data(BarData[] data)
        {
            this.WriteData(this.Storage.M5Directory, data);
        }

        public void WriteM10Data(BarData[] data)
        {
            this.WriteData(this.Storage.M10Directory, data);
        }

        public void WriteM15Data(BarData[] data)
        {
            this.WriteData(this.Storage.M15Directory, data);
        }

        public void WriteM30Data(BarData[] data)
        {
            this.WriteData(this.Storage.M30Directory, data);
        }

        public void WriteH1Data(BarData[] data)
        {
            this.WriteData(this.Storage.H1Directory, data);
        }

        public void WriteH2Data(BarData[] data)
        {
            this.WriteData(this.Storage.H2Directory, data);
        }

        public void WriteH4Data(BarData[] data)
        {
            this.WriteData(this.Storage.H4Directory, data);
        }

        public void WriteH6Data(BarData[] data)
        {
            this.WriteData(this.Storage.H6Directory, data);
        }

        public void WriteH8Data(BarData[] data)
        {
            this.WriteData(this.Storage.H8Directory, data);
        }

        public void WriteH12Data(BarData[] data)
        {
            this.WriteData(this.Storage.H12Directory, data);
        }

        public void WriteD1Data(BarData[] data)
        {
            this.WriteData(this.Storage.D1Directory, data);
        }

        public void WriteW1Data(BarData[] data)
        {
            this.WriteData(this.Storage.W1Directory, data);
        }

        public void WriteMData(BarData[] data)
        {
            this.WriteData(this.Storage.MDirectory, data);
        }
    }
}
