using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Managers.Achievemenets;
using UnityEngine;
using UnityEngine.UI;

public class AchievementIconDisplayHandler : MonoBehaviour
{
	private AchievementDisplayPlace _place;

	private Image _targetIcon;

	private GameObject _targetContainer;

	private int _lastTotalLevels;

	private int _lastActiveLevel;

	private RectTransform _containerRect;

	private AchievementType _type;

	public AchievementDisplayPlace Place => _place;

	private void Awake()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460278");
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c9: Expected I, but got O
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2344;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+B8]");
		object obj5 = 0;
		Delegate obj6 = (Delegate)obj5;
		bool flag;
		Delegate obj9 = default(Delegate);
		do
		{
			Delegate obj7 = Delegate.Combine(obj6, action);
			if ((object)obj7 == null || obj7 == obj)
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag = (object)obj9 == obj6;
				obj6 = obj9;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag);
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c9: Expected I, but got O
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2344;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+B8]");
		object obj5 = 0;
		Delegate obj6 = (Delegate)obj5;
		bool flag;
		Delegate obj9 = default(Delegate);
		do
		{
			Delegate obj7 = Delegate.Remove(obj6, action);
			if ((object)obj7 == null || obj7 == obj)
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag = (object)obj9 == obj6;
				obj6 = obj9;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag);
	}

	public unsafe void ApplyTierDisplay(RectTransform iconRect, int totalLevels, int activeLevel, AchievementType type)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0010: Expected O, but got Ref
		//IL_0020: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		//IL_045f: Expected O, but got I
		//IL_0480: Expected I4, but got O
		//IL_02e3: Expected O, but got I
		//IL_0305: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_034b: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_0365: Expected O, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03f1: Expected O, but got I4
		//IL_040f: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj4 = default(object);
		object obj3 = (object)(&obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj5 = 0;
		object obj6 = (nint)0 + (nint)1648;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+E4]");
		UnityEngine.Object obj9 = default(UnityEngine.Object);
		int num2;
		UnityEngine.Object obj11;
		bool flag;
		if ((nint)0 != 0)
		{
			flag = obj9 == null;
			bool flag2 = !flag;
			int num = 0;
			UnityEngine.Object obj10 = null;
			if (flag2)
			{
				goto IL_00f7;
			}
			num2 = 0;
			obj11 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag = obj9 == null;
			bool flag3 = !flag;
			object obj12 = !flag3;
			int num = 0;
			UnityEngine.Object obj10 = null;
			num2 = 0;
			obj11 = null;
			if (obj12 == null)
			{
				goto IL_00f7;
			}
		}
		goto IL_02a5;
		IL_0359:
		object obj13 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj15 = default(object);
		object obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0386;
		IL_02a5:
		bool flag4 = type == AchievementType.Achievement;
		object obj16 = 0;
		AchievementIconDisplayHandler achievementIconDisplayHandler = (AchievementIconDisplayHandler)flag;
		if (flag4)
		{
			goto IL_044f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		bool flag5 = obj17 != null;
		obj16 = 0;
		if (!flag5)
		{
			Reset();
			return;
		}
		goto IL_048f;
		IL_00f7:
		object obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v12+E4]");
		bool flag6;
		int num3;
		UnityEngine.Object obj19;
		if ((nint)0 != 0)
		{
			flag6 = iconRect == null;
			bool flag7 = type == AchievementType.Achievement;
			num3 = 0;
			obj19 = null;
			if (flag7)
			{
				goto IL_01e1;
			}
			num2 = 0;
			obj11 = null;
			flag = flag6;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag6 = iconRect == null;
			bool flag8 = type == AchievementType.Achievement;
			object obj20 = !flag8;
			num3 = 0;
			obj19 = null;
			num2 = 0;
			obj11 = null;
			flag = flag6;
			if (obj20 == null)
			{
				goto IL_01e1;
			}
		}
		goto IL_02a5;
		IL_048f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		throw new NullReferenceException();
		IL_0386:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		AchievementTierDisplayConfig achievementTierDisplayConfig = default(AchievementTierDisplayConfig);
		int activeLevel2 = default(int);
		ResolvedDisplay? resolvedDisplay = achievementTierDisplayConfig.Resolve(_place, totalLevels, activeLevel2);
		object obj22 = default(object);
		object obj21 = obj22 & 1;
		bool flag9 = obj21 == null;
		object obj24 = default(object);
		object obj23 = obj24;
		object obj25 = default(object);
		obj16 = obj25;
		obj11 = (UnityEngine.Object)_place;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X25_v1+27]");
			obj16 = 0;
			ResolvedDisplay resolvedDisplay2 = default(ResolvedDisplay);
			resolvedDisplay2.ApplyTo(iconRect);
			object obj26 = default(object);
			obj23 = obj26;
			obj11 = iconRect;
		}
		ApplyContainerPosition();
		Refresh();
		num2 = totalLevels;
		achievementIconDisplayHandler = this;
		goto IL_044f;
		IL_01e1:
		bool flag10 = !flag6;
		object obj27 = !flag10;
		num2 = num3;
		obj11 = obj19;
		flag = flag6;
		if (obj27 != null)
		{
			goto IL_02a5;
		}
		obj14 = this + 40;
		_ = 0;
		object obj28 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = (UnityEngine.Object)obj14 == null;
			bool flag12 = !flag11;
			object obj29 = !flag12;
			object obj30 = 0;
			if (obj29 != null)
			{
				goto IL_0359;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = (UnityEngine.Object)obj14 == null;
			bool flag14 = !flag13;
			object obj30 = 0;
			if (!flag14)
			{
				goto IL_0359;
			}
		}
		goto IL_0386;
		IL_044f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		bool flag15 = obj31 != null;
		flag = (byte)(int)achievementIconDisplayHandler != 0;
		if (!flag15)
		{
			return;
		}
		goto IL_048f;
	}

	private void Refresh()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0206: Expected O, but got I
		//IL_02ad: Expected O, but got I4
		object obj = (nint)0 + (nint)1648;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
		UnityEngine.Object obj4 = default(UnityEngine.Object);
		if ((nint)0 != 0)
		{
			bool flag = obj4 == null;
			bool flag2 = !flag;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj4 == null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (obj7 != null)
			{
				return;
			}
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = _targetIcon == null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			if (obj9 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = _targetIcon == null;
			bool flag8 = !flag7;
			object obj10 = !flag8;
			if (obj10 != null)
			{
				return;
			}
		}
		if (_lastTotalLevels < 1 || _lastActiveLevel < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		AchievementTierDisplayConfig achievementTierDisplayConfig = default(AchievementTierDisplayConfig);
		ResolvedDisplay? resolvedDisplay = achievementTierDisplayConfig.Resolve(_place, _lastTotalLevels, _lastActiveLevel);
		ResolvedDisplay? resolvedDisplay2 = default(ResolvedDisplay?);
		object obj11 = (??)resolvedDisplay2 & 1;
		if (obj11 == null)
		{
			return;
		}
		object obj12 = (nint)0 + (nint)4048;
		ResolvedDisplay value = resolvedDisplay2.Value;
		RectTransform rectTransform = _targetIcon.rectTransform;
		ResolvedDisplay resolvedDisplay3 = default(ResolvedDisplay);
		resolvedDisplay3.ApplyTo(rectTransform);
		ApplyContainerPosition();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v19+18]");
		if ((nint)0 == 1)
		{
			ResolvedDisplay value2 = resolvedDisplay2.Value;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v22+E4]");
			bool flag9 = (nint)0 == 0;
			object obj14 = !flag9;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sprite sprite = default(Sprite);
			if (sprite != null)
			{
				ResolvedDisplay value3 = resolvedDisplay2.Value;
				_targetIcon.sprite = sprite;
			}
		}
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		object obj = (nint)0 + (nint)1648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		AchievementTierDisplayConfig achievementTierDisplayConfig = default(AchievementTierDisplayConfig);
		ResolvedDisplay? defaults = achievementTierDisplayConfig.GetDefaults(_place);
		ResolvedDisplay? resolvedDisplay = default(ResolvedDisplay?);
		object obj2 = (??)resolvedDisplay & 1;
		if (obj2 == null)
		{
			return;
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+E4]");
		RectTransform rectTransform;
		if ((nint)0 != 0)
		{
			bool flag = _targetIcon;
			bool flag2 = !flag;
			object obj5 = !flag2;
			rectTransform = null;
			if (obj5 == null)
			{
				goto IL_00c8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _targetIcon;
			bool flag4 = !flag3;
			rectTransform = null;
			if (flag4)
			{
				goto IL_00c8;
			}
		}
		ResolvedDisplay value = resolvedDisplay.Value;
		RectTransform rectTransform2 = _targetIcon.rectTransform;
		ResolvedDisplay resolvedDisplay2 = default(ResolvedDisplay);
		resolvedDisplay2.ApplyTo(rectTransform2);
		UnityEngine.Object containerRect = _containerRect;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		rectTransform = rectTransform2;
		UnityEngine.Object containerRect2 = _containerRect;
		if (obj7 != null)
		{
			goto IL_0109;
		}
		goto IL_01ff;
		IL_00c8:
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		containerRect = _containerRect;
		containerRect2 = _containerRect;
		if (!flag6)
		{
			goto IL_0109;
		}
		goto IL_01ff;
		IL_0285:
		if (_place == AchievementDisplayPlace.INFOPOPUP || _place == AchievementDisplayPlace.CLAIMPOPUP)
		{
		}
		_containerRect.anchoredPosition = (Vector2)0;
		return;
		IL_0109:
		bool flag7 = containerRect;
		bool flag8 = !flag7;
		object obj8 = !flag8;
		if (obj8 == null)
		{
			return;
		}
		goto IL_0285;
		IL_01ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!containerRect2)
		{
			return;
		}
		goto IL_0285;
	}

	private void ApplyContainerPosition()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017c: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0226: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_02a5: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B1D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object containerRect;
		UnityEngine.Object containerRect2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			containerRect = _containerRect;
			containerRect2 = _containerRect;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			containerRect = _containerRect;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			containerRect2 = _containerRect;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = containerRect2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj9 = (nint)0 + (nint)1648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v3+E4]");
		UnityEngine.Object obj11 = default(UnityEngine.Object);
		if ((nint)0 != 0)
		{
			bool flag5 = obj11 == null;
			bool flag6 = !flag5;
			object obj12 = !flag6;
			if (obj12 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = obj11 == null;
			bool flag8 = !flag7;
			object obj13 = !flag8;
			if (obj13 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D16598");
		AchievementTierDisplayConfig achievementTierDisplayConfig = default(AchievementTierDisplayConfig);
		Vector2? containerPosition = achievementTierDisplayConfig.GetContainerPosition(_place);
		object obj14 = (??)containerPosition & 1;
		if (obj14 != null)
		{
			Vector2? vector = default(Vector2?);
			Vector2 value = vector.Value;
			_containerRect.anchoredPosition = (Vector2)0;
		}
		return;
		IL_0091:
		bool flag9 = containerRect == null;
		bool flag10 = !flag9;
		obj7 = 0;
		obj8 = null;
		if (!flag10)
		{
			return;
		}
		goto IL_0170;
	}
}
