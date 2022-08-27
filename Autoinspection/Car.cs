using System;
using System.Collections.Generic;
using System.Text;

namespace Autoinspection
{
    class Car
    {
        public string carName = "";
        public string carModel = "";
        public int constructionYear = 1900;
        public int lastInspectionYear = 1900;

        //Konstruktor
        public Car(string newCarName, string newCarModel, int newConstructorYear, int newLastInspectionYear)
        {
            carName = newCarName;
            carModel = newCarModel;
            constructionYear = newConstructorYear;
            lastInspectionYear = newLastInspectionYear;
        }

        public void Inspect()
        {
            lastInspectionYear = 2022;
        }

    }
}
