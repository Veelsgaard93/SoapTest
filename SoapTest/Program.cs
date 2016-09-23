using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter celcius degrees");
            double celsius = Convert.ToDouble(Console.ReadLine());
            // to get serviceRef: rightclick project -> add -> servicereference -> paste wsdl

            ServiceReference1.ConvertTemperatureSoapClient converter = new ServiceReference1.ConvertTemperatureSoapClient("ConvertTemperatureSoap");

            //solve endpoint issue: delete all but one endpoint or specify endpoint in string when instantiated
            // you find name in the webconfig -> endpoint

            double fahrenheit = converter.ConvertTemp(celsius,
                ServiceReference1.TemperatureUnit.degreeCelsius,
                ServiceReference1.TemperatureUnit.degreeFahrenheit);
            Console.WriteLine("fino bambino - det svarer til: " + fahrenheit);

        }
    }
}
