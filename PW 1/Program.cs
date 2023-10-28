namespace Racing
{
    class Car
    {
        public string CarName;
        public int MaxSpeed;
        public string DriverName;
        public int distance = 520;

        public Car(string carName, int maxSpeed, string driverName)
        {
            CarName = carName;
            MaxSpeed = maxSpeed;
            DriverName = driverName;

        }
        public void RacingInfo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Давно тебя не было Уличных Гонках. Заходи.");
            Console.WriteLine("Сегоднящняя дистанция трасы - " + distance + " метров.");
            Console.WriteLine("Представляем участников гонки:");
            Console.WriteLine("==============================================");
        }

        public void CarInfo()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Именование машины: " + CarName);
            Console.WriteLine("Максимальная развиваемая скорость: " + MaxSpeed + " км/ч");
            Console.WriteLine("Водитель: " + DriverName);
           Console.WriteLine("---------------------------------------------");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes-Benz S-Class", 240, "Роберт");
            Car car2 = new Car("BMW 7 Series", 220, "Джеймс");
            Car car3 = new Car("Audi A8", 230, "Майкл");
            Car car4 = new Car("Lexus LS", 250, "Френсис");
            Car info = new Car("",0,"");
           


            info.RacingInfo();
            car1.CarInfo();
            car2.CarInfo();
            car3.CarInfo();
            car4.CarInfo();


            int WinNumb = Math.Max(Math.Max(car1.MaxSpeed,car2.MaxSpeed), Math.Max(car3.MaxSpeed, car4.MaxSpeed));
            if (WinNumb == car1.MaxSpeed) 
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("Победитель Гонки: " + car1.DriverName + " на машине " + car1.CarName);
                Console.WriteLine("==============================================");
            }
            else if (WinNumb == car2.MaxSpeed)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("Победитель Гонки: " + car2.DriverName + " на машине " + car2.CarName);
                Console.WriteLine("==============================================");
            }
            else if (WinNumb == car3.MaxSpeed)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("Победитель Гонки: " + car3.DriverName + " на машине " + car3.CarName);
                Console.WriteLine("==============================================");
            }
            else if (WinNumb == car4.MaxSpeed)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("Победитель Гонки: " + car4.DriverName + " на машине " + car4.CarName);
                Console.WriteLine("==============================================");
            }
            else
            {
                Console.WriteLine("Победитель не определен!");
                    }


            Console.ReadKey();
        }
    }
}
