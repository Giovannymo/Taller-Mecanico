namespace Taller_Mecanico.Class;

    public class Vehicle
    {
        public int id;
        public string plate;
        public int model;
        public string brand;
        public string color;
        public int km;
             
        public Vehicle(){
            
        }

        public Vehicle(int _id, string _plate, int _model, string _brand, string _color, int _km){
            this.id = _id;
            this.plate = _plate;
            this.model = _model;
            this.brand = _brand;
            this.color = _color;
            this.km = _km;
        }

        public int Id{
            get { return id; }
            set { id = value; }
        }

        public string Plate{
            get { return plate; }
            set { plate = value; }
        }
        public int Model{
            get { return model; }
            set { model = value; }
        }
        public string Brand{
            get { return brand; }
            set { brand = value; }
        }
        public string Color{
            get { return color; }
            set { color = value; }
        }
        public int Km{
            get { return km; }
            set { km = value; }
        }



/// <summary>
/// Created a new object Vehicle
/// </summary>
/// <returns>Object vehicle</returns>
        public Vehicle AddVehicle(){

            Console.WriteLine("Ingrese el id del vehiculo: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la placa del vehiculo: ");
            string plate = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo: ");
            int model = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la marca del vehiculo: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Ingrese el color del vehiculo: ");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el kilometraje del vehiculo: ");
            int km = int.Parse(Console.ReadLine());

            Vehicle vehicle= new Vehicle(id,plate,model,brand,color,km);

            return vehicle;
        }


        public void RemoveVehicle(List<Vehicle> vehicles){
            Console.WriteLine("Ingrese la placa del vehiculo a remover: ");
            string removePlate = Console.ReadLine();
            foreach(Vehicle vehicle in vehicles){
                if(vehicle.Plate.Equals(removePlate)){
                    vehicles.Remove(vehicle);
                }
            }

        }
        


    }
