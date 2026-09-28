using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CollapsibleUI : MonoBehaviour
{
	[Serializable]
	public class CollapsibleItem
	{
		public LayoutElement Title;

		public LayoutElement Body;

		private Button _button;

		public Button Button
		{
			get
			{
				//IL_0009: Expected O, but got I4
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected O, but got Unknown
				//IL_0033: Expected O, but got I
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Expected O, but got Unknown
				//IL_011a: Expected O, but got I4
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Expected O, but got Unknown
				//IL_016e: Expected O, but got I4
				//IL_01af: Expected O, but got I
				object obj = 152989696;
				object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A88]");
				object obj3 = (nint)0 & (nint)1;
				object obj4;
				UnityEngine.Object obj5;
				UnityEngine.Object obj7;
				object obj8;
				if (obj3 != null)
				{
					obj4 = this + 32;
					obj5 = (UnityEngine.Object)obj4;
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
					bool flag = (nint)0 == 0;
					obj7 = (UnityEngine.Object)obj4;
					obj8 = obj4;
					if (!flag)
					{
						goto IL_00a0;
					}
				}
				else
				{
					_ = 1;
					obj4 = this + 32;
					obj5 = (UnityEngine.Object)obj4;
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					obj7 = (UnityEngine.Object)obj4;
					obj8 = obj4;
					if (obj9 != null)
					{
						goto IL_00a0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = obj7;
				bool flag4 = !flag3;
				object obj10 = !flag4;
				obj4 = obj8;
				if (obj10 != null)
				{
					goto IL_00d2;
				}
				goto IL_0184;
				IL_00d2:
				return (Button)obj4;
				IL_0184:
				if ((object)Title != null)
				{
					object obj11 = (nint)0 + (nint)3640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					Button button = default(Button);
					obj8 = button;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return button;
				}
				return (Button)(object)new NullReferenceException();
				IL_00a0:
				bool flag5 = obj5;
				bool flag6 = !flag5;
				obj8 = obj4;
				if (!flag6)
				{
					goto IL_00d2;
				}
				goto IL_0184;
			}
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public CollapsibleItem item;

		public CollapsibleUI <>4__this;

		internal void <Start>b__0()
		{
			<>4__this.OnTitleClick(item);
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public CollapsibleItem item;

		internal void <CollapseAll>b__0()
		{
			//IL_0029: Expected I, but got O
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			CollapsibleItem collapsibleItem = item;
			LayoutElement title = collapsibleItem.Title;
			nint num = (nint)title;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<UnityEngine.UI.LayoutElement>)+358]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<UnityEngine.UI.LayoutElement>)+360]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private CollapsibleItem[] items;

	public UnityEvent<bool> onStateChanged;

	private float titleHeight;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_006e: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01de: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_0233: Expected O, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02e7: Expected I, but got O
		//IL_030b: Expected O, but got I4
		object obj = (nint)0 + (nint)504;
		UnityAction unityAction = (UnityAction)obj;
		object obj2 = Enumerable.FirstOrDefault((IEnumerable<object>)items);
		CollapsibleItem[] array;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v16+390]");
			unityAction = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ X8_v16+388] (should have been resolved before IL gen)");
			float num = default(float);
			titleHeight = num;
			bool flag = items == null;
			object obj5 = !flag;
			array = items;
			if (obj5 == null)
			{
				goto IL_0319;
			}
		}
		else
		{
			titleHeight = 125f;
			array = items;
		}
		if (array.Length < 1)
		{
			return;
		}
		object obj6 = typeof(CardUtils.<>c) + 1816;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj8 = array + 32;
		object obj9 = (nint)0 + (nint)1160;
		object obj10 = 0;
		object obj11 = default(object);
		UnityAction unityAction3 = default(UnityAction);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj11..ctor();
			object obj12 = obj11 + 24;
			obj12 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = (nint)obj10 < array.Length;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				object obj14 = obj11 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X28_v4+v102 @ X24_v5*8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj15 = obj14;
				object obj16 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v10+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v9+18]");
					bool flag3 = (UnityEngine.Object)0;
					bool flag4 = !flag3;
					unityAction = null;
					if (flag4)
					{
						goto IL_0133;
					}
					UnityAction unityAction2 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v9+18]");
					bool flag5 = (UnityEngine.Object)0;
					bool flag6 = !flag5;
					unityAction = null;
					UnityAction unityAction2 = null;
					if (flag6)
					{
						goto IL_0133;
					}
				}
				Button button = ((CollapsibleItem)obj14).Button;
				object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				unityAction3..ctor(obj11, (IntPtr)obj9);
				bool flag7 = button.m_OnClick == null;
				object obj18 = !flag7;
				if (obj18 != null)
				{
					button.m_OnClick.AddListener(unityAction3);
					unityAction = unityAction3;
					goto IL_0133;
				}
				break;
			}
			throw new IndexOutOfRangeException();
			IL_0133:
			obj10++;
			if ((nint)obj10 < array.Length)
			{
				continue;
			}
			return;
		}
		goto IL_0319;
		IL_0319:
		throw new NullReferenceException();
	}

	private void OnTitleClick(CollapsibleItem item)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0269: Expected O, but got I
		//IL_02a6: Expected O, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_01cd: Expected O, but got I
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_019f: Expected F4, but got O
		//IL_019f: Expected O, but got I4
		//IL_019f: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (item.Body == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = item.Body == null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		Button button = item.Button;
		button.interactable = false;
		CollapsibleItem[] array = items;
		object obj4 = array.Length;
		object obj5 = typeof(UsageHint) + 744;
		object obj7 = default(object);
		if (array.Length >= 1)
		{
			object obj6 = items + 32;
			object obj8 = default(object);
			obj7 = obj8;
			object obj9 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X25_v4+v133 @ X24_v5*8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X25_v4+v133 @ X24_v5*8]");
				if (item != null)
				{
					object obj11 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v24+B8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v25+4]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v5+10]");
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize((LayoutElement)0, (Vector2)0, (float)obj12);
					obj4 = array.Length;
					object obj13 = 1045220557;
				}
				obj9++;
			}
			while (obj9 < obj4);
		}
		item.Title.minHeight = titleHeight;
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v12+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v13+10]");
		float duration = 0f * (float)obj7;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOPreferredSize(item.Body, (Vector2)0, duration);
		onStateChanged.Invoke(arg0: true);
	}

	public void CollapseAll()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0194: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I
		//IL_02b4: Expected O, but got I
		//IL_02ce: Expected O, but got I4
		//IL_006e: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		//IL_00bf: Expected O, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_03fa: Expected O, but got I
		//IL_0419: Expected F4, but got O
		//IL_0419: Expected O, but got I4
		//IL_0419: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_0103: Expected I, but got O
		//IL_010f: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		CollapsibleItem[] array = items;
		if (items == null)
		{
			goto IL_03a4;
		}
		if (array.Length < 1)
		{
			goto IL_0373;
		}
		object obj = items + 32;
		object obj2 = typeof(UsageHint) + 744;
		object obj3 = 0;
		object obj5 = default(object);
		TweenCallback tweenCallback = default(TweenCallback);
		while (true)
		{
			object obj4 = typeof(CardUtils.<>c) + 1824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj5..ctor();
			bool flag = (nint)obj3 < array.Length;
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			object obj7;
			if (obj5 != null)
			{
				obj7 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v5+v128 @ X25_v6*8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj7 != null)
				{
					Button button = ((CollapsibleItem)obj7).Button;
					if ((object)button != null)
					{
						button.interactable = true;
						object obj8 = obj7;
						if (obj7 != null)
						{
							object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v16+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v13+18]");
								bool flag2 = (UnityEngine.Object)0 != null;
								bool flag3 = !flag2;
								object obj11 = !flag3;
								if (obj11 != null)
								{
									goto IL_031f;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v13+18]");
								if ((UnityEngine.Object)0 != null)
								{
									goto IL_031f;
								}
							}
							goto IL_0349;
						}
					}
				}
			}
			goto IL_03a4;
			IL_0349:
			object obj12 = obj7;
			if (obj7 != null)
			{
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v22+B8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v23+10]");
				float duration = 0f * titleHeight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v23+14]");
				float num = 0f * titleHeight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v18+10]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize((LayoutElement)0, (Vector2)0, duration);
				object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj16 = (nint)0 + (nint)1168;
				tweenCallback..ctor(obj5, (IntPtr)obj16);
				object obj17 = (nint)0 + (nint)2488;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				obj3++;
				if ((nint)obj3 < array.Length)
				{
					continue;
				}
				goto IL_0373;
			}
			goto IL_03a4;
			IL_031f:
			object obj18 = obj7;
			if (obj7 != null)
			{
				object obj19 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v35+B8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v31+18]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOPreferredSize((LayoutElement)0, (Vector2)0, (float)obj20);
				goto IL_0349;
			}
			goto IL_03a4;
		}
		goto IL_03b2;
		IL_0373:
		if (onStateChanged != null)
		{
			onStateChanged.Invoke(arg0: false);
			return;
		}
		goto IL_03a4;
		IL_03b2:
		throw new IndexOutOfRangeException();
		IL_03a4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03b2;
	}

	public CollapsibleUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 544;
		object obj2 = (nint)0 + (nint)824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40293B8");
		object obj3 = this + 40;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
