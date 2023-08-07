namespace Taller_Mecanico.Class;


internal class Program
{
    private static void Main(string[] args)
    {   
        Workshop workshop = new Workshop(1,"Honda motors", "Mrs.Hundido");
        int mainOption = 1;
        do{
            MainMenu mainMenu = new MainMenu();
            mainOption = mainMenu.Menu();

            switch(mainOption){
                case 1:
                    Customer customer = new Customer();
                    Customer newCustomer = customer.Add();
                    Console.WriteLine(newCustomer.Name);
                    workshop.Customers.Add(newCustomer);
                    workshop.ShowCustomers();

                    break;
                case 2:
                    Customer customerRemove = new Customer();
               
                    List<Person> newListCostumers = customerRemove.Remove(workshop.Customers);
                    workshop.Customers = newListCostumers;
                    workshop.ShowCustomers();

                    break;
                case 10: 
                    workshop.ShowCustomers();
                    break;
                case 0:
                 Console.WriteLine("Apagando...");
                     break;
            }


        }while(mainOption != 0);
        
        
       
    }
}