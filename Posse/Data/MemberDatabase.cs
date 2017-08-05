//using System;
//using System.Linq;
using System.Collections.Generic;
using SQLite;
//using System.Collections;
using System.Threading.Tasks;

namespace Posse
{
    // This relies on the Sqlite-net nuget package(published by Frank Kreuger) 
    // to embed SQLite-NET code that provides an Object-Relational Mapping(ORM) 
    // database interface. This Database class inherits from SQLiteConnection 
    // and adds the required Create, Read, Update, Delete(CRUD) methods to read 
    // and write data to SQLite.
    public class MemberDatabase
    {

		//static object locker = new object();

		//public SQLiteConnection database;
		readonly SQLiteAsyncConnection database;

		//public string path;

		/// <summary>
		/// Initializes a new instance of the Database. 
		/// if the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		public MemberDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Member>().Wait();
		}

		//public IEnumerable<Member> GetItems()
		//{
	    //	lock (locker)
        //	{
		//		return (from i in database.Table<Member>() select i).ToList();
		//	}
		//}

		public Task<List<Member>> GetItemsAsync()
		{
			return database.Table<Member>().ToListAsync();
		}

		//public Member GetItem(int id)
		//{
		//	lock (locker)
		//	{
		//		return database.Table<Member>().FirstOrDefault(x => x.ID == id);
		//		// Following throws NotSupportedException - thanks aliegeni
		//		//return (from i in Table<T> ()
		//		//        where i.ID == id
		//		//        select i).FirstOrDefault ();
		//	}
		//}

		public Task<Member> GetItemAsync(int id)
		{
			return database.Table<Member>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		//public int SaveItem(Member item)
		//{
		//	lock (locker)
		//	{
		//		if (item.ID != 0)
		//		{
		//			database.Update(item);
		//			return item.ID;
		//		}
		//		else
		//		{
		//			return database.Insert(item);
		//		}
		//	}
		//}

		public Task<int> SaveItemAsync(Member item)
		{
			if (item.ID != 0)
			{
				return database.UpdateAsync(item);
			}
			else
			{
				return database.InsertAsync(item);
			}
		}

		//public int DeleteItem(int id)
		//{
		//	lock (locker)
		//	{
		//		return database.Delete<Member>(id);
		//	}
		//}

		public Task<int> DeleteItemAsync(Member member)
		{
			return database.DeleteAsync(member);
		}

        //internal Task<IEnumerable> GetItemsAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
