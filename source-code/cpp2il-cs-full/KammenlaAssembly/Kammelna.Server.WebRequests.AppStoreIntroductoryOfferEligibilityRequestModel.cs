using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class AppStoreIntroductoryOfferEligibilityRequestModel
{
	private string <Receipt>k__BackingField;

	public string Receipt
	{
		get
		{
			return <Receipt>k__BackingField;
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

	public AppStoreIntroductoryOfferEligibilityRequestModel(string receipt)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = receipt;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
