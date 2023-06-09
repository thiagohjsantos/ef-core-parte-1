using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                #region Filmes e idiomas
                /*
                var idiomas = contexto.Idiomas
                    .Include(i => i.FilmesFalados);

                foreach (var idioma in idiomas)
                {
                    Console.WriteLine(idioma);

                    foreach (var filme in idioma.FilmesFalados)
                    {
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("\n");

                } */
                #endregion

                var categorias = contexto.Categorias
                    .Include(c => c.Filmes)
                    .ThenInclude(fc => fc.Filme);

                foreach (var c in categorias)
                {
                    Console.WriteLine($"Filmes da categoria {c}: \n");
                    foreach (var fc in c.Filmes)
                    {
                        Console.WriteLine(fc.Filme);
                    }
                }

                Console.ReadKey();

            }
        }
    }
}
