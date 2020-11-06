using labo4Pinto;
using System;
using System.Collections.Generic;


namespace labo4PintO
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

         
            Simple leaf = new Simple();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

      
            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Simple());
            branch1.Add(new Simple());
            Composite branch2 = new Composite();
            branch2.Add(new Simple());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
