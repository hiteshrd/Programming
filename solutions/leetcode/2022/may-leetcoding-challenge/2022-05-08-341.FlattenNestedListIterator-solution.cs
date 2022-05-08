/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    Queue<int> myQueue;

    public NestedIterator(IList<NestedInteger> nestedList) {
        myQueue = new Queue<int>();
        Find(nestedList);
        
    }
    private void Find(IList<NestedInteger> nestedList)
    {
        for(int i = 0; i < nestedList.Count(); i++)
        {
            if(nestedList[i].IsInteger())
            {
                myQueue.Enqueue(nestedList[i].GetInteger());
            }
            else
            {
                Find(nestedList[i].GetList());
            }
        }
    }

    public bool HasNext() {
        return myQueue.Count() > 0;
        
    }

    public int Next() {
        return myQueue.Dequeue();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
