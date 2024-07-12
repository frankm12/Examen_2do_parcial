using System;

namespace parcial
{
    class program
    {

        public class MaterialBibliografico
        {
            public void libro()
            {
                Console.WriteLine("Nuestro catologo de libros incluye los siguientes:");
                Console.WriteLine("El principito, la vaca lola, 50 razones por que");
                Console.WriteLine("elija un libro de su preferencia escribiendolo tal y como se lo escribimos si quiere mas informacion");
                string seleccion_2 = Console.ReadLine();

                if (seleccion_2 == "el principito")
                {
                    Console.WriteLine("El principito contiene 300 paginas y es de la edicion santillana");
                }
                else
                {
                    if (seleccion_2 == "la vaca lola")
                    {
                        Console.WriteLine("la vaca lola es un cuento para niños que contiene 30 paginas y habla sobre la historia de una vaca con tiene la edicion puerto plata");
                    }
                    else
                    {
                        if (seleccion_2 == "50 razones por que")
                        {
                            Console.WriteLine("50 razones por que es un libro juvenil contiene 350 paginas y es edicion santo domingo");
                        }
                        else
                        {
                            Console.WriteLine("ninguna de las opciones fue las ingresadas");
                        }
                    }
                }
            }
        }
        public class MaterialBibliografico_revista
        {
            public void revista()
            {
                Console.WriteLine("Nuestro catologo de revista incluye los siguientes:");
                Console.WriteLine("El principito version revista, la vaca lola version revista, 50 razones por que version revista");
                Console.WriteLine("elija un libro de su preferencia escribiendolo tal y como se lo escribimos si quiere mas informacion");
                string seleccion_2 = Console.ReadLine();

                if (seleccion_2 == "el principito version revista")
                {
                    Console.WriteLine("El principito contiene 300 paginas y es de la edicion santillana");
                }
                else
                {
                    if (seleccion_2 == "la vaca lola version revista")
                    {
                        Console.WriteLine("la vaca lola es un cuento para niños que contiene 30 paginas y habla sobre la historia de una vaca con tiene la edicion puerto plata");
                    }
                    else
                    {
                        if (seleccion_2 == "50 razones por que version revista")
                        {
                            Console.WriteLine("50 razones por que es un libro juvenil contiene 350 paginas y es edicion santo domingo");
                        }
                        else
                        {
                            Console.WriteLine("ninguna de las opciones fue las ingresadas");
                        }
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("bienvenido a mi biblioteca de materiales bibliografico, aqui dentro tenemos libros y revistas que quieres usar?");
            Console.WriteLine("Ingrese la palabra 'libro' si quiere un libro o la palabra 'revista' si quiere una revista");
            string seleccion = Console.ReadLine();

            if (seleccion == "libro")
            {
                MaterialBibliografico seleccion3 = new MaterialBibliografico();
                seleccion3.libro();
            }
            else
            {
                if (seleccion == "revista")
                {
                    MaterialBibliografico_revista seleccion3 = new MaterialBibliografico_revista();
                    seleccion3.revista();
                }
                else
                {
                    Console.WriteLine("ninguna seleccion fue la correcta");
                }
            }

        }
    }
}