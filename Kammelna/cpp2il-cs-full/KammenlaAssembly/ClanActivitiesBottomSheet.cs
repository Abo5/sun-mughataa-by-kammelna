using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.UI;

public class ClanActivitiesBottomSheet : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<bool, bool> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_ActivitiesAvailable>b__8_0(bool v)
		{
			return v;
		}
	}

	private Button Announcement;

	private Button Vote;

	private Button Play;

	private Button Gift;

	private Dictionary<Button, bool> _availability;

	private Dictionary<Button, bool> Availability
	{
		get
		{
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0048: Expected O, but got I4
			//IL_0071: Expected O, but got I
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			//IL_012f: Expected O, but got I
			object obj = this + 64;
			if (obj != null)
			{
				return (Dictionary<Button, bool>)obj;
			}
			object obj2 = typeof(Queue<string>) + 728;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = (nint)0 + (nint)1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			if ((object)clanServerConnector != null)
			{
				ClanUserModel myMembership = clanServerConnector.GetMyMembership();
				if (myMembership != null)
				{
					bool value = ClanPermissionsExtensions.Can(myMembership.Permissions, ClanPermissions.ManageActivities);
					object obj6 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 424;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Dictionary<object, bool> dictionary = default(Dictionary<object, bool>);
					dictionary..ctor();
					if (dictionary != null)
					{
						object obj7 = (nint)0 + (nint)1904;
						dictionary.Add(Announcement, value);
						dictionary.Add(Vote, value);
						dictionary.Add(Play, value: false);
						dictionary.Add(Gift, value: false);
						_availability = (Dictionary<Button, bool>)(object)dictionary;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return _availability;
					}
				}
				else
				{
					object obj8 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 424;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Dictionary<object, bool> dictionary2 = default(Dictionary<object, bool>);
					dictionary2..ctor();
					if (dictionary2 != null)
					{
						dictionary2.Add(Announcement, value: false);
						dictionary2.Add(Vote, value: false);
						dictionary2.Add(Play, value: false);
						dictionary2.Add(Gift, value: false);
						return (Dictionary<Button, bool>)(object)dictionary2;
					}
				}
			}
			return (Dictionary<Button, bool>)(object)new NullReferenceException();
		}
	}

	public bool ActivitiesAvailable
	{
		get
		{
			//IL_01b9: Expected I4, but got O
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_00e6: Expected O, but got I
			//IL_00f6: Expected O, but got I
			//IL_0106: Expected O, but got I
			//IL_0128: Expected O, but got I4
			//IL_006b: Expected O, but got I
			//IL_007b: Expected O, but got I
			//IL_008b: Expected O, but got I
			//IL_00ad: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_020a: Expected O, but got I
			//IL_021b: Expected I, but got O
			//IL_0239: Expected O, but got I
			//IL_0190: Expected O, but got I
			Dictionary<Button, bool> availability = Availability;
			object obj2;
			Dictionary<object, bool>.ValueCollection values;
			object obj5;
			Func<bool, bool> predicate;
			object obj7;
			object obj4;
			if (availability != null)
			{
				object obj = (nint)0 + (nint)1920;
				obj2 = typeof(CardUtils.<>c) + 480;
				values = ((Dictionary<object, bool>)(object)availability).Values;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					obj4 = (nint)0 + (nint)2472;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v9+B8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+8]");
					predicate = (Func<bool, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+8]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 == null)
					{
						obj7 = obj4;
						goto IL_013e;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
					obj7 = (nint)0 + (nint)2472;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v9+B8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+8]");
					predicate = (Func<bool, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+8]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					obj4 = obj7;
					if (obj8 == null)
					{
						goto IL_013e;
					}
				}
				goto IL_0195;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0195:
			return Enumerable.Any(values, predicate);
			IL_013e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v14+B8]");
				obj5 = 0;
			}
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3336;
			Func<bool, bool> func = default(Func<bool, bool>);
			func..ctor(obj5, (IntPtr)obj12);
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v13+B8]");
			object obj14 = (nint)0 + (nint)8;
			obj14 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = obj7;
			predicate = func;
			goto IL_0195;
		}
	}

	public void Init()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_005c: Expected I, but got O
		Dictionary<Button, bool> availability = Availability;
		object obj = (nint)0 + (nint)1912;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj3 = (nint)0 + (nint)704;
		Dictionary<object, bool>.KeyCollection keys = ((Dictionary<object, bool>)(object)availability).Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		ArraysExtensions.ForEach(keys, action);
	}

	private void <Init>b__9_0(Button b)
	{
		GameObject gameObject = b.gameObject;
		Dictionary<Button, bool> availability = Availability;
		bool active = DictionaryExtensions.Get((IDictionary<object, bool>)availability, b, defaultValue: false);
		gameObject.SetActive(active);
	}
}
