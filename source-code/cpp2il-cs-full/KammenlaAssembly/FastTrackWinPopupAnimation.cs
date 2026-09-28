using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class FastTrackWinPopupAnimation : MonoBehaviour
{
	public Image Sunshine;

	public Image KammelnaCupShine;

	public Image CongratsText;

	public float RoundDuration;

	public float PulsDuration;

	public float PulsSize;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_02b9: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_036b: Expected O, but got I4
		//IL_0537: Expected O, but got I4
		//IL_0302: Expected O, but got I4
		//IL_0310: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_043a: Expected O, but got I4
		//IL_03d1: Expected O, but got I4
		//IL_03df: Expected O, but got I4
		//IL_05c3: Expected O, but got I4
		//IL_05cc: Expected F4, but got I4
		//IL_05df: Expected F4, but got I4
		//IL_05f2: Expected F4, but got I4
		//IL_0605: Expected F4, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_049a: Expected O, but got I4
		//IL_04c3: Expected O, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0252: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F7]");
		object obj3 = (nint)0 & (nint)1;
		Object sunshine;
		Object sunshine2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			sunshine = Sunshine;
			sunshine2 = Sunshine;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			sunshine = Sunshine;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			sunshine2 = Sunshine;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = sunshine2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		Object obj7 = null;
		object obj8 = 0;
		if (flag4)
		{
			goto IL_00da;
		}
		goto IL_031e;
		IL_01d5:
		Object congratsText;
		bool flag5 = congratsText != null;
		bool flag6 = !flag5;
		object obj9 = 0;
		if (!flag6)
		{
			goto IL_0205;
		}
		return;
		IL_0205:
		RectTransform rectTransform = CongratsText.rectTransform;
		object obj10 = typeof(SqlSingle[]) + 3912;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		Transform rect = rectTransform;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect = rectTransform;
		}
		AnimationExtensions.AnimHeartGain(rect);
		return;
		IL_03ed:
		RectTransform rectTransform2 = KammelnaCupShine.rectTransform;
		object obj13 = typeof(SqlSingle[]) + 3912;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		Transform rect2 = rectTransform2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect2 = rectTransform2;
		}
		AnimationExtensions.AnimPulsing(rect2, PulsDuration, PulsSize);
		congratsText = CongratsText;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v4+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		float num = 0f;
		float pulsSize = PulsSize;
		float num2 = 0f;
		float pulsDuration = PulsDuration;
		float num3 = 0f;
		float num4 = PulsSize;
		float num5 = 0f;
		float num6 = PulsDuration;
		object obj19;
		object obj18 = obj19;
		Object obj20 = null;
		Object congratsText2 = CongratsText;
		if (obj17 != null)
		{
			goto IL_01d5;
		}
		goto IL_0467;
		IL_0091:
		bool flag10 = sunshine != null;
		bool flag11 = !flag10;
		object obj21 = !flag11;
		obj6 = 0;
		obj7 = null;
		obj8 = 0;
		if (obj21 == null)
		{
			goto IL_00da;
		}
		goto IL_031e;
		IL_031e:
		RectTransform rectTransform3 = Sunshine.rectTransform;
		object obj22 = typeof(SqlSingle[]) + 3912;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v14+E4]");
		bool flag12 = (nint)0 == 0;
		object obj24 = !flag12;
		Transform rect3 = rectTransform3;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect3 = rectTransform3;
		}
		AnimationExtensions.AnimGuruGoMawaru(rect3, RoundDuration);
		Object kammelnaCupShine = KammelnaCupShine;
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v16+E4]");
		bool flag13 = (nint)0 == 0;
		object obj26 = !flag13;
		pulsDuration = RoundDuration;
		float num7 = RoundDuration;
		obj6 = obj8;
		obj7 = null;
		Object kammelnaCupShine2 = KammelnaCupShine;
		if (obj26 != null)
		{
			goto IL_0123;
		}
		goto IL_0398;
		IL_0467:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = congratsText2 != null;
		bool flag15 = !flag14;
		object obj27 = !flag15;
		num = num3;
		pulsSize = num4;
		num2 = num5;
		pulsDuration = num6;
		obj9 = 0;
		if (obj27 == null)
		{
			return;
		}
		goto IL_0205;
		IL_0174:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v4+E4]");
		bool flag16 = (nint)0 == 0;
		congratsText = CongratsText;
		num3 = num;
		num4 = pulsSize;
		num5 = num2;
		num6 = pulsDuration;
		congratsText2 = CongratsText;
		if (!flag16)
		{
			goto IL_01d5;
		}
		goto IL_0467;
		IL_00da:
		obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v16+E4]");
		bool flag17 = (nint)0 == 0;
		kammelnaCupShine = KammelnaCupShine;
		num7 = pulsDuration;
		kammelnaCupShine2 = KammelnaCupShine;
		if (!flag17)
		{
			goto IL_0123;
		}
		goto IL_0398;
		IL_0398:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag18 = kammelnaCupShine2 != null;
		bool flag19 = !flag18;
		pulsDuration = num7;
		obj18 = 0;
		obj20 = null;
		obj19 = 0;
		if (flag19)
		{
			goto IL_0174;
		}
		goto IL_03ed;
		IL_0123:
		bool flag20 = kammelnaCupShine != null;
		bool flag21 = !flag20;
		object obj28 = !flag21;
		obj18 = 0;
		obj20 = null;
		num7 = pulsDuration;
		obj19 = 0;
		if (obj28 == null)
		{
			goto IL_0174;
		}
		goto IL_03ed;
	}

	public void TestSunshineSpin()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01c9: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F8]");
		object obj3 = (nint)0 & (nint)1;
		Object sunshine;
		Object sunshine2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			sunshine = Sunshine;
			sunshine2 = Sunshine;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			sunshine = Sunshine;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			sunshine2 = Sunshine;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = sunshine2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00c1;
		IL_00c1:
		RectTransform rectTransform = Sunshine.rectTransform;
		object obj8 = typeof(SqlSingle[]) + 3912;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		Transform rect = rectTransform;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect = rectTransform;
		}
		AnimationExtensions.AnimGuruGoMawaru(rect, RoundDuration);
		return;
		IL_0091:
		bool flag6 = sunshine != null;
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			goto IL_00c1;
		}
	}

	public void TestCupShinePulse()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01c9: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F9]");
		object obj3 = (nint)0 & (nint)1;
		Object kammelnaCupShine;
		Object kammelnaCupShine2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			kammelnaCupShine = KammelnaCupShine;
			kammelnaCupShine2 = KammelnaCupShine;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			kammelnaCupShine = KammelnaCupShine;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			kammelnaCupShine2 = KammelnaCupShine;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = kammelnaCupShine2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00c1;
		IL_00c1:
		RectTransform rectTransform = KammelnaCupShine.rectTransform;
		object obj8 = typeof(SqlSingle[]) + 3912;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		Transform rect = rectTransform;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect = rectTransform;
		}
		AnimationExtensions.AnimPulsing(rect, PulsDuration, PulsSize);
		return;
		IL_0091:
		bool flag6 = kammelnaCupShine != null;
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			goto IL_00c1;
		}
	}

	public void TestCongratsShow()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01c9: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89FA]");
		object obj3 = (nint)0 & (nint)1;
		Object kammelnaCupShine;
		Object kammelnaCupShine2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			kammelnaCupShine = KammelnaCupShine;
			kammelnaCupShine2 = KammelnaCupShine;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			kammelnaCupShine = KammelnaCupShine;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			kammelnaCupShine2 = KammelnaCupShine;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = kammelnaCupShine2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00c1;
		IL_00c1:
		RectTransform rectTransform = KammelnaCupShine.rectTransform;
		object obj8 = typeof(SqlSingle[]) + 3912;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		Transform rect = rectTransform;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect = rectTransform;
		}
		AnimationExtensions.AnimHeartGain(rect);
		return;
		IL_0091:
		bool flag6 = kammelnaCupShine != null;
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			goto IL_00c1;
		}
	}

	public void TestStopAnimation()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0269: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_031b: Expected O, but got I4
		//IL_04b0: Expected O, but got I4
		//IL_02b2: Expected O, but got I4
		//IL_02c0: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_0387: Expected O, but got I4
		//IL_0512: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		//IL_044b: Expected O, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89FB]");
		object obj3 = (nint)0 & (nint)1;
		Object sunshine;
		Object sunshine2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			sunshine = Sunshine;
			sunshine2 = Sunshine;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			sunshine = Sunshine;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			sunshine2 = Sunshine;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = sunshine2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		Object obj7 = null;
		object obj8 = 0;
		if (flag4)
		{
			goto IL_00da;
		}
		goto IL_02ce;
		IL_01a5:
		Object congratsText;
		bool flag5 = congratsText != null;
		bool flag6 = !flag5;
		object obj9 = 0;
		if (!flag6)
		{
			goto IL_01d5;
		}
		return;
		IL_01d5:
		RectTransform rectTransform = CongratsText.rectTransform;
		object obj10 = typeof(SqlSingle[]) + 3912;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v22+E4]");
		if ((nint)0 != 0)
		{
			AnimationExtensions.AnimEndAnimation(rectTransform);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AnimationExtensions.AnimEndAnimation(rectTransform);
		return;
		IL_0395:
		RectTransform rectTransform2 = KammelnaCupShine.rectTransform;
		object obj12 = typeof(SqlSingle[]) + 3912;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		Transform rect = rectTransform2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect = rectTransform2;
		}
		AnimationExtensions.AnimEndAnimation(rect);
		congratsText = CongratsText;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v4+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		object obj18;
		object obj17 = obj18;
		Object obj19 = null;
		Object congratsText2 = CongratsText;
		if (obj16 != null)
		{
			goto IL_01a5;
		}
		goto IL_040f;
		IL_0091:
		bool flag9 = sunshine != null;
		bool flag10 = !flag9;
		object obj20 = !flag10;
		obj6 = 0;
		obj7 = null;
		obj8 = 0;
		if (obj20 == null)
		{
			goto IL_00da;
		}
		goto IL_02ce;
		IL_02ce:
		RectTransform rectTransform3 = Sunshine.rectTransform;
		object obj21 = typeof(SqlSingle[]) + 3912;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v14+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		Transform rect2 = rectTransform3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect2 = rectTransform3;
		}
		AnimationExtensions.AnimEndAnimation(rect2);
		Object kammelnaCupShine = KammelnaCupShine;
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v16+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		obj6 = obj8;
		obj7 = null;
		Object kammelnaCupShine2 = KammelnaCupShine;
		if (obj25 != null)
		{
			goto IL_011b;
		}
		goto IL_0348;
		IL_040f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = congratsText2 != null;
		bool flag14 = !flag13;
		object obj26 = !flag14;
		obj9 = 0;
		if (obj26 == null)
		{
			return;
		}
		goto IL_01d5;
		IL_0164:
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v4+E4]");
		bool flag15 = (nint)0 == 0;
		congratsText = CongratsText;
		congratsText2 = CongratsText;
		if (!flag15)
		{
			goto IL_01a5;
		}
		goto IL_040f;
		IL_00da:
		obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v16+E4]");
		bool flag16 = (nint)0 == 0;
		kammelnaCupShine = KammelnaCupShine;
		kammelnaCupShine2 = KammelnaCupShine;
		if (!flag16)
		{
			goto IL_011b;
		}
		goto IL_0348;
		IL_0348:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = kammelnaCupShine2 != null;
		bool flag18 = !flag17;
		obj17 = 0;
		obj19 = null;
		obj18 = 0;
		if (flag18)
		{
			goto IL_0164;
		}
		goto IL_0395;
		IL_011b:
		bool flag19 = kammelnaCupShine != null;
		bool flag20 = !flag19;
		object obj27 = !flag20;
		obj17 = 0;
		obj19 = null;
		obj18 = 0;
		if (obj27 == null)
		{
			goto IL_0164;
		}
		goto IL_0395;
	}

	public FastTrackWinPopupAnimation()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253618]");
		RoundDuration = 0f;
		PulsSize = 0.4f;
		base..ctor();
	}
}
