public class MyHashSet {
    Dictionary<int,int> myDic;
    int val;
    public MyHashSet() {
        myDic = new Dictionary<int,int>();
    }
    
    public void Add(int key) {
        if(!myDic.TryGetValue(key, out val))
        {
            myDic.Add(key,key);
        }
    }
    
    public void Remove(int key) {
        if(myDic.TryGetValue(key, out val))
        {
            myDic.Remove(key);
        }        
    }
    
    public bool Contains(int key) {
        return myDic.TryGetValue(key, out val);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
