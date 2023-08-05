namespace Taller_Mecanico.Class
{
    public class Employee : Person
    {   
        public string speciality;

        public string Speaciality{
            get{ return speciality;}
            set{ speciality = value;}
        }
        public Employee(){

        }
        public Employee(int _id, string _name, int _numberPhone, string _speciality) : base(_id, _name, _numberPhone)
        {
            this.speciality = _speciality;
        }

        public override Employee Add()
        {
            Console.WriteLine("Ingrese la cedula del empleado: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de telefono del empleado: ");
            int numberPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la especialidad del empleado: ");
            string speciality = Console.ReadLine();

            Employee employee = new Employee(id, name, numberPhone, speciality);

            return employee;
        }
        public override void Remove(List<Person> Employees){
            Console.WriteLine("Ingrese la cedula del Empleado: ");
            int IdRemove = int.Parse(Console.ReadLine());
             foreach(Employee employee in Employees){
                if(employee.Id == IdRemove){
                    Employees.Remove(employee);
                }
            }
        }

    }
}