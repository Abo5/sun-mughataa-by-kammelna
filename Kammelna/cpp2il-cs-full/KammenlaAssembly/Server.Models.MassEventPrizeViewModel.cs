using System;
using Cpp2ILInjected;

namespace Server.Models;

[Serializable]
public class MassEventPrizeViewModel
{
	private int <Place>k__BackingField;

	private string <Name>k__BackingField;

	private string <Description>k__BackingField;

	private FileInfoModel <Image>k__BackingField;

	public int Place
	{
		get
		{
			return <Place>k__BackingField;
		}
		set
		{
			<Place>k__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

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
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public FileInfoModel Image
	{
		get
		{
			return <Image>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
