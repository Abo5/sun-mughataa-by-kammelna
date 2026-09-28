using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;

public class ClanMembersListView : UiListView<ClanMemberWrapper, ClanMemberStrip>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanUserModel, bool> <>9__2_0;

		public static Func<ClanUserModel, bool> <>9__2_1;

		public static Func<ClanMemberWrapper, int, ClanMemberWrapper> <>9__4_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Initialize>b__2_0(ClanUserModel u)
		{
			//IL_0035: Expected I4, but got O
			if (u != null)
			{
				return u.IsOwner;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <Initialize>b__2_1(ClanUserModel u)
		{
			//IL_003d: Expected I4, but got O
			if (u != null)
			{
				return u.IsAdmin;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal unsafe ClanMemberWrapper <RemoveMember>b__4_1(ClanMemberWrapper d, int i)
		{
			//IL_0023: Expected native int or pointer, but got O
			//IL_002d: Expected native int or pointer, but got O
			//IL_0062: Expected O, but got I4
			//IL_0072: Expected native int or pointer, but got O
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00b2: Expected O, but got I4
			string <template>k__BackingField = d.<template>k__BackingField;
			int stringLength = <template>k__BackingField._stringLength;
			ClanMemberWrapper clanMemberWrapper = default(ClanMemberWrapper);
			((ClanMemberWrapper*)(nint)clanMemberWrapper)-><index>k__BackingField = 0;
			System.Runtime.CompilerServices.Unsafe.Write(&((ClanMemberWrapper*)(nint)clanMemberWrapper)-><User>k__BackingField, null);
			if (<template>k__BackingField._stringLength != 0)
			{
				object obj = i + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (System.Int32)+14]");
				((ClanMemberWrapper*)(nint)clanMemberWrapper)-><index>k__BackingField = 0;
				object obj2 = clanMemberWrapper + 8;
				obj2 = <template>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = clanMemberWrapper + 16;
				obj3 = <template>k__BackingField._stringLength;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ClanMemberWrapper result = default(ClanMemberWrapper);
				return result;
			}
			return (ClanMemberWrapper)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public int userId;

		internal bool <RemoveMember>b__0(ClanMemberWrapper d)
		{
			//IL_0014: Expected O, but got I4
			object obj = d.<index>k__BackingField - userId;
			bool flag = obj == null;
			return !flag;
		}
	}

	private bool ShowOptions;

	private ClanMemberStrip myPlaceStrip;

	public void Initialize(IEnumerable<ClanUserModel> users)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_03a5: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03c6: Expected O, but got I
		//IL_03d9: Expected O, but got I
		//IL_03e9: Expected O, but got I
		//IL_040b: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_033a: Expected O, but got I
		//IL_034b: Expected I, but got O
		//IL_0369: Expected O, but got I
		//IL_0384: Expected O, but got I4
		//IL_026e: Expected I, but got O
		//IL_01fe: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_0443: Expected O, but got I
		//IL_0454: Expected I, but got O
		//IL_0472: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_02c8: Expected I, but got O
		//IL_02d8: Expected O, but got I
		//IL_02e8: Expected O, but got I
		if (users == null)
		{
			return;
		}
		object obj = typeof(CardUtils.<>c) + 1192;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v33+E4]");
		object obj4;
		Func<object, bool> keySelector;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2384;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v33+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v20+8]");
			keySelector = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v20+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0125;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2384;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v33+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v20+8]");
			keySelector = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v20+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0125;
			}
		}
		goto IL_017c;
		IL_017c:
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(users, keySelector);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		object obj10 = (nint)0 + (nint)1048;
		object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 704;
		object obj12 = (nint)0 + (nint)1416;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v8+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+10]");
		Func<object, bool> keySelector2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v11+10]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj21;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+B8]");
				obj13 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)368;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj13, (IntPtr)obj18);
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+B8]");
			object obj20 = (nint)0 + (nint)16;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = (nint)0 + (nint)1048;
			obj21 = 0;
			keySelector2 = func;
		}
		IOrderedEnumerable<object> source2 = Enumerable.ThenByDescending(source, keySelector2);
		List<object> list = Enumerable.ToList(source2);
		PopulateMyPlace((List<ClanUserModel>)(object)list);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, int, ClanMemberWrapper> func2 = default(Func<object, int, ClanMemberWrapper>);
		func2..ctor((object)this, (IntPtr)obj12);
		IEnumerable<ClanMemberWrapper> source3 = Enumerable.Select(list, func2);
		List<ClanMemberWrapper> list2 = Enumerable.ToList(source3);
		base.data = list2;
		if (((UiListView<ClanMemberWrapper, object>)(object)this).TemplatesReady)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v10 (Il2CppClass<ClanMembersListView>)+1B8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v10 (Il2CppClass<ClanMembersListView>)+1C0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v135 @ X2_v9 (should have been resolved before IL gen)");
		}
		return;
		IL_0125:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v33+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v26+B8]");
			obj4 = 0;
		}
		object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)360;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj4, (IntPtr)obj27);
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v25+B8]");
		object obj29 = (nint)0 + (nint)8;
		obj29 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj21 = 0;
		obj3 = obj6;
		keySelector = func3;
		goto IL_017c;
	}

	private unsafe void PopulateMyPlace(List<ClanUserModel> ordered)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_01a8: Expected I, but got O
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_025d: Expected I4, but got I8
		//IL_0277: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02cf: Expected O, but got I
		//IL_02f5: Expected O, but got I
		//IL_0350: Expected O, but got I
		//IL_037f: Expected O, but got I
		//IL_0397: Expected O, but got Ref
		//IL_03d9: Expected O, but got Ref
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87D4]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			obj5 = myPlaceStrip;
			obj6 = myPlaceStrip;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = myPlaceStrip;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = myPlaceStrip;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj11 = typeof(List<Tween>) + 3168;
		object obj12 = (nint)0 + (nint)1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)null, (IntPtr)obj12);
		if (ordered != null)
		{
			int num = ((List<object>)(object)ordered).FindIndex(predicate);
			if ((object)myPlaceStrip != null)
			{
				GameObject gameObject = myPlaceStrip.gameObject;
				if ((object)gameObject != null)
				{
					int num2 = ~num;
					bool active = (byte)(num2 >> 31) != 0;
					gameObject.SetActive(active);
					int num3 = (int)(num & 0x80000000L);
					bool flag5 = num3 == 0;
					object obj13 = !flag5;
					if (obj13 != null)
					{
						return;
					}
					if ((object)myPlaceStrip != null)
					{
						object obj14 = myPlaceStrip + 200;
						obj14 = this;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj15 = (nint)0 + (nint)3520;
						object obj16 = ((List<object>)(object)ordered).get_Item(num);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanMembersListView)+38]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanMembersListView)+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v12+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v12+20]");
								string text = ((UnityEngine.Object)0).name;
								if (obj16 != null)
								{
									object obj19 = default(object);
									object obj18 = (nint)(&obj19) | (nint)8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj19, 16));
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									if ((object)myPlaceStrip != null)
									{
										object obj21 = default(object);
										myPlaceStrip.Setup((ClanMemberWrapper)(&obj21), firstTime: true);
										((List<object>)(object)ordered).RemoveAt(num);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0091:
		bool flag6 = obj5 == null;
		bool flag7 = !flag6;
		obj9 = 0;
		obj10 = null;
		if (!flag7)
		{
			return;
		}
		goto IL_0170;
	}

	public void RemoveMember(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0063: Expected I, but got O
		//IL_0088: Expected I, but got O
		//IL_00c8: Expected O, but got I4
		//IL_01c0: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_016c: Expected I, but got O
		//IL_017c: Expected O, but got I
		//IL_018c: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022a: Expected O, but got I
		//IL_023b: Expected I, but got O
		//IL_0259: Expected O, but got I
		//IL_013f: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1200;
		object obj2 = default(object);
		Func<ClanMemberWrapper, bool> func = default(Func<ClanMemberWrapper, bool>);
		Func<ClanMemberWrapper, int, ClanMemberWrapper> func2 = default(Func<ClanMemberWrapper, int, ClanMemberWrapper>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 704;
			object obj4 = (nint)0 + (nint)384;
			object obj5 = (nint)0 + (nint)3336;
			object obj6 = typeof(CardUtils.<>c) + 1192;
			nint num = (nint)this;
			List<ClanMemberWrapper> source = base.data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj4);
			IEnumerable<ClanMemberWrapper> source2 = Enumerable.Where(source, func);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+18]");
			Func<ClanMemberWrapper, int, ClanMemberWrapper> selector = (Func<ClanMemberWrapper, int, ClanMemberWrapper>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+18]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj12 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v14+B8]");
					obj9 = 0;
				}
				object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 696;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)376;
				func2..ctor(obj9, (IntPtr)obj14);
				object obj15 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v13+B8]");
				object obj16 = (nint)0 + (nint)24;
				obj16 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func2;
			}
			IEnumerable<ClanMemberWrapper> source3 = Enumerable.Select(source2, selector);
			List<ClanMemberWrapper> list = Enumerable.ToList(source3);
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7 (Il2CppClass<ClanMembersListView>)+2A8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7 (Il2CppClass<ClanMembersListView>)+2B0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	protected unsafe override bool GetNewItem(ClanMemberWrapper datum, out ClanMemberStrip item)
	{
		//IL_000c: Expected O, but got I
		//IL_0050: Expected O, but got Ref
		//IL_0042: Expected I4, but got O
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1440;
		int num = default(int);
		bool newItem = ((ListViewController<ClanMemberWrapper, object, int>)(object)this).GetNewItem((ClanMemberWrapper)(&num), out System.Runtime.CompilerServices.Unsafe.As<ClanMemberStrip, object>(ref item));
		if ((object)item != null)
		{
			object obj2 = item + 200;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return newItem;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public ClanMembersListView()
	{
		((UiListView<ClanMemberWrapper, object>)(object)this)..ctor();
	}

	private unsafe ClanMemberWrapper <Initialize>b__2_2(ClanUserModel user, int i)
	{
		//IL_0010: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_009d: Expected native int or pointer, but got O
		//IL_00a7: Expected native int or pointer, but got O
		//IL_00d7: Expected O, but got I4
		//IL_00e4: Expected native int or pointer, but got O
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanMembersListView)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanMembersListView)+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1+18]");
			if ((nint)0 == 0)
			{
				goto IL_0146;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1+20]");
				string text = ((UnityEngine.Object)0).name;
				ClanMemberWrapper clanMemberWrapper = default(ClanMemberWrapper);
				((ClanMemberWrapper*)(nint)clanMemberWrapper)-><index>k__BackingField = 0;
				System.Runtime.CompilerServices.Unsafe.Write(&((ClanMemberWrapper*)(nint)clanMemberWrapper)-><User>k__BackingField, null);
				if (user != null)
				{
					object obj2 = i + 1;
					((ClanMemberWrapper*)(nint)clanMemberWrapper)-><index>k__BackingField = user.UserId;
					object obj3 = clanMemberWrapper + 8;
					obj3 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj4 = clanMemberWrapper + 16;
					obj4 = user;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					ClanMemberWrapper result = default(ClanMemberWrapper);
					return result;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0146;
		IL_0146:
		return (ClanMemberWrapper)new IndexOutOfRangeException();
	}
}
