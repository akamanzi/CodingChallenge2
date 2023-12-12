namespace GenericClass;
public class GenericClassAssignment<T> where T: ValueTypeClass
{
    private ICollection<T> privateCollection = new List<T>();

    public void addItems(T item)
    {
        privateCollection.Add(item);
    }

    public T getItemfrom(int index)
    {
        return privateCollection.ElementAt(index);
    }
     public ICollection<T> reverseCollection()
    {
         return privateCollection.OrderByDescending(i => i).ToArray();
    }

}

