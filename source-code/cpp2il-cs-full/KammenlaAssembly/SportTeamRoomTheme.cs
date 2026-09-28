using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class SportTeamRoomTheme : MonoBehaviour
{
	private Sprite BackGround;

	private Sprite PrimaryColor;

	private Sprite SecondaryColor;

	private Image roomTheme;

	private Image layerOne;

	private Image layerTwo;

	public void SetRoomTheme(SportTeam sportTeam)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		//IL_01cb: Expected O, but got F8
		//IL_0137: Expected O, but got I
		//IL_0207: Expected I, but got O
		//IL_0212: Expected O, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_01ea: Expected F8, but got I4
		//IL_02af: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_031f: Expected O, but got I
		//IL_038b: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		roomTheme.sprite = BackGround;
		object obj2 = this + 64;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!(Object)obj2)
			{
				goto IL_00d5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = (Object)obj2;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				goto IL_00d5;
			}
		}
		goto IL_0158;
		IL_0158:
		((Image)obj2).sprite = PrimaryColor;
		Image image = layerOne;
		Color color;
		bool flag3 = ColorUtility.TryParseHtmlString(sportTeam.<colorOne>k__BackingField, out color);
		bool flag4 = !flag3;
		double num = 1.0;
		double num2 = 1.0;
		double num3 = 1.0;
		Color color2 = (Color)1.0;
		if (!flag4)
		{
			double num4 = default(double);
			num = num4;
			num2 = 0.0;
			double num5 = default(double);
			num3 = num5;
			color2 = color;
		}
		nint num6 = (nint)image;
		image.color = (Color)0;
		object obj5 = this + 72;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!(Object)obj5)
			{
				goto IL_02bd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = (Object)obj5;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				goto IL_02bd;
			}
		}
		goto IL_0340;
		IL_02bd:
		Transform transform = roomTheme.transform;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj11 = default(object);
		obj5 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0340;
		IL_00d5:
		Transform transform2 = roomTheme.transform;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v37+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = (nint)0 + (nint)552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj15 = default(object);
		obj2 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0158;
		IL_0340:
		((Image)obj5).sprite = SecondaryColor;
		if (ColorUtility.TryParseHtmlString(sportTeam.<colorTwo>k__BackingField, out color))
		{
		}
		layerTwo.color = (Color)0;
	}
}
