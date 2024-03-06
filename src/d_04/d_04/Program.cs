// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using d_04.Model;

Console.WriteLine("Input search text:");

var jsonDoc = JsonDocument.Parse(File.ReadAllText("/Users/gabriela/C_sharp_Day04-2/src/book_reviews.json"));
var resultsElement = jsonDoc.RootElement.GetProperty("results");
var booksList = resultsElement.Deserialize<List<BookReview>>();
foreach (var book in booksList)
{
    Console.WriteLine(book);
    // Console.WriteLine(book.Info[0]);
}

Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

jsonDoc = JsonDocument.Parse(File.ReadAllText("/Users/gabriela/C_sharp_Day04-2/src/movie_reviews.json"));
resultsElement = jsonDoc.RootElement.GetProperty("results");
var moviesList = resultsElement.Deserialize<List<MovieReview>>();
foreach (var movie in moviesList)
{
    Console.WriteLine(movie);
}









// var root = JsonDocument.Parse("/Users/gabriela/ly04/src/book_reviews.json").RootElement;
// // var resultsElement = document.RootElement.GetProperty("results");
// lilst = JsonSerializer.Deserialize<BookReview>(json: File.ReadAllText(root.GetProperty("results").ToString());
// string json = File.ReadAllText(source.GetProperty("fileName").GetString());


// var booksList = JsonSerializer
//     .Deserialize<BookReview>(File.ReadAllText("/Users/gabriela/ly04/src/book_reviews.json"));
// foreach (var book in booksList.Results)
// {
//     Console.WriteLine(book);
// }

// Console.WriteLine(booksList.Results[0]);



// var moviesList = JsonSerializer
//     .Deserialize<MovieReview>(File.ReadAllText("/Users/gabriela/ly04/src/movie_reviews.json"));
// foreach (var movie in moviesList.Results)
// {
//     Console.WriteLine(movie);
// }

// static T[] Search<T>(this IEnumerable<T> list, string search) where T : ISearchable
// {
//     foreach (var l in list)
//     {
//         if (l)
//     }
// }