using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask.Classes
{
    interface IGUIFactory
    {
         Button CreateButton();
         CheckBox CreateCheckbox();
    }
}
