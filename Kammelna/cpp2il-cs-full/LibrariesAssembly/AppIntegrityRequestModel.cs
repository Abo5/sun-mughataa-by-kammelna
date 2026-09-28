using System;
using Cpp2ILInjected;

[Serializable]
public class AppIntegrityRequestModel
{
	private string <Token>k__BackingField;

	private string <ValidationKey>k__BackingField;

	private int <Platform>k__BackingField;

	private string <PlatformVersion>k__BackingField;

	private string <DeviceId>k__BackingField;

	private string <Error>k__BackingField;

	private string <AppVersion>k__BackingField;

	public string Token
	{
		get
		{
			return <Token>k__BackingField;
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

	public string ValidationKey
	{
		get
		{
			return <ValidationKey>k__BackingField;
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

	public int Platform
	{
		get
		{
			return <Platform>k__BackingField;
		}
		set
		{
			<Platform>k__BackingField = value;
		}
	}

	public string PlatformVersion
	{
		get
		{
			return <PlatformVersion>k__BackingField;
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

	public string DeviceId
	{
		get
		{
			return <DeviceId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string Error
	{
		get
		{
			return <Error>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string AppVersion
	{
		get
		{
			return <AppVersion>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
