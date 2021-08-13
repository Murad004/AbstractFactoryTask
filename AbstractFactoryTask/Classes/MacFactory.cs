using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask.Classes
{
     class MacFactory : IGUIFactory
    {
        public Button CreateButton()
        {
            throw new NotImplementedException();
        }

        public CheckBox CreateCheckbox()
        {
            throw new NotImplementedException();
        }
    }
}
