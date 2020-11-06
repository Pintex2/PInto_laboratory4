using System;
using System.Collections.Generic;
using System.Text;

namespace labo4Pinto
{
    class Client
    {
      
        public void ClientCode(Component simple)
        {
            Console.WriteLine($"RESULT: {simple.Operation()}\n");
        }

        
        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}
