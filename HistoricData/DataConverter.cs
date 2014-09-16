using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricData
{
    public class DataConverter
    {
        private DataReader Reader { get; set; }

        private DataWriter Writer { get; set; }

        public StorageStructure Storage { get; set; }

        public DataConverter(StorageStructure structure)
        {
            this.Storage = structure;
            this.Reader = new DataReader(this.Storage);
            this.Writer = new DataWriter(this.Storage);
        }

        private BarData Combine(params BarData[] bars)
        {
            var ordered = bars.OrderBy(a => a.Time);
            var first = ordered.First();
            var last = ordered.Last();
            var highest = ordered.Max(a => a.High);
            var lowest = ordered.Min(a => a.Low);

            return new BarData()
            {
                Time = first.Time,
                Close = last.Close,
                High = highest,
                Open = first.Open,
                Low = lowest,
                Volume = ordered.Sum(a => a.Volume)
            };
        }

        public void CreateH1Data()
        {

        }

        public void CreateM30Data()
        {
            var output = new List<BarData>();
            var data = this.Reader.ReadM15Data();

            for (var i = 0; i < data.Length; i++)
            {
                if (i == 0 && data[i].Time.Minute % 30 != 0)
                {
                    output.Add(data[i]);
                }
                else if (data[i].Time.Minute % 30 == 0)
                {
                    var dbuild = new List<BarData>() { data[i] };

                    if (i + 1 < data.Length && data[i + 1].Time == data[i].Time.AddMinutes(30))
                    {
                        dbuild.Add(data[i + 1]);
                    }

                    i += dbuild.Count - 1;

                    output.Add(this.Combine(dbuild.ToArray()));
                }
            }

            this.Writer.WriteM30Data(output.ToArray());
        }

        public void CreateM15Data()
        {
            var output = new List<BarData>();
            var data = this.Reader.ReadM5Data();

            for (var i = 0; i < data.Length; i++)
            {
                if (i == 0 && data[i].Time.Minute % 15 != 0)
                {
                    output.Add(data[i]);
                }
                else if (data[i].Time.Minute % 15 == 0)
                {
                    var dbuild = new List<BarData>() { data[i] };

                    if (i + 1 < data.Length && data[i + 1].Time == data[i].Time.AddMinutes(5))
                    {
                        dbuild.Add(data[i + 1]);
                    }

                    if (i + 2 < data.Length && data[i + 2].Time == data[i].Time.AddMinutes(10))
                    {
                        dbuild.Add(data[i + 2]);
                    }

                    i += dbuild.Count - 1;

                    output.Add(this.Combine(dbuild.ToArray()));
                }
            }

            this.Writer.WriteM15Data(output.ToArray());
        }

        public void CreateM10Data()
        {
            var output = new List<BarData>();
            var data = this.Reader.ReadM5Data();

            for (var i = 0; i < data.Length; i++)
            {
                if (i == 0 && data[i].Time.Minute % 10 != 0)
                {
                    output.Add(data[i]);
                }
                else if (data[i].Time.Minute % 10 == 0)
                {
                    var dbuild = new List<BarData>() { data[i] };

                    if (i + 1 < data.Length && data[i + 1].Time == data[i].Time.AddMinutes(5))
                    {
                        dbuild.Add(data[i + 1]);
                    }

                    i += dbuild.Count - 1;

                    output.Add(this.Combine(dbuild.ToArray()));
                }
            }

            this.Writer.WriteM10Data(output.ToArray());
        }

        public void CreateM5Data()
        {
            var output = new List<BarData>();
            var data = this.Reader.ReadM1Data();

            for (var i = 0; i < data.Length; i++)
            {
                if (i == 0 && data[i].Time.Minute % 5 != 0)
                {
                    output.Add(data[i]);
                }
                else if (data[i].Time.Minute % 5 == 0)
                {
                    var dbuild = new List<BarData>() { data[i] };

                    if (i + 1 < data.Length && data[i + 1].Time == data[i].Time.AddMinutes(1))
                    {
                        dbuild.Add(data[i + 1]);
                    }

                    if (i + 2 < data.Length && data[i + 2].Time == data[i].Time.AddMinutes(2))
                    {
                        dbuild.Add(data[i + 2]);
                    }

                    if (i + 3 < data.Length && data[i + 3].Time == data[i].Time.AddMinutes(3))
                    {
                        dbuild.Add(data[i + 3]);
                    }

                    if (i + 4 < data.Length && data[i + 4].Time == data[i].Time.AddMinutes(4))
                    {
                        dbuild.Add(data[i + 4]);
                    }

                    i += dbuild.Count - 1;

                    output.Add(this.Combine(dbuild.ToArray()));
                }
            }

            this.Writer.WriteM5Data(output.ToArray());
        }

        public void CreateM4Data()
        {
            var output = new List<BarData>();
            var data = this.Reader.ReadM1Data();

            for (var i = 0; i < data.Length; i++)
            {
                if (i == 0 && data[i].Time.Minute % 4 != 0)
                {
                    output.Add(data[i]);
                }
                else if (data[i].Time.Minute % 4 == 0)
                {
                    var dbuild = new List<BarData>() { data[i] };

                    if(i + 1 < data.Length && data[i + 1].Time == data[i].Time.AddMinutes(1))
                    {
                        dbuild.Add(data[i + 1]);
                    }

                    if(i + 2 < data.Length && data[i + 2].Time == data[i].Time.AddMinutes(2))
                    {
                        dbuild.Add(data[i + 2]);
                    }

                    if(i + 3 < data.Length && data[i + 3].Time == data[i].Time.AddMinutes(3))
                    {
                        dbuild.Add(data[i + 3]);
                    }

                    i += dbuild.Count - 1;

                    output.Add(this.Combine(dbuild.ToArray()));
                }
            }

            this.Writer.WriteM4Data(output.ToArray());
        }

        public void CreateM3Data()
        {
            var output = new List<BarData>();
            var data = this.Reader.ReadM1Data();

            for (var i = 0; i < data.Length; i++)
            {
                if (i == 0 && data[i].Time.Minute % 3 != 0)
                {
                    output.Add(data[i]);
                }
                else if (data[i].Time.Minute % 3 == 0)
                {
                    var dbuild = new List<BarData>() { data[i] };

                    if (i + 1 < data.Length && data[i + 1].Time == data[i].Time.AddMinutes(1))
                    {
                        dbuild.Add(data[i + 1]);
                    }

                    if (i + 2 < data.Length && data[i + 2].Time == data[i].Time.AddMinutes(2))
                    {
                        dbuild.Add(data[i + 2]);
                    }

                    i += dbuild.Count - 1;

                    output.Add(this.Combine(dbuild.ToArray()));
                }
            }

            this.Writer.WriteM3Data(output.ToArray());
        }

        public void CreateM2Data()
        {
            var output = new List<BarData>();
            var data = this.Reader.ReadM1Data();

            for (var i = 0; i < data.Length; i++)
            {
                if (i == 0)
                {
                    if (data[i].Time.Minute % 2 == 1)
                    {
                        output.Add(data[i]);
                    }
                }
                else if (data[i].Time.Minute % 2 == 1)
                {
                    if (data[i - 1].Time.Minute % 2 == 1)
                    {
                        var d = new BarData()
                        {
                            Time = data[i].Time.AddMinutes(-1),
                            Close = data[i].Close,
                            High = data[i].High,
                            Low = data[i].Low,
                            Open = data[i].Open,
                            Volume = data[i].Volume
                        };

                        output.Add(d);
                    }
                    else
                    {
                        output.Add(this.Combine(data[i], data[i - 1]));
                    }
                }
            }

            this.Writer.WriteM2Data(output.ToArray());
        }
    }
}
