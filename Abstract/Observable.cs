using System.Collections.Generic;
using System.Linq;

//This is the observable
public abstract class ChatRoom
{
    private List<User> _users = new List<User>();
    public void Attach(User user)
    {
        _users.Add(user);
    }

    public void Detatch(User user)
    {
        _users.Remove(user);
    }

    public void Notify()
    {
        foreach (User q in _users)
            q.Update();
    }

    public ConcreteUser GetUser(string userName)
    {
        return _users.Where(q => q.Name).FirstOrDefault();
    }
}