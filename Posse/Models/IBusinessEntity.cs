using System;
namespace Posse
{

    // The Data Layer takes a dependency on BL.Contracts.IBusinessIdentity so 
    // that it can implement abstract data access methods that require a primary
    // key.Any Business Layer class that implements the interface can then be 
    // persisted in the Data Layer.
    public interface IBusinessEntity
    {
		// The interface just specifies an integer property to act as the primary key
		int ID { get; set; }
    }
}
