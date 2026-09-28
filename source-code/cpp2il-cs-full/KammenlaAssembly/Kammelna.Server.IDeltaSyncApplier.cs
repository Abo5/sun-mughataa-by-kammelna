using System;
using Server.Models;

namespace Kammelna.Server;

public interface IDeltaSyncApplier
{
	string WireKey { get; }

	ICachedModel Cache { get; }

	void FetchSince(long cursor, Action<bool> onDone);
}
