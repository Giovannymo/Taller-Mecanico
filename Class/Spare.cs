namespace Taller_Mecanico.Class;

    public class Spare
    {
        public int id;
        public string name;
        public long unityValue;
        public int quantity;
        public bool state = false;

    public Spare()
    {
    }
    public Spare(string _name, long _unityValue, int _quantity)
    {   
        Random random = new Random();
        this.id = random.Next(0,100);
        this.name = _name;
        this.unityValue = _unityValue;
        this.quantity = _quantity;
    }


    public int Id{
        get{ return id; }
        set{ id = value; }
    }
    public string Name{
        get{ return name; }
        set{ name = value; }
    }
    public long UnityValue{
        get{ return unityValue; }
        set{ unityValue = value; }
    }
    public int Quantity{
        get{ return quantity; }
        set{ quantity = value; }
    }
    public bool State{
        get{ return state; }
        set{ state = value; }
    }

    public Spare AddSpare(){
        try{
            Console.WriteLine("Ingrese el nombre del repuesto");
            string nameSpare = Console.ReadLine();
            Console.WriteLine("Ingrese el valor unitario del repuesto: ");
            long unityValue = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad: ");
            int quantitySpare = int.Parse(Console.ReadLine());
            Spare spare = new Spare(nameSpare, unityValue, quantitySpare);   

            return spare;

        } catch(Exception e){
            Console.WriteLine("Ha ocurrido una excepción, intentelo de nuevo. "+ e.Message);
        }
        Console.WriteLine("");


        return null;
    }
    public void ShowSpare(){
        Console.WriteLine("#ID \t Nombre \t Valor Unit. \t");
        Console.WriteLine(this.Id + "\t" + this.Name + "\t" + this.unityValue);


    }

  /*   public List<SpareOrder> RemoveSpare(List<SpareOrder> allSpare){
        try{
            Console.WriteLine("Ingrese el id del repuesto a eliminar");
            



        }catch(Exception e){
            Console.WriteLine("Ha ocurrido una excepción, intentelo de nuevo. "+ e.Message);
        }
        return allSpare;
    } */


}
