using Observer_Pattern.Concrete;

public class ConcreteUser : User
{
    private string _name;
    private string _message;


    private string _observerState;

    private ConcreteChatRoom _concreteChatRoom;

    public ConcreteUser(ConcreteChatRoom concreteChatRoom, string name)
    {
        _name = name;
        _concreteChatRoom = concreteChatRoom;
    }

    public ConcreteChatRoom ConcreteChatRoom
    {
        get { return _concreteChatRoom; }
        set { _concreteChatRoom = value; }
    }

    public override void Update()
    {
        _observerState = _concreteChatRoom.State;
    }

    public string Message { get => _message; set => _message = value; }
   // public string Name { get => _name; set => _message = value; }

    public string Name { get { return _name; } set { _name = value; } }
}