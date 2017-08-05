using System;
using System.Collections.Generic;
using SQLite;

namespace Posse
{
	// The Business Layer implements the Model classes and a Façade to manage 
    // them. In Membery the Model is the MemberItem class and MemberItemManager 
    // implements the Façade pattern to provide an API for managing MemberItems.
	public class MemberManager
    {

		MemberRepository repository;

		public MemberManager (SQLiteConnection conn)
		{
			repository = new MemberRepository(conn);
		}

		public Member GetMember(int id)
		{
			return repository.GetMember(id);
		}

		public IList<Member> GetMembers()
		{
			return new List<Member>(repository.GetMembers());
		}

		public int SaveMember(Member item)
		{
			return repository.SaveMember(item);
		}

		public int DeleteMember(int id)
		{
			return repository.DeleteMember(id);
		}
	}
}