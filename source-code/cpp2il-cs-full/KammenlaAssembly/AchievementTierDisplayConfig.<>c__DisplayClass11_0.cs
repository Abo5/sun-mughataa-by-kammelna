using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class AchievementTierDisplayConfig : KammelnaSettingsBase<AchievementTierDisplayConfig>
{
	private sealed class <>c__DisplayClass10_0
	{
		public AchievementDisplayPlace place;

		internal bool <GetDefaults>b__0(PlaceEntry p)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = p.Place - place;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public AchievementDisplayPlace place;

		internal bool <GetContainerPosition>b__0(PlaceEntry p)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = p.Place - place;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public AchievementDisplayPlace place;

		internal bool <Resolve>b__0(PlaceEntry p)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = p.Place - place;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool _enableTestImages;

	private List<PlaceEntry> _places;

	public bool EnableTestImages => _enableTestImages;

	public IReadOnlyList<PlaceEntry> Places => _places;

	public static event Action OnRefreshRequested
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 2344;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 2344;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public unsafe ResolvedDisplay? Resolve(AchievementDisplayPlace place, int totalLevels, int activeLevel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0236: Expected O, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03ff: Expected O, but got I4
		//IL_041a: Expected O, but got I4
		//IL_030a: Expected O, but got I4
		//IL_031b: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_0269: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0561: Expected O, but got Ref
		//IL_0574: Expected O, but got I4
		//IL_0594: Expected O, but got Ref
		//IL_058f: Expected native int or pointer, but got O
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_015b: Expected O, but got I
		//IL_0191: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		//IL_0454: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04c6: Expected O, but got I4
		//IL_04ed: Expected O, but got I
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_052b: Expected O, but got I4
		//IL_0534: Expected O, but got I4
		//IL_053d: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_020e: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj9 = default(object);
		UnityEngine.Object obj18;
		object obj22;
		object obj23;
		object obj25;
		UnityEngine.Object obj26;
		object obj27;
		ResolvedDisplay? resolvedDisplay;
		object obj24;
		if (obj2 != null)
		{
			if (_places != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2664;
				object obj4 = (nint)0 + (nint)2096;
				object obj5 = (nint)0 + (nint)1040;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				object obj6 = obj5;
				obj2 = Enumerable.FirstOrDefault(_places, func);
				if (obj2 != null)
				{
					DisplayPreset preset = ((PlaceEntry)obj2).GetPreset(totalLevels);
					bool flag = preset == null;
					int num = totalLevels;
					object obj20;
					if (!flag)
					{
						num = activeLevel - 1;
						if (activeLevel >= 1)
						{
							List<object> tiers = (List<object>)(object)preset._tiers;
							if (preset._tiers != null && num < tiers._size)
							{
								object obj7 = (nint)0 + (nint)920;
								obj6 = obj7;
								object obj8 = ((List<object>)(object)preset._tiers).get_Item(num);
								bool flag2 = obj8 == null;
								obj9 = 0;
								if (!flag2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v31 (System.Object)+20]");
									bool flag3 = (nint)0 == 0;
									object obj10 = !flag3;
									object obj11 = ~obj10;
									if (obj11 == null)
									{
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v31 (System.Object)+2C]");
									bool flag4 = (nint)0 == 0;
									object obj12 = !flag4;
									object obj13 = ~obj12;
									if (obj13 == null)
									{
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v31 (System.Object)+38]");
									bool flag5 = (nint)0 == 0;
									object obj14 = !flag5;
									object obj15 = ~obj14;
									if (obj15 == null)
									{
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v31 (System.Object)+44]");
									bool flag6 = (nint)0 == 0;
									object obj16 = !flag6;
									object obj17 = ~obj16;
									if (obj17 == null)
									{
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v31 (System.Object)+18]");
									obj18 = (UnityEngine.Object)0;
									object obj19 = typeof(MemberAchievementClanFeedData) + 2976;
									obj20 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v20+E4]");
									bool flag7 = (nint)0 == 0;
									object obj21 = !flag7;
									obj9 = 0;
									obj22 = 0;
									obj23 = obj8;
									if (obj21 != null)
									{
										goto IL_0243;
									}
									obj24 = 0;
									obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v31 (System.Object)+18]");
									obj26 = (UnityEngine.Object)0;
									obj27 = obj8;
									goto IL_02d3;
								}
							}
						}
					}
					object obj28 = typeof(MemberAchievementClanFeedData) + 2976;
					obj20 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v20+E4]");
					bool flag8 = (nint)0 == 0;
					obj22 = 1;
					obj18 = null;
					obj23 = null;
					obj24 = obj9;
					obj25 = 1;
					obj26 = null;
					obj27 = null;
					if (!flag8)
					{
						goto IL_0243;
					}
					goto IL_02d3;
				}
			}
			_ = 0;
			_ = 0;
			_ = 0;
			resolvedDisplay = (ResolvedDisplay?)(object)0;
			return (ResolvedDisplay?)obj2;
		}
		goto IL_035a;
		IL_0553:
		object obj30 = default(object);
		object obj29 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj30, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		resolvedDisplay = (ResolvedDisplay?)(object)0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj31 = default(object);
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)resolvedDisplay, new ResolvedDisplay?((ResolvedDisplay)(&obj31)));
		return resolvedDisplay;
		IL_02d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = obj26 != null;
		bool flag10 = !flag9;
		object obj32 = !flag10;
		obj9 = obj24;
		object obj33 = 0;
		obj22 = obj25;
		obj23 = obj27;
		object obj34 = 0;
		if (obj32 != null)
		{
			goto IL_0288;
		}
		goto IL_0342;
		IL_0243:
		bool flag11 = obj18 != null;
		bool flag12 = !flag11;
		obj33 = 0;
		obj24 = obj9;
		obj34 = 0;
		if (!flag12)
		{
			goto IL_0288;
		}
		goto IL_0342;
		IL_0342:
		object obj35 = obj2 + 64;
		goto IL_0553;
		IL_0288:
		bool flag13 = obj22 == null;
		object obj36 = !flag13;
		if (obj36 != null)
		{
			goto IL_035a;
		}
		obj35 = obj23 + 24;
		obj24 = obj9;
		obj34 = obj33;
		goto IL_0553;
		IL_035a:
		return (ResolvedDisplay?)new NullReferenceException();
	}

	public unsafe ResolvedDisplay? GetDefaults(AchievementDisplayPlace place)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_00c8: Expected O, but got Ref
		//IL_00db: Expected O, but got I4
		//IL_00fa: Expected O, but got Ref
		//IL_00f5: Expected native int or pointer, but got O
		object obj = typeof(XmlSchemaInclude) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null && _places != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2664;
			object obj4 = (nint)0 + (nint)2080;
			object obj5 = (nint)0 + (nint)1040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			object obj6 = Enumerable.FirstOrDefault(_places, func);
			if (obj6 != null)
			{
				object obj8 = default(object);
				object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ResolvedDisplay? resolvedDisplay = (ResolvedDisplay?)(object)0;
				_ = 0;
				_ = 0;
				_ = 0;
				object obj9 = default(object);
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)resolvedDisplay, new ResolvedDisplay?((ResolvedDisplay)(&obj9)));
				return resolvedDisplay;
			}
		}
		return (ResolvedDisplay?)new NullReferenceException();
	}

	public Vector2? GetContainerPosition(AchievementDisplayPlace place)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0079: Expected I, but got O
		//IL_00ba: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			if (_places != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2664;
				object obj4 = (nint)0 + (nint)2088;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				object obj5 = Enumerable.FirstOrDefault(_places, func);
				if (obj5 != null)
				{
					object value = (nint)0 + (nint)744;
					Vector2? vector = (Vector2)value;
				}
			}
			return (Vector2?)(object)0;
		}
		return (Vector2?)new NullReferenceException();
	}

	public AchievementTierDisplayConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2648;
		object obj2 = (nint)0 + (nint)1640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 32;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D167D8");
	}
}
