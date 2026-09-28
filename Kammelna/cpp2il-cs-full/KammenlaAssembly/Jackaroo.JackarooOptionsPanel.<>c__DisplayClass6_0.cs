using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooOptionsPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<JackarooActionOptionUi> <>9__2_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Awake>b__2_2(JackarooActionOptionUi optionUi)
		{
			Transform transform = optionUi.transform;
			transform.SetParent(null);
			GameObject gameObject = optionUi.gameObject;
			gameObject.SetActive(value: false);
			optionUi.Reset();
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public Action<JackarooActions> onSelectedAction;

		public JackarooOptionsPanel <>4__this;

		public Action<JackarooActions> <>9__0;

		internal void <ShowActionsOptions>b__0(JackarooActions actions)
		{
			Action<JackarooActions> action = onSelectedAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ X8_v1 (System.Action`1<Jackaroo.JackarooActions>)+18] (should have been resolved before IL gen)");
			<>4__this.Dismiss();
		}
	}

	private DOTweenAnimation _animation;

	private ObjectPool<JackarooActionOptionUi> _optionsPool;

	private JackarooActionOptionUi _jackarooUiOptionPrefab;

	private HorizontalLayoutGroup _parent;

	private readonly List<JackarooActionOptionUi> _jackarooUiOptions;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0164: Expected I, but got O
		//IL_0061: Expected I, but got O
		//IL_006f: Expected I, but got O
		//IL_0099: Expected O, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0193: Expected O, but got I
		//IL_01a3: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_0207: Expected O, but got I
		//IL_020f: Expected I, but got O
		//IL_0220: Expected I, but got O
		//IL_023e: Expected O, but got I
		//IL_0259: Expected O, but got I4
		//IL_0110: Expected O, but got I
		object obj = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2408;
		object obj2 = (nint)0 + (nint)816;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2432;
		object obj4 = (nint)0 + (nint)824;
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object> func = default(Func<object>);
		func..ctor((object)this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj4;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		object obj8 = typeof(List<Tween>) + 2672;
		object obj9 = (nint)0 + (nint)1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v7+8]");
		Action<object> action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v7+8]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		object obj12 = 0;
		object obj13 = this;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v11+B8]");
				obj10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)2344;
			num = (nint)obj16;
			Action<object> action3 = default(Action<object>);
			action3..ctor(obj10, (IntPtr)obj16);
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v10+B8]");
			object obj18 = (nint)0 + (nint)8;
			obj18 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = 0;
			obj13 = action3;
			action2 = action3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3989138");
		object obj19 = this + 40;
		object obj20 = default(object);
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe void ShowActionsOptions(List<JackarooMove> moves, Action<JackarooActions> onSelectedAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0d84: Expected O, but got I4
		//IL_0d8e: Expected O, but got I4
		//IL_0d98: Expected O, but got I4
		//IL_0da6: Expected O, but got I4
		//IL_0c28: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00bb: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_0cdb: Expected O, but got I
		//IL_01bf: Expected O, but got I4
		//IL_01da: Expected I4, but got O
		//IL_0ae5: Expected O, but got I4
		//IL_0aef: Expected O, but got I4
		//IL_0a4b: Expected O, but got I4
		//IL_0240: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_0279: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_021d: Expected I, but got O
		//IL_02ba: Expected O, but got I4
		//IL_02c4: Expected O, but got I4
		//IL_02e6: Expected O, but got I4
		//IL_0309: Expected O, but got I
		//IL_032a: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_0356: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_03e6: Expected O, but got I4
		//IL_0408: Expected O, but got I4
		//IL_0431: Expected O, but got I
		//IL_0456: Expected O, but got I4
		//IL_0e07: Expected O, but got I4
		//IL_0e11: Expected O, but got I4
		//IL_0e33: Expected O, but got I4
		//IL_0e3b: Expected O, but got I4
		//IL_0e52: Expected O, but got I4
		//IL_047a: Expected O, but got I
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected I4, but got Unknown
		//IL_0e7c: Expected O, but got I
		//IL_0e8d: Expected I4, but got O
		//IL_0507: Expected O, but got I4
		//IL_0511: Expected O, but got I4
		//IL_0519: Expected O, but got Ref
		//IL_0532: Expected O, but got I4
		//IL_0540: Expected O, but got I4
		//IL_0565: Expected O, but got I4
		//IL_056d: Expected O, but got Ref
		//IL_0576: Expected O, but got I4
		//IL_057f: Expected O, but got I4
		//IL_0a03: Expected O, but got I
		//IL_0a1c: Expected O, but got Ref
		//IL_0a25: Expected O, but got I4
		//IL_0f29: Expected O, but got I
		//IL_0b7a: Expected O, but got Ref
		//IL_0b83: Expected O, but got I4
		//IL_0b9f: Expected O, but got I4
		//IL_09d7: Expected O, but got Ref
		//IL_09e0: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		List<System.Int32Enum>.Enumerator enumerator2 = (List<System.Int32Enum>.Enumerator)0;
		List<object>.Enumerator enumerator3 = (List<object>.Enumerator)0;
		JackarooOptionsPanel jackarooOptionsPanel = null;
		HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)152989696;
		Action<JackarooActions> action2 = default(Action<JackarooActions>);
		Action<JackarooActions> action = action2;
		bool flag3;
		object obj6;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		JackarooActions jackarooActions;
		Action<System.Int32Enum> action3 = default(Action<System.Int32Enum>);
		bool flag8;
		object obj13;
		Action<JackarooActions> action4 = default(Action<JackarooActions>);
		List<System.Int32Enum>.Enumerator enumerator8 = default(List<System.Int32Enum>.Enumerator);
		List<object>.Enumerator enumerator6;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = _jackarooUiOptions == null;
			enumerator = (List<object>.Enumerator)0;
			enumerator2 = (List<System.Int32Enum>.Enumerator)0;
			enumerator3 = (List<object>.Enumerator)0;
			jackarooOptionsPanel = this;
			horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)152989696;
			action = action2;
			if (!flag2)
			{
				action = (Action<JackarooActions>)((nint)0 + (nint)2632);
				flag3 = (byte)((nuint)0u + (nuint)1392u) != 0;
				object obj5 = (nint)0 + (nint)2360;
				obj6 = (nint)0 + (nint)2800;
				horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)((nint)0 + (nint)2624);
				List<object>.Enumerator enumerator4 = ((List<object>)(object)_jackarooUiOptions).GetEnumerator();
				while (true)
				{
					jackarooOptionsPanel = (JackarooOptionsPanel)(object)action;
					if (!enumerator3.MoveNext())
					{
						break;
					}
					if (_optionsPool != null)
					{
						action2 = (Action<JackarooActions>)((bool*)(flag3 ? 1 : 0))->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D498F4");
						continue;
					}
					goto IL_0ad2;
				}
				jackarooOptionsPanel = (JackarooOptionsPanel)(object)horizontalOrVerticalLayoutGroup;
				enumerator3.Dispose();
				List<JackarooActionOptionUi> jackarooUiOptions = _jackarooUiOptions;
				bool flag4 = _jackarooUiOptions == null;
				enumerator = (List<object>.Enumerator)0;
				enumerator2 = (List<System.Int32Enum>.Enumerator)0;
				enumerator3 = enumerator5;
				enumerator6 = enumerator5;
				jackarooActions = JackarooActions.NONE;
				action3 = (Action<System.Int32Enum>)flag3;
				if (!flag4)
				{
					object[] array = (object[])(jackarooUiOptions._version + 1);
					jackarooUiOptions._size = 0;
					jackarooUiOptions._version = (int)array;
					if (jackarooUiOptions._size >= 1)
					{
						Array.Clear(jackarooUiOptions._items, 0, jackarooUiOptions._size);
						nint num = unchecked((nint)null);
						jackarooOptionsPanel = null;
					}
					bool flag5 = moves == null;
					enumerator = (List<object>.Enumerator)0;
					enumerator2 = (List<System.Int32Enum>.Enumerator)0;
					action2 = (Action<JackarooActions>)jackarooUiOptions._size;
					enumerator3 = enumerator5;
					enumerator6 = enumerator5;
					jackarooActions = JackarooActions.NONE;
					action3 = (Action<System.Int32Enum>)flag3;
					if (!flag5)
					{
						action2 = (Action<JackarooActions>)obj5;
						object obj7 = ((List<object>)(object)moves).get_Item(0);
						bool flag6 = obj7 == null;
						enumerator = (List<object>.Enumerator)0;
						enumerator2 = (List<System.Int32Enum>.Enumerator)0;
						enumerator3 = enumerator5;
						enumerator6 = enumerator5;
						jackarooActions = JackarooActions.NONE;
						action3 = (Action<System.Int32Enum>)flag3;
						jackarooOptionsPanel = null;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v41 (System.Object)+10]");
							action = (Action<JackarooActions>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v41 (System.Object)+10]");
							bool flag7 = (nint)0 == 0;
							enumerator = (List<object>.Enumerator)0;
							enumerator2 = (List<System.Int32Enum>.Enumerator)0;
							enumerator3 = enumerator5;
							enumerator6 = enumerator5;
							jackarooActions = JackarooActions.NONE;
							action3 = (Action<System.Int32Enum>)flag3;
							jackarooOptionsPanel = null;
							if (!flag7)
							{
								horizontalOrVerticalLayoutGroup = _parent;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X22_v12 (System.Action`1<Jackaroo.JackarooActions>)+10]");
								flag8 = (nint)0 != 5;
								bool flag9;
								if (!flag8)
								{
									flag9 = true;
								}
								else
								{
									action2 = (Action<JackarooActions>)obj5;
									object obj8 = ((List<object>)(object)moves).get_Item(0);
									bool flag10 = obj8 == null;
									enumerator = (List<object>.Enumerator)0;
									enumerator2 = (List<System.Int32Enum>.Enumerator)0;
									enumerator3 = enumerator5;
									enumerator6 = enumerator5;
									jackarooActions = JackarooActions.NONE;
									action3 = (Action<System.Int32Enum>)flag3;
									jackarooOptionsPanel = null;
									if (flag10)
									{
										goto IL_0c09;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v88 (System.Object)+18]");
									object obj9 = -16;
									bool flag11 = obj9 == null;
									flag8 = !flag11;
									object obj10 = !flag8;
									bool flag12;
									if (obj10 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v88 (System.Object)+18]");
										object obj11 = -32;
										flag12 = obj11 == null;
									}
									else
									{
										flag12 = true;
									}
									array = (object[])32;
									flag9 = flag12;
								}
								bool flag13 = (object)horizontalOrVerticalLayoutGroup == null;
								enumerator = (List<object>.Enumerator)0;
								enumerator2 = (List<System.Int32Enum>.Enumerator)0;
								enumerator3 = enumerator5;
								enumerator6 = enumerator5;
								jackarooActions = JackarooActions.NONE;
								action3 = (Action<System.Int32Enum>)flag3;
								jackarooOptionsPanel = (JackarooOptionsPanel)flag9;
								if (!flag13)
								{
									horizontalOrVerticalLayoutGroup.reverseArrangement = flag9;
									flag3 = (byte)(typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304) != 0;
									bool value = ((bool*)(flag3 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v22 (System.Boolean)+B8]");
									object obj12 = 0;
									JackarooActions jackarooActions2 = ((!JackarooCardsMapper.IsCustomRule((Card)(object)action, (JackarooAllowedRules)obj12, out jackarooActions)) ? JackarooCardsMapper.GetDefaultJackarooActions((Card)(object)action) : jackarooActions);
									List<JackarooActions> list = JackarooActionsExtensions.ToList(jackarooActions2);
									bool flag14 = list == null;
									enumerator = (List<object>.Enumerator)0;
									enumerator2 = (List<System.Int32Enum>.Enumerator)0;
									action2 = (Action<JackarooActions>)(&jackarooActions);
									enumerator3 = enumerator5;
									enumerator6 = enumerator5;
									action3 = (Action<System.Int32Enum>)flag3;
									jackarooOptionsPanel = null;
									horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)146685952;
									if (!flag14)
									{
										List<System.Int32Enum>.Enumerator enumerator7 = ((List<System.Int32Enum>)(object)list).GetEnumerator();
										enumerator = (List<object>.Enumerator)0;
										action2 = (Action<JackarooActions>)(&jackarooActions);
										enumerator6 = (List<object>.Enumerator)jackarooActions;
										obj13 = 146685952;
										while (enumerator2.MoveNext())
										{
											if ((nint)action4 == 131072)
											{
												continue;
											}
											goto IL_05a1;
										}
										object obj14 = (nint)0 + (nint)2648;
										jackarooOptionsPanel = (JackarooOptionsPanel)obj14;
										enumerator2.Dispose();
										enumerator8 = (List<System.Int32Enum>.Enumerator)(&enumerator2);
										object obj15 = 0;
										horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)obj13;
										goto IL_0a32;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0c09;
		IL_05a1:
		List<object>.Enumerator enumerator9 = ((List<object>)(object)moves).GetEnumerator();
		NullReferenceException ex;
		List<object>.Enumerator enumerator10 = default(List<object>.Enumerator);
		while (true)
		{
			jackarooOptionsPanel = (JackarooOptionsPanel)obj6;
			bool flag15 = enumerator.MoveNext();
			bool flag16 = !flag15;
			bool flag17 = flag8;
			object obj15;
			if (!flag16)
			{
				if (action4 == null)
				{
					ex = new NullReferenceException();
					enumerator = enumerator10;
					enumerator8 = (List<System.Int32Enum>.Enumerator)(&enumerator2);
					obj15 = 0;
					enumerator6 = enumerator10;
					jackarooActions = JackarooActions.NONE;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ stack_-C8 (System.Action`1<Jackaroo.JackarooActions>)+18]");
				flag17 = action4 != null;
				flag8 = flag17;
				if (flag17)
				{
					continue;
				}
			}
			object obj16 = (nint)0 + (nint)2792;
			jackarooOptionsPanel = (JackarooOptionsPanel)obj16;
			enumerator.Dispose();
			OutOfMemoryException ex2 = new OutOfMemoryException();
			enumerator = enumerator10;
			enumerator8 = (List<System.Int32Enum>.Enumerator)(&enumerator2);
			obj15 = 0;
			enumerator6 = enumerator10;
			jackarooActions = JackarooActions.NONE;
			object obj5 = 13;
			flag3 = flag15;
			ex = (NullReferenceException)(object)ex2;
			obj13 = null;
			break;
		}
		goto IL_0f0e;
		IL_0a32:
		bool flag18 = _animation == null;
		action3 = (Action<System.Int32Enum>)flag3;
		if (!flag18)
		{
			_animation.DOPlayForward();
			return;
		}
		goto IL_0c09;
		IL_0f0e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
		bool flag19 = (nint)jackarooOptionsPanel != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex;
		if (!flag19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj17 = (nint)0 + (nint)2648;
			jackarooOptionsPanel = (JackarooOptionsPanel)obj17;
			((List<System.Int32Enum>.Enumerator*)enumerator8)->Dispose();
			object obj18 = default(object);
			bool flag20 = obj18 == null;
			object obj15 = obj18;
			horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)obj13;
			if (flag20)
			{
				goto IL_0a32;
			}
			ex3 = new OutOfMemoryException();
			obj15 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0ad2:
		ex = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		enumerator2 = (List<System.Int32Enum>.Enumerator)0;
		enumerator6 = enumerator5;
		jackarooActions = JackarooActions.NONE;
		obj13 = horizontalOrVerticalLayoutGroup;
		goto IL_0f0e;
		IL_0c09:
		NullReferenceException ex4 = new NullReferenceException();
		ex = new NullReferenceException();
		flag3 = (byte)(int)action3 != 0;
		obj13 = horizontalOrVerticalLayoutGroup;
		goto IL_0f0e;
	}

	private void Dismiss()
	{
		//IL_000d: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0061: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_01ce: Expected I, but got O
		//IL_025a: Expected I, but got O
		//IL_00b7: Expected I, but got O
		//IL_00ca: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		DOTweenAnimation animation = _animation;
		nint num2 = default(nint);
		object obj3 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		object obj4;
		if (_animation != null)
		{
			nint num = (nint)animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
			num2 = 0;
			_animation.DOPlayBackwards();
			if (_jackarooUiOptions != null)
			{
				object obj = (nint)0 + (nint)2632;
				object obj2 = (nint)0 + (nint)1392;
				obj3 = (nint)0 + (nint)2624;
				List<object>.Enumerator enumerator = ((List<object>)(object)_jackarooUiOptions).GetEnumerator();
				while (true)
				{
					num2 = (nint)obj;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					if (_optionsPool != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D498F4");
						continue;
					}
					goto IL_016b;
				}
				num2 = (nint)obj3;
				enumerator2.Dispose();
				obj4 = 0;
				goto IL_00d0;
			}
		}
		goto IL_0244;
		IL_0244:
		NullReferenceException ex = new NullReferenceException();
		bool flag = num2 != 1;
		NullReferenceException ex2 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num2 = (nint)obj3;
			enumerator2.Dispose();
			object obj5 = default(object);
			bool flag2 = obj5 == null;
			obj4 = obj5;
			if (flag2)
			{
				goto IL_00d0;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj4 = obj5;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00d0:
		List<JackarooActionOptionUi> jackarooUiOptions = _jackarooUiOptions;
		if (_jackarooUiOptions != null)
		{
			int version = jackarooUiOptions._version + 1;
			jackarooUiOptions._size = 0;
			jackarooUiOptions._version = version;
			if (jackarooUiOptions._size >= 1)
			{
				Array.Clear(jackarooUiOptions._items, 0, jackarooUiOptions._size);
			}
			return;
		}
		goto IL_0244;
		IL_016b:
		NullReferenceException ex4 = new NullReferenceException();
		obj4 = 0;
		goto IL_0244;
	}

	public void Hide()
	{
		Dismiss();
	}

	public JackarooOptionsPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private JackarooActionOptionUi <Awake>b__2_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_005e: Expected O, but got I4
		if ((object)_parent != null)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = (nint)0 + (nint)560;
			Transform transform = _parent.transform;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			JackarooActionOptionUi result = default(JackarooActionOptionUi);
			return result;
		}
		return (JackarooActionOptionUi)(object)new NullReferenceException();
	}

	private void <Awake>b__2_1(JackarooActionOptionUi optionUi)
	{
		Transform transform = optionUi.transform;
		Transform parent = _parent.transform;
		transform.SetParent(parent);
		GameObject gameObject = optionUi.gameObject;
		gameObject.SetActive(value: true);
	}
}
