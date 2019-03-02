using System;

namespace YeahModels.Models
{
    public interface IBaseEntity
    {
	    long Id { get; set; }
	    DateTime Created { get; set; }
	    DateTime Modified { get; set; }
		bool Active { get; set; }
	}
}
