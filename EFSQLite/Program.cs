// See https://aka.ms/new-console-template for more information
using EFSQLite.Models;

using var context = new LibraryContext();
/*
context.Database.EnsureCreated();
*/
/*
var author = new Author { Name = "Juan", LastName = "Vera" };
var book = new Book { Title = "Viviendo", Sinopsis = "Libro sobre como vivir", Author = author };
author.Books.Add(book);
context.Authors.Add(author);
context.Books.Add(book);
await context.SaveChangesAsync();
*/
var bookFromDb = context.Books.FirstOrDefault(b => b.Title == "Viviendo");
var authorFromDb = context.Authors.FirstOrDefault(b => b.Name == "Juan");
ArgumentNullException.ThrowIfNull(bookFromDb);
ArgumentNullException.ThrowIfNull(authorFromDb);
Console.WriteLine(bookFromDb.BookId);
Console.WriteLine(authorFromDb.Books.First().BookId);