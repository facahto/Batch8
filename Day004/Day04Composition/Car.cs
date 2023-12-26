namespace CarComponent;

class Car
{
	public Engine engine; 
	//tipe data diganti dengan class 
	public Lamp lamp;
	
	public Car(Engine engine,Lamp lamp)
	{
		this.engine = engine;
		this.lamp = lamp;
	}
	
	
	public void Start()
	{
		engine.EngineRun();
		lamp.TurnOn();
	}
	//method
	public void ChangeEngine(Engine replacement)
	{
		engine= replacement;
	}
}