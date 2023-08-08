namespace Taller_Mecanico.Class
{
    public class Approved
    {
        public int id;
        public DateTime createdAt;
        public long idEmployee;
        public List<SpareOrder> spareParts;

        public Approved()
        {
        }
        public Approved(long _idEmployee)
        {
            Random random = new Random();
            this.id = random.Next(0,100);
            this.createdAt = DateTime.Now;
            this.idEmployee = _idEmployee;
            this.spareParts = new List<SpareOrder>();
        }


        public void ApprovalDetails(){
            try
            {
                Console.WriteLine("#id \t Nombre \t Valor Unit. \t Cantidad \t Estado ");
                foreach (SpareOrder part in spareParts){
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


    }
}