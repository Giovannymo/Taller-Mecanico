namespace Taller_Mecanico.Class
{
    public abstract class Person
    {
        
        public int Id;
        public string Name;
        public int NumberPhone;
    

        public Person (int id, string name, int numberPhone){
            this.Id = id;
            this.Name = name;
            this.NumberPhone = numberPhone;
        }

        public abstract Person Add();

        public void Remove(List<Person> Persons, int IdRemove){

            foreach(Person person in Persons){
                if(person.Id == IdRemove){
                    Persons.Remove(person);
                }
            }


        }

    }
}