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
    public Workshop(int _id, string _name, string _owner)
    {
        this.id = _id;
        this.name = _name;
        this.owner = _owner;
        this.customers = new List<Customer>();
        this.employees = new List<Employee>();
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }
    public List<Customer> Customers
    {
        get { return customers; }
        set { customers = value; }
    }
    public List<Employee> Employees
    {
        get { return employees; }
        set { employees = value; }
    }


    /// <summary>
    /// Show all employees in Employess List
    /// 
    /// </summary>
    public void ShowEmployees()
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Cedula: \t\t Nombre: \t\t Telefono \t\t Especialidades: ");
            Console.Write(employee.Id + "\t");
            Console.Write(employee.Name + "\t");
            Console.Write(employee.NumberPhone + "\t");
            foreach (string speciality in employee.Speaciality)
            {
                Console.Write(speciality + ", ");
            }

        }
    }
    /// <summary>
    /// Show All List Customers 
    /// </summary>
    public void ShowCustomers()
    {

        foreach (Customer customer in customers)
        {
            Console.WriteLine($"Cedula:\t\t Nombre: \t\t Telefono:\t\t Email: \t\t Creado:");
            Console.Write(customer.Id + "\t\t");
            Console.Write(customer.Name + "\t\t\t");
            Console.Write(customer.NumberPhone + "\t\t");
            Console.Write(customer.Email + "\t\t\t");
            Console.Write(customer.CreatedAt.ToString() + "\n\n");
            Console.WriteLine("Vehiculos del cliente: ");
            Console.WriteLine("Placa: \t Modelo: \t Marca: \t   Color: \t Kilometraje:");
            foreach (Vehicle vehicle in customer.Vehicles)
            {
                Console.Write(vehicle.Plate + ",\t  ");
                Console.Write(vehicle.Model + ",\t  ");
                Console.Write(vehicle.Brand + ",\t  ");
                Console.Write(vehicle.Color + ",\t  ");
                Console.Write(vehicle.Km + ". \n\n");
            }

        }
    }



}
