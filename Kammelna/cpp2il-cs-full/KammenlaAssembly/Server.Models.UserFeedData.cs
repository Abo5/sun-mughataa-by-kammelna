using System;

namespace Server.Models;

[Serializable]
public abstract class UserFeedData
{
	private UserFeedType <Type>k__BackingField;

	public UserFeedType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	public abstract bool HasPreview { get; }

	public abstract bool ForcedPreview { get; }

	public abstract LocalizableText GetTitle();

	public abstract LocalizableText GetDetails();

	public abstract void ShowPreview(Action markSeen);

	public virtual bool IsValid()
	{
		return true;
	}
}
