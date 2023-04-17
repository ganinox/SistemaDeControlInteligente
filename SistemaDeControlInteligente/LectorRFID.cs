using System;
using System.IO;

public class LectorRFID
{
    private int Id_Lector;
    private int Id_Puerta;
    private string logFilePath;

    public LectorRFID(int readerId, int doorId)
    {
        this.Id_Lector = readerId;
        this.Id_Puerta = doorId;
        this.logFilePath = "rfid_logs.txt";
        if (!File.Exists(this.logFilePath))
        {
            File.Create(this.logFilePath).Close();
        }
    }

    public void AbrirPuerta()
    {
        //Aqui se introduce el codigo de apertura de la puerta, dependiendo de el modelo del controlador o las librerias usadas este puede cambiar.
        //para efectos de demostracion solo se escribe en consola un mensaje de apertura.
        Console.WriteLine("Abriendo puerta...");
        this.LogOperationes("ABIERTO");
    }

    public void CerrarPuerta()
    {
        //Aqui se introduce el codigo de cierre de la puerta, dependiendo de el modelo del controlador o las librerias usadas este puede cambiar.
        //para efectos de demostracion solo se escribe en consola un mensaje de cierre.
        Console.WriteLine("Cerrando puerta...");
        this.LogOperationes("Cerrado");
    }

    private void LogOperationes(string operation)
    {
        //En este metodo se puede generar un registro al log del equipo con el lector o a la base de datos del sistema en cuestion.
        string timestamp = DateTime.Now.ToString();
        string logLine = $"{timestamp}\t{this.Id_Lector}\t{this.Id_Puerta}\t{operation}";
        using (StreamWriter writer = File.AppendText(this.logFilePath))
        {
            writer.WriteLine(logLine);
        }
    }
}
