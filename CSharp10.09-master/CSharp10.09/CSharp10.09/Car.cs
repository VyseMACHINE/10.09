using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10._09
{
    partial class Car
    {
        private static int doors;
        private static int wheels;
        private int issueDate;
        private int maxSpeed;
        private int weight;
        private string issueCountry;
        private string name;

        

        static Car()
        {
            doors = 4;
            wheels = 4;
        }

        public Car()
        {
            IssueDate = 0;
            MaxSpeed = 0;
            Weight = 0;
            IssueCountry = "";
            Name = "";
        }
        public Car(string tname,int tissueDate)
        {
            IssueDate = tissueDate;
            MaxSpeed = 0;
            Weight = 0;
            IssueCountry = "";
            Name = tname;
        }
        public Car(int issueDate,int maxSpeed, int weight,string issueCountry, string name)
        {
            IssueDate = issueDate;
            MaxSpeed = maxSpeed;
            Weight = weight;
            IssueCountry = issueCountry;
            Name = name;
        }

        partial void Write();


        public static int Doors { get => doors; set => doors = value; }
        public static int Wheels { get => wheels; set => wheels = value; }
        public int IssueDate { get => issueDate; set => issueDate = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int Weight { get => weight; set => weight = value; }
        public string IssueCountry { get => issueCountry; set => issueCountry = value; }
        public string Name { get => name; set => name = value; }
    }
}
