using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class MiniGameResultMessage : MonoBehaviour
{
	public static readonly Color BlockerColor;

	public static readonly Color BlockerColorLose;

	private PopupUI popup;

	private GameObject winPanel;

	private TextMeshProUGUI winMessageText;

	private TextMeshProUGUI prizeValueText;

	private WinPopupAnimations winAnimations;

	private GameObject losePanel;

	private TextMeshProUGUI loseMessageText;

	private Transform[] _foregroundReparentTargets;

	private CanvasLayer _foregroundCanvas = CanvasLayer.SecondaryCanvas;

	private Transform[] _originalParents;

	private int[] _originalSiblingIndexes;

	private bool _isReparented;

	public void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		popup.SlideToBottom(action);
	}

	public unsafe void ShowWinPopup(string message, string prizeText, int prizeValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03a9: Expected O, but got I4
		//IL_0035: Expected O, but got Ref
		//IL_005a: Expected O, but got Ref
		//IL_0070: Expected I, but got O
		//IL_0080: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I
		//IL_01ca: Expected O, but got Ref
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0216: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02c0: Expected O, but got I
		//IL_0253: Expected O, but got Ref
		//IL_02f2: Expected I, but got O
		//IL_0279: Expected O, but got I
		//IL_0291: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		string text = default(string);
		TextMeshProExtensions.Localize(winMessageText, text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag = array == null;
		object[] array2 = null;
		int num = default(int);
		string text2 = (string)(&num);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text3;
		if (!flag)
		{
			object obj3 = default(object);
			bool flag2 = obj3 == null;
			text2 = (string)(&num);
			if (!flag2)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				array2 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				if (flag3)
				{
					goto IL_036b;
				}
			}
			bool flag4 = array.Length == 0;
			array2 = null;
			if (flag4)
			{
				goto IL_0355;
			}
			object obj4 = array + 32;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(prizeValueText, prizeText, array);
			PopupUI popupUI = popup;
			bool flag5 = (object)popup == null;
			int num3 = 0;
			array2 = array;
			text2 = prizeText;
			if (!flag5)
			{
				bool flag6 = (object)popupUI.blocker == null;
				num3 = 0;
				array2 = array;
				text2 = prizeText;
				if (!flag6)
				{
					object obj5 = (nint)0 + (nint)1008;
					array2 = (object[])obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
					object obj6 = default(object);
					bool flag7 = obj6 == null;
					object obj7 = default(object);
					text2 = (string)(&obj7);
					if (!flag7)
					{
						object obj8 = typeof(MemberAchievementClanFeedData) + 800;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v27+E4]");
						bool flag8 = (nint)0 == 0;
						object obj10 = !flag8;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag9 = obj7 == null;
						num3 = 0;
						text2 = (string)(&obj7);
						if (flag9)
						{
							goto IL_0347;
						}
						object obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v15+B8]");
						object obj12 = 0;
						object obj13 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v17+2B0]");
						text2 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ X8_v17+2A8] (should have been resolved before IL gen)");
					}
					bool flag10 = (object)winPanel == null;
					num3 = 0;
					if (!flag10)
					{
						object obj14 = typeof(SqlSingle[]) + 2376;
						object obj15 = (nint)0 + (nint)1712;
						winPanel.SetActive(value: true);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action action = default(Action);
						action..ctor(winAnimations, (IntPtr)obj15);
						bool flag11 = (object)popup == null;
						num3 = 0;
						array2 = (object[])obj15;
						text2 = (string)(object)winAnimations;
						if (!flag11)
						{
							popup.SlideFromBottom(action);
							ReparentForegroundTargets();
							return;
						}
					}
				}
			}
		}
		goto IL_0347;
		IL_0355:
		ex = new IndexOutOfRangeException();
		text3 = text2;
		goto IL_036b;
		IL_036b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0347:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0355;
	}

	public void ShowLosePopup(string message)
	{
		//IL_0011: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		string text = default(string);
		TextMeshProExtensions.Localize(loseMessageText, text);
		PopupUI popupUI = popup;
		object obj = (nint)0 + (nint)1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 800;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v9+B8]");
			object obj7 = 0;
			object obj9 = default(object);
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X8_v11+2A8] (should have been resolved before IL gen)");
		}
		losePanel.SetActive(value: true);
		popup.SlideFromBottom();
		ReparentForegroundTargets();
	}

	private void ReparentForegroundTargets()
	{
		//IL_000f: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_016a: Expected O, but got I
		//IL_04ea: Expected O, but got I4
		//IL_02c0: Expected O, but got I
		//IL_02e3: Expected O, but got I4
		//IL_0257: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_05fe: Expected O, but got I
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected O, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected O, but got Unknown
		//IL_0621: Expected O, but got I4
		//IL_05a3: Expected O, but got I
		//IL_05c1: Expected O, but got I4
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0659: Expected O, but got I
		//IL_0662: Expected O, but got I4
		//IL_0675: Expected O, but got I4
		//IL_034b: Expected O, but got I
		//IL_03f2: Expected O, but got I
		//IL_0413: Expected O, but got I4
		//IL_03ab: Expected O, but got I
		//IL_03d4: Expected O, but got I
		//IL_0458: Expected O, but got I
		//IL_048f: Expected O, but got I4
		//IL_04aa: Expected O, but got I4
		Transform[] array = _foregroundReparentTargets;
		if (_foregroundReparentTargets == null)
		{
			return;
		}
		UnityEngine.Object obj = (UnityEngine.Object)array.Length;
		if (array.Length == 0 || _isReparented)
		{
			return;
		}
		object obj2 = this + 104;
		object obj3 = obj2;
		_ = 1;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X9_v3+18]");
			if ((nint)0 == array.Length)
			{
				goto IL_01a7;
			}
		}
		object obj4 = typeof(SqlSingle[]) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Transform[] array2 = default(Transform[]);
		_originalParents = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform[] foregroundReparentTargets = _foregroundReparentTargets;
		bool flag = _foregroundReparentTargets == null;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		UnityEngine.Object obj5 = (UnityEngine.Object)(object)array2;
		if (!flag)
		{
			object obj6 = typeof(TypeConverter<ushort, char>) + 3048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj7 = this + 112;
			UnityEngine.Object obj8 = default(UnityEngine.Object);
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v13-18]");
			array = (Transform[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X21_v13-18]");
			bool flag4 = (nint)0 == 0;
			obj = obj8;
			flag2 = flag3;
			obj5 = obj8;
			if (!flag4)
			{
				goto IL_01a7;
			}
		}
		goto IL_067a;
		IL_0688:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_01a7:
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = 32;
		object obj11 = 8;
		object obj17 = default(object);
		bool flag14;
		NullReferenceException ex = default(NullReferenceException);
		do
		{
			object obj12 = obj11 - 8;
			if ((nint)obj12 < array.Length)
			{
				object obj13 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v21+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10 (UnityEngine.Transform[])+v99 @ X25_v6]");
					bool flag5 = (UnityEngine.Object)0 == null;
					bool flag6 = !flag5;
					object obj14 = !flag6;
					flag3 = false;
					obj = null;
					if (obj14 == null)
					{
						flag2 = false;
						obj5 = null;
						goto IL_030d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10 (UnityEngine.Transform[])+v99 @ X25_v6]");
					bool flag7 = (UnityEngine.Object)0 == null;
					bool flag8 = !flag7;
					object obj15 = !flag8;
					flag2 = false;
					obj5 = null;
					flag3 = false;
					obj = null;
					if (obj15 == null)
					{
						goto IL_030d;
					}
				}
				goto IL_06c7;
			}
			object obj16 = obj17;
			object obj18 = 0;
			bool flag13;
			do
			{
				if ((nint)obj18 >= array.Length)
				{
					return;
				}
				object obj19 = (object)array + obj18;
				object obj20 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v11+20]");
					bool flag9 = (UnityEngine.Object)0 == null;
					bool flag10 = !flag9;
					object obj21 = !flag10;
					flag3 = false;
					obj = null;
					if (obj21 != null)
					{
						goto IL_04ef;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v11+20]");
					bool flag11 = (UnityEngine.Object)0 == null;
					bool flag12 = !flag11;
					object obj22 = !flag12;
					flag3 = false;
					obj = null;
					if (obj22 != null)
					{
						goto IL_04ef;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v11+20]");
				UIExtensions.AttachToCanvas((Transform)0, _foregroundCanvas);
				obj16 = 0;
				flag3 = false;
				obj = (UnityEngine.Object)_foregroundCanvas;
				goto IL_04ef;
				IL_04ef:
				obj18++;
				array = _foregroundReparentTargets;
				flag13 = _foregroundReparentTargets == null;
				flag2 = flag3;
				obj5 = obj;
			}
			while (!flag13);
			break;
			IL_06c7:
			array = _foregroundReparentTargets;
			obj11++;
			obj10 += 8;
			flag14 = _foregroundReparentTargets == null;
			flag2 = flag3;
			obj5 = obj;
			continue;
			IL_030d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10 (UnityEngine.Transform[])+v99 @ X25_v6]");
			if ((nint)0 == 0)
			{
				break;
			}
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10 (UnityEngine.Transform[])+v99 @ X25_v6]");
			Transform parent = ((Transform)0).parent;
			bool flag15 = obj2 == null;
			obj5 = null;
			if (flag15)
			{
				break;
			}
			bool flag16 = (object)parent == null;
			obj = null;
			if (!flag16)
			{
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+40]");
				obj = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag17 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+40]");
				obj5 = (UnityEngine.Object)0;
				if (flag17)
				{
					goto IL_0688;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X27_v7+18]");
			array = (Transform[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X27_v7+18]");
			bool flag18 = (nint)obj12 < 0;
			object obj25 = !flag18;
			if (obj25 == null)
			{
				object obj26 = obj2 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				int[] originalSiblingIndexes = _originalSiblingIndexes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10 (UnityEngine.Transform[])+v99 @ X25_v6]");
				int siblingIndex = ((Transform)0).GetSiblingIndex();
				bool flag19 = _originalSiblingIndexes == null;
				obj5 = null;
				if (flag19)
				{
					break;
				}
				array = (Transform[])originalSiblingIndexes.Length;
				bool flag20 = (nint)obj12 < originalSiblingIndexes.Length;
				object obj27 = !flag20;
				object obj28 = ~obj27;
				obj = null;
				if (obj28 != null)
				{
					flag3 = flag2;
					obj = null;
					goto IL_06c7;
				}
			}
			flag3 = flag2;
			throw new IndexOutOfRangeException();
		}
		while (!flag14);
		goto IL_067a;
		IL_067a:
		ex = new NullReferenceException();
		goto IL_0688;
	}

	private void RestoreForegroundTargets()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_01da: Expected O, but got I4
		//IL_01df: Expected I, but got O
		//IL_01e8: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_0163: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_0171: Expected I, but got O
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_0225: Expected O, but got I4
		//IL_02da: Expected O, but got I
		//IL_02fd: Expected O, but got I4
		//IL_0306: Expected O, but got I4
		//IL_030b: Expected I, but got O
		//IL_027f: Expected O, but got I
		//IL_029d: Expected O, but got I4
		//IL_02a6: Expected O, but got I4
		//IL_02ab: Expected I, but got O
		//IL_0343: Expected O, but got I4
		//IL_0380: Expected O, but got I
		//IL_0380: Expected O, but got I
		//IL_03aa: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		Transform[] foregroundReparentTargets = _foregroundReparentTargets;
		if (_foregroundReparentTargets == null || _originalParents == null || !_isReparented)
		{
			return;
		}
		_isReparented = false;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		for (object obj2 = 0; (nint)obj2 < foregroundReparentTargets.Length; obj2++, foregroundReparentTargets = _foregroundReparentTargets)
		{
			object obj3 = (object)foregroundReparentTargets + obj2;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v6+20]");
				bool flag = (UnityEngine.Object)0 == null;
				bool flag2 = !flag;
				object obj5 = !flag2;
				object obj6 = 0;
				nint num = unchecked((nint)null);
				if (obj5 != null)
				{
					continue;
				}
				object obj7 = 0;
				UnityEngine.Object obj8 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v6+20]");
				bool flag3 = (UnityEngine.Object)0 == null;
				bool flag4 = !flag3;
				object obj9 = !flag4;
				object obj6 = 0;
				nint num = unchecked((nint)null);
				object obj7 = 0;
				UnityEngine.Object obj8 = null;
				if (obj9 != null)
				{
					continue;
				}
			}
			Transform[] originalParents = _originalParents;
			bool flag5 = (nint)obj2 < originalParents.Length;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				object obj11 = (object)originalParents + obj2;
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v11+20]");
					bool flag6 = (UnityEngine.Object)0 == null;
					bool flag7 = !flag6;
					object obj13 = !flag7;
					object obj6 = 0;
					nint num = unchecked((nint)null);
					if (obj13 != null)
					{
						continue;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v11+20]");
					bool flag8 = (UnityEngine.Object)0 == null;
					bool flag9 = !flag8;
					object obj14 = !flag9;
					object obj6 = 0;
					nint num = unchecked((nint)null);
					if (obj14 != null)
					{
						continue;
					}
				}
				Transform[] originalParents2 = _originalParents;
				bool flag10 = (nint)obj2 < originalParents2.Length;
				object obj15 = !flag10;
				if (obj15 == null)
				{
					object obj16 = (object)originalParents2 + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v6+20]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v14+20]");
					((Transform)num2).SetParent((Transform)0, worldPositionStays: false);
					int[] originalSiblingIndexes = _originalSiblingIndexes;
					bool flag11 = (nint)obj2 < originalSiblingIndexes.Length;
					object obj17 = !flag11;
					object obj18 = ~obj17;
					if (obj18 != null)
					{
						object obj19 = (object)originalSiblingIndexes + obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v6+20]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v16+20]");
						((Transform)num3).SetSiblingIndex(0);
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v16+20]");
						nint num = 0;
						continue;
					}
				}
			}
			throw new IndexOutOfRangeException();
		}
	}

	static MiniGameResultMessage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 800;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B70]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B80]");
		_ = 0;
	}

	private void <Hide>b__14_0()
	{
		RestoreForegroundTargets();
		winPanel.SetActive(value: false);
		losePanel.SetActive(value: false);
	}
}
