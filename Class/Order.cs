namespace Taller_Mecanico.Class;

    public class Order 
    {
        public int id;
        public DateTime createdAt {get;set;}
        public long idCustomer;
        public long idEmployee;
        public string plateVehicle;
        public bool state;

        public Order(){
            this.createdAt = DateTime.Now;
        }
        public Order(long _idCustomer, long _idEmployee, string _plateVehicle){ 
            Random random = new Random();
            this.id = random.Next(0,100);
            this.createdAt = DateTime.Now;
            this.idCustomer = _idCustomer;
            this.idEmployee = _idEmployee;
            this.plateVehicle = _plateVehicle;
        }

        public int Id{
            get{return id;}
            set{id = value;}
        }
        public long IdEmployee{
            get{return idEmployee;}
            set{idEmployee = value;}
        }
        public string PlateVehicle{
            get{return plateVehicle;}
            set{plateVehicle = value;}
        }
        

        public Order GenerateOrder(List<Person> customers){
            Console.WriteLine("Ingrese la cedula del Cliente:");
            long idCustomer = long.Parse(Console.ReadLine());
            Person foundCustomer = customers.Find(customer => customer.Id == idCustomer);
            Customer customer = foundCustomer as Customer;

            //Vehicle customerVehicle = customer.Vehicles.Find(vehicle => vehicle.Plate == )


            Order order = new Order();

            return new Order();
        }




        
    }
