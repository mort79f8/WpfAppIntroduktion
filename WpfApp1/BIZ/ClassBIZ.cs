using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.BIZ
{
    class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void Number4711(ListBox listBox)
        {
            for (int i = 4711; i <= 4736; i++)
            {
                listBox.Items.Add(i.ToString());
            }
        }

        public void RandomNumbers(ListBox listBox)
        {
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                listBox.Items.Add(random.Next(100_000,1_000_001).ToString());
            }
        }
    }
}
