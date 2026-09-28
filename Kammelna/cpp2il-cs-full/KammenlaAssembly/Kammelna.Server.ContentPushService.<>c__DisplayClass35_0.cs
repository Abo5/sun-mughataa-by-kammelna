using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Server.Models.Products;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Kammelna.Server;

public static class ContentPushService
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__34_0;

		public static Func<string> <>9__34_1;

		public static Func<CachedModel<List<MatchPredictionModel>>> <>9__34_2;

		public static Func<MatchPredictionModel, int> <>9__34_3;

		public static Func<string> <>9__34_4;

		public static Func<CachedModel<List<MassEventModel>>> <>9__34_5;

		public static Func<MassEventModel, long> <>9__34_6;

		public static Action <>9__34_7;

		public static Func<string> <>9__34_8;

		public static Func<CachedModel<List<GameAchievementViewModel>>> <>9__34_9;

		public static Func<GameAchievementViewModel, string> <>9__34_10;

		public static Action <>9__34_11;

		public static Func<string> <>9__34_12;

		public static Func<CachedModel<List<Notification>>> <>9__34_13;

		public static Func<Notification, int> <>9__34_14;

		public static Action <>9__34_15;

		public static Func<string> <>9__34_16;

		public static Func<CachedModel<List<AppAnnouncementModel>>> <>9__34_17;

		public static Func<AppAnnouncementModel, int> <>9__34_18;

		public static Action <>9__34_19;

		public static Func<string> <>9__34_20;

		public static Func<CachedModel<List<StoreItem>>> <>9__34_21;

		public static Func<StoreItem, int> <>9__34_22;

		public static Func<string> <>9__34_23;

		public static Func<CachedModel<List<ProfileGiftModel>>> <>9__34_24;

		public static Func<ProfileGiftModel, long> <>9__34_25;

		public static Func<string> <>9__34_26;

		public static Func<CachedModel<List<ProductViewModel>>> <>9__34_27;

		public static Func<ProductViewModel, int> <>9__34_28;

		public static Func<IContentApplier, string> <>9__34_29;

		public static Action<IContentApplier> <>9__35_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <BuildCatalog>b__34_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c9: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_0109: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8245]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CachedModel<StoreHomePageViewModel> storeHomePage = CachedModels.StoreHomePage;
			bool flag2 = storeHomePage == null;
			object obj5 = !flag2;
			CachedModel<object> cachedModel = (CachedModel<object>)(object)storeHomePage;
			if (obj5 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_008a;
			IL_0074:
			CachedModel<StoreHomePageViewModel> storeHomePage2 = CachedModels.StoreHomePage;
			cachedModel = (CachedModel<object>)(object)storeHomePage2;
			goto IL_008a;
			IL_008a:
			cachedModel.ClearLastUpdateDate((DateTime?)(object)0);
		}

		internal string <BuildCatalog>b__34_1()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			return "alignContent" + 1408;
		}

		internal CachedModel<List<MatchPredictionModel>> <BuildCatalog>b__34_2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8247]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.UpcomingPredictionsModel;
			IL_0074:
			return CachedModels.UpcomingPredictionsModel;
		}

		internal int <BuildCatalog>b__34_3(MatchPredictionModel m)
		{
			//IL_0035: Expected I4, but got O
			if (m != null)
			{
				return m.<id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal string <BuildCatalog>b__34_4()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			return "alignContent" + 1360;
		}

		internal CachedModel<List<MassEventModel>> <BuildCatalog>b__34_5()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8249]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.MassEvents;
			IL_0074:
			return CachedModels.MassEvents;
		}

		internal long <BuildCatalog>b__34_6(MassEventModel m)
		{
			//IL_0035: Expected I8, but got O
			if (m != null)
			{
				return m.<Id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal void <BuildCatalog>b__34_7()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00cf: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_0107: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E824A]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object action = 0;
			Actions.SafeInvoke((Action)action);
			return;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object action2 = 0;
			Actions.SafeInvoke((Action)action2);
		}

		internal string <BuildCatalog>b__34_8()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			return "alignContent" + 728;
		}

		internal CachedModel<List<GameAchievementViewModel>> <BuildCatalog>b__34_9()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E824C]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.Achievements;
			IL_0074:
			return CachedModels.Achievements;
		}

		internal string <BuildCatalog>b__34_10(GameAchievementViewModel m)
		{
			if (m != null)
			{
				return m.<id>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal void <BuildCatalog>b__34_11()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a6: Expected O, but got I
			//IL_010f: Expected O, but got I
			//IL_0120: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E824D]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+8]");
			Actions.SafeInvoke((Action)0);
			return;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			Actions.SafeInvoke((Action)0);
		}

		internal string <BuildCatalog>b__34_12()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			return "alignContent" + 1504;
		}

		internal CachedModel<List<Notification>> <BuildCatalog>b__34_13()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E824F]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.Notifications;
			IL_0074:
			return CachedModels.Notifications;
		}

		internal int <BuildCatalog>b__34_14(Notification n)
		{
			//IL_0035: Expected I4, but got O
			if (n != null)
			{
				return n.<id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <BuildCatalog>b__34_15()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a6: Expected O, but got I
			//IL_010f: Expected O, but got I
			//IL_0120: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8250]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+10]");
			Actions.SafeInvoke((Action)0);
			return;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+10]");
			Actions.SafeInvoke((Action)0);
		}

		internal string <BuildCatalog>b__34_16()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			return "alignContent" + 736;
		}

		internal CachedModel<List<AppAnnouncementModel>> <BuildCatalog>b__34_17()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8252]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.AppAnnouncements;
			IL_0074:
			return CachedModels.AppAnnouncements;
		}

		internal int <BuildCatalog>b__34_18(AppAnnouncementModel a)
		{
			//IL_0035: Expected I4, but got O
			if (a != null)
			{
				return a.<Id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <BuildCatalog>b__34_19()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a6: Expected O, but got I
			//IL_010f: Expected O, but got I
			//IL_0120: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8253]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+18]");
			Actions.SafeInvoke((Action)0);
			return;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+18]");
			Actions.SafeInvoke((Action)0);
		}

		internal string <BuildCatalog>b__34_20()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			return "alignContent" + 1280;
		}

		internal CachedModel<List<StoreItem>> <BuildCatalog>b__34_21()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8255]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.StoreItems;
			IL_0074:
			return CachedModels.StoreItems;
		}

		internal int <BuildCatalog>b__34_22(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal string <BuildCatalog>b__34_23()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			return "alignContent" + 1296;
		}

		internal CachedModel<List<ProfileGiftModel>> <BuildCatalog>b__34_24()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8257]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.StoreProfileGifts;
			IL_0074:
			return CachedModels.StoreProfileGifts;
		}

		internal long <BuildCatalog>b__34_25(ProfileGiftModel g)
		{
			//IL_0035: Expected I8, but got O
			if (g != null)
			{
				return g.ID;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal string <BuildCatalog>b__34_26()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 728;
			object format = "alignContent" + 1288;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Platform platform = KUtil.GetPlatform();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			return string.Format((string)format, arg);
		}

		internal CachedModel<List<ProductViewModel>> <BuildCatalog>b__34_27()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8259]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return CachedModels.StoreProducts;
			IL_0074:
			return CachedModels.StoreProducts;
		}

		internal int <BuildCatalog>b__34_28(ProductViewModel p)
		{
			//IL_0035: Expected I4, but got O
			if (p != null)
			{
				return p.<id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal string <BuildCatalog>b__34_29(IContentApplier applier)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (applier != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1824;
				num = (nint)applier;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				goto IL_00d9;
			}
			goto IL_0116;
			IL_0116:
			return (string)(object)new NullReferenceException();
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}

		internal void <OnContentChangedReceived>b__35_1(IContentApplier applier)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_011a: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1824;
			nint num = (nint)applier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			goto IL_0124;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_0124:
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			goto IL_00d9;
			IL_00d9:
			object obj7 = obj3 + 1;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0124;
		}
	}

	private sealed class <>c__DisplayClass35_0
	{
		public string wireKey;

		internal void <OnContentChangedReceived>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected O, but got Unknown
			//IL_01d1: Expected O, but got I4
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00d4: Expected O, but got I
			//IL_00e4: Expected O, but got I
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_02b1: Expected O, but got I4
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected O, but got Unknown
			//IL_022f: Expected O, but got I
			//IL_023f: Expected O, but got I
			//IL_0269: Expected O, but got I4
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected O, but got Unknown
			//IL_03a9: Expected O, but got I
			//IL_03ba: Expected I, but got O
			//IL_03d8: Expected O, but got I
			//IL_0310: Expected O, but got I4
			//IL_0319: Expected O, but got I4
			//IL_033a: Expected O, but got I4
			//IL_02e1: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(CardUtils.<>c) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E825C]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			string text;
			object obj7;
			string text2;
			object obj5;
			if (obj3 != null)
			{
				obj4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2840;
				text = wireKey;
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				text2 = wireKey;
				if (!flag)
				{
					goto IL_00b0;
				}
			}
			else
			{
				_ = 1;
				obj4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2840;
				text = wireKey;
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				text2 = wireKey;
				if (obj8 != null)
				{
					goto IL_00b0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v4+F8]");
			Action<IContentApplier> action = (Action<IContentApplier>)0;
			string text3 = (string)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v4+F8]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			text = text2;
			object obj12 = obj9;
			string text4 = (string)obj7;
			if (obj11 != null)
			{
				goto IL_0129;
			}
			goto IL_028f;
			IL_0129:
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v1+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = default(object);
			object obj14 = obj15;
			Action<IContentApplier> action2 = action;
			text4 = text3;
			text2 = text;
			if (!flag4)
			{
				goto IL_0176;
			}
			goto IL_0350;
			IL_0350:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj14;
			action = action2;
			text3 = text4;
			text = text2;
			goto IL_0176;
			IL_0176:
			Apply(text, text3, action);
			return;
			IL_00b0:
			obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v4+F8]");
			action = (Action<IContentApplier>)0;
			text3 = (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v4+F8]");
			bool flag5 = (nint)0 == 0;
			obj12 = obj9;
			text4 = (string)obj4;
			text2 = text;
			if (!flag5)
			{
				goto IL_0129;
			}
			goto IL_028f;
			IL_028f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj17 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v11+B8]");
				obj10 = 0;
			}
			object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj19 = (nint)0 + (nint)2160;
			Action<object> action3 = default(Action<object>);
			action3..ctor(obj10, (IntPtr)obj19);
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v9+B8]");
			object obj21 = (nint)0 + (nint)248;
			obj21 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v1+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			obj15 = 0;
			action = action3;
			text3 = text4;
			text = text2;
			obj14 = 0;
			action2 = action3;
			if (obj22 != null)
			{
				goto IL_0176;
			}
			goto IL_0350;
		}
	}

	private sealed class <>c__DisplayClass36_0
	{
		public string wireKey;

		public string payloadJson;

		public Action<IContentApplier> <>9__1;

		internal void <OnContentDeltaReceived>b__0()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0095: Expected O, but got I
			//IL_00a3: Expected I, but got O
			//IL_00e6: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			//IL_0100: Expected O, but got I4
			//IL_006a: Expected O, but got I
			object kind = "com.unity.services.authentication.profile" + 3832;
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = this + 32;
			Action<object> action = (Action<object>)obj2;
			object obj4;
			Action<object> action2;
			object obj5 = default(object);
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				obj4 = obj5;
				action2 = action;
				if (!flag)
				{
					goto IL_0051;
				}
			}
			else
			{
				object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)2184;
				Action<object> action3 = default(Action<object>);
				action3..ctor((object)this, (IntPtr)obj7);
				<>9__1 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj5 = 0;
				action = action3;
				obj4 = 0;
				action2 = action3;
				if (obj8 != null)
				{
					goto IL_0051;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
			action = action2;
			goto IL_0051;
			IL_0051:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v2-10]");
			Apply((string)0, (string)kind, action);
		}

		internal void <OnContentDeltaReceived>b__1(IContentApplier applier)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002b: Expected I, but got O
			//IL_003b: Expected O, but got I
			//IL_0130: Expected O, but got I
			//IL_0076: Expected O, but got I
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1824;
			string text = payloadJson;
			nint num = (nint)applier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00b7;
			}
			object obj4 = obj3 + 2;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0118;
			IL_00b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0118;
			IL_0118:
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v3+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public string wireKey;

		public string modelJson;

		public Action<IContentApplier> <>9__1;

		internal void <OnContentBlobReceived>b__0()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0095: Expected O, but got I
			//IL_00a3: Expected I, but got O
			//IL_00e6: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			//IL_0100: Expected O, but got I4
			//IL_006a: Expected O, but got I
			object kind = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 528;
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = this + 32;
			Action<object> action = (Action<object>)obj2;
			object obj4;
			Action<object> action2;
			object obj5 = default(object);
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				obj4 = obj5;
				action2 = action;
				if (!flag)
				{
					goto IL_0051;
				}
			}
			else
			{
				object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)2200;
				Action<object> action3 = default(Action<object>);
				action3..ctor((object)this, (IntPtr)obj7);
				<>9__1 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj5 = 0;
				action = action3;
				obj4 = 0;
				action2 = action3;
				if (obj8 != null)
				{
					goto IL_0051;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
			action = action2;
			goto IL_0051;
			IL_0051:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v2-10]");
			Apply((string)0, (string)kind, action);
		}

		internal void <OnContentBlobReceived>b__1(IContentApplier applier)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002b: Expected I, but got O
			//IL_003b: Expected O, but got I
			//IL_0130: Expected O, but got I
			//IL_0076: Expected O, but got I
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1824;
			string text = modelJson;
			nint num = (nint)applier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.IContentApplier>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00b7;
			}
			object obj4 = obj3 + 3;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0118;
			IL_00b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0118;
			IL_0118:
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v3+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public const string REMOTE_CONFIG_WIRE_KEY = "remote_config";

	public const string STORE_ITEM_GROUPS_WIRE_KEY = "store_item_groups";

	public const string STORE_HOME_WIRE_KEY = "store_home";

	public const string UPCOMING_PREDICTIONS_WIRE_KEY = "predictions";

	public const string MASS_EVENTS_WIRE_KEY = "mass_events";

	public const string STORE_ITEMS_WIRE_KEY = "store_items";

	public const string STORE_PROFILE_GIFTS_WIRE_KEY = "store_profile_gifts";

	public const string STORE_PRODUCTS_WIRE_KEY = "store_products";

	public const string ACHIEVEMENTS_WIRE_KEY = "achievements";

	public const string NOTIFICATIONS_WIRE_KEY = "notifications";

	public const string APP_ANNOUNCEMENTS_WIRE_KEY = "app_announcements";

	public const string HINTS_WIRE_KEY = "hints";

	private static readonly Dictionary<string, IContentApplier> APPLIERS;

	public static IEnumerable<IDeltaSyncApplier> DeltaSyncAppliers
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0128: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a5: Expected O, but got I
			//IL_0160: Expected O, but got I
			//IL_0170: Expected O, but got I
			//IL_0192: Expected O, but got I4
			//IL_00d7: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8234]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+30]");
			Dictionary<object, object> dictionary = (Dictionary<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+30]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00ca;
			}
			goto IL_01a0;
			IL_00ca:
			object obj10 = (nint)0 + (nint)1976;
			Dictionary<object, object>.ValueCollection values = dictionary.Values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCBBAC");
			IEnumerable<IDeltaSyncApplier> result = default(IEnumerable<IDeltaSyncApplier>);
			return result;
			IL_01a0:
			return (IEnumerable<IDeltaSyncApplier>)new NullReferenceException();
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v20+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v11+30]");
			dictionary = (Dictionary<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v11+30]");
			if ((nint)0 != 0)
			{
				goto IL_00ca;
			}
			goto IL_01a0;
		}
	}

	public static event Action OnMassEventsApplied
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_013c: Expected O, but got I4
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_016e: Expected O, but got I
			//IL_00e5: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj11 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj11 == obj6;
				obj6 = obj11;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_013c: Expected O, but got I4
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_016e: Expected O, but got I
			//IL_00e5: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj11 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj11 == obj6;
				obj6 = obj11;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnAchievementsApplied
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+8]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnNotificationsApplied
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnAppAnnouncementsApplied
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnUpcomingPredictionsApplied
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnStoreApplied
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static IDeltaSyncApplier GetDeltaSyncApplier(string wireKey)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00ad: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8235]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v24+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v24+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v8+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+30]");
		Dictionary<object, object> dictionary = (Dictionary<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+30]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v24+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v15+30]");
		dictionary = (Dictionary<object, object>)0;
		goto IL_00a1;
		IL_00a1:
		object obj10 = (nint)0 + (nint)2880;
		object obj11 = dictionary.get_Item((object)wireKey);
		bool flag4 = obj11 == null;
		IDeltaSyncApplier deltaSyncApplier = (IDeltaSyncApplier)obj11;
		if (!flag4)
		{
			object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			if (deltaSyncApplier == null)
			{
				return (IDeltaSyncApplier)new InvalidCastException();
			}
		}
		return deltaSyncApplier;
	}

	private static Dictionary<string, IContentApplier> BuildCatalog()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_4d7e: Expected I, but got O
		//IL_4d8c: Expected I, but got O
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00de: Expected I, but got O
		//IL_00ee: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0196: Expected I, but got O
		//IL_01a4: Expected I, but got O
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0209: Expected I, but got O
		//IL_0219: Expected O, but got I
		//IL_0264: Expected O, but got I8
		//IL_0292: Expected O, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02d8: Expected I, but got O
		//IL_02e6: Expected I, but got O
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_034b: Expected I, but got O
		//IL_035b: Expected O, but got I
		//IL_03ae: Expected O, but got I4
		//IL_03c4: Expected O, but got I
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0530: Expected O, but got I
		//IL_0540: Expected O, but got I
		//IL_056a: Expected O, but got I4
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0490: Expected O, but got I
		//IL_04a0: Expected O, but got I
		//IL_04ca: Expected O, but got I4
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_05b7: Expected O, but got I4
		//IL_0651: Expected I, but got O
		//IL_0661: Expected O, but got I
		//IL_4da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4da5: Expected O, but got Unknown
		//IL_4dbb: Expected O, but got I
		//IL_4dc3: Expected I, but got O
		//IL_4dd4: Expected I, but got O
		//IL_4df2: Expected O, but got I
		//IL_05e7: Expected O, but got I
		//IL_06a2: Expected O, but got I8
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_2df2: Expected O, but got I
		//IL_2e02: Expected O, but got I
		//IL_2e2c: Expected O, but got I4
		//IL_072b: Expected O, but got I
		//IL_073b: Expected O, but got I
		//IL_2f3d: Expected O, but got I
		//IL_2f4d: Expected O, but got I
		//IL_2f6f: Expected O, but got I4
		//IL_2e6c: Expected O, but got I4
		//IL_0869: Expected I, but got O
		//IL_08a1: Expected I, but got O
		//IL_07e5: Expected O, but got I
		//IL_07f5: Expected O, but got I
		//IL_530b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5310: Expected O, but got Unknown
		//IL_5326: Expected O, but got I
		//IL_532e: Expected I, but got O
		//IL_533f: Expected I, but got O
		//IL_535d: Expected O, but got I
		//IL_2fcf: Expected O, but got I4
		//IL_2ecb: Expected O, but got I4
		//IL_2efd: Expected I, but got O
		//IL_2e9c: Expected O, but got I
		//IL_08bb: Expected O, but got I
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08db: Expected O, but got I
		//IL_08eb: Expected O, but got I
		//IL_08fb: Expected O, but got I
		//IL_091d: Expected O, but got I4
		//IL_5383: Unknown result type (might be due to invalid IL or missing references)
		//IL_5388: Expected O, but got Unknown
		//IL_539e: Expected O, but got I
		//IL_53a6: Expected I, but got O
		//IL_53b7: Expected I, but got O
		//IL_53d5: Expected O, but got I
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_09c2: Expected I, but got O
		//IL_302e: Expected O, but got I4
		//IL_3053: Expected I, but got O
		//IL_3068: Expected I, but got O
		//IL_3080: Expected I, but got O
		//IL_2fff: Expected O, but got I
		//IL_094d: Expected O, but got I4
		//IL_4e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e42: Expected O, but got Unknown
		//IL_4e58: Expected O, but got I
		//IL_4e60: Expected I, but got O
		//IL_4e71: Expected I, but got O
		//IL_4e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e85: Expected O, but got Unknown
		//IL_4ea3: Expected O, but got I
		//IL_0aa3: Expected O, but got I4
		//IL_0ab9: Expected O, but got I
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected O, but got Unknown
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected O, but got Unknown
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected O, but got Unknown
		//IL_0991: Expected O, but got I
		//IL_0a15: Expected I, but got O
		//IL_0a25: Expected O, but got I
		//IL_0a6b: Expected O, but got I
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		//IL_30f7: Expected O, but got I
		//IL_3107: Expected O, but got I
		//IL_3131: Expected O, but got I4
		//IL_0b99: Expected O, but got I
		//IL_0ba9: Expected O, but got I
		//IL_3242: Expected O, but got I
		//IL_3252: Expected O, but got I
		//IL_3274: Expected O, but got I4
		//IL_3171: Expected O, but got I4
		//IL_0c63: Expected O, but got I
		//IL_0c73: Expected O, but got I
		//IL_53fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5400: Expected O, but got Unknown
		//IL_5416: Expected O, but got I
		//IL_541e: Expected I, but got O
		//IL_542f: Expected I, but got O
		//IL_544d: Expected O, but got I
		//IL_33ad: Expected O, but got I
		//IL_33bd: Expected O, but got I
		//IL_33df: Expected O, but got I4
		//IL_32d4: Expected O, but got I4
		//IL_31d0: Expected O, but got I4
		//IL_3202: Expected I, but got O
		//IL_31a1: Expected O, but got I
		//IL_0d35: Expected O, but got I
		//IL_0d45: Expected O, but got I
		//IL_5473: Unknown result type (might be due to invalid IL or missing references)
		//IL_5478: Expected O, but got Unknown
		//IL_548e: Expected O, but got I
		//IL_5496: Expected I, but got O
		//IL_54a7: Expected I, but got O
		//IL_54c5: Expected O, but got I
		//IL_3447: Expected O, but got I4
		//IL_3333: Expected O, but got I4
		//IL_336d: Expected I, but got O
		//IL_3304: Expected O, but got I
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2b: Expected O, but got Unknown
		//IL_0e37: Expected O, but got I
		//IL_0e47: Expected O, but got I
		//IL_0e57: Expected O, but got I
		//IL_0e79: Expected O, but got I4
		//IL_54eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_54f0: Expected O, but got Unknown
		//IL_5506: Expected O, but got I
		//IL_550e: Expected I, but got O
		//IL_551f: Expected I, but got O
		//IL_553d: Expected O, but got I
		//IL_34a6: Expected O, but got I4
		//IL_34e8: Expected I, but got O
		//IL_3477: Expected O, but got I
		//IL_0eb1: Expected O, but got I4
		//IL_0fd6: Expected O, but got I4
		//IL_0fec: Expected O, but got I
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected O, but got Unknown
		//IL_103e: Expected I, but got O
		//IL_4ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ee3: Expected O, but got Unknown
		//IL_4ef9: Expected O, but got I
		//IL_4f01: Expected I, but got O
		//IL_4f12: Expected I, but got O
		//IL_4f30: Expected O, but got I
		//IL_0f48: Expected I, but got O
		//IL_0f58: Expected O, but got I
		//IL_0f9e: Expected O, but got I
		//IL_0fa6: Expected I, but got O
		//IL_0ee1: Expected O, but got I
		//IL_1056: Unknown result type (might be due to invalid IL or missing references)
		//IL_105b: Expected O, but got Unknown
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected O, but got Unknown
		//IL_3587: Expected O, but got I
		//IL_3597: Expected O, but got I
		//IL_35c1: Expected O, but got I4
		//IL_114c: Expected I, but got O
		//IL_10b8: Expected O, but got I
		//IL_10c8: Expected O, but got I
		//IL_36d2: Expected O, but got I
		//IL_36e2: Expected O, but got I
		//IL_3704: Expected O, but got I4
		//IL_371c: Expected O, but got I
		//IL_3601: Expected O, but got I4
		//IL_1216: Expected I, but got O
		//IL_1182: Expected O, but got I
		//IL_1192: Expected O, but got I
		//IL_11c1: Expected I, but got O
		//IL_5563: Unknown result type (might be due to invalid IL or missing references)
		//IL_5568: Expected O, but got Unknown
		//IL_557e: Expected O, but got I
		//IL_5586: Expected I, but got O
		//IL_5597: Expected I, but got O
		//IL_55b5: Expected O, but got I
		//IL_383d: Expected O, but got I
		//IL_384d: Expected O, but got I
		//IL_386f: Expected O, but got I4
		//IL_3887: Expected O, but got I
		//IL_3764: Expected O, but got I4
		//IL_3660: Expected O, but got I4
		//IL_3631: Expected O, but got I
		//IL_1254: Expected O, but got I
		//IL_1264: Expected O, but got I
		//IL_1293: Expected I, but got O
		//IL_55db: Unknown result type (might be due to invalid IL or missing references)
		//IL_55e0: Expected O, but got Unknown
		//IL_55f6: Expected O, but got I
		//IL_55fe: Expected I, but got O
		//IL_560f: Expected I, but got O
		//IL_562d: Expected O, but got I
		//IL_38d7: Expected O, but got I4
		//IL_37c3: Expected O, but got I4
		//IL_3794: Expected O, but got I
		//IL_1345: Unknown result type (might be due to invalid IL or missing references)
		//IL_134a: Expected O, but got Unknown
		//IL_1356: Expected O, but got I
		//IL_1366: Expected O, but got I
		//IL_1376: Expected O, but got I
		//IL_1398: Expected O, but got I4
		//IL_13a0: Expected I, but got O
		//IL_5653: Unknown result type (might be due to invalid IL or missing references)
		//IL_5658: Expected O, but got Unknown
		//IL_566e: Expected O, but got I
		//IL_567f: Expected I, but got O
		//IL_569d: Expected O, but got I
		//IL_3936: Expected O, but got I4
		//IL_3907: Expected O, but got I
		//IL_13d0: Expected O, but got I4
		//IL_14f5: Expected O, but got I4
		//IL_150b: Expected O, but got I
		//IL_152b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1530: Expected O, but got Unknown
		//IL_155d: Expected I, but got O
		//IL_4f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f70: Expected O, but got Unknown
		//IL_4f86: Expected O, but got I
		//IL_4f8e: Expected I, but got O
		//IL_4f9f: Expected I, but got O
		//IL_4fbd: Expected O, but got I
		//IL_1467: Expected I, but got O
		//IL_1477: Expected O, but got I
		//IL_14bd: Expected O, but got I
		//IL_14c5: Expected I, but got O
		//IL_1400: Expected O, but got I
		//IL_1575: Unknown result type (might be due to invalid IL or missing references)
		//IL_157a: Expected O, but got Unknown
		//IL_1583: Unknown result type (might be due to invalid IL or missing references)
		//IL_1588: Expected O, but got Unknown
		//IL_3a1f: Expected O, but got I
		//IL_3a2f: Expected O, but got I
		//IL_3a59: Expected O, but got I4
		//IL_166b: Expected I, but got O
		//IL_15d7: Expected O, but got I
		//IL_15e7: Expected O, but got I
		//IL_3b6a: Expected O, but got I
		//IL_3b7a: Expected O, but got I
		//IL_3b9c: Expected O, but got I4
		//IL_3bb4: Expected O, but got I
		//IL_3a99: Expected O, but got I4
		//IL_1735: Expected I, but got O
		//IL_16a1: Expected O, but got I
		//IL_16b1: Expected O, but got I
		//IL_16e0: Expected I, but got O
		//IL_56c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_56c8: Expected O, but got Unknown
		//IL_56de: Expected O, but got I
		//IL_56e6: Expected I, but got O
		//IL_56f7: Expected I, but got O
		//IL_5715: Expected O, but got I
		//IL_3cd5: Expected O, but got I
		//IL_3ce5: Expected O, but got I
		//IL_3d07: Expected O, but got I4
		//IL_3d1f: Expected O, but got I
		//IL_3bfc: Expected O, but got I4
		//IL_3af8: Expected O, but got I4
		//IL_3ac9: Expected O, but got I
		//IL_1807: Expected I, but got O
		//IL_1847: Expected I, but got O
		//IL_1773: Expected O, but got I
		//IL_1783: Expected O, but got I
		//IL_17b2: Expected I, but got O
		//IL_573b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5740: Expected O, but got Unknown
		//IL_5756: Expected O, but got I
		//IL_575e: Expected I, but got O
		//IL_576f: Expected I, but got O
		//IL_578d: Expected O, but got I
		//IL_3d6f: Expected O, but got I4
		//IL_3c5b: Expected O, but got I4
		//IL_3c2c: Expected O, but got I
		//IL_1864: Unknown result type (might be due to invalid IL or missing references)
		//IL_1869: Expected O, but got Unknown
		//IL_1875: Expected O, but got I
		//IL_1885: Expected O, but got I
		//IL_1895: Expected O, but got I
		//IL_18b7: Expected O, but got I4
		//IL_18bf: Expected I, but got O
		//IL_57b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_57b8: Expected O, but got Unknown
		//IL_57ce: Expected O, but got I
		//IL_57df: Expected I, but got O
		//IL_57fd: Expected O, but got I
		//IL_3dce: Expected O, but got I4
		//IL_3e03: Expected I, but got O
		//IL_3e38: Expected I, but got O
		//IL_3d9f: Expected O, but got I
		//IL_18ef: Expected O, but got I4
		//IL_19f8: Expected O, but got I8
		//IL_4ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ffd: Expected O, but got Unknown
		//IL_5013: Expected O, but got I
		//IL_501b: Expected I, but got O
		//IL_502c: Expected I, but got O
		//IL_504a: Expected O, but got I
		//IL_1972: Expected I, but got O
		//IL_1982: Expected O, but got I
		//IL_19c8: Expected O, but got I
		//IL_191f: Expected O, but got I
		//IL_1a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a51: Expected O, but got Unknown
		//IL_1a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5f: Expected O, but got Unknown
		//IL_3eb7: Expected O, but got I
		//IL_3ec7: Expected O, but got I
		//IL_3ef1: Expected O, but got I4
		//IL_1aae: Expected O, but got I
		//IL_1abe: Expected O, but got I
		//IL_4002: Expected O, but got I
		//IL_4012: Expected O, but got I
		//IL_4034: Expected O, but got I4
		//IL_3f31: Expected O, but got I4
		//IL_1b78: Expected O, but got I
		//IL_1b88: Expected O, but got I
		//IL_5823: Unknown result type (might be due to invalid IL or missing references)
		//IL_5828: Expected O, but got Unknown
		//IL_583e: Expected O, but got I
		//IL_5846: Expected I, but got O
		//IL_5857: Expected I, but got O
		//IL_5875: Expected O, but got I
		//IL_416d: Expected O, but got I
		//IL_417d: Expected O, but got I
		//IL_419f: Expected O, but got I4
		//IL_4094: Expected O, but got I4
		//IL_3f90: Expected O, but got I4
		//IL_3fc2: Expected I, but got O
		//IL_3f61: Expected O, but got I
		//IL_1cde: Expected I, but got O
		//IL_1d1e: Expected I, but got O
		//IL_1c4a: Expected O, but got I
		//IL_1c5a: Expected O, but got I
		//IL_589b: Unknown result type (might be due to invalid IL or missing references)
		//IL_58a0: Expected O, but got Unknown
		//IL_58b6: Expected O, but got I
		//IL_58be: Expected I, but got O
		//IL_58cf: Expected I, but got O
		//IL_58ed: Expected O, but got I
		//IL_4207: Expected O, but got I4
		//IL_40f3: Expected O, but got I4
		//IL_412d: Expected I, but got O
		//IL_40c4: Expected O, but got I
		//IL_1d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d40: Expected O, but got Unknown
		//IL_1d4c: Expected O, but got I
		//IL_1d5c: Expected O, but got I
		//IL_1d6c: Expected O, but got I
		//IL_1d8e: Expected O, but got I4
		//IL_5913: Unknown result type (might be due to invalid IL or missing references)
		//IL_5918: Expected O, but got Unknown
		//IL_592e: Expected O, but got I
		//IL_5936: Expected I, but got O
		//IL_5947: Expected I, but got O
		//IL_5965: Expected O, but got I
		//IL_4266: Expected O, but got I4
		//IL_4293: Expected I, but got O
		//IL_42a8: Expected I, but got O
		//IL_42c8: Expected I, but got O
		//IL_4237: Expected O, but got I
		//IL_1dc6: Expected O, but got I4
		//IL_1ed7: Expected O, but got I4
		//IL_1eed: Expected O, but got I
		//IL_1f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f12: Expected O, but got Unknown
		//IL_5085: Unknown result type (might be due to invalid IL or missing references)
		//IL_508a: Expected O, but got Unknown
		//IL_50a0: Expected O, but got I
		//IL_50a8: Expected I, but got O
		//IL_50b9: Expected I, but got O
		//IL_50d7: Expected O, but got I
		//IL_1e49: Expected I, but got O
		//IL_1e59: Expected O, but got I
		//IL_1e9f: Expected O, but got I
		//IL_1df6: Expected O, but got I
		//IL_1f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5c: Expected O, but got Unknown
		//IL_1f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6a: Expected O, but got Unknown
		//IL_4347: Expected O, but got I
		//IL_4357: Expected O, but got I
		//IL_4381: Expected O, but got I4
		//IL_1fb9: Expected O, but got I
		//IL_1fc9: Expected O, but got I
		//IL_4492: Expected O, but got I
		//IL_44a2: Expected O, but got I
		//IL_44c4: Expected O, but got I4
		//IL_43c1: Expected O, but got I4
		//IL_2107: Expected I, but got O
		//IL_213f: Expected I, but got O
		//IL_2083: Expected O, but got I
		//IL_2093: Expected O, but got I
		//IL_598b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5990: Expected O, but got Unknown
		//IL_59a6: Expected O, but got I
		//IL_59ae: Expected I, but got O
		//IL_59bf: Expected I, but got O
		//IL_59dd: Expected O, but got I
		//IL_4524: Expected O, but got I4
		//IL_4420: Expected O, but got I4
		//IL_4452: Expected I, but got O
		//IL_43f1: Expected O, but got I
		//IL_2159: Expected O, but got I
		//IL_2168: Unknown result type (might be due to invalid IL or missing references)
		//IL_216d: Expected O, but got Unknown
		//IL_2179: Expected O, but got I
		//IL_2189: Expected O, but got I
		//IL_2199: Expected O, but got I
		//IL_21bb: Expected O, but got I4
		//IL_5a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a08: Expected O, but got Unknown
		//IL_5a1e: Expected O, but got I
		//IL_5a26: Expected I, but got O
		//IL_5a37: Expected I, but got O
		//IL_5a55: Expected O, but got I
		//IL_224b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2250: Expected O, but got Unknown
		//IL_2268: Expected I, but got O
		//IL_4583: Expected O, but got I4
		//IL_45a8: Expected I, but got O
		//IL_45bd: Expected I, but got O
		//IL_45d5: Expected I, but got O
		//IL_4554: Expected O, but got I
		//IL_21f3: Expected O, but got I4
		//IL_5112: Unknown result type (might be due to invalid IL or missing references)
		//IL_5117: Expected O, but got Unknown
		//IL_512d: Expected O, but got I
		//IL_5135: Expected I, but got O
		//IL_5146: Expected I, but got O
		//IL_5155: Unknown result type (might be due to invalid IL or missing references)
		//IL_515a: Expected O, but got Unknown
		//IL_5178: Expected O, but got I
		//IL_2349: Expected O, but got I4
		//IL_235f: Expected O, but got I
		//IL_237d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2382: Expected O, but got Unknown
		//IL_2393: Unknown result type (might be due to invalid IL or missing references)
		//IL_2398: Expected O, but got Unknown
		//IL_221a: Unknown result type (might be due to invalid IL or missing references)
		//IL_221f: Expected O, but got Unknown
		//IL_2237: Expected O, but got I
		//IL_22bb: Expected I, but got O
		//IL_22cb: Expected O, but got I
		//IL_2311: Expected O, but got I
		//IL_23dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e2: Expected O, but got Unknown
		//IL_23eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f0: Expected O, but got Unknown
		//IL_464c: Expected O, but got I
		//IL_465c: Expected O, but got I
		//IL_4686: Expected O, but got I4
		//IL_243f: Expected O, but got I
		//IL_244f: Expected O, but got I
		//IL_4797: Expected O, but got I
		//IL_47a7: Expected O, but got I
		//IL_47c9: Expected O, but got I4
		//IL_46c6: Expected O, but got I4
		//IL_2509: Expected O, but got I
		//IL_2519: Expected O, but got I
		//IL_5a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a80: Expected O, but got Unknown
		//IL_5a96: Expected O, but got I
		//IL_5a9e: Expected I, but got O
		//IL_5aaf: Expected I, but got O
		//IL_5acd: Expected O, but got I
		//IL_4829: Expected O, but got I4
		//IL_4725: Expected O, but got I4
		//IL_4757: Expected I, but got O
		//IL_46f6: Expected O, but got I
		//IL_25e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e7: Expected O, but got Unknown
		//IL_25f3: Expected O, but got I
		//IL_2603: Expected O, but got I
		//IL_2613: Expected O, but got I
		//IL_2635: Expected O, but got I4
		//IL_5af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5af8: Expected O, but got Unknown
		//IL_5b0e: Expected O, but got I
		//IL_5b16: Expected I, but got O
		//IL_5b27: Expected I, but got O
		//IL_5b45: Expected O, but got I
		//IL_26c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ca: Expected O, but got Unknown
		//IL_26e2: Expected I, but got O
		//IL_4888: Expected O, but got I4
		//IL_48c2: Expected I, but got O
		//IL_4859: Expected O, but got I
		//IL_266d: Expected O, but got I4
		//IL_51b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_51b8: Expected O, but got Unknown
		//IL_51ce: Expected O, but got I
		//IL_51d6: Expected I, but got O
		//IL_51e7: Expected I, but got O
		//IL_51f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_51fb: Expected O, but got Unknown
		//IL_5219: Expected O, but got I
		//IL_27d7: Expected O, but got I4
		//IL_27ed: Expected O, but got I
		//IL_280b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2810: Expected O, but got Unknown
		//IL_2821: Unknown result type (might be due to invalid IL or missing references)
		//IL_2826: Expected O, but got Unknown
		//IL_2853: Expected I, but got O
		//IL_2694: Unknown result type (might be due to invalid IL or missing references)
		//IL_2699: Expected O, but got Unknown
		//IL_26b1: Expected O, but got I
		//IL_2749: Expected I, but got O
		//IL_2759: Expected O, but got I
		//IL_279f: Expected O, but got I
		//IL_27a7: Expected I, but got O
		//IL_286b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2870: Expected O, but got Unknown
		//IL_2879: Unknown result type (might be due to invalid IL or missing references)
		//IL_287e: Expected O, but got Unknown
		//IL_4951: Expected O, but got I
		//IL_4961: Expected O, but got I
		//IL_4983: Expected O, but got I4
		//IL_2969: Expected I, but got O
		//IL_28cd: Expected O, but got I
		//IL_28dd: Expected O, but got I
		//IL_4a9c: Expected O, but got I
		//IL_4aac: Expected O, but got I
		//IL_4ace: Expected O, but got I4
		//IL_4aee: Expected O, but got I
		//IL_49cb: Expected O, but got I4
		//IL_2a1b: Expected I, but got O
		//IL_2a53: Expected I, but got O
		//IL_2997: Expected O, but got I
		//IL_29a7: Expected O, but got I
		//IL_29de: Expected I, but got O
		//IL_5b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b70: Expected O, but got Unknown
		//IL_5b86: Expected O, but got I
		//IL_5b8e: Expected I, but got O
		//IL_5b9f: Expected I, but got O
		//IL_5bbd: Expected O, but got I
		//IL_4b2e: Expected O, but got I4
		//IL_4a2a: Expected O, but got I4
		//IL_49fb: Expected O, but got I
		//IL_2a6d: Expected O, but got I
		//IL_2a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a81: Expected O, but got Unknown
		//IL_2a8d: Expected O, but got I
		//IL_2a9d: Expected O, but got I
		//IL_2aad: Expected O, but got I
		//IL_2acf: Expected O, but got I4
		//IL_2ad7: Expected I, but got O
		//IL_5be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5be8: Expected O, but got Unknown
		//IL_5bfe: Expected O, but got I
		//IL_5c0f: Expected I, but got O
		//IL_5c2d: Expected O, but got I
		//IL_2b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b64: Expected O, but got Unknown
		//IL_2b7c: Expected I, but got O
		//IL_4b8d: Expected O, but got I4
		//IL_4bba: Expected I, but got O
		//IL_4be7: Expected I, but got O
		//IL_4b5e: Expected O, but got I
		//IL_2b99: Expected I, but got O
		//IL_2b07: Expected O, but got I4
		//IL_5254: Unknown result type (might be due to invalid IL or missing references)
		//IL_5259: Expected O, but got Unknown
		//IL_526f: Expected O, but got I
		//IL_5277: Expected I, but got O
		//IL_5288: Expected I, but got O
		//IL_5297: Unknown result type (might be due to invalid IL or missing references)
		//IL_529c: Expected O, but got Unknown
		//IL_52ba: Expected O, but got I
		//IL_2b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b33: Expected O, but got Unknown
		//IL_2b4b: Expected O, but got I
		//IL_2c7d: Expected O, but got I4
		//IL_2c93: Expected O, but got I
		//IL_2cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb6: Expected O, but got Unknown
		//IL_2cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ccc: Expected O, but got Unknown
		//IL_2bec: Expected I, but got O
		//IL_2bfc: Expected O, but got I
		//IL_2c45: Expected O, but got I
		//IL_2d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d18: Expected O, but got Unknown
		//IL_4c5a: Expected O, but got I
		//IL_4c6a: Expected O, but got I
		//IL_4c7a: Expected O, but got I
		//IL_4c9c: Expected O, but got I4
		//IL_4cac: Expected O, but got I
		//IL_2d63: Expected O, but got I
		//IL_2d73: Expected O, but got I
		//IL_2d83: Expected O, but got I
		//IL_2da5: Expected O, but got I4
		//IL_4ce4: Expected O, but got I4
		//IL_5c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c58: Expected O, but got Unknown
		//IL_5c6e: Expected O, but got I
		//IL_5c7f: Expected I, but got O
		//IL_5c9d: Expected O, but got I
		//IL_2dc3: Expected O, but got I
		//IL_4d14: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 2816;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj3 = (nint)0 + (nint)2464;
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3008;
		object obj5 = "placementId" + 3056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj3;
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		object obj7 = obj6 + 16;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj6 + 24;
		obj8 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		object obj26;
		object obj31;
		Action action4;
		object obj32;
		object obj35;
		object obj36;
		object obj34;
		object obj30;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		Func<CachedModel<List<object>>> func;
		string text;
		if (enumerable != null)
		{
			nint num2 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag = ex == null;
			func = null;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				bool flag2 = (nint)0 == 0;
				func = null;
				if (!flag2)
				{
					object obj9 = (nint)0 + (nint)2472;
					object obj10 = "startPosition" + 656;
					object obj11 = enumerable + 32;
					obj11 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					num = (nint)obj9;
					Action<object> action2 = default(Action<object>);
					action2..ctor((object)null, (IntPtr)obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj12 = default(object);
					obj12..ctor();
					object obj13 = obj12 + 16;
					obj13 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj14 = obj12 + 24;
					obj14 = action2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					nint num3 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = ex == null;
					func = null;
					if (flag3)
					{
						goto IL_4d3c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					object obj15 = 0 & 0xFFFFFFFEL;
					bool flag4 = obj15 == null;
					func = null;
					if (!flag4)
					{
						object obj16 = (nint)0 + (nint)2456;
						object obj17 = "getSecondRescanTask" + 2944;
						object obj18 = enumerable + 40;
						obj18 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						num = (nint)obj16;
						Action<object> action3 = default(Action<object>);
						action3..ctor((object)null, (IntPtr)obj16);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj19 = default(object);
						obj19..ctor();
						object obj20 = obj19 + 16;
						obj20 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj21 = obj19 + 24;
						obj21 = action3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						nint num4 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = ex == null;
						func = null;
						if (flag5)
						{
							goto IL_4d3c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
						bool flag6 = (nint)0 < (nint)2;
						object obj22 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
						object obj23 = -2;
						bool flag7 = obj23 == null;
						object obj24 = ~obj22;
						object obj25 = obj24 | flag7;
						func = null;
						if (obj25 == null)
						{
							obj26 = typeof(CardUtils.<>c) + 2376;
							object obj27 = "startPosition" + 640;
							object obj28 = enumerable + 48;
							obj28 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj29 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v527+E4]");
							if ((nint)0 != 0)
							{
								obj30 = typeof(System.Formats.Asn1.SetOfValueComparer) + 360;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v527+B8]");
								obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v484+8]");
								action4 = (Action)0;
								obj32 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v484+8]");
								bool flag8 = (nint)0 == 0;
								object obj33 = !flag8;
								func = null;
								obj34 = obj19;
								if (obj33 == null)
								{
									obj35 = obj30;
									obj36 = obj27;
									goto IL_0595;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj29 = obj26;
								obj35 = typeof(System.Formats.Asn1.SetOfValueComparer) + 360;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v527+B8]");
								obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v484+8]");
								action4 = (Action)0;
								obj36 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v484+8]");
								bool flag9 = (nint)0 == 0;
								object obj37 = !flag9;
								func = null;
								obj34 = obj19;
								obj30 = obj35;
								obj32 = obj27;
								if (obj37 == null)
								{
									goto IL_0595;
								}
							}
							goto IL_05ec;
						}
					}
				}
				goto IL_4d2e;
			}
			goto IL_4d3c;
		}
		goto IL_4d54;
		IL_1c3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ X8_v177+98]");
		Func<object, long> func2 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ X8_v177+98]");
		bool flag10 = (nint)0 == 0;
		Func<CachedModel<List<object>>> func4;
		Func<CachedModel<List<object>>> func3 = func4;
		Func<object> func6;
		Func<object> func5 = func6;
		nint num6;
		nint num5 = num6;
		object obj40;
		object obj39 = obj40;
		Func<object> func8;
		Func<object> func7 = func8;
		string text3;
		string text2 = text3;
		Func<object> func10;
		Func<object> func9 = func10;
		if (!flag10)
		{
			goto IL_1cb7;
		}
		goto IL_41e5;
		IL_414b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj41;
		obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+B8]");
		obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ X8_v177+98]");
		func2 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ X8_v177+98]");
		bool flag11 = (nint)0 == 0;
		object obj42 = !flag11;
		func4 = func3;
		func6 = func5;
		num6 = num5;
		func8 = func7;
		text3 = text2;
		func10 = func9;
		obj39 = obj40;
		if (obj42 != null)
		{
			goto IL_1cb7;
		}
		goto IL_41e5;
		IL_12c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
		bool flag12 = (nint)0 == 0;
		Func<object> func12;
		Func<CachedModel<List<object>>> func11 = (Func<CachedModel<List<object>>>)func12;
		Func<object> func14;
		Func<string> func13 = (Func<string>)func14;
		Func<CachedModel<List<object>>> func16;
		Func<CachedModel<List<object>>> func15 = func16;
		ListDeltaApplier<object, long> listDeltaApplier2;
		ListDeltaApplier<object, long> listDeltaApplier = listDeltaApplier2;
		Func<string> func18;
		Func<string> func17 = func18;
		object obj44;
		object obj43 = obj44;
		Func<CachedModel<List<object>>> func19 = (Func<CachedModel<List<object>>>)func12;
		Func<object, object> func21;
		Func<object, object> func20 = func21;
		string text5;
		string text4 = text5;
		Func<string> func22 = (Func<string>)func14;
		if (!flag12)
		{
			goto IL_1336;
		}
		goto IL_39ae;
		IL_39ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj44 = obj41;
		func16 = func15;
		listDeltaApplier2 = listDeltaApplier;
		func18 = func17;
		func11 = func19;
		func21 = func20;
		text5 = text4;
		func13 = func22;
		goto IL_1336;
		IL_1336:
		object obj45 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3376;
		object obj46 = (nint)0 + (nint)1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+B8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v424+60]");
		Action action5 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v424+60]");
		bool flag13 = (nint)0 == 0;
		object obj48 = !flag13;
		nint num7 = (nint)func18;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
			bool flag14 = (nint)0 == 0;
			object obj49 = !flag14;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj50 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1703 @ X8_v430+B8]");
				obj47 = 0;
			}
			object obj51 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj52 = (nint)0 + (nint)1944;
			num7 = (nint)obj52;
			Action action6 = default(Action);
			action6..ctor(obj47, (IntPtr)obj52);
			object obj53 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1676 @ X8_v429+B8]");
			object obj54 = (nint)0 + (nint)96;
			obj54 = action6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func16 = null;
			listDeltaApplier2 = (ListDeltaApplier<object, long>)(object)action6;
			action5 = action6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj55 = obj46;
		ListDeltaApplier<object, object> listDeltaApplier3 = default(ListDeltaApplier<object, object>);
		listDeltaApplier3..ctor(text5, func13, func11, func21, action5, (Action)null);
		bool flag15 = listDeltaApplier3 == null;
		string text6 = text5;
		Action action7;
		Action action8;
		Func<object, long> func23;
		if (!flag15)
		{
			nint num8 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v423 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text6 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag16 = ex == null;
			action7 = null;
			action8 = action5;
			func23 = (Func<object, long>)(object)func21;
			func = func11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v423 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = (nint)func13;
			if (flag16)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag17 = (nint)0 < (nint)6;
		object obj56 = !flag17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj57 = -6;
		bool flag18 = obj57 == null;
		object obj58 = ~obj56;
		object obj59 = obj58 | flag18;
		action7 = null;
		action8 = action5;
		func23 = (Func<object, long>)(object)func21;
		func = func11;
		text = text6;
		num = (nint)func13;
		Func<object> func24;
		string text7;
		string text8;
		Func<string> func27;
		Func<object> func29;
		object obj73;
		Func<CachedModel<List<object>>> func28;
		ListDeltaApplier<object, object> listDeltaApplier5;
		nint num9;
		object obj62;
		Func<CachedModel<List<object>>> func26;
		ListDeltaApplier<object, object> listDeltaApplier4;
		if (obj59 == null)
		{
			object obj60 = "not" + 184;
			object obj61 = enumerable + 80;
			obj61 = listDeltaApplier3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj62 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
			object obj63;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+B8]");
				obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v159+68]");
				func24 = (Func<object>)0;
				text7 = (string)obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v159+68]");
				bool flag19 = (nint)0 == 0;
				object obj64 = obj62;
				text8 = (string)obj60;
				if (!flag19)
				{
					goto IL_1624;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj62 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+B8]");
				obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v159+68]");
				func24 = (Func<object>)0;
				text7 = (string)obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v159+68]");
				bool flag20 = (nint)0 == 0;
				object obj65 = !flag20;
				object obj64 = obj62;
				text8 = (string)obj60;
				if (obj65 != null)
				{
					goto IL_1624;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1756 @ X0_v230+E4]");
			bool flag21 = (nint)0 == 0;
			object obj66 = !flag21;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj67 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ X8_v166+B8]");
				obj63 = 0;
			}
			object obj68 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj69 = (nint)0 + (nint)1952;
			num9 = (nint)obj69;
			Func<object> func25 = default(Func<object>);
			func25..ctor(obj63, (IntPtr)obj69);
			object obj70 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1890 @ X8_v164+B8]");
			object obj71 = (nint)0 + (nint)104;
			obj71 = func25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj62 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
			bool flag22 = (nint)0 == 0;
			object obj72 = !flag22;
			func26 = null;
			listDeltaApplier4 = (ListDeltaApplier<object, object>)(object)func25;
			func27 = (Func<string>)obj69;
			text7 = text8;
			func24 = func25;
			func28 = null;
			listDeltaApplier5 = (ListDeltaApplier<object, object>)(object)func25;
			obj73 = obj62;
			func29 = func25;
			if (obj72 != null)
			{
				goto IL_1691;
			}
			goto IL_3b48;
		}
		goto IL_4d2e;
		IL_291a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+E4]");
		bool flag23 = (nint)0 == 0;
		Func<CachedModel<List<object>>> func31;
		Func<CachedModel<List<object>>> func30 = func31;
		ListDeltaApplier<object, long> listDeltaApplier7 = default(ListDeltaApplier<object, long>);
		ListDeltaApplier<object, long> listDeltaApplier6 = listDeltaApplier7;
		Func<string> func33;
		Func<string> func32 = func33;
		string text10;
		string text9 = text10;
		Func<CachedModel<List<object>>> func34 = func31;
		ListDeltaApplier<object, long> listDeltaApplier8 = listDeltaApplier7;
		nint num10 = (nint)func33;
		object obj75;
		object obj74 = obj75;
		Func<object> func36;
		Func<object> func35 = func36;
		if (!flag23)
		{
			goto IL_2987;
		}
		goto IL_4a7a;
		IL_1cb7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
		bool flag24 = (nint)0 == 0;
		Func<CachedModel<List<object>>> func37 = (Func<CachedModel<List<object>>>)func8;
		nint num11 = (nint)func10;
		Func<CachedModel<List<object>>> func38 = func4;
		Func<object> func39 = func6;
		nint num12 = num6;
		object obj76 = obj40;
		Func<CachedModel<List<object>>> func40 = (Func<CachedModel<List<object>>>)func8;
		Func<object, long> func41 = func2;
		text2 = text3;
		nint num13 = (nint)func10;
		if (!flag24)
		{
			goto IL_1d2c;
		}
		goto IL_42d6;
		IL_41e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2208 @ X0_v253+E4]");
		bool flag25 = (nint)0 == 0;
		object obj77 = !flag25;
		if (obj77 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj78 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2291 @ X8_v184+B8]");
			obj38 = 0;
		}
		object obj79 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj80 = (nint)0 + (nint)2000;
		num6 = (nint)obj80;
		Func<object, int> func42 = default(Func<object, int>);
		func42..ctor(obj38, (IntPtr)obj80);
		object obj81 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ X8_v182+B8]");
		object obj82 = (nint)0 + (nint)152;
		obj82 = func42;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
		bool flag26 = (nint)0 == 0;
		object obj83 = !flag26;
		func4 = null;
		func6 = (Func<object>)(object)func42;
		func37 = (Func<CachedModel<List<object>>>)func7;
		func2 = (Func<object, long>)(object)func42;
		text3 = text2;
		num11 = (nint)func9;
		func38 = null;
		func39 = (Func<object>)(object)func42;
		num12 = (nint)obj80;
		obj76 = obj40;
		func40 = (Func<CachedModel<List<object>>>)func7;
		func41 = (Func<object, long>)(object)func42;
		num13 = (nint)func9;
		if (obj83 != null)
		{
			goto IL_1d2c;
		}
		goto IL_42d6;
		IL_48e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj85;
		object obj84 = obj85;
		Func<CachedModel<List<object>>> func44;
		Func<CachedModel<List<object>>> func43 = func44;
		Func<object> func46;
		Func<object> func45 = func46;
		nint num15;
		nint num14 = num15;
		Func<CachedModel<List<object>>> func47;
		func31 = func47;
		string text12;
		string text11 = text12;
		Func<string> func48;
		func33 = func48;
		goto IL_25d3;
		IL_1d2c:
		object obj86 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3368;
		object obj87 = (nint)0 + (nint)1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+B8]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2298 @ X8_v384+A0]");
		Action action9 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2298 @ X8_v384+A0]");
		bool flag27 = (nint)0 == 0;
		object obj89 = !flag27;
		Action action10 = (Action)(object)func6;
		if (obj89 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
			bool flag28 = (nint)0 == 0;
			object obj90 = !flag28;
			if (obj90 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj91 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2309 @ X8_v390+B8]");
				obj88 = 0;
			}
			object obj92 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj93 = (nint)0 + (nint)2008;
			num6 = (nint)obj93;
			Action action11 = default(Action);
			action11..ctor(obj88, (IntPtr)obj93);
			object obj94 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2288 @ X8_v389+B8]");
			object obj95 = (nint)0 + (nint)160;
			obj95 = action11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func4 = null;
			action10 = action11;
			action9 = action11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj55 = obj87;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328B910");
		Func<object> func49 = default(Func<object>);
		bool flag29 = func49 == null;
		string text13 = text3;
		if (!flag29)
		{
			nint num16 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v383 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text13 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag30 = ex == null;
			action7 = null;
			action8 = action9;
			func23 = func2;
			func = func37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v383 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = num11;
			if (flag30)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag31 = (nint)0 < (nint)8;
		object obj96 = !flag31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj97 = -8;
		bool flag32 = obj97 == null;
		object obj98 = ~obj96;
		object obj99 = obj98 | flag32;
		action7 = null;
		action8 = action9;
		func23 = func2;
		func = func37;
		text = text13;
		num = num11;
		Func<object> func50;
		string text14;
		string text15;
		Func<object> func53;
		Func<object> func56;
		object obj113;
		object obj102;
		Func<CachedModel<List<object>>> func54;
		Func<object> func55;
		nint num18;
		nint num17;
		Func<CachedModel<List<object>>> func52;
		if (obj99 == null)
		{
			object obj100 = "startPosition" + 664;
			object obj101 = enumerable + 96;
			obj101 = func49;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj102 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+E4]");
			object obj103;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+B8]");
				obj103 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2390 @ X8_v231+A8]");
				func50 = (Func<object>)0;
				text14 = (string)obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2390 @ X8_v231+A8]");
				bool flag33 = (nint)0 == 0;
				object obj104 = obj102;
				text15 = (string)obj100;
				if (!flag33)
				{
					goto IL_2006;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj102 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+B8]");
				obj103 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2390 @ X8_v231+A8]");
				func50 = (Func<object>)0;
				text14 = (string)obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2390 @ X8_v231+A8]");
				bool flag34 = (nint)0 == 0;
				object obj105 = !flag34;
				object obj104 = obj102;
				text15 = (string)obj100;
				if (obj105 != null)
				{
					goto IL_2006;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v312+E4]");
			bool flag35 = (nint)0 == 0;
			object obj106 = !flag35;
			if (obj106 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj107 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2426 @ X8_v238+B8]");
				obj103 = 0;
			}
			object obj108 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj109 = (nint)0 + (nint)2024;
			num17 = (nint)obj109;
			Func<object> func51 = default(Func<object>);
			func51..ctor(obj103, (IntPtr)obj109);
			object obj110 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2474 @ X8_v236+B8]");
			object obj111 = (nint)0 + (nint)168;
			obj111 = func51;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj102 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+E4]");
			bool flag36 = (nint)0 == 0;
			object obj112 = !flag36;
			func52 = null;
			func53 = func51;
			text14 = text15;
			func50 = func51;
			func54 = null;
			func55 = func51;
			num18 = (nint)obj109;
			obj113 = obj102;
			func56 = func51;
			if (obj112 != null)
			{
				goto IL_2073;
			}
			goto IL_4470;
		}
		goto IL_4d2e;
		IL_0595:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v527+E4]");
		bool flag37 = (nint)0 == 0;
		object obj114 = !flag37;
		if (obj114 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj115 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v490+B8]");
			obj31 = 0;
		}
		object obj116 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj117 = (nint)0 + (nint)1920;
		num = (nint)obj117;
		Action action12 = default(Action);
		action12..ctor(obj31, (IntPtr)obj117);
		object obj118 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v489+B8]");
		object obj119 = (nint)0 + (nint)8;
		obj119 = action12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func = null;
		obj34 = action12;
		obj30 = obj35;
		obj32 = obj36;
		action4 = action12;
		goto IL_05ec;
		IL_52e6:
		Func<object, object> keySelector;
		return (Dictionary<string, IContentApplier>)(object)Enumerable.ToDictionary(enumerable, keySelector);
		IL_42d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj40 = obj41;
		func4 = func38;
		func6 = func39;
		num6 = num12;
		func37 = func40;
		func2 = func41;
		text3 = text2;
		num11 = num13;
		goto IL_1d2c;
		IL_05ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj120 = default(object);
		obj120..ctor();
		object obj121 = obj120 + 16;
		obj121 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj122 = obj120 + 24;
		obj122 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num19 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v14 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		Func<object> func57;
		string text16;
		string text17;
		Func<object> func60;
		object obj139;
		Func<CachedModel<List<object>>> func59;
		object obj138;
		nint num20;
		object obj126;
		object obj137;
		if (ex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj123 = 0 & 0xFFFFFFFCL;
			if (obj123 != null)
			{
				object obj124 = "placementId" + 672;
				object obj125 = enumerable + 56;
				obj125 = obj120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj126 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+E4]");
				object obj127;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+B8]");
					obj127 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v31+10]");
					func57 = (Func<object>)0;
					text16 = (string)obj124;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v31+10]");
					bool flag38 = (nint)0 == 0;
					object obj128 = obj126;
					text17 = (string)obj124;
					if (!flag38)
					{
						goto IL_0778;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj126 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+B8]");
					obj127 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v31+10]");
					func57 = (Func<object>)0;
					text16 = (string)obj124;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v31+10]");
					bool flag39 = (nint)0 == 0;
					object obj129 = !flag39;
					object obj128 = obj126;
					text17 = (string)obj124;
					if (obj129 != null)
					{
						goto IL_0778;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X0_v87+E4]");
				bool flag40 = (nint)0 == 0;
				object obj130 = !flag40;
				if (obj130 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj131 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v38+B8]");
					obj127 = 0;
				}
				object obj132 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj133 = (nint)0 + (nint)1928;
				num = (nint)obj133;
				Func<object> func58 = default(Func<object>);
				func58..ctor(obj127, (IntPtr)obj133);
				object obj134 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v36+B8]");
				object obj135 = (nint)0 + (nint)16;
				obj135 = func58;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj126 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+E4]");
				bool flag41 = (nint)0 == 0;
				object obj136 = !flag41;
				func = null;
				obj137 = func58;
				text16 = text17;
				func57 = func58;
				func59 = null;
				obj138 = func58;
				num20 = (nint)obj133;
				obj139 = obj126;
				func60 = func58;
				if (obj136 != null)
				{
					goto IL_07d5;
				}
				goto IL_2f1b;
			}
			goto IL_4d2e;
		}
		goto IL_4d3c;
		IL_2987:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+B8]");
		object obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2907 @ X8_v283+E0]");
		Func<CachedModel<List<object>>> func61 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2907 @ X8_v283+E0]");
		bool flag42 = (nint)0 == 0;
		text9 = text10;
		func34 = func30;
		listDeltaApplier8 = listDeltaApplier6;
		num10 = (nint)func32;
		object obj141 = obj75;
		func35 = func36;
		if (!flag42)
		{
			goto IL_29fc;
		}
		goto IL_4b0c;
		IL_4d2e:
		ex = new IndexOutOfRangeException();
		goto IL_4d3c;
		IL_4bf5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj142;
		obj75 = obj142;
		text10 = text9;
		Func<CachedModel<List<object>>> func62;
		func30 = func62;
		ListDeltaApplier<object, long> listDeltaApplier9;
		listDeltaApplier6 = listDeltaApplier9;
		Func<string> func63;
		func32 = func63;
		Func<CachedModel<List<object>>> func64;
		func61 = func64;
		nint num22;
		nint num21 = num22;
		goto IL_2a61;
		IL_4cc2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3021 @ X0_v413+E4]");
		bool flag43 = (nint)0 == 0;
		object obj143 = !flag43;
		object obj145;
		object obj146;
		if (obj143 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj144 = obj145;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3033 @ X8_v319+B8]");
			obj146 = 0;
		}
		object obj147 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj148 = (nint)0 + (nint)2096;
		Func<object, object> func65 = default(Func<object, object>);
		func65..ctor(obj146, (IntPtr)obj148);
		object obj149 = obj145;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3015 @ X8_v318+B8]");
		object obj150 = (nint)0 + (nint)240;
		obj150 = func65;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		keySelector = func65;
		object obj152;
		object obj151 = obj152;
		goto IL_52e6;
		IL_29fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+E4]");
		bool flag44 = (nint)0 == 0;
		num21 = (nint)func36;
		text9 = text10;
		func62 = func30;
		listDeltaApplier9 = listDeltaApplier6;
		func63 = func32;
		object obj153 = obj75;
		func64 = func61;
		num22 = (nint)func36;
		if (!flag44)
		{
			goto IL_2a61;
		}
		goto IL_4bf5;
		IL_3b48:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj62 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+B8]");
		object obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ X8_v147+70]");
		Func<object> func66 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ X8_v147+70]");
		bool flag45 = (nint)0 == 0;
		object obj155 = !flag45;
		func26 = func28;
		listDeltaApplier4 = listDeltaApplier5;
		func27 = (Func<string>)num9;
		text7 = text8;
		func24 = func29;
		object obj156 = obj62;
		if (obj155 != null)
		{
			goto IL_1706;
		}
		goto IL_3bda;
		IL_1624:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
		bool flag46 = (nint)0 == 0;
		func26 = func11;
		listDeltaApplier4 = listDeltaApplier3;
		func27 = func13;
		func28 = func11;
		listDeltaApplier5 = listDeltaApplier3;
		num9 = (nint)func13;
		obj73 = obj62;
		text8 = text7;
		func29 = func24;
		if (!flag46)
		{
			goto IL_1691;
		}
		goto IL_3b48;
		IL_0778:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+E4]");
		bool flag47 = (nint)0 == 0;
		obj137 = obj120;
		func59 = func;
		obj138 = obj120;
		num20 = num;
		obj139 = obj126;
		text17 = text16;
		func60 = func57;
		if (!flag47)
		{
			goto IL_07d5;
		}
		goto IL_2f1b;
		IL_2f1b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj126 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+B8]");
		object obj157 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v19+18]");
		Func<CachedModel<List<object>>> func67 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v19+18]");
		bool flag48 = (nint)0 == 0;
		object obj158 = !flag48;
		func = func59;
		obj137 = obj138;
		num = num20;
		text16 = text17;
		func57 = func60;
		object obj159 = obj126;
		if (obj158 != null)
		{
			goto IL_084a;
		}
		goto IL_2fad;
		IL_07d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+B8]");
		obj157 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v19+18]");
		func67 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X8_v19+18]");
		bool flag49 = (nint)0 == 0;
		func59 = func;
		obj138 = obj137;
		num20 = num;
		obj159 = obj126;
		text17 = text16;
		func60 = func57;
		if (!flag49)
		{
			goto IL_084a;
		}
		goto IL_2fad;
		IL_2fad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X0_v75+E4]");
		bool flag50 = (nint)0 == 0;
		object obj160 = !flag50;
		if (obj160 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj161 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X8_v26+B8]");
			obj157 = 0;
		}
		object obj162 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj163 = (nint)0 + (nint)2016;
		num = (nint)obj163;
		Func<object> func68 = default(Func<object>);
		func68..ctor(obj157, (IntPtr)obj163);
		object obj164 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v24+B8]");
		object obj165 = (nint)0 + (nint)24;
		obj165 = func68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj126 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+E4]");
		bool flag51 = (nint)0 == 0;
		object obj166 = !flag51;
		func = null;
		obj137 = func68;
		func67 = (Func<CachedModel<List<object>>>)func68;
		text16 = text17;
		nint num23 = (nint)func60;
		Func<CachedModel<List<object>>> func69 = null;
		object obj167 = func68;
		nint num24 = (nint)obj163;
		object obj168 = obj126;
		Func<CachedModel<List<object>>> func70 = (Func<CachedModel<List<object>>>)func68;
		nint num25 = (nint)func60;
		if (obj166 != null)
		{
			goto IL_08af;
		}
		goto IL_308e;
		IL_3bda:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1831 @ X0_v218+E4]");
		bool flag52 = (nint)0 == 0;
		object obj169 = !flag52;
		if (obj169 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj170 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ X8_v154+B8]");
			obj154 = 0;
		}
		object obj171 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj172 = (nint)0 + (nint)1960;
		nint num26 = (nint)obj172;
		Func<object> func71 = default(Func<object>);
		func71..ctor(obj154, (IntPtr)obj172);
		object obj173 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X8_v152+B8]");
		object obj174 = (nint)0 + (nint)112;
		obj174 = func71;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj62 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
		bool flag53 = (nint)0 == 0;
		object obj175 = !flag53;
		func26 = null;
		listDeltaApplier4 = (ListDeltaApplier<object, object>)(object)func71;
		func27 = (Func<string>)obj172;
		func66 = func71;
		text7 = text8;
		func24 = func29;
		Func<CachedModel<List<object>>> func72 = null;
		ListDeltaApplier<object, object> listDeltaApplier10 = (ListDeltaApplier<object, object>)(object)func71;
		object obj176 = obj62;
		Func<object> func73 = func71;
		if (obj175 != null)
		{
			goto IL_1763;
		}
		goto IL_3cb3;
		IL_1691:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+B8]");
		obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ X8_v147+70]");
		func66 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ X8_v147+70]");
		bool flag54 = (nint)0 == 0;
		func28 = func26;
		listDeltaApplier5 = listDeltaApplier4;
		num9 = (nint)func27;
		obj156 = obj62;
		text8 = text7;
		func29 = func24;
		if (!flag54)
		{
			goto IL_1706;
		}
		goto IL_3bda;
		IL_084a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+E4]");
		bool flag55 = (nint)0 == 0;
		num23 = (nint)func57;
		func69 = func;
		obj167 = obj137;
		num24 = num;
		obj168 = obj126;
		func70 = func67;
		text17 = text16;
		num25 = (nint)func57;
		if (!flag55)
		{
			goto IL_08af;
		}
		goto IL_308e;
		IL_308e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj126 = obj26;
		func = func69;
		obj137 = obj167;
		num = num24;
		func67 = func70;
		text16 = text17;
		num23 = num25;
		goto IL_08af;
		IL_08af:
		object obj177 = (nint)0 + (nint)2488;
		object obj178 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3392;
		object obj179 = (nint)0 + (nint)1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+B8]");
		object obj180 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X8_v464+20]");
		Func<object, long> func74 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X8_v464+20]");
		bool flag56 = (nint)0 == 0;
		object obj181 = !flag56;
		if (obj181 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X0_v98+E4]");
			bool flag57 = (nint)0 == 0;
			object obj182 = !flag57;
			if (obj182 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj183 = typeof(CardUtils.<>c) + 2376;
				object obj184 = obj183;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ X8_v474+B8]");
				obj180 = 0;
			}
			object obj185 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj186 = (nint)0 + (nint)2104;
			num = (nint)obj186;
			Func<object, int> func75 = default(Func<object, int>);
			func75..ctor(obj180, (IntPtr)obj186);
			object obj187 = typeof(CardUtils.<>c) + 2376;
			object obj188 = obj187;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v471+B8]");
			object obj189 = (nint)0 + (nint)32;
			obj189 = func75;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = null;
			obj137 = func75;
			func74 = (Func<object, long>)(object)func75;
		}
		object obj190 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action13 = default(Action);
		action13..ctor(null, (IntPtr)obj177);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj55 = obj179;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328B910");
		Func<object> func76 = default(Func<object>);
		bool flag58 = func76 == null;
		string text18 = text16;
		if (!flag58)
		{
			nint num27 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v463 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text18 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag59 = ex == null;
			action7 = null;
			action8 = action13;
			func23 = func74;
			func = func67;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v463 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = num23;
			if (flag59)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag60 = (nint)0 < (nint)4;
		object obj191 = !flag60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj192 = -4;
		bool flag61 = obj192 == null;
		obj41 = typeof(CardUtils.<>c) + 2376;
		object obj193 = ~obj191;
		object obj194 = obj193 | flag61;
		action7 = null;
		action8 = action13;
		func23 = func74;
		func = func67;
		text = text18;
		num = num23;
		Func<object> func77;
		string text19;
		string text20;
		Func<object> func80;
		Func<object> func83;
		object obj208;
		Func<CachedModel<List<object>>> func81;
		Func<object> func82;
		nint num29;
		object obj197;
		nint num28;
		Func<CachedModel<List<object>>> func79;
		if (obj194 == null)
		{
			object obj195 = "m_StencilDeferredPS" + 576;
			object obj196 = enumerable + 64;
			obj196 = func76;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj197 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
			object obj198;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+B8]");
				obj198 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v75+28]");
				func77 = (Func<object>)0;
				text19 = (string)obj195;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v75+28]");
				bool flag62 = (nint)0 == 0;
				object obj199 = obj197;
				text20 = (string)obj195;
				if (!flag62)
				{
					goto IL_0be6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj197 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+B8]");
				obj198 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v75+28]");
				func77 = (Func<object>)0;
				text19 = (string)obj195;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v75+28]");
				bool flag63 = (nint)0 == 0;
				object obj200 = !flag63;
				object obj199 = obj197;
				text20 = (string)obj195;
				if (obj200 != null)
				{
					goto IL_0be6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ X0_v136+E4]");
			bool flag64 = (nint)0 == 0;
			object obj201 = !flag64;
			if (obj201 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj202 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v82+B8]");
				obj198 = 0;
			}
			object obj203 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj204 = (nint)0 + (nint)2112;
			num28 = (nint)obj204;
			Func<object> func78 = default(Func<object>);
			func78..ctor(obj198, (IntPtr)obj204);
			object obj205 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1234 @ X8_v80+B8]");
			object obj206 = (nint)0 + (nint)40;
			obj206 = func78;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj197 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
			bool flag65 = (nint)0 == 0;
			object obj207 = !flag65;
			func79 = null;
			func80 = func78;
			text19 = text20;
			func77 = func78;
			func81 = null;
			func82 = func78;
			num29 = (nint)obj204;
			obj208 = obj197;
			func83 = func78;
			if (obj207 != null)
			{
				goto IL_0c53;
			}
			goto IL_3220;
		}
		goto IL_4d2e;
		IL_2a61:
		object obj209 = (nint)0 + (nint)2528;
		object obj210 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3408;
		object obj211 = (nint)0 + (nint)1336;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+B8]");
		object obj212 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2945 @ X8_v324+E8]");
		Func<object, long> func84 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2945 @ X8_v324+E8]");
		bool flag66 = (nint)0 == 0;
		object obj213 = !flag66;
		nint num30 = (nint)func32;
		if (obj213 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+E4]");
			bool flag67 = (nint)0 == 0;
			object obj214 = !flag67;
			if (obj214 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj215 = typeof(CardUtils.<>c) + 2376;
				object obj216 = obj215;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2960 @ X8_v334+B8]");
				obj212 = 0;
			}
			object obj217 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj218 = (nint)0 + (nint)2088;
			num30 = (nint)obj218;
			Func<object, int> func85 = default(Func<object, int>);
			func85..ctor(obj212, (IntPtr)obj218);
			object obj219 = typeof(CardUtils.<>c) + 2376;
			object obj220 = obj219;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2933 @ X8_v331+B8]");
			object obj221 = (nint)0 + (nint)232;
			obj221 = func85;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func30 = null;
			listDeltaApplier6 = (ListDeltaApplier<object, long>)(object)func85;
			func84 = (Func<object, long>)(object)func85;
		}
		object obj222 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action14 = default(Action);
		object obj223;
		action14..ctor(null, (IntPtr)obj223);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action15 = default(Action);
		action15..ctor(null, (IntPtr)obj209);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj55 = obj211;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328B910");
		object obj224 = default(object);
		bool flag68 = obj224 == null;
		string text21 = text10;
		if (!flag68)
		{
			nint num31 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v323 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text21 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag69 = ex == null;
			action7 = action15;
			action8 = action14;
			func23 = func84;
			func = func61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v323 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = num21;
			if (flag69)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag70 = (nint)0 < (nint)11;
		object obj225 = !flag70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj226 = -11;
		bool flag71 = obj226 == null;
		obj145 = typeof(CardUtils.<>c) + 2376;
		object obj227 = ~obj225;
		object obj228 = obj227 | flag71;
		action7 = action15;
		action8 = action14;
		func23 = func84;
		func = func61;
		text = text21;
		num = num21;
		if (obj228 != null)
		{
			goto IL_4d2e;
		}
		object obj229 = enumerable + 120;
		obj229 = obj224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj230 = obj145;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3021 @ X0_v413+E4]");
		if ((nint)0 != 0)
		{
			obj151 = (nint)0 + (nint)1568;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3021 @ X0_v413+B8]");
			obj146 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3027 @ X8_v313+F0]");
			keySelector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3027 @ X8_v313+F0]");
			bool flag72 = (nint)0 == 0;
			object obj231 = !flag72;
			if (obj231 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3027 @ X8_v313+F0]");
				Func<object, object> func86 = (Func<object, object>)0;
				obj152 = obj151;
				goto IL_4cc2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj230 = obj145;
			obj152 = (nint)0 + (nint)1568;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3021 @ X0_v413+B8]");
			obj146 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3027 @ X8_v313+F0]");
			Func<object, object> func86 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3027 @ X8_v313+F0]");
			bool flag73 = (nint)0 == 0;
			object obj232 = !flag73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3027 @ X8_v313+F0]");
			keySelector = (Func<object, object>)0;
			obj151 = obj152;
			if (obj232 == null)
			{
				goto IL_4cc2;
			}
		}
		goto IL_52e6;
		IL_3cb3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj62 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+B8]");
		object obj233 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1974 @ X8_v135+78]");
		Func<object, long> func87 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1974 @ X8_v135+78]");
		bool flag74 = (nint)0 == 0;
		object obj234 = !flag74;
		func26 = func72;
		listDeltaApplier4 = listDeltaApplier10;
		func27 = (Func<string>)num26;
		func66 = func73;
		text7 = text8;
		func24 = func29;
		object obj235 = obj62;
		if (obj234 != null)
		{
			goto IL_17e0;
		}
		goto IL_3d4d;
		IL_1706:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
		bool flag75 = (nint)0 == 0;
		func72 = func26;
		listDeltaApplier10 = listDeltaApplier4;
		num26 = (nint)func27;
		obj176 = obj62;
		func73 = func66;
		text8 = text7;
		func29 = func24;
		if (!flag75)
		{
			goto IL_1763;
		}
		goto IL_3cb3;
		IL_24f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+B8]");
		object obj236 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2685 @ X8_v251+C8]");
		func31 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2685 @ X8_v251+C8]");
		bool flag76 = (nint)0 == 0;
		Func<CachedModel<List<object>>> func88 = func43;
		Func<object> func89 = func45;
		nint num32 = num14;
		object obj237 = obj84;
		text12 = text11;
		Func<object> func91;
		Func<object> func90 = func91;
		if (!flag76)
		{
			goto IL_256e;
		}
		goto IL_4807;
		IL_3d4d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ X0_v206+E4]");
		bool flag77 = (nint)0 == 0;
		object obj238 = !flag77;
		if (obj238 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj239 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2003 @ X8_v142+B8]");
			obj233 = 0;
		}
		object obj240 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj241 = (nint)0 + (nint)1968;
		Func<object, int> func92 = default(Func<object, int>);
		func92..ctor(obj233, (IntPtr)obj241);
		object obj242 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2017 @ X8_v140+B8]");
		object obj243 = (nint)0 + (nint)120;
		obj243 = func92;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj62 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
		bool flag78 = (nint)0 == 0;
		object obj244 = !flag78;
		func26 = null;
		listDeltaApplier4 = (ListDeltaApplier<object, object>)(object)func92;
		func27 = (Func<string>)obj241;
		Func<CachedModel<List<object>>> func93 = (Func<CachedModel<List<object>>>)func73;
		func87 = (Func<object, long>)(object)func92;
		text7 = text8;
		nint num33 = (nint)func29;
		Func<CachedModel<List<object>>> func94 = null;
		ListDeltaApplier<object, object> listDeltaApplier11 = (ListDeltaApplier<object, object>)(object)func92;
		Func<string> func95 = (Func<string>)obj241;
		object obj245 = obj62;
		Func<CachedModel<List<object>>> func96 = (Func<CachedModel<List<object>>>)func73;
		Func<object, long> func97 = (Func<object, long>)(object)func92;
		nint num34 = (nint)func29;
		if (obj244 != null)
		{
			goto IL_1855;
		}
		goto IL_3e46;
		IL_1763:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+B8]");
		obj233 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1974 @ X8_v135+78]");
		func87 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1974 @ X8_v135+78]");
		bool flag79 = (nint)0 == 0;
		func72 = func26;
		listDeltaApplier10 = listDeltaApplier4;
		num26 = (nint)func27;
		obj235 = obj62;
		func73 = func66;
		text8 = text7;
		func29 = func24;
		if (!flag79)
		{
			goto IL_17e0;
		}
		goto IL_3d4d;
		IL_248c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+E4]");
		bool flag80 = (nint)0 == 0;
		Func<CachedModel<List<object>>> func98;
		func43 = func98;
		Func<object> func99 = default(Func<object>);
		func45 = func99;
		nint num35;
		num14 = num35;
		func88 = func98;
		func89 = func99;
		num32 = num35;
		object obj246 = obj84;
		text12 = text11;
		func90 = func91;
		if (!flag80)
		{
			goto IL_24f9;
		}
		goto IL_4775;
		IL_3e46:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj62 = obj41;
		func26 = func94;
		listDeltaApplier4 = listDeltaApplier11;
		func27 = func95;
		func93 = func96;
		func87 = func97;
		text7 = text8;
		num33 = num34;
		goto IL_1855;
		IL_17e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
		bool flag81 = (nint)0 == 0;
		func93 = (Func<CachedModel<List<object>>>)func66;
		num33 = (nint)func24;
		func94 = func26;
		listDeltaApplier11 = listDeltaApplier4;
		func95 = func27;
		obj245 = obj62;
		func96 = (Func<CachedModel<List<object>>>)func66;
		func97 = func87;
		text8 = text7;
		num34 = (nint)func24;
		if (!flag81)
		{
			goto IL_1855;
		}
		goto IL_3e46;
		IL_4775:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj84 = obj85;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+B8]");
		obj236 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2685 @ X8_v251+C8]");
		func31 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2685 @ X8_v251+C8]");
		bool flag82 = (nint)0 == 0;
		object obj247 = !flag82;
		func43 = func88;
		func45 = func89;
		num14 = num32;
		text11 = text12;
		func91 = func90;
		obj237 = obj84;
		if (obj247 != null)
		{
			goto IL_256e;
		}
		goto IL_4807;
		IL_4807:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2634 @ X0_v337+E4]");
		bool flag83 = (nint)0 == 0;
		object obj248 = !flag83;
		if (obj248 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj249 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2716 @ X8_v258+B8]");
			obj236 = 0;
		}
		object obj250 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj251 = (nint)0 + (nint)2056;
		num14 = (nint)obj251;
		Func<object> func100 = default(Func<object>);
		func100..ctor(obj236, (IntPtr)obj251);
		object obj252 = obj85;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2732 @ X8_v256+B8]");
		object obj253 = (nint)0 + (nint)200;
		obj253 = func100;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj84 = obj85;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+E4]");
		bool flag84 = (nint)0 == 0;
		object obj254 = !flag84;
		func43 = null;
		func45 = func100;
		func31 = (Func<CachedModel<List<object>>>)func100;
		text11 = text12;
		func33 = (Func<string>)func90;
		func44 = null;
		func46 = func100;
		num15 = (nint)obj251;
		object obj255 = obj84;
		func47 = (Func<CachedModel<List<object>>>)func100;
		func48 = (Func<string>)func90;
		if (obj254 != null)
		{
			goto IL_25d3;
		}
		goto IL_48e8;
		IL_1855:
		object obj256 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3400;
		object obj257 = (nint)0 + (nint)1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+B8]");
		object obj258 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2010 @ X8_v404+80]");
		Action action16 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2010 @ X8_v404+80]");
		bool flag85 = (nint)0 == 0;
		object obj259 = !flag85;
		nint num36 = (nint)func27;
		if (obj259 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v241+E4]");
			bool flag86 = (nint)0 == 0;
			object obj260 = !flag86;
			if (obj260 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj261 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2021 @ X8_v410+B8]");
				obj258 = 0;
			}
			object obj262 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj263 = (nint)0 + (nint)1976;
			num36 = (nint)obj263;
			Action action17 = default(Action);
			action17..ctor(obj258, (IntPtr)obj263);
			object obj264 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2000 @ X8_v409+B8]");
			object obj265 = (nint)0 + (nint)128;
			obj265 = action17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func26 = null;
			listDeltaApplier4 = (ListDeltaApplier<object, object>)(object)action17;
			action16 = action17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj55 = obj257;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328B910");
		Func<object> func101 = default(Func<object>);
		bool flag87 = func101 == null;
		string text22 = text7;
		if (!flag87)
		{
			nint num37 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v403 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text22 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag88 = ex == null;
			action7 = null;
			action8 = action16;
			func23 = func87;
			func = func93;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v403 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = num33;
			if (flag88)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj266 = 0 & 0xFFFFFFF8L;
		bool flag89 = obj266 == null;
		action7 = null;
		action8 = action16;
		func23 = func87;
		func = func93;
		text = text22;
		num = num33;
		Func<CachedModel<List<object>>> func103;
		Func<object> func104;
		nint num38;
		object obj279;
		if (!flag89)
		{
			object obj267 = "alignContent" + 2008;
			object obj268 = enumerable + 88;
			obj268 = func101;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj40 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
			object obj269;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+B8]");
				obj269 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2101 @ X8_v201+88]");
				func10 = (Func<object>)0;
				text3 = (string)obj267;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2101 @ X8_v201+88]");
				bool flag90 = (nint)0 == 0;
				object obj270 = obj40;
				text2 = (string)obj267;
				if (!flag90)
				{
					goto IL_1afb;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj40 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+B8]");
				obj269 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2101 @ X8_v201+88]");
				func10 = (Func<object>)0;
				text3 = (string)obj267;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2101 @ X8_v201+88]");
				bool flag91 = (nint)0 == 0;
				object obj271 = !flag91;
				object obj270 = obj40;
				text2 = (string)obj267;
				if (obj271 != null)
				{
					goto IL_1afb;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2058 @ X0_v277+E4]");
			bool flag92 = (nint)0 == 0;
			object obj272 = !flag92;
			if (obj272 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj273 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2137 @ X8_v208+B8]");
				obj269 = 0;
			}
			object obj274 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj275 = (nint)0 + (nint)1984;
			num6 = (nint)obj275;
			Func<object> func102 = default(Func<object>);
			func102..ctor(obj269, (IntPtr)obj275);
			object obj276 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2183 @ X8_v206+B8]");
			object obj277 = (nint)0 + (nint)136;
			obj277 = func102;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj40 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
			bool flag93 = (nint)0 == 0;
			object obj278 = !flag93;
			func4 = null;
			func6 = func102;
			text3 = text2;
			func10 = func102;
			func103 = null;
			func104 = func102;
			num38 = (nint)obj275;
			obj279 = obj40;
			func9 = func102;
			if (obj278 != null)
			{
				goto IL_1b68;
			}
			goto IL_3fe0;
		}
		goto IL_4d2e;
		IL_0be6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
		bool flag94 = (nint)0 == 0;
		func79 = func67;
		func80 = func76;
		num28 = num23;
		func81 = func67;
		func82 = func76;
		num29 = num23;
		obj208 = obj197;
		text20 = text19;
		func83 = func77;
		if (!flag94)
		{
			goto IL_0c53;
		}
		goto IL_3220;
		IL_3220:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj197 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+B8]");
		object obj280 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v63+30]");
		Func<object> func105 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v63+30]");
		bool flag95 = (nint)0 == 0;
		object obj281 = !flag95;
		func79 = func81;
		func80 = func82;
		num28 = num29;
		text19 = text20;
		func77 = func83;
		object obj282 = obj197;
		if (obj281 != null)
		{
			goto IL_0cc8;
		}
		goto IL_32b2;
		IL_0c53:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+B8]");
		obj280 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v63+30]");
		func105 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X8_v63+30]");
		bool flag96 = (nint)0 == 0;
		func81 = func79;
		func82 = func80;
		num29 = num28;
		obj282 = obj197;
		text20 = text19;
		func83 = func77;
		if (!flag96)
		{
			goto IL_0cc8;
		}
		goto IL_32b2;
		IL_32b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v124+E4]");
		bool flag97 = (nint)0 == 0;
		object obj283 = !flag97;
		if (obj283 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj284 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v70+B8]");
			obj280 = 0;
		}
		object obj285 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj286 = (nint)0 + (nint)2120;
		num28 = (nint)obj286;
		Func<object> func106 = default(Func<object>);
		func106..ctor(obj280, (IntPtr)obj286);
		object obj287 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1325 @ X8_v68+B8]");
		object obj288 = (nint)0 + (nint)48;
		obj288 = func106;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj197 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
		bool flag98 = (nint)0 == 0;
		object obj289 = !flag98;
		func79 = null;
		func80 = func106;
		func105 = func106;
		text19 = text20;
		func77 = func83;
		Func<CachedModel<List<object>>> func107 = null;
		Func<object> func108 = func106;
		nint num39 = (nint)obj286;
		object obj290 = obj197;
		Func<object> func109 = func106;
		if (obj289 != null)
		{
			goto IL_0d25;
		}
		goto IL_338b;
		IL_2006:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+E4]");
		bool flag99 = (nint)0 == 0;
		func52 = func37;
		func53 = func49;
		num17 = num11;
		func54 = func37;
		func55 = func49;
		num18 = num11;
		obj113 = obj102;
		text15 = text14;
		func56 = func50;
		if (!flag99)
		{
			goto IL_2073;
		}
		goto IL_4470;
		IL_4470:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj102 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+B8]");
		object obj291 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2468 @ X8_v219+B0]");
		func98 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2468 @ X8_v219+B0]");
		bool flag100 = (nint)0 == 0;
		object obj292 = !flag100;
		func52 = func54;
		func53 = func55;
		num17 = num18;
		text14 = text15;
		func50 = func56;
		object obj293 = obj102;
		if (obj292 != null)
		{
			goto IL_20e8;
		}
		goto IL_4502;
		IL_0cc8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
		bool flag101 = (nint)0 == 0;
		func107 = func79;
		func108 = func80;
		num39 = num28;
		obj290 = obj197;
		func109 = func105;
		text20 = text19;
		func83 = func77;
		if (!flag101)
		{
			goto IL_0d25;
		}
		goto IL_338b;
		IL_338b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj197 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+B8]");
		object obj294 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ X8_v51+38]");
		Func<object, long> func110 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ X8_v51+38]");
		bool flag102 = (nint)0 == 0;
		object obj295 = !flag102;
		func79 = func107;
		func80 = func108;
		num28 = num39;
		func105 = func109;
		text19 = text20;
		func77 = func83;
		object obj296 = obj197;
		if (obj295 != null)
		{
			goto IL_0da2;
		}
		goto IL_3425;
		IL_0d25:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+B8]");
		obj294 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ X8_v51+38]");
		func110 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ X8_v51+38]");
		bool flag103 = (nint)0 == 0;
		func107 = func79;
		func108 = func80;
		num39 = num28;
		obj296 = obj197;
		func109 = func105;
		text20 = text19;
		func83 = func77;
		if (!flag103)
		{
			goto IL_0da2;
		}
		goto IL_3425;
		IL_3425:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X0_v112+E4]");
		bool flag104 = (nint)0 == 0;
		object obj297 = !flag104;
		if (obj297 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj298 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X8_v58+B8]");
			obj294 = 0;
		}
		object obj299 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj300 = (nint)0 + (nint)2128;
		num28 = (nint)obj300;
		Func<object, long> func111 = default(Func<object, long>);
		func111..ctor(obj294, (IntPtr)obj300);
		object obj301 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X8_v56+B8]");
		object obj302 = (nint)0 + (nint)56;
		obj302 = func111;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj197 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
		bool flag105 = (nint)0 == 0;
		object obj303 = !flag105;
		func79 = null;
		func80 = (Func<object>)(object)func111;
		Func<CachedModel<List<object>>> func112 = (Func<CachedModel<List<object>>>)func109;
		func110 = func111;
		text19 = text20;
		Func<string> func113 = (Func<string>)func83;
		Func<CachedModel<List<object>>> func114 = null;
		Func<object> func115 = (Func<object>)(object)func111;
		nint num40 = (nint)obj300;
		object obj304 = obj197;
		Func<CachedModel<List<object>>> func116 = (Func<CachedModel<List<object>>>)func109;
		Func<object, long> func117 = func111;
		Func<string> func118 = (Func<string>)func83;
		if (obj303 != null)
		{
			goto IL_0e17;
		}
		goto IL_3516;
		IL_4502:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2416 @ X0_v300+E4]");
		bool flag106 = (nint)0 == 0;
		object obj305 = !flag106;
		if (obj305 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj306 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2499 @ X8_v226+B8]");
			obj291 = 0;
		}
		object obj307 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj308 = (nint)0 + (nint)2032;
		num17 = (nint)obj308;
		Func<object> func119 = default(Func<object>);
		func119..ctor(obj291, (IntPtr)obj308);
		object obj309 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2515 @ X8_v224+B8]");
		object obj310 = (nint)0 + (nint)176;
		obj310 = func119;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj102 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+E4]");
		bool flag107 = (nint)0 == 0;
		object obj311 = !flag107;
		func52 = null;
		func53 = func119;
		func98 = (Func<CachedModel<List<object>>>)func119;
		text14 = text15;
		num35 = (nint)func56;
		Func<CachedModel<List<object>>> func120 = null;
		Func<object> func121 = func119;
		nint num41 = (nint)obj308;
		object obj312 = obj102;
		Func<CachedModel<List<object>>> func122 = (Func<CachedModel<List<object>>>)func119;
		nint num42 = (nint)func56;
		if (obj311 != null)
		{
			goto IL_214d;
		}
		goto IL_45e3;
		IL_4d54:
		return (Dictionary<string, IContentApplier>)(object)new NullReferenceException();
		IL_0da2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
		bool flag108 = (nint)0 == 0;
		func112 = (Func<CachedModel<List<object>>>)func105;
		func113 = (Func<string>)func77;
		func114 = func79;
		func115 = func80;
		num40 = num28;
		obj304 = obj197;
		func116 = (Func<CachedModel<List<object>>>)func105;
		func117 = func110;
		text20 = text19;
		func118 = (Func<string>)func77;
		if (!flag108)
		{
			goto IL_0e17;
		}
		goto IL_3516;
		IL_3516:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj197 = obj41;
		func79 = func114;
		func80 = func115;
		num28 = num40;
		func112 = func116;
		func110 = func117;
		text19 = text20;
		func113 = func118;
		goto IL_0e17;
		IL_0e17:
		object obj313 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3384;
		object obj314 = (nint)0 + (nint)1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+B8]");
		object obj315 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X8_v444+40]");
		Action action18 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1361 @ X8_v444+40]");
		bool flag109 = (nint)0 == 0;
		object obj316 = !flag109;
		Action action19 = (Action)(object)func80;
		if (obj316 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X0_v147+E4]");
			bool flag110 = (nint)0 == 0;
			object obj317 = !flag110;
			if (obj317 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj318 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ X8_v450+B8]");
				obj315 = 0;
			}
			object obj319 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj320 = (nint)0 + (nint)2136;
			num28 = (nint)obj320;
			Action action20 = default(Action);
			action20..ctor(obj315, (IntPtr)obj320);
			object obj321 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X8_v449+B8]");
			object obj322 = (nint)0 + (nint)64;
			obj322 = action20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func79 = null;
			action19 = action20;
			action18 = action20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj55 = obj314;
		ListDeltaApplier<object, long> listDeltaApplier12 = default(ListDeltaApplier<object, long>);
		listDeltaApplier12..ctor(text19, func113, func112, func110, action18, (Action)null);
		bool flag111 = listDeltaApplier12 == null;
		string text23 = text19;
		if (!flag111)
		{
			nint num43 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v443 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text23 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag112 = ex == null;
			action7 = null;
			action8 = action18;
			func23 = func110;
			func = func112;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v443 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = (nint)func113;
			if (flag112)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag113 = (nint)0 < (nint)5;
		object obj323 = !flag113;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj324 = -5;
		bool flag114 = obj324 == null;
		object obj325 = ~obj323;
		object obj326 = obj325 | flag114;
		action7 = null;
		action8 = action18;
		func23 = func110;
		func = func112;
		text = text23;
		num = (nint)func113;
		Func<object> func125;
		object obj339;
		Func<CachedModel<List<object>>> func124;
		ListDeltaApplier<object, long> listDeltaApplier13;
		nint num44;
		if (obj326 == null)
		{
			object obj327 = "___# Content push apply failed [{0}]: {1}" + 2944;
			object obj328 = enumerable + 72;
			obj328 = listDeltaApplier12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj44 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
			object obj329;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+B8]");
				obj329 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v117+48]");
				func14 = (Func<object>)0;
				text5 = (string)obj327;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v117+48]");
				bool flag115 = (nint)0 == 0;
				object obj330 = obj44;
				text4 = (string)obj327;
				if (!flag115)
				{
					goto IL_1105;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj44 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+B8]");
				obj329 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v117+48]");
				func14 = (Func<object>)0;
				text5 = (string)obj327;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v117+48]");
				bool flag116 = (nint)0 == 0;
				object obj331 = !flag116;
				object obj330 = obj44;
				text4 = (string)obj327;
				if (obj331 != null)
				{
					goto IL_1105;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X0_v183+E4]");
			bool flag117 = (nint)0 == 0;
			object obj332 = !flag117;
			if (obj332 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj333 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1513 @ X8_v124+B8]");
				obj329 = 0;
			}
			object obj334 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj335 = (nint)0 + (nint)2144;
			num44 = (nint)obj335;
			Func<object> func123 = default(Func<object>);
			func123..ctor(obj329, (IntPtr)obj335);
			object obj336 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ X8_v122+B8]");
			object obj337 = (nint)0 + (nint)72;
			obj337 = func123;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj44 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
			bool flag118 = (nint)0 == 0;
			object obj338 = !flag118;
			func16 = null;
			listDeltaApplier2 = (ListDeltaApplier<object, long>)(object)func123;
			func18 = (Func<string>)obj335;
			text5 = text4;
			func14 = func123;
			func124 = null;
			listDeltaApplier13 = (ListDeltaApplier<object, long>)(object)func123;
			obj339 = obj44;
			func125 = func123;
			if (obj338 != null)
			{
				goto IL_1172;
			}
			goto IL_36b0;
		}
		goto IL_4d2e;
		IL_256e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+E4]");
		bool flag119 = (nint)0 == 0;
		func33 = (Func<string>)func91;
		func44 = func43;
		func46 = func45;
		num15 = num14;
		obj255 = obj84;
		func47 = func31;
		text12 = text11;
		func48 = (Func<string>)func91;
		if (!flag119)
		{
			goto IL_25d3;
		}
		goto IL_48e8;
		IL_20e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+E4]");
		bool flag120 = (nint)0 == 0;
		num35 = (nint)func50;
		func120 = func52;
		func121 = func53;
		num41 = num17;
		obj312 = obj102;
		func122 = func98;
		text15 = text14;
		num42 = (nint)func50;
		if (!flag120)
		{
			goto IL_214d;
		}
		goto IL_45e3;
		IL_45e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj102 = obj41;
		func52 = func120;
		func53 = func121;
		num17 = num41;
		func98 = func122;
		text14 = text15;
		num35 = num42;
		goto IL_214d;
		IL_2073:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+B8]");
		obj291 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2468 @ X8_v219+B0]");
		func98 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2468 @ X8_v219+B0]");
		bool flag121 = (nint)0 == 0;
		func54 = func52;
		func55 = func53;
		num18 = num17;
		obj293 = obj102;
		text15 = text14;
		func56 = func50;
		if (!flag121)
		{
			goto IL_20e8;
		}
		goto IL_4502;
		IL_25d3:
		object obj340 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3416;
		object obj341 = (nint)0 + (nint)1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+B8]");
		object obj342 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2723 @ X8_v344+D0]");
		Func<object, long> func126 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2723 @ X8_v344+D0]");
		bool flag122 = (nint)0 == 0;
		object obj343 = !flag122;
		Func<object, long> func127 = (Func<object, long>)(object)func45;
		if (obj343 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+E4]");
			bool flag123 = (nint)0 == 0;
			object obj344 = !flag123;
			if (obj344 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj345 = typeof(CardUtils.<>c) + 2376;
				object obj346 = obj345;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2738 @ X8_v354+B8]");
				obj342 = 0;
			}
			object obj347 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj348 = (nint)0 + (nint)2064;
			num14 = (nint)obj348;
			Func<object, long> func128 = default(Func<object, long>);
			func128..ctor(obj342, (IntPtr)obj348);
			object obj349 = typeof(CardUtils.<>c) + 2376;
			object obj350 = obj349;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2711 @ X8_v351+B8]");
			object obj351 = (nint)0 + (nint)208;
			obj351 = func128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func43 = null;
			func127 = func128;
			func126 = func128;
		}
		object obj352 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action21 = default(Action);
		action21..ctor(null, (IntPtr)obj223);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj55 = obj341;
		listDeltaApplier7..ctor(text11, func33, func31, func126, action21, (Action)null);
		bool flag124 = listDeltaApplier7 == null;
		string text24 = text11;
		if (!flag124)
		{
			nint num45 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v343 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text24 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag125 = ex == null;
			action7 = null;
			action8 = action21;
			func23 = func126;
			func = func31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v343 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = (nint)func33;
			if (flag125)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag126 = (nint)0 < (nint)10;
		object obj353 = !flag126;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj354 = -10;
		bool flag127 = obj354 == null;
		obj142 = typeof(CardUtils.<>c) + 2376;
		object obj355 = ~obj353;
		object obj356 = obj355 | flag127;
		action7 = null;
		action8 = action21;
		func23 = func126;
		func = func31;
		text = text24;
		num = (nint)func33;
		if (obj356 == null)
		{
			object obj357 = "startPosition" + 672;
			object obj358 = enumerable + 112;
			obj358 = listDeltaApplier7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj75 = obj142;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+E4]");
			object obj359;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+B8]");
				obj359 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v295+D8]");
				func36 = (Func<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v295+D8]");
				bool flag128 = (nint)0 == 0;
				text10 = (string)obj357;
				text9 = (string)obj357;
				object obj360 = obj75;
				if (!flag128)
				{
					goto IL_291a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj75 = obj142;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+B8]");
				obj359 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v295+D8]");
				func36 = (Func<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2829 @ X8_v295+D8]");
				bool flag129 = (nint)0 == 0;
				object obj361 = !flag129;
				text10 = (string)obj357;
				text9 = (string)obj357;
				object obj360 = obj75;
				if (obj361 != null)
				{
					goto IL_291a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2787 @ X0_v386+E4]");
			bool flag130 = (nint)0 == 0;
			object obj362 = !flag130;
			if (obj362 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj363 = obj142;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2865 @ X8_v302+B8]");
				obj359 = 0;
			}
			object obj364 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj365 = (nint)0 + (nint)2072;
			num10 = (nint)obj365;
			Func<object> func129 = default(Func<object>);
			func129..ctor(obj359, (IntPtr)obj365);
			object obj366 = obj142;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2913 @ X8_v300+B8]");
			object obj367 = (nint)0 + (nint)216;
			obj367 = func129;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj75 = obj142;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+E4]");
			bool flag131 = (nint)0 == 0;
			object obj368 = !flag131;
			text10 = text9;
			func30 = null;
			listDeltaApplier6 = (ListDeltaApplier<object, long>)(object)func129;
			func32 = (Func<string>)obj365;
			func36 = func129;
			func34 = null;
			listDeltaApplier8 = (ListDeltaApplier<object, long>)(object)func129;
			obj74 = obj75;
			func35 = func129;
			if (obj368 != null)
			{
				goto IL_2987;
			}
			goto IL_4a7a;
		}
		goto IL_4d2e;
		IL_4d3c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_4d54;
		IL_214d:
		obj223 = (nint)0 + (nint)2496;
		object obj369 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3424;
		object obj370 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+B8]");
		object obj371 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2506 @ X8_v364+B8]");
		Func<object, long> func130 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2506 @ X8_v364+B8]");
		bool flag132 = (nint)0 == 0;
		object obj372 = !flag132;
		Func<object, int> func131 = (Func<object, int>)(object)func53;
		if (obj372 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X0_v323+E4]");
			bool flag133 = (nint)0 == 0;
			object obj373 = !flag133;
			if (obj373 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj374 = typeof(CardUtils.<>c) + 2376;
				object obj375 = obj374;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2521 @ X8_v374+B8]");
				obj371 = 0;
			}
			object obj376 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj377 = (nint)0 + (nint)2040;
			num17 = (nint)obj377;
			Func<object, int> func132 = default(Func<object, int>);
			func132..ctor(obj371, (IntPtr)obj377);
			object obj378 = typeof(CardUtils.<>c) + 2376;
			object obj379 = obj378;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2494 @ X8_v371+B8]");
			object obj380 = (nint)0 + (nint)184;
			obj380 = func132;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func52 = null;
			func131 = func132;
			func130 = (Func<object, long>)(object)func132;
		}
		object obj381 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action22 = default(Action);
		action22..ctor(null, (IntPtr)obj223);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj55 = obj370;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @328B910");
		bool flag134 = func99 == null;
		string text25 = text14;
		if (!flag134)
		{
			nint num46 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v363 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text25 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag135 = ex == null;
			action7 = null;
			action8 = action22;
			func23 = func130;
			func = func98;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v363 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			text = (string)0;
			num = num35;
			if (flag135)
			{
				goto IL_4d3c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		bool flag136 = (nint)0 < (nint)9;
		object obj382 = !flag136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj383 = -9;
		bool flag137 = obj383 == null;
		obj85 = typeof(CardUtils.<>c) + 2376;
		object obj384 = ~obj382;
		object obj385 = obj384 | flag137;
		action7 = null;
		action8 = action22;
		func23 = func130;
		func = func98;
		text = text25;
		num = num35;
		if (obj385 == null)
		{
			object obj386 = "startPosition" + 680;
			object obj387 = enumerable + 104;
			obj387 = func99;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj84 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+E4]");
			object obj388;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+B8]");
				obj388 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2608 @ X8_v263+C0]");
				func91 = (Func<object>)0;
				text11 = (string)obj386;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2608 @ X8_v263+C0]");
				bool flag138 = (nint)0 == 0;
				object obj389 = obj84;
				text12 = (string)obj386;
				if (!flag138)
				{
					goto IL_248c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj84 = obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+B8]");
				obj388 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2608 @ X8_v263+C0]");
				func91 = (Func<object>)0;
				text11 = (string)obj386;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2608 @ X8_v263+C0]");
				bool flag139 = (nint)0 == 0;
				object obj390 = !flag139;
				object obj389 = obj84;
				text12 = (string)obj386;
				if (obj390 != null)
				{
					goto IL_248c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2565 @ X0_v349+E4]");
			bool flag140 = (nint)0 == 0;
			object obj391 = !flag140;
			if (obj391 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj392 = obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2644 @ X8_v270+B8]");
				obj388 = 0;
			}
			object obj393 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj394 = (nint)0 + (nint)2048;
			num14 = (nint)obj394;
			Func<object> func133 = default(Func<object>);
			func133..ctor(obj388, (IntPtr)obj394);
			object obj395 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2691 @ X8_v268+B8]");
			object obj396 = (nint)0 + (nint)192;
			obj396 = func133;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj84 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2659 @ X0_v360+E4]");
			bool flag141 = (nint)0 == 0;
			object obj397 = !flag141;
			func43 = null;
			func45 = func133;
			text11 = text12;
			func91 = func133;
			func88 = null;
			func89 = func133;
			num32 = (nint)obj394;
			obj246 = obj84;
			func90 = func133;
			if (obj397 != null)
			{
				goto IL_24f9;
			}
			goto IL_4775;
		}
		goto IL_4d2e;
		IL_1b68:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+B8]");
		object obj398 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ X8_v189+90]");
		func8 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ X8_v189+90]");
		bool flag142 = (nint)0 == 0;
		func103 = func4;
		func104 = func6;
		num38 = num6;
		object obj399 = obj40;
		text2 = text3;
		func9 = func10;
		if (!flag142)
		{
			goto IL_1bdd;
		}
		goto IL_4072;
		IL_3fe0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+B8]");
		obj398 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ X8_v189+90]");
		func8 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ X8_v189+90]");
		bool flag143 = (nint)0 == 0;
		object obj400 = !flag143;
		func4 = func103;
		func6 = func104;
		num6 = num38;
		text3 = text2;
		func10 = func9;
		obj399 = obj40;
		if (obj400 != null)
		{
			goto IL_1bdd;
		}
		goto IL_4072;
		IL_1afb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
		bool flag144 = (nint)0 == 0;
		func4 = func93;
		func6 = func101;
		num6 = num33;
		func103 = func93;
		func104 = func101;
		num38 = num33;
		obj279 = obj40;
		text2 = text3;
		func9 = func10;
		if (!flag144)
		{
			goto IL_1b68;
		}
		goto IL_3fe0;
		IL_4a7a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj75 = obj142;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+B8]");
		obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2907 @ X8_v283+E0]");
		func61 = (Func<CachedModel<List<object>>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2907 @ X8_v283+E0]");
		bool flag145 = (nint)0 == 0;
		object obj401 = !flag145;
		text10 = text9;
		func30 = func34;
		listDeltaApplier6 = listDeltaApplier8;
		func32 = (Func<string>)num10;
		func36 = func35;
		obj141 = obj75;
		if (obj401 != null)
		{
			goto IL_29fc;
		}
		goto IL_4b0c;
		IL_4072:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2127 @ X0_v265+E4]");
		bool flag146 = (nint)0 == 0;
		object obj402 = !flag146;
		if (obj402 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj403 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ X8_v196+B8]");
			obj398 = 0;
		}
		object obj404 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj405 = (nint)0 + (nint)1992;
		num6 = (nint)obj405;
		Func<object> func134 = default(Func<object>);
		func134..ctor(obj398, (IntPtr)obj405);
		object obj406 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2268 @ X8_v194+B8]");
		object obj407 = (nint)0 + (nint)144;
		obj407 = func134;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
		bool flag147 = (nint)0 == 0;
		object obj408 = !flag147;
		func4 = null;
		func6 = func134;
		func8 = func134;
		text3 = text2;
		func10 = func9;
		func3 = null;
		func5 = func134;
		num5 = (nint)obj405;
		object obj409 = obj40;
		func7 = func134;
		if (obj408 != null)
		{
			goto IL_1c3a;
		}
		goto IL_414b;
		IL_1105:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
		bool flag148 = (nint)0 == 0;
		func16 = func112;
		listDeltaApplier2 = listDeltaApplier12;
		func18 = func113;
		func124 = func112;
		listDeltaApplier13 = listDeltaApplier12;
		num44 = (nint)func113;
		obj339 = obj44;
		text4 = text5;
		func125 = func14;
		if (!flag148)
		{
			goto IL_1172;
		}
		goto IL_36b0;
		IL_36b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj44 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+B8]");
		object obj410 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v105+50]");
		func12 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v105+50]");
		bool flag149 = (nint)0 == 0;
		object obj411 = !flag149;
		func16 = func124;
		listDeltaApplier2 = listDeltaApplier13;
		func18 = (Func<string>)num44;
		text5 = text4;
		func14 = func125;
		object obj412 = obj44;
		if (obj411 != null)
		{
			goto IL_11e7;
		}
		goto IL_3742;
		IL_1172:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+B8]");
		obj410 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v105+50]");
		func12 = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v105+50]");
		bool flag150 = (nint)0 == 0;
		func124 = func16;
		listDeltaApplier13 = listDeltaApplier2;
		num44 = (nint)func18;
		obj412 = obj44;
		text4 = text5;
		func125 = func14;
		if (!flag150)
		{
			goto IL_11e7;
		}
		goto IL_3742;
		IL_3742:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ X0_v171+E4]");
		bool flag151 = (nint)0 == 0;
		object obj413 = !flag151;
		if (obj413 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj414 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1601 @ X8_v112+B8]");
			obj410 = 0;
		}
		object obj415 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj416 = (nint)0 + (nint)2152;
		nint num47 = (nint)obj416;
		Func<object> func135 = default(Func<object>);
		func135..ctor(obj410, (IntPtr)obj416);
		object obj417 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ X8_v110+B8]");
		object obj418 = (nint)0 + (nint)80;
		obj418 = func135;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj44 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
		bool flag152 = (nint)0 == 0;
		object obj419 = !flag152;
		func16 = null;
		listDeltaApplier2 = (ListDeltaApplier<object, long>)(object)func135;
		func18 = (Func<string>)obj416;
		func12 = func135;
		text5 = text4;
		func14 = func125;
		Func<CachedModel<List<object>>> func136 = null;
		ListDeltaApplier<object, long> listDeltaApplier14 = (ListDeltaApplier<object, long>)(object)func135;
		object obj420 = obj44;
		Func<object> func137 = func135;
		if (obj419 != null)
		{
			goto IL_1244;
		}
		goto IL_381b;
		IL_1bdd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2235 @ X0_v288+E4]");
		bool flag153 = (nint)0 == 0;
		func3 = func4;
		func5 = func6;
		num5 = num6;
		obj409 = obj40;
		func7 = func8;
		text2 = text3;
		func9 = func10;
		if (!flag153)
		{
			goto IL_1c3a;
		}
		goto IL_414b;
		IL_4b0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2856 @ X0_v374+E4]");
		bool flag154 = (nint)0 == 0;
		object obj421 = !flag154;
		if (obj421 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj422 = obj142;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2938 @ X8_v290+B8]");
			obj140 = 0;
		}
		object obj423 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj424 = (nint)0 + (nint)2080;
		Func<object> func138 = default(Func<object>);
		func138..ctor(obj140, (IntPtr)obj424);
		object obj425 = obj142;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2954 @ X8_v288+B8]");
		object obj426 = (nint)0 + (nint)224;
		obj426 = func138;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj75 = obj142;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ X0_v397+E4]");
		bool flag155 = (nint)0 == 0;
		object obj427 = !flag155;
		text10 = text9;
		func30 = null;
		listDeltaApplier6 = (ListDeltaApplier<object, long>)(object)func138;
		func32 = (Func<string>)obj424;
		func61 = (Func<CachedModel<List<object>>>)func138;
		num21 = (nint)func35;
		func62 = null;
		listDeltaApplier9 = (ListDeltaApplier<object, long>)(object)func138;
		func63 = (Func<string>)obj424;
		obj153 = obj75;
		func64 = (Func<CachedModel<List<object>>>)func138;
		num22 = (nint)func35;
		if (obj427 != null)
		{
			goto IL_2a61;
		}
		goto IL_4bf5;
		IL_11e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
		bool flag156 = (nint)0 == 0;
		func136 = func16;
		listDeltaApplier14 = listDeltaApplier2;
		num47 = (nint)func18;
		obj420 = obj44;
		func137 = func12;
		text4 = text5;
		func125 = func14;
		if (!flag156)
		{
			goto IL_1244;
		}
		goto IL_381b;
		IL_381b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj44 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+B8]");
		object obj428 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v93+58]");
		func21 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v93+58]");
		bool flag157 = (nint)0 == 0;
		object obj429 = !flag157;
		func16 = func136;
		listDeltaApplier2 = listDeltaApplier14;
		func18 = (Func<string>)num47;
		func12 = func137;
		text5 = text4;
		func14 = func125;
		object obj430 = obj44;
		if (obj429 != null)
		{
			goto IL_12c1;
		}
		goto IL_38b5;
		IL_1244:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+B8]");
		obj428 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v93+58]");
		func21 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v93+58]");
		bool flag158 = (nint)0 == 0;
		func136 = func16;
		listDeltaApplier14 = listDeltaApplier2;
		num47 = (nint)func18;
		obj430 = obj44;
		func137 = func12;
		text4 = text5;
		func125 = func14;
		if (!flag158)
		{
			goto IL_12c1;
		}
		goto IL_38b5;
		IL_38b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X0_v159+E4]");
		bool flag159 = (nint)0 == 0;
		object obj431 = !flag159;
		if (obj431 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj432 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X8_v100+B8]");
			obj428 = 0;
		}
		object obj433 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj434 = (nint)0 + (nint)1936;
		Func<object, object> func139 = default(Func<object, object>);
		func139..ctor(obj428, (IntPtr)obj434);
		object obj435 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1696 @ X8_v98+B8]");
		object obj436 = (nint)0 + (nint)88;
		obj436 = func139;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj44 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1620 @ X0_v194+E4]");
		bool flag160 = (nint)0 == 0;
		object obj437 = !flag160;
		func16 = null;
		listDeltaApplier2 = (ListDeltaApplier<object, long>)(object)func139;
		func18 = (Func<string>)obj434;
		func11 = (Func<CachedModel<List<object>>>)func137;
		func21 = func139;
		text5 = text4;
		func13 = (Func<string>)func125;
		func15 = null;
		listDeltaApplier = (ListDeltaApplier<object, long>)(object)func139;
		func17 = (Func<string>)obj434;
		obj43 = obj44;
		func19 = (Func<CachedModel<List<object>>>)func137;
		func20 = func139;
		func22 = (Func<string>)func125;
		if (obj437 != null)
		{
			goto IL_1336;
		}
		goto IL_39ae;
	}

	public static void OnContentChangedReceived(string wireKey, string stamp)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_00b7: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2168;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj6 = obj2 + 16;
		obj6 = wireKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KUtil.CallInMainThread(action);
	}

	public static void OnContentDeltaReceived(string wireKey, string payloadJson)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00dc: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2176;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj6 = obj2 + 16;
		obj6 = wireKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = payloadJson;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KUtil.CallInMainThread(action);
	}

	public static void OnContentBlobReceived(string wireKey, string modelJson)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00dc: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2192;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj6 = obj2 + 16;
		obj6 = wireKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = modelJson;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KUtil.CallInMainThread(action);
	}

	public static void NotifyClientFilterChanged()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b2: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+10]");
		Actions.SafeInvoke((Action)0);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+18]");
		Actions.SafeInvoke((Action)0);
	}

	public static void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0095: Expected I, but got O
		//IL_00bf: Expected O, but got I4
		//IL_006e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2480;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Preferences.OnGameChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj2);
		Preferences.OnGameChanged += action2;
	}

	private unsafe static void Apply(string wireKey, string kind, Action<IContentApplier> apply)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04b5: Expected O, but got I4
		//IL_04d4: Expected O, but got I
		//IL_003c: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I4
		//IL_03b2: Expected O, but got Ref
		//IL_0393: Expected O, but got Ref
		//IL_03c9: Expected O, but got I4
		//IL_03d1: Expected O, but got Ref
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_013f: Expected O, but got I8
		//IL_03f7: Expected O, but got Ref
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0415: Expected O, but got Ref
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0226: Expected O, but got I8
		//IL_0433: Expected O, but got Ref
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_027f: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_0459: Expected O, but got Ref
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0341: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+30]");
		if ((nint)0 != 0)
		{
			object obj5 = (nint)0 + (nint)2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+30]");
			if (((Dictionary<object, object>)0).TryGetValue(wireKey, out var value))
			{
				Action<IContentApplier> action = default(Action<IContentApplier>);
				if (action != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ X2_v1 (System.Action`1<Kammelna.Server.IContentApplier>)+18] (should have been resolved before IL gen)");
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				string text = wireKey;
				action = (Action<IContentApplier>)(&value);
			}
			else
			{
				object obj6 = typeof(SqlSingle[]) + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				string[] array = default(string[]);
				if (array != null)
				{
					if (array.Length != 0)
					{
						object obj7 = "___# Content push apply failed [{0}]: {1}" + 504;
						object obj8 = array + 32;
						obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj9 = array.Length & 0xFFFFFFFEL;
						if (obj9 != null)
						{
							object obj10 = array + 40;
							string text = default(string);
							obj10 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag2 = array.Length < 2;
							object obj11 = !flag2;
							object obj12 = array.Length - 2;
							bool flag3 = obj12 == null;
							object obj13 = ~obj11;
							object obj14 = obj13 | flag3;
							if (obj14 == null)
							{
								object obj15 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 216;
								text = (string)obj15;
								object obj16 = array + 48;
								obj16 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj17 = array.Length & 0xFFFFFFFCL;
								if (obj17 != null)
								{
									object obj18 = array + 56;
									obj18 = wireKey;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag4 = array.Length < 4;
									object obj19 = !flag4;
									object obj20 = array.Length - 4;
									bool flag5 = obj20 == null;
									object obj21 = ~obj19;
									object obj22 = obj21 | flag5;
									if (obj22 == null)
									{
										object obj23 = "[{0}]:{1}" + 352;
										object obj24 = array + 64;
										obj24 = obj23;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										string message = string.Concat(array);
										object obj25 = typeof(DataRelation) + 856;
										object obj26 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v38+E4]");
										bool flag6 = (nint)0 == 0;
										object obj27 = !flag6;
										if (obj27 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Debug.Log(message);
										return;
									}
									IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
									text = wireKey;
									Action<IContentApplier> action = (Action<IContentApplier>)(&value);
									NullReferenceException ex = (NullReferenceException)(object)ex2;
								}
								else
								{
									IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
									Action<IContentApplier> action = (Action<IContentApplier>)(&value);
									NullReferenceException ex = (NullReferenceException)(object)ex3;
								}
							}
							else
							{
								IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
								Action<IContentApplier> action = (Action<IContentApplier>)(&value);
								NullReferenceException ex = (NullReferenceException)(object)ex4;
							}
						}
						else
						{
							IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
							string text = (string)obj7;
							Action<IContentApplier> action = (Action<IContentApplier>)(&value);
							NullReferenceException ex = (NullReferenceException)(object)ex5;
						}
					}
					else
					{
						IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
						string text = (string)5;
						Action<IContentApplier> action = (Action<IContentApplier>)(&value);
						NullReferenceException ex = (NullReferenceException)(object)ex6;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					string text = (string)5;
					Action<IContentApplier> action = (Action<IContentApplier>)(&value);
				}
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private static void ApplyRemoteConfigBlob(string modelJson)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_017c: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0277: Expected O, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_030d: Expected O, but got I4
		//IL_033f: Expected O, but got I
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_038f: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E823D]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)3872;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)3872;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		if (dictionary == null)
		{
			return;
		}
		goto IL_015c;
		IL_015c:
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj10 = (nint)0 + (nint)2728;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		object value;
		bool flag4 = dictionary.TryGetValue((System.Int32Enum)currentGame, out value);
		bool flag5 = !flag4;
		object obj13 = !flag5;
		object obj14 = ~obj13;
		if (obj14 == null && value != null)
		{
			object obj15 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "COORDINATE_TYPE_GCJ_02" + 624;
			CachedModel<object> model = CachedModels.GetModel<object>((string)key);
			object obj18 = (nint)0 + (nint)616;
			model.Update(value);
			object obj19 = typeof(DataRelation) + 712;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v13+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			object obj22 = (nint)0 + (nint)632;
			model.LastUpdate = now;
			object obj23 = typeof(RegisteredWaitHandle) + 56;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v18+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfig.Apply((RemoteConfigModel)value);
		}
		return;
		IL_0091:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		bool flag9 = dictionary == null;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			return;
		}
		goto IL_015c;
	}

	private static void ApplyHintsBlob(string modelJson)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_01f6: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_0247: Expected O, but got I4
		//IL_0135: Expected O, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E823E]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)3880;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)3880;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		object obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v26+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CachedModel<List<InGameHintModel>> hints = CachedModels.Hints;
		object obj14 = (nint)0 + (nint)416;
		object obj15 = typeof(DataRelation) + 712;
		((CachedModel<object>)(object)hints).Update(obj9);
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v31+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		((CachedModel<object>)(object)hints).LastUpdate = now;
		return;
		IL_0091:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		if (obj9 != null)
		{
			goto IL_00c0;
		}
	}

	private static void ApplyStoreItemGroupsBlob(string modelJson)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_0214: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_0136: Expected O, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02b2: Expected O, but got I4
		//IL_02e4: Expected O, but got I
		//IL_0328: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E823F]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)3896;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)3896;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_01d2:
		NotifyStoreApplied();
		return;
		IL_00c0:
		object obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v32+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CachedModel<List<ItemGroup>> storeItemGroups = CachedModels.StoreItemGroups;
		object obj14 = (nint)0 + (nint)456;
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		bool flag5 = ((CachedModel<object>)(object)storeItemGroups).IsValid();
		object obj16 = obj14;
		((CachedModel<object>)(object)storeItemGroups).Update(obj9);
		bool flag6 = !flag5;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			object obj18 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v48+E4]");
			bool flag7 = (nint)0 == 0;
			DateTime dateTime = (DateTime)obj9;
			object obj19 = obj18;
			if (!flag7)
			{
				goto IL_01d2;
			}
		}
		else
		{
			object obj20 = typeof(DataRelation) + 712;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v41+E4]");
			bool flag8 = (nint)0 == 0;
			object obj22 = !flag8;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			object obj23 = (nint)0 + (nint)472;
			obj16 = obj23;
			((CachedModel<object>)(object)storeItemGroups).LastUpdate = now;
			object obj18 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v48+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = !flag9;
			DateTime dateTime = now;
			object obj19 = obj18;
			if (obj24 != null)
			{
				goto IL_01d2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NotifyStoreApplied();
		return;
		IL_0091:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		if (obj9 != null)
		{
			goto IL_00c0;
		}
	}

	private static void OnStoreProductsChanged()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_02dc: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_016b: Expected O, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8240]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<ProductViewModel>> storeProducts = CachedModels.StoreProducts;
		bool flag2 = storeProducts == null;
		object obj6 = !flag2;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)storeProducts;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0093;
		IL_0093:
		object obj7 = (nint)0 + (nint)528;
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		cachedModel.ClearLastUpdateDate((DateTime?)(object)0);
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v28+E4]");
		object obj11;
		if ((nint)0 != 0)
		{
			Store.HasNewStoreSinceLastVisit = true;
			obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v35+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = 0;
			object obj13 = obj11;
			if (!flag3)
			{
				goto IL_014a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Store.HasNewStoreSinceLastVisit = true;
			obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v35+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj12 = 0;
			object obj13 = obj11;
			if (obj14 != null)
			{
				goto IL_014a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj9;
		goto IL_014a;
		IL_007d:
		CachedModel<List<ProductViewModel>> storeProducts2 = CachedModels.StoreProducts;
		cachedModel = (CachedModel<object>)(object)storeProducts2;
		goto IL_0093;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v35+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v14+28]");
		Actions.SafeInvoke((Action)0);
		if (Store.IsLoaded)
		{
			object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v39+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object wireKey = "startPosition" + 672;
			ContentSyncService.EnsureFresh((string)wireKey);
		}
	}

	private static void NotifyStoreApplied()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0102: Expected O, but got I4
		//IL_00ad: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_008a: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.HasNewStoreSinceLastVisit = true;
		Store.ApplyStoreInfoUpdate();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v6+28]");
			Actions.SafeInvoke((Action)0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v8+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+28]");
			Actions.SafeInvoke((Action)0);
		}
	}

	private static void NotifyPredictionsApplied()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_01a0: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8242]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PredictAndWinManager.HasNewPredictionsSinceLastVisit = true;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = 0;
		object obj11 = obj8;
		obj4 = obj6;
		if (obj9 != null)
		{
			goto IL_00e1;
		}
		goto IL_01c7;
		IL_00e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v16+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v9+20]");
		Actions.SafeInvoke((Action)0);
		return;
		IL_01c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v3+20]");
		Actions.SafeInvoke((Action)0);
		return;
		IL_0099:
		PredictAndWinManager.HasNewPredictionsSinceLastVisit = true;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = 0;
		obj11 = obj8;
		if (!flag4)
		{
			goto IL_00e1;
		}
		goto IL_01c7;
	}

	static ContentPushService()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Dictionary<string, IContentApplier> dictionary = BuildCatalog();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+B8]");
		object obj3 = (nint)0 + (nint)48;
		obj3 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
