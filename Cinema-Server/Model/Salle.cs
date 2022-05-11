﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Cinema.Models
{
    public class Salle
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int Numero { get; set; }

        public int NbPlaceAssise { get; set; }

        public Salle()
        {

        }

        public Salle(string id, int numero, int nbPlaceAssise)
        {
            this.Id = id;
            this.Numero = numero;
            this.NbPlaceAssise = nbPlaceAssise;
        }
    }
}
