using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
	public class Category
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] //Id olarak tanıtmak için kullandık
		public string CategoryID { get; set; } //identity mongodbde olmadığı için idler int değil string türde tutulur
        public string CategoryName { get; set; }
    }
}
