using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class ContainerItemSelector : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Toggle, bool> <>9__42_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <NotifyIndexChanged>b__42_0(Toggle t)
		{
			//IL_0067: Expected I4, but got O
			if ((object)t != null)
			{
				GameObject gameObject = t.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private RectTransform container;

	private ToggleGroupIndexer toggleIndexer;

	public bool isVertical;

	public bool useItemPaddingSize;

	private bool <isReversed>k__BackingField;

	private bool <overridePositionFactor>k__BackingField;

	private float <positionFactor>k__BackingField;

	public int forceChildCount;

	private int[] arrangeIndexes;

	public Vector2 anchorOffset;

	private float horizontalPadding;

	private float verticalPadding;

	private float widthMultiplier;

	private float heightMultiplier;

	private bool <useTweaning>k__BackingField;

	private float duration;

	private Ease easing;

	private bool useFading;

	private AnimationCurve fadeCurve;

	private Action<int> m_OnSelectionChanged;

	public bool isReversed
	{
		get
		{
			return <isReversed>k__BackingField;
		}
		set
		{
			<isReversed>k__BackingField = value;
		}
	}

	public bool overridePositionFactor
	{
		get
		{
			return <overridePositionFactor>k__BackingField;
		}
		set
		{
			<overridePositionFactor>k__BackingField = value;
		}
	}

	public float positionFactor
	{
		get
		{
			return <positionFactor>k__BackingField;
		}
		set
		{
			<positionFactor>k__BackingField = value;
		}
	}

	public int itemsCount
	{
		get
		{
			//IL_0070: Expected I4, but got O
			if (forceChildCount > 0)
			{
				return forceChildCount;
			}
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				return transform.childCount;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public bool useTweaning
	{
		get
		{
			return <useTweaning>k__BackingField;
		}
		set
		{
			<useTweaning>k__BackingField = value;
		}
	}

	public event Action<int> OnSelectionChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj2 = this + 120;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj2 = this + 120;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private void Awake()
	{
		//IL_0017: Expected O, but got I
		//IL_002a: Expected O, but got I4
		SetPosition(instant: true);
		object obj = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Vector2 itemFitSize = GetItemFitSize();
		RectTransform rectTransform = default(RectTransform);
		rectTransform.sizeDelta = (Vector2)0;
		duration = 0.12f;
	}

	private void SetSize()
	{
		//IL_000c: Expected O, but got I
		//IL_001f: Expected O, but got I4
		object obj = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Vector2 itemFitSize = GetItemFitSize();
		RectTransform rectTransform = default(RectTransform);
		rectTransform.sizeDelta = (Vector2)0;
	}

	private Vector2 GetItemFitSize(bool useMultiplier = true)
	{
		//IL_01be: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		//IL_0116: Expected I4, but got O
		//IL_01d4: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		if ((object)container == null)
		{
			goto IL_020a;
		}
		Vector2 vector = container.sizeDelta;
		int num;
		if (useItemPaddingSize || isVertical)
		{
			num = forceChildCount;
			if (forceChildCount <= 0)
			{
				goto IL_0074;
			}
			goto IL_01ab;
		}
		if (forceChildCount >= 1)
		{
			bool flag = !useMultiplier;
			object obj = !flag;
			num = (int)vector;
			if (obj != null)
			{
				goto IL_01cc;
			}
		}
		else
		{
			Transform transform = base.transform;
			if ((object)transform == null)
			{
				goto IL_020a;
			}
			num = transform.childCount;
			if (isVertical)
			{
				num = forceChildCount;
				if (forceChildCount <= 0)
				{
					goto IL_0074;
				}
				goto IL_01ab;
			}
			bool flag2 = !useMultiplier;
			object obj2 = !flag2;
			if (obj2 != null)
			{
				goto IL_01cc;
			}
			vector = (Vector2)num;
		}
		goto IL_0237;
		IL_0237:
		return vector;
		IL_020a:
		return (Vector2)new NullReferenceException();
		IL_01cc:
		vector = (Vector2)num;
		goto IL_0237;
		IL_01ab:
		bool flag3 = !useMultiplier;
		vector = (Vector2)num;
		if (!flag3)
		{
			goto IL_01cc;
		}
		goto IL_0237;
		IL_0074:
		Transform transform2 = base.transform;
		if ((object)transform2 == null)
		{
			goto IL_020a;
		}
		num = transform2.childCount;
		bool flag4 = !useMultiplier;
		object obj3 = !flag4;
		if (obj3 != null)
		{
			goto IL_01cc;
		}
		vector = (Vector2)num;
		goto IL_0237;
	}

	private Vector2 GetFitSizeFactor()
	{
		Vector2 itemFitSize = GetItemFitSize(useMultiplier: false);
		if ((object)container != null)
		{
			Vector2 sizeDelta = container.sizeDelta;
			if ((object)container != null)
			{
				return container.sizeDelta;
			}
		}
		return (Vector2)new NullReferenceException();
	}

	private float GetPositionFactor(float index)
	{
		//IL_007c: Invalid comparison between F4 and I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_0518: Expected O, but got I
		//IL_00a9: Invalid comparison between F4 and I4
		//IL_00ba: Expected F4, but got I4
		//IL_0288: Expected F4, but got I4
		//IL_02f6: Expected F4, but got I4
		//IL_0316: Expected F4, but got I4
		//IL_0574: Invalid comparison between F8 and I4
		//IL_0583: Invalid comparison between F8 and I4
		//IL_059d: Expected O, but got F8
		//IL_05ac: Expected O, but got F8
		//IL_05e1: Expected O, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_0173: Expected F4, but got I4
		//IL_06e7: Expected F8, but got I4
		//IL_0610: Invalid comparison between F4 and I4
		//IL_0658: Expected F4, but got I4
		//IL_04a7: Expected O, but got I4
		//IL_023c: Expected F8, but got I4
		//IL_0262: Expected F4, but got I4
		//IL_01e1: Expected F4, but got I4
		int childCount = forceChildCount;
		float num;
		bool flag2;
		if (forceChildCount <= 0)
		{
			Transform transform = base.transform;
			bool flag = (object)transform == null;
			num = index;
			flag2 = false;
			if (flag)
			{
				goto IL_04cb;
			}
			childCount = transform.childCount;
		}
		bool flag3 = index < 0f;
		num = index;
		flag2 = false;
		float num2;
		float num3;
		double num4;
		float num6;
		double num7;
		double num5 = default(double);
		double num8 = default(double);
		if (!flag3)
		{
			bool flag4 = !(index < (float)childCount);
			num = childCount;
			flag2 = false;
			if (!flag4)
			{
				int childCount2 = forceChildCount;
				if (forceChildCount > 0)
				{
					if (<overridePositionFactor>k__BackingField)
					{
						goto IL_011f;
					}
				}
				else
				{
					Transform transform2 = base.transform;
					bool flag5 = (object)transform2 == null;
					num = childCount;
					flag2 = false;
					if (flag5)
					{
						goto IL_04cb;
					}
					childCount2 = transform2.childCount;
					if (<overridePositionFactor>k__BackingField)
					{
						goto IL_011f;
					}
				}
				num2 = index / (float)childCount2;
				bool flag6 = !<isReversed>k__BackingField;
				num3 = childCount2;
				num4 = num5;
				num6 = num2;
				num7 = num8;
				num = childCount2;
				if (!flag6)
				{
					goto IL_0324;
				}
				goto IL_0666;
			}
		}
		object obj = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_011f:
		int childCount3 = forceChildCount;
		bool flag7 = forceChildCount > 0;
		int num9 = forceChildCount;
		if (!flag7)
		{
			Transform transform3 = base.transform;
			bool flag8 = (object)transform3 == null;
			num = childCount;
			flag2 = false;
			if (flag8)
			{
				goto IL_04cb;
			}
			childCount3 = transform3.childCount;
			num9 = forceChildCount;
			if (forceChildCount <= 0)
			{
				Transform transform4 = base.transform;
				bool flag9 = (object)transform4 == null;
				num = childCount;
				flag2 = false;
				if (flag9)
				{
					goto IL_04cb;
				}
				int childCount4 = transform4.childCount;
				num9 = childCount4;
			}
		}
		double num10 = (double)childCount3 + -1.0;
		double num11 = num10 / (double)num9;
		double num12 = (double)<positionFactor>k__BackingField - 1.0;
		bool flag10 = num12 < 0.0;
		bool flag11 = num12 == 0.0;
		object obj3 = (double)<positionFactor>k__BackingField ^ 1.0;
		object obj4 = (double)<positionFactor>k__BackingField ^ num12;
		object obj5 = obj3 & obj4;
		bool flag12 = (nint)obj5 < 0;
		bool flag13 = flag10 == flag12;
		object obj6 = !flag11;
		object obj7 = flag13 & obj6;
		object obj8 = ~obj7;
		num8 = ((obj8 != null) ? ((double)<positionFactor>k__BackingField) : 1.0);
		if (<positionFactor>k__BackingField < 0f)
		{
			num8 = 0.0;
		}
		num5 = num11 * num8;
		bool flag14 = <isReversed>k__BackingField;
		num2 = (float)num5;
		num3 = 0f;
		if (flag14)
		{
			goto IL_0324;
		}
		num4 = num5;
		num6 = (float)num5;
		num7 = num8;
		num = 0f;
		goto IL_0666;
		IL_0324:
		int childCount5 = forceChildCount;
		bool flag15 = forceChildCount > 0;
		int num13 = forceChildCount;
		if (!flag15)
		{
			Transform transform5 = base.transform;
			bool flag16 = (object)transform5 == null;
			num = num3;
			flag2 = false;
			if (flag16)
			{
				goto IL_04cb;
			}
			childCount5 = transform5.childCount;
			num13 = forceChildCount;
			if (forceChildCount <= 0)
			{
				Transform transform6 = base.transform;
				bool flag17 = (object)transform6 == null;
				num = num3;
				flag2 = false;
				if (flag17)
				{
					goto IL_04cb;
				}
				int childCount6 = transform6.childCount;
				num13 = childCount6;
			}
		}
		double num14 = (double)childCount5 + -1.0;
		num = (float)num14 / (float)num13;
		num6 = num - num2;
		num4 = num13;
		num7 = num8;
		goto IL_0666;
		IL_04cb:
		throw new NullReferenceException();
		IL_0666:
		Vector2 itemFitSize = GetItemFitSize(useMultiplier: false);
		bool flag18 = (object)container == null;
		num5 = num4;
		num8 = num7;
		flag2 = false;
		if (!flag18)
		{
			Vector2 sizeDelta = container.sizeDelta;
			bool flag19 = (object)container == null;
			num5 = num4;
			num8 = num7;
			flag2 = false;
			if (!flag19)
			{
				Vector2 sizeDelta2 = container.sizeDelta;
				float num15 = num / num;
				double num16 = num4 / num4;
				bool flag20 = !isVertical;
				object obj9 = !flag20;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					num15 = (float)num16;
				}
				float num17 = num15 * 0.5f;
				return num6 + num17;
			}
		}
		goto IL_04cb;
	}

	private void SetPosition(bool instant = false)
	{
		//IL_0026: Expected I4, but got I8
		//IL_0040: Expected O, but got I4
		//IL_01f5: Expected O, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_0088: Expected F4, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_02bc: Expected F4, but got I
		//IL_0294: Expected F4, but got O
		//IL_0106: Expected O, but got I4
		//IL_02e7: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_0325: Expected O, but got I
		//IL_0346: Expected O, but got I4
		//IL_012c: Expected F4, but got O
		//IL_0176: Expected O, but got I
		//IL_01cf: Expected O, but got I
		int selectedIndex = toggleIndexer.SelectedIndex;
		int num = (int)(selectedIndex & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = (nint)0 + (nint)4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			int selectedViewIndexByOrder = toggleIndexer.GetSelectedViewIndexByOrder(arrangeIndexes);
			float num2 = GetPositionFactor(selectedViewIndexByOrder);
			bool flag2 = !instant;
			object obj3 = !flag2;
			RectTransform rectTransform = default(RectTransform);
			if (obj3 == null && <useTweaning>k__BackingField)
			{
				int num3 = ShortcutExtensions.DOKill(rectTransform);
				bool flag3 = !isVertical;
				object obj4 = !flag3;
				object obj5 = ~obj4;
				if (obj5 == null)
				{
				}
				object obj6 = !flag3;
				object obj7 = ~obj6;
				float num4 = ((obj7 != null) ? num2 : ((float)anchorOffset));
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorMin(rectTransform, (Vector2)0, num4);
				object obj8 = (nint)0 + (nint)2872;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorMax(rectTransform, (Vector2)0, num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				if (useFading)
				{
					object obj9 = (nint)0 + (nint)3872;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					Component target = default(Component);
					int num5 = ShortcutExtensions.DOKill(target);
					float num6 = duration * 1.0636755E+09f;
					TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOFade((Image)target, 1f, num6);
					object obj10 = (nint)0 + (nint)2808;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
				}
			}
			else if (isVertical)
			{
				UIExtensions.SetAnchorY(rectTransform, num2);
				UIExtensions.SetAnchorX(rectTransform, (float)anchorOffset);
			}
			else
			{
				UIExtensions.SetAnchorX(rectTransform, num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ContainerItemSelector)+4C]");
				UIExtensions.SetAnchorY(rectTransform, 0f);
			}
		}
		else
		{
			string text = base.name;
			object obj11 = (nint)0 + (nint)3168;
			string message = text + (string)obj11;
			object obj12 = typeof(DataRelation) + 856;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+E4]");
			if ((nint)0 != 0)
			{
				Debug.LogWarning(message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.LogWarning(message);
		}
	}

	public void NotifyIndexChanged(int _)
	{
		//IL_0065: Expected I4, but got I8
		//IL_007f: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0164: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_0228: Expected O, but got I
		//IL_0238: Expected O, but got I
		//IL_0248: Expected O, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I
		//IL_02e3: Expected I, but got O
		//IL_0301: Expected O, but got I
		//IL_013d: Expected O, but got I
		//IL_0206: Expected O, but got I
		int selectedIndex = toggleIndexer.SelectedIndex;
		int[] array = arrangeIndexes;
		if (selectedIndex >= array.Length)
		{
			return;
		}
		int selectedIndex2 = toggleIndexer.SelectedIndex;
		int num = (int)(selectedIndex2 & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		ToggleGroupIndexer toggleGroupIndexer = toggleIndexer;
		object obj2 = typeof(CardUtils.<>c) + 2328;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v15+E4]");
		object obj4;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v15+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14+8]");
				Func<object, bool> func = (Func<object, bool>)0;
				goto IL_01b4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v15+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14+8]");
			Func<object, bool> func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14+8]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v14+8]");
			predicate = (Func<object, bool>)0;
			if (obj6 == null)
			{
				goto IL_01b4;
			}
		}
		goto IL_0253;
		IL_01b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v20+B8]");
			obj4 = 0;
		}
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1864;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj4, (IntPtr)obj10);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v19+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func2;
		goto IL_0253;
		IL_0253:
		int num2 = Enumerable.Count(toggleGroupIndexer.Toggles, predicate);
		forceChildCount = num2;
		SetPosition();
		Action<int> onSelectionChanged = this.OnSelectionChanged;
		if (this.OnSelectionChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12 (System.Action`1<System.Int32>)+18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12 (System.Action`1<System.Int32>)+40]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v12 (System.Action`1<System.Int32>)+28]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v106 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	private void OnValidate()
	{
		//IL_004c: Expected O, but got I
		//IL_005f: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			SetPosition(instant: true);
			object obj = (nint)0 + (nint)4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Vector2 itemFitSize = GetItemFitSize();
			RectTransform rectTransform = default(RectTransform);
			rectTransform.sizeDelta = (Vector2)0;
		}
	}

	private void OnDrawGizmos()
	{
		//IL_0019: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected I4, but got Unknown
		//IL_0195: Expected O, but got I4
		//IL_060d: Expected O, but got I4
		//IL_062f: Expected O, but got I4
		//IL_0651: Expected O, but got I4
		//IL_01e8: Expected I4, but got F8
		//IL_0202: Expected F8, but got I4
		//IL_024f: Invalid comparison between F8 and I4
		//IL_025e: Invalid comparison between F8 and I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected I4, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected I4, but got Unknown
		//IL_02b3: Expected O, but got I4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_031c: Invalid comparison between F8 and I4
		//IL_032b: Invalid comparison between F8 and I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected I4, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected I4, but got Unknown
		//IL_0380: Expected O, but got I4
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_03e9: Invalid comparison between F8 and I4
		//IL_03f8: Invalid comparison between F8 and I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected I4, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected I4, but got Unknown
		//IL_044d: Expected O, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_04bb: Invalid comparison between F8 and I4
		//IL_04ca: Invalid comparison between F8 and I4
		//IL_04e2: Expected O, but got F8
		//IL_04ef: Expected O, but got F8
		//IL_0524: Expected O, but got I4
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_06d1: Invalid comparison between F8 and I4
		//IL_0584: Expected O, but got I4
		//IL_0584: Expected O, but got I4
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		Vector2 sizeDelta = container.sizeDelta;
		Gizmos.color = (Color)0;
		Vector3 position = container.position;
		Gizmos.DrawWireCube((Vector3)0, (Vector3)0);
		int childCount = forceChildCount;
		bool flag = forceChildCount > 0;
		object obj = 1;
		double num = 1.0;
		double num2 = 1.0;
		int num3 = 0;
		object obj2 = 1;
		double num4 = 1.0;
		double num5 = 1.0;
		int num6 = 0;
		if (!flag)
		{
			goto IL_00c2;
		}
		goto IL_0103;
		IL_00c2:
		Transform transform = base.transform;
		childCount = transform.childCount;
		obj2 = obj;
		num4 = num;
		num5 = num2;
		num6 = num3;
		goto IL_0103;
		IL_0103:
		bool flag19;
		do
		{
			if ((nint)obj2 < childCount)
			{
				int childCount2 = forceChildCount;
				if (forceChildCount <= 0)
				{
					Transform transform2 = base.transform;
					childCount2 = transform2.childCount;
				}
				int num7 = obj2 / childCount2;
				bool flag2 = !isVertical;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				int num8 = ((obj4 != null) ? num7 : num6);
				object obj5 = !flag2;
				object obj6 = ~obj5;
				int num9 = ((obj6 != null) ? num6 : num7);
				object obj7 = !flag2;
				object obj8 = ~obj7;
				int num10 = ((obj8 != null) ? num7 : ((int)num5));
				object obj9 = !flag2;
				object obj10 = ~obj9;
				double num11 = ((obj10 != null) ? num5 : ((double)num7));
				Vector2 sizeDelta2 = container.sizeDelta;
				Vector2 sizeDelta3 = container.sizeDelta;
				double num12 = (double)num8 - num5;
				bool flag3 = num12 < 0.0;
				bool flag4 = num12 == 0.0;
				int num13 = num8 ^ num5;
				int num14 = num8 ^ num12;
				int num15 = num13 & num14;
				bool flag5 = num15 < 0;
				bool flag6 = flag3 == flag5;
				object obj11 = !flag4;
				object obj12 = flag6 & obj11;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
				}
				if (num8 < 0)
				{
				}
				Vector2 sizeDelta4 = container.sizeDelta;
				Vector2 sizeDelta5 = container.sizeDelta;
				double num16 = (double)num9 - num5;
				bool flag7 = num16 < 0.0;
				bool flag8 = num16 == 0.0;
				int num17 = num9 ^ num5;
				int num18 = num9 ^ num16;
				int num19 = num17 & num18;
				bool flag9 = num19 < 0;
				bool flag10 = flag7 == flag9;
				object obj14 = !flag8;
				object obj15 = flag10 & obj14;
				object obj16 = ~obj15;
				if (obj16 == null)
				{
				}
				if (num9 < 0)
				{
				}
				Vector2 sizeDelta6 = container.sizeDelta;
				Vector2 sizeDelta7 = container.sizeDelta;
				double num20 = (double)num10 - num5;
				bool flag11 = num20 < 0.0;
				bool flag12 = num20 == 0.0;
				int num21 = num10 ^ num5;
				int num22 = num10 ^ num20;
				int num23 = num21 & num22;
				bool flag13 = num23 < 0;
				bool flag14 = flag11 == flag13;
				object obj17 = !flag12;
				object obj18 = flag14 & obj17;
				object obj19 = ~obj18;
				if (obj19 == null)
				{
				}
				if (num10 < 0)
				{
				}
				Vector2 sizeDelta8 = container.sizeDelta;
				Vector2 sizeDelta9 = container.sizeDelta;
				double num24 = num11 - 1.0;
				bool flag15 = num24 < 0.0;
				bool flag16 = num24 == 0.0;
				object obj20 = num11 ^ 1.0;
				object obj21 = num11 ^ num24;
				object obj22 = obj20 & obj21;
				bool flag17 = (nint)obj22 < 0;
				bool flag18 = flag15 == flag17;
				object obj23 = !flag16;
				object obj24 = flag18 & obj23;
				object obj25 = ~obj24;
				if (obj25 == null)
				{
				}
				if (num11 < 0.0)
				{
				}
				Vector3 position2 = container.position;
				Vector3 position3 = container.position;
				Gizmos.DrawLine((Vector3)0, (Vector3)0);
				obj2++;
				childCount = forceChildCount;
				flag19 = forceChildCount > 0;
				num5 = 1.0;
				num6 = 0;
				continue;
			}
			return;
		}
		while (flag19);
		obj = obj2;
		num = num4;
		num2 = 1.0;
		num3 = 0;
		goto IL_00c2;
	}

	public ContainerItemSelector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0047: Expected O, but got I
		object obj = typeof(UsageHint) + 744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+8]");
		object obj3 = (nint)0 * (nint)63;
		_ = 0;
		base..ctor();
	}
}
