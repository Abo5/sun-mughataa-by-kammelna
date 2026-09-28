using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;
using UnityEngine.AdaptivePerformance;
using UnityEngine.TextCore;

public class MiniGameReward
{
	private static class Constants
	{
		public const string Name = "name";

		public const string Value = "value";

		public const string Cards = "cards";
	}

	private string <Name>k__BackingField;

	private int <Value>k__BackingField;

	private List<Card> <Cards>k__BackingField;

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int Value
	{
		get
		{
			return <Value>k__BackingField;
		}
		private set
		{
			<Value>k__BackingField = value;
		}
	}

	public List<Card> Cards
	{
		get
		{
			return <Cards>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static List<MiniGameReward> FromSfsArray(ISFSArray sfsArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_041f: Expected I, but got O
		//IL_042f: Expected O, but got I
		//IL_0197: Expected I, but got O
		//IL_01a7: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_023d: Expected O, but got I
		//IL_0273: Expected O, but got I4
		//IL_01e2: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I
		//IL_036a: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (sfsArray != null)
		{
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
			object obj3 = typeof(System.IOAsyncCallback) + 960;
			object obj4 = (nint)0 + (nint)464;
			object obj5 = 0;
			object obj11 = default(object);
			ISFSObject sfsObject = default(ISFSObject);
			ISFSObject sfsObject2 = default(ISFSObject);
			object obj25 = default(object);
			while (true)
			{
				nint num = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0108;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v15-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_0108;
				}
				object obj8 = obj7 + 1;
				object obj9 = num + obj8;
				object obj10 = obj9 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X0_v29] (should have been resolved before IL gen)");
				if (obj5 < obj11)
				{
					goto IL_018f;
				}
				goto IL_03d4;
				IL_018f:
				nint num2 = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0223;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v10-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj13 += 16;
					obj12--;
					if ((nint)obj12 != 1)
					{
						continue;
					}
					goto IL_0223;
				}
				object obj14 = obj13 + 51;
				object obj15 = num2 + obj14;
				object obj16 = obj15 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v21+8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v382 @ X0_v21] (should have been resolved before IL gen)");
				MiniGameReward miniGameReward = FromSfsObject(sfsObject);
				if (list == null)
				{
					break;
				}
				goto IL_02f3;
				IL_02f3:
				object obj18 = obj4;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items == null)
				{
					break;
				}
				bool flag = list._size < items.Length;
				object obj19 = !flag;
				if (obj19 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+20]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v13+C0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v14+70]");
					obj17 = 0;
					list.AddWithResize((object)miniGameReward);
				}
				else
				{
					int size = list._size + 1;
					list._size = size;
					object obj22 = list._items + list._size;
					object obj23 = obj22 + 32;
					obj23 = miniGameReward;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				obj5++;
				continue;
				IL_0223:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v17+8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v365 @ X0_v17] (should have been resolved before IL gen)");
				miniGameReward = FromSfsObject(sfsObject2);
				bool flag2 = list == null;
				object obj24 = !flag2;
				if (obj24 == null)
				{
					break;
				}
				goto IL_02f3;
				IL_0108:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X0_v26] (should have been resolved before IL gen)");
				if (obj5 < obj25)
				{
					goto IL_018f;
				}
				goto IL_03d4;
				IL_03d4:
				return (List<MiniGameReward>)(object)list;
			}
		}
		return (List<MiniGameReward>)(object)new NullReferenceException();
	}

	private static MiniGameReward FromSfsObject(ISFSObject sfsObject)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 808;
		object varName = "m_StencilDeferredPS" + 2872;
		object defaultValue = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		string text = SFSExtensions.Get(sfsObject, (string)varName, (string)defaultValue);
		if (obj2 != null)
		{
			object varName2 = "utf-32" + 208;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
			object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2424;
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = SFSExtensions.Get(sfsObject, (string)varName2, 0);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			List<Card> list = CardUtils.DecodeCards(sfsObject, (string)key);
			object obj7 = obj2 + 32;
			obj7 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (MiniGameReward)obj2;
		}
		return (MiniGameReward)(object)new NullReferenceException();
	}
}
