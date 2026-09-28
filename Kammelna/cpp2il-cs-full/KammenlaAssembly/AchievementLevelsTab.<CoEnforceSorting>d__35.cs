using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Xml.Schema;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AchievementLevelsTab : MonoBehaviour
{
	private sealed class <CoEnforceSorting>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public AchievementLevelsTab <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <CoEnforceSorting>d__35(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I4
			//IL_005a: Expected I4, but got I8
			//IL_00f3: Expected I4, but got O
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					AchievementLevelsTab achievementLevelsTab = <>4__this;
					<>1__state = -1;
					Canvas.ForceUpdateCanvases();
					if ((object)<>4__this == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					<>4__this.ApplySorting(isSelected: true);
					achievementLevelsTab._pendingSortingEnforce = false;
				}
				return <>1__state == 0;
			}
			object obj = this + 24;
			obj = 0;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private Image background;

	private Image selectedBackground;

	private GameObject normalVisuals;

	private GameObject selectedVisuals;

	private TextMeshProUGUI levelText;

	private Toggle toggle;

	private Canvas tabCanvas;

	private Graphic clickHitbox;

	private Sprite edgeLocked;

	private Sprite edgeDone;

	private Sprite edgeActive;

	private Sprite midLocked;

	private Sprite midDone;

	private Sprite midActive;

	private Sprite selectedLocked;

	private Sprite selectedDone;

	private Sprite selectedActive;

	private int selectedOrderBoost = 50;

	private static Color GreenTextColor;

	private static Color WhiteTextColor;

	private int _baseSortingOrder;

	private bool _pendingSortingEnforce;

	private int _levelNumber;

	private int _totalLevels;

	private int _unlockedLevel;

	private bool _isCurrent;

	private UnityAction<int> _onSelected;

	public void SetUnlockedLevel(int unlockedLevel)
	{
		int num = ~unlockedLevel;
		int unlockedLevel2 = unlockedLevel & num;
		_unlockedLevel = unlockedLevel2;
		ApplyVisual();
	}

	public void Configure(int levelNumber, int totalLevels, bool isCurrent, UnityAction<int> onSelected = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0044: Expected O, but got I4
		//IL_0145: Expected I, but got O
		//IL_0196: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_0517: Expected O, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0276: Expected O, but got I
		//IL_0284: Expected I, but got O
		//IL_0394: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_0302: Expected O, but got I4
		//IL_034c: Expected O, but got I4
		//IL_05a0: Expected I, but got O
		//IL_05f2: Expected O, but got I4
		//IL_060b: Expected O, but got I4
		//IL_048b: Expected O, but got I4
		//IL_0403: Expected O, but got I4
		//IL_0689: Expected I, but got O
		//IL_06db: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 200;
		obj2 = onSelected;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v3-88]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			object obj4 = !flag2;
			text = null;
			if (obj4 == null)
			{
				goto IL_0057;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v3-88]");
			bool flag3 = (UnityEngine.Object)0;
			bool flag4 = !flag3;
			text = null;
			if (flag4)
			{
				goto IL_0057;
			}
		}
		TextMeshProUGUI textMeshProUGUI = levelText;
		int num = default(int);
		string text2 = num.ToString();
		nint num2 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v32 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		int num3 = 0;
		textMeshProUGUI.text = text2;
		UnityEngine.Object obj5 = this.toggle;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v64+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v32 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		int num4 = 0;
		text = text2;
		UnityEngine.Object obj8 = this.toggle;
		if (obj7 != null)
		{
			goto IL_00a0;
		}
		goto IL_01c6;
		IL_0623:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		bool flag8 = false;
		int num5;
		num3 = num5;
		bool flag9 = false;
		if (flag7)
		{
			goto IL_04ab;
		}
		goto IL_0672;
		IL_0468:
		UnityEngine.Object obj10;
		bool flag10 = obj10;
		bool flag11 = !flag10;
		object obj11 = !flag11;
		flag8 = false;
		flag9 = false;
		if (obj11 == null)
		{
			goto IL_04ab;
		}
		goto IL_0672;
		IL_0598:
		Graphic graphic;
		nint num6 = (nint)graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v26 (Il2CppClass<UnityEngine.UI.Graphic>)+2D0]");
		num3 = 0;
		graphic.raycastTarget = true;
		obj10 = selectedBackground;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v24+E4]");
		bool flag12 = (nint)0 == 0;
		object obj13 = !flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v26 (Il2CppClass<UnityEngine.UI.Graphic>)+2D0]");
		num5 = 0;
		UnityEngine.Object obj14 = (UnityEngine.Object)1;
		obj9 = selectedBackground;
		if (obj13 != null)
		{
			goto IL_0468;
		}
		goto IL_0623;
		IL_0057:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v64+E4]");
		bool flag13 = (nint)0 == 0;
		obj5 = this.toggle;
		num4 = num3;
		obj8 = this.toggle;
		if (!flag13)
		{
			goto IL_00a0;
		}
		goto IL_01c6;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = obj8;
		bool flag15 = !flag14;
		num3 = num4;
		flag9 = false;
		if (!flag15)
		{
			goto IL_020c;
		}
		goto IL_04ab;
		IL_00a0:
		bool flag16 = obj5;
		bool flag17 = !flag16;
		object obj15 = !flag17;
		if (obj15 != null)
		{
			goto IL_020c;
		}
		flag9 = false;
		goto IL_04ab;
		IL_020c:
		Toggle toggle = this.toggle;
		toggle.onValueChanged.RemoveAllListeners();
		this.toggle.isOn = flag8;
		Toggle toggle2 = this.toggle;
		object obj16 = typeof(TypeConverter<ushort, char>) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1680;
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj17);
		toggle2.onValueChanged.AddListener(unityAction);
		this.toggle.transition = Selectable.Transition.None;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v20+E4]");
		if ((nint)0 != 0)
		{
			bool flag18 = clickHitbox != null;
			bool flag19 = !flag18;
			object obj19 = 0;
			UnityEngine.Object obj20 = null;
			if (!flag19)
			{
				goto IL_0315;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag20 = clickHitbox != null;
			bool flag21 = !flag20;
			object obj21 = !flag21;
			object obj19 = 0;
			UnityEngine.Object obj20 = null;
			if (obj21 != null)
			{
				goto IL_0315;
			}
		}
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v29+E4]");
		if ((nint)0 != 0)
		{
			bool flag22 = background != null;
			bool flag23 = !flag22;
			object obj23 = !flag23;
			num3 = 0;
			obj14 = null;
			if (obj23 == null)
			{
				goto IL_041f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag24 = background != null;
			bool flag25 = !flag24;
			num3 = 0;
			obj14 = null;
			if (flag25)
			{
				goto IL_041f;
			}
		}
		this.toggle.targetGraphic = background;
		graphic = background;
		goto IL_0598;
		IL_04ab:
		UnityEngine.Object obj24 = tabCanvas;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v7+E4]");
		bool flag26 = (nint)0 == 0;
		int num7 = num3;
		UnityEngine.Object obj26 = tabCanvas;
		if (!flag26)
		{
			goto IL_04f4;
		}
		goto IL_0715;
		IL_0672:
		Image image = selectedBackground;
		nint num8 = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v22 (Il2CppClass<UnityEngine.UI.Image>)+2D0]");
		num3 = 0;
		image.raycastTarget = false;
		obj24 = tabCanvas;
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v7+E4]");
		bool flag27 = (nint)0 == 0;
		object obj27 = !flag27;
		flag8 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v22 (Il2CppClass<UnityEngine.UI.Image>)+2D0]");
		num7 = 0;
		flag9 = false;
		obj26 = tabCanvas;
		if (obj27 != null)
		{
			goto IL_04f4;
		}
		goto IL_0715;
		IL_07d8:
		ApplySorting(_isCurrent);
		ApplyVisual();
		return;
		IL_0752:
		int sortingOrder = tabCanvas.sortingOrder;
		_baseSortingOrder = sortingOrder;
		num7 = num3;
		goto IL_07d8;
		IL_04f4:
		bool flag28 = obj24;
		bool flag29 = !flag28;
		object obj28 = !flag29;
		if (obj28 != null)
		{
			goto IL_0752;
		}
		num7 = num3;
		goto IL_07d8;
		IL_0715:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag30 = obj26;
		bool flag31 = !flag30;
		num3 = num7;
		if (!flag31)
		{
			goto IL_0752;
		}
		goto IL_07d8;
		IL_041f:
		obj10 = selectedBackground;
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v24+E4]");
		bool flag32 = (nint)0 == 0;
		num5 = num3;
		obj9 = selectedBackground;
		if (!flag32)
		{
			goto IL_0468;
		}
		goto IL_0623;
		IL_0315:
		this.toggle.targetGraphic = clickHitbox;
		graphic = clickHitbox;
		bool flag33 = (object)clickHitbox == null;
		object obj29 = !flag33;
		if (obj29 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0598;
	}

	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BBC]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			obj5 = this.toggle;
			obj6 = this.toggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = this.toggle;
			obj6 = this.toggle;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_0192;
		IL_0192:
		if (_pendingSortingEnforce && base.isActiveAndEnabled)
		{
			GameObject gameObject = base.gameObject;
			if (gameObject.activeInHierarchy)
			{
				_pendingSortingEnforce = false;
				StopAllCoroutines();
				object obj8 = typeof(XmlSchemaInclude) + 3720;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = default(object);
				obj9..ctor();
				_ = 0;
				object obj10 = obj9 + 32;
				obj10 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Coroutine coroutine = StartCoroutine((IEnumerator)obj9);
			}
		}
		return;
		IL_014e:
		Toggle toggle = this.toggle;
		if (toggle.m_IsOn)
		{
			ApplySorting(isSelected: true);
		}
		goto IL_0192;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_014e;
		}
		goto IL_0192;
	}

	private void LateUpdate()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I4
		if (!_pendingSortingEnforce)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!tabCanvas)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = tabCanvas;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		ApplySorting(isSelected: true);
	}

	public void SetCurrent(bool isCurrent)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0327: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_03e1: Expected I, but got O
		//IL_03e6: Expected I, but got O
		//IL_0141: Expected O, but got I4
		//IL_0527: Expected O, but got I4
		//IL_052c: Expected I, but got O
		//IL_0531: Expected I, but got O
		//IL_049e: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_05d2: Expected O, but got I4
		//IL_05d7: Expected I, but got O
		//IL_05dc: Expected I, but got O
		//IL_024f: Expected O, but got I4
		//IL_0693: Expected O, but got I4
		//IL_0698: Expected I, but got O
		//IL_069d: Expected I, but got O
		//IL_02d2: Expected O, but got I4
		//IL_073c: Expected I, but got O
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected O, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BBD]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			_isCurrent = isCurrent;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v66+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selectedBackground;
			obj6 = selectedBackground;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			_isCurrent = isCurrent;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v66+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = selectedBackground;
			obj6 = selectedBackground;
			if (obj7 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00d5;
		}
		goto IL_0387;
		IL_0642:
		bool active = (byte)((isCurrent ? 1u : 0u) ^ 1u) != 0;
		normalVisuals.SetActive(active);
		UnityEngine.Object obj8 = this.toggle;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		nint num = unchecked((nint)null);
		nint num2 = unchecked((nint)null);
		UnityEngine.Object obj11 = this.toggle;
		if (obj10 != null)
		{
			goto IL_02af;
		}
		goto IL_06b5;
		IL_022c:
		UnityEngine.Object obj12;
		bool flag7 = obj12;
		bool flag8 = !flag7;
		object obj13 = !flag8;
		active = false;
		if (obj13 == null)
		{
			goto IL_0266;
		}
		goto IL_0642;
		IL_05fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj14;
		bool flag9 = obj14;
		bool flag10 = !flag9;
		nint num3;
		num = num3;
		active = false;
		if (flag10)
		{
			goto IL_0266;
		}
		goto IL_0642;
		IL_009b:
		bool flag11 = obj5;
		bool flag12 = !flag11;
		object obj15 = !flag12;
		flag5 = false;
		if (obj15 == null)
		{
			goto IL_00d5;
		}
		goto IL_0387;
		IL_0387:
		GameObject gameObject = selectedBackground.gameObject;
		gameObject.SetActive(isCurrent);
		UnityEngine.Object obj16 = background;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v58+E4]");
		bool flag13 = (nint)0 == 0;
		object obj18 = !flag13;
		num = unchecked((nint)null);
		nint num4 = unchecked((nint)null);
		flag5 = isCurrent;
		UnityEngine.Object obj19 = background;
		if (obj18 != null)
		{
			goto IL_011e;
		}
		goto IL_0406;
		IL_00d5:
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v58+E4]");
		bool flag14 = (nint)0 == 0;
		obj16 = background;
		num4 = num;
		obj19 = background;
		if (!flag14)
		{
			goto IL_011e;
		}
		goto IL_0406;
		IL_0406:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj19;
		bool flag16 = !flag15;
		num = num4;
		bool flag17 = false;
		if (flag16)
		{
			goto IL_0160;
		}
		goto IL_044c;
		IL_011e:
		bool flag18 = obj16;
		bool flag19 = !flag18;
		object obj20 = !flag19;
		flag17 = false;
		num4 = num;
		if (obj20 == null)
		{
			goto IL_0160;
		}
		goto IL_044c;
		IL_044c:
		GameObject gameObject2 = background.gameObject;
		if (isCurrent)
		{
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v52+E4]");
			bool flag20 = (nint)0 == 0;
			object obj22 = !flag20;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag21 = selectedBackground == null;
			flag17 = flag21;
		}
		else
		{
			flag17 = true;
		}
		gameObject2.SetActive(flag17);
		UnityEngine.Object obj23 = selectedVisuals;
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v17+E4]");
		bool flag22 = (nint)0 == 0;
		object obj25 = !flag22;
		num = unchecked((nint)null);
		nint num5 = unchecked((nint)null);
		UnityEngine.Object obj26 = selectedVisuals;
		if (obj25 != null)
		{
			goto IL_01a9;
		}
		goto IL_0549;
		IL_02af:
		bool flag23 = obj8;
		bool flag24 = !flag23;
		object obj27 = !flag24;
		if (obj27 != null)
		{
			goto IL_06f2;
		}
		num2 = num;
		goto IL_0741;
		IL_06b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag25 = obj11;
		bool flag26 = !flag25;
		num = num2;
		if (!flag26)
		{
			goto IL_06f2;
		}
		goto IL_0741;
		IL_0741:
		ApplySorting(isCurrent);
		ApplyVisual();
		if (!isCurrent)
		{
			return;
		}
		_pendingSortingEnforce = true;
		if (base.isActiveAndEnabled)
		{
			GameObject gameObject3 = base.gameObject;
			if (gameObject3.activeInHierarchy)
			{
				StopAllCoroutines();
				object obj28 = typeof(XmlSchemaInclude) + 3720;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj29 = default(object);
				obj29..ctor();
				_ = 0;
				object obj30 = obj29 + 32;
				obj30 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Coroutine coroutine = StartCoroutine((IEnumerator)obj29);
			}
		}
		return;
		IL_06f2:
		Toggle toggle = this.toggle;
		bool flag27 = isCurrent == toggle.m_IsOn;
		num2 = num;
		if (!flag27)
		{
			toggle.SetIsOnWithoutNotify(isCurrent);
			num2 = unchecked((nint)null);
		}
		goto IL_0741;
		IL_0266:
		obj8 = this.toggle;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v11+E4]");
		bool flag28 = (nint)0 == 0;
		num2 = num;
		obj11 = this.toggle;
		if (!flag28)
		{
			goto IL_02af;
		}
		goto IL_06b5;
		IL_0160:
		obj23 = selectedVisuals;
		obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v17+E4]");
		bool flag29 = (nint)0 == 0;
		num5 = num;
		obj26 = selectedVisuals;
		if (!flag29)
		{
			goto IL_01a9;
		}
		goto IL_0549;
		IL_0549:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag30 = obj26;
		bool flag31 = !flag30;
		num = num5;
		bool flag32 = false;
		if (flag31)
		{
			goto IL_01e3;
		}
		goto IL_058f;
		IL_01a9:
		bool flag33 = obj23;
		bool flag34 = !flag33;
		object obj31 = !flag34;
		flag32 = false;
		if (obj31 == null)
		{
			goto IL_01e3;
		}
		goto IL_058f;
		IL_058f:
		selectedVisuals.SetActive(isCurrent);
		obj12 = normalVisuals;
		object obj32 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v14+E4]");
		bool flag35 = (nint)0 == 0;
		object obj33 = !flag35;
		num = unchecked((nint)null);
		num3 = unchecked((nint)null);
		flag32 = isCurrent;
		obj14 = normalVisuals;
		if (obj33 != null)
		{
			goto IL_022c;
		}
		goto IL_05fc;
		IL_01e3:
		obj12 = normalVisuals;
		obj32 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v14+E4]");
		bool flag36 = (nint)0 == 0;
		num3 = num;
		obj14 = normalVisuals;
		if (!flag36)
		{
			goto IL_022c;
		}
		goto IL_05fc;
	}

	private void OnToggleChanged(bool isOn)
	{
		//IL_0067: Expected O, but got I
		//IL_0077: Expected O, but got I
		//IL_0087: Expected O, but got I
		if (isOn)
		{
			SetCurrent(isCurrent: true);
			UnityAction<int> onSelected = _onSelected;
			if (_onSelected != null)
			{
				int levelNumber = _levelNumber;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2 (UnityEngine.Events.UnityAction`1<System.Int32>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2 (UnityEngine.Events.UnityAction`1<System.Int32>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2 (UnityEngine.Events.UnityAction`1<System.Int32>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v36 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private void ApplyVisual()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_012c: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_0180: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_0250: Expected O, but got I4
		//IL_01fa: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_0276: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_0e7a: Expected O, but got I4
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Expected I4, but got Unknown
		//IL_0edd: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_0f04: Expected O, but got I4
		//IL_0f36: Expected O, but got I4
		//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Expected I4, but got Unknown
		//IL_0fa9: Expected O, but got I4
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected O, but got Unknown
		//IL_0351: Expected O, but got I4
		//IL_081a: Expected O, but got I4
		//IL_0823: Expected O, but got I4
		//IL_082c: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_08c9: Expected O, but got I4
		//IL_08d2: Expected O, but got I4
		//IL_08db: Expected O, but got I4
		//IL_0444: Expected O, but got I4
		//IL_048b: Expected O, but got I4
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected O, but got Unknown
		//IL_107b: Expected O, but got I4
		//IL_04b9: Expected O, but got I4
		//IL_05b4: Expected O, but got I4
		//IL_100a: Expected O, but got I
		//IL_1027: Expected O, but got I4
		//IL_04ab: Expected O, but got I4
		//IL_09a0: Expected O, but got I4
		//IL_09a9: Expected O, but got I4
		//IL_09ba: Expected O, but got I4
		//IL_0633: Expected O, but got I4
		//IL_0b2d: Expected O, but got I4
		//IL_0b36: Expected O, but got I4
		//IL_0513: Expected O, but got I4
		//IL_0525: Expected O, but got I4
		//IL_0a69: Expected O, but got I4
		//IL_0a72: Expected O, but got I4
		//IL_0a83: Expected O, but got I4
		//IL_06b0: Expected O, but got I4
		//IL_0b56: Expected O, but got I4
		//IL_0acc: Expected O, but got I4
		//IL_0add: Expected O, but got I4
		//IL_0c22: Expected O, but got I4
		//IL_0c2b: Expected O, but got I4
		//IL_1159: Expected O, but got I4
		//IL_0c78: Expected O, but got I
		//IL_0c48: Expected O, but got I4
		//IL_0c51: Expected O, but got I4
		//IL_0b99: Expected O, but got I4
		//IL_0c9b: Expected O, but got I
		//IL_0ca3: Expected I, but got O
		//IL_0bfc: Expected O, but got I4
		//IL_0c05: Expected O, but got I4
		//IL_0d83: Expected O, but got I4
		//IL_076e: Expected O, but got I4
		//IL_0e3b: Expected O, but got I4
		//IL_0e44: Expected O, but got I4
		//IL_0cf9: Expected O, but got I4
		//IL_10b2: Expected O, but got I4
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f0: Expected I4, but got Unknown
		//IL_1125: Expected O, but got I4
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Expected O, but got Unknown
		//IL_0760: Expected O, but got I4
		//IL_0dd9: Unsupported input type for neg.
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Expected O, but got Unknown
		//IL_0df8: Expected O, but got I4
		//IL_0da2: Expected O, but got I4
		//IL_119a: Expected O, but got I4
		//IL_11a3: Expected O, but got I4
		//IL_0781: Expected O, but got I4
		//IL_11e2: Expected O, but got I4
		//IL_11ea: Expected I, but got O
		//IL_11fc: Expected I, but got O
		//IL_0d24: Expected O, but got I4
		//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected O, but got Unknown
		//IL_0d4a: Expected O, but got I4
		//IL_0d61: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B26]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		UnityEngine.Object obj5;
		object obj7;
		UnityEngine.Object obj8;
		if (obj3 != null)
		{
			obj4 = this + 32;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v117+E4]");
			bool flag = (nint)0 == 0;
			obj7 = obj4;
			obj8 = (UnityEngine.Object)obj4;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v117+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = obj4;
			obj8 = (UnityEngine.Object)obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		obj4 = obj7;
		object obj12 = 0;
		if (obj10 == null)
		{
			goto IL_01a8;
		}
		goto IL_0266;
		IL_041a:
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v89+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = selectedBackground != null;
		bool flag7 = !flag6;
		object obj15 = !flag7;
		object obj16 = ~obj15;
		if (obj16 == null)
		{
			object obj17 = 40;
		}
		else
		{
			object obj17 = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AchievementLevelsTab)+v694 @ X8_v64]");
		UnityEngine.Object obj18 = (UnityEngine.Object)0;
		bool flag8 = !_isCurrent;
		object obj19 = 0;
		bool flag9 = false;
		object obj21;
		bool flag12;
		if (!flag8)
		{
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v93+E4]");
			if ((nint)0 != 0)
			{
				bool flag10 = selectedBackground != null;
				bool flag11 = !flag10;
				obj21 = 0;
				flag12 = false;
				obj19 = 0;
				flag9 = false;
				if (!flag11)
				{
					goto IL_053c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag13 = selectedBackground != null;
				bool flag14 = !flag13;
				object obj22 = !flag14;
				obj21 = 0;
				flag12 = false;
				if (obj22 != null)
				{
					goto IL_053c;
				}
				obj19 = 0;
				flag9 = false;
			}
		}
		goto IL_103e;
		IL_08f3:
		obj18 = (UnityEngine.Object)obj7;
		goto IL_103e;
		IL_03eb:
		bool flag15 = !_isCurrent;
		object obj23 = default(object);
		obj19 = obj23;
		bool flag16;
		flag9 = flag16;
		if (!flag15)
		{
			goto IL_041a;
		}
		goto IL_08f3;
		IL_00a0:
		bool flag17 = obj5;
		bool flag18 = !flag17;
		obj11 = 0;
		if (flag18)
		{
			goto IL_01a8;
		}
		obj12 = 0;
		obj7 = obj4;
		goto IL_0266;
		IL_01a8:
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v111+E4]");
		if ((nint)0 != 0)
		{
			bool flag19 = selectedBackground;
			bool flag20 = !flag19;
			object obj25 = !flag20;
			obj12 = 0;
			obj7 = obj4;
			if (obj25 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag21 = selectedBackground;
			bool flag22 = !flag21;
			obj12 = 0;
			obj7 = obj4;
			if (flag22)
			{
				return;
			}
		}
		goto IL_0266;
		IL_11ba:
		RectTransform rectTransform = ((Graphic)obj18).rectTransform;
		Transform transform = rectTransform;
		goto IL_0dbe;
		IL_0652:
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X0_v8+E4]");
		bool flag23 = (nint)0 == 0;
		object obj27 = obj19;
		UnityEngine.Object obj28 = obj18;
		if (!flag23)
		{
			goto IL_068f;
		}
		goto IL_0a9a;
		IL_0a9a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag24 = obj28;
		bool flag25 = !flag24;
		object obj29 = !flag25;
		obj19 = obj27;
		object obj30 = 0;
		obj18 = obj28;
		if (obj29 == null)
		{
			return;
		}
		goto IL_06be;
		IL_0266:
		object obj31 = _levelNumber - 1;
		bool flag26 = obj31 == null;
		object obj32 = !flag26;
		object obj33 = ~obj32;
		bool flag27;
		if (obj33 == null)
		{
			object obj34 = _levelNumber - _totalLevels;
			flag27 = obj34 == null;
		}
		else
		{
			flag27 = true;
		}
		object obj35 = _totalLevels - 2;
		bool flag28 = (nint)obj35 < 0;
		int num = _totalLevels ^ 2;
		int num2 = _totalLevels ^ obj35;
		int num3 = num & num2;
		bool flag29 = num3 < 0;
		bool flag30 = flag28 == flag29;
		object obj36 = !flag30;
		object obj37 = ~obj36;
		bool flag31 = obj37 == null || flag27;
		object obj38 = _unlockedLevel + 1;
		LevelTabState levelTabState = ((_levelNumber == (nint)obj38) ? LevelTabState.Active : LevelTabState.Locked);
		object obj39 = _levelNumber - _unlockedLevel;
		bool flag32 = (nint)obj39 < 0;
		bool flag33 = obj39 == null;
		int num4 = _levelNumber ^ _unlockedLevel;
		int num5 = _levelNumber ^ obj39;
		int num6 = num4 & num5;
		bool flag34 = num6 < 0;
		bool flag35 = flag32 == flag34;
		object obj40 = !flag33;
		object obj41 = flag35 & obj40;
		object obj42 = ~obj41;
		LevelTabState levelTabState2 = ((obj42 != null) ? LevelTabState.Done : levelTabState);
		object obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v3+E4]");
		bool flag38;
		if ((nint)0 != 0)
		{
			bool flag36 = normalVisuals;
			bool flag37 = !flag36;
			object obj44 = !flag37;
			flag38 = false;
			if (obj44 == null)
			{
				goto IL_0368;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag39 = normalVisuals;
			bool flag40 = !flag39;
			flag38 = false;
			if (flag40)
			{
				goto IL_0368;
			}
		}
		bool flag41 = !_isCurrent;
		normalVisuals.SetActive(flag41);
		UnityEngine.Object obj45 = selectedVisuals;
		object obj46 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v31+E4]");
		bool flag42 = (nint)0 == 0;
		object obj47 = !flag42;
		obj23 = 0;
		object obj48 = 0;
		flag38 = flag41;
		UnityEngine.Object obj49 = selectedVisuals;
		if (obj47 != null)
		{
			goto IL_03b1;
		}
		goto IL_084c;
		IL_0c63:
		UnityEngine.Object obj50 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AchievementLevelsTab)+v579 @ X8_v26]");
		((Image)obj50).sprite = (Sprite)0;
		Color levelTextColor = ((AchievementLevelsTab)obj18).GetLevelTextColor(levelTabState2);
		levelText.color = (Color)0;
		nint num7 = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1039 @ X8_v28 (Il2CppClass<UnityEngine.Object>)+2D8] (should have been resolved before IL gen)");
		bool flag46;
		object obj54;
		if (_isCurrent)
		{
			object obj51 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X8_v36+E4]");
			bool flag43 = (nint)0 == 0;
			object obj52 = !flag43;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag44 = selectedBackground != null;
			bool flag45 = !flag44;
			object obj53 = !flag45;
			obj54 = 0;
			flag46 = false;
			if (obj53 == null)
			{
				object obj55 = (flag31 ? 1 : 0) ^ 1;
				object obj56 = obj55 & 1;
				bool flag47 = obj56 == null;
				obj54 = 0;
				if (flag47)
				{
					goto IL_0d91;
				}
				obj54 = 0;
				flag46 = false;
			}
			goto IL_11ba;
		}
		bool flag48 = !flag31;
		obj54 = 0;
		if (!flag48)
		{
			goto IL_0d91;
		}
		RectTransform rectTransform2 = ((Graphic)obj18).rectTransform;
		bool flag49 = (object)rectTransform2 == null;
		object obj57 = !flag49;
		obj54 = 0;
		flag46 = false;
		transform = rectTransform2;
		if (obj57 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0dbe;
		IL_068f:
		bool flag50 = obj18;
		bool flag51 = !flag50;
		obj30 = 0;
		if (!flag51)
		{
			goto IL_06be;
		}
		return;
		IL_06be:
		if (_isCurrent)
		{
			object obj58 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v46+E4]");
			if ((nint)0 != 0)
			{
				if (selectedBackground != null)
				{
					goto IL_0736;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag52 = selectedBackground != null;
				bool flag53 = !flag52;
				object obj59 = !flag53;
				if (obj59 != null)
				{
					goto IL_0736;
				}
			}
		}
		bool flag54;
		object obj60;
		switch (levelTabState2)
		{
		case LevelTabState.Active:
		{
			flag54 = !flag31;
			obj60 = 112;
			object obj61 = 136;
			break;
		}
		case LevelTabState.Done:
		{
			flag54 = !flag31;
			obj60 = 104;
			object obj61 = 128;
			break;
		}
		default:
		{
			flag54 = !flag31;
			obj60 = 96;
			object obj61 = 120;
			break;
		}
		}
		object obj62 = !flag54;
		object obj63 = ~obj62;
		if (obj63 == null)
		{
			object obj61 = obj60;
		}
		goto IL_0c63;
		IL_0736:
		if (_levelNumber == (nint)obj38)
		{
			object obj61 = 160;
		}
		else
		{
			object obj61 = 144;
		}
		object obj64 = _levelNumber - _unlockedLevel;
		bool flag55 = (nint)obj64 < 0;
		bool flag56 = obj64 == null;
		int num8 = _levelNumber ^ _unlockedLevel;
		int num9 = _levelNumber ^ obj64;
		int num10 = num8 & num9;
		bool flag57 = num10 < 0;
		bool flag58 = flag55 == flag57;
		object obj65 = !flag56;
		object obj66 = flag58 & obj65;
		object obj67 = ~obj66;
		if (obj67 != null)
		{
			object obj61 = 152;
		}
		goto IL_0c63;
		IL_0dbe:
		Vector3 localScale = transform.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj69 = default(object);
		object obj68 = 0 - obj69;
		bool flag59 = !flag46;
		object obj70 = !flag59;
		object obj71 = ~obj70;
		if (obj71 == null)
		{
		}
		transform.localScale = (Vector3)0;
		nint num11 = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1113 @ X8_v32 (Il2CppClass<UnityEngine.Object>)+2F8] (should have been resolved before IL gen)");
		nint num12 = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v344 @ X8_v33 (Il2CppClass<UnityEngine.Object>)+308] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0d91:
		object obj72 = _levelNumber - _totalLevels;
		bool flag60 = obj72 == null;
		flag46 = flag60;
		goto IL_11ba;
		IL_0900:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj73;
		bool flag61 = obj73;
		bool flag62 = !flag61;
		obj19 = obj21;
		bool flag63 = false;
		obj18 = obj28;
		UnityEngine.Object obj74 = obj73;
		if (flag62)
		{
			goto IL_05d3;
		}
		goto IL_0956;
		IL_053c:
		obj74 = (UnityEngine.Object)obj7;
		object obj75 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X0_v24+E4]");
		bool flag64 = (nint)0 == 0;
		obj19 = obj21;
		obj73 = (UnityEngine.Object)obj7;
		flag9 = flag12;
		obj28 = obj18;
		if (!flag64)
		{
			goto IL_0591;
		}
		goto IL_0900;
		IL_103e:
		object obj76 = this + 40;
		obj74 = (UnityEngine.Object)obj76;
		obj75 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X0_v24+E4]");
		bool flag65 = (nint)0 == 0;
		object obj77 = !flag65;
		obj73 = (UnityEngine.Object)obj76;
		obj21 = obj19;
		obj28 = obj18;
		if (obj77 != null)
		{
			goto IL_0591;
		}
		goto IL_0900;
		IL_05d3:
		object obj78 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X0_v16+E4]");
		bool flag66 = (nint)0 == 0;
		object obj79 = obj19;
		obj28 = obj18;
		if (!flag66)
		{
			goto IL_0610;
		}
		goto IL_09d1;
		IL_0956:
		GameObject gameObject = ((Component)obj74).gameObject;
		gameObject.SetActive(value: false);
		obj78 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X0_v16+E4]");
		bool flag67 = (nint)0 == 0;
		object obj80 = !flag67;
		obj19 = 0;
		obj18 = obj28;
		obj79 = 0;
		flag63 = false;
		if (obj80 != null)
		{
			goto IL_0610;
		}
		goto IL_09d1;
		IL_0591:
		bool flag68 = obj74;
		bool flag69 = !flag68;
		object obj81 = !flag69;
		flag63 = false;
		obj28 = obj18;
		if (obj81 == null)
		{
			goto IL_05d3;
		}
		goto IL_0956;
		IL_0a1f:
		GameObject gameObject2 = ((Component)obj28).gameObject;
		gameObject2.SetActive(value: true);
		obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X0_v8+E4]");
		bool flag70 = (nint)0 == 0;
		object obj82 = !flag70;
		obj19 = 0;
		obj18 = obj28;
		obj27 = 0;
		bool flag71 = true;
		if (obj82 != null)
		{
			goto IL_068f;
		}
		goto IL_0a9a;
		IL_0610:
		bool flag72 = obj18;
		bool flag73 = !flag72;
		object obj83 = !flag73;
		flag71 = false;
		obj28 = obj18;
		if (obj83 == null)
		{
			goto IL_0652;
		}
		goto IL_0a1f;
		IL_09d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag74 = obj28;
		bool flag75 = !flag74;
		obj19 = obj79;
		flag71 = false;
		obj18 = obj28;
		if (flag75)
		{
			goto IL_0652;
		}
		goto IL_0a1f;
		IL_0368:
		obj46 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v31+E4]");
		bool flag76 = (nint)0 == 0;
		obj45 = selectedVisuals;
		obj48 = obj23;
		obj49 = selectedVisuals;
		if (!flag76)
		{
			goto IL_03b1;
		}
		goto IL_084c;
		IL_084c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag77 = obj49;
		bool flag78 = !flag77;
		obj23 = obj48;
		flag16 = false;
		if (flag78)
		{
			goto IL_03eb;
		}
		goto IL_0892;
		IL_03b1:
		bool flag79 = obj45;
		bool flag80 = !flag79;
		object obj84 = !flag80;
		flag16 = false;
		if (obj84 == null)
		{
			goto IL_03eb;
		}
		goto IL_0892;
		IL_0892:
		flag16 = _isCurrent;
		selectedVisuals.SetActive(_isCurrent);
		bool flag81 = !_isCurrent;
		object obj85 = !flag81;
		obj23 = 0;
		obj19 = 0;
		flag9 = _isCurrent;
		if (obj85 != null)
		{
			goto IL_041a;
		}
		goto IL_08f3;
	}

	private void ApplySorting(bool isSelected)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0185: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B27]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = tabCanvas;
			obj6 = tabCanvas;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = tabCanvas;
			obj6 = tabCanvas;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		bool flag5 = _baseSortingOrder == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			int sortingOrder = tabCanvas.sortingOrder;
			_baseSortingOrder = sortingOrder;
		}
		tabCanvas.overrideSorting = isSelected;
		int num = _baseSortingOrder;
		if (isSelected)
		{
			num = selectedOrderBoost + num;
		}
		tabCanvas.sortingOrder = num;
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private IEnumerator CoEnforceSorting()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(XmlSchemaInclude) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private Sprite PickSelectedSprite(LevelTabState state)
	{
		//IL_0037: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_0045: Expected O, but got I4
		if (state == LevelTabState.Active)
		{
			object obj = 160;
		}
		else
		{
			object obj = 144;
		}
		if (state == LevelTabState.Done)
		{
			object obj = 152;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AchievementLevelsTab)+v29 @ X8_v3]");
		return (Sprite)0;
	}

	private Color GetLevelTextColor(LevelTabState state)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2336;
		Color result = (Color)obj;
		if (state != LevelTabState.Locked && state == LevelTabState.Done)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v3 (UnityEngine.Color)+E4]");
			bool flag = (nint)0 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result = (Color)obj;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v3 (UnityEngine.Color)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result = (Color)obj;
			}
		}
		return result;
	}

	private Sprite PickSprite(LevelTabPos pos, LevelTabState state)
	{
		//IL_0037: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_0144: Expected O, but got I
		if (pos == LevelTabPos.Edge)
		{
			object obj = 104;
		}
		else
		{
			object obj = 128;
		}
		object obj2 = ((pos != LevelTabPos.Edge) ? ((object)120) : ((object)96));
		object obj3 = ((pos != LevelTabPos.Edge) ? ((object)136) : ((object)112));
		object obj4 = state - 2;
		bool flag = obj4 == null;
		object obj5 = !flag;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			obj2 = obj3;
		}
		if (state != LevelTabState.Done)
		{
			object obj = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AchievementLevelsTab)+v73 @ X8_v3]");
		return (Sprite)0;
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0107: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B29]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = this.toggle;
			obj6 = this.toggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = this.toggle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = this.toggle;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		Toggle toggle = this.toggle;
		object obj10 = typeof(TypeConverter<ushort, char>) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1680;
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj11);
		toggle.onValueChanged.RemoveListener(unityAction);
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	static AchievementLevelsTab()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2336;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D40]");
		obj3 = 0;
		_ = 0;
	}
}
