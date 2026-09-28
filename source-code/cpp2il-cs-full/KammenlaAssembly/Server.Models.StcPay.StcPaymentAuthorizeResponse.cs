using System;
using Cpp2ILInjected;

namespace Server.Models.StcPay;

[Serializable]
public class StcPaymentAuthorizeResponse
{
	private int <ExpiryDuration>k__BackingField;

	private string <BillReference>k__BackingField;

	public int ExpiryDuration
	{
		get
		{
			return <ExpiryDuration>k__BackingField;
		}
		set
		{
			<ExpiryDuration>k__BackingField = value;
		}
	}

	public string BillReference
	{
		get
		{
			return <BillReference>k__BackingField;
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
}
