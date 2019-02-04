using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BMICalculator
{
   static class DB
    {
        //Hello World
static void Save(double BmiResult)
        {
            try
            {
                StreamWriter output = new StreamWriter("ResultLog.txt", true);
                output.WriteLine(BmiResult);
                output.Flush();
                output.Close();
            } catch(Exception)
            {
                // Do something
            }

        }

    }
}
