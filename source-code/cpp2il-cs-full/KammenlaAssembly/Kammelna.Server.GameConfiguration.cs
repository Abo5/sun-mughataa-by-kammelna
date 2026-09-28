using System;
using Cpp2ILInjected;

namespace Kammelna.Server;

[Serializable]
public class GameConfiguration
{
	private Games <Game>k__BackingField;

	private string <Zone>k__BackingField;

	private string <DefaultRoom>k__BackingField;

	private bool <UseSSL>k__BackingField;

	public Games Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
		}
	}

	public string Zone
	{
		get
		{
			return <Zone>k__BackingField;
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

	public string DefaultRoom
	{
		get
		{
			return <DefaultRoom>k__BackingField;
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

	public bool UseSSL
	{
		get
		{
			return <UseSSL>k__BackingField;
		}
		set
		{
			<UseSSL>k__BackingField = value;
		}
	}
}
