using System;

namespace Server.Models;

public interface ICachedModel
{
	string Key { get; }

	string ETag { get; set; }

	DateTime LastUpdate { get; set; }

	long ServerCursor { get; set; }

	bool IsValid();

	void Load();

	void Clear();

	void ClearLastUpdateDate(DateTime? epoch = null);
}
