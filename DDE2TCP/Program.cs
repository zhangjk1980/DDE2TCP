using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDE2TCP
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                KktDdeClient.RunDdeClient();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.GetBaseException().Message);

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
