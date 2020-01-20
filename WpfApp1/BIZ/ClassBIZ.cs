﻿using System;
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
    }
}
