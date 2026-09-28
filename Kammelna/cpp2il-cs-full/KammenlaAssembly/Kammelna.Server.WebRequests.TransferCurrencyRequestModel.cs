using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class TransferCurrencyRequestModel
{
	private long <TargetUserId>k__BackingField;

	private int <Amount>k__BackingField;

	private string <Message>k__BackingField;

	public long TargetUserId
	{
		get
		{
			return <TargetUserId>k__BackingField;
		}
		set
		{
			<TargetUserId>k__BackingField = value;
		}
	}

	public int Amount
	{
		get
		{
			return <Amount>k__BackingField;
		}
		set
		{
			<Amount>k__BackingField = value;
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
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
