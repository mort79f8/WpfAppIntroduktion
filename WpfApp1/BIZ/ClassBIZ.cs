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
        Random random = new Random();

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
            
            for (int i = 0; i < 25; i++)
            {
                listBox.Items.Add(random.Next(100_000,1_000_001).ToString());
            }
        }

        public void RandomSortedNumbers(ListBox listBox)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_000));
            }

            numbers.Sort();

            foreach (int number in numbers)
            {
                listBox.Items.Add(number).ToString();
            }
        }
    }
}
