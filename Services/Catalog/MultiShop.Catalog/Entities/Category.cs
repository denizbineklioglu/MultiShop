using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
	public class Category
	{
		// Mongo DB'nin ID'yi benzersiz değer görmesi için.
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
