namespace Taller_Mecanico.Class;

    public class Customer : Person
    {
        public string lastName;
        public string email;
        public DateTime createdAt;
        public List<Vehicle> vehicles;
        public List<Order> orders;
        public List<Checkout> checkouts;

        public Customer(){
            this.createdAt =  DateTime.Now;
            this.vehicles = new List<Vehicle>();
            this.orders = new List<Order>();
            this.checkouts = new List<Checkout>();
        }

        public Customer(int _id, string _name, int _numberPhone, string _lastName, string _email) : base(_id, _name, _numberPhone)
        {
            this.lastName = _lastName;
            this.email = _email;
            this.createdAt =  DateTime.Now;
            this.vehicles = new List<Vehicle>();
            this.orders = new List<Order>();
            this.checkouts = new List<Checkout>();
        }

        public override Customer Add(){
            Console.WriteLine("Ingrese la cedula del cliente: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del cliente: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del cliente: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de telefono del cliente: ");
            int numberPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el email del cliente: ");
            string email =Console.ReadLine();

            Customer customer = new Customer(id,name,numberPhone,lastName,email);

            int option = 0;
            do{         
                try{
                    Console.WriteLine("#### Agregando vehiculo ####");
                    Vehicle vehicle = new Vehicle();
                    Vehicle newVehicle = vehicle.AddVehicle();
                    this.vehicles.Add(newVehicle);
                    Console.WriteLine("#### ¿Desea agregar otro vehiculo? #### \n "+
                                    "1. Si \n" + "2. No \n" + "0. Salir" );
                    option = int.Parse(Console.ReadLine());

                }catch(Exception e){
                    Console.WriteLine("Digite un valor valido");
                }
            }while(option != 0);
            
    
        
            return customer;
        }

        public override void Remove(List<Person> Customers){
            Console.WriteLine("Ingrese la cedula del Cliente: ");
            int IdRemove = int.Parse(Console.ReadLine());
             foreach(Customer customer in Customers){
                if(customer.Id == IdRemove){
                    Customers.Remove(customer);
                }
            }
        }
}