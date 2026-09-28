using System;
using Cpp2ILInjected;

namespace Server.Models;

[Serializable]
public class AppAnnouncementTimingViewModel
{
	private string <Description>k__BackingField;

	private DateTime <DateTime>k__BackingField;

	public string Description
	{
		get
		{
			return <Description>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public DateTime DateTime
	{
		get
		{
			return <DateTime>k__BackingField;
		}
		set
		{
			<DateTime>k__BackingField = value;
		}
	}
}
