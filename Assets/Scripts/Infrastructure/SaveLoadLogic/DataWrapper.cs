namespace Infrastructure.SaveLoadLogic
{
    public class DataWrapper<T>
    {
        public T Value;

        public DataWrapper(T value) => 
            Value = value;
    }
}