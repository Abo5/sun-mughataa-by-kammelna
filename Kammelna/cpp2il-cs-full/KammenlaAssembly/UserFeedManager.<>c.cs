using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class UserFeedManager : Singleton<UserFeedManager>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<UserFeedItem> <>9__18_0;

		public static Func<UserFeedItem, long> <>9__21_0;

		public static Comparison<UserFeedItem> <>9__21_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SaveFeedsToCache>b__18_0(UserFeedItem item)
		{
			//IL_0097: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (item != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return item.<DateExpires>k__BackingField < now;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal long <ProcessNewFeeds>b__21_0(UserFeedItem item)
		{
			//IL_0035: Expected I8, but got O
			if (item != null)
			{
				return item.<Id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal int <ProcessNewFeeds>b__21_1(UserFeedItem a, UserFeedItem b)
		{
			//IL_00a7: Expected I4, but got O
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0061: Expected O, but got I4
			if (a != null && b != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime = default(DateTime);
				return dateTime.CompareTo(b.<DateCreated>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private const string UpdateFeedCommand = "uf";

	private string _currentUser;

	private List<UserFeedItem> _feeds;

	private UserFeedEventsChannel eventsChannel;

	private bool _isDirty;

	private Coroutine _savingTask;

	private string FeedsPath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00d4: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object path = "m_StencilDeferredPS" + 2256;
			object path2 = "Unsupported map type" + 824;
			string cachePath = Config.CachePath;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Path.Combine(cachePath, (string)path, _currentUser, (string)path2);
		}
	}

	public IEnumerable<UserFeedItem> Feeds
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_0043: Expected I, but got O
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 96;
			object obj2 = (nint)0 + (nint)4080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			return (IEnumerable<UserFeedItem>)Enumerable.Where(_feeds, func);
		}
	}

	public IEnumerable<UserFeedItem> UnreadFeeds
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_0043: Expected I, but got O
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 96;
			object obj2 = (nint)0 + (nint)4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			return (IEnumerable<UserFeedItem>)Enumerable.Where(_feeds, func);
		}
	}

	public int UnreadCount
	{
		get
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_0038: Expected O, but got I
			//IL_0056: Expected I, but got O
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 96;
			object obj2 = (nint)0 + (nint)4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			IEnumerable<object> source = Enumerable.Where(_feeds, func);
			return Enumerable.Count(source);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014b: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_016b: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I
		//IL_0219: Expected I, but got O
		//IL_0060: Expected I, but got O
		//IL_008f: Expected O, but got I4
		//IL_00df: Expected I, but got O
		//IL_00f0: Expected O, but got I
		//IL_011c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj3 = 0;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj5 = (nint)0 + (nint)8;
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		GameObject gameObject = base.gameObject;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object command = "tournament_participate_warning_body_with_tickets_warning_daily" + 1224;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj10 = (nint)0 + (nint)4064;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		SFS.OnLogin += action;
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.AddListener(go, (string)command, onlyOnce: false, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj10);
		object obj13 = (nint)0 + (nint)4088;
		eventsChannel.OnDismissFeed += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj13);
		eventsChannel.OnMarkFeedSeen += action4;
	}

	public void CreateLocalFeed(UserFeedItem feedItem)
	{
		//IL_0011: Expected O, but got I
		//IL_0090: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_0181: Expected O, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I
		//IL_01e4: Expected O, but got I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0495: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_011f: Expected O, but got I
		//IL_0285: Expected O, but got I4
		//IL_028d: Expected I, but got O
		//IL_0296: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_0352: Expected I, but got O
		//IL_02d2: Expected I, but got O
		//IL_02e2: Expected O, but got I
		//IL_0304: Expected O, but got I4
		//IL_030c: Expected I, but got O
		//IL_031c: Expected O, but got I
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_03a2: Expected O, but got I4
		//IL_03aa: Expected I, but got O
		List<object> feeds = (List<object>)(object)_feeds;
		bool flag = _feeds == null;
		UserFeedItem userFeedItem = feedItem;
		object obj6;
		object obj8;
		object obj9;
		nint num2 = default(nint);
		nint num;
		object obj10;
		if (!flag)
		{
			object obj = (nint)0 + (nint)2888;
			object obj2 = obj;
			int version = feeds._version + 1;
			feeds._version = version;
			object[] items = feeds._items;
			bool flag2 = feeds._items == null;
			userFeedItem = feedItem;
			if (!flag2)
			{
				bool flag3 = feeds._size < items.Length;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					int size = feeds._size + 1;
					feeds._size = size;
					object obj4 = feeds._items + feeds._size;
					object obj5 = obj4 + 32;
					obj5 = feedItem;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7030]");
					object obj7 = (nint)0 & (nint)1;
					bool flag4 = obj7 == null;
					obj8 = feedItem;
					if (flag4)
					{
						goto IL_021a;
					}
					num = num2;
					obj9 = obj6;
					obj10 = feedItem;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+20]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v16+C0]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v17+70]");
					num2 = 0;
					((List<object>)(object)_feeds).AddWithResize((object)feedItem);
					obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7030]");
					object obj13 = (nint)0 & (nint)1;
					bool flag5 = obj13 == null;
					object obj14 = !flag5;
					obj8 = feedItem;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v17+70]");
					num = 0;
					obj9 = obj6;
					obj10 = feedItem;
					if (obj14 == null)
					{
						goto IL_021a;
					}
				}
				goto IL_043e;
			}
		}
		goto IL_03db;
		IL_03f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_043e:
		object obj15 = typeof(SqlSingle[]) + 480;
		object obj16 = "Picking audio files is not supported on iOS" + 1864;
		int unreadCount = UnreadCount;
		object obj17 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Notifications, unreadCount, (string)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IReadOnlyList<UserFeedItem> readOnlyList = default(IReadOnlyList<UserFeedItem>);
		bool flag7 = readOnlyList == null;
		object obj19 = 0;
		num2 = (nint)obj16;
		userFeedItem = (UserFeedItem)1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag7)
		{
			bool flag8 = feedItem == null;
			UserFeedItem userFeedItem2 = (UserFeedItem)1;
			if (!flag8)
			{
				nint num3 = (nint)readOnlyList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Server.Models.UserFeedItem>>)+40]");
				userFeedItem2 = (UserFeedItem)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag9 = ex == null;
				obj19 = 0;
				num2 = (nint)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Server.Models.UserFeedItem>>)+40]");
				userFeedItem = (UserFeedItem)0;
				if (flag9)
				{
					goto IL_03f7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v17 (System.Collections.Generic.IReadOnlyList`1<Server.Models.UserFeedItem>)+18]");
			bool flag10 = (nint)0 == 0;
			obj19 = 0;
			num2 = (nint)obj16;
			userFeedItem = userFeedItem2;
			if (flag10)
			{
				goto IL_03e9;
			}
			object obj20 = readOnlyList + 32;
			obj20 = feedItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag11 = (object)eventsChannel == null;
			obj19 = 0;
			num2 = (nint)obj16;
			userFeedItem = feedItem;
			if (!flag11)
			{
				eventsChannel.TriggerFeedsReceived(readOnlyList);
				MarkDirty();
				return;
			}
		}
		goto IL_03db;
		IL_03e9:
		ex = new IndexOutOfRangeException();
		goto IL_03f7;
		IL_03db:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03e9;
		IL_021a:
		_ = 1;
		num = num2;
		obj9 = obj6;
		obj10 = obj8;
		goto IL_043e;
	}

	private List<UserFeedItem> GetCachedFeeds()
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_005f: Expected O, but got I4
		//IL_0088: Expected O, but got I
		string feedsPath = FeedsPath;
		if (File.Exists(feedsPath))
		{
			string feedsPath2 = FeedsPath;
			string text = File.ReadAllText(feedsPath2);
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
			List<UserFeedItem> result = default(List<UserFeedItem>);
			return result;
		}
		object obj5 = typeof(List<Tween>) + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<UserFeedItem>)(object)list;
	}

	private void MarkDirty()
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_003e: Expected I, but got O
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		object obj = this + 64;
		_ = 1;
		if (obj == null)
		{
			object obj2 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = (nint)0 + (nint)4048;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj3);
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSecondsPermanently(1f, action);
			obj = coroutine;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void SaveFeedsToCache()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_027d: Expected O, but got I4
		//IL_0213: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_0245: Expected O, but got I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_031b: Expected O, but got I
		//IL_032c: Expected I, but got O
		//IL_034a: Expected O, but got I
		//IL_02cc: Expected O, but got I4
		//IL_02ad: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_014e: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F2E]");
		object obj3 = (nint)0 & (nint)1;
		List<UserFeedItem> list;
		List<UserFeedItem> list2;
		object obj4;
		if (obj3 != null)
		{
			list = _feeds;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = _feeds;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = _feeds;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = _feeds;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
		Predicate<object> match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		list = list2;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_025b;
		IL_00f3:
		object obj9 = (nint)0 + (nint)2912;
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		List<object> list3;
		int num = list3.RemoveAll(match);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string contents = JsonConvert.SerializeObject(_feeds);
		string feedsPath = FeedsPath;
		File.WriteAllText(feedsPath, contents);
		return;
		IL_00e6:
		list3 = (List<object>)(object)list;
		goto IL_00f3;
		IL_025b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v10+B8]");
			obj7 = 0;
		}
		object obj15 = typeof(List<Tween>) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2280;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj7, (IntPtr)obj16);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v9+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag6 = list2 == null;
		object obj19 = !flag6;
		match = predicate;
		list3 = (List<object>)(object)list2;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f3;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
		match = (Predicate<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v4+8]");
		bool flag7 = (nint)0 == 0;
		list2 = list;
		if (!flag7)
		{
			goto IL_00e6;
		}
		goto IL_025b;
	}

	private void OnLogin(BaseEvent evt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0261: Expected O, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_036f: Expected O, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I
		//IL_0395: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E702C]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v52+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v52+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0137:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj7 = this + 32;
		if (dbId != (string)obj7)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			string dbId2 = SFSKammelnaUserExtensions.GetDbId(localUser2);
			_currentUser = dbId2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string feedsPath = FeedsPath;
			object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string directoryName = Path.GetDirectoryName(feedsPath);
			DirectoryInfo directoryInfo = Directory.CreateDirectory(directoryName);
			List<UserFeedItem> cachedFeeds = GetCachedFeeds();
			object obj13 = this + 40;
			obj13 = cachedFeeds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object extra = "Picking audio files is not supported on iOS" + 1864;
			int unreadCount = UnreadCount;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v28+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CounterBubbleManager.UpdateCounter(CounterBubbleType.Notifications, unreadCount, (string)extra);
			object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 416;
			object obj18 = (nint)0 + (nint)4056;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj18);
			KammelnaRequests.GetUserFeedItems(action);
		}
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	private void RequestFeeds()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 416;
		object obj2 = (nint)0 + (nint)4056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetUserFeedItems(action);
	}

	private void ProcessNewFeeds(List<UserFeedItem> newFeeds)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_033d: Expected O, but got I
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035d: Expected O, but got I
		//IL_036d: Expected O, but got I
		//IL_037d: Expected O, but got I
		//IL_039f: Expected O, but got I4
		//IL_00f2: Expected I, but got O
		//IL_0096: Expected O, but got I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03d7: Expected O, but got I
		//IL_03e8: Expected I, but got O
		//IL_0406: Expected O, but got I
		//IL_01cf: Expected O, but got I
		//IL_01df: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_0199: Expected O, but got I4
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0231: Expected O, but got I4
		//IL_029b: Expected O, but got I
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_044f: Expected O, but got I
		//IL_0460: Expected I, but got O
		//IL_047e: Expected O, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_026f: Expected O, but got I4
		//IL_0261: Expected O, but got I
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04d8: Expected O, but got I4
		object obj = (nint)0 + (nint)2400;
		if (!Enumerable.Any((IEnumerable<object>)newFeeds))
		{
			return;
		}
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		object obj5 = (nint)0 + (nint)1904;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj7 = (nint)0 + (nint)1864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v29+10]");
		Func<object, long> func = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v29+10]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v35+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)2264;
			Func<object, long> func2 = default(Func<object, long>);
			func2..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v34+B8]");
			object obj15 = (nint)0 + (nint)16;
			obj15 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = func2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAABC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj7);
		long lastReadFeedId = default(long);
		KammelnaRequests.DeleteReadFeedItems(lastReadFeedId, action);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v33+E4]");
		object obj17;
		Comparison<object> comparison;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v33+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v18+18]");
			comparison = (Comparison<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v18+18]");
			if ((nint)0 != 0)
			{
				goto IL_0176;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v33+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v18+18]");
			comparison = (Comparison<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v18+18]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 != null)
			{
				goto IL_0176;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v33+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v24+B8]");
			obj17 = 0;
		}
		object obj21 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)2272;
		Comparison<object> comparison2 = default(Comparison<object>);
		comparison2..ctor(obj17, (IntPtr)obj22);
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v23+B8]");
		object obj24 = (nint)0 + (nint)24;
		obj24 = comparison2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = 0;
		comparison = comparison2;
		goto IL_027c;
		IL_0176:
		bool flag6 = newFeeds == null;
		object obj26 = !flag6;
		obj25 = 0;
		if (obj26 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_027c;
		IL_027c:
		((List<object>)(object)newFeeds).Sort(comparison);
		object obj27 = (nint)0 + (nint)2896;
		((List<object>)(object)_feeds).AddRange((IEnumerable<object>)newFeeds);
		SaveFeedsToCache();
		object obj28 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object extra = "Picking audio files is not supported on iOS" + 1864;
		int unreadCount = UnreadCount;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj30 = !flag7;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Notifications, unreadCount, (string)extra);
		eventsChannel.TriggerFeedsReceived(newFeeds);
	}

	private void OnNewFeed(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UserFeedItem userFeedItem = default(UserFeedItem);
		userFeedItem..ctor(data);
		CreateLocalFeed(userFeedItem);
	}

	private void DismissFeed(UserFeedItem feed)
	{
		//IL_0011: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2904;
		bool flag = ((List<object>)(object)_feeds).Remove((object)feed);
		MarkDirty();
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.UserFeedsDismissed(feed.<Type>k__BackingField);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void MarkFeedSeen(UserFeedItem feed)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		feed.<IsSeen>k__BackingField = true;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object extra = "Picking audio files is not supported on iOS" + 1864;
		int unreadCount = UnreadCount;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Notifications, unreadCount, (string)extra);
		MarkDirty();
		ITrackEvent trackEvent = TrackerLibrary.UserFeedViewed(feed.<Type>k__BackingField);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void UpdateCounter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object extra = "Picking audio files is not supported on iOS" + 1864;
		int unreadCount = UnreadCount;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Notifications, unreadCount, (string)extra);
	}

	private bool IsUnread(UserFeedItem feed)
	{
		//IL_004c: Expected I4, but got O
		//IL_002b: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		if (feed != null)
		{
			object obj = ~(feed.<IsSeen>k__BackingField ? 1 : 0);
			return (byte)(1 & obj) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool IsValid(UserFeedItem feed)
	{
		//IL_0091: Expected I4, but got O
		//IL_0011: Expected O, but got I
		//IL_006b: Expected I, but got O
		if (feed != null)
		{
			object obj = (nint)0 + (nint)1560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70F1C");
			bool flag = default(bool);
			if (flag)
			{
				UserFeedData <Data>k__BackingField = feed.<Data>k__BackingField;
				if (feed.<Data>k__BackingField != null)
				{
					nint num = (nint)<Data>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v64 @ X8_v5 (Il2CppClass<Server.Models.UserFeedData>)+1C8] (should have been resolved before IL gen)");
				}
				return true;
			}
			return flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public UserFeedManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F32]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2264;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
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
			object obj4 = (nint)0 + (nint)2264;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	private void <MarkDirty>b__17_0()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004c: Expected O, but got I4
		if (_isDirty)
		{
			_isDirty = false;
			SaveFeedsToCache();
		}
		object obj = this + 64;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <RequestFeeds>b__20_0(KammelnaResponseModel<List<UserFeedItem>> response)
	{
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			List<UserFeedItem> <Model>k__BackingField = response.<Model>k__BackingField;
			if (response.<Model>k__BackingField != null && <Model>k__BackingField._size >= 1)
			{
				ProcessNewFeeds(response.<Model>k__BackingField);
			}
		}
	}
}
