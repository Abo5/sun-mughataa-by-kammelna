using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Coordinator.Models;
using Sfs2X.Core;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class ClanServerConnector : Singleton<ClanServerConnector>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanPendingMembershipViewModel, bool> <>9__16_1;

		public static Action<ClanModel> <>9__19_0;

		public static Func<ClanFeedModel, bool> <>9__53_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <FetchJoinRequests>b__16_1(ClanPendingMembershipViewModel p)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (p != null)
			{
				object obj = p.Direction - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <RaiseClanRosterChanged>b__19_0(ClanModel clan)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0032: Expected O, but got I
			//IL_0047: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+8]");
			Actions.SafeInvoke((Action<object>)0, clan);
		}

		internal bool <HasOpenVaultSupportRequest>b__53_1(ClanFeedModel entry)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0058: Expected I, but got O
			//IL_0081: Expected O, but got I4
			//IL_00ba: Expected O, but got I
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_0197: Expected O, but got I
			//IL_0143: Expected O, but got I
			//IL_01d1: Expected O, but got I
			//IL_01fd: Expected O, but got I
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected O, but got Unknown
			if (entry != null)
			{
				ClanFeedData data = entry.Data;
				if (entry.Data != null)
				{
					object obj = typeof(UsageHint) + 712;
					object obj2 = obj;
					nint num = (nint)data;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X9_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+130]");
					bool flag = num2 < 0;
					object obj3 = !flag;
					bool flag2;
					if (obj3 == null)
					{
						flag2 = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X9_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+130]");
						object obj4 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v5-8]");
						if (0 != (nint)obj2)
						{
							goto IL_00de;
						}
						object obj5 = typeof(DataRelation) + 712;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v4+E4]");
						if ((nint)0 != 0)
						{
							DateTime utcNow = DateTime.UtcNow;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+18]");
							flag2 = utcNow < (DateTime)0;
							if (flag2)
							{
								goto IL_01b4;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							DateTime utcNow2 = DateTime.UtcNow;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+18]");
							flag2 = utcNow2 < (DateTime)0;
							if (flag2)
							{
								goto IL_01b4;
							}
						}
					}
					return flag2;
				}
			}
			goto IL_00de;
			IL_01b4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
			object obj7 = num4 - 0;
			bool flag3 = (nint)obj7 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
			object obj8 = num5 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
			object obj9 = 0 ^ obj7;
			object obj10 = obj8 & obj9;
			bool flag4 = (nint)obj10 < 0;
			bool flag5 = flag3 == flag4;
			return !flag5;
			IL_00de:
			return false;
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public int myClanId;

		public Action<ClanModel> callback;

		internal void <GetMyClan>b__0(ClanModel clan)
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00ae: Expected O, but got I4
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_00d3: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			bool flag;
			bool flag2;
			bool flag3;
			if (clan == null)
			{
				flag = myClanId < 0;
				flag2 = myClanId == 0;
				int num = myClanId ^ myClanId;
				int num2 = myClanId & num;
				flag3 = num2 < 0;
			}
			else
			{
				flag3 = false;
				flag2 = true;
				flag = false;
			}
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			object obj3 = flag4 & obj2;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X9_v1+B8]");
			object obj5 = 0;
			Actions.SafeInvoke((Action<object>)callback, clan);
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public int id;

		public Action<ClanModel> onDone;

		internal void <FetchClan>b__0(KammelnaResponseModel<ClanViewModel> response)
		{
			//IL_002d: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			//IL_00ca: Expected O, but got I4
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_01ba: Expected O, but got I4
			bool succeeded = ((KammelnaResponseModel<object>)(object)response).Succeeded;
			bool flag = !succeeded;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				object format = "WhiteSmoke" + 2944;
				object arg = default(object);
				string text = string.Format((string)format, arg, errorMessage);
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj6 = text;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = text;
				}
				KLogger.LogWarning(obj6);
				ITrackEvent trackEvent = TrackerLibrary.ClanProfileLoadError();
				object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v18+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
			}
			Action<ClanModel> action = onDone;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				ClanModel clanModel = response.<Model>k__BackingField;
				ClanModel clanModel2 = clanModel;
			}
			else
			{
				ClanModel clanModel2 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X20_v3 (System.Action`1<ClanModel>)+18] (should have been resolved before IL gen)");
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public Action<List<ClanUserModel>> onDone;

		public int clanId;

		public Func<ClanPendingMembershipViewModel, ClanUserModel> <>9__2;

		internal void <FetchJoinRequests>b__0(KammelnaResponseModel<List<ClanPendingMembershipViewModel>> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00f9: Expected O, but got I4
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_016a: Expected O, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_01c4: Expected O, but got I
			//IL_01d4: Expected O, but got I
			//IL_01f6: Expected O, but got I4
			//IL_0267: Expected O, but got I
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected O, but got Unknown
			//IL_02aa: Expected O, but got I4
			//IL_0096: Expected O, but got I
			//IL_00a6: Expected O, but got I
			//IL_00c8: Expected O, but got I4
			//IL_0226: Expected O, but got I4
			//IL_0336: Expected O, but got I
			//IL_0346: Expected O, but got I
			//IL_0356: Expected O, but got I
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Expected O, but got Unknown
			//IL_02ea: Expected O, but got I
			//IL_02f8: Expected I, but got O
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Expected O, but got Unknown
			//IL_03a2: Expected O, but got I
			//IL_03b3: Expected I, but got O
			//IL_03d1: Expected O, but got I
			//IL_0256: Expected O, but got I
			object obj = (nint)0 + (nint)656;
			object obj2;
			object obj4;
			Func<object, bool> predicate;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				Action<List<ClanUserModel>> action = onDone;
				obj2 = typeof(CardUtils.<>c) + 1288;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v31+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v31+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v32+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v32+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						goto IL_0204;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v31+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v32+8]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v32+8]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						goto IL_0204;
					}
				}
				goto IL_025b;
			}
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj7 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "WhiteSmoke" + 2968;
			object arg = default(object);
			string text = string.Format((string)format, errorMessage, arg);
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			object obj11 = text;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = text;
			}
			goto IL_0360;
			IL_0204:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v31+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v38+B8]");
				obj4 = 0;
			}
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)512;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj15);
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v37+B8]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
			goto IL_025b;
			IL_0360:
			KLogger.LogWarning(obj11);
			Action<List<ClanUserModel>> action2 = onDone;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X8_v16 (System.Action`1<System.Collections.Generic.List`1<ClanUserModel>>)+18] (should have been resolved before IL gen)");
			return;
			IL_025b:
			object obj18 = (nint)0 + (nint)3344;
			IEnumerable<object> enumerable = Enumerable.Where(response.<Model>k__BackingField, predicate);
			object obj19 = this + 32;
			Func<object, object> selector = (Func<object, object>)obj19;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			IEnumerable<object> source = enumerable;
			if (obj20 == null)
			{
				object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 720;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj22 = (nint)0 + (nint)560;
				Func<object, object> func2 = default(Func<object, object>);
				func2..ctor((object)this, (IntPtr)obj22);
				<>9__2 = (Func<ClanPendingMembershipViewModel, ClanUserModel>)func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				source = enumerable;
				selector = func2;
			}
			IEnumerable<object> source2 = Enumerable.Select(source, selector);
			List<object> list = Enumerable.ToList(source2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v3 (System.Action`1<System.Collections.Generic.List`1<ClanUserModel>>)+18]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v3 (System.Action`1<System.Collections.Generic.List`1<ClanUserModel>>)+40]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v3 (System.Action`1<System.Collections.Generic.List`1<ClanUserModel>>)+28]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v122 @ X3_v5 (should have been resolved before IL gen)");
			goto IL_0360;
		}

		internal ClanUserModel <FetchJoinRequests>b__2(ClanPendingMembershipViewModel p)
		{
			return ClanUserModel.FromJoinRequest(p, clanId);
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public Action<List<UserPendingMembershipModel>> onDone;

		internal void <FetchMyPendingMemberships>b__0(KammelnaResponseModel<List<UserPendingMembershipModel>> response)
		{
			//IL_00a4: Expected O, but got I4
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_0115: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007c: Expected O, but got I
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				Action<List<UserPendingMembershipModel>> action = onDone;
				List<UserPendingMembershipModel> <Model>k__BackingField = response.<Model>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v17 (System.Action`1<System.Collections.Generic.List`1<Kammelna.Server.Models.Clans.UserPendingMembershipModel>>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v17 (System.Action`1<System.Collections.Generic.List`1<Kammelna.Server.Models.Clans.UserPendingMembershipModel>>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v17 (System.Action`1<System.Collections.Generic.List`1<Kammelna.Server.Models.Clans.UserPendingMembershipModel>>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X3_v3 (should have been resolved before IL gen)");
			}
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj4 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "WhiteSmoke" + 2992;
			object arg = default(object);
			string text = string.Format((string)format, errorMessage, arg);
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			object obj8 = text;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = text;
			}
			KLogger.LogWarning(obj8);
			Action<List<UserPendingMembershipModel>> action2 = onDone;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ X8_v16 (System.Action`1<System.Collections.Generic.List`1<Kammelna.Server.Models.Clans.UserPendingMembershipModel>>)+18] (should have been resolved before IL gen)");
		}
	}

	private sealed class <>c__DisplayClass52_0
	{
		public Action<List<ClanFeedModel>> callback;

		internal void <GetClanFeed>b__0(KammelnaResponseModel<List<ClanFeedModel>> response)
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				Actions.SafeInvoke((Action<object>)callback, response.<Model>k__BackingField);
				return;
			}
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj = "WhiteSmoke" + 2960;
			string text = (string)obj + errorMessage;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			object obj5 = text;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = text;
			}
			KLogger.LogWarning(obj5);
			Actions.SafeInvoke((Action<object>)callback, null);
		}
	}

	private sealed class <>c__DisplayClass53_0
	{
		public Action<bool> callback;

		internal void <HasOpenVaultSupportRequest>b__0(List<ClanFeedModel> feed)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00db: Expected O, but got I
			//IL_00eb: Expected O, but got I
			//IL_00fb: Expected O, but got I
			//IL_011d: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0072: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Expected O, but got Unknown
			//IL_0200: Expected O, but got I
			//IL_0211: Expected I, but got O
			//IL_022f: Expected O, but got I
			//IL_0185: Expected O, but got I
			object obj;
			object obj4;
			Func<object, bool> predicate;
			object obj6;
			object obj3;
			if (feed != null)
			{
				obj = typeof(CardUtils.<>c) + 1288;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)2536;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v8+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+18]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+18]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_0133;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)2536;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v8+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+18]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+18]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_0133;
					}
				}
				goto IL_018a;
			}
			bool arg = false;
			goto IL_01c6;
			IL_018a:
			bool flag3 = Enumerable.Any(feed, predicate);
			arg = flag3;
			goto IL_01c6;
			IL_0133:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v13+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)520;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+B8]");
			object obj13 = (nint)0 + (nint)24;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = obj6;
			predicate = func;
			goto IL_018a;
			IL_01c6:
			Actions.SafeInvoke(callback, arg);
		}
	}

	private sealed class <>c__DisplayClass54_0
	{
		public Action<bool> callback;

		internal void <DeleteAnnouncement>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00ec: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			ClanActivityType succeeded = (response.Succeeded ? ClanActivityType.Vote : ClanActivityType.Announcement);
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (succeeded != ClanActivityType.Announcement)
			{
				trackEvent = TrackerLibrary.ClanActivityDeleted(ClanActivityType.Announcement);
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					object obj4 = 0;
					trackEvent2 = trackEvent;
					goto IL_010b;
				}
			}
			else
			{
				trackEvent2 = TrackerLibrary.ClanActivityDeleteError(succeeded);
				object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj4 = 0;
				trackEvent = trackEvent2;
				if (obj6 == null)
				{
					goto IL_010b;
				}
			}
			goto IL_0123;
			IL_010b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_0123;
			IL_0123:
			Tracker.DesignEvent(trackEvent);
			bool succeeded2 = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded2);
		}
	}

	private sealed class <>c__DisplayClass55_0
	{
		public Action<bool> callback;

		internal void <PinFeed>b__0(KammelnaResponseModel<bool> response)
		{
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public Action<bool> callback;

		internal void <UnpinFeed>b__0(KammelnaResponseModel<bool> response)
		{
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
		}
	}

	private sealed class <>c__DisplayClass57_0
	{
		public Action<List<InterClanLeaderboardEntryModel>> callback;

		internal void <GetClanLeaderboard>b__0(KammelnaResponseModel<List<InterClanLeaderboardEntryModel>> response)
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				Actions.SafeInvoke((Action<object>)callback, response.<Model>k__BackingField);
				return;
			}
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj = "WhiteSmoke" + 2984;
			string text = (string)obj + errorMessage;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			object obj5 = text;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = text;
			}
			KLogger.LogWarning(obj5);
			object obj6 = typeof(List<AdaptivePerformanceScaler>) + 1840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			Actions.SafeInvoke((Action<object>)callback, list);
		}
	}

	private sealed class <>c__DisplayClass58_0
	{
		public Action<ClanLandingResponseModel> callback;

		internal void <GetClanLanding>b__0(KammelnaResponseModel<ClanLandingResponseModel> response)
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected O, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				Actions.SafeInvoke((Action<object>)callback, response.<Model>k__BackingField);
				return;
			}
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj = "WhiteSmoke" + 2976;
			string text = (string)obj + errorMessage;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			object obj5 = text;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = text;
			}
			KLogger.LogWarning(obj5);
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ClanLandingResponseModel clanLandingResponseModel = default(ClanLandingResponseModel);
			clanLandingResponseModel..ctor();
			object obj7 = typeof(List<AdaptivePerformanceScaler>) + 1840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			object obj8 = clanLandingResponseModel + 16;
			obj8 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = typeof(List<AdaptivePerformanceScaler>) + 552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list2 = default(List<object>);
			list2..ctor();
			object obj10 = clanLandingResponseModel + 24;
			obj10 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj11 = typeof(List<AdaptivePerformanceScaler>) + 536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list3 = default(List<object>);
			list3..ctor();
			object obj12 = clanLandingResponseModel + 32;
			obj12 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Actions.SafeInvoke((Action<object>)callback, clanLandingResponseModel);
		}
	}

	private sealed class <>c__DisplayClass59_0
	{
		public Action<ClanModel[]> callback;

		internal void <GetAllClans>b__0(KammelnaResponseModel<List<ClanCardModel>> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0124: Expected O, but got I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0065: Expected O, but got I
			//IL_0073: Expected I, but got O
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_018f: Expected O, but got I4
			//IL_045b: Expected O, but got I
			//IL_0473: Expected O, but got I
			//IL_02f8: Expected O, but got I
			//IL_0308: Expected O, but got I
			//IL_031e: Expected O, but got I
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Expected O, but got Unknown
			//IL_0346: Expected O, but got I4
			//IL_0356: Expected O, but got I
			//IL_01bc: Expected O, but got I
			//IL_01d2: Expected O, but got I
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected O, but got Unknown
			//IL_01ff: Expected O, but got I
			//IL_03b8: Expected O, but got I
			//IL_03c8: Expected O, but got I
			//IL_03de: Expected O, but got I
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Expected O, but got Unknown
			//IL_0390: Expected O, but got I4
			//IL_0242: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_0268: Expected O, but got I
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected O, but got Unknown
			//IL_0290: Expected O, but got I4
			//IL_02a0: Expected O, but got I
			//IL_02cd: Expected O, but got I
			//IL_0419: Expected O, but got I
			object obj = (nint)0 + (nint)552;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = (nint)0 + (nint)1640;
				Func<object, object> func = default(Func<object, object>);
				func..ctor((object)null, (IntPtr)obj3);
				IEnumerable<object> source = Enumerable.Select(response.<Model>k__BackingField, func);
				object[] arg = Enumerable.ToArray(source);
				Actions.SafeInvoke((Action<object>)callback, arg);
				return;
			}
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			object obj4 = "WhiteSmoke" + 2936;
			string text = (string)obj4 + errorMessage;
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			object obj8 = text;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = text;
			}
			KLogger.LogWarning(obj8);
			string errorMessage2 = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			ITrackEvent trackEvent = TrackerLibrary.ClanListLoadError(errorMessage2);
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			object obj12 = (nint)0 + (nint)2976;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X20_v3+38]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X20_v3+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v15+10]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v15+10]");
				object obj16 = (nint)0 + (nint)309;
				object obj17 = obj16 & 1;
				bool flag3 = obj17 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v15+10]");
				object obj18 = 0;
				if (!flag3)
				{
					goto IL_020d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X20_v3+38]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v22+10]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v22+10]");
				object obj20 = (nint)0 + (nint)309;
				object obj21 = obj20 & 1;
				bool flag4 = obj21 == null;
				object obj22 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v22+10]");
				object obj18 = 0;
				if (obj22 != null)
				{
					goto IL_020d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 != null)
			{
				goto IL_0232;
			}
			goto IL_039e;
			IL_02ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			goto IL_02bd;
			IL_020d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0232;
			}
			goto IL_039e;
			IL_0232:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X20_v3+38]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v31+10]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v31+10]");
			object obj26 = (nint)0 + (nint)309;
			object obj27 = obj26 & 1;
			bool flag6 = obj27 == null;
			object obj28 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v31+10]");
			object obj29 = 0;
			if (obj28 == null)
			{
				goto IL_02ae;
			}
			goto IL_02bd;
			IL_02bd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v22+B8]");
			object arg2 = 0;
			Actions.SafeInvoke((Action<object>)callback, arg2);
			return;
			IL_039e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X20_v3+38]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v17+10]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v17+10]");
			object obj31 = (nint)0 + (nint)309;
			object obj32 = obj31 & 1;
			if (obj32 == null)
			{
				goto IL_02ae;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v17+10]");
			obj29 = 0;
			goto IL_02bd;
		}
	}

	private sealed class <>c__DisplayClass60_0
	{
		public ClanServerConnector <>4__this;

		public Action<KammelnaResponseModel<int>> callback;

		internal void <SendCreateClan>b__0(KammelnaResponseModel<int> response)
		{
			//IL_0011: Expected O, but got I
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0088: Expected O, but got I4
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_0240: Expected O, but got I4
			//IL_0249: Expected O, but got I4
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			//IL_01c7: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected O, but got Unknown
			//IL_00e8: Expected I8, but got I4
			//IL_0344: Expected O, but got I
			//IL_0282: Expected O, but got I
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_0134: Expected O, but got I4
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Expected O, but got Unknown
			//IL_031d: Expected O, but got I4
			//IL_014b: Expected O, but got I4
			object obj = (nint)0 + (nint)1240;
			object obj2 = obj;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				object obj3 = typeof(Queue<string>) + 848;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v28+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				SFS.RefreshClanMembership(intDbId);
				trackEvent = TrackerLibrary.ClanCreated();
				object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					obj2 = 0;
					trackEvent2 = trackEvent;
					goto IL_025f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int32>)+14]");
				if ((nint)0 == 6004)
				{
					trackEvent = TrackerLibrary.ClanCreateNotEnoughAces();
					object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj8 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v16+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						trackEvent2 = trackEvent;
						goto IL_025f;
					}
				}
				else
				{
					string errorMessage = response.ErrorMessage;
					trackEvent2 = TrackerLibrary.ClanCreateError(errorMessage);
					object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj8 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v16+E4]");
					bool flag4 = (nint)0 == 0;
					object obj13 = !flag4;
					obj2 = 0;
					trackEvent = trackEvent2;
					if (obj13 == null)
					{
						goto IL_025f;
					}
				}
			}
			goto IL_03b9;
			IL_0396:
			object obj14;
			KLogger.Log(obj14);
			return;
			IL_03b9:
			Tracker.DesignEvent(trackEvent);
			if (callback != null)
			{
				object obj15 = (nint)0 + (nint)1960;
				Actions.SafeInvoke((Action<object>)callback, response);
			}
			object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj17 = obj;
			object obj21;
			if (response.Succeeded)
			{
				object obj18 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3456;
				obj14 = obj18;
				object obj19 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj20 = !flag5;
				if (obj20 != null)
				{
					goto IL_0396;
				}
				obj21 = obj18;
			}
			else
			{
				object obj22 = (nint)0 + (nint)1224;
				obj17 = obj22;
				string errorMessage2 = response.ErrorMessage;
				object obj19 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+E4]");
				bool flag6 = (nint)0 == 0;
				obj14 = errorMessage2;
				obj21 = errorMessage2;
				if (!flag6)
				{
					goto IL_0396;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.Log(obj21);
			return;
			IL_025f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_03b9;
		}
	}

	private sealed class <>c__DisplayClass61_0
	{
		public ClanServerConnector <>4__this;

		public Action<bool> callback;

		internal void <SendEditClan>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_010f: Expected O, but got I4
			//IL_0118: Expected O, but got I4
			//IL_0258: Expected O, but got I
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_0096: Expected O, but got I4
			//IL_01df: Expected O, but got I
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_01b8: Expected O, but got I4
			object obj = (nint)0 + (nint)1048;
			object obj2 = obj;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				<>4__this.RaiseClanRosterChanged();
				trackEvent = TrackerLibrary.ClanEdited();
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					trackEvent2 = trackEvent;
					goto IL_012e;
				}
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				trackEvent2 = TrackerLibrary.ClanEditError(errorMessage);
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj2 = 0;
				trackEvent = trackEvent2;
				if (obj7 == null)
				{
					goto IL_012e;
				}
			}
			goto IL_024c;
			IL_024c:
			object obj8 = (nint)0 + (nint)2056;
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			Tracker.DesignEvent(trackEvent);
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
			object obj10 = obj;
			object obj12;
			object obj15;
			if (response.Succeeded)
			{
				object obj11 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3448;
				obj12 = obj11;
				object obj13 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				if (obj14 != null)
				{
					goto IL_0229;
				}
				obj15 = obj11;
			}
			else
			{
				object obj16 = (nint)0 + (nint)1024;
				obj10 = obj16;
				obj12 = response.ErrorMessage;
				object obj13 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v4+E4]");
				bool flag4 = (nint)0 == 0;
				obj15 = obj12;
				if (!flag4)
				{
					goto IL_0229;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.Log(obj15);
			return;
			IL_012e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_024c;
			IL_0229:
			KLogger.Log(obj12);
		}
	}

	private sealed class <>c__DisplayClass62_0
	{
		public ClanServerConnector <>4__this;

		public Action<ClanResult> callback;

		internal void <LeaveClan>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00d7: Expected O, but got I4
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
			//IL_0148: Expected O, but got I4
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_0096: Expected O, but got I4
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_01b3: Expected O, but got I4
			//IL_01c4: Expected O, but got I4
			//IL_00ac: Expected O, but got I
			object obj = (nint)0 + (nint)1048;
			object obj2 = obj;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				trackEvent = TrackerLibrary.ClanLeft();
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					IntPtr intPtr = default(IntPtr);
					object obj6 = (nint)intPtr;
					trackEvent2 = trackEvent;
					goto IL_01da;
				}
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				object obj7 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "WhiteSmoke" + 3008;
				object obj8 = default(object);
				string text = string.Format((string)format, errorMessage, obj8);
				object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				object obj12 = text;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = text;
				}
				KLogger.LogWarning(obj12);
				string errorMessage2 = response.ErrorMessage;
				trackEvent2 = TrackerLibrary.ClanLeaveError(errorMessage2);
				object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				object obj6 = obj8;
				obj2 = 0;
				trackEvent = trackEvent2;
				if (obj14 == null)
				{
					goto IL_01da;
				}
			}
			goto IL_0229;
			IL_01da:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_0229;
			IL_0229:
			Tracker.DesignEvent(trackEvent);
			ClanResult arg;
			if (response.Succeeded)
			{
				arg = ClanResult.Ok();
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
				arg = ClanResult.Fail((KammelnaError)0);
			}
			Actions.SafeInvoke(callback, arg);
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public Action<ClanResult<ClanMemberViewModel>> callback;

		internal void <GetSuggestedOwner>b__0(KammelnaResponseModel<ClanMemberViewModel> response)
		{
			//IL_002d: Expected O, but got I4
			//IL_0150: Expected O, but got I
			//IL_0059: Expected O, but got I4
			//IL_012d: Expected O, but got I
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			//IL_00ca: Expected O, but got I4
			bool succeeded = ((KammelnaResponseModel<object>)(object)response).Succeeded;
			bool flag = !succeeded;
			object obj = !flag;
			if (obj == null)
			{
				string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				object obj2 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "WhiteSmoke" + 3000;
				object arg = default(object);
				string text = string.Format((string)format, errorMessage, arg);
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v18+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj6 = text;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = text;
				}
				KLogger.LogWarning(obj6);
			}
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				object obj7 = (nint)0 + (nint)1600;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @439BBA8");
			}
			else
			{
				object obj9 = (nint)0 + (nint)1592;
				object obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @439BC00");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F2A9F8");
		}
	}

	private sealed class <>c__DisplayClass64_0
	{
		public ClanServerConnector <>4__this;

		public int newOwnerId;

		public Action<ClanResult> callback;

		internal void <TransferOwnership>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00c9: Expected O, but got I4
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_015c: Expected O, but got I4
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_0096: Expected O, but got I4
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			//IL_01c7: Expected O, but got I4
			//IL_01d8: Expected O, but got I4
			//IL_00ac: Expected O, but got I
			object obj = (nint)0 + (nint)1048;
			object obj2 = obj;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				trackEvent = TrackerLibrary.ClanOwnershipTransferred();
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					IntPtr intPtr = default(IntPtr);
					object obj6 = (nint)intPtr;
					trackEvent2 = trackEvent;
					goto IL_01ee;
				}
			}
			else
			{
				object obj7 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string errorMessage = response.ErrorMessage;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "WhiteSmoke" + 3040;
				object arg = default(object);
				object arg2 = default(object);
				string text = string.Format((string)format, arg, errorMessage, arg2);
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				object obj11 = text;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = text;
				}
				KLogger.LogWarning(obj11);
				string errorMessage2 = response.ErrorMessage;
				trackEvent2 = TrackerLibrary.ClanOwnershipTransferError(errorMessage2);
				object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				object obj6 = errorMessage;
				obj2 = 0;
				trackEvent = trackEvent2;
				if (obj13 == null)
				{
					goto IL_01ee;
				}
			}
			goto IL_023d;
			IL_01ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_023d;
			IL_023d:
			Tracker.DesignEvent(trackEvent);
			ClanResult arg3;
			if (response.Succeeded)
			{
				arg3 = ClanResult.Ok();
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
				arg3 = ClanResult.Fail((KammelnaError)0);
			}
			Actions.SafeInvoke(callback, arg3);
		}
	}

	private sealed class <>c__DisplayClass65_0
	{
		public Action<IEnumerable<ClanUserModel>> callback;

		internal void <GetJoinRequests>b__0(List<ClanUserModel> requests)
		{
			//IL_00c7: Expected O, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0090: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			bool flag = requests == null;
			object obj = !flag;
			List<object> list = (List<object>)(object)requests;
			if (obj == null)
			{
				object obj2 = typeof(List<AdaptivePerformanceScaler>) + 560;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list2 = default(List<object>);
				list2..ctor();
				list = list2;
			}
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			ITrackEvent trackEvent = TrackerLibrary.ClanJoinRequestsViewed(list._size);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			Actions.SafeInvoke((Action<object>)callback, list);
		}
	}

	private sealed class <>c__DisplayClass67_0
	{
		public ClanServerConnector <>4__this;

		public int clanId;

		public Action<bool, KammelnaError> callback;

		internal void <RequestJoinClan>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_012b: Expected O, but got I4
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_019c: Expected O, but got I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0063: Expected O, but got I
			//IL_0079: Expected O, but got I
			//IL_009d: Expected O, but got I
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00e9: Expected O, but got I4
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected O, but got Unknown
			//IL_0207: Expected O, but got I4
			//IL_0218: Expected O, but got I4
			//IL_0264: Expected O, but got I
			//IL_0100: Expected O, but got I4
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v18+B8]");
				object obj3 = 0;
				int num = clanId;
				object obj4 = (nint)0 + (nint)2432;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v19+18]");
				Actions.SafeInvoke((Action<int, bool>)0, clanId, arg2: true);
				trackEvent = TrackerLibrary.ClanJoinRequested();
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					object obj9 = 1;
					trackEvent2 = trackEvent;
					goto IL_0237;
				}
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				object obj10 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "WhiteSmoke" + 3016;
				object obj11 = default(object);
				string text = string.Format((string)format, errorMessage, obj11);
				object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj14 = !flag2;
				object obj15 = text;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = text;
				}
				KLogger.LogWarning(obj15);
				string errorMessage2 = response.ErrorMessage;
				trackEvent2 = TrackerLibrary.ClanJoinRequestError(errorMessage2);
				object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj17 = !flag3;
				object obj9 = obj11;
				object obj5 = 0;
				int num = 0;
				trackEvent = trackEvent2;
				if (obj17 == null)
				{
					goto IL_0237;
				}
			}
			goto IL_024f;
			IL_0237:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_024f;
			IL_024f:
			Tracker.DesignEvent(trackEvent);
			object obj18 = (nint)0 + (nint)2408;
			bool succeeded = response.Succeeded;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F2C978");
		}
	}

	private sealed class <>c__DisplayClass68_0
	{
		public ClanServerConnector <>4__this;

		public int clanId;

		public Action<bool, KammelnaError> callback;

		internal void <CancelJoinRequest>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0127: Expected O, but got I4
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_0198: Expected O, but got I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0063: Expected O, but got I
			//IL_0079: Expected O, but got I
			//IL_009d: Expected O, but got I
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00e9: Expected O, but got I4
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_0203: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_0260: Expected O, but got I
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v18+B8]");
				object obj3 = 0;
				int num = clanId;
				object obj4 = (nint)0 + (nint)2432;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v19+18]");
				Actions.SafeInvoke((Action<int, bool>)0, clanId, arg2: false);
				trackEvent = TrackerLibrary.ClanJoinRequestCanceled();
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					object obj9 = null;
					trackEvent2 = trackEvent;
					goto IL_0233;
				}
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				object obj10 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "WhiteSmoke" + 2904;
				object obj11 = default(object);
				string text = string.Format((string)format, errorMessage, obj11);
				object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj14 = !flag2;
				object obj15 = text;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = text;
				}
				KLogger.LogWarning(obj15);
				string errorMessage2 = response.ErrorMessage;
				trackEvent2 = TrackerLibrary.ClanJoinRequestCancelError(errorMessage2);
				object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj17 = !flag3;
				object obj9 = obj11;
				object obj5 = 0;
				int num = 0;
				trackEvent = trackEvent2;
				if (obj17 == null)
				{
					goto IL_0233;
				}
			}
			goto IL_024b;
			IL_0233:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_024b;
			IL_024b:
			Tracker.DesignEvent(trackEvent);
			object obj18 = (nint)0 + (nint)2408;
			bool succeeded = response.Succeeded;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F2C978");
		}
	}

	private sealed class <>c__DisplayClass69_0
	{
		public Action<bool> callback;

		public int memberId;

		public ClanServerConnector <>4__this;

		internal void <KickClanMember>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected O, but got Unknown
			//IL_00af: Expected O, but got I4
			//IL_0159: Expected I8, but got I4
			object obj = (nint)0 + (nint)1048;
			object obj2 = (nint)0 + (nint)2056;
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
			if (response.Succeeded)
			{
				ITrackEvent trackEvent = TrackerLibrary.ClanMemberKicked();
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				SFS.RefreshClanMembership(memberId);
				<>4__this.RaiseClanRosterChanged();
			}
			else
			{
				ITrackEvent trackEvent2 = TrackerLibrary.ClanMemberKickError();
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent2);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent2);
			}
		}
	}

	private sealed class <>c__DisplayClass70_0
	{
		public Action<bool, KammelnaError> callback;

		public int memberId;

		public ClanServerConnector <>4__this;

		internal void <AcceptJoinRequest>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_00aa: Expected O, but got I4
			//IL_0154: Expected I8, but got I4
			object obj = (nint)0 + (nint)1048;
			object obj2 = (nint)0 + (nint)2408;
			bool succeeded = response.Succeeded;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F2C978");
			if (response.Succeeded)
			{
				ITrackEvent trackEvent = TrackerLibrary.ClanJoinRequestAccepted();
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				SFS.RefreshClanMembership(memberId);
				<>4__this.RaiseClanRosterChanged();
			}
			else
			{
				ITrackEvent trackEvent2 = TrackerLibrary.ClanJoinRequestAcceptError();
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent2);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent2);
			}
		}
	}

	private sealed class <>c__DisplayClass71_0
	{
		public Action<bool, KammelnaError> callback;

		public ClanServerConnector <>4__this;

		public int memberId;

		internal void <RejectJoinRequest>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_00b6: Expected O, but got I4
			//IL_0154: Expected I8, but got I4
			object obj = (nint)0 + (nint)1048;
			object obj2 = (nint)0 + (nint)2408;
			bool succeeded = response.Succeeded;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F2C978");
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				ITrackEvent trackEvent = TrackerLibrary.ClanJoinRequestRejected();
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				SFS.RefreshClanMembership(memberId);
			}
			else
			{
				ITrackEvent trackEvent2 = TrackerLibrary.ClanJoinRequestRejectError();
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v5+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent2);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent2);
			}
		}
	}

	private sealed class <>c__DisplayClass72_0
	{
		public Action<bool> callback;

		public ClanAdminData newAdminData;

		public ClanServerConnector <>4__this;

		public int memberId;

		internal unsafe void <UpdateAdminPermissions>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01dd: Expected O, but got I4
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected O, but got Unknown
			//IL_0241: Expected O, but got I4
			//IL_00ac: Expected O, but got Ref
			//IL_014c: Expected I8, but got I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_0100: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_017d: Expected O, but got I
			//IL_0195: Expected O, but got I
			object obj = (nint)0 + (nint)1048;
			object obj2 = (nint)0 + (nint)2056;
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
			object obj3 = obj;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				ClanAdminData clanAdminData = newAdminData;
				if (clanAdminData.Permissions != ClanPermissions.None)
				{
					object obj4 = default(object);
					string permissions = ((Enum)(&obj4)).ToString();
					trackEvent = TrackerLibrary.ClanMemberPromoted(permissions);
					object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v19+E4]");
					bool flag = (nint)0 == 0;
					object obj7 = !flag;
					obj3 = 0;
					trackEvent2 = trackEvent;
					if (obj7 == null)
					{
						goto IL_011f;
					}
				}
				else
				{
					trackEvent2 = TrackerLibrary.ClanMemberDemoted();
					object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj6 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v19+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						trackEvent = trackEvent2;
						goto IL_011f;
					}
				}
				goto IL_025c;
			}
			ITrackEvent trackEvent3 = TrackerLibrary.ClanPermissionsUpdateError();
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent3);
			return;
			IL_011f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent2 = trackEvent;
			goto IL_025c;
			IL_025c:
			Tracker.DesignEvent(trackEvent2);
			<>4__this.InvalidateClanCache();
			SFS.RefreshClanMembership(memberId);
			object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v12+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+10]");
			Actions.SafeInvoke((Action<int>)0, memberId);
		}
	}

	private sealed class <>c__DisplayClass73_0
	{
		public Action<bool> callback;

		public ClanServerConnector <>4__this;

		public int memberId;

		internal void <DemoteAdmin>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected O, but got Unknown
			//IL_00af: Expected O, but got I4
			//IL_00e2: Expected I8, but got I4
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			//IL_0113: Expected O, but got I
			//IL_012b: Expected O, but got I
			object obj = (nint)0 + (nint)1048;
			object obj2 = (nint)0 + (nint)2056;
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
			if (response.Succeeded)
			{
				ITrackEvent trackEvent = TrackerLibrary.ClanMemberDemoted();
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				<>4__this.InvalidateClanCache();
				SFS.RefreshClanMembership(memberId);
				object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v12+B8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13+10]");
				Actions.SafeInvoke((Action<int>)0, memberId);
			}
			else
			{
				ITrackEvent trackEvent2 = TrackerLibrary.ClanPermissionsUpdateError();
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent2);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent2);
			}
		}
	}

	private sealed class <>c__DisplayClass76_0
	{
		public Action<List<ClanVaultTransactionModel>> callback;

		internal void <GetClanVaultTransactions>b__0(KammelnaResponseModel<List<ClanVaultTransactionModel>> response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			object obj = typeof(List<AdaptivePerformanceScaler>) + 576;
			object context = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			HandleVaultResponse((KammelnaResponseModel<object>)(object)response, (string)context, list, (Action<object>)callback);
		}
	}

	private sealed class <>c__DisplayClass77_0
	{
		public long feedId;

		public Action<List<ClanVaultSupporterModel>> callback;

		internal void <GetClanVaultSupportRequestSupporters>b__0(KammelnaResponseModel<List<ClanVaultSupporterModel>> response)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0060: Expected O, but got I4
			object format = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2688;
			object obj = typeof(List<AdaptivePerformanceScaler>) + 568;
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string context = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			HandleVaultResponse((KammelnaResponseModel<object>)(object)response, context, list, (Action<object>)callback);
		}
	}

	private sealed class <>c__DisplayClass78_0
	{
		public int amount;

		public Action<bool> callback;

		internal void <DepositToVault>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_002c: Expected O, but got I
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0145: Expected O, but got I4
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_009f: Expected O, but got I4
			//IL_0172: Expected O, but got I4
			//IL_01dc: Expected F8, but got I4
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_00e8: Expected O, but got I
			//IL_00f9: Expected O, but got I
			object obj = (nint)0 + (nint)1048;
			object format = "DNQUALIFIER" + 2488;
			object obj2 = (nint)0 + (nint)1576;
			if (response.Succeeded)
			{
				ITrackEvent trackEvent = TrackerLibrary.ClanVaultDeposited(amount);
				object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				string itemId = Tracker.ItemId(ResourceItemId.ClanVaultDeposit);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Social, itemId, amount, ResourceCurrency.Aces);
				object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v17+B8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v18+20]");
				Actions.SafeInvoke((Action)0);
			}
			else
			{
				ITrackEvent trackEvent2 = TrackerLibrary.ClanVaultDepositError();
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent2);
			}
			object obj12 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D21BE4");
		}
	}

	private sealed class <>c__DisplayClass79_0
	{
		public bool enabled;

		public ClanServerConnector <>4__this;

		public Action<bool> callback;

		internal void <SetAutoRenewal>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_0166: Expected O, but got I4
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_0290: Expected O, but got I4
			//IL_02a1: Expected O, but got I4
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected O, but got Unknown
			//IL_01f2: Expected O, but got I4
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_00b4: Expected O, but got I4
			//IL_0208: Expected O, but got I
			//IL_00ca: Expected O, but got I
			object obj = (nint)0 + (nint)1048;
			object obj2 = obj;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				IntPtr intPtr = default(IntPtr);
				if (enabled)
				{
					trackEvent = TrackerLibrary.ClanAutoRenewalEnabled();
					object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v4+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						object obj6 = (nint)intPtr;
						trackEvent2 = trackEvent;
						goto IL_0193;
					}
				}
				else
				{
					trackEvent = TrackerLibrary.ClanAutoRenewalDisabled();
					object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj4 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v4+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						object obj6 = (nint)intPtr;
						trackEvent2 = trackEvent;
						goto IL_0193;
					}
				}
			}
			else
			{
				object obj9 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object errorMessage = response.ErrorMessage;
				object format = "WhiteSmoke" + 3032;
				object arg = default(object);
				string text = string.Format((string)format, arg, errorMessage);
				object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v14+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				object obj13 = text;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = text;
				}
				KLogger.LogWarning(obj13);
				trackEvent2 = TrackerLibrary.ClanAutoRenewalError();
				object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj4 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v4+E4]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				object obj6 = errorMessage;
				obj2 = 0;
				trackEvent = trackEvent2;
				if (obj15 == null)
				{
					goto IL_0193;
				}
			}
			goto IL_0215;
			IL_0193:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_0215;
			IL_0215:
			Tracker.DesignEvent(trackEvent);
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
		}
	}

	private sealed class <>c__DisplayClass80_0
	{
		public ClanServerConnector <>4__this;

		public Action<bool> callback;

		internal void <BuyEmblemTier>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			//IL_00b1: Expected O, but got I4
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				object obj = "WhiteSmoke" + 2896;
				string text = (string)obj + errorMessage;
				object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				object obj5 = text;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = text;
				}
				KLogger.LogWarning(obj5);
			}
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
		}
	}

	private sealed class <>c__DisplayClass81_0
	{
		public int tier;

		public ClanServerConnector <>4__this;

		public Action<bool> callback;

		internal void <ActivateEmblemTier>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0092: Expected O, but got I4
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0111: Expected O, but got I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0067: Expected O, but got I
			//IL_0078: Expected O, but got I
			if (response.Succeeded)
			{
				<>4__this.InvalidateClanCache();
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v16+B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v17+30]");
				Actions.SafeInvoke((Action)0);
			}
			else
			{
				object obj4 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object errorMessage = response.ErrorMessage;
				object format = "WhiteSmoke" + 2888;
				object arg = default(object);
				string text = string.Format((string)format, arg, errorMessage);
				object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				object obj8 = text;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = text;
				}
				KLogger.LogWarning(obj8);
			}
			bool succeeded = response.Succeeded;
			Actions.SafeInvoke(callback, succeeded);
		}
	}

	private sealed class <>c__DisplayClass82_0
	{
		public Action<List<ClanEmblemTierModel>> callback;

		internal void <GetClanEmblemTiers>b__0(KammelnaResponseModel<List<ClanEmblemTierModel>> response)
		{
			//IL_002d: Expected O, but got I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00ac: Expected O, but got I4
			bool succeeded = ((KammelnaResponseModel<object>)(object)response).Succeeded;
			bool flag = !succeeded;
			object obj = !flag;
			if (obj == null)
			{
				string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				object obj2 = "WhiteSmoke" + 2952;
				string text = (string)obj2 + errorMessage;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj6 = text;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = text;
				}
				KLogger.LogWarning(obj6);
			}
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				Actions.SafeInvoke((Action<object>)callback, response.<Model>k__BackingField);
			}
			else
			{
				Actions.SafeInvoke((Action<object>)callback, null);
			}
		}
	}

	private sealed class <>c__DisplayClass83_0
	{
		public Action<bool> callback;

		internal void <CreateSupportRequest>b__0(KammelnaResponseModel<int> response)
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected O, but got Unknown
			//IL_0147: Expected O, but got I4
			//IL_007b: Expected O, but got I
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I4
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected I4, but got Unknown
			if (response.Succeeded)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int32>)+30]");
				bool flag = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int32>)+30]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int32>)+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int32>)+30]");
				object obj = num ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Int32>)+30]");
				object obj2 = 0 & obj;
				bool flag3 = (nint)obj2 < 0;
				bool flag4 = flag == flag3;
				object obj3 = !flag2;
				bool arg = (byte)((flag4 & obj3) ? 1 : 0) != 0;
				Actions.SafeInvoke(callback, arg);
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				object obj4 = "WhiteSmoke" + 2928;
				string text = (string)obj4 + errorMessage;
				object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				object obj8 = text;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = text;
				}
				KLogger.LogWarning(obj8);
				Actions.SafeInvoke(callback, arg: false);
			}
		}
	}

	private sealed class <>c__DisplayClass84_0
	{
		public int targetAmount;

		public int durationDays;

		public Action<bool, KammelnaError> callback;

		internal unsafe void <CreateVaultSupportRequest>b__0(KammelnaResponseModel<long> response)
		{
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00de: Expected O, but got I4
			//IL_0104: Expected O, but got Ref
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0079: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_05e6: Expected O, but got I
			//IL_0129: Expected O, but got Ref
			//IL_013f: Expected I, but got O
			//IL_014f: Expected O, but got I
			//IL_0178: Expected O, but got I
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01ec: Expected O, but got Ref
			//IL_025d: Expected O, but got I8
			//IL_0202: Expected I, but got O
			//IL_0212: Expected O, but got I
			//IL_023b: Expected O, but got I
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected O, but got Unknown
			//IL_02a6: Expected O, but got I
			//IL_0348: Expected O, but got I4
			//IL_0358: Expected O, but got I4
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Expected O, but got Unknown
			//IL_02e5: Expected I, but got O
			//IL_02f5: Expected O, but got I
			//IL_031e: Expected O, but got I
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Expected O, but got Unknown
			//IL_03d2: Expected O, but got Ref
			//IL_0443: Expected O, but got I8
			//IL_03e8: Expected I, but got O
			//IL_03f8: Expected O, but got I
			//IL_0421: Expected O, but got I
			//IL_0469: Unknown result type (might be due to invalid IL or missing references)
			//IL_046e: Expected O, but got Unknown
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Expected O, but got Unknown
			//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b9: Expected O, but got Unknown
			//IL_04e3: Expected O, but got I4
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Expected O, but got Unknown
			//IL_054e: Expected O, but got I4
			//IL_0565: Expected O, but got I4
			bool flag = response == null;
			KammelnaResponseModel<long> kammelnaResponseModel = response;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			NullReferenceException ex = default(NullReferenceException);
			if (!flag)
			{
				if (response.Succeeded)
				{
					trackEvent = TrackerLibrary.ClanSupportRequestCreated(targetAmount);
					object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v32+E4]");
					bool flag2 = (nint)0 == 0;
					object obj3 = !flag2;
					object obj4 = 0;
					trackEvent2 = trackEvent;
					if (obj3 == null)
					{
						goto IL_0098;
					}
					goto IL_05d1;
				}
				object obj5 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj6 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array = default(object[]);
				bool flag3 = array == null;
				int num = default(int);
				kammelnaResponseModel = (KammelnaResponseModel<long>)(&num);
				if (!flag3)
				{
					object obj7 = default(object);
					bool flag4 = obj7 == null;
					KammelnaResponseModel<long> kammelnaResponseModel2 = (KammelnaResponseModel<long>)(&num);
					if (!flag4)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						kammelnaResponseModel2 = (KammelnaResponseModel<long>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						kammelnaResponseModel = (KammelnaResponseModel<long>)0;
						if (flag5)
						{
							goto IL_0596;
						}
					}
					if (array.Length != 0)
					{
						object obj8 = array + 32;
						obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj9 = default(object);
						bool flag6 = obj9 == null;
						int num3 = default(int);
						kammelnaResponseModel2 = (KammelnaResponseModel<long>)(&num3);
						if (!flag6)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
							kammelnaResponseModel2 = (KammelnaResponseModel<long>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag7 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
							kammelnaResponseModel = (KammelnaResponseModel<long>)0;
							if (flag7)
							{
								goto IL_0596;
							}
						}
						object obj10 = array.Length & 0xFFFFFFFEL;
						if (obj10 != null)
						{
							object obj11 = array + 40;
							obj11 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj12 = (nint)0 + (nint)1256;
							kammelnaResponseModel2 = (KammelnaResponseModel<long>)obj12;
							string errorMessage = response.ErrorMessage;
							if (errorMessage != null)
							{
								nint num5 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
								kammelnaResponseModel2 = (KammelnaResponseModel<long>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag8 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
								kammelnaResponseModel = (KammelnaResponseModel<long>)0;
								if (flag8)
								{
									goto IL_0596;
								}
							}
							bool flag9 = array.Length < 2;
							object obj13 = !flag9;
							object obj14 = array.Length - 2;
							bool flag10 = obj14 == null;
							object obj15 = ~obj13;
							object obj16 = obj15 | flag10;
							if (obj16 == null)
							{
								object obj17 = array + 48;
								obj17 = errorMessage;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object obj18 = default(object);
								bool flag11 = obj18 == null;
								object obj19 = default(object);
								kammelnaResponseModel2 = (KammelnaResponseModel<long>)(&obj19);
								if (!flag11)
								{
									nint num6 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
									kammelnaResponseModel2 = (KammelnaResponseModel<long>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag12 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
									kammelnaResponseModel = (KammelnaResponseModel<long>)0;
									if (flag12)
									{
										goto IL_0596;
									}
								}
								object obj20 = array.Length & 0xFFFFFFFCL;
								if (obj20 != null)
								{
									object obj21 = array + 56;
									obj21 = obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object format = "WhiteSmoke" + 3800;
									string text = string.Format((string)format, array);
									object obj22 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
									object obj23 = obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v24+E4]");
									bool flag13 = (nint)0 == 0;
									object obj24 = !flag13;
									object obj25 = text;
									if (obj24 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj25 = text;
									}
									KLogger.LogWarning(obj25);
									string errorMessage2 = response.ErrorMessage;
									trackEvent2 = TrackerLibrary.ClanSupportRequestError(errorMessage2);
									object obj26 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
									object obj2 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v32+E4]");
									bool flag14 = (nint)0 == 0;
									object obj27 = !flag14;
									if (obj27 == null)
									{
										object obj4 = 0;
										trackEvent = trackEvent2;
										goto IL_0098;
									}
									goto IL_05d1;
								}
							}
						}
					}
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					kammelnaResponseModel = kammelnaResponseModel2;
				}
			}
			ex = new NullReferenceException();
			goto IL_0596;
			IL_0596:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			throw new OutOfMemoryException();
			IL_0098:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent2 = trackEvent;
			goto IL_05d1;
			IL_05d1:
			Tracker.DesignEvent(trackEvent2);
			object obj28 = (nint)0 + (nint)2408;
			bool succeeded = response.Succeeded;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F2C978");
		}
	}

	private const string CLAN_KICKED_TITLE_KEY = "clan_kicked_title";

	private const string CLAN_KICKED_BODY_KEY = "clan_kicked_body";

	private const string CLAN_DISBANDED_TITLE_KEY = "clan_disbanded_title";

	private const string CLAN_DISBANDED_BODY_KEY = "clan_disbanded_body";

	private const float CLAN_CACHE_TTL_SECONDS = 60f;

	private ClanRateLimitConfig rateLimitConfig;

	private readonly RequestCache<int, ClanModel> _clanCache;

	private readonly RequestCache<int, List<UserPendingMembershipModel>> _pendingMembershipsCache;

	private readonly RequestCache<int, List<ClanUserModel>> _joinRequestsCache;

	private static bool <MyClanLoadFailed>k__BackingField;

	public static bool MyClanLoadFailed
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+38]");
			return false;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
		}
	}

	public static event Action<ClanUserModel> OnMyMembershipChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			object obj8 = default(object);
			bool flag2;
			Delegate obj11 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj11 == obj5;
				obj5 = obj11;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			object obj8 = default(object);
			bool flag2;
			Delegate obj11 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj11 == obj5;
				obj5 = obj11;
			}
			while (!flag2);
		}
	}

	public static event Action<ClanModel> OnClanRosterChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<int> OnMemberPermissionsUpdated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<int, bool> OnMyJoinRequestChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 464;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 464;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action OnLocalFeedChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
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
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<ClanActivityType> OnActivityCreated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+28]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1416;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+28]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action OnEmblemTierActivated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+30]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
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
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+30]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	protected override void OnAwake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_018c: Expected O, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0202: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0249: Expected O, but got I4
		//IL_0067: Expected I, but got O
		//IL_008d: Expected I, but got O
		//IL_00b8: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_00ea: Expected I, but got O
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0135: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1232;
		GameObject gameObject = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj6 = (nint)0 + (nint)1624;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
		object obj8 = (nint)0 + (nint)1632;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1544;
		object obj10 = (nint)0 + (nint)1608;
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1584;
		UnityEngine.Object.DontDestroyOnLoad(target);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ClanJoinRequestRateLimiter.Configure(rateLimitConfig);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		SFS.OnLogin += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj8);
		SFS.OnMyUserVariableUpdate += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj10);
		CoordinatorService.OnClanMembershipChanged += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1616;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj14);
		CoordinatorService.OnClanRosterChanged += action4;
		object obj15 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1648;
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj16);
		CoordinatorService.OnConnected += action5;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0160: Expected I, but got O
		//IL_009d: Expected I, but got O
		//IL_00c8: Expected I, but got O
		//IL_00ee: Expected I, but got O
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_012b: Expected O, but got I
		//IL_0139: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj2 = (nint)0 + (nint)1624;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
		object obj4 = (nint)0 + (nint)1632;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1544;
		object obj6 = (nint)0 + (nint)1608;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1584;
		object obj8 = (nint)0 + (nint)1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnLogin -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnMyUserVariableUpdate -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		CoordinatorService.OnClanMembershipChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj8);
		CoordinatorService.OnClanRosterChanged -= action4;
		object obj9 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1648;
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj10);
		CoordinatorService.OnConnected -= action5;
	}

	public void ConnectToClan()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8832]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = "WhiteSmoke" + 2920;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "WhiteSmoke" + 2920;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogWarning(obj6);
		return;
		IL_0094:
		KLogger.LogWarning(obj4);
	}

	public ClanUserModel GetMyMembership()
	{
		ClanUserModel mySelf = (ClanUserModel)SFS.MySelf;
		if (mySelf != null)
		{
			return SFSKammelnaUserExtensions.GetClanMembership((User)mySelf);
		}
		return mySelf;
	}

	public void GetClan(int id, Action<ClanModel> callback)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1FBC");
	}

	public void GetMyClan(Action<ClanModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_00bf: Expected I, but got O
		//IL_00d5: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		User mySelf = SFS.MySelf;
		if (mySelf != null)
		{
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
			object obj5 = (nint)0 + (nint)536;
			User mySelf2 = SFS.MySelf;
			int clanId = SFSKammelnaUserExtensions.GetClanId(mySelf2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			object obj6 = (nint)0 + (nint)1120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1FBC");
		}
		else
		{
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v6+B8]");
			object obj9 = 0;
			_ = 0;
			Actions.SafeInvoke((Action<object>)obj3, null);
		}
	}

	private static void FetchClan(int id, Action<ClanModel> onDone)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 528;
		object obj4 = (nint)0 + (nint)544;
		object obj5 = obj2 + 24;
		obj5 = onDone;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		KammelnaRequests.GetClan(0, action);
	}

	private static void FetchJoinRequests(int clanId, Action<List<ClanUserModel>> onDone)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 328;
		object obj4 = (nint)0 + (nint)552;
		object obj5 = obj2 + 16;
		obj5 = onDone;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetClanJoinRequests(action);
	}

	private static void FetchMyPendingMemberships(int userId, Action<List<UserPendingMembershipModel>> onDone)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 432;
		object obj4 = (nint)0 + (nint)568;
		object obj5 = obj2 + 16;
		obj5 = onDone;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetMyPendingMemberships(action);
	}

	private void InvalidateClanCache()
	{
		//IL_0011: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0047: Expected O, but got I
		object obj = (nint)0 + (nint)1112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD226C");
		object obj2 = (nint)0 + (nint)1088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD226C");
		object obj3 = (nint)0 + (nint)1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD226C");
	}

	private void RaiseClanRosterChanged()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ff: Expected O, but got I4
		//IL_006a: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_020b: Expected O, but got I
		//IL_021c: Expected I, but got O
		//IL_023a: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_015f: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
		InvalidateClanCache();
		RefreshPendingRequestsBadge();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj4 = typeof(CardUtils.<>c) + 1288;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+E4]");
		object obj6;
		Action<ClanModel> callback;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v9+10]");
			callback = (Action<ClanModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v9+10]");
			if ((nint)0 != 0)
			{
				goto IL_009f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v9+10]");
			callback = (Action<ClanModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v9+10]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_009f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v15+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)528;
		Action<object> action = default(Action<object>);
		action..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v14+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = (object)this == null;
		object obj14 = !flag3;
		callback = action;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_009f;
		IL_009f:
		GetMyClan(callback);
	}

	private void HandleUserVariableUpdate(List<string> changed)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00cc: Expected O, but got I
		if (changed == null)
		{
			return;
		}
		object item = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3304;
		if (((List<object>)(object)changed).Contains(item))
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+B8]");
			object obj3 = 0;
			_ = 0;
			InvalidateClanCache();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+B8]");
			object action = 0;
			User mySelf = SFS.MySelf;
			bool flag = mySelf == null;
			object arg = null;
			if (!flag)
			{
				ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(mySelf);
				arg = clanMembership;
			}
			Actions.SafeInvoke((Action<object>)action, arg);
			RefreshPendingRequestsBadge();
		}
	}

	private void HandleClanMembershipChanged(ClanMembershipChanged payload)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0032: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_020b: Expected O, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_006c: Expected I8, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0252: Expected O, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		InvalidateClanCache();
		object obj = (??)payload.ClanId & 1;
		bool flag = obj == null;
		object obj2 = !flag;
		string text = (string)(object)payload;
		if (obj2 == null)
		{
			User mySelf = SFS.MySelf;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(mySelf);
			SFS.RefreshClanMembership(intDbId);
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v19+B8]");
			object obj5 = 0;
			object obj6 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
			text = (string)obj6;
			((CoordinatorVariableBinder)obj5).ClearCached((string)obj6);
		}
		object obj9;
		object obj10;
		object obj12;
		object obj13;
		if (payload.ChangeType != ClanMembershipChangeType.Disbanded)
		{
			if (payload.ChangeType != ClanMembershipChangeType.Kicked)
			{
				return;
			}
			object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj8 = obj7;
			obj9 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3696;
			obj10 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3704;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			obj12 = obj10;
			obj13 = obj9;
			if (obj11 == null)
			{
				goto IL_016f;
			}
		}
		else
		{
			object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj8 = obj14;
			obj13 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3520;
			obj12 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				obj10 = obj12;
				obj9 = obj13;
				goto IL_016f;
			}
		}
		goto IL_018e;
		IL_018e:
		object buttonText = "Network Authentication Required" + 3128;
		PopupWindow.ShowInfo((string)obj12, (string)obj13, (string)buttonText);
		return;
		IL_016f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj10;
		obj13 = obj9;
		goto IL_018e;
	}

	private void HandleLogin(BaseEvent evt)
	{
		RefreshPendingRequestsBadge();
	}

	private void HandleClanRosterChanged(ClanRosterChanged payload)
	{
		RaiseClanRosterChanged();
	}

	private static ClanModel MapToClanModel(ClanViewModel viewModel)
	{
		return viewModel;
	}

	private static ClanModel MapToClanModel(ClanCardModel card)
	{
		return card;
	}

	public static void NotifyActivityCreated(ClanActivityType type, string details = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		//IL_00a8: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_00e6: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
		string details2 = default(string);
		ITrackEvent trackEvent = TrackerLibrary.ClanActivityCreated(type, details2);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+28]");
		Actions.SafeInvoke((Action<System.Int32Enum>)0, (System.Int32Enum)type);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v7+20]");
		Actions.SafeInvoke((Action)0);
	}

	public void GetClanFeed(int limit, long? beforeId, Action<List<ClanFeedModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 312;
		object obj4 = (nint)0 + (nint)576;
		object obj5 = obj2 + 16;
		IntPtr intPtr = default(IntPtr);
		obj5 = (nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetClanFeed(limit, beforeId, (Action<KammelnaResponseModel<List<ClanFeedModel>>>)callback);
	}

	public void HasOpenVaultSupportRequest(Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		//IL_008d: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 736;
		object obj4 = (nint)0 + (nint)584;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		((ClanServerConnector)(object)action).GetClanFeed(50, (long?)(object)0, (Action<List<ClanFeedModel>>)null);
	}

	public void DeleteAnnouncement(long feedId, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)592;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.DeleteClanAnnouncement(feedId, action);
	}

	public void PinFeed(long feedId, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)600;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.PinClanFeed(feedId, action);
	}

	public void UnpinFeed(long feedId, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)608;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.UnpinClanFeed(feedId, action);
	}

	public void GetClanLeaderboard(Games game, Action<List<InterClanLeaderboardEntryModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_0112: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(DataRelation) + 712;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 376;
		object obj5 = (nint)0 + (nint)616;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		DateTime dateTime = default(DateTime);
		int year = dateTime.Year;
		int month = dateTime.Month;
		DateTime firstDayOfTheMonth = new DateTime(year, month, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		KammelnaRequests.GetClanInterClanLeaderboard(firstDayOfTheMonth, game, action);
	}

	public void GetClanLanding(Games game, Action<ClanLandingResponseModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 512;
		object obj4 = (nint)0 + (nint)624;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetClanLanding(game, action);
	}

	public void GetAllClans(Action<ClanModel[]> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 296;
		object obj4 = (nint)0 + (nint)632;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetClans(null, action);
	}

	public void SendCreateClan(ClanCreationModel model, Action<KammelnaResponseModel<int>> callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 552;
		object obj4 = (nint)0 + (nint)640;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.CreateClan(model, action);
	}

	public void SendEditClan(ClanCreationModel model, Action<bool> callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_013b: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(DataRelation) + 2928;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EditClanModel editClanModel = default(EditClanModel);
		editClanModel..ctor();
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj7 = (nint)0 + (nint)648;
		object obj8 = editClanModel + 16;
		obj8 = model.Name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = editClanModel + 24;
		obj9 = model.Description;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = editClanModel + 32;
		obj10 = model.Rules;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		KammelnaRequests.EditClan(editClanModel, action);
	}

	public void LeaveClan(Action<ClanResult> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)656;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.LeaveClanRequest(action);
	}

	public void GetSuggestedOwner(Action<ClanResult<ClanMemberViewModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 520;
		object obj4 = (nint)0 + (nint)664;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetSuggestedOwner(action);
	}

	public void TransferOwnership(int newOwnerId, Action<ClanResult> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00b5: Expected I8, but got I
		object obj = typeof(CardUtils.<>c) + 1424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)672;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		KammelnaRequests.TransferClanOwnership(0L, action);
	}

	public void GetJoinRequests(int clanId, Action<IEnumerable<ClanUserModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		//IL_008a: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 752;
		object obj4 = (nint)0 + (nint)680;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj6 = (nint)0 + (nint)1072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1FBC");
	}

	public void GetMyPendingMemberships(Action<List<UserPendingMembershipModel>> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0193: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8855]");
		object obj3 = (nint)0 & (nint)1;
		RequestCache<int, List<UserPendingMembershipModel>> pendingMembershipsCache2;
		RequestCache<int, List<UserPendingMembershipModel>> pendingMembershipsCache;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			pendingMembershipsCache = _pendingMembershipsCache;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			pendingMembershipsCache2 = _pendingMembershipsCache;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			pendingMembershipsCache = _pendingMembershipsCache;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			pendingMembershipsCache2 = _pendingMembershipsCache;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		pendingMembershipsCache = pendingMembershipsCache2;
		goto IL_0168;
		IL_0168:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj8 = (nint)0 + (nint)1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1FBC");
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0168;
	}

	public void RequestJoinClan(int clanId, Action<bool, KammelnaError> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)688;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		KammelnaRequests.RequestJoinClan(0, action);
	}

	public void CancelJoinRequest(int clanId, Action<bool, KammelnaError> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)696;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		KammelnaRequests.CancelJoinRequest(0, action);
	}

	public void KickClanMember(int memberId, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00b5: Expected I8, but got I
		object obj = typeof(CardUtils.<>c) + 1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)704;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		KammelnaRequests.KickClanMember(0L, action);
	}

	public void AcceptJoinRequest(int memberId, Action<bool, KammelnaError> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00b5: Expected I8, but got I
		object obj = typeof(CardUtils.<>c) + 1464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)712;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		KammelnaRequests.AcceptClanRequest(0L, action);
	}

	public void RejectJoinRequest(int memberId, Action<bool, KammelnaError> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ad: Expected I8, but got I4
		object obj = typeof(CardUtils.<>c) + 1472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)720;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.RefuseClanRequest(memberId, action);
	}

	public void UpdateAdminPermissions(int memberId, ClanAdminData newAdminData, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00c6: Expected I8, but got I
		//IL_00d6: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_0158: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(DataRelation) + 2912;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = newAdminData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EditClanMembershipModel editClanMembershipModel = default(EditClanMembershipModel);
		editClanMembershipModel..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+28]");
		editClanMembershipModel.TargetUserId = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+18]");
		object obj7 = 0;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj9 = (nint)0 + (nint)728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+18]");
		editClanMembershipModel.Permissions = ClanPermissions.None;
		object obj10 = editClanMembershipModel + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+10]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		KammelnaRequests.EditMembershipRequest(editClanMembershipModel, action);
	}

	public void DemoteAdmin(int memberId, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00c1: Expected I8, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_0110: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(DataRelation) + 2912;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EditClanMembershipModel editClanMembershipModel = default(EditClanMembershipModel);
		editClanMembershipModel..ctor();
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj7 = (nint)0 + (nint)736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+20]");
		editClanMembershipModel.TargetUserId = 0L;
		editClanMembershipModel.Permissions = ClanPermissions.None;
		object obj8 = editClanMembershipModel + 24;
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		KammelnaRequests.EditMembershipRequest(editClanMembershipModel, action);
	}

	private void RefreshPendingRequestsBadge()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0178: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00d2: Expected I, but got O
		//IL_00e3: Expected O, but got I
		if (CanSeePendingRequests())
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1496;
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj6);
			object obj7 = (nint)0 + (nint)1072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1FBC");
		}
		else
		{
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CounterBubbleManager.UpdateCounter(CounterBubbleType.ClanJoinRequests, 0);
		}
	}

	private bool CanSeePendingRequests()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01eb: Expected I4, but got O
		//IL_01cf: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E885D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_01dd;
		IL_00b8:
		User localUser = sessionModel.LocalUser;
		if (localUser != null)
		{
			User mySelf = SFS.MySelf;
			if (mySelf != null)
			{
				ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(mySelf);
				if (clanMembership != null)
				{
					return clanMembership.CanManageRequests;
				}
			}
		}
		return false;
		IL_01dd:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_01dd;
	}

	public void GetClanVaultTransactions(int limit, Action<List<ClanVaultTransactionModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 344;
		object obj4 = (nint)0 + (nint)744;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetClanVaultTransactions(limit, action);
	}

	public void GetClanVaultSupportRequestSupporters(long feedId, Action<List<ClanVaultSupporterModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		//IL_0093: Expected I8, but got I
		object obj = typeof(CardUtils.<>c) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 336;
		object obj4 = (nint)0 + (nint)752;
		object obj5 = obj2 + 24;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		KammelnaRequests.GetClanVaultSupportRequestSupporters(0L, action);
	}

	public void DepositToVault(int amount, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)760;
		object obj5 = obj2 + 24;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		KammelnaRequests.DepositToClanVault(0, action);
	}

	public void SetAutoRenewal(bool enabled, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)768;
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
		KammelnaRequests.SetClanAutoRenewal(enabled: false, action);
	}

	public void BuyEmblemTier(Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)776;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.BuyEmblemTier(action);
	}

	public void ActivateEmblemTier(int tier, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)784;
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
		KammelnaRequests.ActivateEmblemTier(0, action);
	}

	public void GetClanEmblemTiers(Action<List<ClanEmblemTierModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 304;
		object obj4 = (nint)0 + (nint)792;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetClanEmblemTiers(action);
	}

	public void CreateSupportRequest(Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 552;
		object obj4 = (nint)0 + (nint)800;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.CreateClanSupportRequest(action);
	}

	public void CreateVaultSupportRequest(int targetAmount, int durationDays, Action<bool, KammelnaError> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0083: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 560;
		object obj4 = (nint)0 + (nint)808;
		object obj5 = obj2 + 24;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+14]");
		KammelnaRequests.CreateClanVaultSupportRequest((int)num, 0, action);
	}

	private static void HandleVaultResponse<T>(KammelnaResponseModel<T> response, string context, T fallback, Action<T> callback)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected I4, but got Unknown
		T val;
		if (response.Succeeded)
		{
			val = response.<Model>k__BackingField;
		}
		else
		{
			string errorMessage = response.ErrorMessage;
			object obj = "WhiteSmoke" + 3792;
			object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 896;
			string text = (string)obj + context + (string)obj2 + errorMessage;
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			object obj6 = text;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = text;
			}
			KLogger.LogWarning(obj6);
			val = fallback;
		}
		bool arg = (byte)(val & 1) != 0;
		Actions.SafeInvoke((Action<bool>)(object)callback, arg);
	}

	public ClanServerConnector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_020e: Expected O, but got I
		//IL_0226: Expected I, but got O
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00c9: Expected I, but got O
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_0141: Expected I, but got O
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01da: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 456;
		object obj2 = (nint)0 + (nint)1584;
		object obj3 = typeof(Queue<string>) + 520;
		object obj4 = (nint)0 + (nint)1104;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 448;
		object obj6 = (nint)0 + (nint)1600;
		object obj7 = typeof(Queue<string>) + 512;
		object obj8 = (nint)0 + (nint)1080;
		object obj9 = (nint)0 + (nint)1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action = default(Action<int, object>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1EE0");
		object obj10 = this + 40;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action2 = default(Action<int, object>);
		action2..ctor((object)null, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1EE0");
		object obj12 = this + 48;
		object obj13 = default(object);
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action3 = default(Action<int, object>);
		action3..ctor((object)null, (IntPtr)(object)((nint)0 + (nint)1592));
		object obj15 = typeof(Queue<string>) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1EE0");
		object obj17 = this + 56;
		object obj18 = default(object);
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19 = typeof(Queue<string>) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v23+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
