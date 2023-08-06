namespace Taller_Mecanico.Class;

    public class MainMenu
    {
        public int Menu(){
            int option =0;
            try{
                Console.Clear();
                Console.WriteLine("********** TALLER MECANICO **********");
                Console.WriteLine("1. REGISTRAR CLIENTE. " + "\n"
                                + "2. ELIMINAR CLIENTE."  + "\n"
                                + "3. AGREGAR EMPLEADO."  + "\n"
                                + "4. ELIMINAR EMPLEADO."  + "\n"
                                + "5. AGREGAR NUEVA ESPECIALIDAD A EMPLEADO."  + "\n"
                                + "6. REGISTRAR VEHICULO A CLIENTE EXISTENTE."  + "\n"
                                + "7. ELIMINAR VEHICULO A CLIENTE EXISTENTE."  + "\n"
                                + "8. GENERAR UNA ORDEN DE SERVICIO AL CLIENTE."  + "\n"
                                + "9. AGREGAR UNA NUEVA ORDEN DE APROBACION ."  + "\n"
                                + "10. ENTREGAR VEHICULO(S) Y FACTURA FINAL."  + "\n"
                                + "0. SALIR."  + "\n");
                                option= int.Parse(Console.ReadLine());

            }catch(Exception e){
                Console.WriteLine("Digite un valor valido, Vuelva a intentarlo");
            }
            return option;

        }

    }
