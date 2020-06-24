using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggabale> itemToLog) 
        {
            foreach (var item in itemToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
