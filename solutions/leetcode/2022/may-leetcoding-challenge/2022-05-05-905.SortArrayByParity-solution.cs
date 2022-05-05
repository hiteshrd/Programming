public class MyStack {
    Queue<int> q1;
    Queue<int> q2;
    bool isQ1;

    public MyStack() {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
        
    }
    
    public void Push(int x) {
        if(isQ1)
        {
            q2.Enqueue(x);
            while(q1.Count>0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            isQ1 = false;
        }
        else
        {
            q1.Enqueue(x);
            while(q2.Count>0)
            {
                q1.Enqueue(q2.Dequeue());
            }            
            isQ1 = true;
        }
    }
    
    public int Pop() {
        
        if(isQ1)
        {
            return q1.Dequeue();
        }
        else
        {
            return q2.Dequeue();            
        }
    }
    
    public int Top() {
        if(isQ1)
        {
            return q1.Peek();
        }
        else
        {
            return q2.Peek();            
        }
        
    }
    
    public bool Empty() {
        if(isQ1)
        {
            return q1.Count() == 0;
        }
        else
        {
            return q2.Count() == 0;   
        }
        
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
