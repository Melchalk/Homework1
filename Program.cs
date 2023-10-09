Console.WriteLine("Hello, World!");

class Bag
{
    public int PizzaPieces { get; set; }
    public int BeerBottles { get; set; }
    public double Capacity { get; set; }
    private const double pizzaInLiters = 0.3,
        beerInLiters = 0.5;

    public bool AddPizza(int pizzaPieces, Bag bag)
    {
        double countPizzaLiters = pizzaPieces * pizzaInLiters;
        if (bag.Capacity - countPizzaLiters >= 0)
        {
            bag.Capacity -= countPizzaLiters;
            return true;
        }
        return false;
    }

    public bool AddBeer(int beerBottles, Bag bag)
    {
        double countBeerLiters = beerBottles * beerInLiters;
        if (bag.Capacity - countBeerLiters >= 0)
        {
            bag.Capacity -= countBeerLiters;
            return true;
        }
        return false;
    }
}

class Student
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
            return "Трез";
        else if (levelDrunk > normalDrunk)
            return "Перепил";
        else
            return "В самый раз";
    }
}