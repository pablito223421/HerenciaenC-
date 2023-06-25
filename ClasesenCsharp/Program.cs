using ClasesenCsharp;

Libro libro = new Libro("La divina comedia", "Dante Alligheri", 500, 230.50m);
var libroresultado = libro.getInscripcion();
Console.WriteLine(libroresultado);

Revista revista = new Revista("Alfonso Mendez", "Muy interesante", 20, 25.50m);
var revistaresultado= revista.getInscripcion();
Console.WriteLine(revistaresultado);


