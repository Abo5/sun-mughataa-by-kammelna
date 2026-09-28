using Cpp2ILInjected;
using UnityEngine;

public class ClanTierSprites : ScriptableObject
{
	public const int TierCount = 5;

	public Sprite Tier1;

	public Sprite Tier2;

	public Sprite Tier3;

	public Sprite Tier4;

	public Sprite Tier5;

	public Sprite GetSprite(int tier)
	{
		//IL_000e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected I4, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0177: Expected O, but got I
		object obj = tier - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = tier ^ 1;
		int num2 = tier ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num4 = ((obj4 != null) ? 1 : tier);
		object obj5 = num4 - 5;
		bool flag5 = (nint)obj5 < 0;
		int num5 = num4 ^ 5;
		int num6 = num4 ^ obj5;
		int num7 = num5 & num6;
		bool flag6 = num7 < 0;
		bool flag7 = flag5 == flag6;
		object obj6 = !flag7;
		object obj7 = ~obj6;
		if (obj7 != null)
		{
			num4 = 5;
		}
		object obj8 = num4 - 1;
		object obj9 = (object)this + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4+18]");
		return (Sprite)0;
	}
}
