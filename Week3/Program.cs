using Library;

Book book = new Book();
// This info is for one book in our library 
book.Title = "C# for beginners";
book.Author = "Bill Gates";
book.ISBN = "12345678";

book.DisplayInfo();

//This is another book in our library
Book book1 = new Book();
book1.Title = "C# methods";
book1.Author = "Microsoft";
book1.ISBN = "66666778";


book1.DisplayInfo();