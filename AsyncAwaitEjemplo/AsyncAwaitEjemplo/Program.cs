using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

/*
 * Async es una palabra clave que se puede utilizar para declarar un método asincrónico.
 * y Await es una palabra clave que se puede utilizar para indicar al compilador que la ejecución 
 * del método debe esperar a que se complete una operación asincrónica.
 * 
 * Ademas de las palabras clave async y await, el código asincrónico también se puede escribir 
 * de forma explícita utilizando la clase Task y los métodos ContinueWith.
 *  
 * Hacer programas asincrónicos es una forma de escribir código que no bloquea el hilo de ejecución
 * y permite que el programa siga ejecutando otras tareas mientras se espera a que se complete una operación.
 * o se pueden hacer tareas en paralelo.
 * Como nuestro ejemplo, descargamos 3 imágenes en paralelo.
 * 
 */

class Program
{
    static async Task Main(string[] args)
    {
        // Ruta completa al directorio "Downloads" del disco C
        string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        // Crear la carpeta de destino si no existe
        Directory.CreateDirectory(downloadsPath);

        // Lista de URLs de imágenes a descargar
        List<string> imageUrls = new List<string>
        {
            "https://www.packagecostarica.com/wp-content/uploads/2013/05/Punta-Caracol-Air-Shot_mini.jpg",
            "https://www.brightwaterholidays.com/media/4070/gardens-costa-rica-arenal-volcano-in-costa-rica-hero.jpg",
            "https://www.holidayhypermarket.co.uk/wp-content/uploads/2021/05/CostaRica-shutterstock_445483960.png"
        };

        // Crear un cliente HttpClient para las descargas
        using (HttpClient httpClient = new HttpClient())
        {
            // Crear una lista para almacenar las tareas de descarga
            List<Task> downloadTasks = new List<Task>();

            foreach (string imageUrl in imageUrls)
            {
                // Agregar una tarea de descarga asincrónica a la lista
                downloadTasks.Add(DownloadImageAsync(httpClient, imageUrl, downloadsPath));
            }

            // Esperar a que todas las tareas de descarga se completen
            await Task.WhenAll(downloadTasks);

            Console.WriteLine("Todas las imágenes han sido descargadas en la carpeta Downloads del disco C.");
        }
    }

    static async Task DownloadImageAsync(HttpClient httpClient, string imageUrl, string outputPath)
    {
        // Descargar la imagen de manera asincrónica
        byte[] imageData = await httpClient.GetByteArrayAsync(imageUrl);

        // Simulamos el nombre del archivo con un valor fijo
        string fileName = Path.GetFileName(imageUrl);

        // Combinar la ruta completa de la carpeta de destino con el nombre del archivo
        string filePath = Path.Combine(outputPath, fileName);

        // Guardar la imagen en disco
        File.WriteAllBytes(filePath, imageData);

        Console.WriteLine($"Imagen {fileName} descargada en {filePath}");
    }
}
