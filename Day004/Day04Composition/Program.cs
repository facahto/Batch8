using CarComponent;

class Program
{
	static void Main()
	{
		//1.
		/*
		// declare dulu class yang ngegantiin type datanya
		Engine engine = new Engine();
		Lamp lamp = new Lamp();
		
		engine.cylinder = 4;
		
		Car car = new Car(engine,lamp);
		car.Start();*/
		
		//2.
		/*Engine engine = new Engine();
		Engine engine1 = new Engine();
		Lamp lamp = new Lamp();
		Car car = new Car(engine,lamp);
		engine1.cylinder = 5;
		car.ChangeEngine(engine1);
		car.Start();*/
		
		
		//3.
		Engine engine = new Engine();
		Lamp lamp = new Lamp();
		engine.cylinder = 4;
		ElectricEngine  electricEngine = new();
		//awal : Car car = new char(engine,lamp);
		Car newcar = new Car(electricEngine,lamp);
		newcar.Start();
	}
}