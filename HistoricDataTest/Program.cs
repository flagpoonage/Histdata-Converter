using HistoricData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricDataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = "C:\\Users\\jhay\\Documents\\DATA";

            var structure = new StorageStructure(folder);

            var converter = new DataConverter(structure);

            converter.CreateM5Data();
            converter.CreateM10Data();
        }
    }
}
