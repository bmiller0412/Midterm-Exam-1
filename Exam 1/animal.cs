using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1
{
    class Animal
    {
        //Variables and Datatypes needed for animal class
        private string animalType;
        private string animalBreed;
        private string animalColor;
        private string animalGender;
        private decimal cost = 5000.00m;  //m converts it to money format
        public decimal salesTax = 0.075m; //m converts sales tax to money format
        public decimal calculatedTax;

        //Default constructor with given default fields
        public Animal(string Cat, string Siamese, string Seal_Point, string Male, double cost)
        {
            animalType = Cat;
            animalBreed = Siamese;
            animalColor = Seal_Point;
            animalGender = Male;
            cost = 5000.00;
        }

        public Animal()
        {
            
        }

        //Properties of Animal
        private string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        private string AnimalBreed
        {
            get { return animalBreed; }
            set { animalBreed = value; }
        }

        private string AnimalColor
        {
            get { return animalColor; }
            set { animalColor = value; }
        }

        private string AnimalGender
        {
            get { return animalGender; }
            set { animalGender = value; }
        }
        
        //Method that calculates the sales tax for animal purchase
        private decimal GetCalculatedTax()
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
