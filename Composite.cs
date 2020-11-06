using System;
using System.Collections.Generic;
using System.Text;

namespace labo4Pinto
{
    class Composite : Component
    {
        protected List<Component> childrens = new List<Component>();

        public override void Add(Component component)
        {
            this.childrens.Add(component);
        }

        public override void Remove(Component component)
        {
            this.childrens.Remove(component);
        }

      
        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this.childrens)
            {
                result += component.Operation();
                if (i != this.childrens.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
