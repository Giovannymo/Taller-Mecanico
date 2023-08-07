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

            switch(mainOption){
                //Create and Add a new Customer
                case 1:
                    Customer customer = new Customer();
                    Customer newCustomer = customer.Add();
                    workshop.Customers.Add(newCustomer);
                    workshop.ShowCustomers();

                    break;
                //Deleted and Update List Customer of Workshop
                case 2:
                    Customer customerRemove = new Customer();
               
                    List<Person> newListCostumers = customerRemove.Remove(workshop.Customers);
                    workshop.Customers = newListCostumers;
                    workshop.ShowCustomers();

                    break;
                //Create and Add a new Employee
                case 3:
                    Employee employee = new Employee();
                    Employee newEmployee = employee.Add();
                    workshop.Employees.Add(newEmployee);
                    workshop.ShowEmployees();

                    break;
                case 4:
                    Employee employeeRemove = new Employee();
                    List<Person> newListEmployees = employeeRemove.Remove(workshop.Employees);
                    workshop.Employees = newListEmployees;
                    workshop.ShowEmployees();
                    break;
                case 10: 
                    workshop.ShowCustomers();
                    break;
                case 11:
                    workshop.ShowEmployees();
                    break;
                case 0:
                    next = false;
                    break;
            }


        }while(next);
        
        
       
    }
}