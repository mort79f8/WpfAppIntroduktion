using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

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
                numbers.Add(random.Next(100_000, 1_000_001));
            }

            numbers.Sort();

            foreach (int number in numbers)
            {
                listBox.Items.Add(number.ToString());
            }
        }

        public void ListUnsortedAndSorted(ListBox listBox)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int number = random.Next(100_000, 1_000_001);
                list1.Add(number);
                list2.Add(number);
            }

            list2.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                listBox.Items.Add($"{list1[i].ToString()} - {list2[i].ToString()}");
            }
        }

        public void RandomNumbersAndAverage(ListBox listBox)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }

            foreach (int number in numbers)
            {
                listBox.Items.Add(number.ToString());
            }

            listBox.Items.Add(" ");
            listBox.Items.Add($"Gennemsnitsværdi: {GetAverage(numbers)}");
        }

        public void RandomNumberMinusAverage(ListBox listBox)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }
            
            numbers.Sort();

            int average = GetAverage(numbers);

            foreach (int number in numbers)
            {
                listBox.Items.Add($"{number} - {average} = {number - average}");
            }

        }

        public List<string> RandomNumbersMinusAverage()
        {
            List<int> numbers = new List<int>();
            List<string> returnList = new List<string>();


            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }

            numbers.Sort();

            int average = GetAverage(numbers);

            foreach (int number in numbers)
            {
                returnList.Add($"{number} - {average} = {number - average}");
            }

            return returnList;
        }

        public void ColoredRandomNumbersMinusAverage(ListBox listBox)
        {
            List<int> numbers = new List<int>();
            

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }

            int average = GetAverage(numbers);

            foreach (int number in numbers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                SetBackgroundColor(listBoxItem, number);
                listBoxItem.Content = $"{number} - {average} = {number - average}";
                listBox.Items.Add(listBoxItem);
            }
        }

        public List<ListBoxItem> ColoredSortedRandomNumbersMinusAverage()
        {
            List<int> numbers = new List<int>();
            List<ListBoxItem> returnList = new List<ListBoxItem>();


            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }

            numbers.Sort();

            int average = GetAverage(numbers);

            foreach (int number in numbers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                SetBackgroundColor(listBoxItem, number);
                listBoxItem.Content = $"{number} - {average} = {number - average}";
                returnList.Add(listBoxItem);
            }

            return returnList;
        }

        public void SetupAssignmentOneTen(ListBox listBox)
        {
            listBox.ItemsSource = ColoredSortedRandomNumbersMinusAverage();
        }

        #region utilsMethods
        public void CheckItemSource(ListBox listBox)
        {
            if (listBox.ItemsSource == null)
            {
                listBox.Items.Clear();
                return;
            }
            else
            {
                listBox.ItemsSource = null;
                listBox.Items.Clear();
            }
        }

        private int GetAverage(List<int> listOfnumbers)
        {
            int number = 0;

            foreach (int num in listOfnumbers)
            {
                number = +num; 
            }

            number = number / listOfnumbers.Count();
            
            return number;
        }

        private bool IsNumberEven(int number)
        {
            int modulus = number % 2;
            if (modulus == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetBackgroundColor(ListBoxItem listBoxItem, int number)
        {
            if (IsNumberEven(number))
            {
                listBoxItem.Background = Brushes.HotPink;
            }
            else
            {
                listBoxItem.Background = Brushes.AliceBlue;
            }
        }

        #endregion
    }
}
