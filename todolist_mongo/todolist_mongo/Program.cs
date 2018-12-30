using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace todolist_mongo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MongoClient client = new MongoClient("mongodb://127.0.0.1:27017");

                // get database
                IMongoDatabase db = client.GetDatabase("independent");

                // get collections
                var collections = db.ListCollections().ToList();
            }
        }
    }
}
