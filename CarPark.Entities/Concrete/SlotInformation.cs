using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections;
using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{
    public class SlotInformation:BaseModel
    {
        public ICollection<Translation>  Translations { get; set; }
    }
}