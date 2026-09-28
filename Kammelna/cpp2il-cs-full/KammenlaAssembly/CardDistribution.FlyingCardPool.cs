using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace CardDistribution;

public class FlyingCardPool : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Image> <>9__2_1;

		public static Action<Image> <>9__2_2;

		public static Action<Image> <>9__2_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Awake>b__2_1(Image card)
		{
			GameObject gameObject = card.gameObject;
			gameObject.SetActive(value: true);
		}

		internal void <Awake>b__2_2(Image card)
		{
			GameObject gameObject = card.gameObject;
			gameObject.SetActive(value: false);
		}

		internal void <Awake>b__2_3(Image card)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_0162: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F01]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = card != null;
			bool flag3 = !flag2;
			object obj5 = !flag3;
			object obj6 = 0;
			if (obj5 == null)
			{
				return;
			}
			goto IL_00a4;
			IL_00a4:
			GameObject gameObject = card.gameObject;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
			return;
			IL_0074:
			bool flag4 = card != null;
			bool flag5 = !flag4;
			obj6 = 0;
			if (!flag5)
			{
				goto IL_00a4;
			}
		}
	}

	private Image _flyingCardPrefab;

	private PooledObjectList<Image> _pool;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_058e: Expected I, but got O
		//IL_059c: Expected I, but got O
		//IL_02c1: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_02f3: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_03fc: Expected O, but got I
		//IL_040c: Expected O, but got I
		//IL_042e: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_00ef: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_0684: Expected O, but got I
		//IL_068c: Expected I, but got O
		//IL_069d: Expected I, but got O
		//IL_06bb: Expected O, but got I
		//IL_0486: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_03ac: Expected O, but got I4
		//IL_03bc: Expected I, but got O
		//IL_035b: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected O, but got Unknown
		//IL_06fc: Expected O, but got I
		//IL_0704: Expected I, but got O
		//IL_0715: Expected I, but got O
		//IL_0733: Expected O, but got I
		//IL_04e5: Expected O, but got I4
		//IL_04ee: Expected O, but got I4
		//IL_050f: Expected O, but got I4
		//IL_051f: Expected I, but got O
		//IL_04b6: Expected O, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_0233: Expected O, but got I4
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_05f3: Expected O, but got I
		//IL_05fb: Expected I, but got O
		//IL_060c: Expected I, but got O
		//IL_062a: Expected O, but got I
		//IL_064d: Expected O, but got I4
		//IL_0263: Expected O, but got I
		object obj = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2368;
		object obj2 = (nint)0 + (nint)1768;
		object obj3 = typeof(DebugUI.BitField) + 2920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj2;
		Func<object> func = default(Func<object>);
		func..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+E4]");
		object obj5;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v18+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v18+8]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v18+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v18+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0086;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v25+B8]");
			obj5 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)448;
		num = (nint)obj11;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj5, (IntPtr)obj11);
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v23+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj15 = 0;
		object obj16 = action2;
		action = action2;
		object obj17 = 0;
		object obj18 = action2;
		nint num2 = (nint)obj11;
		object obj19 = obj4;
		Action<object> action3 = action2;
		if (obj14 != null)
		{
			goto IL_00df;
		}
		goto IL_03da;
		IL_01a1:
		object obj20 = typeof(List<Tween>) + 3008;
		object obj21 = (nint)0 + (nint)3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v31+18]");
		Action<object> action4 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v31+18]");
		bool flag5 = (nint)0 == 0;
		object obj23 = !flag5;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj25 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v37+B8]");
				obj22 = 0;
			}
			object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)464;
			num = (nint)obj27;
			Action<object> action5 = default(Action<object>);
			action5..ctor(obj22, (IntPtr)obj27);
			object obj28 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v36+B8]");
			object obj29 = (nint)0 + (nint)24;
			obj29 = action5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action4 = action5;
			obj15 = 0;
			obj16 = action5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C3500");
		object obj30 = this + 40;
		object obj31 = default(object);
		obj30 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0464:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		object obj34;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v13+B8]");
			obj34 = 0;
		}
		object obj35 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj36 = (nint)0 + (nint)456;
		num = (nint)obj36;
		Action<object> action6 = default(Action<object>);
		action6..ctor(obj34, (IntPtr)obj36);
		object obj37 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v11+B8]");
		object obj38 = (nint)0 + (nint)16;
		obj38 = action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+E4]");
		bool flag8 = (nint)0 == 0;
		object obj39 = !flag8;
		obj15 = 0;
		obj16 = action6;
		action = action3;
		Action<object> action7 = action6;
		object obj40 = 0;
		object obj41 = action6;
		nint num3 = (nint)obj36;
		object obj42 = obj4;
		Action<object> action8 = action6;
		if (obj39 != null)
		{
			goto IL_01a1;
		}
		goto IL_053d;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+B8]");
		obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+10]");
		action7 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+10]");
		bool flag9 = (nint)0 == 0;
		obj17 = obj15;
		obj18 = obj16;
		num2 = num;
		object obj43 = obj4;
		action3 = action;
		if (!flag9)
		{
			goto IL_014c;
		}
		goto IL_0464;
		IL_014c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		obj40 = obj15;
		obj41 = obj16;
		num3 = num;
		obj42 = obj4;
		action3 = action;
		action8 = action7;
		if (!flag10)
		{
			goto IL_01a1;
		}
		goto IL_053d;
		IL_053d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj3;
		obj15 = obj40;
		obj16 = obj41;
		num = num3;
		action = action3;
		action7 = action8;
		goto IL_01a1;
		IL_0086:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+E4]");
		bool flag11 = (nint)0 == 0;
		obj15 = 0;
		obj16 = this;
		obj17 = 0;
		obj18 = this;
		num2 = num;
		obj19 = obj4;
		action3 = action;
		if (!flag11)
		{
			goto IL_00df;
		}
		goto IL_03da;
		IL_03da:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v31+B8]");
		obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+10]");
		action7 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+10]");
		bool flag12 = (nint)0 == 0;
		object obj44 = !flag12;
		obj15 = obj17;
		obj16 = obj18;
		num = num2;
		action = action3;
		obj43 = obj4;
		if (obj44 != null)
		{
			goto IL_014c;
		}
		goto IL_0464;
	}

	public Image Get(Sprite cardBackSprite, Transform coverCard)
	{
		//IL_0011: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		object obj = (nint)0 + (nint)3808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C364C");
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
		Image image = default(Image);
		image.sprite = cardBackSprite;
		image.color = (Color)0;
		if ((object)coverCard == null || coverCard == obj2)
		{
			Transform transform = image.transform;
			if ((object)transform == null || transform == obj2)
			{
				Transform transform2 = image.transform;
				transform2.SetParent(coverCard, worldPositionStays: false);
				Transform transform3 = image.transform;
				transform3.localPosition = (Vector3)0;
				Transform transform4 = image.transform;
				transform4.localRotation = (Quaternion)0;
				Transform transform5 = image.transform;
				transform5.localScale = (Vector3)0;
				Vector2 sizeDelta = ((RectTransform)coverCard).sizeDelta;
				((RectTransform)transform).sizeDelta = (Vector2)0;
				Vector2 pivot = ((RectTransform)coverCard).pivot;
				((RectTransform)transform).pivot = (Vector2)0;
				Transform transform6 = image.transform;
				Transform parent = base.transform;
				transform6.SetParent(parent, worldPositionStays: true);
				return image;
			}
			return (Image)(object)new InvalidCastException();
		}
		throw new InvalidCastException();
	}

	public void Return(Image card)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C36B4");
	}

	public void ReturnAll()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C3728");
	}

	private Image <Awake>b__2_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0077: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)552;
		Transform transform = base.transform;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		Image result = default(Image);
		return result;
	}
}
