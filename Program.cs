namespace Taller_Mecanico.Class;


internal class Program
{
    private static void Main(string[] args)
    {   
        Workshop workshop = new Workshop(1,"Honda motors", "Mrs.Hundido");
        bool next = true;
        do{
            MainMenu mainMenu = new MainMenu();
            int mainOption = mainMenu.Menu();

            Customer customer = new Customer();
            Employee employee = new Employee();
            Approved approved = new Approved();


            switch(mainOption){
                //Create and Add a new Customer
                case 1:
                    Customer newCustomer = customer.Add();
                    workshop.Customers.Add(newCustomer);
                    workshop.ShowCustomers();

                    break;
                //Deleted and Update List Customers of Workshop
                case 2:
                    List<Person> newListCostumers = customer.Remove(workshop.Customers);
                    workshop.Customers = newListCostumers;
                    workshop.ShowCustomers();

                    break;
                //Create and Add a new Employee
                case 3:
                    Employee newEmployee = employee.Add();
                    workshop.Employees.Add(newEmployee);
                    workshop.ShowEmployees();

                    break;
                //Deleted and Update List Employees of Workshop
                case 4:
                    List<Person> newListEmployees = employee.Remove(workshop.Employees);
                    workshop.Employees = newListEmployees;
                    workshop.ShowEmployees();

                    break;
                //Add new Vehicle to Customer
                case 5:
                    try
                    {
                        Console.WriteLine("Ingrese la cedula del cliente para agregar un nuevo vehiculo: ");
                        long idCustomer = long.Parse(Console.ReadLine());
                        Person findCustomer = workshop.Customers.Find( customer => customer.Id == idCustomer );
                        
                        if(findCustomer != null){
                            Vehicle vehicle = new Vehicle();
                            Vehicle newVehicle = vehicle.AddVehicle();
                            Customer customerVehicle = findCustomer as Customer;
                            customerVehicle.Vehicles.Add(newVehicle);
                        }

                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ocurrió una excepción, intentelo de nuevo." + e.Message);
                    }
                    workshop.ShowCustomers();
                    Console.WriteLine("Agregado con éxito.\n\n");

                    break;
                //Deleted Vehicles to Customer
                case 6:
                    Vehicle removeVehicle = new Vehicle();
                    removeVehicle.RemoveVehicle(workshop.Customers);
                    Console.WriteLine("El auto se removió con éxito. \n");

                    break;
                //Add new Spare to workshop                   
                case 7:
                    Spare spare = new();
                    workshop.Spares.Add(spare.AddSpare());
                    Console.WriteLine("El repuesto se agregó con éxito. \n");
                    break;
                //Create a new order
                case 8:
                    Order order = new Order();
                    order.GenerateOrder(workshop.Customers, workshop.Employees);
                    break;
                //Add spare to Order Approved
                case 9:
                    approved.AddSpareApproved(workshop.Spares);
                    break;
                //Client aproved Spared
                case 10:
                    Console.WriteLine("Ingrese el id del cliente: ");
                    long idCustomer = long.Parse(Console.ReadLine());
                    Customer foundCustomer = workshop.Customers.Find( customer => customer.Id == idCustomer );

                case 11: 
                    workshop.ShowCustomers();
                    break;
                case 12:
                    workshop.ShowEmployees();
                    break;    
                case 13:
                    workshop.ShowSpares();
                    break;
                case 0:
                    next = false;
                    break;
            }


        }while(next);
        
        
       
    }
}