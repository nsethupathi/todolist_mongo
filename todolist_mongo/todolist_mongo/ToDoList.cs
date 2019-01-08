using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace todolist_mongo
{
    class ToDoList
    {
        // data
        private MongoClient client;

        // default constructor
        public ToDoList()
        {
            // open connection
            this.client = new MongoClient("mongodb://localhost:27017");

            // create database
            IMongoDatabase db = client.GetDatabase("independent");

            // create collection
            var collection = db.GetCollection<BsonDocument>("tasks");
        }
    }
}
