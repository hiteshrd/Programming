public class MyHashMap {
    Dictionary<int,int> myDic;
    int val;

    public MyHashMap() {
        myDic = new Dictionary<int,int>();
    }
    
    public void Put(int key, int value) {
        if(myDic.TryGetValue(key, out val))
           {
               myDic[key] = value;
           }
           else{
               myDic.Add(key, value);
               }
        
    }
    
    public int Get(int key) {
        if(myDic.TryGetValue(key,out val))
            {
            return val;
            }
        return -1;
    }
    
    public void Remove(int key) {
        if(myDic.TryGetValue(key, out val))
            {
            myDic.Remove(key);
            }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
