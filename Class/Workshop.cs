namespace Taller_Mecanico.Class; 

    public class Workshop
    {
        public int id;
        public string name;
        public string owner;
        public List<Customer> customers;
        public List<Employee> employees;

        public Workshop()
        {
        }
        public Workshop(int _id, string _name, string _owner){
            this.id = _id;
            this.name = _name;
            this.owner = _owner;
            this.customers = new List<Customer>();
            this.employees = new List<Employee>();
        }

        public int Id{
            get{ return id; }
            set{ id = value; }
        }
        public string Name{
            get{ return name; }
            set{ name = value; }
        }
        public string Owner{
            get{ return owner; }
            set{ owner = value; }
        }
        public List<Customer> Customers{
            get{ return customers; }
            set{ customers = value; }	
        }
        public List<Employee> Employees{
            get{ return employees; }
            set{ employees = value; }
        }


/// <summary>
/// Show all employees in Employess List
/// 
/// </summary>
        public void ShowEmployees(){
            foreach (Employee employee in employees){
                Console.WriteLine($"Cedula: \t\t Nombre: \t\t Telefono \t\t Especialidades: ");
                Console.Write(employee.Id+"\t");
                Console.Write(employee.Name+"\t");
                Console.Write(employee.NumberPhone+"\t");
                foreach(string speciality in employee.Speaciality){
                    Console.Write(speciality + ", ");
                }
               
            }
        }
        /// <summary>
        /// Show All List Customers 
        /// </summary>
        public void ShowCustomers(){
            foreach (Customer customer in customers){
                Console.WriteLine($"Cedula: \t\t Nombre: \t\t Telefono: \t\t Email: \t\t\t  Creado:");
                Console.Write(customer.Id+"\t");
                Console.Write(customer.Name+"\t");
                Console.Write(customer.NumberPhone+"\t");
                Console.Write(customer.email+"\t\n");
                Console.Write(customer.CreatedAt.ToString());
                Console.WriteLine("Vehiculos del cliente: ");
                foreach(Vehicle vehicle in customer.vehicles){
                    Console.WriteLine("Placa: \t\t Modelo: \t\t Marca: \t\t Color: \t\t Kilometraje:" );
                    Console.Write(vehicle.Plate + ", ");
                    Console.Write(vehicle.Model + ", ");
                    Console.Write(vehicle.Brand + ", ");
                    Console.Write(vehicle.Color + ", ");
                    Console.Write(vehicle.Km + ". ");
                }
               
            }
        }



}
