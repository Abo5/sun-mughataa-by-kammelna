using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Core;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class MiniGameRewardsHandler : MonoBehaviour
{
	private static class Constants
	{
		public const string ListRewards = "list_rewards";

		public const string RewardsDefinitions = "rewards_definitions";
	}

	private static readonly OneShotEvent ReadyState;

	private static readonly Dictionary<Games, List<MiniGameRewardDescription>> CachedRewardDescriptions;

	public static List<MiniGameRewardDescription> Rewards;

	public static void CallWhenReady(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0131: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64BF]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+B8]");
		object obj7 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj7;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0099;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+B8]");
		object obj9 = 0;
		oneShotEvent = (OneShotEvent)obj9;
		goto IL_0099;
		IL_0099:
		oneShotEvent.CallWhenReady(callback);
	}

	private unsafe void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_019a: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02fa: Expected O, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_031a: Expected O, but got I
		//IL_035c: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_0419: Expected O, but got I
		//IL_0443: Expected I, but got O
		//IL_03ac: Expected O, but got I
		//IL_03b8: Expected O, but got I
		//IL_03c0: Expected I4, but got O
		//IL_03d1: Expected O, but got I
		//IL_02a6: Expected O, but got I4
		//IL_03fe: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6416]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v64+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v64+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v37+B8]");
		object obj7 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj7;
		goto IL_0136;
		IL_0136:
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		oneShotEvent.IsReady = false;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+B8]");
		object obj10 = 0;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		object obj13 = (nint)0 + (nint)2712;
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v2+B8]");
		ref object value = ref *(object*)((nint)0 + (nint)16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+8]");
		bool flag4 = ((Dictionary<System.Int32Enum, object>)0).TryGetValue((System.Int32Enum)currentGame, out value);
		bool flag5 = !flag4;
		System.Int32Enum int32Enum = (System.Int32Enum)currentGame;
		if (!flag5)
		{
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v24+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v24+B8]");
			object obj17 = 0;
			object obj18 = (nint)0 + (nint)2280;
			int32Enum = (System.Int32Enum)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v14+10]");
			if (Enumerable.Any((IEnumerable<object>)0))
			{
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v28+E4]");
				bool flag7 = (nint)0 == 0;
				object obj20 = !flag7;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v28+B8]");
				object obj21 = 0;
				((OneShotEvent)obj21).IsReady = true;
				return;
			}
		}
		object obj22 = typeof(List<AdaptivePerformanceScaler>) + 2392;
		object obj23 = (nint)0 + (nint)496;
		object obj24 = typeof(DataRelation) + 3728;
		object obj25 = (nint)0 + (nint)2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v14+B8]");
		object obj28 = (nint)0 + (nint)16;
		obj28 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj25);
		SFS.OnExtensionResponse += eventListenerDelegate;
		RequestRewards();
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v64+B8]");
		object obj29 = 0;
		oneShotEvent = (OneShotEvent)obj29;
		bool flag9 = obj29 == null;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00af: Expected I, but got O
		//IL_0063: Expected O, but got I4
		//IL_00cd: Expected O, but got I
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2808;
		object obj3 = typeof(MemberAchievementClanFeedData) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse -= eventListenerDelegate;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+B8]");
		object obj6 = 0;
		((OneShotEvent)obj6).IsReady = false;
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0793: Expected O, but got I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_00cc: Expected I, but got O
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010a: Expected I, but got O
		//IL_011a: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0263: Expected O, but got I
		//IL_026c: Expected O, but got I4
		//IL_0155: Expected O, but got I
		//IL_07dd: Expected O, but got I
		//IL_0330: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0220: Expected O, but got I
		//IL_02dc: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_06ac: Expected O, but got I4
		//IL_088b: Expected O, but got I
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected O, but got Unknown
		//IL_08c9: Expected O, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0437: Expected O, but got I
		//IL_0447: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_0496: Expected O, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0706: Expected O, but got I
		//IL_0728: Expected O, but got I
		//IL_0728: Expected O, but got I
		//IL_0740: Expected O, but got I
		//IL_0525: Expected O, but got I
		//IL_0398: Expected O, but got I
		//IL_03a8: Expected O, but got I
		//IL_03c8: Expected O, but got I
		//IL_03ea: Expected O, but got I4
		//IL_055b: Expected O, but got I4
		//IL_04ba: Expected O, but got I
		//IL_0410: Expected O, but got I
		//IL_0625: Expected O, but got I4
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I
		//IL_0281: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 1432;
		string command = SFSExtensions.GetCommand(evt);
		bool flag = command != (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			return;
		}
		ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
		object varName = "clear_mass_tournaments" + 264;
		object defaultValue = (nint)0 + (nint)2000;
		string text = SFSExtensions.Get(responseParams, (string)varName, (string)defaultValue);
		object obj3 = "java.io.FileOutputStream" + 2840;
		if (text != (string)obj3)
		{
			return;
		}
		object obj4 = typeof(DataRelation) + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)2808;
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj5);
		SFS.OnExtensionResponse -= eventListenerDelegate;
		object obj6 = typeof(System.IOAsyncCallback) + 976;
		object obj7 = "placementId" + 3912;
		nint num = (nint)responseParams;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0196;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X10_v20-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0196;
		}
		object obj10 = obj9 + 28;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v57+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v373 @ X0_v57] (should have been resolved before IL gen)");
		goto IL_022f;
		IL_0196:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v54+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v54] (should have been resolved before IL gen)");
		object obj14 = default(object);
		bool flag3 = obj14 == null;
		object obj15 = !flag3;
		if (obj15 != null)
		{
			goto IL_022f;
		}
		goto IL_0754;
		IL_022f:
		object obj16 = typeof(System.IOAsyncCallback) + 960;
		object obj17 = typeof(MemberAchievementClanFeedData) + 824;
		object obj18 = (nint)0 + (nint)504;
		object obj19 = 0;
		ISFSObject data = default(ISFSObject);
		ISFSObject data2 = default(ISFSObject);
		object obj42 = default(object);
		while (true)
		{
			object obj20 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v22+12E]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v22+12E]");
			if ((nint)0 == 0)
			{
				goto IL_031d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v22+B0]");
			object obj22 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X10_v15-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj22 += 16;
				obj21--;
				if ((nint)obj21 != 1)
				{
					continue;
				}
				goto IL_031d;
			}
			object obj23 = obj22 + 4;
			object obj24 = obj20 + obj23;
			object obj25 = obj24 + 312;
			goto IL_0826;
			IL_04a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v44+B0]");
			object obj26 = (nint)0 + (nint)8;
			object obj27;
			object obj28;
			List<object> list;
			List<object> list2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v10-8]");
				if (0 == (nint)obj27)
				{
					break;
				}
				obj26 += 16;
				obj28--;
				bool flag4 = (nint)obj28 != 1;
				object obj29 = obj27;
				list = list2;
				if (flag4)
				{
					continue;
				}
				goto IL_050b;
			}
			object obj30 = obj26 + 51;
			object obj32;
			object obj31 = obj32 + obj30;
			object obj33 = obj31 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v44+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v576 @ X0_v44] (should have been resolved before IL gen)");
			MiniGameRewardDescription miniGameRewardDescription = MiniGameRewardDescription.FromSfsObject(data);
			list = list2;
			goto IL_05cb;
			IL_05cb:
			object obj34 = obj18;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag5 = list._size < items.Length;
			object obj35 = !flag5;
			if (obj35 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v37+20]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v40+C0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v41+70]");
				obj13 = 0;
				list.AddWithResize((object)miniGameRewardDescription);
			}
			else
			{
				int size = list._size + 1;
				list._size = size;
				object obj38 = items + list._size;
				object obj39 = obj38 + 32;
				obj39 = miniGameRewardDescription;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			obj19++;
			continue;
			IL_050b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v39+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v559 @ X0_v39] (should have been resolved before IL gen)");
			miniGameRewardDescription = MiniGameRewardDescription.FromSfsObject(data2);
			bool flag6 = list == null;
			object obj40 = !flag6;
			if (obj40 == null)
			{
				break;
			}
			goto IL_05cb;
			IL_031d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj13 = 4;
			goto IL_0826;
			IL_0826:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v497 @ X0_v17] (should have been resolved before IL gen)");
			object obj41 = obj17;
			if (obj19 < obj42)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v21+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v21+B8]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v49+10]");
					list2 = (List<object>)0;
					obj27 = obj16;
					obj32 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v44+12E]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v44+12E]");
					bool flag7 = (nint)0 == 0;
					object obj44 = !flag7;
					if (obj44 != null)
					{
						goto IL_04a4;
					}
					object obj29 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v49+10]");
					list = (List<object>)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj45 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v49+B8]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v47+10]");
					list2 = (List<object>)0;
					obj27 = obj16;
					obj32 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v44+12E]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v44+12E]");
					bool flag8 = (nint)0 == 0;
					object obj29 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v47+10]");
					list = (List<object>)0;
					if (!flag8)
					{
						goto IL_04a4;
					}
				}
				goto IL_050b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v21+E4]");
			bool flag9 = (nint)0 == 0;
			object obj47 = !flag9;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj41 = obj17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v21+B8]");
			object obj48 = 0;
			object obj49 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v22+E4]");
			bool flag10 = (nint)0 == 0;
			object obj51 = !flag10;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj52 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v30+B8]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v26+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31+10]");
			((Dictionary<System.Int32Enum, object>)num2).set_Item((System.Int32Enum)currentGame, (object)0);
			object obj54 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v34+B8]");
			object obj55 = 0;
			((OneShotEvent)obj55).IsReady = true;
			return;
		}
		goto IL_0754;
		IL_0754:
		throw new NullReferenceException();
	}

	private static void RequestRewards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "java.io.FileOutputStream" + 2840;
		object command = "m_StencilDeferredPS" + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
	}

	static MiniGameRewardsHandler()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		object obj2 = typeof(MemberAchievementClanFeedData) + 824;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj4 = obj2;
		object obj5 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
