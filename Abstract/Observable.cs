using System.Collections.Generic;
using System.Linq;

//This is the observable
public abstract class ChatRoom
{
    private List<ConcreteUser> _users = new List<ConcreteUser>();
    public void Attach(ConcreteUser user)
    {
        _users.Add(user);
    }

    public void Detatch(ConcreteUser user)
    {
        _users.Remove(user);
    }

    private void Notify()
    {
        foreach (User q in _users)
            q.Update();
    }

    public ConcreteUser GetUser(string userName)
    {
        return _users.Where(q => q.Name == userName).FirstOrDefault();
    }
}