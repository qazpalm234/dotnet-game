namespace EntityComponentSystem;

public class ComponentColumn(Type componentType)
{
    public Type ComponentType { get; } = componentType;
    private readonly List<IComponent> _components = [];
    
    public int AddComponent(IComponent component)
    {
        _components.Add(component);
        return _components.Count - 1;
    }

    public void RemoveComponent(int index)
    {
        _components.RemoveAt(index);
    }

    public IComponent this[int index]
    {
        get => _components[index];
        set
        {
            if (value.GetType() != ComponentType) throw new Exception("Invalid component type given");
            _components[index] = value;
        }
    }
}