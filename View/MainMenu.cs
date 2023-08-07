namespace Taller_Mecanico.Class;

    public class MainMenu
    {
        public int Menu(){
            int option =1;

            try{
                Console.WriteLine("\n********** TALLER MECANICO **********");
                Console.WriteLine("1. REGISTRAR CLIENTE. " + "\n"
                                + "2. ELIMINAR CLIENTE."  + "\n"
                                + "3. AGREGAR EMPLEADO."  + "\n"
                                + "4. ELIMINAR EMPLEADO."  + "\n"
                                + "5. REGISTRAR VEHICULO A CLIENTE EXISTENTE."  + "\n"
                                + "6. ELIMINAR VEHICULO A CLIENTE EXISTENTE."  + "\n"
                                + "7. GENERAR UNA ORDEN DE SERVICIO AL CLIENTE."  + "\n"
                                + "8. AGREGAR UNA NUEVA ORDEN DE APROBACION ."  + "\n"
                                + "9. MOSTRAR CLIENTES ."  + "\n"
                                + "10. MOSTRAR EMPLEADOS ."  + "\n"
                                + "11. ENTREGAR VEHICULO(S) Y FACTURA FINAL."  + "\n"
                                + "0. SALIR."  + "\n");
                                option= int.Parse(Console.ReadLine());

            }catch(Exception e){
                Console.WriteLine("Digite un valor valido, Vuelva a intentarlo. "+ e.Message);
            }
            return option;

        }

    }
