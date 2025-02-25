﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSetup.Model
{
    public class Person
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
