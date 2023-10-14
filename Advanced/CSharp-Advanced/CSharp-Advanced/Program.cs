// Generics

using CSharp_Advanced.Generics;

Book book = new Book(2001, "Dac Nhan Tam");

BookList bookList = new BookList();
bookList.Add(book);
// bookList.Add(10); --> compiler error
Book book1 = bookList[1];

ObjectList objectList = new ObjectList();
objectList.Add(book1);
objectList.Add(10);
// ton them thoi gian de auto-boxing

GenericList<int> genericInt = new GenericList<int>();
genericInt.Add(1);
genericInt.Add(2);

GenericList<Book> genericList = new GenericList<Book>();
genericList.Add(book1);
// ok -> rang buoc duoc du lieu
