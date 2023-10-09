using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Bag StudentBag { get; set; }
        const double normalSatiety = 30;
        const double normalDrunk = 72;
        public string CountSatiety(Student student)
        {
            if (student.Age <= 0 || student.StudentBag.PizzaPieces <= 0)
                return "Ошибка";
            //уславливаемся, что с возрастом нужно меньше пиццы для насыщения
            double levelSatiety = (student.StudentBag.PizzaPieces / student.Age) * 100;
            if (levelSatiety < normalSatiety)
                return "Голоден";
            else if (levelSatiety > normalSatiety)
                return "Переел";
            else
                return "В самый раз";
        }

        public string CountDrunk(Student student)
        {
            if (student.Age <= 0 || student.StudentBag.PizzaPieces <= 0)
                return "Ошибка";
            //уславливаемся, что с возрастом нужно больше пива для опьянения
            double levelDrunk = student.StudentBag.PizzaPieces * student.Age;
            if (levelDrunk < normalDrunk)
                return "Трезв";
            else if (levelDrunk > normalDrunk)
                return "Перепил";
            else
                return "В самый раз";
        }
    }
}
