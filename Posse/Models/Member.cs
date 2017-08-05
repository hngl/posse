using System;
using SQLite;

namespace Posse
{
    // Model
    public class Member : IBusinessEntity
    {
        // No constructor because empty

		// SQLite attributes
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
    }
}
