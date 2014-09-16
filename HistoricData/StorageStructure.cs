using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricData
{
    public class StorageStructure
    {
        public string RootDirectory { get; set; }
        public string M1Directory { get; set; }
        public string M2Directory { get; set; }
        public string M3Directory { get; set; }
        public string M4Directory { get; set; }
        public string M5Directory { get; set; }
        public string M10Directory { get; set; }
        public string M15Directory { get; set; }
        public string M30Directory { get; set; }
        public string H1Directory { get; set; }
        public string H2Directory { get; set; }
        public string H4Directory { get; set; }
        public string H6Directory { get; set; }
        public string H8Directory { get; set; }
        public string H12Directory { get; set; }
        public string D1Directory { get; set; }
        public string W1Directory { get; set; }
        public string MDirectory { get; set; }

        public StorageStructure(string rootDirectory)
        {
            this.RootDirectory = rootDirectory;
            this.M1Directory = Path.Combine(rootDirectory, "m1\\");
            this.M2Directory = Path.Combine(rootDirectory, "m2\\");
            this.M3Directory = Path.Combine(rootDirectory, "m3\\");
            this.M4Directory = Path.Combine(rootDirectory, "m4\\");
            this.M5Directory = Path.Combine(rootDirectory, "m5\\");
            this.M10Directory = Path.Combine(rootDirectory, "m10\\");
            this.M15Directory = Path.Combine(rootDirectory, "m15\\");
            this.M30Directory = Path.Combine(rootDirectory, "m30\\");
            this.H1Directory = Path.Combine(rootDirectory, "h1\\");
            this.H2Directory = Path.Combine(rootDirectory, "h2\\");
            this.H4Directory = Path.Combine(rootDirectory, "h4\\");
            this.H6Directory = Path.Combine(rootDirectory, "h6\\");
            this.H8Directory = Path.Combine(rootDirectory, "h8\\");
            this.H12Directory = Path.Combine(rootDirectory, "h12\\");
            this.D1Directory = Path.Combine(rootDirectory, "d1\\");
            this.W1Directory = Path.Combine(rootDirectory, "w1\\");
            this.MDirectory = Path.Combine(rootDirectory, "m\\");
        }
    }
}
