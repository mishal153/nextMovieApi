using System.Dynamic;
using System.Text.Json;

namespace NextMovieApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            dynamic expando = new ExpandoObject();
            expando.Name = "Vikram";

            app.MapGet("/nextmovie", () => expando);

            app.Run();
        }
    }
}