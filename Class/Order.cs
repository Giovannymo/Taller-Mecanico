namespace Taller_Mecanico.Class;

    public class Order 
    {
        public int id;
        public DateTime createdAt {get;set;}
        public Customer customer;
        public Employee employee;
        public Vehicle vehicle;
        public string diagnosticCustomer;
        public string diagnosticEmployee;
        public Approved orderApproved;
        public bool state;

        public Order(){
            this.createdAt = DateTime.Now;
        }
        public Order(Customer _customer, Employee _employee , Vehicle _vehicle, string _diagnosticCustomer, string _diagnosticEmployee, Approved _orderApproved ){ 
            Random random = new Random();
            this.id = random.Next(0,100);
            this.createdAt = DateTime.Now;
            this.customer = _customer;
            this.employee = _employee;
            this.vehicle = _vehicle;
            this.diagnosticCustomer = _diagnosticCustomer;
            this.diagnosticEmployee = _diagnosticEmployee;
            this.orderApproved = _orderApproved;
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
        public Vehicle Vehicle{
            get{return vehicle;}
            set{vehicle = value;}
        }
        public string DiagnosticCustomer{
            get{return diagnosticCustomer;}
            set{diagnosticCustomer = value;}
        }
        public string DiagnosticEmployee{
            get{return diagnosticEmployee;}
            set{diagnosticEmployee = value;}
        }
        public Approved OrderApproved{
            get{return orderApproved;}
            set{orderApproved = value;}
        }
        

        public Order GenerateOrder(List<Person> customers, List<Person> employees){
            try
            {
                Console.WriteLine("Ingrese la cedula del Cliente:");
                long idCustomer = long.Parse(Console.ReadLine());
                Person foundCustomer = customers.Find(customer => customer.Id == idCustomer);
                Customer customer = foundCustomer as Customer;

                Console.WriteLine("Ingrese el diagnostico del Cliente:");
                string diagnosticCustomer = Console.ReadLine();

                Console.WriteLine("Ingrese la cedula del Encargado:");
                long idEmployee = long.Parse(Console.ReadLine());
                Person foundEmployee = employees.Find(employee => employee.Id == idEmployee);
                Employee employee = foundEmployee as Employee;
                
                Console.WriteLine("Ingrese el diagnostico del Encargado:");
                string diagnosticEmployee = Console.ReadLine();

                Console.WriteLine("Ingrese la placa del vehiculo:");
                string plateVehicle = Console.ReadLine();
                Vehicle foundVehicle = customer.Vehicles.Find(vehicle => vehicle.Plate == plateVehicle);
                Approved orderApproved = new Approved(employee);
                Order order = new Order(customer, employee, foundVehicle, diagnosticCustomer, diagnosticEmployee, orderApproved);
                customer.Orders.Add(order);
                return order;
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Ocurrió una excepción, intentelo de nuevo." + e.Message);

            }

            return null;
        }



        public void ShowOrder(){
            
            Console.WriteLine("########### DATOS DE LA ORDEN ###########");
            Console.WriteLine($"#Orden: {this.id} Fecha orden: {this.createdAt}\n"
                            +$"Id Cliente: {this.customer.Id} Nombre: {this.customer.Name}\n");
            Console.WriteLine("########### DATOS VEHICULO ###########");
            Console.WriteLine($"#Placa: {this.vehicle.Plate} Km: {this.vehicle.Km}\n");
            Console.WriteLine("########### DIAGNOSTICO CLIENTE ###########");
            Console.WriteLine(this.diagnosticCustomer);
            Console.WriteLine("########### PERSONA A CARGO ###########");
            Console.WriteLine($"#Nro CC: {this.employee.Id} Nombre: {this.employee.Name}\n"
                            +$"Especialidad: {this.employee.Speaciality}\n"); 
            Console.WriteLine("########### DIAGNOSTICO EXPERTO ###########");
            Console.WriteLine(this.diagnosticEmployee);


        }
        
    }

