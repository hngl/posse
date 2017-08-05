using System;
using SQLite;

namespace Posse
{
    // The base class implements the interface and adds the SQLite-NET 
    // attributes to mark it as an auto-incrementing primary key. Any class in 
    // the Business Layer that implements this base class can then be persisted 
    // in the Data Layer
    public abstract class BusinessEntityBase : IBusinessEntity
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        // No constructor, because empty
    }
}
