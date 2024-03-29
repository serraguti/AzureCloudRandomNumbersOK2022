﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceRandomNumbers" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceRandomNumbers.svc or ServiceRandomNumbers.svc.cs at the Solution Explorer and start debugging.
    public class ServiceRandomNumbers : IServiceRandomNumbers
    {
        public List<int> GetRandomNumbers()
        {
            List<int> numeros = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 14; i++)
            {
                int num = random.Next(1, 500);
                numeros.Add(num);
            }
            return numeros;
        }

    }
}
