namespace UserTicketService
{

    /*
     * Выполните тестирование функции FindAll при помощи moq-объекта. 
     * Используйте следующие три имени пользователей для добавления в moq-коллекцию: 
     * Антон, Иван, Алексей. При написании теста используйте фреймворк NUnit. 
     * Для проверки наличия элемента в коллекции используйте метод That класса Assert и метод Any синтаксиса Linq.
     */

    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return null;
        }
    }

    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }

    public class User
    {
        public string Name
        {
            get;
            set;
        }
    }
}
