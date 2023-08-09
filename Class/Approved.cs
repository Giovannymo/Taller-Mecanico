namespace Taller_Mecanico.Class
{
    public class Approved
    {
        public int id;
        public DateTime createdAt;
        public Employee employee;
        public List<Spare> spareParts;

        public Approved()
        {
        }
        public Approved(Employee _employee)
        {
            Random random = new Random();
            this.id = random.Next(0,100);
            this.createdAt = DateTime.Now;
            this.employee = _employee;
            this.spareParts = new List<Spare>();
        }


        public void ApprovalDetails(){
            try
            {
                Console.WriteLine("#id \t Nombre \t Valor Unit. \t Cantidad \t Estado ");
                foreach (Spare part in spareParts){
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
                
            }
            catch(Exception e){
                Console.WriteLine("Ha ocurrido una excepción, intentelo de nuevo. "+ e.Message);
            }
        }

        public void AddSpare(){
            Spare part = new();
            Spare spareOrder = part.AddSpare();
            this.spareParts.Add(spareOrder);
        }
    }
}