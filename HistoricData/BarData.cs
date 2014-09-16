using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricData
{
    public class BarData
    {
        public DateTime Time { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public int Volume { get; set; }

        public bool IsValid { get; set; }

        public BarData() { }

        public BarData(string parseable)
        {
            if(string.IsNullOrEmpty(parseable))
            {
                return;
            }

            var columns = parseable.Split(';');

            if (columns.Length == 6)
            {
                this.Time = DateTime.ParseExact(columns[0], "yyyyMMdd HHmmss", CultureInfo.CurrentCulture);
                this.Open = double.Parse(columns[1]);
                this.High = double.Parse(columns[2]);
                this.Low = double.Parse(columns[3]);
                this.Close = double.Parse(columns[4]);
                this.Volume = int.Parse(columns[5]);

                this.IsValid = true;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "{0};{1};{2};{3};{4};{5}",
                this.Time.ToString("yyyyMMdd HHmmss"),
                this.Open.ToString("0.000000"),
                this.High.ToString("0.000000"),
                this.Low.ToString("0.000000"),
                this.Close.ToString("0.000000"),
                this.Volume);
        }
    }
}
