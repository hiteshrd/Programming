public class UndergroundSystem {
    Dictionary<int,station> data;
    Dictionary<string,stationavg> result;
        

    public UndergroundSystem() {
        data = new Dictionary<int,station>();
        result = new Dictionary<string,stationavg>();
    }
    
    public void CheckIn(int id, string stationName, int t) {
        station st = new station{
            id = id,
            checkinStation = stationName,
            time = t
            };
            data.Add(id, st);
    }
    
    public void CheckOut(int id, string stationName, int t) {
        station st = data[id];
        stationavg val = null;
        string key = st.checkinStation + "." + stationName;
        if(result.TryGetValue(key, out val))
        {
            val.time += t - st.time;
            val.count++;
        }
        else
        {
            val = new stationavg{
                time = t - st.time,
                count = 1
            };
        }
        result[key] = val;
        data.Remove(id);
    }
    
    public double GetAverageTime(string startStation, string endStation) { 
        string key = startStation + "." + endStation;   
        stationavg val = result[key];
        if(result.TryGetValue(key, out val))
        {
            return val.time/val.count;
        }
        return 0;
    }
}
public class station {
    public int id{get;set;}
    public string checkinStation{get;set;}
    public double time{get;set;}
}
public class stationavg {
    public double time{get;set;}
    public int count{get;set;}
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */
