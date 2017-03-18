using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1
{
    class animal
    {
        //Variables and Datatypes needed for animal class
        public string animalType;
        public string animalBreed;
        public string animalColor;
        public string animalGender;
        public decimal cost = 5000.00m;  //m converts it to money format
        public decimal salesTax = 0.075m; //m converts sales tax to money format
        public decimal calculatedTax;

        //Default constructor with given default fields
        public void Animal(string Cat, string Siamese, string Seal_Point, string Male, double cost)
        {
            animalType = Cat;
            animalBreed = Siamese;
            animalColor = Seal_Point;
            animalGender = Male;
            cost = 5000.00;
        }

        public void Animal()
        {
            
        }

        //Properties of Animal
        public string AnimalType
        {
            get { return AnimalType; }
            set { AnimalType = value; }
        }

        public string AnimalBreed
        {
            get { return AnimalBreed; }
            set { AnimalBreed = value; }
        }

        public string AnimalColor
        {
            get { return AnimalColor; }
            set { AnimalColor = value; }
        }

        public string AnimalGender
        {
            get { return AnimalGender; }
            set { AnimalGender = value; }
        }
        
        //Method that calculates the sales tax for animal purchase
        public decimal GetCalculatedTax()
        {
            return calculatedTax = cost * salesTax;
        }

        // Stores the calculated tax value to be used by the program when called
        private decimal CalculatedTax()
        {
            return calculatedTax;
        }
    }
}
