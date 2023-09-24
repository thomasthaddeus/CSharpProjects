/*
*
*
*
*
*
*
*/

using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using static System.Console;

// Replace these values with your own
string connectionString = "mongodb://localhost:27017";  // mongodb://localhost:27017
string databaseName = "data";                           // your_database_name
string collectionName = "data";                         // your_collection_name
string inputDirectory = "D:/Downloads/dump/database/";   // path/to/your/bson_file.bson

// Create a MongoClient instance and connect to the database
var client = new MongoClient(connectionString);
var database = client.GetDatabase(databaseName);
var collection = database.GetCollection<BsonDocument>(collectionName);

// Read all BSON and JSON files in the input directory
var bsonFiles = Directory.GetFiles(inputDirectory, "*.bson");
var jsonFiles = Directory.GetFiles(inputDirectory, "*.json");
var filesToProcess = bsonFiles.Concat(jsonFiles);

foreach (var filePath in filesToProcess)
{
    if (Path.GetExtension(filePath) == ".bson")
    {
        // Process BSON files
        using (var fileStream = File.OpenRead(filePath))
        using (var bsonReader = new BsonBinaryReader(fileStream))
        {
            // Read and import BSON documents one by one
            while (!bsonReader.State.Equals(BsonReaderState.EndOfArray))
            {
                var context = BsonDeserializationContext.CreateRoot(bsonReader);
                var document = BsonSerializer.Deserialize<BsonDocument>(bsonReader, context);
                collection.InsertOne(document);
            }
        }
    }
    else if (Path.GetExtension(filePath) == ".json")
    {
        // Process JSON files
        using (var fileStream = File.OpenRead(filePath))
        using (var streamReader = new StreamReader(fileStream))
        {
            var jsonContent = streamReader.ReadToEnd();
            var document = BsonDocument.Parse(jsonContent);
            collection.InsertOne(document);
        }
    }
}

WriteLine("BSON and JSON data imported successfully.");
