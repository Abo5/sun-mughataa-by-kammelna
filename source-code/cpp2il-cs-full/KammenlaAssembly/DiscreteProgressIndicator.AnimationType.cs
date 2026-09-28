using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DiscreteProgressIndicator : MonoBehaviour
{
	private enum AnimationType
	{
		Fade,
		Scale
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Graphic, bool> <>9__21_0;

		public static Func<Image, bool> <>9__27_0;

		public static Func<Graphic, bool> <>9__28_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <InitComponent>b__21_0(Graphic g)
		{
			//IL_00ee: Expected I4, but got O
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_00c5: Expected O, but got I
			//IL_008d: Expected O, but got I
			if ((object)g != null)
			{
				GameObject gameObject = g.gameObject;
				if ((object)gameObject != null)
				{
					object obj = typeof(DataRelation) + 2320;
					string name = gameObject.name;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+B8]");
						object obj3 = 0;
						return name == (string)obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+B8]");
					object obj5 = 0;
					return name == (string)obj5;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SetSprite>b__27_0(Image g)
		{
			//IL_00ee: Expected I4, but got O
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_00c5: Expected O, but got I
			//IL_008d: Expected O, but got I
			if ((object)g != null)
			{
				GameObject gameObject = g.gameObject;
				if ((object)gameObject != null)
				{
					object obj = typeof(DataRelation) + 2320;
					string name = gameObject.name;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+B8]");
						object obj3 = 0;
						return name == (string)obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+B8]");
					object obj5 = 0;
					return name == (string)obj5;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ValidateOnSpriteName>b__28_0(Graphic g)
		{
			//IL_00ee: Expected I4, but got O
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_00c5: Expected O, but got I
			//IL_008d: Expected O, but got I
			if ((object)g != null)
			{
				GameObject gameObject = g.gameObject;
				if ((object)gameObject != null)
				{
					object obj = typeof(DataRelation) + 2320;
					string name = gameObject.name;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+B8]");
						object obj3 = 0;
						return name == (string)obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+B8]");
					object obj5 = 0;
					return name == (string)obj5;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static readonly string OnSpriteName;

	private bool rightToLeft;

	private bool isPagination;

	private float animationDuration;

	private AnimationType animationType;

	private int currentProgress;

	private int maxProgress;

	private GameObject stepTemplate;

	private GameObject bordersContainer;

	private LayoutGroup parent;

	private readonly List<Graphic> steps;

	private bool _manualInit;

	public int CurrentProgress
	{
		get
		{
			return currentProgress;
		}
		set
		{
			currentProgress = value;
			UpdateProgress();
		}
	}

	public int MaxProgress
	{
		get
		{
			return maxProgress;
		}
		set
		{
			if (value != maxProgress)
			{
				maxProgress = value;
				InitComponent();
			}
		}
	}

	private void Start()
	{
		if (!_manualInit)
		{
			InitComponent();
		}
	}

	public void ManualInit()
	{
		InitComponent();
	}

	private void InitComponent()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0157: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I
		//IL_021c: Expected I4, but got O
		//IL_0101: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_02a7: Expected O, but got I4
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_04fb: Expected O, but got I
		//IL_0507: Expected O, but got I
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0527: Expected O, but got I
		//IL_0533: Expected O, but got I
		//IL_053c: Expected O, but got I4
		//IL_0545: Expected O, but got I4
		//IL_0610: Expected O, but got I4
		//IL_09ee: Expected O, but got I4
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected O, but got Unknown
		//IL_0a1b: Expected O, but got I4
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected I4, but got Unknown
		//IL_0a97: Expected O, but got I4
		//IL_070a: Expected O, but got I
		//IL_071a: Expected O, but got I
		//IL_073c: Expected O, but got I4
		//IL_06a3: Expected O, but got I
		//IL_06b3: Expected O, but got I
		//IL_06d5: Expected O, but got I4
		//IL_0999: Expected F4, but got I4
		//IL_09cd: Expected O, but got I4
		//IL_076c: Expected O, but got I4
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected O, but got Unknown
		//IL_0bdf: Expected O, but got I
		//IL_0bf0: Expected I, but got O
		//IL_0c0e: Expected O, but got I
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_07be: Expected O, but got I4
		//IL_079c: Expected O, but got I
		//IL_0842: Expected O, but got I4
		//IL_055a: Expected O, but got I
		//IL_056a: Expected O, but got I
		//IL_057a: Expected O, but got I
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected O, but got Unknown
		//IL_0b05: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A9D]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 72;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v78+E4]");
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
			obj4 = this + 72;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v78+E4]");
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
		int num = 0;
		obj4 = obj8;
		if (obj10 != null)
		{
			goto IL_00db;
		}
		goto IL_01ca;
		IL_0b5e:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_08d3:
		if ((object)stepTemplate != null)
		{
			stepTemplate.SetActive(value: false);
			if (rightToLeft)
			{
				if (steps == null)
				{
					goto IL_0b5e;
				}
				((List<object>)(object)steps).Reverse();
			}
			List<object> list = (List<object>)(object)steps;
			if (steps != null)
			{
				int num2 = 0;
				while (true)
				{
					if (num2 >= list._size)
					{
						return;
					}
					object obj11 = num2 + 1;
					object obj12 = obj11 - currentProgress;
					bool flag5 = obj12 == null;
					object obj13 = num2 - currentProgress;
					bool flag6 = (nint)obj13 < 0;
					int num3 = num2 ^ currentProgress;
					int num4 = num2 ^ obj13;
					int num5 = num3 & num4;
					bool flag7 = num5 < 0;
					bool flag8 = flag6 == flag7;
					bool flag9 = !flag8;
					bool flag10 = !isPagination;
					object obj14 = !flag10;
					object obj15 = ~obj14;
					bool flag11 = ((obj15 != null) ? flag9 : flag5);
					object obj16 = list.get_Item(num2);
					if (animationType == AnimationType.Fade)
					{
						UIExtensions.SetAlpha((Graphic)obj16, flag11 ? 1 : 0);
						list = (List<object>)(object)steps;
						num2++;
						bool flag12 = steps == null;
						object obj17 = !flag12;
						if (obj17 == null)
						{
							break;
						}
						continue;
					}
					if (obj16 == null)
					{
						break;
					}
					RectTransform rectTransform = ((Graphic)obj16).rectTransform;
					if ((object)rectTransform == null)
					{
						break;
					}
					rectTransform.localScale = (Vector3)0;
					list = (List<object>)(object)steps;
					num2++;
					if (steps == null)
					{
						break;
					}
				}
			}
		}
		goto IL_0b5e;
		IL_04a1:
		if ((object)stepTemplate != null)
		{
			stepTemplate.SetActive(value: true);
			if (maxProgress < 1)
			{
				goto IL_08d3;
			}
			object obj18 = (nint)0 + (nint)920;
			object obj19 = (nint)0 + (nint)1672;
			object obj20 = typeof(DebugUI.BitField) + 840;
			object obj21 = (nint)0 + (nint)144;
			object obj22 = (nint)0 + (nint)3016;
			object obj23 = 0;
			object obj24 = 0;
			object obj28 = default(object);
			IEnumerable<object> source = default(IEnumerable<object>);
			Func<object, bool> func = default(Func<object, bool>);
			while ((object)parent != null)
			{
				Transform transform = parent.transform;
				object obj25 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v31+E4]");
				bool flag13 = (nint)0 == 0;
				object obj26 = !flag13;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj27 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				if (obj28 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33B8C");
				object obj29 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v44+E4]");
				object obj30;
				Func<object, bool> predicate;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v44+B8]");
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v34+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v34+8]");
					bool flag14 = (nint)0 == 0;
					object obj31 = !flag14;
					if (obj31 == null)
					{
						goto IL_074a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj29 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v44+B8]");
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v34+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v34+8]");
					bool flag15 = (nint)0 == 0;
					object obj32 = !flag15;
					if (obj32 == null)
					{
						goto IL_074a;
					}
				}
				goto IL_0b73;
				IL_0b73:
				obj24 = obj21;
				object obj33 = Enumerable.First(source, predicate);
				List<object> list2 = (List<object>)(object)steps;
				if (steps == null)
				{
					break;
				}
				object obj34 = obj22;
				int version = list2._version + 1;
				list2._version = version;
				object[] items = list2._items;
				if (list2._items == null)
				{
					break;
				}
				bool flag16 = list2._size < items.Length;
				object obj35 = !flag16;
				if (obj35 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v27+20]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v30+C0]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v31+70]");
					obj24 = 0;
					((List<object>)(object)steps).AddWithResize(obj33);
					obj23++;
					if ((nint)obj23 < maxProgress)
					{
						continue;
					}
				}
				else
				{
					int size = list2._size + 1;
					list2._size = size;
					object obj38 = list2._items + list2._size;
					object obj39 = obj38 + 32;
					obj39 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj23++;
					if ((nint)obj23 < maxProgress)
					{
						continue;
					}
				}
				goto IL_08d3;
				IL_074a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v44+E4]");
				bool flag17 = (nint)0 == 0;
				object obj40 = !flag17;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj41 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v40+B8]");
					obj30 = 0;
				}
				object obj42 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1424;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj43 = (nint)0 + (nint)2216;
				func..ctor(obj30, (IntPtr)obj43);
				object obj44 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v39+B8]");
				object obj45 = (nint)0 + (nint)8;
				obj45 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				obj27 = 0;
				predicate = func;
				goto IL_0b73;
			}
		}
		goto IL_0b5e;
		IL_00a0:
		bool flag18 = obj5;
		bool flag19 = !flag18;
		num = 0;
		obj8 = obj4;
		if (!flag19)
		{
			goto IL_00db;
		}
		goto IL_01ca;
		IL_01ca:
		object obj46 = (nint)0 + (nint)3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		LayoutGroup layoutGroup = default(LayoutGroup);
		parent = layoutGroup;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<Graphic> list3 = steps;
		bool flag20 = steps == null;
		num = (int)layoutGroup;
		obj4 = obj8;
		if (!flag20)
		{
			goto IL_0232;
		}
		goto IL_0b5e;
		IL_00db:
		list3 = steps;
		bool flag21 = steps == null;
		object obj47 = !flag21;
		if (obj47 != null)
		{
			goto IL_0232;
		}
		goto IL_0b5e;
		IL_0232:
		int version2 = list3._version + 1;
		list3._size = 0;
		list3._version = version2;
		if (list3._size >= 1)
		{
			Array.Clear(list3._items, 0, list3._size);
			object obj27 = 0;
			num = 0;
		}
		object obj48 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v7+E4]");
		bool flag22 = (nint)0 == 0;
		object obj49 = !flag22;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (bordersContainer != null)
		{
			if (obj4 != null)
			{
				Transform transform2 = ((Component)obj4).transform;
				object obj50 = typeof(TypeConverter<ushort, char>) + 2568;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				GameObject[] array = default(GameObject[]);
				if (array != null)
				{
					object obj51 = array + 32;
					obj51 = stepTemplate;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj52 = array + 40;
					obj52 = bordersContainer;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					UIExtensions.DestroyAllChildren(transform2, array);
					obj2 = typeof(MemberAchievementClanFeedData) + 2976;
					goto IL_04a1;
				}
			}
		}
		else if (obj4 != null)
		{
			Transform transform3 = ((Component)obj4).transform;
			object obj53 = typeof(TypeConverter<ushort, char>) + 2568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			GameObject[] array2 = default(GameObject[]);
			if (array2 != null)
			{
				object obj54 = array2 + 32;
				obj54 = stepTemplate;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				UIExtensions.DestroyAllChildren(transform3, array2);
				goto IL_04a1;
			}
		}
		goto IL_0b5e;
	}

	private void UpdateProgress()
	{
		//IL_0063: Expected O, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0090: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected I4, but got Unknown
		//IL_010c: Expected O, but got I4
		//IL_01e4: Expected F4, but got I4
		//IL_0199: Expected F4, but got I4
		List<object> list = (List<object>)(object)steps;
		for (int i = 0; i < list._size; i++)
		{
			object obj = i + 1;
			object obj2 = obj - currentProgress;
			bool flag = obj2 == null;
			object obj3 = i - currentProgress;
			bool flag2 = (nint)obj3 < 0;
			int num = i ^ currentProgress;
			int num2 = i ^ obj3;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag2 == flag3;
			bool flag5 = !flag4;
			bool flag6 = !isPagination;
			object obj4 = !flag6;
			object obj5 = ~obj4;
			bool flag7 = ((obj5 != null) ? flag5 : flag);
			object obj6 = list.get_Item(i);
			if (animationType != AnimationType.Fade)
			{
				Transform target = ((Component)obj6).transform;
				int num4 = ShortcutExtensions.DOKill(target);
				object obj7 = ((List<object>)(object)steps).get_Item(i);
				Transform target2 = ((Component)obj7).transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target2, flag7 ? 1 : 0, animationDuration);
			}
			else
			{
				int num5 = ShortcutExtensions.DOKill((Component)obj6);
				object target3 = ((List<object>)(object)steps).get_Item(i);
				TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade((Graphic)target3, flag7 ? 1 : 0, animationDuration);
			}
			list = (List<object>)(object)steps;
		}
	}

	private int GetAnimationTarget(int i)
	{
		//IL_000e: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_003b: Expected O, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected I4, but got Unknown
		//IL_00b7: Expected O, but got I4
		object obj = i + 1;
		object obj2 = obj - currentProgress;
		bool result = obj2 == null;
		object obj3 = i - currentProgress;
		bool flag = (nint)obj3 < 0;
		int num = i ^ currentProgress;
		int num2 = i ^ obj3;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		int result2 = ((!flag3) ? 1 : 0);
		bool flag4 = !isPagination;
		object obj4 = !flag4;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return result ? 1 : 0;
		}
		return result2;
	}

	public void Next()
	{
		int num = currentProgress + 1;
		currentProgress = num;
		UpdateProgress();
	}

	public void Previous()
	{
		int num = currentProgress - 1;
		currentProgress = num;
		UpdateProgress();
	}

	public void SetupNumberProgress(int inputNumber)
	{
		currentProgress = 1;
		maxProgress = inputNumber;
		UpdateProgress();
		InitComponent();
	}

	public void SetSprite(Sprite sprite)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_007d: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I
		//IL_020d: Expected I, but got O
		//IL_022b: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_0185: Expected O, but got I
		object obj = (nint)0 + (nint)1688;
		object obj2 = typeof(DebugUI.BitField) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33B8C");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v7+E4]");
		object obj4;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v7+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				goto IL_00a3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v7+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+10]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_00a3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v14+B8]");
			obj4 = 0;
		}
		object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)2224;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj4, (IntPtr)obj9);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v13+B8]");
		object obj11 = (nint)0 + (nint)16;
		obj11 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> source = default(IEnumerable<object>);
		object obj12 = Enumerable.First(source, func);
		bool flag3 = obj12 == null;
		object obj13 = !flag3;
		Image image = (Image)obj12;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c1;
		IL_00c1:
		image.sprite = sprite;
		return;
		IL_00a3:
		object obj14 = Enumerable.First(source, predicate);
		image = (Image)obj14;
		goto IL_00c1;
	}

	private static string ValidateOnSpriteName(GameObject step)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_0088: Expected O, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0249: Expected O, but got I4
		//IL_018d: Expected O, but got I4
		//IL_0319: Expected O, but got I
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02c3: Expected O, but got I
		//IL_02d4: Expected I, but got O
		//IL_02f2: Expected O, but got I
		//IL_01f5: Expected O, but got I4
		//IL_01bd: Expected O, but got I
		GameObject gameObject = default(GameObject);
		object obj4;
		Func<object, bool> func;
		IEnumerable<object> source = default(IEnumerable<object>);
		object obj14;
		Func<object, bool> func3;
		if ((object)gameObject != null)
		{
			object obj = (nint)0 + (nint)1672;
			object obj2 = typeof(DebugUI.BitField) + 840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33B8C");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+E4]");
			object obj5;
			object obj6;
			if ((nint)0 != 0)
			{
				obj4 = (nint)0 + (nint)2584;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v12+18]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v12+18]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_00b5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
				obj4 = (nint)0 + (nint)2584;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v12+18]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v12+18]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_00b5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v18+B8]");
				obj5 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2232;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj5, (IntPtr)obj11);
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v17+B8]");
			object obj13 = (nint)0 + (nint)24;
			obj13 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj14 = obj6;
			bool flag4 = Enumerable.Any(source, func2);
			bool flag5 = !flag4;
			object obj15 = !flag5;
			func3 = func2;
			if (obj15 != null)
			{
				goto IL_00f3;
			}
			goto IL_020b;
		}
		return (string)(object)new NullReferenceException();
		IL_00f3:
		return null;
		IL_020b:
		object obj16 = typeof(DataRelation) + 2320;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v7+B8]");
		object obj19 = 0;
		object obj20 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3608;
		object obj21 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2544;
		return (string)obj20 + (string)obj19 + (string)obj21;
		IL_00b5:
		obj14 = obj4;
		bool flag7 = Enumerable.Any(source, func);
		bool flag8 = !flag7;
		func3 = func;
		if (!flag8)
		{
			goto IL_00f3;
		}
		goto IL_020b;
	}

	public DiscreteProgressIndicator()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1264;
		rightToLeft = true;
		animationDuration = 0.2f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 80;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	static DiscreteProgressIndicator()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		object obj = "October" + 256;
		object obj2 = typeof(DataRelation) + 2320;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj4 = 0;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
