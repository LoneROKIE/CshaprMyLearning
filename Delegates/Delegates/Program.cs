﻿// creamos una variable del tipo delegado
PrintDelegate Print = (string text) =>
{
    Console.WriteLine(text);
};

PrintDelegate PrintToFile = (string text) =>
{
    File.AppendAllText("./logs.txt", text);
};

static void ConnectToDatabase(PrintDelegate log)
{
    // Do the insertion
    log("Inserting a new record into the database");
    // Insertion done
    log("The record got inserted into the database");
}

ConnectToDatabase(PrintToFile);

// creamos un delegado
delegate void PrintDelegate(string text);
