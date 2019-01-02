﻿using System;
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
            
            MongoClient client = new MongoClient("mongodb://localhost:27017");


            // create database
            IMongoDatabase db = client.GetDatabase("independent");

            // create collection
            var collection = db.GetCollection<BsonDocument>("tasks");

            var document = new BsonDocument
            {
                {"name", new BsonString("walk the dog")}
            };

            collection.InsertOne(document);

            Console.ReadLine();
            db.DropCollection("tasks");

            Console.ReadLine();
            client.DropDatabase("independent");

            Console.ReadLine();
        }
    }
}
