namespace Taller_Mecanico.Class;

    public class Order 
    {
        public int id;
        public DateTime createdAt {get;set;}
        public Customer customer;
        public Employee employee;
        public string plateVehicle;
        public bool state;

        public Order(){
            this.createdAt = DateTime.Now;
        }
        public Order(Customer _customer, Employee _employee , string _plateVehicle){ 
            Random random = new Random();
            this.id = random.Next(0,100);
            this.createdAt = DateTime.Now;
            this.customer = _customer;
            this.employee = _employee;
            this.plateVehicle = _plateVehicle;
        }

        public int Id{
            get{return id;}
            set{id = value;}
        }
        public Customer Customer{
            get{return customer;}
            set{customer = value;}
        }
        public Employee Employee{
            get{return employee;}
            set{employee = value;}
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
