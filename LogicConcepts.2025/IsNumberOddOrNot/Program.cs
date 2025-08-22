Console.Write("Escriba un número: ");
 if (int.TryParse(Console.ReadLine(), out int numero))
    {
       if (numero % 2 == 0)
         {
          Console.WriteLine("El número " + numero + " es PAR.");
           }
            else
            {
                Console.WriteLine("El número " + numero + " No es PAR.");
            }
               }
               else
                  {
                  Console.WriteLine("Eso no es un número válido.");
                  }
   