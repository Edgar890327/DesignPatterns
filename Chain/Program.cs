using System;
using Chain;

var chain = new NumberStep(3, "Fizz", 
                 new AbstractStep(5, "Buzz",
                    new AbstractStep(7, "Bazz",
                       new PrintStep())));

for(var i=1; i<=100; i++)
{
    chain.Handle(i);
}

