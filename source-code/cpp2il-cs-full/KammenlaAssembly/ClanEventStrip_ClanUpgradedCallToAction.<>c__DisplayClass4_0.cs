using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;

public class ClanEventStrip_ClanUpgradedCallToAction : ClanEventStrip
{
	private sealed class <>c__DisplayClass4_0
	{
		public ClanEventStrip_ClanUpgradedCallToAction <>4__this;

		public int tier;

		public int clanId;

		public Func<ClanEmblemTierModel, bool> <>9__1;

		internal void <LoadTierEmblem>b__0(List<ClanEmblemTierModel> tiers)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0109: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0440: Expected O, but got I
			//IL_0198: Expected O, but got I
			//IL_01cd: Expected O, but got I
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Expected O, but got Unknown
			//IL_023f: Expected O, but got I4
			//IL_0273: Expected O, but got I
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Expected O, but got Unknown
			//IL_030d: Expected O, but got I4
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Expected O, but got Unknown
			//IL_0345: Expected O, but got I
			//IL_0353: Expected I, but got O
			//IL_03de: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86DA]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = <>4__this;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = <>4__this;
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
			if (obj8 == null)
			{
				goto IL_0174;
			}
			return;
			IL_0174:
			ClanEventStrip_ClanUpgradedCallToAction clanEventStrip_ClanUpgradedCallToAction = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X21_v5 (ClanEventStrip_ClanUpgradedCallToAction)+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X21_v5 (ClanEventStrip_ClanUpgradedCallToAction)+40]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7+18]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v8+78]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v8+78]");
			if ((nint)0 == 0)
			{
				return;
			}
			object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1384;
			object obj15 = obj14;
			object obj16 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v3+130]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X9_v5+130]");
			bool flag5 = num < 0;
			object obj17 = !flag5;
			object obj18 = ~obj17;
			if (obj18 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v3+C8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X9_v5+130]");
			object obj19 = num2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X10_v5-8]");
			if (0 != (nint)obj15)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v9+14]");
			if ((nint)0 != tier)
			{
				return;
			}
			ClanEmblemLoader clanEmblem;
			int num3;
			FileInfoModel emblem;
			if (tiers != null)
			{
				object obj20 = this + 32;
				Func<object, bool> predicate = (Func<object, bool>)obj20;
				bool flag6 = obj20 == null;
				object obj21 = !flag6;
				if (obj21 == null)
				{
					object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 616;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj23 = (nint)0 + (nint)3504;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)this, (IntPtr)obj23);
					<>9__1 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				object obj24 = Enumerable.FirstOrDefault(tiers, predicate);
				ClanEventStrip_ClanUpgradedCallToAction clanEventStrip_ClanUpgradedCallToAction2 = <>4__this;
				clanEmblem = clanEventStrip_ClanUpgradedCallToAction2.clanEmblem;
				num3 = clanId;
				if (obj24 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v10 (System.Object)+18]");
					emblem = (FileInfoModel)0;
				}
				else
				{
					emblem = null;
				}
			}
			else
			{
				ClanEventStrip_ClanUpgradedCallToAction clanEventStrip_ClanUpgradedCallToAction3 = <>4__this;
				clanEmblem = clanEventStrip_ClanUpgradedCallToAction3.clanEmblem;
				num3 = clanId;
				emblem = null;
			}
			clanEmblem.Load(num3, emblem);
			return;
			IL_0091:
			bool flag7 = obj5 == null;
			bool flag8 = !flag7;
			obj9 = 0;
			obj10 = null;
			if (!flag8)
			{
				return;
			}
			goto IL_0174;
		}

		internal bool <LoadTierEmblem>b__1(ClanEmblemTierModel t)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (t != null)
			{
				object obj = t.Tier - tier;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string TEXT_KEY = "clan_emblem_now_available";

	private const string LEVEL_ORDINAL_KEY = "ORDINAL_LEVELS";

	private ClanEmblemLoader clanEmblem;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0194: Expected I, but got O
		//IL_019d: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_023b: Expected I, but got O
		//IL_01d9: Expected I, but got O
		//IL_01e9: Expected O, but got I
		//IL_0207: Expected I, but got O
		//IL_0217: Expected O, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		bool flag = model == null;
		ClanFeedModel clanFeedModel = model;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			ClanFeedData clanFeedData = model.Data;
			if (model.Data == null)
			{
				return;
			}
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1384;
			object obj2 = obj;
			nint num = (nint)clanFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+130]");
			bool flag2 = num2 < 0;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v7-8]");
			if (0 != (nint)obj2)
			{
				return;
			}
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input = "Network Authentication Required" + 3280;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
			string text = LocalizationUtil.LocalizeOrdinal((string)input, 0);
			object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag4 = array == null;
			nint num4 = unchecked((nint)null);
			clanFeedModel = (ClanFeedModel)1;
			if (!flag4)
			{
				bool flag5 = text == null;
				ClanFeedModel clanFeedModel2 = (ClanFeedModel)1;
				if (!flag5)
				{
					nint num5 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					clanFeedModel2 = (ClanFeedModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					num4 = unchecked((nint)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					clanFeedModel = (ClanFeedModel)0;
					if (flag6)
					{
						goto IL_02d0;
					}
				}
				bool flag7 = array.Length == 0;
				num4 = unchecked((nint)null);
				clanFeedModel = clanFeedModel2;
				if (!flag7)
				{
					object obj10 = array + 32;
					obj10 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj11 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3536;
					TextMeshProExtensions.Localize(base.text, (string)obj11, array);
					int clanId = model.ClanId;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
					LoadTierEmblem(clanId, 0);
					return;
				}
				goto IL_02c2;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02c2;
		IL_02c2:
		ex = new IndexOutOfRangeException();
		goto IL_02d0;
		IL_02d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void LoadTierEmblem(int clanId, int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_00f1: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 728;
		object obj6 = (nint)0 + (nint)3496;
		object obj7 = obj2 + 16;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClanEmblemTiers(action);
	}

	public ClanEventStrip_ClanUpgradedCallToAction()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
