using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class StcPaymentConfirmModel
{
	private string <BillReference>k__BackingField;

	private string <OtpValue>k__BackingField;

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
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string OtpValue
	{
		get
		{
			return <OtpValue>k__BackingField;
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
