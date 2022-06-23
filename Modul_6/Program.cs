using System;

namespace Modul_6
{
    class Money
    {
        public int PartMoney { get; set; }
        private int partKopecks;
        public int PartKopecks
        {
            get { return partKopecks; }
            set
            {
                if (value >= 100)
                {
                    PartMoney += value / 100;
                    partKopecks = value % 100;
                }
                else partKopecks = value;
            }
        }
        public override string ToString()
        {
            return $"{PartMoney},{PartKopecks}";
        }
    }
    class Product: Money
    {
        
        private int minimum=0;
        public int Minimum
        {
            get { return minimum; } 
            set
            {
                int PartM,PartK;
                PartM = value / 100;
                PartK = value % 100;
                Console.WriteLine($"Minimum {PartM},{PartK}");
                if (PartK>=PartKopecks) 
                {
                    PartM++;
                    PartKopecks = 100-(PartK - PartKopecks);
                    PartMoney = PartMoney - PartM;
                    
                }else
                {
                    PartMoney = PartMoney - PartM;
                    PartKopecks = PartKopecks - PartK;
                } 
            }
        }
    }


    abstract class Device
    {

         public string Name { get; set; }
         public string Manufacturer { get; set; }

        public Device(string name,string manufacturer)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
        }

        abstract public void Sound();
        abstract public void Show();
        abstract public void Desc();
 
    }
    class Car:Device
    {
        public int tank_capacity { get; set; }

        public Car(int Tank_capacity,string name,string manufacturer): base(name,manufacturer)
        {
            this.tank_capacity = Tank_capacity;
        }

        public override void Sound()
        {
            Console.WriteLine("Sound");
        }

        public override void Show()
        {
            Console.WriteLine($"Показать: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine("------------Описание-----------");
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Name);
            Console.WriteLine($"Обьем топливного бака: {tank_capacity}");
        }

    }
    class Teapot : Device
    {
        public int VolumTeapot { get; set; }
        public Teapot(int VolumTeapot, string name, string manufacturer) : base(name, manufacturer)
        {
            this.VolumTeapot = VolumTeapot;
        }
        public override void Sound()
        { 
            Console.WriteLine("Teapot Sound");
        }
        public override void Show()
        {
            Console.WriteLine($"Показать имя Teapot:{Name}");
        }
        public override void Desc()
        {
            Console.WriteLine("------------Описание-----------");
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Name);
            Console.WriteLine($"Обьем Teapot: {VolumTeapot}");
        }
    }

    class Microwave : Device
    {
        public int power { get; set; }
        public bool? display { get; set; } = null;

        public Microwave(int power, bool? display, string name, string manufacturer ) : base(name,manufacturer)
        {
            this.power = power;
            this.display = display;
        }
        public override void Sound()
        {
            Console.WriteLine("Microwave Sound");
        }
        public override void Show()
        {
            Console.WriteLine($"Показать Microwave: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine("------------Описание-----------");
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Name);
            Console.WriteLine($"Мощность Microwave: {power}");
            Console.WriteLine($"Дисплей: {display}");
        }

    }



    
    class Program
    {
        static void Main(string[] args)
        {
            //================================ 1 task=========================
            /*Money dollar = new Money();
            Product Kefir = new Product();
            Kefir.PartMoney = 100;
            Kefir.PartKopecks = 120;
            Console.WriteLine(Kefir.ToString());

            Kefir.Minimum = 50;
            Console.WriteLine(Kefir.ToString());*/
            //================================================================
            //================================ 2 task=========================
            /*Device avto = new Car(10,"VAZ","Spain");
            avto.Sound();
            avto.Show();
            avto.Desc();
            Console.WriteLine();
            Device teapot = new Teapot(5, "Bosh", "Canada");
            teapot.Sound();
            teapot.Show();
            teapot.Desc();
            Console.WriteLine();
            Device microwave = new Microwave(220, true, "Samsung", "Germany");
            microwave.Sound();
            microwave.Show();
            microwave.Desc();
            *///================================================================
            //================================ 3 task=========================
            
            //================================================================
        }
    }
}
