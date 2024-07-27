using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Generar log en consola");
        Console.WriteLine("2. Generar log en PDF");

        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Log("Este es un mensaje de log en consola.");
        }
        else if (opcion == "2")
        {
            GenerarPDF("Este es un mensaje de log en PDF.");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    // Método para registrar logs en consola
    public static void Log(string message)
    {
        Console.WriteLine(message);
    }

    // Método para generar un PDF con logs
    public static void GenerarPDF(string message)
    {
        Document doc = new Document();
        try
        {
            PdfWriter.GetInstance(doc, new FileStream("Log.pdf", FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Log generado:"));
            doc.Add(new Paragraph(message));
            Console.WriteLine("PDF generado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al generar PDF: " + ex.Message);
        }
        finally
        {
            doc.Close();
        }
    }
}
