using System;
using System.Collections.Generic;
using System.Text;

namespace labo4Pinto
{
    class Simple : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
