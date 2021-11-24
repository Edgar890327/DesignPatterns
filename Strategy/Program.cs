using Strategy;
using System;
using System.Collections.Generic;

List<IStrategy> stragies = new()
{
    new AddStrategy(),
    new SubstractStrategy(),
    new MultStrategy(),
    new DivStrategy(),
    new GaussStrategy()
};

stragies.ForEach(Print);

void Print(IStrategy strategy)
{
    if (strategy is GaussStrategy gauss)
        Console.WriteLine($"El resultado de la suma de gauss es ${strategy.Operation(0,100)}");
    else
        Console.WriteLine(strategy.Operation(20,10));
}