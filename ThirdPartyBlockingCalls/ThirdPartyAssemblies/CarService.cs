using System;
using System.Collections.Generic;
using System.Threading;

namespace ThirdPartyBlockingCalls.ThirdPartyAssemblies;

public  class CarService
{
    private static Random _rnd = new();

    public static CarService GetCarService(int id) => new CarService();
    private CarService(){}
    public IEnumerable<Car> GetCars()
    {
        for (int i = 0; i < 50; i++)
        {
            Thread.Sleep(_rnd.Next(50) + 5);
           // Thread.Sleep(25);
            yield return new Car();
        }
    }
}
