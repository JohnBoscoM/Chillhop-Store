
namespace ChillhopStore.Models
{
    public class MongoDBSettings:IMongoDBSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        //string IMongoDBSettings.ConnectionString { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}