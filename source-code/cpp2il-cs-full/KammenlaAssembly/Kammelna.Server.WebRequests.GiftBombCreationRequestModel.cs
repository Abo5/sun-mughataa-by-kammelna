using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class GiftBombCreationRequestModel
{
	private int <ServerId>k__BackingField;

	private string <ZoneName>k__BackingField;

	private GiftBombType <GiftBombType>k__BackingField;

	private Games <Game>k__BackingField;

	private int <Size>k__BackingField;

	private int <Count>k__BackingField;

	private string <Message>k__BackingField;

	public int ServerId
	{
		get
		{
			return <ServerId>k__BackingField;
		}
		set
		{
			<ServerId>k__BackingField = value;
		}
	}

	public string ZoneName
	{
		get
		{
			return <ZoneName>k__BackingField;
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

	public GiftBombType GiftBombType
	{
		get
		{
			return <GiftBombType>k__BackingField;
		}
		set
		{
			<GiftBombType>k__BackingField = value;
		}
	}

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

	public int Size
	{
		get
		{
			return <Size>k__BackingField;
		}
		set
		{
			<Size>k__BackingField = value;
		}
	}

	public int Count
	{
		get
		{
			return <Count>k__BackingField;
		}
		set
		{
			<Count>k__BackingField = value;
		}
	}

	public string Message
	{
		get
		{
			return <Message>k__BackingField;
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
}
