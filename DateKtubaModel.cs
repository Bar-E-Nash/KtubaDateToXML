using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace KtubaDateToXML
{
    
    [XmlRoot("Query")]
    public class DateKtubaModel
    {

        [XmlElement("Year")]
        public string Year { get; set; }

        [XmlElement("Month")]
        public string Month { get; set; }

        [XmlElement("DayMonth")]
        public int DayMonth { get; set; }

        [XmlElement("DayWeek")]
        public int DayWeek { get; set; }

        [XmlElement("Result")]
        public string Result { get; set; }
        public DateKtubaModel(string year, string month, int dm, int dw, string res)
        {
            // TO DO
        }


        public void GenerateResult()
        {

        }


    }
}
