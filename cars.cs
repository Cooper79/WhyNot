using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8_1
{
    public class Car
    {
        public string name { get; set; }
        public string color { get; set; }
        public int speed { get; set; }
        public int year { get; set; }
    }
    class Garage
    {
        public List<Car> garageList = new List<Car>();

        public List<Car> addCar(int index, List<Car> carList)
        {
            garageList.Add(carList[index - 1]);

            return garageList;
        }

        public List<Car> removeCar(int index)
        {
            garageList.Remove(garageList[index - 1]);

            return garageList;
        }

        public void showAllCars()
        {
            foreach (Car car in garageList)
            {
                Console.WriteLine($"{car.name} - {car.color} - {car.speed} - {car.year}");
            }
        }

        public void chooseCar(string _name, string _color, int _speed, int _year)
        {
            List<Car> searchList = new List<Car>();

            Car searchCar = new Car() { name = _name, color = _color, speed = _speed, year = _year };
            for (int i = 0; i < garageList.Count; i++)
            {
                if (garageList[i].name == searchCar.name)
                {
                    searchList.Add(garageList[i]);
                }
                else if (searchCar.name != null)
                {
                    searchList.RemoveAll(car => car.name != searchCar.name);
                }
                if (garageList[i].color == searchCar.color)
                {
                    searchList.Add(garageList[i]);
                }
                else if (searchCar.color != null)
                {
                    searchList.RemoveAll(car => car.color != searchCar.color);
                }
                if (garageList[i].speed == searchCar.speed)
                {
                    searchList.Add(garageList[i]);
                }
                else if (searchCar.speed != 0)
                {
                    searchList.RemoveAll(car => car.speed != searchCar.speed);
                }
                if (garageList[i].year == searchCar.year)
                {
                    searchList.Add(garageList[i]);
                }
                else if (searchCar.year != 0)
                {
                    searchList.RemoveAll(car => car.year != searchCar.year);
                }
            }
            IEnumerable<Car> result = searchList.Distinct();

            foreach (Car car in result)
            {
                Console.WriteLine($"Your choise{car.name} - {car.color} - {car.speed} - {car.year}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            int count;
            bool a;

            List<Car> carList = new List<Car>()
            {
                new Car(){name = "Ferrari 488", color = "Red", speed=330, year=2015},
                new Car(){name = "BMW M5", color = "Black", speed=300, year=2019},
                new Car(){name = "BMW X6", color = "Black", speed=320, year=2019},
                new Car(){name = "Porsche 991", color = "Silver", speed=310, year=2011},
                new Car(){name = "Audi A7", color = "Silver", speed=250, year=2018},
                new Car(){name = "Mazda Furai", color = "Dark Gray", speed=290, year=2008},
                new Car(){name = "Audi S4", color = "Red", speed=200, year=2013},
                new Car(){name = "Lamborghini Aventador", color = "White", speed=350, year=2017}
            };


            do
            {
                Console.WriteLine("1) Show all the cars in the garage");
                Console.WriteLine("2) Add car to the garage");
                Console.WriteLine("3) Delete car from the garage");
                Console.WriteLine("4) Choose car from the garage");
                Console.WriteLine("0) Exit");
                
                do
                {
                    Console.Write("Enter your choise: ");
                    a = int.TryParse(Console.ReadLine(), out count);
                    Console.WriteLine("------------");
                    if (!a || count >= 5)
                        Console.WriteLine("Wrong number!");
                } while (!a || count >= 5);
                switch (count)
                {
                    case 1:
                        if (garage.garageList == null)
                            Console.WriteLine("Garage is empty");
                        else
                            garage.showAllCars();

                        break;
                    case 2:
                        for (int i = 0; i < carList.Count; i++)
                        {
                            Console.WriteLine($"{carList[i].name} - {carList[i].color} - {carList[i].speed} - {carList[i].year}; Index = {i + 1}");
                        }
                        do
                        {
                            Console.Write("Enter the index to buy the car: ");
                            a = int.TryParse(Console.ReadLine(), out count);
                            Console.WriteLine("------------");
                            if (!a || count > carList.Count)
                                Console.WriteLine("Wrong index!");
                        } while (!a || count > carList.Count);
                        garage.addCar(count, carList);

                        break;
                    case 3:
                        if (garage.garageList == null)
                        {
                            Console.WriteLine("Garage is empty");
                        }
                        else
                        {
                            for (int i = 0; i < garage.garageList.Count; i++)
                            {
                                Console.WriteLine($"{garage.garageList[i].name} - {garage.garageList[i].color} - {garage.garageList[i].speed} - {garage.garageList[i].year}; Index = {i + 1}");
                            }
                            do
                            {
                                Console.Write("Enter the index to remove the car: ");
                                a = int.TryParse(Console.ReadLine(), out count);
                                Console.WriteLine("------------");
                                if (!a || count > garage.garageList.Count)
                                    Console.WriteLine("Wrong index!");
                            } while (!a || count > garage.garageList.Count);
                            garage.removeCar(count);
                        }

                        break;
                    case 4:
                        string carName = null, carColor = null;
                        int carSpeed = 0, carYear = 0;
                        if (garage.garageList == null)
                        {
                            Console.WriteLine("Garage is empty");
                        }
                        else
                        {
                            for (int i = 0; i < garage.garageList.Count; i++)
                            {
                                Console.WriteLine($"{garage.garageList[i].name} - {garage.garageList[i].color} - {garage.garageList[i].speed} - {garage.garageList[i].year}; Index = {i + 1}");
                            }
                            do
                            {
                                Console.WriteLine($"1) Car name {(carName == null ? "#" : carName)}");
                                Console.WriteLine($"2) Car color {(carColor == null ? "#" : carColor)}");
                                Console.WriteLine($"3) Car speed {(carSpeed == 0 ? 0 : carSpeed)}");
                                Console.WriteLine($"4) Car year {(carYear == 0 ? 0 : carYear)}");
                                Console.WriteLine("0) Exit");
                                Console.WriteLine("0 or # - any value");
                                do
                                {
                                    Console.Write("Enter your choise: ");
                                    a = int.TryParse(Console.ReadLine(), out count);
                                    if (!a || count >= 5)
                                        Console.WriteLine("Wrong number!");
                                } while (!a || count >= 5);
                                Console.WriteLine();
                                switch (count)
                                {
                                    case 1:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].name}");
                                        }
                                        carName = Console.ReadLine();

                                        break;
                                    case 2:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].color}");
                                        }
                                        carColor = Console.ReadLine();

                                        break;
                                    case 3:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].speed}");
                                        }
                                        do
                                        {
                                            Console.Write("Enter your choise: ");
                                            a = int.TryParse(Console.ReadLine(), out carSpeed);
                                            if (!a)
                                                Console.WriteLine("Wrong number!");
                                        } while (!a);

                                        break;
                                    case 4:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].year}");
                                        }
                                        do
                                        {
                                            Console.Write("Enter your choise: ");
                                            a = int.TryParse(Console.ReadLine(), out carYear);
                                            if (!a)
                                                Console.WriteLine("Wrong number!");
                                        } while (!a);
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine();
                                garage.chooseCar(carName, carColor, carSpeed, carYear);
                                Console.WriteLine();
                            } while (count != 0);
                        }

                        break;
                    default:
                        break;
                }

            } while (count != 0);
        }
    }
}