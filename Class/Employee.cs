namespace Taller_Mecanico.Class;

    public class Employee : Person
    {   
        public List<string> speciality;

        public List<string> Speaciality{
            get{ return speciality;}
            set{ speciality = value;}
        }
        public Employee(){

        }
        public Employee(long _id, string _name, long _numberPhone) : base(_id, _name, _numberPhone)
        {
            this.speciality = new List<string>();
        }

        public override Employee Add()
        {
            try
            {
                Console.WriteLine("Ingrese la cedula del empleado: ");
                long id = long.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del empleado: ");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de telefono del empleado: ");
                long numberPhone = long.Parse(Console.ReadLine()); 

                Employee employee = new Employee(id, name, numberPhone);

                int option = 1;
                do{         
                
                    Console.Clear();
                    
                    Console.WriteLine("#### Agregando especialidades ####");
                    Console.WriteLine("Ingrese la especialidad del empleado: ");
                    string speciality = Console.ReadLine();
                    employee.Speaciality.Add(speciality);
                    Console.WriteLine("#### ¿Desea agregar otra especialidad? #### \n "+
                                    "1. Si \n" + "2. No \n");
                    option = int.Parse(Console.ReadLine());
                }while(option != 2);
         
                return employee;
            }
            catch (Exception e)
            {
                
                throw new Exception("Ocurrio una excepcion" + e.Message);
                return null;    
            }

        }
        public override List<Person> Remove(List<Person> Employees){
            Console.WriteLine("Ingrese la cedula del Empleado: ");
            int IdRemove = int.Parse(Console.ReadLine());
             foreach(Employee employee in Employees){
                if(employee.Id == IdRemove){
                    Employees.Remove(employee);
                    break;
                }
            }
            return Employees;
        }

    }
