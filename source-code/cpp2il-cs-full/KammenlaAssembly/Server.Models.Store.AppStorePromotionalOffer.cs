using System;
using Cpp2ILInjected;

namespace Server.Models.Store;

[Serializable]
public class AppStorePromotionalOffer
{
	private string <OfferIdentifier>k__BackingField;

	private string <Signature>k__BackingField;

	private string <Nonce>k__BackingField;

	private long <Timestamp>k__BackingField;

	private string <KeyIdentifier>k__BackingField;

	public string OfferIdentifier
	{
		get
		{
			return <OfferIdentifier>k__BackingField;
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

	public string Signature
	{
		get
		{
			return <Signature>k__BackingField;
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

	public string Nonce
	{
		get
		{
			return <Nonce>k__BackingField;
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

	public long Timestamp
	{
		get
		{
			return <Timestamp>k__BackingField;
		}
		set
		{
			<Timestamp>k__BackingField = value;
		}
	}

	public string KeyIdentifier
	{
		get
		{
			return <KeyIdentifier>k__BackingField;
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
