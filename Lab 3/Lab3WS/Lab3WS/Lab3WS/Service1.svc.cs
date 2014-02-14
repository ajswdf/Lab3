using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab3WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public double GetLat(string city)
        {
            if (city.ToUpper().Contains("KANSAS CITY"))
            {
                return 39.099722;
            }
            else
            {
                return 38.627222;
            }
        }

        public double GetLong(string city)
        {
            if (city.ToUpper().Contains("KANSAS CITY"))
            {
                return -94.578333;
            }
            else
            {
                return -90.197778;
            }
        }
    }
}
