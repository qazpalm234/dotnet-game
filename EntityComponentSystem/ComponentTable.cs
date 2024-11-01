namespace EntityComponentSystem;

public class ComponentTable
{
    public Dictionary<Type, ComponentColumn> Columns { get; } = new Dictionary<Type, ComponentColumn>();

    
    public void AddComponent(Type type)
    {
        if (Columns.ContainsKey(type))
            return;
        Columns[type] = new ComponentColumn(type);
    }
}