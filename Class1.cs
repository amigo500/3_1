using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        public class Person
    {
        private int age;
        private string fname;
        private string lname;
        private int height;
        private int weight;
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Fname
        {
            get => fname;
            set => fname = value;
        }
        public string Lname
        {
            get => lname;
            set => lname = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public int Weight
        {
            get => weight;
            set => weight = value;
        }
        public Person(int age, string fname, string lname, int height, int weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
                    }
            }

    