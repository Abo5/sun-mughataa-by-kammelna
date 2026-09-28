using System.Collections.Generic;

namespace Server.Models;

public interface IClientFilterable
{
	List<ClientFilter> Filters { get; }
}
