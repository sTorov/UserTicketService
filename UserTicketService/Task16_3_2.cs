namespace UserTicketService
{
    /*
     * По аналогии с предыдущим заданием выполните тестирование функции FindAll при помощи moq-объекта. 
     * Используйте следующие три названия книг для добавления в moq-коллекцию: 
     * Война и мир, Человек-невидимка, Анна Каренина. При написании теста используйте фреймворк XUnit. 
     * Для проверки на существование элемента в коллекции используйте метод Contains класса Assert.
     */

    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }

    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }

    public class Book
    {
        public string Title
        { get; set; }
    }
}
