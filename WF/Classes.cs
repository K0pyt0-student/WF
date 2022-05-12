public enum driveType { Полный_привод, Передний_привод, Задний_привод }

class CargoTransport
{
    protected string name;
    protected int carWeight;
    protected int maxDistance;
    protected int maxWeight;
    protected int cargoWeight;


    protected CargoTransport()
    {
        name = "Аааааавтомобиииль";
        carWeight = 1;
        maxDistance = 1000;
        maxWeight = 10;
        cargoWeight = 10;
    }

    protected CargoTransport(string name)
    {
        this.name = name;
        carWeight = 1;
        maxDistance = 1000;
        maxWeight = 10;
        cargoWeight = 10;
    }

    protected CargoTransport(string name, int carWeight, int distance, int maxWeight, int cargoWeight)
    {
        this.name = name;
        this.carWeight = carWeight;
        maxDistance = distance;
        if (maxWeight >= cargoWeight) this.maxWeight = maxWeight;
        else this.maxWeight = cargoWeight;
        this.cargoWeight = cargoWeight;
    }

    /*public virtual void Show()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Вес транспорта: {carWeight}");
        Console.WriteLine($"Максимальное расстояние: {maxDistance}");
        Console.WriteLine($"Максимальный возможный вес: {maxWeight}");
        Console.WriteLine($"Вес груза: {cargoWeight}");
    }*/

    protected string CarName
    {
        get { return name; }
    }

    public virtual int TotalWeight
    {
        get { return carWeight + cargoWeight; }
    }

    public virtual int CargoWeight
    {
        get { return cargoWeight; }
        set
        {
            if (value < maxWeight) cargoWeight = value;
            else
            {
                maxWeight = value;
                cargoWeight = value;
            }
        }
    }

    public virtual int WeightDistance
    {
        get { return maxDistance * carWeight / (carWeight + cargoWeight); }
    }
}

class WheeledTransport : CargoTransport
{
    protected int wheelAm;
    protected driveType drive;

    protected WheeledTransport(string name) : base(name)
    {
        wheelAm = 4;
        drive = driveType.Полный_привод;
    }

    protected WheeledTransport(int wheelAm, string name) : base(name)
    {
        this.wheelAm = wheelAm;
        drive = driveType.Полный_привод;
    }

    protected WheeledTransport(string name, int carWeight, int distance, int maxWeight, int cargoWeight, int wheelAm, int drive)
        : base(name, carWeight, distance, maxWeight, cargoWeight)
    {
        this.wheelAm = wheelAm;
        this.drive = (driveType)drive;
    }

    /*public override void Show()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Вес транспорта: {carWeight}");
        Console.WriteLine($"Максимальное расстояние: {maxDistance}");
        Console.WriteLine($"Максимальный возможный вес: {maxWeight}");
        Console.WriteLine($"Вес груза: {cargoWeight}");
        Console.WriteLine($"Количество колёс: {wheelAm}");
        Console.WriteLine($"Привод: {drive}");
    }*/

    public override int WeightDistance
    {
        get { return maxDistance * carWeight / (carWeight + cargoWeight); }
    }
}

class Train : WheeledTransport
{
    private int wagonAm;

    public Train() : base(80, "Поезд")
    {
        wagonAm = 10;
    }

    public Train(string name, int carWeight, int distance, int maxWeight, int cargoWeight, int wheelAm, int wagonAm)
    : base(name, carWeight, distance, maxWeight, cargoWeight, wheelAm, 1)
    {
        this.wagonAm = wagonAm;
    }

    /*public override void Show()
    {
        Console.WriteLine($"Н


азвание: { name}
        ");
            Console.WriteLine($"Вес транспорта: {carWeight}");
        Console.WriteLine($"Максимальное расстояние: {maxDistance}");
        Console.WriteLine($"Максимальный возможный вес: {maxWeight}");
        Console.WriteLine($"Вес груза: {cargoWeight}");
        Console.WriteLine($"Количество колёс: {wheelAm * wagonAm}");
        Console.WriteLine($"Привод: {drive}");
        Console.WriteLine($"Колчисество вагонов:{wagonAm}");
    }*/

