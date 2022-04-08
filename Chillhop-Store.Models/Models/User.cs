using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chillhop_Store.Models.Models
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Username")]
        public string UserName { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("LastLogin")]
        public DateTime LastLogin { get; set; }
        [BsonElement("IsLocked")]
        public bool IsLocked { get; set; }
        [BsonElement("RoleId")]
        public int RoleId { get; set; }
    }
}
