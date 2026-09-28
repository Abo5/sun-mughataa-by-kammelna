using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Server.Models;
using Spine;
using UnityEngine;

public class TournamentFeaturesList : ScriptableObject
{
	private sealed class <>c__DisplayClass2_0
	{
		public TournamentAddonType type;

		internal bool <GetTournamentFeature>b__0(TournamentFeature f)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if ((object)f != null)
			{
				object obj = f.FeatureType - type;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public TournamentFeature feature;

		public Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addonConfigs;

		public TournamentType type;

		internal bool <IsFeatureAvailable>b__0(TournamentFeature f)
		{
			//IL_01ac: Expected I4, but got O
			//IL_017d: Expected O, but got I
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected O, but got Unknown
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected I4, but got Unknown
			//IL_0138: Expected O, but got I4
			if ((object)f != null)
			{
				TournamentFeature tournamentFeature = feature;
				if ((object)feature != null)
				{
					if (f.FeatureType != tournamentFeature.FeatureType)
					{
						goto IL_0161;
					}
					if (addonConfigs != null)
					{
						if (!((Dictionary<System.Int32Enum, object>)(object)addonConfigs).ContainsKey((System.Int32Enum)f.FeatureType))
						{
							goto IL_0161;
						}
						if (addonConfigs != null)
						{
							object obj = ((Dictionary<System.Int32Enum, object>)(object)addonConfigs).get_Item((System.Int32Enum)f.FeatureType);
							if (obj != null)
							{
								if (type != TournamentType.Private)
								{
									bool flag = type == TournamentType.Public;
									object obj2 = !flag;
									if (obj2 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9 (System.Object)+10]");
										return (byte)((nuint)0u & (nuint)1u) != 0;
									}
									goto IL_0161;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9 (System.Object)+10]");
								object obj3 = (nint)0 >> 1;
								object obj4 = obj3 & 1;
								return (byte)(obj4 & 1) != 0;
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0161:
			return false;
		}
	}

	public List<TournamentFeature> allTournamentFeatures;

	public IEnumerable<TournamentFeature> GetTournamentFeatures()
	{
		return allTournamentFeatures;
	}

	public TournamentFeature GetTournamentFeature(TournamentAddonType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3896;
			object obj4 = (nint)0 + (nint)3864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (TournamentFeature)Enumerable.First(allTournamentFeatures, func);
		}
		return (TournamentFeature)(object)new NullReferenceException();
	}

	public bool IsFeatureAvailable(TournamentFeature feature, TournamentType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_017f: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0101: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0154: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(RegisteredWaitHandle) + 56;
			object obj4 = obj2 + 16;
			obj4 = feature;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null && current.<Tournaments>k__BackingField != null)
			{
				object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3896;
				object obj8 = (nint)0 + (nint)3872;
				Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addons = current.<Tournaments>k__BackingField.Addons;
				object obj9 = obj2 + 24;
				obj9 = addons;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj8);
				return Enumerable.Any(allTournamentFeatures, func);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
