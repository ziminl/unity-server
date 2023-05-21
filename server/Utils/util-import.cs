string jsonFilePath = @"C:\Users\zizizi\바탕 화면\unity_socket\server";
            
string json = File.ReadAllText(jsonFilePath);
Dictionary<string, object> json_Dictionary = (new JavaScriptSerializer()).Deserialize<Dictionary<string, object>>(json);

foreach (var item in json_Dictionary)
{
    // parse here
}    public class Object
    {
        public string PORT { get; set; }
        public string value { get; set; }
    }

    public class Root
    {
        public Object @object { get; set; }
    }

