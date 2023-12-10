
// proyecto encriptador de strings y desencriptador
using System;
using System.Text;

public class Principal
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Message for encrypt: ");
        
        string message = Console.ReadLine();

        string encryptedMessage = "";

        for(int i = 0; i < message.Length; i++)
        {
            char c = message[i];
            char encryptedC = (char)(c + 3);
            encryptedMessage += encryptedC;
        }

        Console.WriteLine("Encrypted Message:");
        Console.WriteLine(encryptedMessage);

        // desencriptacion del mensaje
        string decryptedMessage = "";

        for(int i=0; i < encryptedMessage.Length; i++) 
        {
            char c = encryptedMessage[i];
            char decryptedC = (char)(c - 3);
            decryptedMessage += decryptedC;
        }

        Console.WriteLine("Do you want to decrypt the message ? (y/n)");
        if(Console.ReadLine().ToLower() == "y")
        {
            Console.WriteLine("Decrypted Message: " + decryptedMessage);
        }


    }

}

/*
 * EXPLICACION:

    La suma de caracteres en C# aprovecha el hecho de que los caracteres en C# y muchos otros lenguajes de programación están representados
    internamente como valores numéricos según la tabla de códigos ASCII. La tabla ASCII asigna un número único a cada carácter, 
    lo que permite realizar operaciones numéricas con ellos.

    En el código que proporcionaste, se utiliza la expresión (char)(c + 3) para encriptar el mensaje. Aquí está cómo funciona:

    c es el valor numérico del carácter actual en el mensaje original.
    c + 3 suma 3 al valor numérico de ese carácter.
    (char)(c + 3) convierte el nuevo valor numérico de vuelta a un carácter.
    Por ejemplo, si c es el valor numérico de la letra 'A' (que es 65 según la tabla ASCII),
    entonces (char)(c + 3) sería el carácter con el valor numérico 68, que es la letra 'D'.
    Esto es básicamente un cifrado de desplazamiento, donde cada carácter en el mensaje se desplaza
    tres posiciones hacia adelante en el alfabeto.

    La resta se utiliza en la desencriptación de manera similar, pero se resta 3 para volver al valor original.
    Por ejemplo, si c es el valor numérico de la letra 'D' (68), entonces (char)(c - 3) sería el carácter con el valor numérico 65, que es la letra 'A'.

    Es importante mencionar que este tipo de cifrado es muy simple y no proporciona una seguridad real.
    En contextos de seguridad, se utilizan algoritmos de cifrado más avanzados y robustos. Este ejemplo
    es más didáctico para ilustrar cómo se pueden realizar operaciones con los valores numéricos
    de los caracteres en un lenguaje de programación.
 * 
 */