using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Библиотека_экзамен;

namespace Консольное_приложение_экзамеен
{
    //Со слезами и отчаянием выполнила ГУЛЕНОК АРИНА 22ИС
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание описания объектов основного класса
            Buildig South_Park = new Buildig("Северная улица, дом 22", "Новый дом в молодом районе, прекрасный выбор для семьи с детьми");
            Buildig Warhsawa = new Buildig("Улица Дэвида Боуи, дом 94", "Историческое здание в центре города. Отличный выбор для творческого человека");
            Buildig BorderLine = new Buildig("Улица Бумажная, дом 154", "Современное здание в бизнес-центре. Прекрасный вариант для работников IT-сферы");
            //Создание описания объектов дополнительного класса
            Apartments pers_1 = new Apartments("Новиков Марк Михайлович", 132);
            Apartments pers_2 = new Apartments("Викторов Александр Андеевич", 42);
            Apartments pers_3 = new Apartments("Спухня Анна Владимировна", 366);
            //Добавление объектов дополнительного класса в список объектов основного класса
            BorderLine.Apartments.Add(pers_1);
            Warhsawa.Apartments.Add(pers_2);
            Warhsawa.Apartments.Add(pers_3);
            //Вывод на экран информации о зданиях и квартирах
            //Первое здание. Вывод информации о здании и о жильцах
            South_Park.ShowAll();
            Console.WriteLine("Жильцы в доме:");
            foreach (var pers in South_Park.Apartments)
            {
                pers.Show();
            }
            //Второе здание. Вывод информации о здании и о жильцах
            BorderLine.ShowAll();
            Console.WriteLine("Жильцы в доме:");
            foreach (var pers in BorderLine.Apartments)
            {
                pers.Show();
            }
            //Третье здание. Вывод информации о здании и о жильцах
            Warhsawa.ShowAll();
            Console.WriteLine("Жильцы в доме:");
            foreach (var pers in Warhsawa.Apartments)
            {
                pers.Show();
            }
            //Со слезами и отчаянием выполнила ГУЛЕНОК АРИНА 22ИС
            Console.ReadKey();
        }
    }
}
