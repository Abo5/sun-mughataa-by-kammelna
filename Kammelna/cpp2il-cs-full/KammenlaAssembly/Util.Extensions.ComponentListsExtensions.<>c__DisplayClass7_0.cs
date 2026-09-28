using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Util.Extensions;

public static class ComponentListsExtensions
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Component> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2056;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Destroy>b__4_0(Component component)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = component.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public bool active;

		internal void <SetActive>b__0(GameObject go)
		{
			go.SetActive(active);
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public bool isWorldPositions;

		public float? x;

		public float? y;

		public float? z;

		internal void <MoveTo>b__0(GameObject go)
		{
			Transform transform = go.transform;
			UIExtensions.MoveTo(transform, isWorldPositions, x, y, z);
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public bool active;

		internal void <SetActive>b__0(Component c)
		{
			GameObject gameObject = c.gameObject;
			gameObject.SetActive(active);
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public bool isWorldPositions;

		public float? x;

		public float? y;

		public float? z;

		internal void <MoveTo>b__0(Component component)
		{
			Transform transform = component.transform;
			UIExtensions.MoveTo(transform, isWorldPositions, x, y, z);
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public UnityAction callback;

		internal void <AddClickListeners>b__0(Button b)
		{
			b.m_OnClick.AddListener(callback);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public float alpha;

		internal void <SetAlpha>b__0(Graphic i)
		{
			UIExtensions.SetAlpha(i, alpha);
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public string text;

		internal void <FixArabic>b__0(TextMeshProUGUI tm)
		{
			TextMeshProExtensions.FixArabic(tm, text);
		}
	}

	public static void SetActive(IEnumerable<GameObject> gameObjects, bool active)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj4 = (nint)0 + (nint)1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(gameObjects, action);
	}

	public static void Destroy(IEnumerable<GameObject> gameObjects)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(gameObjects, action);
	}

	public static void MoveTo(IEnumerable<GameObject> gameObjects, bool isWorldPositions = false, float? x = null, float? y = null, float? z = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0069: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj4 = (nint)0 + (nint)1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(gameObjects, action);
	}

	public static void SetActive(IEnumerable<Component> components, bool active)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1696;
		object obj4 = (nint)0 + (nint)1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(components, action);
	}

	public static void Destroy(IEnumerable<Component> components)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		//IL_024a: Expected I, but got O
		//IL_0268: Expected O, but got I
		//IL_01fc: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 2056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E872A]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1288;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		action = action2;
		goto IL_0201;
		IL_0201:
		ArraysExtensions.ForEach(components, action);
		return;
		IL_0085:
		obj10 = (nint)0 + (nint)2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}

	public static void MoveTo(IEnumerable<Component> components, bool isWorldPositions = false, float? x = null, float? y = null, float? z = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0069: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1696;
		object obj4 = (nint)0 + (nint)1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(components, action);
	}

	public static void AddClickListeners(IEnumerable<Button> buttons, UnityAction callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj4 = (nint)0 + (nint)1328;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(buttons, action);
	}

	public static void SetAlpha(IEnumerable<Graphic> images, float alpha)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj4 = (nint)0 + (nint)1336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(images, action);
	}

	public static void FixArabic(IEnumerable<TextMeshProUGUI> textMeshes, string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		object obj4 = (nint)0 + (nint)1344;
		object obj5 = obj2 + 16;
		obj5 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(textMeshes, action);
	}
}
