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


        
}
