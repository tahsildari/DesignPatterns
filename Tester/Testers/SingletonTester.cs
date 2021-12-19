using DesignPatternsAsISeeThem.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Testers
{
    /// <summary>
    /// Normally, a singleton method exists on the class itself. 
    /// Here, for better understanding of the situation, I moved the instantiation to another class.
    /// If we use the SignletonLogger's GetLogger() we expect the logs to be stored in a unique object, because it is singleton.
    /// However, when we use the NormalLogger's GetLogger() we expect logs to be separated, since the objects are NEW.
    /// In a real-world example, we will not allow this separation (hence new instances), because we only want the Singleton.
    /// </summary>
    public class SingletonTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;
        public void Run()
        {
            Console.WriteLine(this.GetType().Name + " " + new string('-', 20));

            Thread t1 = new Thread(() => {
                var logger = SingletonLogger.GetLogger();
                logger.Log("1st message from thread #1");
                logger.Log("2nd message from thread #1");
                Console.WriteLine(logger.GetHistory());
            });


            Thread t2 = new Thread(() => {
                var logger = SingletonLogger.GetLogger();
                logger.Log("only message from thread #2");
                Console.WriteLine(logger.GetHistory());
            });


            Thread t3 = new Thread(() => {
                var logger = NormalLogger.GetLogger();
                logger.Log("1st message from thread #3");
                logger.Log("2nd message from thread #3");
                logger.Log("3rd message from thread #3");
                Console.WriteLine(logger.GetHistory());
            });

            Thread t4 = new Thread(() => {
                var logger = NormalLogger.GetLogger();
                logger.Log("1st message from thread #4");
                logger.Log("2nd message from thread #4");
                logger.Log("3rd message from thread #4");
                Console.WriteLine(logger.GetHistory());
            });

            t1.Start(); Thread.Sleep(100);
            t2.Start(); Thread.Sleep(100);
            t3.Start(); Thread.Sleep(100);
            t4.Start(); Thread.Sleep(100);

        }

    }
}
