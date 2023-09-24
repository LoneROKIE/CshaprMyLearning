var beers = new List<Beer>()
{
    new Beer(){Name = "Pikantus", Brand = "Erdinger", Alcohol = 7.5m},
    new Beer(){Name = "Corona", Brand = "Modelo", Alcohol = 4.5m},
    new Beer(){Name = "Red", Brand = "Delirium", Alcohol = 8m},
    new Beer(){Name = "Stout", Brand = "Minerva", Alcohol = 6m},
    new Beer(){Name = "IPA", Brand = "Minerva", Alcohol = 7m}

};

var brands = new List<Brand>()
{
    new Brand(){Name = "Erdinger", Country = "Alemania"},
    new Brand(){Name = "Modelo", Country = "Mexico"},
    new Brand(){Name = "Minerva", Country = "Mexico"},
    new Brand(){Name = "Delirium", Country = "Belgica"}
};

// podemos trabajar con linq de dos formas 1 con query expressions como
// los dos ejemplos de beers2 Y beers3 O EN FORMA DE METODOS o expresiones lambda

// SELECT
var beers2 = from b in beers select  new { b.Name , b.Brand};

// WHERE
var beers3 = from b in beers where b.Brand == "Minerva" || b.Alcohol >= 7
             select new { b.Name , b.Brand };

var beers4 = beers.Where(b => b.Brand == "Minerva" || b.Alcohol >= 7).Select(
                        b => new
                        {
                            b.Name,
                            b.Brand,
                        });

// ORDER BY
var beers5 = from b in beers
             where b.Brand == "Minerva" || b.Alcohol >= 7
             orderby b.Name descending
             select new { b.Name, b.Brand };

// Group by
var beers6 = from b in beers
             group b by b.Name into groupBeers
             select new
             {
                 Brand = groupBeers.Key,
                 Count = groupBeers.Count()
             };

// JOIN
var beers7 = from b in beers
             join bra in brands on b.Brand equals bra.Name
             select new
             {
                 Name = b.Name,
                 Brand = b.Brand,
                 Country = bra.Country
             };

foreach (var b in beers7)
{
    Console.WriteLine(b.Name + " " + b.Brand + " "+ b.Country);
}


public class Beer
{
    public string? Name { get; set; }
    public string? Brand { get; set; }
    public decimal Alcohol { get; set; }
}

public class Brand
{
    public string? Name { get; set; }
    public string? Country { get; set; }
}