using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека_экзамен
{
    public class Buildig
    {
        //Создание полей класса
        public string Adress { get; set; }//Адрес
        public string Description { get; set; } //Описание
        public List<Apartments> Apartments = new List<Apartments>();//Список квартир (связан с соответствующим классом)

        //Создание объекта класса
        public Buildig(string adress, string description)
        {
            Adress = adress;
            Description = description;
        }
        //Создание метода класса, показывающего все здания и их описание
        public void ShowAll()
        {
            Console.WriteLine("Адрес здания - " + Adress + "  Описание здания " + Description);
        }

        //С гордостью и надменностью выполнила ГУЛЕНОК АРИНА 22ИС
    }
    //Создание дополнительного класса
    public class Apartments
    {
        public string Owner { get; set; }//Владелец квартиры
        public int Number { get; set; }//Номер квартиры
        public Apartments(string owner, int number)//Создание объекта класса
        {
            Owner = owner;
            Number = number;
        }
        //Создание метода, показывающего все номера квартир и их владельцев
        public void Show()
        { Console.WriteLine("Владелец квартиры - " + Owner + "  Номер квартиры - " + Number); }

    }
}
