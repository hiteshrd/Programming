public class Codec {
    Dictionary<string,string> myDic = new Dictionary<string,string>();

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        string key = "https://leetcode.com/" + System.DateTime.Now.ToString("%d%m%Y%H%M%S");
        myDic.Add(key,longUrl);
        return key;
        
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        string val;
        myDic.TryGetValue(shortUrl, out val);
        return val;
        
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));
