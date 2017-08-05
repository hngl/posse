using System;
using System.Collections.Generic;
using SQLite;

namespace Posse
{
	// The Repository class encapsulates the data storage mechanism with a strongly-typed API that allows objects to be created, deleted, retrieved and updated.
	public class MemberRepository
	{
		MemberDatabase db = null;

		public MemberRepository(SQLiteConnection conn)
		{
			db = new MemberDatabase(conn);
		}

		public Member GetMember(int id)
		{
			return db.GetItem(id);
		}

		public IEnumerable<Member> GetMembers()
		{
			return db.GetItems();
		}

		public int SaveMember(Member item)
		{
			return db.SaveItem(item);
		}

		public int DeleteMember(int id)
		{
			return db.DeleteItem(id);
		}
	}
}
