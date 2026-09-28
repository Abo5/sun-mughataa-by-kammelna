using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using ListView;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;

public class FriendInviteListView : UiListView<FriendInviteDataHolder, InvitePanelStrip>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, bool> <>9__4_1;

		public static Func<FriendProfile, string> <>9__4_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SetFriendInviteStrips>b__4_1(FriendProfile f)
		{
			//IL_0035: Expected I4, but got O
			if (f != null)
			{
				return f.IsOnline;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal string <SetFriendInviteStrips>b__4_2(FriendProfile f)
		{
			if (f != null)
			{
				return f.UserName;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public string filter;

		internal bool <SetFriendInviteStrips>b__0(FriendProfile f)
		{
			//IL_008b: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (f != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return StringsExtensions.ContainsIgnoreCase(f.UserName, filter);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private Action<FriendInviteDataHolder> m_InviteRequested;

	public event Action<FriendInviteDataHolder> InviteRequested
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2016;
			Delegate obj2 = this.m_InviteRequested;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2016;
			Delegate obj2 = this.m_InviteRequested;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
	}

	public void RaiseInviteRequested(FriendInviteDataHolder d)
	{
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		Action<FriendInviteDataHolder> inviteRequested = this.InviteRequested;
		if (this.InviteRequested != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<FriendInviteDataHolder>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<FriendInviteDataHolder>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<FriendInviteDataHolder>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public unsafe void SetFriendInviteStrips(string filter = "", bool reload = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected I4, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_0057: Expected I, but got O
		//IL_0067: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_03d8: Expected O, but got I
		//IL_03e8: Expected O, but got I
		//IL_040a: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_026a: Expected O, but got I4
		//IL_084f: Expected O, but got I
		//IL_0358: Expected O, but got I
		//IL_0368: Expected O, but got I
		//IL_038a: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0137: Expected I4, but got O
		//IL_0528: Expected O, but got I
		//IL_0538: Expected O, but got I
		//IL_055a: Expected O, but got I4
		//IL_056a: Expected O, but got I
		//IL_0452: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_02d0: Expected I, but got O
		//IL_02dc: Expected O, but got I
		//IL_02e4: Expected I4, but got O
		//IL_02fa: Expected I, but got O
		//IL_00cc: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_0909: Expected O, but got I
		//IL_0911: Expected I4, but got O
		//IL_092e: Expected O, but got I
		//IL_095a: Expected I4, but got O
		//IL_04b1: Expected O, but got I
		//IL_04c1: Expected O, but got I
		//IL_04e3: Expected O, but got I4
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected O, but got Unknown
		//IL_08b7: Expected O, but got I
		//IL_08c8: Expected I, but got O
		//IL_08e6: Expected O, but got I
		//IL_03b0: Expected O, but got I
		//IL_059a: Expected O, but got I4
		//IL_048c: Expected I, but got O
		//IL_0482: Expected O, but got I
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected O, but got Unknown
		//IL_0992: Expected O, but got I
		//IL_09a3: Expected I, but got O
		//IL_09c1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_075e: Expected I, but got O
		//IL_076e: Expected O, but got I
		//IL_077e: Expected O, but got I
		//IL_05d4: Expected I, but got O
		//IL_05ca: Expected O, but got I
		//IL_063b: Expected I4, but got O
		//IL_07c5: Expected O, but got I
		//IL_07d3: Expected O, but got I4
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Expected O, but got Unknown
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Expected O, but got Unknown
		//IL_0a37: Expected O, but got I
		//IL_0a3f: Expected I4, but got O
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected O, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected O, but got Unknown
		//IL_0690: Expected I, but got O
		//IL_06a0: Expected O, but got I
		//IL_06c1: Expected I4, but got O
		//IL_06f0: Expected O, but got I4
		//IL_06f8: Expected I4, but got O
		object obj = typeof(DebugUI.BitField) + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		string text = null;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		IEnumerable<object> enumerable;
		object obj11;
		object obj13;
		Func<object, bool> keySelector;
		IEnumerable<object> source;
		nint num3;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = filter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (flag3)
			{
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v73 (Il2CppClass<FriendInviteListView>)+2A0]");
				text = (string)0;
				List<FriendInviteDataHolder> list = base.data;
				bool flag4 = list == null;
				flag2 = flag3;
				if (!flag4)
				{
					object obj4 = (nint)0 + (nint)1448;
					List<FriendInviteDataHolder> list2 = list;
					bool flag5 = false;
					bool flag6;
					do
					{
						if ((flag5 ? 1 : 0) < list2._size)
						{
							flag3 = (byte)(int)obj4 != 0;
							((ListViewItem<object, int>)GetListItem(flag5 ? 1 : 0))?.ForceRefresh();
							flag5 = (byte)((flag5 ? 1u : 0u) + 1u) != 0;
							nint num2 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v76 (Il2CppClass<FriendInviteListView>)+2A0]");
							text = (string)0;
							list2 = base.data;
							flag6 = list2 == null;
							flag2 = flag5;
							continue;
						}
						return;
					}
					while (!flag6);
				}
			}
			else
			{
				flag2 = (byte)(typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528) != 0;
				bool value = ((bool*)(flag2 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v29 (System.Boolean)+E4]");
				bool flag7 = (nint)0 == 0;
				object obj5 = !flag7;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerable<FriendProfile> friendsList = FriendsManager.FriendsList;
				object obj6 = obj3;
				bool flag8 = obj3 == null;
				text = filter;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v17+10]");
					bool flag9 = (nint)0 < (nint)1;
					Func<object, bool> func = (Func<object, bool>)(object)filter;
					enumerable = friendsList;
					if (!flag9)
					{
						bool value2 = ((bool*)(flag2 ? 1 : 0))->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v89 (System.Boolean)+E4]");
						bool flag10 = (nint)0 == 0;
						object obj7 = !flag10;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						IEnumerable<FriendProfile> friendsList2 = FriendsManager.FriendsList;
						object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj9 = (nint)0 + (nint)688;
						Func<object, bool> func2 = default(Func<object, bool>);
						func2..ctor(obj2, (IntPtr)obj9);
						object obj10 = (nint)0 + (nint)3432;
						flag3 = (byte)(int)obj10 != 0;
						enumerable = Enumerable.Where(friendsList2, func2);
						num3 = unchecked((nint)null);
						func = func2;
					}
					obj11 = typeof(DebugUI.BitField) + 3120;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v57+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v57+B8]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X9_v10+8]");
						keySelector = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X9_v10+8]");
						bool flag11 = (nint)0 == 0;
						object obj14 = !flag11;
						source = enumerable;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X9_v10+8]");
							Func<object, bool> func3 = (Func<object, bool>)0;
							goto IL_0430;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v57+B8]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X9_v10+8]");
						Func<object, bool> func3 = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X9_v10+8]");
						bool flag12 = (nint)0 == 0;
						object obj15 = !flag12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X9_v10+8]");
						keySelector = (Func<object, bool>)0;
						source = enumerable;
						if (obj15 == null)
						{
							goto IL_0430;
						}
					}
					goto IL_0843;
				}
			}
		}
		goto IL_0788;
		IL_08fd:
		object obj16 = (nint)0 + (nint)952;
		flag3 = (byte)(int)obj16 != 0;
		IOrderedEnumerable<object> orderedEnumerable;
		Func<object, object> keySelector2;
		IOrderedEnumerable<object> source2 = Enumerable.ThenBy(orderedEnumerable, keySelector2);
		object obj17 = (nint)0 + (nint)2080;
		text = (string)obj17;
		List<object> list3 = Enumerable.ToList(source2);
		bool flag13 = list3 == null;
		flag2 = (byte)(int)orderedEnumerable != 0;
		if (flag13)
		{
			goto IL_0788;
		}
		object obj18 = typeof(TypeConverter<ushort, char>) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v40 (System.Collections.Generic.List`1<System.Object>)+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_074b;
		}
		IEnumerable<object> enumerable2 = default(IEnumerable<object>);
		bool flag14 = enumerable2 == null;
		flag2 = (byte)(int)list3 != 0;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag14)
		{
			object obj19 = enumerable2 + 32;
			object obj20 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1384;
			object obj21 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 744;
			int num4 = 0;
			object obj24 = default(object);
			while (true)
			{
				object obj22 = (nint)0 + (nint)2344;
				flag3 = (byte)(int)obj22 != 0;
				object obj23 = list3.get_Item(num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj24..ctor();
				object obj25 = obj24 + 16;
				obj25 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj26 = obj24 + 40;
				obj26 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num5 = (nint)enumerable2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v42 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag15 = ex == null;
				flag2 = (byte)(int)list3 != 0;
				if (flag15)
				{
					break;
				}
				int num6 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v42 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				bool flag16 = (nint)num6 < (nint)0;
				object obj27 = !flag16;
				flag2 = (byte)(int)list3 != 0;
				if (obj27 == null)
				{
					obj19 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num4++;
					int num7 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v40 (System.Collections.Generic.List`1<System.Object>)+18]");
					if ((nint)num7 < (nint)0)
					{
						continue;
					}
					goto IL_074b;
				}
				goto IL_07ae;
			}
			goto IL_0796;
		}
		object obj28 = (nint)0 + (nint)2344;
		object obj29 = ((List<object>)flag2).get_Item(0);
		object obj30 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = default(object);
		obj31..ctor();
		object obj32 = obj31 + 16;
		obj32 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj33 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 744;
		object obj34 = obj31 + 40;
		obj34 = obj33;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		throw new NullReferenceException();
		IL_0796:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_07ae;
		IL_074b:
		List<object> list4 = Enumerable.ToList(enumerable2);
		nint num8 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v36 (Il2CppClass<FriendInviteListView>)+2A8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v36 (Il2CppClass<FriendInviteListView>)+2B0]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v379 @ X3_v8 (should have been resolved before IL gen)");
		goto IL_0788;
		IL_07ae:
		throw new IndexOutOfRangeException();
		IL_0843:
		object obj37 = (nint)0 + (nint)2408;
		orderedEnumerable = Enumerable.OrderByDescending(source, keySelector);
		object obj38 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v66+E4]");
		object obj39;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v66+B8]");
			obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v47+10]");
			keySelector2 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v47+10]");
			bool flag17 = (nint)0 == 0;
			object obj40 = !flag17;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v47+10]");
				Func<object, object> func4 = (Func<object, object>)0;
				goto IL_0578;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v66+B8]");
			obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v47+10]");
			Func<object, object> func4 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v47+10]");
			bool flag18 = (nint)0 == 0;
			object obj41 = !flag18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v47+10]");
			keySelector2 = (Func<object, object>)0;
			if (obj41 == null)
			{
				goto IL_0578;
			}
		}
		goto IL_08fd;
		IL_0430:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v57+E4]");
		bool flag19 = (nint)0 == 0;
		object obj42 = !flag19;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj43 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v64+B8]");
			obj13 = 0;
		}
		object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)672;
		Func<object, bool> func5 = default(Func<object, bool>);
		func5..ctor(obj13, (IntPtr)obj45);
		object obj46 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v63+B8]");
		object obj47 = (nint)0 + (nint)8;
		obj47 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num3 = unchecked((nint)null);
		keySelector = func5;
		source = enumerable;
		goto IL_0843;
		IL_0578:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v66+E4]");
		bool flag20 = (nint)0 == 0;
		object obj48 = !flag20;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj49 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v53+B8]");
			obj39 = 0;
		}
		object obj50 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = (nint)0 + (nint)680;
		Func<object, object> func6 = default(Func<object, object>);
		func6..ctor(obj39, (IntPtr)obj51);
		object obj52 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v52+B8]");
		object obj53 = (nint)0 + (nint)16;
		obj53 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num3 = unchecked((nint)null);
		keySelector2 = func6;
		goto IL_08fd;
		IL_0788:
		ex = new NullReferenceException();
		goto IL_0796;
	}

	public FriendInviteListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
