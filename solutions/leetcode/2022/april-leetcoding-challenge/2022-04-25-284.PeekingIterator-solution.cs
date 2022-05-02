// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator {
    Queue<int> myQueue;
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator) {
        // initialize any member here.
        myQueue = new Queue<int>();
        do
        {
            myQueue.Enqueue(iterator.Current);
        }while(iterator.MoveNext());
    }
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() {
        return myQueue.Peek();
    }
    
    // Returns the next element in the iteration and advances the iterator.
    public int Next() {
        return myQueue.Dequeue();
        
    }
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() {
		return myQueue.Count() > 0;
    }
}
