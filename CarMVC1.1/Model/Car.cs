using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMVC1._1.Model
{
    public class Car
    {
		private string model;
		public string Model
		{
			get { return model; }
			set { model = value; }
		}


        private string mark;
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        private string registrationNumber;
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (age<1980 || age>2023)
                {
                    throw new ArgumentOutOfRangeException("Can't be older than 1980 and yanger tahn 2023 year");
                }
                age = value;
            }
        }

        public Car( string registrationNumbers, int age)
        {
            this.Model = model;
            this.Mark = mark;
            this.RegistrationNumber = registrationNumbers;
            this.Age = age;
        }
       // public Car() this: ("","", "", 0)
        
        public string GetCar(string model, string mark)
        {
            return $"{mark} {model} --- bruum brum brum";
        }
        
        


    }
}
