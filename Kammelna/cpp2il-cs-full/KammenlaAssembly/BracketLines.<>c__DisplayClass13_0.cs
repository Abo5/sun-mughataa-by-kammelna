using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class BracketLines : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Slider> <>9__13_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <SliderSequence>b__13_2(Slider l)
		{
			Transform transform = l.m_FillRect.transform;
			Transform transform2 = l.transform;
			Transform parent = transform2.parent;
			transform.SetParent(parent);
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public BracketLines <>4__this;

		public Slider[] lines;

		public bool topLine;

		public Slider midLine;

		internal void <SliderSequence>b__0()
		{
			Slider[] array = lines;
			if (lines != null && (object)array[1] != null)
			{
				Transform transform = array[1].transform;
				if ((object)<>4__this != null)
				{
					bool top = !topLine;
					((BracketLines)(object)transform).ChangeMidPoint(transform, add: true, top);
					if ((object)midLine != null)
					{
						Transform transform2 = midLine.transform;
						if ((object)<>4__this != null)
						{
							((BracketLines)(object)transform2).ChangeMidPoint(transform2, add: false, topLine);
							return;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}

		internal void <SliderSequence>b__1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected O, but got Unknown
			//IL_0281: Expected O, but got I
			//IL_0292: Expected I, but got O
			//IL_02b0: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E6C]");
			object obj3 = (nint)0 & (nint)1;
			Slider[] array;
			Slider[] array2;
			object obj4;
			if (obj3 != null)
			{
				array = lines;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				array2 = lines;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				array = lines;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				array2 = lines;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
			Action<object> action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = array2;
			object obj10 = obj7;
			IEnumerable<object> enumeration = array2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1816;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			action = action2;
			enumeration = enumerable;
			goto IL_0249;
			IL_0249:
			ArraysExtensions.ForEach(enumeration, action);
			return;
			IL_0099:
			obj10 = (nint)0 + (nint)2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			enumeration = array;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = array;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	private const float PathWeight = 0.6f;

	private const float Speed = 500f;

	private const float PathSpeed = 0.002f;

	private static readonly Color MyLightColor;

	private static readonly Color WinnerLightColor;

	private Vector2 _midPoint;

	private GameObject _linePrefab;

	private Transform _bracketArea;

	public void DrawLines(GameObject linePrefab, Transform bracketArea, float lineThickness)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		Vector2 offsetMin = rectTransform.offsetMin;
		Vector2 offsetMax = rectTransform.offsetMax;
		Vector2 offsetMin2 = rectTransform.offsetMin;
		Vector2 offsetMin3 = rectTransform.offsetMin;
		Vector2 offsetMax2 = rectTransform.offsetMax;
		float num = lineThickness - lineThickness;
		float num2 = num * 1.0586423E+09f;
		object obj = this + 48;
		obj = bracketArea;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 40;
		obj2 = linePrefab;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Vector2 offsetMin4 = rectTransform.offsetMin;
		Vector2 offsetMax3 = rectTransform.offsetMax;
		Vector2 offsetMax4 = rectTransform.offsetMax;
		DrawRect((Vector2)0, (Vector2)bracketArea);
		Vector2 offsetMin5 = rectTransform.offsetMin;
		Vector2 offsetMin6 = rectTransform.offsetMin;
		Vector2 offsetMin7 = rectTransform.offsetMin;
		DrawRect((Vector2)0, (Vector2)bracketArea);
		Vector2 offsetMax5 = rectTransform.offsetMax;
		DrawRect((Vector2)0, (Vector2)bracketArea);
		Vector2 offsetMin8 = rectTransform.offsetMin;
		DrawRect((Vector2)0, (Vector2)bracketArea);
		Vector2 offsetMax6 = rectTransform.offsetMax;
		DrawRect((Vector2)0, (Vector2)bracketArea);
	}

	private Vector2 GetMidPoint(RectTransform rect)
	{
		if ((object)rect != null)
		{
			Vector2 offsetMin = rect.offsetMin;
			Vector2 offsetMax = rect.offsetMax;
			Vector2 offsetMin2 = rect.offsetMin;
			Vector2 offsetMin3 = rect.offsetMin;
			return rect.offsetMax;
		}
		return (Vector2)new NullReferenceException();
	}

	private void DrawRect(Vector2 pointA, Vector2 pointB)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_020d: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E65]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)544;
			GameObject linePrefab = _linePrefab;
			Transform bracketArea = _bracketArea;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			Transform bracketArea2 = _bracketArea;
			object obj6 = obj4;
			GameObject linePrefab2 = _linePrefab;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)544;
			GameObject linePrefab = _linePrefab;
			Transform bracketArea = _bracketArea;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Transform bracketArea2 = _bracketArea;
			object obj6 = obj4;
			GameObject linePrefab2 = _linePrefab;
			if (obj7 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject = default(GameObject);
		if ((object)gameObject != null)
		{
			goto IL_01a2;
		}
		goto IL_026c;
		IL_026c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_027a;
		IL_027a:
		throw new InvalidCastException();
		IL_01a2:
		Transform transform = gameObject.transform;
		if ((object)transform != null)
		{
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			if (transform != obj8)
			{
				goto IL_027a;
			}
			((RectTransform)transform).offsetMin = (Vector2)0;
			((RectTransform)transform).offsetMax = (Vector2)0;
			Transform transform2 = transform.transform;
			Transform parent = base.transform;
			if ((object)transform2 != null)
			{
				transform2.SetParent(parent, worldPositionStays: false);
				return;
			}
		}
		goto IL_026c;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		bool flag3 = (object)gameObject == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_01a2;
		}
		goto IL_026c;
	}

	private void ChangeMidPoint(Transform rect, bool add, bool top)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		RectTransform rectTransform = UIExtensions.rectTransform(rect);
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect2 = rectTransform.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = !add;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
		}
		RectTransform rectTransform2 = UIExtensions.rectTransform(rect);
		RectTransform rectTransform3 = UIExtensions.rectTransform(rect);
		Rect rect3 = rectTransform3.rect;
		RectTransform rectTransform4 = UIExtensions.rectTransform(rect);
		Rect rect4 = rectTransform4.rect;
		rectTransform2.sizeDelta = (Vector2)0;
		RectTransform rectTransform5 = UIExtensions.rectTransform(rect);
		Vector3 position = rectTransform5.position;
		RectTransform rectTransform6 = UIExtensions.rectTransform(rect);
		Vector3 position2 = rectTransform6.position;
		RectTransform rectTransform7 = UIExtensions.rectTransform(rect);
		Vector3 position3 = rectTransform7.position;
		bool flag3 = !top;
		object obj6 = !flag3;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		rect.position = (Vector3)0;
	}

	public Sequence AnimateSlider(bool isMe, bool topLine, Sequence sequence)
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		//IL_016b: Expected I, but got O
		//IL_017b: Expected O, but got I
		//IL_01a4: Expected O, but got I
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I
		//IL_0223: Expected O, but got I4
		//IL_0239: Expected O, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_026e: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_0314: Expected O, but got I8
		//IL_02b9: Expected I, but got O
		//IL_02c9: Expected O, but got I
		//IL_02f2: Expected O, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_0383: Expected O, but got I4
		//IL_0399: Expected O, but got I
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03ce: Expected O, but got I
		//IL_0403: Expected O, but got I
		//IL_047c: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_0419: Expected I, but got O
		//IL_0429: Expected O, but got I
		//IL_0452: Expected O, but got I
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_04e5: Expected O, but got I
		//IL_0518: Expected O, but got I8
		//IL_0530: Expected O, but got I4
		//IL_057b: Expected O, but got I4
		//IL_0591: Expected I, but got O
		//IL_05a1: Expected O, but got I
		//IL_05ca: Expected O, but got I
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_061d: Expected O, but got I
		//IL_0641: Expected O, but got I8
		//IL_0660: Expected O, but got I
		//IL_0695: Expected O, but got I
		//IL_0706: Expected O, but got I8
		//IL_06ab: Expected I, but got O
		//IL_06bb: Expected O, but got I
		//IL_06e4: Expected O, but got I
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_0749: Expected O, but got I
		//IL_0775: Expected O, but got I4
		//IL_078b: Expected O, but got I
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
		//IL_07c0: Expected O, but got I
		//IL_07f5: Expected O, but got I
		//IL_086e: Expected O, but got I4
		//IL_087e: Expected O, but got I4
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_080b: Expected I, but got O
		//IL_081b: Expected O, but got I
		//IL_0844: Expected O, but got I
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected O, but got Unknown
		//IL_08d7: Expected O, but got I
		//IL_0979: Expected O, but got I8
		//IL_0998: Expected O, but got I
		//IL_0912: Expected O, but got I8
		//IL_0931: Expected O, but got I
		//IL_0950: Expected O, but got I4
		object obj = (nint)0 + (nint)728;
		object obj2 = (nint)0 + (nint)2760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		if (ArraysExtensions.IsNullOrEmpty(enumerable))
		{
			return null;
		}
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3368;
		object obj4 = typeof(TypeConverter<ushort, char>) + 3928;
		object obj5 = obj3;
		if (isMe)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (enumerable != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			bool flag3 = (nint)0 == 0;
			object obj8 = 3;
			if (!flag3)
			{
				Slider[] array = default(Slider[]);
				if (array == null)
				{
					goto IL_09ee;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+20]");
				bool flag4 = (nint)0 == 0;
				object obj9 = 3;
				if (!flag4)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v34 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v34 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
					obj8 = 0;
					if (flag5)
					{
						goto IL_09d6;
					}
				}
				bool flag6 = array.Length == 0;
				obj8 = obj9;
				if (!flag6)
				{
					object obj10 = array + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+20]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					bool flag7 = (nint)0 < (nint)2;
					object obj11 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					object obj12 = -2;
					bool flag8 = obj12 == null;
					object obj13 = ~obj11;
					object obj14 = obj13 | flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+20]");
					obj8 = 0;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+30]");
						bool flag9 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+20]");
						object obj15 = 0;
						if (!flag9)
						{
							nint num2 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v33 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v33 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
							obj8 = 0;
							if (flag10)
							{
								goto IL_09d6;
							}
						}
						object obj16 = array.Length & 0xFFFFFFFEL;
						bool flag11 = obj16 == null;
						obj8 = obj15;
						if (!flag11)
						{
							object obj17 = array + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+30]");
							obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
							bool flag12 = (nint)0 < (nint)4;
							object obj18 = !flag12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
							object obj19 = -4;
							bool flag13 = obj19 == null;
							object obj20 = ~obj18;
							object obj21 = obj20 | flag13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+30]");
							obj8 = 0;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+40]");
								bool flag14 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+30]");
								object obj22 = 0;
								if (!flag14)
								{
									nint num3 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v32 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
									obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag15 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v32 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
									obj8 = 0;
									if (flag15)
									{
										goto IL_09d6;
									}
								}
								bool flag16 = array.Length < 2;
								object obj23 = !flag16;
								object obj24 = array.Length - 2;
								bool flag17 = obj24 == null;
								object obj25 = ~obj23;
								object obj26 = obj25 | flag17;
								obj8 = obj22;
								if (obj26 == null)
								{
									object obj27 = array + 48;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+40]");
									obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
									object obj28 = 0 & 0xFFFFFFFEL;
									bool flag18 = obj28 == null;
									obj8 = 3;
									if (!flag18)
									{
										Slider[] array2 = default(Slider[]);
										if (array2 == null)
										{
											goto IL_09ee;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+28]");
										bool flag19 = (nint)0 == 0;
										object obj29 = 3;
										if (!flag19)
										{
											nint num4 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v31 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
											obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag20 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v31 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
											obj8 = 0;
											if (flag20)
											{
												goto IL_09d6;
											}
										}
										bool flag21 = array2.Length == 0;
										obj8 = obj29;
										if (!flag21)
										{
											object obj30 = array2 + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+28]");
											obj30 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
											object obj31 = 0 & 0xFFFFFFFCL;
											bool flag22 = obj31 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+28]");
											obj8 = 0;
											if (!flag22)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
												bool flag23 = (nint)0 == 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+28]");
												object obj32 = 0;
												if (!flag23)
												{
													nint num5 = (nint)array2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v30 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
													obj32 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag24 = ex == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v30 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
													obj8 = 0;
													if (flag24)
													{
														goto IL_09d6;
													}
												}
												object obj33 = array2.Length & 0xFFFFFFFEL;
												bool flag25 = obj33 == null;
												obj8 = obj32;
												if (!flag25)
												{
													object obj34 = array2 + 40;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
													obj34 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
													bool flag26 = (nint)0 < (nint)4;
													object obj35 = !flag26;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
													object obj36 = -4;
													bool flag27 = obj36 == null;
													object obj37 = ~obj35;
													object obj38 = obj37 | flag27;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
													obj8 = 0;
													if (obj38 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+40]");
														bool flag28 = (nint)0 == 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+38]");
														object obj39 = 0;
														if (!flag28)
														{
															nint num6 = (nint)array2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v29 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
															obj39 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
															bool flag29 = ex == null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v29 (Il2CppClass<UnityEngine.UI.Slider[]>)+40]");
															obj8 = 0;
															if (flag29)
															{
																goto IL_09d6;
															}
														}
														bool flag30 = array2.Length < 2;
														object obj40 = !flag30;
														object obj41 = array2.Length - 2;
														bool flag31 = obj41 == null;
														object obj42 = ~obj40;
														object obj43 = obj42 | flag31;
														obj8 = obj39;
														if (obj43 == null)
														{
															object obj44 = array2 + 48;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+40]");
															obj44 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															Color color;
															Slider midLine;
															Slider[] lines;
															Sequence sequence2;
															if (topLine)
															{
																object obj45 = array2.Length & 0xFFFFFFFEL;
																bool flag32 = obj45 == null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+40]");
																obj8 = 0;
																if (flag32)
																{
																	goto IL_09c8;
																}
																color = (Color)obj34;
																midLine = (Slider)1;
																lines = array;
																sequence2 = sequence;
															}
															else
															{
																object obj46 = array.Length & 0xFFFFFFFEL;
																bool flag33 = obj46 == null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+40]");
																obj8 = 0;
																if (flag33)
																{
																	goto IL_09c8;
																}
																color = (Color)obj17;
																midLine = null;
																lines = array2;
																sequence2 = sequence;
															}
															bool topLine2 = default(bool);
															return SliderSequence(sequence2, lines, color, midLine, topLine2);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_09c8;
		}
		goto IL_09ee;
		IL_09c8:
		ex = new IndexOutOfRangeException();
		goto IL_09d6;
		IL_09d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_09ee;
		IL_09ee:
		return (Sequence)(object)new NullReferenceException();
	}

	private Sequence SliderSequence(Sequence sequence, Slider[] lines, Color color, Slider midLine, bool topLine)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I8
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0137: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_0595: Expected O, but got I
		//IL_05b0: Expected I, but got O
		//IL_01b3: Expected O, but got I
		//IL_020e: Expected O, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024f: Expected O, but got I
		//IL_0286: Expected O, but got I4
		//IL_05e8: Expected O, but got I
		//IL_02e2: Expected O, but got I8
		//IL_0310: Expected O, but got I
		//IL_0371: Expected O, but got I
		//IL_03e1: Expected O, but got I4
		//IL_03f7: Expected O, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_043b: Expected O, but got I
		//IL_0468: Expected O, but got I
		//IL_0474: Expected O, but got I
		//IL_04b4: Expected O, but got I
		//IL_04f8: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = lines;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 40;
			obj5 = color;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			BracketLines bracketLines = default(BracketLines);
			bracketLines.ChangeLinesColor((Slider[])obj4, (Color)lines);
			object obj6 = obj4;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v5+18]");
				object obj7 = 0 & 0xFFFFFFFEL;
				if (obj7 == null)
				{
					goto IL_0542;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v5+28]");
				if ((nint)0 != 0)
				{
					object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
					object obj9 = (nint)0 + (nint)1824;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3 (System.Object)+20]");
					bool flag = (nint)0 == 0;
					object obj10 = !flag;
					object obj11 = ~obj10;
					Slider.Direction direction = ((obj11 != null) ? Slider.Direction.BottomToTop : Slider.Direction.TopToBottom);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v5+28]");
					((Slider)0).direction = direction;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					TweenCallback tweenCallback = default(TweenCallback);
					tweenCallback..ctor(obj2, (IntPtr)obj9);
					Sequence s = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3 (System.Object)+18]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3 (System.Object)+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v8+18]");
						if ((nint)0 == 0)
						{
							goto IL_0542;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v8+20]");
						RectTransform rectTransform = UIExtensions.rectTransform((Component)0);
						if ((object)rectTransform != null)
						{
							object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
							object obj14 = (nint)0 + (nint)2864;
							Rect rect = rectTransform.rect;
							object obj15 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v24+E4]");
							bool flag2 = (nint)0 == 0;
							object obj16 = !flag2;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj17 = default(object);
							float duration = (float)obj17 * 990057100f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v8+20]");
							TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOValue((Slider)0, 1f, duration);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							Tween t = default(Tween);
							Sequence s2 = TweenSettingsExtensions.Append(s, t);
							object obj18 = obj4;
							if (obj4 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v12+18]");
								object obj19 = 0 & 0xFFFFFFFEL;
								if (obj19 == null)
								{
									goto IL_0542;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v12+28]");
								RectTransform rectTransform2 = UIExtensions.rectTransform((Component)0);
								if ((object)rectTransform2 != null)
								{
									Rect rect2 = rectTransform2.rect;
									object obj20 = default(object);
									float duration2 = (float)obj20 * 990057100f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v12+28]");
									TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOValue((Slider)0, 1f, duration2);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
									Tween t2 = default(Tween);
									Sequence s3 = TweenSettingsExtensions.Append(s2, t2);
									object obj21 = obj4;
									if (obj4 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v15+18]");
										bool flag3 = (nint)0 < (nint)2;
										object obj22 = !flag3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v15+18]");
										object obj23 = -2;
										bool flag4 = obj23 == null;
										object obj24 = ~obj22;
										object obj25 = obj24 | flag4;
										if (obj25 != null)
										{
											goto IL_0542;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v15+30]");
										RectTransform rectTransform3 = UIExtensions.rectTransform((Component)0);
										if ((object)rectTransform3 != null)
										{
											object obj26 = (nint)0 + (nint)1832;
											object obj27 = (nint)0 + (nint)2912;
											Rect rect3 = rectTransform3.rect;
											float duration3 = (float)obj17 * 990057100f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v15+30]");
											TweenerCore<float, float, FloatOptions> tweenerCore3 = DOTweenModuleUI.DOValue((Slider)0, 1f, duration3);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
											Tween t3 = default(Tween);
											Sequence s4 = TweenSettingsExtensions.Append(s3, t3);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											TweenCallback tweenCallback2 = default(TweenCallback);
											tweenCallback2..ctor(obj2, (IntPtr)obj26);
											Sequence s5 = TweenSettingsExtensions.AppendCallback(s4, tweenCallback2);
											Sequence sequence2 = TweenSettingsExtensions.AppendInterval(s5, 0.2f);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
											Sequence result = default(Sequence);
											return result;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0542;
		IL_0542:
		return (Sequence)(object)new IndexOutOfRangeException();
	}

	private void ChangeLinesColor(Slider[] lines, Color color)
	{
		//IL_0030: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_005d: Expected O, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		if (lines.Length >= 1)
		{
			object obj = (nint)0 + (nint)1312;
			object obj2 = lines + 32;
			object obj3 = 0;
			object obj6 = default(object);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X22_v4+v126 @ X20_v6*8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v7+100]");
				GameObject gameObject = ((Component)0).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				obj3++;
				object obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ X8_v8+2A8] (should have been resolved before IL gen)");
			}
			while ((nint)obj3 < lines.Length);
		}
	}

	static BracketLines()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3368;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E50]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252E60]");
		_ = 0;
	}
}
