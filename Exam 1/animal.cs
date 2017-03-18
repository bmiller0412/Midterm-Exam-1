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

        //Constructor fuck you
        public Animal(string animalType, string animalBreed, string animalColor, string animalGender, decimal cost)
        {
            this.animalType = animalType;
            this.animalBreed = animalBreed;
           this.animalColor = animalColor;
            this.animalGender = animalGender;
            this.cost = cost;
        }
        //Default constructor with set values
        public Animal()
        {
            animalType = "Cat";
            animalBreed = "Siamese";
            animalColor = "Seal Point";
            animalGender = "Male";
            cost = 5000.00m;
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
