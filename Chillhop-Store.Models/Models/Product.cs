using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChillhopStore.Models
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("ProductName")]
        public string Name { get; set; }
        [BsonElement("Price")]
        public double Price { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("ProductId")]
        public int ProductId { get; set; }
    }
}
