using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeProgressBar : MonoBehaviour
{
	private Image redProgress;

	private Transform fireIcon;

	private List<Transform> positions;

	private List<TextMeshProUGUI> numberLables;

	private List<float> redBarFillValues;

	private GameObject maxLevelDecorations;

	private Color numberOnFireColor;

	private int valueForTest;

	private int _finalResult;

	private void Awake()
	{
	}

	public void SetProgress(int result)
	{
		//IL_008d: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		_finalResult = result;
		int index = result + 3;
		float fillAmount = redBarFillValues.get_Item(index);
		redProgress.fillAmount = fillAmount;
		int fireToPosition = result + 3;
		SetFireToPosition(fireToPosition);
		int colorFor;
		if (result <= 0)
		{
			object obj = result + 3;
			if (obj != null)
			{
				object obj2 = result + 1;
				if (obj2 == null)
				{
					colorFor = 1;
					goto IL_0196;
				}
				if (result != 0)
				{
					goto IL_00f2;
				}
			}
			goto IL_015a;
		}
		if (result != 1)
		{
			if (result != 2)
			{
				if (result != 3)
				{
					goto IL_00f2;
				}
				goto IL_015a;
			}
			colorFor = 3;
		}
		else
		{
			colorFor = 2;
		}
		goto IL_0196;
		IL_00f2:
		colorFor = 0;
		goto IL_0196;
		IL_015a:
		ClearColor();
		ShowExtraDecorations();
		return;
		IL_0196:
		SetColorFor(colorFor);
		ShowExtraDecorations();
	}

	public void TestWithValue()
	{
		SetProgress(valueForTest);
	}

	private void FillRedBar(int result)
	{
		int index = result + 3;
		float fillAmount = redBarFillValues.get_Item(index);
		redProgress.fillAmount = fillAmount;
	}

	private void SetFireToPosition(int pos)
	{
		//IL_0054: Expected O, but got I4
		object obj = ((List<object>)(object)positions).get_Item(pos);
		Vector3 localPosition = ((Transform)obj).localPosition;
		Vector3 localPosition2 = fireIcon.localPosition;
		fireIcon.localPosition = (Vector3)0;
		object obj2 = ((List<object>)(object)positions).get_Item(pos);
		GameObject gameObject = ((Component)obj2).gameObject;
		gameObject.SetActive(value: false);
	}

	private void ColorNumber(int result)
	{
		//IL_002b: Expected O, but got I4
		//IL_0056: Expected O, but got I4
		if (result <= 0)
		{
			object obj = result + 3;
			if (obj != null)
			{
				object obj2 = result + 1;
				if (obj2 == null)
				{
					SetColorFor(1);
					return;
				}
				if (result != 0)
				{
					goto IL_0090;
				}
			}
		}
		else
		{
			if (result == 1)
			{
				SetColorFor(2);
				return;
			}
			if (result == 2)
			{
				SetColorFor(3);
				return;
			}
			if (result != 3)
			{
				goto IL_0090;
			}
		}
		ClearColor();
		return;
		IL_0090:
		SetColorFor(0);
	}

	private static bool PositionDoesNotHaveNumberLabel(int result)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_004c: Expected I4, but got O
		object obj = result + 3;
		bool flag = (nint)obj < 7;
		object obj2 = !flag;
		object obj3 = ~obj2;
		object obj4 = 73 >> (int)obj;
		return (byte)(obj3 & obj4) != 0;
	}

	private int TranslateResultToIndex(int result)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		object obj = result + 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		object obj3 = obj - 3;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119877632 + 1680;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1*4]");
			return 0;
		}
		return 0;
	}

	private void SetColorFor(int indx)
	{
		//IL_002e: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_0058: Expected O, but got I
		//IL_0060: Expected I, but got O
		//IL_0070: Expected O, but got I
		//IL_0080: Expected O, but got I
		while (true)
		{
			ClearColor();
			object obj = ((List<object>)(object)numberLables).get_Item(indx);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChallengeProgressBar)+58]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChallengeProgressBar)+5C]");
			object obj3 = 0;
			Color color = numberOnFireColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChallengeProgressBar)+54]");
			object obj4 = 0;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<System.Object>)+2A8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<System.Object>)+2B0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v63 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	private void ClearColor()
	{
		//IL_0126: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_013c: Expected I, but got O
		//IL_00c7: Expected I, but got O
		//IL_003b: Expected O, but got I4
		//IL_0079: Expected O, but got I4
		bool flag = numberLables == null;
		object obj = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)2280;
			obj = (nint)0 + (nint)2272;
			List<object>.Enumerator enumerator = ((List<object>)(object)numberLables).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj3 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj4 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E7C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private int TranslateLevelToArrayPosition(int level)
	{
		return level + 3;
	}

	private bool ChallengeIsMaxLevel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = ((_finalResult >= 0) ? _finalResult : (-_finalResult));
		object obj4 = num - 3;
		return obj4 == null;
	}

	private void ShowExtraDecorations()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_019a: Expected O, but got I
		//IL_0255: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_02ac: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A2A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			obj5 = maxLevelDecorations;
			obj6 = maxLevelDecorations;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = maxLevelDecorations;
			obj6 = maxLevelDecorations;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_01e4:
		int num = ((_finalResult >= 0) ? _finalResult : (-_finalResult));
		object obj11 = num - 3;
		bool active = obj11 == null;
		maxLevelDecorations.SetActive(active);
		return;
		IL_0170:
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF144]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01e4;
			}
		}
		else
		{
			_ = 1;
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v4+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 != null)
			{
				goto IL_01e4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = (object)maxLevelDecorations == null;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01e4;
		IL_0091:
		bool flag7 = obj5 == null;
		bool flag8 = !flag7;
		obj9 = 0;
		obj10 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0170;
	}
}
