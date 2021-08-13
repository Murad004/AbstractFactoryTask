using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask.Classes
{
    class App
    {
        public IGUIFactory Factory { get; set; }
        public Button Button { get; set; }
        public CheckBox CheckBox { get; set; }

        public App(IGUIFactory factory)
        {
            Factory = factory;
        }

        public void CreateUI()
        {
            Button = Factory.CreateButton();
            CheckBox = Factory.CreateCheckbox();
        }

    }
}
