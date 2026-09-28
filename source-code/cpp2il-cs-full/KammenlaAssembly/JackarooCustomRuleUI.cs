using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using Jackaroo;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class JackarooCustomRuleUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<(string, int), string> <>9__23_0;

		public static Func<(string, int), string> <>9__23_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <Initialize>b__23_0((string, int) t)
		{
			return (string)t;
		}

		internal string <Initialize>b__23_2((string, int) t)
		{
			return (string)t;
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public List<JackarooCustomRuleUI> jackarooCustomRulesUis;

		public JackarooCustomRuleUI <>4__this;

		internal void <Initialize>g__OnShow|1()
		{
			//IL_0465: Expected O, but got I4
			//IL_0012: Expected O, but got I
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0032: Expected O, but got I
			//IL_047b: Expected I, but got O
			//IL_0406: Expected I, but got O
			//IL_03b8: Expected O, but got I4
			//IL_0083: Expected O, but got I
			//IL_0214: Expected O, but got I4
			//IL_024b: Expected O, but got I
			//IL_0269: Expected O, but got I4
			//IL_0272: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			//IL_0120: Expected O, but got I
			//IL_013e: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_0290: Expected O, but got I
			//IL_036a: Expected O, but got I4
			//IL_0165: Expected O, but got I
			//IL_02cb: Expected O, but got I
			//IL_02e3: Expected O, but got I4
			//IL_0391: Expected O, but got I4
			//IL_01a0: Expected O, but got I
			//IL_01b8: Expected O, but got I4
			//IL_0303: Expected O, but got I
			//IL_031a: Expected O, but got I
			bool flag = jackarooCustomRulesUis == null;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
			object obj3 = default(object);
			nint num = default(nint);
			if (!flag)
			{
				object obj = (nint)0 + (nint)2728;
				object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				obj3 = (nint)0 + (nint)2720;
				List<object>.Enumerator enumerator2 = ((List<object>)(object)jackarooCustomRulesUis).GetEnumerator();
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				object obj4 = default(object);
				while (true)
				{
					num = (nint)obj;
					if (enumerator3.MoveNext())
					{
						if (obj4 == null)
						{
							NullReferenceException ex = new NullReferenceException();
							break;
						}
						JackarooCustomRuleUI jackarooCustomRuleUI = <>4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+2C]");
						object obj5 = (nint)0 & (nint)1;
						if (obj5 != null)
						{
							if ((object)<>4__this == null)
							{
								NullReferenceException ex2 = new NullReferenceException();
								break;
							}
							object obj6 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v35+E4]");
							bool flag2 = (nint)0 == 0;
							object obj7 = !flag2;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							TwinSlidedKDropMenu twinDropMenu = jackarooCustomRuleUI._twinDropMenu;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+58]");
							bool flag3 = twinDropMenu == (UnityEngine.Object)0;
							bool flag4 = !flag3;
							object obj8 = !flag4;
							object obj9 = 0;
							if (obj8 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+58]");
							BaseDropMenu<object> baseDropMenu = (BaseDropMenu<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+58]");
							if ((nint)0 == 0)
							{
								NullReferenceException ex3 = new NullReferenceException();
								obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+58]");
								num = 0;
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v39 (BaseDropMenu`1<System.Object>)+30]");
							object obj10 = (nint)0 & (nint)1;
							bool flag5 = obj10 == null;
							obj9 = 0;
							if (flag5)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+58]");
							((BaseDropMenu<object>)0).Toggle();
						}
						else
						{
							if ((object)<>4__this == null)
							{
								NullReferenceException ex4 = new NullReferenceException();
								break;
							}
							object obj11 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v27+E4]");
							bool flag6 = (nint)0 == 0;
							object obj12 = !flag6;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							SlidedKDropMenu dropMenu = jackarooCustomRuleUI._dropMenu;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+50]");
							bool flag7 = dropMenu == (UnityEngine.Object)0;
							bool flag8 = !flag7;
							object obj13 = !flag8;
							object obj9 = 0;
							if (obj13 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+50]");
							BaseDropMenu<object> baseDropMenu2 = (BaseDropMenu<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+50]");
							if ((nint)0 == 0)
							{
								NullReferenceException ex5 = new NullReferenceException();
								obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+50]");
								num = 0;
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v31 (BaseDropMenu`1<System.Object>)+30]");
							object obj14 = (nint)0 & (nint)1;
							bool flag9 = obj14 == null;
							obj9 = 0;
							if (flag9)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ stack_-78+50]");
							((BaseDropMenu<object>)0).Toggle();
						}
					}
					enumerator3.Dispose();
					return;
				}
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				enumerator = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
			}
			NullReferenceException ex6 = new NullReferenceException();
			bool flag10 = num != 1;
			NullReferenceException ex7 = ex6;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				num = (nint)obj3;
				enumerator.Dispose();
				object obj15 = default(object);
				if (obj15 == null)
				{
					return;
				}
				OutOfMemoryException ex8 = new OutOfMemoryException();
				List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj15;
				ex7 = (NullReferenceException)(object)ex8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A1C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	private CardsSprites _jackarooRulesSprites;

	private RuleType _ruleType;

	private bool _isTwinRule;

	private CardData _cardData1;

	private Image _cardImage1;

	private CardData _cardData2;

	private Image _cardImage2;

	private SlidedKDropMenu _dropMenu;

	private TwinSlidedKDropMenu _twinDropMenu;

	private List<(string, int)> <ValueTuples1>k__BackingField;

	private List<(string, int)> <ValueTuples2>k__BackingField;

	public bool IsTwinRule => _isTwinRule;

	public SlidedKDropMenu DropMenu => _dropMenu;

	public TwinSlidedKDropMenu TwinDropMenu => _twinDropMenu;

	public List<(string, int)> ValueTuples1
	{
		get
		{
			return <ValueTuples1>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<(string, int)> ValueTuples2
	{
		get
		{
			return <ValueTuples2>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public unsafe void Initialize(List<JackarooCustomRuleUI> jackarooCustomRulesUis)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0117: Expected O, but got Ref
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_057c: Expected O, but got I
		//IL_0588: Expected O, but got I
		//IL_0598: Expected O, but got I
		//IL_05a8: Expected O, but got I
		//IL_05ca: Expected O, but got I4
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03cb: Expected O, but got I
		//IL_03dc: Expected I, but got O
		//IL_0233: Expected O, but got I4
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_0602: Expected O, but got I
		//IL_0613: Expected I, but got O
		//IL_0631: Expected O, but got I
		//IL_0271: Expected O, but got I4
		//IL_0263: Expected O, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0432: Expected O, but got I
		//IL_0442: Expected O, but got I
		//IL_0464: Expected O, but got I4
		//IL_0474: Expected O, but got I
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_034c: Expected O, but got I
		//IL_035c: Expected O, but got I
		//IL_037e: Expected O, but got I4
		//IL_04fb: Expected O, but got I
		//IL_050c: Expected I, but got O
		//IL_04a4: Expected O, but got I4
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_06b4: Expected O, but got I
		//IL_06c5: Expected I, but got O
		//IL_06e3: Expected O, but got I
		//IL_039c: Expected O, but got I
		//IL_04e2: Expected O, but got I4
		//IL_04d4: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = jackarooCustomRulesUis;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Image cardImage;
		Sprite sprite2;
		if (_ruleType != RuleType.Last7SharedRule)
		{
			bool flag = _ruleType == RuleType.CardRule;
			object obj5 = !flag;
			if (obj5 != null)
			{
				object obj6 = default(object);
				string cardName = ((Enum)(&obj6)).ToString();
				Sprite sprite = _jackarooRulesSprites.GetFor(cardName);
				cardImage = _cardImage1;
				sprite2 = sprite;
				goto IL_014a;
			}
		}
		Card card = CardDataExtension.ToCard(_cardData1);
		Sprite sprite3 = _jackarooRulesSprites.GetFor(card);
		cardImage = _cardImage1;
		bool flag2 = (object)_cardImage1 == null;
		object obj7 = !flag2;
		sprite2 = sprite3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_014a;
		IL_0482:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v50+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj10;
		object obj11;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v31+B8]");
			obj11 = 0;
		}
		object obj12 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1808;
		Func<(object, int), object> func = default(Func<(object, int), object>);
		func..ctor(obj11, (IntPtr)obj13);
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v30+B8]");
		object obj15 = (nint)0 + (nint)16;
		obj15 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = 0;
		Func<(object, int), object> selector = func;
		goto IL_0648;
		IL_0648:
		object source2;
		IEnumerable<object> source = Enumerable.Select((IEnumerable<(object, int)>)source2, selector);
		List<object> newItems = Enumerable.ToList(source);
		object obj17 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1816;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj18);
		List<object> list;
		_twinDropMenu.SetupItems2((List<string>)(object)list, (List<string>)(object)newItems, action);
		TwinSlidedKDropMenu twinDropMenu = _twinDropMenu;
		_ = 0;
		twinDropMenu.<SelectedIndex2>k__BackingField = 0;
		return;
		IL_014a:
		obj10 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 512;
		cardImage.sprite = sprite2;
		Card card2 = CardDataExtension.ToCard(_cardData1);
		IEnumerable<(string, int)> jackarooAllowedRulesString = JackarooAllowedRulesExtensions.GetJackarooAllowedRulesString(_ruleType, card2);
		List<(object, int)> list2 = Enumerable.ToList((IEnumerable<(object, int)>)jackarooAllowedRulesString);
		object obj19 = this + 96;
		obj19 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj20 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj10;
		}
		object obj22 = (nint)0 + (nint)2872;
		object obj23 = (nint)0 + (nint)2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v21+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v35+8]");
		Func<(object, int), object> selector2 = (Func<(object, int), object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v35+8]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v21+E4]");
			bool flag6 = (nint)0 == 0;
			object obj26 = !flag6;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v41+B8]");
				obj24 = 0;
			}
			object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj29 = (nint)0 + (nint)1800;
			Func<(object, int), object> func2 = default(Func<(object, int), object>);
			func2..ctor(obj24, (IntPtr)obj29);
			object obj30 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v40+B8]");
			object obj31 = (nint)0 + (nint)8;
			obj31 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj16 = 0;
			selector2 = func2;
		}
		IEnumerable<object> source3 = Enumerable.Select((IEnumerable<(object, int)>)obj19, selector2);
		list = Enumerable.ToList(source3);
		if (_isTwinRule)
		{
			Card card3 = CardDataExtension.ToCard(_cardData2);
			Sprite sprite4 = _jackarooRulesSprites.GetFor(card3);
			_cardImage2.sprite = sprite4;
			Card card4 = CardDataExtension.ToCard(_cardData2);
			IEnumerable<(string, int)> jackarooAllowedRulesString2 = JackarooAllowedRulesExtensions.GetJackarooAllowedRulesString(_ruleType, card4);
			List<(object, int)> list3 = Enumerable.ToList((IEnumerable<(object, int)>)jackarooAllowedRulesString2);
			source2 = this + 104;
			source2 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj32 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v50+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v50+B8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v25+10]");
				selector = (Func<(object, int), object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v25+10]");
				bool flag7 = (nint)0 == 0;
				object obj33 = !flag7;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v25+10]");
					Func<(object, int), object> func3 = (Func<(object, int), object>)0;
					goto IL_0482;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj32 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v50+B8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v25+10]");
				Func<(object, int), object> func3 = (Func<(object, int), object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v25+10]");
				bool flag8 = (nint)0 == 0;
				object obj34 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v25+10]");
				selector = (Func<(object, int), object>)0;
				if (obj34 == null)
				{
					goto IL_0482;
				}
			}
			goto IL_0648;
		}
		object obj35 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj36 = (nint)0 + (nint)1816;
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj36);
		((BaseDropMenu<object>)(object)_dropMenu).SetupItems(list, action2, (Action)null);
		SlidedKDropMenu dropMenu = _dropMenu;
		_ = 0;
	}

	public void Reset()
	{
		//IL_005f: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_007f: Expected O, but got I
		if (_isTwinRule)
		{
			_twinDropMenu.SetSelectedIndex(0);
			_twinDropMenu.SetSelectedIndex2(0);
			return;
		}
		SlidedKDropMenu dropMenu = _dropMenu;
		nint num = (nint)dropMenu;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<SlidedKDropMenu>)+1E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<SlidedKDropMenu>)+1F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
