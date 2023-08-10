namespace Taller_Mecanico.Class
{
    public class Approved
    {
        public int id;
        public DateTime createdAt;
        public Employee employee;
        public List<Spare> sparesApproved;

        public Approved()
        {
        }
        public Approved(Employee _employee)
        {
            Random random = new Random();
            this.id = random.Next(0,100);
            this.createdAt = DateTime.Now;
            this.employee = _employee;
            this.sparesApproved = new List<Spare>();
        }

        public int Id{
            get{ return id; }
            set{ id = value; }
        }
        public DateTime CreatedAt{
            get{ return createdAt; }
            set{ createdAt = value; }
        }
        public Employee Employee{
            get{ return employee; }
            set{ employee = value; }
        }
        public List<Spare> SparesApproved{
            get{ return sparesApproved;}
            set{ sparesApproved = value; }
        }


        public void ApprovalOrder(List<Customer> customers){

            try
            {


                int option=0;

                do{
                    Console.WriteLine("#id \t Nombre \t Valor Unit. \t Cantidad \t Estado ");
                    foreach (Spare part in this.sparesApproved){
                        Console.Write(part.Id + "\t "+
                                        part.Name + "\t "+ 
                                        part.UnityValue + "\t "+ 
                                        part.Quantity + "\t "); 
                        if(part.State == false ){
                            Console.WriteLine("R");

                        }else{
                            Console.WriteLine("A");

                        }
                    }                    
                    Console.WriteLine("Ingrese el id del repuesto que quiere aprobar:  ");
                    int idSpare = int.Parse(Console.ReadLine());
                    Spare spareAprobation = this.sparesApproved.Find(spare => spare.Id == idSpare);
                    spareAprobation.state = true;

                    Console.WriteLine("¿Agregar otro?");
                    Console.WriteLine("1.Si    2.No");
                    option = int.Parse(Console.ReadLine());
                }while(option !=2);

                
                
            }
            catch(Exception e){
                Console.WriteLine("Ha ocurrido una excepción, intentelo de nuevo. "+ e.Message);
            }
        }


        public void AddSpareApproved(List<Spare> workshopSpares){
            try
            {
                int option = 0;

                do{ 
                    
                    foreach(Spare spare in workshopSpares){
                        spare.ShowSpare();
                    }
                    Console.WriteLine("Ingrese el ID del repuesto que quiere agregar: ");
                    int idSpare = int.Parse(Console.ReadLine());
                    Spare foundSpare = workshopSpares.Find(spare=> spare.Id == idSpare);
                    this.sparesApproved.Add(foundSpare);
                    
                    Console.WriteLine("¿Agregar otro?");
                    Console.WriteLine("1.Si    2.No");
                    option = int.Parse(Console.ReadLine());



                }while(option != 2);

                
 
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido una excepción, intentelo de nuevo. "+ e.Message);
            }

        }
    }
}