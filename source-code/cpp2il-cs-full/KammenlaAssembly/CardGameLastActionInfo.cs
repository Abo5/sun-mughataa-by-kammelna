using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class CardGameLastActionInfo : LastActionInfo
{
	internal const string BID_TYPE = "bt";

	private readonly string <BidType>k__BackingField;

	private readonly int? <GameActionItemId>k__BackingField;

	public string BidType => <BidType>k__BackingField;

	public int? GameActionItemId => <GameActionItemId>k__BackingField;

	public CardGameLastActionInfo(ISFSObject lastActionParams)
		: base(lastActionParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		if (lastActionParams != null)
		{
			object varName = "fetch_products" + 2336;
			object varName2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1488;
			object defaultValue = (nint)0 + (nint)2000;
			<GameActionItemId>k__BackingField = SFSExtensions.GetIntOrNull(lastActionParams, (string)varName);
			string text = SFSExtensions.Get(lastActionParams, (string)varName2, (string)defaultValue);
			object obj = this + 32;
			obj = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardGameLastActionInfo(CardGameLastActionInfo cardGameLastActionInfo)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		base.<ActionPlayer>k__BackingField = ((LastActionInfo)cardGameLastActionInfo).<ActionPlayer>k__BackingField;
		object obj = this + 24;
		obj = ((LastActionInfo)cardGameLastActionInfo).<Action>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = cardGameLastActionInfo.<BidType>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = cardGameLastActionInfo.<GameActionItemId>k__BackingField;
	}
}
