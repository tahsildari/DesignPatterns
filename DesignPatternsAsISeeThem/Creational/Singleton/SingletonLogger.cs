using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAsISeeThem.Creational.Singleton
{
    public class SingletonLogger
    {
        static Logger instance;
        static object locker = new object();
        public static Logger GetLogger()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }
    }
}