    public override int CargoWeight
    {
        get { return cargoWeight * wagonAm; }
        set
        {
            if (value < maxWeight) cargoWeight = value;
            else
            {
                maxWeight = value;
                cargoWeight = value;
            }
        }
    }

    public override int TotalWeight
    {
        get { return carWeight + cargoWeight; }
    }

    public override int WeightDistance
    {
        get { return maxDistance * carWeight / (carWeight + cargoWeight); }
    }
}

class CargoCar : WheeledTransport
{
    protected int driversAm;

    public CargoCar(string name) : base(name)
    {
        driversAm = 1;
    }

    public CargoCar(string name, int carWeight, int distance, int maxWeight, int cargoWeight, int wheelAm, int drive, int driversAm)
    : base(name, carWeight, distance, maxWeight, cargoWeight, wheelAm, drive)
    {
        this.driversAm = driversAm;
    }

    /*public override void Show()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Вес транспорта: {carWeight}");
        Console.WriteLine($"Максимальное расстояние: {maxDistance}");
        Console.WriteLine($"Максимальный возможный вес: {maxWeight}");
        Console.WriteLine($"Вес груза: {cargoWeight}");
        Console.WriteLine($"Количество колёс: {wheelAm}");
        Console.WriteLine($"Привод: {drive}");
        Console.WriteLine($"Количество водителей на маршруте: {driversAm}");
    }*/

    public override int CargoWeight
    {
        get { return cargoWeight + driversAm; }
        set
        {
            if (value < maxWeight) cargoWeight = value;
            else
            {
                maxWeight = value;
                cargoWeight = value;
            }
        }
    }

    public override int TotalWeight
    {
        get { return carWeight + cargoWeight; }
    }
}

class Pickup : CargoCar
{
    private bool isTherePassenger;

    public Pickup() : base("Пикап")
    {
        isTherePassenger = false;
    }

    public Pickup(string name, int carWeight, int distance, int maxWeight, int cargoWeight, int wheelAm, int drive, int driversAm, bool isThere)
        : base(name, carWeight, distance, maxWeight, cargoWeight, wheelAm, drive, driversAm)
    {
        isTherePassenger = isThere;
    }

    public override int CargoWeight
    {
        get
        {
            if (isTherePassenger) return cargoWeight + driversAm + 1;
            else return cargoWeight + driversAm;
        }
        set
        {
            if (value < maxWeight) cargoWeight = value;
            else
            {
                maxWeight = value;
                cargoWeight = value;
            }
        }
    }

    public override int TotalWeight
    {
        get
        {
            if (isTherePassenger) return carWeight + cargoWeight + driversAm + 1;
            else return carWeight + cargoWeight + driversAm;
        }
    }
}

class BigWeight : CargoCar
{
    private int tanksAm;
    public BigWeight() : base("Большегруз")
    {
        tanksAm = 1;
    }

    public BigWeight(string name, int carWeight, int distance, int maxWeight, int cargoWeight, int wheelAm,

int drive, int driversAm, int tanksAm)
   : base(name, carWeight, distance * tanksAm, maxWeight, cargoWeight, wheelAm, drive, driversAm)
    {
        this.tanksAm = tanksAm;
    }

    public override int TotalWeight
    {
        get
        {
            return carWeight + cargoWeight + driversAm + tanksAm;
        }
    }

    /*public override void Show()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Вес транспорта: {carWeight}");
        Console.WriteLine($"Максимальное расстояние: {maxDistance}");
        Console.WriteLine($"Максимальный возможный вес: {maxWeight}");
        Console.WriteLine($"Вес груза: {cargoWeight}");
        Console.WriteLine($"Количество колёс: {wheelAm}");
        Console.WriteLine($"Привод: {drive}");
        Console.WriteLine($"Количество водителей на маршруте: {driversAm}");
        Console.WriteLine($"Количество баков: {tanksAm}");
    }*/

    public override int WeightDistance
    {
        get { return maxDistance * tanksAm * carWeight / (carWeight + cargoWeight); }
    }
}