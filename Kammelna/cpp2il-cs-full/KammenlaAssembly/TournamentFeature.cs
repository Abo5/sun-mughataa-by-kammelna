using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;

public class TournamentFeature : ScriptableObject
{
	public TournamentAddonType FeatureType;

	public string Title;

	public string MiniTitle;

	public string Description;

	public string EditMessage;

	public Sprite Icon;

	public bool Configurable;

	public long Cost
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_01d0: Expected I8, but got O
			//IL_01ab: Expected O, but got I
			//IL_01b3: Expected I, but got O
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C2C]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_01c2;
			IL_01c2:
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
			IL_011d:
			if (current.<Tournaments>k__BackingField != null)
			{
				Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> addons = current.<Tournaments>k__BackingField.Addons;
				if (addons != null)
				{
					object obj5 = ((Dictionary<System.Int32Enum, object>)(object)addons).get_Item((System.Int32Enum)FeatureType);
					if (obj5 != null)
					{
						object obj6 = (nint)0 + (nint)2000;
						nint num = (nint)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X8_v8 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
						long result = default(long);
						return result;
					}
				}
			}
			goto IL_01c2;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_011d;
			}
			goto IL_01c2;
		}
	}
}
