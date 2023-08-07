namespace Taller_Mecanico.Class;

    public abstract class Person
    {
        
        public long id;
        public string name;
        public long numberPhone;
    

        public Person(){

        }
        public Person (long _id, string _name, long _numberPhone){
            this.id = _id;
            this.name = _name;
            this.numberPhone = _numberPhone;
        }

        public long Id{
            get{ return id; }
            set{ id = value; }
        }
        public string Name{
            get{ return name; }
            set{ name = value; }
        }

        public long NumberPhone{
            get{ return numberPhone; }
            set{ numberPhone = value; }
        }

/// <summary>
/// Created a new object person
/// </summary>
/// <returns>Object Person</returns>
        public abstract Person Add();
        
/// <summary>
/// Removed a object Person
/// </summary>
/// <param name="Persons">List of Persons</param>
        public abstract List<Person>  Remove(List<Person> Persons);


    }