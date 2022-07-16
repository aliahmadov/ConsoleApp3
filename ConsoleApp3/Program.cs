using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp3
{

    //public class Car
    //{
    //    public string Model { get; set; }

    //    public string Vendor { get; set; }

    //    public int Year { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Model}-{Vendor}-{Year}";
    //    }
    //}




    public class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<Car>
            //{
            //    new Car{ Model ="Mustang",Vendor="Ford",Year=1964},
            //    new Car{ Model ="Charger",Vendor="Dodge", Year=2000},
            //    new Car{ Model ="Veyron", Year=2010, Vendor="Bugatti"},
            //    new Car{ Model="M5", Vendor="BMW", Year=2020}
            //};


            #region Xml Writer

            //using (var writer = new XmlTextWriter("cars.xml", Encoding.UTF8))
            //{
            //    writer.Formatting = Formatting.Indented;
            //    writer.WriteStartDocument();

            //    writer.WriteStartElement("Cars");

            //    foreach (var car in cars)
            //    {
            //        writer.WriteStartElement("car");

            //        //Like Tag
            //        writer.WriteElementString(nameof(car.Model), car.Model);
            //        writer.WriteElementString(nameof(car.Vendor), car.Vendor);
            //        writer.WriteElementString(nameof(car.Year), car.Year.ToString());

            //        //writer.WriteAttributeString(nameof(car.Model), car.Model);
            //        //writer.WriteAttributeString(nameof(car.Vendor), car.Vendor);
            //        //writer.WriteAttributeString(nameof(car.Year), car.Year.ToString());

            //        writer.WriteEndElement();
            //    }


            //    writer.WriteEndElement();


            //    writer.WriteEndDocument();
            //}

            #endregion


            #region Xml Reading

            //XmlDocument xml = new XmlDocument();

            //xml.Load("cars.xml");

            //var root = xml.DocumentElement;

            //if (root.HasChildNodes)
            //{
            //    foreach (XmlNode car_node in root.ChildNodes)
            //    {
            //        var car = new Car
            //        {
            //            //Like attribute

            //            //Model = car_node.Attributes[0].Value,
            //            //Vendor = car_node.Attributes[1].Value,
            //            //Year = int.Parse(car_node.Attributes[2].Value)

            //            //Like Tag
            //            Model = car_node.ChildNodes[0].InnerText,
            //            Vendor = car_node.ChildNodes[1].InnerText,
            //            Year = int.Parse(car_node.ChildNodes[2].InnerText)
            //        };
            //        Console.WriteLine(car);
            //        Console.WriteLine();
            //    }
            //}

            #endregion

            #region XML Serialization
            //var army = new TranslatorArmy
            //{
            //    Name = "Step IT Academy",
            //    Location = "Koroglu Rehimov 71",
            //    Translators = new List<Translator>
            //    {
            //        new Translator
            //        {
            //            Name="Tural",
            //            Surname="Eliyev",
            //            Id=1,
            //            Subjects=new List<Subject>
            //            {
            //                new Subject
            //                {
            //                     Name="C++",
            //                     Degree=42,
            //                     Lessons=30
            //                },
            //                new Subject
            //                {
            //                     Name="C#",
            //                     Degree=42,
            //                     Lessons=35
            //                },
            //            }
            //        },
            //        new Translator
            //        {
            //            Name="Eli",
            //            Surname="Memmedov",
            //            Id=2,
            //            Subjects=new List<Subject>
            //            {
            //                new Subject
            //                {
            //                     Name="JS",
            //                     Degree=42,
            //                     Lessons=30
            //                },
            //                new Subject
            //                {
            //                     Name="PHP",
            //                     Degree=42,
            //                     Lessons=35
            //                },
            //            }
            //        },
            //        new Translator
            //        {
            //            Name="Leyla",
            //            Surname="Mammadli",
            //            Id=3,
            //            Subjects=new List<Subject>
            //            {
            //                new Subject
            //                {
            //                     Name="Angular",
            //                     Degree=35,
            //                     Lessons=25
            //                },
            //                new Subject
            //                {
            //                     Name="React",
            //                     Degree=85,
            //                     Lessons=21
            //                },
            //            }
            //        }
            //    }
            //};


            //var xml = new XmlSerializer(typeof(TranslatorArmy));
            //using (var fs = new FileStream("TranslatorArmy.xml", FileMode.OpenOrCreate))
            //{
            //    xml.Serialize(fs, army);
            //}



            #endregion

            #region XML DESERIALIZE
            //TranslatorArmy army = null;

            //var xml = new XmlSerializer(typeof(TranslatorArmy));

            //using (var fs = new FileStream("TranslatorArmy.xml", FileMode.OpenOrCreate))
            //{
            //    army = xml.Deserialize(fs) as TranslatorArmy;
            //}
            //Console.WriteLine(army);
            #endregion


        }
    }
}
