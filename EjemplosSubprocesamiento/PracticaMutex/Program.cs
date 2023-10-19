// mutex sirve para que solo una persona pueda morder el pastel a la vez
// si no se usa el mutex, varias personas pueden morder el pastel al mismo tiempo
// y el pastel se acaba mas rapido de lo que deberia.

// En terminos tecnicos, el mutex es un semaforo binario, es decir, solo puede tener dos estados
// 0 o 1, bloqueado o desbloqueado, en este caso, si el mutex esta bloqueado, la persona no puede morder el pastel
// si el mutex esta desbloqueado, la persona puede morder el pastel.

// La diferencia entre un mutex y un semaforo es que el mutex es un semaforo binario,
// es decir, solo puede tener dos estados, mientras que el semaforo puede tener mas de dos estados
// por ejemplo, un semaforo puede tener 3 estados, rojo, amarillo y verde, y cada uno de estos estados
// puede tener un significado diferente, por ejemplo, rojo significa que no se puede morder el pastel,
// amarillo significa que se puede morder el pastel pero solo una persona a la vez, y verde significa que
// se puede morder el pastel sin restricciones.

// Las formas de usar mutex es la siguiente:

// 1. Crear un mutex
// 2. Bloquear el mutex
// 3. Desbloquear el mutex

Mutex mut = new Mutex();
var myCake = new Cake(100);

// lista de personas
List<Person> people = new List<Person>()
{
    new Person(myCake, "Hector", mut),
    new Person(myCake, "Juan", mut),
    new Person(myCake, "Pedro", mut),
    new Person(myCake, "Maria", mut),
    new Person(myCake, "Jose", mut),
};

foreach (var person in people)
{
   var thread = new Thread(new ThreadStart(person.Bite));
   thread.Start();
}


public class Person
{
    private Cake _cake;
    private string _name;
    private Mutex _mutex;

    public Person( Cake cake , string name, Mutex mutex)
    {
        _cake = cake;
        _name = name;
        _mutex = new Mutex();
    }

    public void Bite()
    {
        while (_cake.GetQuantity() > 0)
        {
            try
            {
                _mutex.WaitOne(); // bloquea el mutex

                if (_cake.GetQuantity() > 0)
                {
                    Console.WriteLine($"{_name} le muerdo al pastel {_cake.GetQuantity()}");
                    _cake.BiteMe();
                    Console.WriteLine($"{_name} deja al pastel con {_cake.GetQuantity()}");
                    _mutex.ReleaseMutex(); // libera el mutex
                }   
            }
            catch(AbandonedMutexException e)
            {
                Console.WriteLine($"{_name} iba a morderle y ya no pudo xd");
            }
        }
    }
}

public class Cake 
{
    private int _quiantity { get; set; }
    public Cake(int quantity)
    {
        _quiantity = quantity;
    }
    public void BiteMe() => _quiantity--;
    public int GetQuantity() => _quiantity;
}