using System;

namespace Server.Models;

public interface IAvatarFeedData
{
	long Id { get; }

	string Name { get; }

	DateTime? AvatarDate { get; }
}
