namespace GenericClass;
public class GenericClassAssignment<T> where T: ValueTypeClass
{
    private ICollection<T> privateCollection = new List<T>();

    public void addItems(T item)
    {
        privateCollection.Add(item);
    }

    public T getItemfrom(T item)
    {
        return privateCollection.FirstOrDefault(x => x == item);
    }
     public void reverseCollection()
    {
         privateCollection.OrderByDescending(i => i);
    }

}

