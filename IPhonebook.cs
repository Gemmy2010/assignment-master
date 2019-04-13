namespace Phonebook
{
    public interface IPhonebook
    {
        

        void CreateUser(User user);
        void DeleteUser(User user);
        User RetrieveByPersonalId(User user);
        string ToString();
        void UpdateUser(User user);
        

    }
}