using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class ClanFeedListView : UiListView<ClanFeedEventDataHolder, ClanEventStrip>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<ClanFeedEventDataHolder> <>9__3_0;

		public static Predicate<ClanFeedEventDataHolder> <>9__7_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SeedPinFromData>b__3_0(ClanFeedEventDataHolder d)
		{
			//IL_006c: Expected I4, but got O
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected I4, but got Unknown
			//IL_0059: Expected O, but got I4
			if (d != null)
			{
				ClanFeedModel clanFeedModel = d.<Model>k__BackingField;
				if (d.<Model>k__BackingField != null)
				{
					clanFeedModel = (ClanFeedModel)clanFeedModel.Pinned;
				}
				return (byte)(clanFeedModel & 1) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ApplyVaultSupportProgress>b__7_0(ClanFeedEventDataHolder d)
		{
			//IL_0118: Expected I4, but got O
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_0087: Expected I, but got O
			//IL_00b0: Expected O, but got I4
			//IL_00e1: Expected O, but got I
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			if (d != null)
			{
				ClanFeedModel <Model>k__BackingField = d.<Model>k__BackingField;
				if (d.<Model>k__BackingField != null)
				{
					ClanFeedData data = <Model>k__BackingField.Data;
					if (<Model>k__BackingField.Data != null)
					{
						object obj = typeof(UsageHint) + 712;
						object obj2 = obj;
						nint num = (nint)data;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+130]");
						bool flag = num2 < 0;
						object obj3 = !flag;
						if (obj3 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+130]");
							object obj4 = num3 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X9_v5-8]");
							object obj5 = 0 - obj2;
							return obj5 == null;
						}
					}
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public int roomId;

		internal bool <RemoveLiveRoomById>b__0(ClanFeedEventDataHolder d)
		{
			//IL_005b: Expected I4, but got O
			//IL_0039: Expected O, but got I4
			if (d != null)
			{
				int liveRoomId = d.LiveRoomId;
				object obj = liveRoomId - roomId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public long? feedId;

		internal unsafe bool <ApplyPinChangeById>b__0(ClanFeedEventDataHolder d)
		{
			//IL_0083: Expected I4, but got O
			//IL_0067: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected I4, but got Unknown
			//IL_0051: Expected O, but got I4
			if (d != null)
			{
				ClanFeedModel <Model>k__BackingField = d.<Model>k__BackingField;
				object obj;
				long? num2;
				if (d.<Model>k__BackingField != null)
				{
					long? num = <Model>k__BackingField.Id;
					obj = 0;
					num2 = num;
				}
				else
				{
					obj = 0;
					num2 = (long?)(object)0;
				}
				long? num3 = (long?)(object)(this + 16);
				long value = ((long?*)num3)->Value;
				object obj2 = obj - value;
				bool flag = obj2 == null;
				return (byte)(((??)num2 & flag) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public ClanFeedListView <>4__this;

		public ClanFeedEventDataHolder datum;

		internal void <DeleteFeed>b__0(bool success)
		{
			if (success)
			{
				((UiListView<object, object>)(object)<>4__this).RemoveItem((object)datum, (Action)null);
			}
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public ClanFeedListView <>4__this;

		public ClanFeedEventDataHolder datum;

		internal void <ServerTogglePin>b__0(bool success)
		{
			if (success)
			{
				((UiListView<object, object>)(object)<>4__this).ClearPinned();
			}
		}

		internal void <ServerTogglePin>b__1(bool success)
		{
			if (success)
			{
				((UiListView<object, object>)(object)<>4__this).SetPinned((object)datum);
			}
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public int index;

		public ClanFeedListView <>4__this;

		public Action <>9__2;

		internal bool <OnPinnedHeaderClicked>b__0(ClanFeedEventDataHolder d)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (d != null)
			{
				object obj = d.<index>k__BackingField - index;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <OnPinnedHeaderClicked>b__1()
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_010e: Expected O, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			//IL_014e: Expected O, but got I
			//IL_015c: Expected I, but got O
			//IL_019f: Expected O, but got I4
			object obj = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8786]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			Action action;
			object obj5;
			if (obj2 != null)
			{
				obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj4 = this + 32;
				action = (Action)obj4;
				bool flag = obj4 == null;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj4 = this + 32;
				action = (Action)obj4;
				bool flag2 = obj4 == null;
				object obj6 = !flag2;
				obj5 = obj3;
				if (obj6 != null)
				{
					goto IL_0088;
				}
			}
			object obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)3600;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj8);
			<>9__2 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v1+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			action = action2;
			Action callback = action2;
			if (obj10 != null)
			{
				goto IL_00bd;
			}
			goto IL_01bd;
			IL_00bd:
			CoroutineDummy.WaitForEndOfFrame(action);
			return;
			IL_01bd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForEndOfFrame(callback);
			return;
			IL_0088:
			obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v1+E4]");
			bool flag4 = (nint)0 == 0;
			callback = action;
			if (!flag4)
			{
				goto IL_00bd;
			}
			goto IL_01bd;
		}

		internal void <OnPinnedHeaderClicked>b__2()
		{
			<>4__this.NudgeIndex(index);
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public int index;

		internal bool <MorphsInPlaceIndex>b__0(ClanFeedEventDataHolder d)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (d != null)
			{
				object obj = d.<index>k__BackingField - index;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public ClanFeedEventDataHolder datum;

		internal bool <AddFeed>b__0(ClanFeedEventDataHolder d)
		{
			//IL_0087: Expected I4, but got O
			//IL_0065: Expected O, but got I4
			if (d != null)
			{
				int liveRoomId = d.LiveRoomId;
				if (datum != null)
				{
					int liveRoomId2 = datum.LiveRoomId;
					object obj = liveRoomId - liveRoomId2;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <AddFeed>b__1(ClanFeedEventDataHolder d)
		{
			//IL_0136: Expected I4, but got O
			//IL_00b8: Expected O, but got I4
			//IL_004a: Expected I8, but got I
			//IL_0070: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected I4, but got Unknown
			long? num;
			ClanFeedEventDataHolder clanFeedEventDataHolder;
			object obj2;
			if (d != null)
			{
				num = (long?)d.<Model>k__BackingField;
				if (d.<Model>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5 (System.Nullable`1<System.Int64>)+10]");
					long? num2 = 0L;
					clanFeedEventDataHolder = datum;
					bool flag = datum == null;
					object obj = !flag;
					obj2 = 0;
					num = num2;
					if (obj != null)
					{
						goto IL_00c6;
					}
				}
				else
				{
					clanFeedEventDataHolder = datum;
					bool flag2 = datum == null;
					obj2 = 0;
					if (!flag2)
					{
						goto IL_00c6;
					}
				}
			}
			goto IL_0128;
			IL_00c6:
			ClanFeedModel <Model>k__BackingField = clanFeedEventDataHolder.<Model>k__BackingField;
			if (clanFeedEventDataHolder.<Model>k__BackingField != null)
			{
				object obj3 = obj2 - <Model>k__BackingField.Id;
				bool flag3 = obj3 == null;
				return (byte)(((??)num & flag3) ? 1 : 0) != 0;
			}
			goto IL_0128;
			IL_0128:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public ClanFeedEventDataHolder h;

		internal bool <ReconcileServerFeed>b__0(ClanFeedEventDataHolder d)
		{
			//IL_0136: Expected I4, but got O
			//IL_00b8: Expected O, but got I4
			//IL_004a: Expected I8, but got I
			//IL_0070: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected I4, but got Unknown
			long? num;
			ClanFeedEventDataHolder clanFeedEventDataHolder;
			object obj2;
			if (d != null)
			{
				num = (long?)d.<Model>k__BackingField;
				if (d.<Model>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5 (System.Nullable`1<System.Int64>)+10]");
					long? num2 = 0L;
					clanFeedEventDataHolder = h;
					bool flag = h == null;
					object obj = !flag;
					obj2 = 0;
					num = num2;
					if (obj != null)
					{
						goto IL_00c6;
					}
				}
				else
				{
					clanFeedEventDataHolder = h;
					bool flag2 = h == null;
					obj2 = 0;
					if (!flag2)
					{
						goto IL_00c6;
					}
				}
			}
			goto IL_0128;
			IL_00c6:
			ClanFeedModel <Model>k__BackingField = clanFeedEventDataHolder.<Model>k__BackingField;
			if (clanFeedEventDataHolder.<Model>k__BackingField != null)
			{
				object obj3 = obj2 - <Model>k__BackingField.Id;
				bool flag3 = obj3 == null;
				return (byte)(((??)num & flag3) ? 1 : 0) != 0;
			}
			goto IL_0128;
			IL_0128:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public long feedId;

		internal bool <RemoveFeedById>b__0(ClanFeedEventDataHolder d)
		{
			//IL_0088: Expected I4, but got O
			//IL_0060: Expected O, but got I8
			if (d != null)
			{
				ClanFeedModel <Model>k__BackingField = d.<Model>k__BackingField;
				if (d.<Model>k__BackingField != null)
				{
					object obj = <Model>k__BackingField.Id - feedId;
					return obj == null;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public int roomId;

		internal bool <HasLiveRoom>b__0(ClanFeedEventDataHolder d)
		{
			//IL_005b: Expected I4, but got O
			//IL_0039: Expected O, but got I4
			if (d != null)
			{
				int liveRoomId = d.LiveRoomId;
				object obj = liveRoomId - roomId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private ClanEventStrip _pinnedHeaderClone;

	private readonly Dictionary<string, ClanEventStrip> _stripByTemplate;

	private float _loadOlderPrefetchDistance;

	private RectTransform _loadingOlderFooter;

	private float _footerGap;

	private Action<long> m_OnLoadOlderRequested;

	private const float OlderFetchRetryCooldown = 3f;

	private bool _loadingOlder;

	private bool _reachedFeedEnd;

	private float _olderRetryNotBefore;

	protected override float trailingExtent
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011d: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00be: Expected F4, but got I4
			//IL_00c7: Expected F4, but got I4
			//IL_00d0: Expected O, but got I4
			//IL_0166: Expected F4, but got I4
			//IL_016f: Expected F4, but got I4
			//IL_0178: Expected O, but got I4
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
			//IL_0215: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E877A]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object loadingOlderFooter;
			UnityEngine.Object loadingOlderFooter2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				loadingOlderFooter = _loadingOlderFooter;
				loadingOlderFooter2 = _loadingOlderFooter;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				loadingOlderFooter = _loadingOlderFooter;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				loadingOlderFooter2 = _loadingOlderFooter;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = loadingOlderFooter2 != null;
			bool flag4 = !flag3;
			float result = 0f;
			float num = 0f;
			object obj6 = 0;
			if (flag4)
			{
				goto IL_00de;
			}
			goto IL_0186;
			IL_00de:
			return result;
			IL_0186:
			GameObject gameObject = _loadingOlderFooter.gameObject;
			bool activeSelf = gameObject.activeSelf;
			bool flag5 = !activeSelf;
			result = num;
			if (!flag5)
			{
				Rect rect = _loadingOlderFooter.rect;
				object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj10 = default(object);
				return _footerGap + (float)obj10;
			}
			goto IL_00de;
			IL_0091:
			bool flag7 = loadingOlderFooter != null;
			bool flag8 = !flag7;
			object obj11 = !flag8;
			result = 0f;
			num = 0f;
			obj6 = 0;
			if (obj11 == null)
			{
				goto IL_00de;
			}
			goto IL_0186;
		}
	}

	private float DistanceFromBottom
	{
		get
		{
			float num = base.listHeight;
			object obj = default(object);
			float num2 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+20]");
			return num2 + 0f;
		}
	}

	public event Action<long> OnLoadOlderRequested
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
			Delegate obj2 = this.m_OnLoadOlderRequested;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
			Delegate obj2 = this.m_OnLoadOlderRequested;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
	}

	protected override void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_00b8: Expected I, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0077: Expected I, but got O
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		object obj = (nint)0 + (nint)464;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1456;
		object obj3 = (nint)0 + (nint)1000;
		object obj4 = (nint)0 + (nint)1016;
		Awake();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj5 = this + 216;
		obj5 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj6 = this + 224;
		obj6 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SeedPinFromData()
	{
		//IL_01d8: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0057: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0229: Expected O, but got I
		//IL_023a: Expected I, but got O
		//IL_0258: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_018d: Expected O, but got I
		nint num = (nint)this;
		List<object> list = (List<object>)(object)base.data;
		Predicate<object> match;
		object obj11;
		if (list != null)
		{
			object obj = typeof(CardUtils.<>c) + 632;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+E4]");
			object obj3;
			List<object> list2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v5+8]");
				match = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v5+8]");
				bool flag = (nint)0 == 0;
				list2 = list;
				if (!flag)
				{
					goto IL_0095;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v5+8]");
				match = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v5+8]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				list2 = list;
				if (obj4 != null)
				{
					goto IL_0095;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v15+B8]");
				obj3 = 0;
			}
			object obj7 = typeof(List<Tween>) + 3152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)3536;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj3, (IntPtr)obj8);
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v14+B8]");
			object obj10 = (nint)0 + (nint)8;
			obj10 = predicate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj11 = list2.Find(predicate);
			bool flag4 = obj11 == null;
			object obj12 = !flag4;
			if (obj12 != null)
			{
				goto IL_00c3;
			}
		}
		goto IL_01cb;
		IL_00c3:
		((UiListView<object, object>)(object)this).SetPinned(obj11);
		return;
		IL_0095:
		obj11 = list.Find(match);
		if (obj11 != null)
		{
			goto IL_00c3;
		}
		goto IL_01cb;
		IL_01cb:
		((UiListView<object, object>)(object)this).ClearPinned();
	}

	public bool ShouldDisplay(ClanFeedEventDataHolder datum)
	{
		//IL_0024: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		bool flag3;
		if (datum != null)
		{
			bool flag = datum.<Model>k__BackingField == null;
			object obj = !flag;
			if (obj == null)
			{
				bool isLiveTournament = datum.IsLiveTournament;
				bool flag2 = !isLiveTournament;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					flag3 = datum.IsLiveGame;
					if (!flag3)
					{
						goto IL_0108;
					}
				}
			}
			if (((UiListView<object, object>)(object)this).TemplatesReady)
			{
				string template = datum.template;
				return IsTemplateRegistered(template);
			}
			return true;
		}
		flag3 = false;
		goto IL_0108;
		IL_0108:
		return flag3;
	}

	public void AddFeed(ClanFeedEventDataHolder datum)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_0123: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_0185: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0229: Expected O, but got I4
		//IL_01b0: Expected O, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_01eb: Expected I, but got O
		//IL_0264: Expected O, but got I
		//IL_0288: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = datum;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj3 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		if ((nint)0 == 0 || !ShouldDisplay((ClanFeedEventDataHolder)obj3))
		{
			return;
		}
		bool isLiveTournament = ((ClanFeedEventDataHolder)obj3).IsLiveTournament;
		bool flag = !isLiveTournament;
		object obj4 = !flag;
		object obj5 = 0;
		List<object> list;
		Predicate<object> match;
		if (obj4 == null)
		{
			bool isLiveGame = ((ClanFeedEventDataHolder)obj3).IsLiveGame;
			bool flag2 = !isLiveGame;
			obj5 = 0;
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
				list = (List<object>)0;
				object obj6 = typeof(List<Tween>) + 3152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)3624;
				Predicate<object> predicate = default(Predicate<object>);
				predicate..ctor(obj2, (IntPtr)obj7);
				match = predicate;
				goto IL_01fd;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		list = (List<object>)0;
		object obj8 = typeof(List<Tween>) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)3616;
		Predicate<object> predicate2 = default(Predicate<object>);
		predicate2..ctor(obj2, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		match = predicate2;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01fd;
		IL_01fd:
		bool flag4 = list.Exists(match);
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			return;
		}
		int index = SortedInsertIndex((ClanFeedEventDataHolder)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		((List<object>)0).Insert(index, obj3);
		base.StartSettling();
		object pinned = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X1_v12 (System.Object)+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X1_v12 (System.Object)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v12+38]");
			if ((nint)0 == 1)
			{
				((UiListView<object, object>)(object)this).SetPinned(pinned);
			}
		}
	}

	public unsafe void ReconcileServerFeed(IReadOnlyList<ClanFeedEventDataHolder> incoming)
	{
		//IL_22fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2301: Expected O, but got Unknown
		//IL_2310: Unknown result type (might be due to invalid IL or missing references)
		//IL_2315: Expected O, but got Unknown
		//IL_2324: Unknown result type (might be due to invalid IL or missing references)
		//IL_2329: Expected O, but got Unknown
		//IL_2338: Unknown result type (might be due to invalid IL or missing references)
		//IL_233d: Expected O, but got Unknown
		//IL_2349: Expected O, but got I
		//IL_2355: Expected O, but got I
		//IL_01cb: Expected I8, but got O
		//IL_01f2: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0037: Expected I8, but got O
		//IL_005e: Expected O, but got I4
		//IL_0210: Expected I, but got O
		//IL_0220: Expected O, but got I
		//IL_0348: Expected I, but got O
		//IL_007c: Expected I, but got O
		//IL_008c: Expected O, but got I
		//IL_2570: Expected I8, but got I
		//IL_01b4: Expected I, but got O
		//IL_20f4: Expected O, but got I4
		//IL_24b1: Expected O, but got I
		//IL_24d2: Expected O, but got I4
		//IL_24e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e7: Expected O, but got Unknown
		//IL_251c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2521: Expected I8, but got Unknown
		//IL_2531: Unknown result type (might be due to invalid IL or missing references)
		//IL_2536: Expected I8, but got Unknown
		//IL_2455: Expected O, but got I
		//IL_2461: Expected O, but got I
		//IL_246d: Expected O, but got I
		//IL_247d: Expected I8, but got I
		//IL_249c: Expected O, but got I8
		//IL_17e8: Expected I4, but got I8
		//IL_17f0: Expected I4, but got I8
		//IL_17f8: Expected I4, but got I8
		//IL_179b: Expected O, but got I4
		//IL_17ad: Expected O, but got I
		//IL_17b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bb: Expected O, but got Unknown
		//IL_239a: Expected O, but got I
		//IL_23bb: Expected O, but got I4
		//IL_23cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d0: Expected O, but got Unknown
		//IL_2405: Unknown result type (might be due to invalid IL or missing references)
		//IL_240a: Expected I8, but got Unknown
		//IL_241a: Unknown result type (might be due to invalid IL or missing references)
		//IL_241f: Expected I8, but got Unknown
		//IL_2f66: Expected O, but got I4
		//IL_2f74: Expected O, but got I8
		//IL_2fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fad: Expected I8, but got Unknown
		//IL_18b4: Expected I, but got O
		//IL_18c4: Expected O, but got I
		//IL_028c: Expected O, but got I
		//IL_02a6: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected I8, but got Unknown
		//IL_02ed: Expected I8, but got O
		//IL_1ec8: Expected O, but got I4
		//IL_035a: Expected O, but got I4
		//IL_036c: Expected O, but got I
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_19ec: Expected I, but got O
		//IL_0397: Expected I, but got O
		//IL_03a7: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_0112: Expected O, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected I8, but got Unknown
		//IL_0159: Expected I8, but got O
		//IL_2d6e: Expected I, but got O
		//IL_2d7e: Expected I8, but got I
		//IL_2d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d96: Expected O, but got Unknown
		//IL_04cf: Expected I, but got O
		//IL_2cb7: Expected O, but got I
		//IL_2cd8: Expected O, but got I4
		//IL_2ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ced: Expected O, but got Unknown
		//IL_2d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d27: Expected I4, but got Unknown
		//IL_2d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3c: Expected I4, but got Unknown
		//IL_2666: Expected I, but got O
		//IL_2676: Expected I8, but got I
		//IL_2689: Unknown result type (might be due to invalid IL or missing references)
		//IL_268e: Expected O, but got Unknown
		//IL_2eca: Expected O, but got I4
		//IL_19fe: Expected O, but got I4
		//IL_1a10: Expected O, but got I
		//IL_1a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1e: Expected O, but got Unknown
		//IL_0896: Expected O, but got I4
		//IL_25af: Expected O, but got I
		//IL_25d0: Expected O, but got I4
		//IL_25e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e5: Expected O, but got Unknown
		//IL_261a: Unknown result type (might be due to invalid IL or missing references)
		//IL_261f: Expected I8, but got Unknown
		//IL_262f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2634: Expected I8, but got Unknown
		//IL_27e5: Expected O, but got I4
		//IL_1d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da1: Expected O, but got Unknown
		//IL_1da9: Expected I, but got O
		//IL_1db9: Expected O, but got I
		//IL_2122: Expected O, but got I4
		//IL_1930: Expected O, but got I
		//IL_194a: Expected O, but got I4
		//IL_1953: Unknown result type (might be due to invalid IL or missing references)
		//IL_1958: Expected O, but got Unknown
		//IL_197f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1984: Expected I4, but got Unknown
		//IL_1991: Expected I4, but got O
		//IL_04e1: Expected O, but got I4
		//IL_04f3: Expected O, but got I
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_08c9: Expected I, but got O
		//IL_08d9: Expected O, but got I
		//IL_1e54: Expected I, but got O
		//IL_1a58: Expected I, but got O
		//IL_1a68: Expected O, but got I
		//IL_1f3e: Expected O, but got I4
		//IL_0413: Expected O, but got I
		//IL_042d: Expected O, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected I8, but got Unknown
		//IL_0474: Expected I8, but got O
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected O, but got Unknown
		//IL_0a7a: Expected I8, but got I
		//IL_0a01: Expected I, but got O
		//IL_2f2d: Expected I, but got O
		//IL_2f3d: Expected I8, but got I
		//IL_1b90: Expected I, but got O
		//IL_053b: Expected I, but got O
		//IL_054b: Expected O, but got I
		//IL_28ba: Expected I, but got O
		//IL_28ca: Expected I8, but got I
		//IL_2f01: Expected O, but got I
		//IL_2e7a: Expected I, but got O
		//IL_0673: Expected I, but got O
		//IL_2803: Expected O, but got I
		//IL_2824: Expected O, but got I4
		//IL_2834: Unknown result type (might be due to invalid IL or missing references)
		//IL_2839: Expected O, but got Unknown
		//IL_286e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2873: Expected I8, but got Unknown
		//IL_2883: Unknown result type (might be due to invalid IL or missing references)
		//IL_2888: Expected I8, but got Unknown
		//IL_1e66: Expected O, but got I4
		//IL_1e78: Expected O, but got I
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e86: Expected O, but got Unknown
		//IL_1896: Expected I8, but got O
		//IL_2dc3: Expected O, but got I
		//IL_2de4: Expected O, but got I4
		//IL_2df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df9: Expected O, but got Unknown
		//IL_2e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e33: Expected I4, but got Unknown
		//IL_2e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e48: Expected I4, but got Unknown
		//IL_2772: Expected I, but got O
		//IL_2782: Expected I8, but got I
		//IL_0abe: Expected O, but got I
		//IL_0a13: Expected O, but got I4
		//IL_0a25: Expected O, but got I
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_1e1d: Expected O, but got I
		//IL_1ba2: Expected O, but got I4
		//IL_1bb4: Expected O, but got I
		//IL_1bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc2: Expected O, but got Unknown
		//IL_1f6c: Expected O, but got I4
		//IL_26bb: Expected O, but got I
		//IL_26dc: Expected O, but got I4
		//IL_26ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f1: Expected O, but got Unknown
		//IL_2726: Unknown result type (might be due to invalid IL or missing references)
		//IL_272b: Expected I8, but got Unknown
		//IL_273b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2740: Expected I8, but got Unknown
		//IL_0b21: Expected I8, but got O
		//IL_0945: Expected O, but got I
		//IL_095f: Expected O, but got I4
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected I8, but got Unknown
		//IL_09a6: Expected I8, but got O
		//IL_2168: Expected O, but got I4
		//IL_218d: Expected I8, but got O
		//IL_1ad4: Expected O, but got I
		//IL_1aee: Expected O, but got I4
		//IL_1af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afc: Expected O, but got Unknown
		//IL_1b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b28: Expected I4, but got Unknown
		//IL_1b35: Expected I4, but got O
		//IL_0685: Expected O, but got I4
		//IL_0697: Expected O, but got I
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_0e92: Expected O, but got I
		//IL_0e9a: Expected I8, but got O
		//IL_1bfc: Expected I, but got O
		//IL_05b7: Expected O, but got I
		//IL_05d1: Expected O, but got I4
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected I8, but got Unknown
		//IL_0618: Expected I8, but got O
		//IL_0711: Expected O, but got I4
		//IL_1c62: Expected O, but got I4
		//IL_1c82: Expected O, but got I4
		//IL_1c96: Expected O, but got I4
		//IL_1cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cda: Expected I4, but got Unknown
		//IL_181d: Expected O, but got I
		//IL_073c: Expected I8, but got I
		//IL_0744: Expected I, but got O
		//IL_0759: Expected I8, but got I
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected O, but got Unknown
		//IL_0f2a: Expected I, but got O
		//IL_0f3a: Expected O, but got I
		//IL_1d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3b: Expected O, but got Unknown
		//IL_1d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d49: Expected O, but got Unknown
		//IL_228d: Expected O, but got I4
		//IL_1062: Expected I, but got O
		//IL_0f00: Expected I, but got O
		//IL_0bb5: Expected I8, but got I
		//IL_0bd6: Expected O, but got I4
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected O, but got Unknown
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected I8, but got Unknown
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected I8, but got Unknown
		//IL_07c3: Expected O, but got I4
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected I8, but got Unknown
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected I8, but got Unknown
		//IL_0860: Expected O, but got I4
		//IL_29d2: Expected I8, but got I
		//IL_2913: Expected O, but got I
		//IL_2934: Expected O, but got I4
		//IL_2944: Unknown result type (might be due to invalid IL or missing references)
		//IL_2949: Expected O, but got Unknown
		//IL_297e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2983: Expected I8, but got Unknown
		//IL_2993: Unknown result type (might be due to invalid IL or missing references)
		//IL_2998: Expected I8, but got Unknown
		//IL_087e: Expected O, but got I
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Expected O, but got Unknown
		//IL_10dd: Expected O, but got I
		//IL_10e9: Expected O, but got I
		//IL_1074: Expected O, but got I4
		//IL_1086: Expected O, but got I
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1094: Expected O, but got Unknown
		//IL_119b: Expected I, but got O
		//IL_11ab: Expected O, but got I
		//IL_0fa6: Expected O, but got I
		//IL_0fc0: Expected O, but got I4
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Expected O, but got Unknown
		//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Expected I8, but got Unknown
		//IL_1007: Expected I8, but got O
		//IL_0cc1: Expected I8, but got I
		//IL_0cdf: Expected O, but got I4
		//IL_12d3: Expected I, but got O
		//IL_2ad0: Expected I, but got O
		//IL_2ae0: Expected I8, but got I
		//IL_2af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af8: Expected O, but got Unknown
		//IL_2a19: Expected O, but got I
		//IL_2a3a: Expected O, but got I4
		//IL_2a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4f: Expected O, but got Unknown
		//IL_2a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a89: Expected I8, but got Unknown
		//IL_2a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9e: Expected I8, but got Unknown
		//IL_12e5: Expected O, but got I4
		//IL_12f7: Expected O, but got I
		//IL_1300: Unknown result type (might be due to invalid IL or missing references)
		//IL_1305: Expected O, but got Unknown
		//IL_0d1a: Expected I, but got O
		//IL_1682: Unknown result type (might be due to invalid IL or missing references)
		//IL_1687: Expected O, but got Unknown
		//IL_168f: Expected I, but got O
		//IL_169f: Expected O, but got I
		//IL_1217: Expected O, but got I
		//IL_1231: Expected O, but got I4
		//IL_123a: Unknown result type (might be due to invalid IL or missing references)
		//IL_123f: Expected O, but got Unknown
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_126b: Expected I8, but got Unknown
		//IL_1278: Expected I8, but got O
		//IL_173a: Expected I, but got O
		//IL_2076: Expected I8, but got I4
		//IL_0d80: Expected O, but got I4
		//IL_0da0: Expected O, but got I4
		//IL_0db4: Expected O, but got I4
		//IL_0de6: Expected I8, but got I4
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected I8, but got Unknown
		//IL_2c87: Expected I, but got O
		//IL_2c97: Expected I8, but got I
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Expected O, but got Unknown
		//IL_136b: Expected I, but got O
		//IL_137b: Expected O, but got I
		//IL_0adf: Expected O, but got I
		//IL_2c5b: Expected O, but got I
		//IL_14a3: Expected I, but got O
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected O, but got Unknown
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e67: Expected O, but got Unknown
		//IL_174c: Expected O, but got I4
		//IL_175e: Expected O, but got I
		//IL_1767: Unknown result type (might be due to invalid IL or missing references)
		//IL_176c: Expected O, but got Unknown
		//IL_2bdc: Expected I, but got O
		//IL_1703: Expected O, but got I
		//IL_2b25: Expected O, but got I
		//IL_2b46: Expected O, but got I4
		//IL_2b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5b: Expected O, but got Unknown
		//IL_2b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b95: Expected I8, but got Unknown
		//IL_2ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2baa: Expected I8, but got Unknown
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f8: Expected O, but got Unknown
		//IL_1500: Expected O, but got I8
		//IL_1512: Expected I, but got O
		//IL_14b5: Expected O, but got I4
		//IL_14c7: Expected O, but got I
		//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d5: Expected O, but got Unknown
		//IL_13e7: Expected O, but got I
		//IL_1401: Expected O, but got I4
		//IL_140a: Unknown result type (might be due to invalid IL or missing references)
		//IL_140f: Expected O, but got Unknown
		//IL_1436: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Expected I8, but got Unknown
		//IL_1448: Expected I8, but got O
		//IL_1587: Expected I, but got O
		//IL_209d: Expected O, but got I4
		//IL_20c3: Expected I, but got O
		//IL_20d3: Expected I8, but got O
		//IL_15b9: Expected I, but got O
		//IL_15ce: Expected O, but got I
		//IL_1129: Expected O, but got I4
		//IL_1131: Expected I8, but got O
		//IL_1141: Expected O, but got I
		//IL_21b4: Expected O, but got I4
		//IL_21da: Expected I, but got O
		//IL_21ea: Expected I8, but got O
		//IL_162f: Expected O, but got I4
		//IL_1634: Expected I, but got O
		//IL_1641: Expected I8, but got O
		//IL_1651: Expected O, but got I
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3048;
		object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 424;
		object[] array = (object[])(typeof(List<AdaptivePerformanceScaler>) + 528);
		IReadOnlyList<ClanFeedEventDataHolder> readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)((nint)0 + (nint)3248);
		object obj4 = (nint)0 + (nint)3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		HashSet<long> hashSet = default(HashSet<long>);
		List<object>.Enumerator enumerator;
		bool flag3 = default(bool);
		List<object> list = default(List<object>);
		long num2;
		object obj5 = default(object);
		int num8 = default(int);
		HashSet<long> hashSet2;
		object obj6;
		object obj7;
		bool flag5;
		bool flag6;
		long num5 = default(long);
		long num6 = default(long);
		long num7 = default(long);
		bool flag7;
		if ((nint)0 != 0)
		{
			num = (nint)(typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1536);
			readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)((nint)0 + (nint)480);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num2 = (long)readOnlyList;
			hashSet..ctor();
			bool flag = incoming == null;
			enumerator = (List<object>.Enumerator)0;
			hashSet2 = hashSet;
			if (!flag)
			{
				nint num3 = (nint)incoming;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v96 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v96 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01a5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v96 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+B0]");
				int num4 = (int)((nint)0 + (nint)8);
				bool flag2 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v90 (System.Int32)-8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v90 (System.Int32)-8]");
					bool flag4 = 0 < (nint)obj;
					obj6 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v90 (System.Int32)-8]");
					obj7 = 0 - obj;
					flag5 = (nint)obj7 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v90 (System.Int32)-8]");
					flag6 = 0 == (nint)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v90 (System.Int32)-8]");
					num5 = 0 ^ obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v90 (System.Int32)-8]");
					num6 = 0 ^ obj7;
					num7 = num5 & num6;
					flag7 = num7 < 0;
					if (flag6)
					{
						break;
					}
					num8 = num4 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v96 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
					array = (object[])(-1);
					bool flag8 = (nint)array < 1;
					obj6 = !flag8;
					obj7 = array - 1;
					flag5 = (nint)obj7 < 0;
					flag6 = obj7 == null;
					num5 = array ^ 1;
					num6 = (object)array ^ obj7;
					num7 = num5 & num6;
					flag7 = num7 < 0;
					flag3 = (nint)array != 1;
					flag2 = flag3;
					num4 = num8;
					if (flag3)
					{
						continue;
					}
					goto IL_01a5;
				}
				array = (object[])((int*)num4)->m_value;
				object obj8 = num3 + ((int*)num4)->m_value;
				object obj9 = obj8 + 312;
				flag3 = flag2;
				num8 = num4;
				goto IL_2449;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num2 = (long)readOnlyList;
			list..ctor();
			bool flag9 = incoming == null;
			enumerator = (List<object>.Enumerator)0;
			hashSet2 = (HashSet<long>)(object)list;
			if (!flag9)
			{
				nint num9 = (nint)incoming;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0339;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+B0]");
				int num10 = (int)((nint)0 + (nint)8);
				bool flag10 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v71 (System.Int32)-8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v71 (System.Int32)-8]");
					bool flag11 = 0 < (nint)obj;
					obj6 = !flag11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v71 (System.Int32)-8]");
					obj7 = 0 - obj;
					flag5 = (nint)obj7 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v71 (System.Int32)-8]");
					flag6 = 0 == (nint)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v71 (System.Int32)-8]");
					num5 = 0 ^ obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v71 (System.Int32)-8]");
					num6 = 0 ^ obj7;
					num7 = num5 & num6;
					flag7 = num7 < 0;
					if (flag6)
					{
						break;
					}
					num8 = num10 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
					array = (object[])(-1);
					bool flag12 = (nint)array < 1;
					obj6 = !flag12;
					obj7 = array - 1;
					flag5 = (nint)obj7 < 0;
					flag6 = obj7 == null;
					num5 = array ^ 1;
					num6 = (object)array ^ obj7;
					num7 = num5 & num6;
					flag7 = num7 < 0;
					flag3 = (nint)array != 1;
					flag10 = flag3;
					num10 = num8;
					if (flag3)
					{
						continue;
					}
					goto IL_0339;
				}
				array = (object[])((int*)num10)->m_value;
				object obj10 = num9 + ((int*)num10)->m_value;
				object obj11 = obj10 + 312;
				flag3 = flag10;
				num8 = num10;
				goto IL_2560;
			}
		}
		goto IL_223f;
		IL_1f7e:
		NullReferenceException ex = new NullReferenceException();
		object obj13;
		object obj12 = obj13;
		object obj14;
		obj5 = obj14;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		enumerator = enumerator2;
		List<object>.Enumerator enumerator3 = enumerator2;
		object obj15 = null;
		nint num12;
		nint num11 = num12;
		int num13;
		num8 = num13;
		long num14 = default(long);
		num2 = num14;
		HashSet<long> hashSet3 = default(HashSet<long>);
		hashSet2 = hashSet3;
		object obj16 = default(object);
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)obj16;
		goto IL_2f4c;
		IL_2271:
		ex = new NullReferenceException();
		IReadOnlyList<ClanFeedEventDataHolder> readOnlyList2 = incoming;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		hashSet2 = hashSet;
		goto IL_2f4c;
		IL_29c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1662 @ X0_v18+8]");
		num2 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1662 @ X0_v18] (should have been resolved before IL gen)");
		IReadOnlyList<ClanFeedEventDataHolder> readOnlyList3 = default(IReadOnlyList<ClanFeedEventDataHolder>);
		bool flag13 = readOnlyList3 == null;
		num = (nint)(&hashSet3);
		readOnlyList = readOnlyList2;
		if (flag13)
		{
			goto IL_1eda;
		}
		obj4 = typeof(CardUtils.<>c) + 696;
		object obj17 = typeof(List<Tween>) + 3152;
		object obj18 = (nint)0 + (nint)3632;
		object obj19 = (nint)0 + (nint)3272;
		obj13 = obj12;
		obj14 = obj5;
		num12 = num11;
		num13 = num8;
		IReadOnlyList<ClanFeedEventDataHolder> readOnlyList4 = readOnlyList3;
		object obj21 = default(object);
		object obj23 = default(object);
		object obj26 = default(object);
		Predicate<object> predicate = default(Predicate<object>);
		object obj28;
		while (true)
		{
			nint num15 = (nint)readOnlyList4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X8_v25 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X8_v25 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_12c4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X8_v25 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+B0]");
			int num16 = (int)((nint)0 + (nint)8);
			bool flag14 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X10_v24 (System.Int32)-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X10_v24 (System.Int32)-8]");
				bool flag15 = 0 < (nint)obj2;
				obj6 = !flag15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X10_v24 (System.Int32)-8]");
				obj7 = 0 - obj2;
				flag5 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X10_v24 (System.Int32)-8]");
				flag6 = 0 == (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X10_v24 (System.Int32)-8]");
				num5 = 0 ^ obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1747 @ X10_v24 (System.Int32)-8]");
				num6 = 0 ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				if (flag6)
				{
					break;
				}
				num13 = num16 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X8_v25 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
				array = (object[])(-1);
				bool flag16 = (nint)array < 1;
				obj6 = !flag16;
				obj7 = array - 1;
				flag5 = (nint)obj7 < 0;
				flag6 = obj7 == null;
				num5 = array ^ 1;
				num6 = (object)array ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				flag3 = (nint)array != 1;
				flag14 = flag3;
				num16 = num13;
				if (flag3)
				{
					continue;
				}
				goto IL_12c4;
			}
			array = (object[])((int*)num16)->m_value;
			object obj20 = num15 + ((int*)num16)->m_value;
			obj21 = obj20 + 312;
			flag3 = flag14;
			num13 = num16;
			goto IL_2ac8;
			IL_2ac8:
			num = (nint)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1762 @ X0_v24+8]");
			num2 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1762 @ X0_v24] (should have been resolved before IL gen)");
			object obj22 = obj23 & 1;
			if (obj22 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj16..ctor();
			if (hashSet3 == null)
			{
				goto IL_202e;
			}
			object obj24 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 424;
			nint num17 = (nint)hashSet3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v37 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v37 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1494;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v37 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+B0]");
			int num18 = (int)((nint)0 + (nint)8);
			bool flag17 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ X10_v19 (System.Int32)-8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ X10_v19 (System.Int32)-8]");
				bool flag18 = 0 < (nint)obj24;
				obj6 = !flag18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ X10_v19 (System.Int32)-8]");
				obj7 = 0 - obj24;
				flag5 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ X10_v19 (System.Int32)-8]");
				flag6 = 0 == (nint)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ X10_v19 (System.Int32)-8]");
				num5 = 0 ^ obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ X10_v19 (System.Int32)-8]");
				num6 = 0 ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				if (flag6)
				{
					break;
				}
				num13 = num18 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1829 @ X8_v37 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
				array = (object[])(-1);
				bool flag19 = (nint)array < 1;
				obj6 = !flag19;
				obj7 = array - 1;
				flag5 = (nint)obj7 < 0;
				flag6 = obj7 == null;
				num5 = array ^ 1;
				num6 = (object)array ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				flag3 = (nint)array != 1;
				flag17 = flag3;
				num18 = num13;
				if (flag3)
				{
					continue;
				}
				goto IL_1494;
			}
			array = (object[])((int*)num18)->m_value;
			object obj25 = num17 + ((int*)num18)->m_value;
			obj26 = obj25 + 312;
			flag3 = flag17;
			num13 = num18;
			goto IL_2bd4;
			IL_2bd4:
			num = (nint)obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1915 @ X0_v38] (should have been resolved before IL gen)");
			if (obj16 == null)
			{
				goto IL_1f7e;
			}
			hashSet2 = (HashSet<long>)(obj16 + 16);
			hashSet2 = (HashSet<long>)num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = (nint)hashSet2;
			if (hashSet2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+18]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+18]");
				bool flag20 = (nint)0 == 0;
				num2 = num14;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					predicate..ctor(obj16, (IntPtr)obj18);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
					if ((nint)0 == 0)
					{
						goto IL_208b;
					}
					num12 = (nint)obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
					object obj27 = ((List<object>)0).Find(predicate);
					ClanFeedEventDataHolder clanFeedEventDataHolder = (ClanFeedEventDataHolder)(object)hashSet2;
					if (obj27 == null)
					{
						AddFeed((ClanFeedEventDataHolder)(object)hashSet2);
						obj13 = 0;
						num2 = (long)hashSet2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
						obj28 = 0;
					}
					else
					{
						if (hashSet2 == null)
						{
							goto IL_21a2;
						}
						((ClanFeedEventDataHolder)obj27).UpdateModel(clanFeedEventDataHolder.<Model>k__BackingField);
						obj13 = 0;
						num12 = unchecked((nint)null);
						num2 = (long)clanFeedEventDataHolder.<Model>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
						obj28 = 0;
					}
				}
				bool flag21 = hashSet3 == null;
				readOnlyList4 = (IReadOnlyList<ClanFeedEventDataHolder>)hashSet3;
				obj12 = obj13;
				obj5 = obj14;
				num11 = num12;
				num8 = num13;
				readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)hashSet3;
				if (!flag21)
				{
					continue;
				}
				goto IL_1eda;
			}
			goto IL_1fda;
			IL_1494:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num12 = unchecked((nint)null);
			goto IL_2bd4;
			IL_12c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num12 = unchecked((nint)null);
			goto IL_2ac8;
		}
		if (hashSet3 == null)
		{
			goto IL_2c03;
		}
		object obj29 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num19 = (nint)hashSet3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ X8_v31 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ X8_v31 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_172b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ X8_v31 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+B0]");
		int num20 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1842 @ X10_v13 (System.Int32)-8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1842 @ X10_v13 (System.Int32)-8]");
			if (0 == (nint)obj29)
			{
				break;
			}
			num13 = num20 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ X8_v31 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			array = (object[])(-1);
			bool flag22 = (nint)array != 1;
			num20 = num13;
			if (flag22)
			{
				continue;
			}
			goto IL_172b;
		}
		array = (object[])((int*)num20)->m_value;
		object obj30 = num19 + ((int*)num20)->m_value;
		object obj31 = obj30 + 312;
		num13 = num20;
		goto IL_2c7f;
		IL_20e0:
		ex = new NullReferenceException();
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		hashSet2 = (HashSet<long>)(object)list;
		goto IL_2f4c;
		IL_223f:
		throw new NullReferenceException();
		IL_1053:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num11 = unchecked((nint)null);
		goto IL_29c2;
		IL_0339:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num11 = unchecked((nint)null);
		goto IL_2560;
		IL_2560:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v100+8]");
		num2 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v565 @ X0_v100] (should have been resolved before IL gen)");
		HashSet<long> hashSet4 = default(HashSet<long>);
		bool flag23 = hashSet4 == null;
		num = (nint)(&hashSet3);
		if (flag23)
		{
			goto IL_20e0;
		}
		object obj32 = obj5;
		nint num21 = num11;
		int num22 = (int)num7;
		int num23 = (int)num6;
		int num24 = (int)num5;
		int num25 = num8;
		HashSet<long> hashSet5 = hashSet4;
		object obj34 = default(object);
		object obj35 = default(object);
		ClanFeedEventDataHolder clanFeedEventDataHolder2 = default(ClanFeedEventDataHolder);
		object[] array2;
		object obj41 = default(object);
		while (true)
		{
			nint num26 = (nint)hashSet5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v71 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v71 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_19dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v71 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+B0]");
			int num27 = (int)((nint)0 + (nint)8);
			bool flag24 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X10_v66 (System.Int32)-8]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X10_v66 (System.Int32)-8]");
				bool flag25 = 0 < (nint)obj2;
				obj6 = !flag25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X10_v66 (System.Int32)-8]");
				obj7 = 0 - obj2;
				flag5 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X10_v66 (System.Int32)-8]");
				flag6 = 0 == (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X10_v66 (System.Int32)-8]");
				num24 = 0 ^ obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X10_v66 (System.Int32)-8]");
				num23 = 0 ^ obj7;
				num22 = num24 & num23;
				flag7 = num22 < 0;
				if (flag6)
				{
					break;
				}
				num25 = num27 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X8_v71 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
				array = (object[])(-1);
				bool flag26 = (nint)array < 1;
				obj6 = !flag26;
				obj7 = array - 1;
				flag5 = (nint)obj7 < 0;
				flag6 = obj7 == null;
				num24 = array ^ 1;
				num23 = (object)array ^ obj7;
				num22 = num24 & num23;
				flag7 = num22 < 0;
				flag3 = (nint)array != 1;
				flag24 = flag3;
				num27 = num25;
				if (flag3)
				{
					continue;
				}
				goto IL_19dd;
			}
			array = (object[])((int*)num27)->m_value;
			object obj33 = num26 + ((int*)num27)->m_value;
			obj34 = obj33 + 312;
			flag3 = flag24;
			num25 = num27;
			goto IL_2d66;
			IL_2e72:
			num = (nint)obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1430 @ X0_v119] (should have been resolved before IL gen)");
			bool flag27 = ShouldDisplay(clanFeedEventDataHolder2);
			bool flag28 = !flag27;
			object obj36 = clanFeedEventDataHolder2;
			if (flag28)
			{
				goto IL_1857;
			}
			if (list != null)
			{
				num = (nint)obj4;
				int version = list._version + 1;
				list._version = version;
				array2 = list._items;
				if (list._items != null)
				{
					num25 = list._size;
					obj32 = array2.Length;
					bool flag29 = list._size < array2.Length;
					obj6 = !flag29;
					obj7 = list._size - array2.Length;
					flag5 = (nint)obj7 < 0;
					flag6 = obj7 == null;
					num24 = list._size ^ array2.Length;
					num23 = list._size ^ obj7;
					num22 = num24 & num23;
					flag7 = num22 < 0;
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+20]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ X8_v88+C0]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+70]");
						num21 = 0;
						list.AddWithResize((object)clanFeedEventDataHolder2);
						obj36 = clanFeedEventDataHolder2;
					}
					else
					{
						int num28 = ++list._size;
						object obj38 = list._items + list._size;
						object obj39 = obj38 + 32;
						obj39 = clanFeedEventDataHolder2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj36 = clanFeedEventDataHolder2;
						num = num28;
					}
					goto IL_1857;
				}
			}
			goto IL_214c;
			IL_1857:
			bool flag30 = hashSet3 == null;
			hashSet5 = hashSet3;
			obj5 = obj32;
			num11 = num21;
			num8 = num25;
			array = array2;
			num2 = (long)obj36;
			readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)hashSet3;
			if (!flag30)
			{
				continue;
			}
			goto IL_20e0;
			IL_1b81:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num21 = unchecked((nint)null);
			goto IL_2e72;
			IL_19dd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num21 = unchecked((nint)null);
			goto IL_2d66;
			IL_2d66:
			num = (nint)obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X0_v106+8]");
			num2 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1013 @ X0_v106] (should have been resolved before IL gen)");
			object obj40 = obj41 & 1;
			if (obj40 == null)
			{
				break;
			}
			if (hashSet3 == null)
			{
				goto IL_2106;
			}
			nint num29 = (nint)hashSet3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
			array2 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1b81;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+B0]");
			int num30 = (int)((nint)0 + (nint)8);
			bool flag31 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X10_v61 (System.Int32)-8]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X10_v61 (System.Int32)-8]");
				bool flag32 = 0 < (nint)obj3;
				obj6 = !flag32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X10_v61 (System.Int32)-8]");
				obj7 = 0 - obj3;
				flag5 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X10_v61 (System.Int32)-8]");
				flag6 = 0 == (nint)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X10_v61 (System.Int32)-8]");
				num24 = 0 ^ obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X10_v61 (System.Int32)-8]");
				num23 = 0 ^ obj7;
				num22 = num24 & num23;
				flag7 = num22 < 0;
				if (flag6)
				{
					break;
				}
				num25 = num30 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
				array2 = (object[])(-1);
				bool flag33 = (nint)array2 < 1;
				obj6 = !flag33;
				obj7 = array2 - 1;
				flag5 = (nint)obj7 < 0;
				flag6 = obj7 == null;
				num24 = array2 ^ 1;
				num23 = (object)array2 ^ obj7;
				num22 = num24 & num23;
				flag7 = num22 < 0;
				flag3 = (nint)array2 != 1;
				flag31 = flag3;
				num30 = num25;
				if (flag3)
				{
					continue;
				}
				goto IL_1b81;
			}
			array2 = (object[])((int*)num30)->m_value;
			object obj42 = num29 + ((int*)num30)->m_value;
			obj35 = obj42 + 312;
			flag3 = flag31;
			num25 = num30;
			goto IL_2e72;
		}
		if (hashSet3 == null)
		{
			goto IL_2eb7;
		}
		object obj43 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num31 = (nint)hashSet3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v78 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v78 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1e45;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v78 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+B0]");
		int num32 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X10_v53 (System.Int32)-8]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X10_v53 (System.Int32)-8]");
			if (0 == (nint)obj43)
			{
				break;
			}
			num25 = num32 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v78 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			array = (object[])(-1);
			bool flag34 = (nint)array != 1;
			num32 = num25;
			if (flag34)
			{
				continue;
			}
			goto IL_1e45;
		}
		array = (object[])((int*)num32)->m_value;
		object obj44 = num31 + ((int*)num32)->m_value;
		object obj45 = obj44 + 312;
		num25 = num32;
		goto IL_2f25;
		IL_01a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num11 = unchecked((nint)null);
		goto IL_2449;
		IL_2449:
		object obj46 = (nint)0 + (nint)488;
		obj18 = (nint)0 + (nint)3968;
		obj17 = (nint)0 + (nint)520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v141+8]");
		num2 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v474 @ X0_v141] (should have been resolved before IL gen)");
		num = (nint)(&hashSet3);
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)9223372036854775807L;
		object obj48 = default(object);
		object obj50 = default(object);
		object obj52 = default(object);
		object obj53 = default(object);
		while (hashSet3 != null)
		{
			nint num33 = (nint)hashSet3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v101 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v101 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v101 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+B0]");
			int num34 = (int)((nint)0 + (nint)8);
			bool flag35 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X10_v85 (System.Int32)-8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X10_v85 (System.Int32)-8]");
				bool flag36 = 0 < (nint)obj2;
				obj6 = !flag36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X10_v85 (System.Int32)-8]");
				obj7 = 0 - obj2;
				flag5 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X10_v85 (System.Int32)-8]");
				flag6 = 0 == (nint)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X10_v85 (System.Int32)-8]");
				num5 = 0 ^ obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X10_v85 (System.Int32)-8]");
				num6 = 0 ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				if (flag6)
				{
					break;
				}
				num8 = num34 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v101 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
				array = (object[])(-1);
				bool flag37 = (nint)array < 1;
				obj6 = !flag37;
				obj7 = array - 1;
				flag5 = (nint)obj7 < 0;
				flag6 = obj7 == null;
				num5 = array ^ 1;
				num6 = (object)array ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				flag3 = (nint)array != 1;
				flag35 = flag3;
				num34 = num8;
				if (flag3)
				{
					continue;
				}
				goto IL_04c0;
			}
			array = (object[])((int*)num34)->m_value;
			object obj47 = num33 + ((int*)num34)->m_value;
			obj48 = obj47 + 312;
			flag3 = flag35;
			num8 = num34;
			goto IL_265e;
			IL_04c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num11 = unchecked((nint)null);
			goto IL_265e;
			IL_265e:
			num = (nint)obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v146+8]");
			num2 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v999 @ X0_v146] (should have been resolved before IL gen)");
			object obj49 = obj50 & 1;
			if (obj49 == null)
			{
				goto IL_0883;
			}
			if (hashSet3 == null)
			{
				goto IL_1f22;
			}
			nint num35 = (nint)hashSet3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v104 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v104 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0664;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v104 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+B0]");
			int num36 = (int)((nint)0 + (nint)8);
			bool flag38 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v80 (System.Int32)-8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v80 (System.Int32)-8]");
				bool flag39 = 0 < (nint)obj3;
				obj6 = !flag39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v80 (System.Int32)-8]");
				obj7 = 0 - obj3;
				flag5 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v80 (System.Int32)-8]");
				flag6 = 0 == (nint)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v80 (System.Int32)-8]");
				num5 = 0 ^ obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v80 (System.Int32)-8]");
				num6 = 0 ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				if (flag6)
				{
					break;
				}
				num8 = num36 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v104 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
				array = (object[])(-1);
				bool flag40 = (nint)array < 1;
				obj6 = !flag40;
				obj7 = array - 1;
				flag5 = (nint)obj7 < 0;
				flag6 = obj7 == null;
				num5 = array ^ 1;
				num6 = (object)array ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				flag3 = (nint)array != 1;
				flag38 = flag3;
				num36 = num8;
				if (flag3)
				{
					continue;
				}
				goto IL_0664;
			}
			array = (object[])((int*)num36)->m_value;
			object obj51 = num35 + ((int*)num36)->m_value;
			obj52 = obj51 + 312;
			flag3 = flag38;
			num8 = num36;
			goto IL_276a;
			IL_276a:
			num = (nint)obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X0_v150+8]");
			num2 = 0L;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1324 @ X0_v150] (should have been resolved before IL gen)");
			if (obj53 == null)
			{
				goto IL_1f50;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v152+18]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v152+18]");
			if ((nint)0 == 0)
			{
				continue;
			}
			bool flag41 = hashSet == null;
			readOnlyList2 = incoming;
			enumerator = (List<object>.Enumerator)0;
			obj15 = null;
			hashSet2 = hashSet;
			if (flag41)
			{
				goto IL_2263;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
			num2 = 0L;
			num11 = (nint)obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
			bool flag42 = hashSet.Add(0L);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v152+18]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v152+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
				bool flag43 = 0 < (nint)readOnlyList;
				obj6 = !flag43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
				obj7 = 0 - readOnlyList;
				flag5 = (nint)obj7 < 0;
				flag6 = obj7 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
				num5 = 0 ^ readOnlyList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
				num6 = 0 ^ obj7;
				num7 = num5 & num6;
				flag7 = num7 < 0;
				bool flag44 = flag5 == flag7;
				flag3 = !flag44;
				object obj54 = !flag3;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
					readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)0;
				}
				continue;
			}
			goto IL_2271;
			IL_0664:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num11 = unchecked((nint)null);
			goto IL_276a;
		}
		ex = new NullReferenceException();
		readOnlyList2 = incoming;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		hashSet2 = hashSet;
		goto IL_2f4c;
		IL_2c03:
		obj12 = obj13;
		obj5 = obj14;
		enumerator = enumerator2;
		enumerator3 = enumerator2;
		obj15 = null;
		num11 = num12;
		num8 = num13;
		hashSet2 = hashSet3;
		readOnlyList = null;
		goto IL_224a;
		IL_2c7f:
		num = (nint)obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1887 @ X0_v29+8]");
		num2 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1887 @ X0_v29] (should have been resolved before IL gen)");
		goto IL_2c03;
		IL_172b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num12 = unchecked((nint)null);
		goto IL_2c7f;
		IL_224a:
		throw new OutOfMemoryException();
		IL_0883:
		readOnlyList2 = incoming;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		hashSet2 = hashSet;
		obj28 = null;
		goto IL_2fe9;
		IL_208b:
		ex = new NullReferenceException();
		obj12 = 0;
		obj5 = obj14;
		enumerator = enumerator2;
		enumerator3 = enumerator2;
		obj15 = null;
		num11 = (nint)obj18;
		num8 = num13;
		num2 = (long)obj16;
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)obj16;
		goto IL_2f4c;
		IL_214c:
		ex = new NullReferenceException();
		obj5 = obj32;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		num11 = num21;
		num8 = num25;
		array = array2;
		num2 = (long)clanFeedEventDataHolder2;
		hashSet2 = (HashSet<long>)(object)list;
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)clanFeedEventDataHolder2;
		goto IL_2f4c;
		IL_221b:
		ex = new NullReferenceException();
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		enumerator = enumerator4;
		enumerator3 = enumerator4;
		obj15 = null;
		goto IL_2f4c;
		IL_28b2:
		object obj55 = default(object);
		num = (nint)obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X0_v72+8]");
		num2 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1471 @ X0_v72] (should have been resolved before IL gen)");
		goto IL_27cb;
		IL_1f50:
		ex = new NullReferenceException();
		readOnlyList2 = incoming;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		hashSet2 = hashSet;
		goto IL_2f4c;
		IL_27cb:
		bool flag45 = obj28 == null;
		object obj56 = !flag45;
		if (obj56 == null)
		{
			object obj57 = typeof(List<AdaptivePerformanceScaler>) + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num = (nint)0 + (nint)3248;
			num2 = num;
			List<object> list2 = default(List<object>);
			list2..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
				List<object>.Enumerator enumerator5 = ((List<object>)0).GetEnumerator();
				num = (nint)(&enumerator);
				object obj58 = default(object);
				while (true)
				{
					num2 = (long)obj18;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if (obj58 == null)
					{
						goto IL_1efe;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ stack_-88 (System.Object)+18]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ stack_-88 (System.Object)+18]");
					bool flag46 = (nint)0 == 0;
					obj28 = obj58;
					if (flag46)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
					num2 = 0L;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
					bool flag47 = 0 < (nint)readOnlyList;
					obj6 = !flag47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
					obj7 = 0 - readOnlyList;
					flag5 = (nint)obj7 < 0;
					flag6 = obj7 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
					num5 = 0 ^ readOnlyList;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
					num6 = 0 ^ obj7;
					num7 = num5 & num6;
					flag7 = num7 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
					flag3 = 0 < (nint)readOnlyList;
					obj28 = obj58;
					if (flag3)
					{
						continue;
					}
					if (hashSet2 != null)
					{
						num = (nint)0 + (nint)496;
						num11 = num;
						HashSet<long> hashSet6 = hashSet2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+10]");
						bool flag48 = hashSet6.Contains(0L);
						bool flag49 = !flag48;
						object obj59 = !flag49;
						obj28 = obj58;
						if (obj59 != null)
						{
							continue;
						}
						if (list2 != null)
						{
							num = (nint)obj4;
							int version2 = list2._version + 1;
							list2._version = version2;
							array = list2._items;
							if (list2._items != null)
							{
								num8 = list2._size;
								obj5 = array.Length;
								bool flag50 = list2._size < array.Length;
								obj6 = !flag50;
								obj7 = list2._size - array.Length;
								flag5 = (nint)obj7 < 0;
								flag6 = obj7 == null;
								num5 = list2._size ^ array.Length;
								num6 = list2._size ^ obj7;
								num7 = num5 & num6;
								flag7 = num7 < 0;
								if (obj6 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+20]");
									object obj60 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ X8_v51+C0]");
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v48 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+70]");
									num11 = 0;
									list2.AddWithResize(obj58);
									obj28 = obj58;
								}
								else
								{
									num = list2._size + 1;
									list2._size = (int)num;
									object obj61 = list2._items + list2._size;
									object obj62 = obj61 + 32;
									obj62 = obj58;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									obj28 = obj58;
								}
								continue;
							}
						}
						goto IL_21f7;
					}
					goto IL_221b;
				}
				readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)((nint)0 + (nint)3960);
				num2 = (long)readOnlyList;
				enumerator.Dispose();
				bool flag51 = list2 == null;
				enumerator = enumerator4;
				enumerator3 = enumerator4;
				obj15 = null;
				if (!flag51)
				{
					List<object>.Enumerator enumerator6 = list2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						obj12 = obj17;
						((UiListView<object, object>)(object)this).RemoveItem(obj58, (Action)null);
						num11 = unchecked((nint)null);
					}
					enumerator.Dispose();
					object obj63 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3048;
					nint num37 = (nint)readOnlyList2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X8_v19 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
					array = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X8_v19 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_1053;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X8_v19 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+B0]");
					int num38 = (int)((nint)0 + (nint)8);
					bool flag52 = flag3;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X10_v29 (System.Int32)-8]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X10_v29 (System.Int32)-8]");
						bool flag53 = 0 < (nint)obj63;
						obj6 = !flag53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X10_v29 (System.Int32)-8]");
						obj7 = 0 - obj63;
						flag5 = (nint)obj7 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X10_v29 (System.Int32)-8]");
						flag6 = 0 == (nint)obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X10_v29 (System.Int32)-8]");
						num5 = 0 ^ obj63;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X10_v29 (System.Int32)-8]");
						num6 = 0 ^ obj7;
						num7 = num5 & num6;
						flag7 = num7 < 0;
						if (flag6)
						{
							break;
						}
						num8 = num38 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X8_v19 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<ClanFeedEventDataHolder>>)+12E]");
						array = (object[])(-1);
						bool flag54 = (nint)array < 1;
						obj6 = !flag54;
						obj7 = array - 1;
						flag5 = (nint)obj7 < 0;
						flag6 = obj7 == null;
						num5 = array ^ 1;
						num6 = (object)array ^ obj7;
						num7 = num5 & num6;
						flag7 = num7 < 0;
						flag3 = (nint)array != 1;
						flag52 = flag3;
						num38 = num8;
						if (flag3)
						{
							continue;
						}
						goto IL_1053;
					}
					array = (object[])((int*)num38)->m_value;
					object obj64 = num37 + ((int*)num38)->m_value;
					object obj65 = obj64 + 312;
					flag3 = flag52;
					num8 = num38;
					goto IL_29c2;
				}
			}
			goto IL_223f;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_2263;
		IL_202e:
		ex = new NullReferenceException();
		obj12 = obj13;
		obj5 = obj14;
		enumerator = enumerator2;
		enumerator3 = enumerator2;
		obj15 = null;
		num11 = num12;
		num8 = num13;
		num2 = 0L;
		hashSet2 = hashSet3;
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)obj16;
		goto IL_2f4c;
		IL_1e45:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num21 = unchecked((nint)null);
		goto IL_2f25;
		IL_2f25:
		num = (nint)obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ X0_v112+8]");
		num2 = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1442 @ X0_v112] (should have been resolved before IL gen)");
		goto IL_2eb7;
		IL_2eb7:
		obj5 = obj32;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		num11 = num21;
		num8 = num25;
		hashSet2 = (HashSet<long>)(object)list;
		readOnlyList = null;
		goto IL_224a;
		IL_2fe9:
		if (hashSet3 == null)
		{
			goto IL_27cb;
		}
		object obj66 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num39 = (nint)hashSet3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v55 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v55 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_09f2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v55 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+B0]");
		int num40 = (int)((nint)0 + (nint)8);
		bool flag55 = flag3;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X10_v36 (System.Int32)-8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X10_v36 (System.Int32)-8]");
			bool flag56 = 0 < (nint)obj66;
			obj6 = !flag56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X10_v36 (System.Int32)-8]");
			obj7 = 0 - obj66;
			flag5 = (nint)obj7 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X10_v36 (System.Int32)-8]");
			flag6 = 0 == (nint)obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X10_v36 (System.Int32)-8]");
			num5 = 0 ^ obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X10_v36 (System.Int32)-8]");
			num6 = 0 ^ obj7;
			num7 = num5 & num6;
			flag7 = num7 < 0;
			if (flag6)
			{
				break;
			}
			num8 = num40 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v55 (Il2CppClass<System.Collections.Generic.HashSet`1<System.Int64>>)+12E]");
			array = (object[])(-1);
			bool flag57 = (nint)array < 1;
			obj6 = !flag57;
			obj7 = array - 1;
			flag5 = (nint)obj7 < 0;
			flag6 = obj7 == null;
			num5 = array ^ 1;
			num6 = (object)array ^ obj7;
			num7 = num5 & num6;
			flag7 = num7 < 0;
			flag3 = (nint)array != 1;
			flag55 = flag3;
			num40 = num8;
			if (flag3)
			{
				continue;
			}
			goto IL_09f2;
		}
		array = (object[])((int*)num40)->m_value;
		object obj67 = num39 + ((int*)num40)->m_value;
		obj55 = obj67 + 312;
		flag3 = flag55;
		num8 = num40;
		goto IL_28b2;
		IL_2106:
		ex = new NullReferenceException();
		obj5 = obj32;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		num11 = num21;
		num8 = num25;
		hashSet2 = (HashSet<long>)(object)list;
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)hashSet3;
		goto IL_2f4c;
		IL_1f22:
		ex = new NullReferenceException();
		readOnlyList2 = incoming;
		enumerator = (List<object>.Enumerator)0;
		obj15 = null;
		hashSet2 = hashSet;
		goto IL_2f4c;
		IL_09f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num11 = unchecked((nint)null);
		goto IL_28b2;
		IL_2f4c:
		bool flag58 = num2 < 1;
		obj6 = !flag58;
		obj7 = num2 - 1;
		flag5 = (nint)obj7 < 0;
		flag6 = obj7 == null;
		num5 = num2 ^ 1;
		num6 = num2 ^ obj7;
		num7 = num5 & num6;
		flag7 = num7 < 0;
		flag3 = num2 != 1;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj68 = default(object);
			obj28 = obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj15 = obj68;
			goto IL_2fe9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_1efe:
		ex = new NullReferenceException();
		enumerator = enumerator4;
		enumerator3 = enumerator4;
		obj15 = null;
		goto IL_2f4c;
		IL_1eda:
		ex = new NullReferenceException();
		enumerator = enumerator2;
		enumerator3 = enumerator2;
		obj15 = null;
		goto IL_2f4c;
		IL_2263:
		ex = new NullReferenceException();
		goto IL_2f4c;
		IL_21a2:
		ex = new NullReferenceException();
		obj12 = 0;
		obj5 = obj14;
		enumerator = enumerator2;
		enumerator3 = enumerator2;
		obj15 = null;
		num11 = (nint)obj19;
		num8 = num13;
		num2 = (long)hashSet2;
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)obj16;
		goto IL_2f4c;
		IL_21f7:
		ex = new NullReferenceException();
		enumerator = enumerator4;
		enumerator3 = enumerator4;
		obj15 = null;
		goto IL_2f4c;
		IL_1fda:
		ex = new NullReferenceException();
		obj12 = obj13;
		obj5 = obj14;
		enumerator = enumerator2;
		enumerator3 = enumerator2;
		obj15 = null;
		num11 = num12;
		num8 = num13;
		num2 = num14;
		readOnlyList = (IReadOnlyList<ClanFeedEventDataHolder>)obj16;
		goto IL_2f4c;
	}

	public unsafe void ApplyVaultSupportProgress(int currentAmount)
	{
		//IL_0424: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0128: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0057: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0476: Expected O, but got I
		//IL_0487: Expected I, but got O
		//IL_04a5: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_02af: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_0324: Expected O, but got Ref
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I4
		//IL_034a: Expected I, but got O
		//IL_035a: Expected O, but got I
		//IL_03e6: Expected O, but got I
		//IL_041a: Expected O, but got I
		nint num = (nint)this;
		List<object> list = (List<object>)(object)base.data;
		if (list == null)
		{
			return;
		}
		object obj = typeof(CardUtils.<>c) + 632;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v20+E4]");
		object obj3;
		Predicate<object> match;
		List<object> list2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v20+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v14+10]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v14+10]");
			bool flag = (nint)0 == 0;
			list2 = list;
			if (!flag)
			{
				goto IL_0095;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v20+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v14+10]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v14+10]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			list2 = list;
			if (obj4 != null)
			{
				goto IL_0095;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v27+B8]");
			obj3 = 0;
		}
		object obj7 = typeof(List<Tween>) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)3528;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj3, (IntPtr)obj8);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v26+B8]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = list2.Find(predicate);
		if (obj11 != null)
		{
			goto IL_01c4;
		}
		return;
		IL_01c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5 (System.Object)+18]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5 (System.Object)+18]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v7+78]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v7+78]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj14 = typeof(UsageHint) + 712;
		object obj15 = obj14;
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v3+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X9_v7+130]");
		bool flag4 = num2 < 0;
		object obj17 = !flag4;
		object obj18 = ~obj17;
		if (obj18 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v3+C8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X9_v7+130]");
		object obj19 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X10_v5-8]");
		if (0 != (nint)obj15)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5 (System.Object)+10]");
		int num4 = 0;
		object obj20 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5 (System.Object)+10]");
		object item;
		bool flag5 = TryGetTrackedItem(0, out item);
		bool flag6 = !flag5;
		object obj21 = (object)(&item);
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5 (System.Object)+18]");
			num4 = 0;
			nint num5 = (nint)item;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v19 (Il2CppClass<System.Object>)+330]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v341 @ X8_v19 (Il2CppClass<System.Object>)+328] (should have been resolved before IL gen)");
		}
		object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(_pinnedHeaderClone != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5 (System.Object)+10]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+154]");
		if (num6 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+150]");
			object obj25 = (nint)0 & (nint)1;
			if (obj25 != null)
			{
				ClanEventStrip pinnedHeaderClone = _pinnedHeaderClone;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v5 (System.Object)+18]");
				pinnedHeaderClone.Initialize((ClanFeedModel)0);
			}
		}
		return;
		IL_0095:
		obj11 = list.Find(match);
		bool flag8 = obj11 == null;
		object obj26 = !flag8;
		if (obj26 == null)
		{
			return;
		}
		goto IL_01c4;
	}

	public void RemoveFeedById(long feedId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Expected I, but got O
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_0086: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		nint num = (nint)this;
		List<ClanFeedEventDataHolder> list = base.data;
		if (list != null)
		{
			object obj3 = typeof(List<Tween>) + 3152;
			object obj4 = (nint)0 + (nint)3640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj2, (IntPtr)obj4);
			object obj5 = ((List<object>)(object)list).Find(predicate);
			if (obj5 != null)
			{
				((UiListView<object, object>)(object)this).RemoveItem(obj5, (Action)null);
			}
		}
	}

	public bool HasLiveRoom(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d7: Expected I4, but got O
		//IL_0028: Expected I4, but got O
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0066: Expected I, but got O
		//IL_008b: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			bool flag = (byte)(int)base.data != 0;
			if (!flag)
			{
				return flag;
			}
			object obj3 = typeof(List<Tween>) + 3152;
			object obj4 = (nint)0 + (nint)3648;
			nint num = (nint)this;
			List<ClanFeedEventDataHolder> list = base.data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj2, (IntPtr)obj4);
			if (list != null)
			{
				return ((List<object>)(object)list).Exists(predicate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public void RemoveLiveRoomById(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Expected I, but got O
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_0086: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		nint num = (nint)this;
		List<ClanFeedEventDataHolder> list = base.data;
		if (list != null)
		{
			object obj3 = typeof(List<Tween>) + 3152;
			object obj4 = (nint)0 + (nint)3544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj2, (IntPtr)obj4);
			object obj5 = ((List<object>)(object)list).Find(predicate);
			if (obj5 != null)
			{
				((UiListView<object, object>)(object)this).RemoveItem(obj5, (Action)null);
				SeedPinFromData();
			}
		}
	}

	public void ReseedServerPin()
	{
		SeedPinFromData();
	}

	public void ApplyPinChangeById(long? feedId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I
		//IL_00b5: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (??)feedId & 1;
		if (obj3 != null)
		{
			nint num = (nint)this;
			List<ClanFeedEventDataHolder> list = base.data;
			if (list != null)
			{
				object obj4 = typeof(List<Tween>) + 3152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)3552;
				Predicate<object> predicate = default(Predicate<object>);
				predicate..ctor(obj2, (IntPtr)obj5);
				object obj6 = ((List<object>)(object)list).Find(predicate);
				if (obj6 != null)
				{
					((UiListView<object, object>)(object)this).SetPinned(obj6);
					return;
				}
			}
		}
		((UiListView<object, object>)(object)this).ClearPinned();
	}

	private void DeleteFeed(ClanFeedEventDataHolder datum)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0173: Expected I, but got O
		//IL_0191: Expected I8, but got I
		object obj = typeof(CardUtils.<>c) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = datum;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		if (obj4 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4+18]");
		if ((nint)0 != 0)
		{
			object obj6 = typeof(Queue<string>) + 728;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = (nint)0 + (nint)1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v12+18]");
			object obj11 = 0;
			object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)3560;
			Action<bool> action = default(Action<bool>);
			action..ctor(obj2, (IntPtr)obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v13+10]");
			((ClanServerConnector)(object)action).DeleteAnnouncement(0L, action);
		}
	}

	private void ServerTogglePin(ClanFeedEventDataHolder datum)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0217: Expected O, but got I4
		//IL_0240: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0267: Expected O, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0296: Expected O, but got I
		//IL_02a7: Expected I, but got O
		//IL_0145: Expected O, but got I4
		//IL_02c5: Expected I8, but got I
		//IL_016e: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I
		//IL_01d5: Expected I, but got O
		//IL_01f3: Expected I8, but got I
		object obj = typeof(CardUtils.<>c) + 664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = datum;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		if (obj4 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+18]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj6 = typeof(Queue<string>) + 728;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+154]");
		if (num == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+150]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj10 = (nint)0 + (nint)1976;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v18+18]");
				object obj12 = 0;
				object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)3568;
				Action<bool> action = default(Action<bool>);
				action..ctor(obj2, (IntPtr)obj14);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v19+10]");
				((ClanServerConnector)(object)action).UnpinFeed(0L, action);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v10+18]");
		object obj18 = 0;
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)3576;
		Action<bool> action2 = default(Action<bool>);
		action2..ctor(obj2, (IntPtr)obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v11+10]");
		((ClanServerConnector)(object)action2).PinFeed(0L, action2);
	}

	private int SortedInsertIndex(ClanFeedEventDataHolder datum)
	{
		//IL_03a9: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_013c: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_0191: Expected O, but got I4
		//IL_01d9: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_0251: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_0300: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8772]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		List<object> list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		int num2;
		if ((nint)0 != 0)
		{
			if (datum != null)
			{
				object obj = (nint)0 + (nint)3312;
				object obj2 = typeof(DataRelation) + 712;
				num2 = 0;
				do
				{
					num = list._size;
					if (num2 < list._size)
					{
						object obj3 = list.get_Item(num2);
						if (obj3 == null)
						{
							break;
						}
						object obj4 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v10+E4]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v10+E4]");
						bool flag = (nint)0 == 0;
						object obj5 = !flag;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime <SortDate>k__BackingField = datum.<SortDate>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v9 (System.Object)+30]");
						bool flag2 = <SortDate>k__BackingField > (DateTime)0;
						bool flag3 = !flag2;
						object obj6 = !flag3;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
							object obj7 = ((List<object>)0).get_Item(num2);
							if (obj7 == null)
							{
								break;
							}
							object obj8 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v16+E4]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v16+E4]");
							if ((nint)0 != 0)
							{
								DateTime <SortDate>k__BackingField2 = datum.<SortDate>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v15 (System.Object)+30]");
								if (!(<SortDate>k__BackingField2 == (DateTime)0))
								{
									goto IL_0060;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								DateTime <SortDate>k__BackingField3 = datum.<SortDate>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v15 (System.Object)+30]");
								if (!(<SortDate>k__BackingField3 == (DateTime)0))
								{
									goto IL_0060;
								}
							}
							long sortId = datum.SortId;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
							object obj9 = ((List<object>)0).get_Item(num2);
							if (obj9 == null)
							{
								break;
							}
							long sortId2 = ((ClanFeedEventDataHolder)obj9).SortId;
							if (sortId < sortId2)
							{
								goto IL_0060;
							}
						}
					}
					else
					{
						num2 = num;
					}
					goto IL_03ce;
					IL_0060:
					num2++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
					list = (List<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
				}
				while ((nint)0 != 0);
			}
			else
			{
				num2 = list._size;
				if (list._size <= 0)
				{
					goto IL_03ce;
				}
			}
		}
		throw new NullReferenceException();
		IL_03ce:
		return num2;
	}

	private ClanEventStrip TemplateStrip(string template)
	{
		//IL_0090: Expected O, but got I
		if (_stripByTemplate != null)
		{
			if (((Dictionary<object, object>)(object)_stripByTemplate).TryGetValue((object)template, out object value))
			{
				return (ClanEventStrip)value;
			}
			if (!TryGetTemplatePrefab(template, out GameObject prefab))
			{
				goto IL_00ef;
			}
			if ((object)prefab != null)
			{
				object obj = (nint)0 + (nint)1776;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
				object obj2 = default(object);
				if (obj2 == null)
				{
					goto IL_00ef;
				}
				if (_stripByTemplate != null)
				{
					((Dictionary<object, object>)(object)_stripByTemplate).set_Item((object)template, value);
					return (ClanEventStrip)value;
				}
			}
		}
		return (ClanEventStrip)(object)new NullReferenceException();
		IL_00ef:
		return null;
	}

	private bool TemplateKeepsWhenPinned(string template)
	{
		//IL_0093: Expected I4, but got O
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected I4, but got Unknown
		string template2 = default(string);
		ClanEventStrip clanEventStrip = TemplateStrip(template2);
		bool flag = (object)clanEventStrip == null;
		bool result = (byte)(int)clanEventStrip != 0;
		if (!flag)
		{
			ListViewItemExtra extra = clanEventStrip._extra;
			if ((object)clanEventStrip._extra == null)
			{
				return false;
			}
			bool? flag2 = extra._keepWhenPinned;
			object obj = (object?)flag2 >> 8;
			result = (byte)(obj & 1) != 0;
		}
		return result;
	}

	private bool TemplateUsesSeparatePrefab(string template)
	{
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_0079: Expected O, but got I4
		//IL_01d4: Expected I4, but got O
		//IL_0104: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		string template2 = default(string);
		ClanEventStrip clanEventStrip = TemplateStrip(template2);
		ListViewItemExtra listViewItemExtra;
		ListViewItemExtra listViewItemExtra2;
		if ((object)clanEventStrip != null)
		{
			listViewItemExtra = clanEventStrip._extra;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			listViewItemExtra2 = clanEventStrip._extra;
			if (!flag)
			{
				goto IL_004c;
			}
		}
		else
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			listViewItemExtra = null;
			listViewItemExtra2 = null;
			if (obj3 != null)
			{
				goto IL_004c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = listViewItemExtra2 != null;
		bool flag4 = !flag3;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		listViewItemExtra = listViewItemExtra2;
		if (!flag4)
		{
			goto IL_011f;
		}
		goto IL_01c0;
		IL_01c0:
		return false;
		IL_011f:
		if ((object)listViewItemExtra != null)
		{
			if (listViewItemExtra._pinnedForm == PinnedForm.SeparatePrefab)
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return listViewItemExtra._miniPrefab != null;
			}
			goto IL_01c0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_004c:
		bool flag6 = listViewItemExtra != null;
		bool flag7 = !flag6;
		object obj8 = !flag7;
		obj4 = 0;
		obj5 = null;
		if (obj8 != null)
		{
			goto IL_011f;
		}
		goto IL_01c0;
	}

	private void OnPinnedHeaderClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_00ff: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0246: Expected O, but got I
		//IL_0257: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+150]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+150]");
		object obj5 = (nint)0 >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj6 = typeof(List<Tween>) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)3584;
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		object obj8 = ((List<object>)0).Find(predicate);
		if (obj8 == null)
		{
			return;
		}
		string template = ((ClanFeedEventDataHolder)obj8).template;
		ClanEventStrip clanEventStrip = TemplateStrip(template);
		if ((object)clanEventStrip == null)
		{
			return;
		}
		ListViewItemExtra extra = clanEventStrip._extra;
		if ((object)clanEventStrip._extra == null)
		{
			return;
		}
		bool? flag = extra._keepWhenPinned;
		object obj9 = (??)flag & 0x100;
		if (obj9 != null)
		{
			object obj10 = (nint)0 + (nint)480;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+10]");
			if (IsIndexOnScreen(0, fully: true))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+10]");
				NudgeIndex(0);
				return;
			}
			object obj11 = (nint)0 + (nint)3288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
			int index = ((List<object>)0).IndexOf(obj8);
			object obj12 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)3592;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj13);
			((UiListView<object, object>)(object)this).AnimateCenteredScrollTo(index, 0.3f, action);
		}
	}

	private void NudgeIndex(int index)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_0064: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		object obj = (nint)0 + (nint)544;
		int index2 = default(int);
		if (!TryGetTrackedItem(index2, out object _))
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-38_v2 (System.Object)+90]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-38_v2 (System.Object)+90]");
			if (!((UnityEngine.Object)0 != null))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-38_v2 (System.Object)+90]");
		((ListViewItemExtra)0).NudgeAttention();
	}

	private bool MorphsInPlaceIndex(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0195: Expected I4, but got O
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_007f: Expected I, but got O
		//IL_009a: Expected O, but got I
		//IL_00b5: Expected I4, but got O
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0140: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
			if ((nint)0 != 0)
			{
				object obj3 = typeof(List<Tween>) + 3152;
				object obj4 = (nint)0 + (nint)3608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Predicate<object> predicate = default(Predicate<object>);
				predicate..ctor(obj2, (IntPtr)obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
				object obj5 = ((List<object>)0).Find(predicate);
				bool flag = obj5 == null;
				bool result = (byte)(int)obj5 != 0;
				if (!flag)
				{
					string template = ((ClanFeedEventDataHolder)obj5).template;
					ClanEventStrip clanEventStrip = TemplateStrip(template);
					if ((object)clanEventStrip != null)
					{
						ListViewItemExtra extra = clanEventStrip._extra;
						if ((object)clanEventStrip._extra != null)
						{
							bool? flag2 = extra._keepWhenPinned;
							object obj6 = (??)flag2 & 0x100;
							bool flag3 = obj6 == null;
							object obj7 = !flag3;
							if (obj7 != null)
							{
								goto IL_0181;
							}
						}
					}
					string template2 = ((ClanFeedEventDataHolder)obj5).template;
					bool flag4 = TemplateUsesSeparatePrefab(template2);
					result = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
				}
				return result;
			}
			goto IL_0181;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0181:
		return false;
	}

	protected override bool KeepPinnedDatumInList(ClanFeedEventDataHolder pinned)
	{
		//IL_00a6: Expected I4, but got O
		//IL_00cb: Expected I4, but got O
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		if (pinned != null)
		{
			string template = pinned.template;
			ClanEventStrip clanEventStrip = TemplateStrip(template);
			bool flag = (object)clanEventStrip == null;
			bool result = (byte)(int)clanEventStrip != 0;
			if (!flag)
			{
				ListViewItemExtra extra = clanEventStrip._extra;
				if ((object)clanEventStrip._extra == null)
				{
					return false;
				}
				bool? flag2 = extra._keepWhenPinned;
				object obj = (object?)flag2 >> 8;
				result = (byte)(obj & 1) != 0;
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	protected override bool UsesClonedHeader(ClanFeedEventDataHolder pinned)
	{
		//IL_0050: Expected I4, but got O
		if (pinned != null)
		{
			string template = pinned.template;
			return TemplateUsesSeparatePrefab(template);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	protected override float GetPinnedTopOffset(ClanFeedEventDataHolder pinned)
	{
		//IL_003d: Expected F4, but got I4
		//IL_0075: Expected F4, but got I4
		string template = pinned.template;
		ClanEventStrip clanEventStrip = TemplateStrip(template);
		bool flag = (object)clanEventStrip == null;
		float result = 0f;
		if (!flag)
		{
			ListViewItemExtra extra = clanEventStrip._extra;
			bool flag2 = (object)clanEventStrip._extra == null;
			result = 0f;
			if (!flag2)
			{
				float? num = extra._pinnedTopOffset;
				float num2 = default(float);
				result = num2;
			}
		}
		return result;
	}

	protected override float GetPinnedHeight(ClanFeedEventDataHolder pinned, float templateHeight)
	{
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_00e2: Expected I, but got O
		//IL_0180: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		//IL_0094: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		//IL_0392: Expected O, but got I
		//IL_025f: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_01f7: Expected O, but got I
		//IL_0211: Expected O, but got I4
		//IL_03da: Expected O, but got I
		//IL_02df: Expected O, but got I4
		//IL_0363: Expected O, but got I4
		string template = pinned.template;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		ClanEventStrip clanEventStrip = TemplateStrip(template);
		object obj2 = default(object);
		nint num;
		string text;
		if ((object)clanEventStrip != null)
		{
			ListViewItemExtra extra = clanEventStrip._extra;
			if ((object)clanEventStrip._extra != null)
			{
				obj2 = (nint)0 + (nint)2008;
				bool? flag = extra._keepWhenPinned;
				object obj3 = (??)flag & 0x100;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				num = (nint)obj2;
				text = (string)extra._keepWhenPinned;
				if (obj4 != null)
				{
					goto IL_00f8;
				}
			}
		}
		string template2 = pinned.template;
		bool flag3 = TemplateUsesSeparatePrefab(template2);
		bool flag4 = !flag3;
		num = (nint)obj2;
		text = template2;
		if (!flag4)
		{
			goto IL_00f8;
		}
		object obj5 = (nint)0 + (nint)544;
		object item;
		bool flag5 = TryGetTrackedItem(pinned.<index>k__BackingField, out item);
		bool flag6 = !flag5;
		float result = templateHeight;
		if (!flag6)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v34+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ stack_-50_v5 (System.Object)+90]");
				bool flag7 = (UnityEngine.Object)0 != null;
				bool flag8 = !flag7;
				object obj7 = !flag8;
				if (obj7 != null)
				{
					goto IL_03bc;
				}
				result = templateHeight;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ stack_-50_v5 (System.Object)+90]");
				bool flag9 = (UnityEngine.Object)0 != null;
				bool flag10 = !flag9;
				result = templateHeight;
				if (!flag10)
				{
					goto IL_03bc;
				}
			}
		}
		goto IL_0435;
		IL_03bc:
		object obj8 = item;
		goto IL_03c9;
		IL_03c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7 (System.Object)+90]");
		float currentHeight = ((ListViewItemExtra)0).CurrentHeight;
		result = currentHeight;
		goto IL_0435;
		IL_0435:
		return result;
		IL_00f8:
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = _pinnedHeaderClone != null;
			bool flag12 = !flag11;
			object obj10 = !flag12;
			object obj11 = 0;
			UnityEngine.Object obj12 = null;
			if (obj10 != null)
			{
				goto IL_027a;
			}
			result = templateHeight;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = _pinnedHeaderClone != null;
			bool flag14 = !flag13;
			object obj11 = 0;
			UnityEngine.Object obj12 = null;
			result = templateHeight;
			if (!flag14)
			{
				goto IL_027a;
			}
		}
		goto IL_0435;
		IL_033d:
		obj8 = _pinnedHeaderClone;
		bool flag15 = (object)_pinnedHeaderClone == null;
		object obj13 = !flag15;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_03c9;
		IL_027a:
		ClanEventStrip pinnedHeaderClone = _pinnedHeaderClone;
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			bool flag16 = pinnedHeaderClone._extra != null;
			bool flag17 = !flag16;
			object obj15 = !flag17;
			if (obj15 != null)
			{
				goto IL_033d;
			}
			result = templateHeight;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag18 = pinnedHeaderClone._extra != null;
			bool flag19 = !flag18;
			result = templateHeight;
			if (!flag19)
			{
				goto IL_033d;
			}
		}
		goto IL_0435;
	}

	protected override void OnPinnedCloneReady(ClanEventStrip clone, ClanFeedEventDataHolder datum)
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00d7: Expected I, but got O
		_pinnedHeaderClone = clone;
		object obj = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (nint)0 + (nint)1568;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		((ListViewItem<object, int>)(object)clone).SetPinned(pinned: true, animated: false);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag = clone._extra != null;
			bool flag2 = !flag;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clone._extra != null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (obj7 == null)
			{
				return;
			}
		}
		object obj8 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1008;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		clone._extra.OnPinnedHeaderClicked += action;
	}

	protected override void OnPinnedCloneShown(ClanEventStrip clone, ClanFeedEventDataHolder datum)
	{
		clone.ReassertPinned();
	}

	protected override GameObject ResolveCloneSource(ClanFeedEventDataHolder datum, GameObject templatePrefab)
	{
		GameObject result;
		if (datum != null)
		{
			string template = datum.template;
			bool flag = TemplateUsesSeparatePrefab(template);
			bool flag2 = !flag;
			result = templatePrefab;
			if (flag2)
			{
				goto IL_00ea;
			}
			string template2 = datum.template;
			ClanEventStrip clanEventStrip = TemplateStrip(template2);
			if ((object)clanEventStrip != null)
			{
				ListViewItemExtra extra = clanEventStrip._extra;
				if ((object)clanEventStrip._extra != null)
				{
					result = extra._miniPrefab;
					goto IL_00ea;
				}
			}
		}
		return (GameObject)(object)new NullReferenceException();
		IL_00ea:
		return result;
	}

	protected override void OnPinnedChanged(int? previousIndex, int? currentIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0253: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (_pinnedHeaderClone != null)
		{
			object obj4 = (??)currentIndex & 1;
			if (obj4 != null)
			{
				object obj5 = (object?)currentIndex ^ (object?)previousIndex;
				object obj6 = obj5 & -4294967295L;
				if (obj6 == null)
				{
					goto IL_00da;
				}
			}
			_pinnedHeaderClone = null;
			object obj7 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		goto IL_00da;
		IL_00da:
		((UiListView<object, object>)(object)this).OnPinnedChanged(previousIndex, currentIndex);
		object obj8 = (??)previousIndex & 1;
		if (obj8 != null)
		{
			int? num = default(int?);
			int value = num.Value;
			if (TryGetTrackedItem(value, out object item))
			{
				((ListViewItem<object, int>)item).SetPinned(pinned: false, animated: true);
			}
		}
		object obj9 = (??)currentIndex & 1;
		if (obj9 == null)
		{
			return;
		}
		int? num2 = default(int?);
		int value2 = num2.Value;
		if (MorphsInPlaceIndex(value2))
		{
			int value3 = num2.Value;
			if (TryGetTrackedItem(value3, out object item2))
			{
				((ListViewItem<object, int>)item2).SetPinned(pinned: true, animated: true);
			}
		}
	}

	protected override void OnItemSetup(ClanFeedEventDataHolder datum, ClanEventStrip item)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected I4, but got Unknown
		//IL_0172: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		object obj = (nint)0 + (nint)496;
		OnItemSetup((object)datum, (object)item);
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (item._extra != null)
			{
				goto IL_00be;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (item._extra != null)
			{
				goto IL_00be;
			}
		}
		goto IL_00f2;
		IL_0100:
		int <index>k__BackingField = datum.<index>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+154]");
		object obj4 = (nint)<index>k__BackingField - (nint)0;
		bool flag = obj4 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+150]");
		object obj6;
		object obj5 = 0 & obj6;
		bool pinned = (byte)((flag & obj5) ? 1 : 0) != 0;
		((ListViewItem<object, int>)(object)item).SetPinned(pinned, animated: false);
		return;
		IL_00f2:
		obj6 = 0;
		goto IL_0100;
		IL_00be:
		ListViewItemExtra extra = item._extra;
		if (extra._pinnedForm != PinnedForm.Morph)
		{
			goto IL_00f2;
		}
		obj6 = (extra._keepWhenPinned ? 1 : 0) ^ 1;
		bool flag2 = datum == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0100;
	}

	protected override void UpdateItems()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_004b: Expected O, but got I4
		object obj = (nint)0 + (nint)552;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		UpdateItems();
		MaybeRequestOlder();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = _loadingOlderFooter != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(_loadingOlderFooter != null))
			{
				return;
			}
		}
		GameObject gameObject = _loadingOlderFooter.gameObject;
		if (gameObject.activeSelf)
		{
			PositionAtContentEnd(_loadingOlderFooter, _footerGap);
		}
	}

	private void MaybeRequestOlder()
	{
		//IL_0022: Expected O, but got I4
		//IL_00d2: Invalid comparison between F4 and I4
		//IL_00e3: Expected O, but got I4
		//IL_00ec: Invalid comparison between F4 and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		if (_loadingOlder)
		{
			return;
		}
		bool flag = !_reachedFeedEnd;
		object obj = !flag;
		if (obj != null || this.OnLoadOlderRequested == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		if ((nint)0 == 0 || !((UiListView<object, object>)(object)this).TemplatesReady)
		{
			return;
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (realtimeSinceStartup < _olderRetryNotBefore)
		{
			return;
		}
		float num = base.listHeight;
		bool flag2 = realtimeSinceStartup < 0f;
		object obj2 = !flag2;
		bool flag3 = realtimeSinceStartup == 0f;
		object obj3 = ~obj2;
		object obj4 = obj3 | flag3;
		if (obj4 != null)
		{
			return;
		}
		float num2 = base.listHeight;
		float num3 = realtimeSinceStartup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+20]");
		float num4 = num3 + 0f;
		if (!(num4 > _loadOlderPrefetchDistance))
		{
			long? num5 = OldestServerFeedId();
			object obj5 = (??)num5 & 1;
			if (obj5 != null)
			{
				_loadingOlder = true;
				SetFooterActive(active: true);
				long? num6 = default(long?);
				long value = num6.Value;
				Actions.SafeInvoke(this.OnLoadOlderRequested, value);
			}
		}
	}

	private unsafe long? OldestServerFeedId()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0373: Expected O, but got I4
		//IL_001a: Expected O, but got I
		//IL_0026: Expected O, but got I
		//IL_0032: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_004f: Expected O, but got I
		//IL_0389: Expected I, but got O
		//IL_02fe: Expected I, but got O
		//IL_026f: Expected O, but got I
		//IL_02b0: Expected O, but got I4
		//IL_008d: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_00f0: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_0143: Expected I, but got O
		//IL_0200: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_023a: Expected I8, but got I
		//IL_0299: Expected I, but got O
		//IL_0196: Expected O, but got I
		//IL_019e: Expected I, but got O
		//IL_01ac: Expected O, but got Ref
		//IL_01e2: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
		bool flag = (nint)0 == 0;
		object obj3 = 152993792;
		List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj4 = (nint)0 + (nint)3968;
			object obj5 = (nint)0 + (nint)3232;
			object obj6 = (nint)0 + (nint)3184;
			obj3 = (nint)0 + (nint)3960;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanFeedListView)+98]");
			List<object>.Enumerator enumerator = ((List<object>)0).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			List<object>.Enumerator enumerator2 = enumerator3;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			object obj7 = default(object);
			object obj11 = default(object);
			while (true)
			{
				num = (nint)obj4;
				if (!enumerator4.MoveNext())
				{
					break;
				}
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-78+18]");
					ClanFeedModel clanFeedModel = (ClanFeedModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-78+18]");
					if ((nint)0 == 0)
					{
						continue;
					}
					bool flag2 = !clanFeedModel.Pinned;
					object obj8 = !flag2;
					if (obj8 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-78+18]");
					bool isSynthetic = ((ClanFeedModel)0).IsSynthetic;
					bool flag3 = !isSynthetic;
					object obj9 = !flag3;
					if (obj9 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
					bool flag4 = (nint)0 != 1;
					object obj10 = obj11;
					num = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-78+18]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-78+18]");
						if ((nint)0 == 0)
						{
							NullReferenceException ex = new NullReferenceException();
							num = unchecked((nint)null);
							goto IL_029e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+10]");
						obj10 = 0;
						num = (nint)obj5;
						long? num2 = (long?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
						long value = ((long?*)num2)->Value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+10]");
						bool flag5 = 0 >= value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+10]");
						obj11 = 0;
						if (flag5)
						{
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-78+18]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ stack_-78+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v15+10]");
						long? num3 = 0L;
						obj11 = obj10;
						enumerator2 = (List<object>.Enumerator)num3;
						continue;
					}
					NullReferenceException ex2 = new NullReferenceException();
				}
				else
				{
					NullReferenceException ex3 = new NullReferenceException();
				}
				goto IL_029e;
				IL_029e:
				enumerator5 = enumerator3;
				enumerator3 = (List<object>.Enumerator)0;
				goto IL_03d6;
			}
			enumerator4.Dispose();
			goto IL_0262;
		}
		goto IL_03d6;
		IL_03d6:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag6 = num != 1;
		NullReferenceException ex5 = ex4;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj3;
			enumerator5.Dispose();
			object obj14 = default(object);
			if (obj14 == null)
			{
				goto IL_0262;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			List<object>.Enumerator enumerator3 = (List<object>.Enumerator)obj14;
			ex5 = (NullReferenceException)(object)ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223DDB4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		long? result = default(long?);
		return result;
		IL_0262:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
		return (long?)(object)0;
	}

	public void OnOlderPageLoaded(int receivedCount, int requestedLimit)
	{
		_loadingOlder = false;
		SetFooterActive(active: false);
		if (receivedCount < requestedLimit)
		{
			_reachedFeedEnd = true;
		}
	}

	public void OnOlderPageFailed()
	{
		_loadingOlder = false;
		SetFooterActive(active: false);
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float olderRetryNotBefore = realtimeSinceStartup + 3f;
		_olderRetryNotBefore = olderRetryNotBefore;
	}

	public void ResetPagination(bool reachedEnd)
	{
		_loadingOlder = false;
		_reachedFeedEnd = reachedEnd;
		SetFooterActive(active: false);
	}

	private void SetFooterActive(bool active)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E877E]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object loadingOlderFooter;
		UnityEngine.Object loadingOlderFooter2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			loadingOlderFooter = _loadingOlderFooter;
			loadingOlderFooter2 = _loadingOlderFooter;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			loadingOlderFooter = _loadingOlderFooter;
			loadingOlderFooter2 = _loadingOlderFooter;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (loadingOlderFooter2 != null)
		{
			goto IL_0150;
		}
		return;
		IL_0150:
		GameObject gameObject = _loadingOlderFooter.gameObject;
		bool activeSelf = gameObject.activeSelf;
		if (active != activeSelf)
		{
			GameObject gameObject2 = _loadingOlderFooter.gameObject;
			gameObject2.SetActive(active);
		}
		return;
		IL_0091:
		bool flag3 = loadingOlderFooter != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_0150;
	}

	public ClanFeedListView()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		_stripByTemplate = (Dictionary<string, ClanEventStrip>)(object)dictionary;
		object obj2 = this + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_loadOlderPrefetchDistance = 600f;
		((UiListView<object, object>)(object)this)..ctor();
	}
}
