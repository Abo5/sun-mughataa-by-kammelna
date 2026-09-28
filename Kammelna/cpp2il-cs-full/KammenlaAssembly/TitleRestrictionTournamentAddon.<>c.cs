using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Spine;
using UnityEngine;

public class TitleRestrictionTournamentAddon : TournamentAddonModel
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, int> <>9__14_0;

		public static Func<string, int> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <.ctor>b__14_0(string _)
		{
			return 1;
		}

		internal int <.ctor>b__15_0(string _)
		{
			return 1;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public TitleRestrictionTournamentAddon <>4__this;

		public bool userTitleEligibility;

		internal void <IsEligible>b__0(PlayerProfileModel myProfile)
		{
			//IL_0011: Expected O, but got I
			//IL_00b2: Expected O, but got I
			//IL_00be: Expected O, but got I
			//IL_00ca: Expected O, but got I
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_0143: Expected O, but got I
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Expected O, but got Unknown
			//IL_02d0: Expected I, but got O
			//IL_01e2: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			//IL_0259: Expected O, but got I4
			TitleRestrictionTournamentAddon titleRestrictionTournamentAddon = <>4__this;
			object obj = (nint)0 + (nint)2816;
			Func<object, bool> func = (Func<object, bool>)obj;
			if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)titleRestrictionTournamentAddon.<TournamentTitles>k__BackingField))
			{
				if (myProfile == null || myProfile.<gameAchievements>k__BackingField == null)
				{
					return;
				}
				TitleRestrictionTournamentAddon titleRestrictionTournamentAddon2 = <>4__this;
				object obj2 = (nint)0 + (nint)1488;
				object obj3 = (nint)0 + (nint)3432;
				object obj4 = (nint)0 + (nint)2880;
				int num = 0;
				object obj6 = default(object);
				Func<object, bool> func2 = default(Func<object, bool>);
				while (true)
				{
					List<string> <TournamentTitles>k__BackingField = titleRestrictionTournamentAddon2.<TournamentTitles>k__BackingField;
					if (num < <TournamentTitles>k__BackingField._size)
					{
						object obj5 = typeof(SkeletonBinary.SkeletonInput) + 3208;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj6..ctor();
						TitleRestrictionTournamentAddon titleRestrictionTournamentAddon3 = <>4__this;
						object obj7 = (nint)0 + (nint)3208;
						object obj8 = obj7;
						object obj9 = ((List<object>)(object)titleRestrictionTournamentAddon3.<TournamentTitles>k__BackingField).get_Item(num);
						object obj10 = obj6 + 16;
						obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TitleRestrictionTournamentAddon titleRestrictionTournamentAddon4 = <>4__this;
						List<int> <RequiredLevels>k__BackingField = titleRestrictionTournamentAddon4.<RequiredLevels>k__BackingField;
						int num2 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
						if ((nint)num2 < (nint)0)
						{
							obj8 = obj2;
							int num3 = <RequiredLevels>k__BackingField.get_Item(num);
							object obj11 = num;
						}
						else
						{
							object obj11 = obj9;
							int num3 = 1;
						}
						object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func2..ctor(obj6, (IntPtr)obj3);
						bool flag = Enumerable.Any(myProfile.<gameAchievements>k__BackingField, func2);
						bool flag2 = !flag;
						object obj13 = !flag2;
						if (obj13 != null)
						{
							break;
						}
						num++;
						titleRestrictionTournamentAddon2 = <>4__this;
						bool flag3 = <>4__this == null;
						object obj14 = !flag3;
						func = func2;
						if (obj14 == null)
						{
							throw new NullReferenceException();
						}
						continue;
					}
					return;
				}
			}
			userTitleEligibility = true;
		}
	}

	private sealed class <>c__DisplayClass18_1
	{
		public string requiredId;

		public int requiredLevel;

		internal bool <IsEligible>b__1(UserAchievementModel a)
		{
			//IL_0102: Expected I4, but got O
			//IL_0088: Expected O, but got I4
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected I4, but got Unknown
			if (a != null)
			{
				bool flag = a.<gameAchievementId>k__BackingField == requiredId;
				if (flag)
				{
					flag = a.isUnlocked;
					if (flag)
					{
						object obj = a.<levelId>k__BackingField - requiredLevel;
						bool flag2 = (nint)obj < 0;
						int num = a.<levelId>k__BackingField ^ requiredLevel;
						int num2 = a.<levelId>k__BackingField ^ obj;
						int num3 = num & num2;
						bool flag3 = num3 < 0;
						bool flag4 = flag2 == flag3;
						flag = flag4;
					}
				}
				return flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private List<string> <TournamentTitles>k__BackingField;

	private List<int> <RequiredLevels>k__BackingField;

	public override int Priority => 0;

	public override TournamentAddonType Type => TournamentAddonType.TitleRestriction;

	public override string SerializedData
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CA3]");
			object obj2 = (nint)0 & (nint)1;
			object obj4;
			object obj5;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				obj4 = <TournamentTitles>k__BackingField;
				obj5 = <TournamentTitles>k__BackingField;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj4 = <TournamentTitles>k__BackingField;
				obj5 = <TournamentTitles>k__BackingField;
				if (obj6 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return JsonMapper.ToJson(obj5);
			IL_0088:
			return JsonMapper.ToJson(obj4);
		}
	}

	public List<string> TournamentTitles
	{
		get
		{
			return <TournamentTitles>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<int> RequiredLevels
	{
		get
		{
			return <RequiredLevels>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TitleRestrictionTournamentAddon(string titlesList)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0147: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		//IL_01a5: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0220: Expected O, but got I
		//IL_0231: Expected I, but got O
		//IL_024f: Expected O, but got I
		//IL_00f5: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object obj2 = (nint)0 + (nint)1072;
		object obj3 = typeof(SkeletonBinary.SkeletonInput) + 3192;
		((object)this)..ctor();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
		object obj6 = this + 16;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v10+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj9 = (nint)0 + (nint)40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v10+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v7+8]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v7+8]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v10+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v13+B8]");
				obj10 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)3408;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj10, (IntPtr)obj14);
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		List<int> list = Enumerable.ToList(Enumerable.Select((IEnumerable<object>)obj6, selector));
		object obj17 = this + 24;
		obj17 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public TitleRestrictionTournamentAddon(List<string> titles)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0115: Expected O, but got I4
		//IL_012f: Expected O, but got I
		//IL_0140: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_01bb: Expected I, but got O
		//IL_01d9: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3192;
		((object)this)..ctor();
		object obj2 = this + 16;
		obj2 = titles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+10]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+10]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v12+B8]");
				obj6 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3416;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj6, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+B8]");
			object obj12 = (nint)0 + (nint)16;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		List<int> list = Enumerable.ToList(Enumerable.Select(titles, selector));
		object obj13 = this + 24;
		obj13 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetRequiredLevels(string levelsJson)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object obj2 = (nint)0 + (nint)1064;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
		object obj5 = this + 24;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public int GetRequiredLevel(int index)
	{
		//IL_0094: Expected I4, but got I8
		//IL_00ae: Expected O, but got I4
		//IL_0082: Expected I4, but got O
		int num = (int)(index & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			List<int> list = <RequiredLevels>k__BackingField;
			if (<RequiredLevels>k__BackingField == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)index < (nint)0)
			{
				return <RequiredLevels>k__BackingField.get_Item(index);
			}
		}
		return 1;
	}

	public bool IsEligible()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fc: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			object obj4 = (nint)0 + (nint)3424;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RequestMyProfile(action);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+18]");
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public string RestrictionTitleId()
	{
		return (string)Enumerable.FirstOrDefault((IEnumerable<object>)<TournamentTitles>k__BackingField);
	}

	public int RestrictionTitleLevel()
	{
		//IL_0058: Expected I4, but got O
		List<int> list = <RequiredLevels>k__BackingField;
		if (<RequiredLevels>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)0 >= (nint)1)
			{
				return <RequiredLevels>k__BackingField.get_Item(0);
			}
			return 1;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
