using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class ClanEmblemLoader : MonoBehaviour
{
	private sealed class <>c__DisplayClass19_0
	{
		public ClanEmblemLoader <>4__this;

		public int clanId;

		public FileInfoModel emblem;

		public int retriesLeft;

		internal void <RequestEmblem>b__0(bool success)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ff: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0222: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8764]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
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
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = <>4__this;
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
			ClanEmblemLoader clanEmblemLoader = <>4__this;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				if (clanEmblemLoader.target == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = clanEmblemLoader.target == null;
				bool flag6 = !flag5;
				object obj12 = !flag6;
				if (obj12 != null)
				{
					return;
				}
			}
			ClanEmblemLoader clanEmblemLoader2 = <>4__this;
			if (success && clanEmblemLoader2._loadedClanId == clanId)
			{
				clanEmblemLoader2.ShowPlaceholder(show: false);
			}
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

		internal void <RequestEmblem>b__1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f8: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8765]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
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
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (obj6 != null)
			{
				goto IL_0150;
			}
			return;
			IL_0150:
			ClanEmblemLoader clanEmblemLoader = <>4__this;
			if (clanEmblemLoader._loadedClanId == clanId)
			{
				int num = retriesLeft - 1;
				clanEmblemLoader.RequestEmblem(clanEmblemLoader._loadedClanId, emblem, num);
			}
			return;
			IL_0091:
			bool flag3 = obj5 != null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				return;
			}
			goto IL_0150;
		}
	}

	private const int EmblemLoadMaxRetries = 5;

	private const float EmblemLoadRetryDelay = 1f;

	private Image target;

	private Image placeholder;

	private ClansSerializedUtils clanUtils;

	private bool autoLoadMyClan;

	private bool retryUntilLoaded;

	private int _loadedClanId = -2147483648;

	private ClanModel _loadedModel;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_0162: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E875E]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 32;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 32;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		obj4 = obj8;
		if (obj10 != null)
		{
			return;
		}
		goto IL_0178;
		IL_0178:
		object obj11 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Image image = default(Image);
		target = image;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00a0:
		if ((bool)obj5)
		{
			return;
		}
		goto IL_0178;
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0048: Expected I, but got O
		//IL_006e: Expected I, but got O
		if (autoLoadMyClan)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
			object obj2 = (nint)0 + (nint)928;
			ReloadMyClan();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			ClanServerConnector.OnMyMembershipChanged -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj2);
			ClanServerConnector.OnMyMembershipChanged += action2;
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0196: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_013d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+30]");
		Delegate obj6 = (Delegate)0;
		bool flag;
		Delegate obj12 = default(Delegate);
		do
		{
			Delegate obj7 = Delegate.Remove(obj6, action);
			Delegate obj8;
			Delegate obj9;
			if ((object)obj7 != null)
			{
				obj8 = (Delegate)obj;
				if (obj7 != obj)
				{
					obj9 = null;
					throw new InvalidCastException();
				}
			}
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X9_v5+B8]");
			object obj11 = (nint)0 + (nint)48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag = (object)obj12 == obj6;
			obj6 = obj12;
			obj8 = obj7;
			obj9 = obj12;
		}
		while (!flag);
		if (autoLoadMyClan)
		{
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)928;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj14);
			ClanServerConnector.OnMyMembershipChanged -= action2;
		}
	}

	public void Load(ClanModel clan)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_02b2: Expected I4, but got I8
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_018c: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_022c: Expected O, but got I4
		object obj = this + 64;
		obj = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UnityEngine.Object obj6;
		if (clan != null)
		{
			object obj2 = 152993792;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88AF]");
			object obj4 = (nint)0 & (nint)1;
			UnityEngine.Object obj7;
			if (obj4 != null)
			{
				_loadedClanId = clan.ClanId;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				obj6 = target;
				obj7 = target;
				if (!flag)
				{
					goto IL_00da;
				}
			}
			else
			{
				_ = 1;
				_loadedClanId = clan.ClanId;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj6 = target;
				obj7 = target;
				if (obj8 != null)
				{
					goto IL_00da;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)obj7)
			{
				goto IL_01e3;
			}
			return;
		}
		_loadedClanId = -1;
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = target;
			bool flag4 = !flag3;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!target)
			{
				return;
			}
		}
		ShowPlaceholder(show: true);
		return;
		IL_01e3:
		ShowPlaceholder(show: true);
		if (clan.Emblem != null)
		{
			bool flag5 = !retryUntilLoaded;
			object obj12 = !flag5;
			object obj13 = ~obj12;
			int retriesLeft = ((obj13 == null) ? 5 : 0);
			RequestEmblem(clan.ClanId, clan.Emblem, retriesLeft);
		}
		return;
		IL_00da:
		bool flag6 = obj6;
		bool flag7 = !flag6;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			return;
		}
		goto IL_01e3;
	}

	public void Load(int clanId, FileInfoModel emblem)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88AF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			_loadedClanId = clanId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = target;
			obj6 = target;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			_loadedClanId = clanId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = target;
			obj6 = target;
			if (obj7 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_0162;
		}
		return;
		IL_0162:
		ShowPlaceholder(show: true);
		if (emblem != null)
		{
			bool flag3 = !retryUntilLoaded;
			object obj8 = !flag3;
			object obj9 = ~obj8;
			int retriesLeft = ((obj9 == null) ? 5 : 0);
			RequestEmblem(clanId, emblem, retriesLeft);
		}
		return;
		IL_009b:
		bool flag4 = obj5;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0162;
	}

	public void LoadMyClan()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_0185: Expected O, but got I4
		//IL_0330: Expected I, but got O
		//IL_01bd: Expected O, but got I4
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_060a: Expected O, but got I
		//IL_061a: Expected O, but got I
		//IL_0358: Expected O, but got I
		//IL_0223: Expected O, but got I4
		//IL_0249: Expected I, but got O
		//IL_03e1: Expected O, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_05c9: Expected O, but got I
		//IL_05d9: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_040f: Expected I, but got O
		//IL_0637: Expected O, but got I
		//IL_0647: Expected O, but got I
		//IL_030e: Expected O, but got I4
		//IL_0437: Expected O, but got I
		//IL_0460: Expected O, but got I4
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0527: Expected O, but got I4
		//IL_04cb: Expected O, but got I4
		//IL_0550: Expected O, but got I
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0589: Expected O, but got I
		//IL_0597: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88B0]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v68+E4]");
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
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v68+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_04de:
		throw new InvalidCastException();
		IL_0140:
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)920;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag3 = localUser == null;
		object obj10 = 0;
		object obj19;
		Delegate obj20;
		if (!flag3)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v33+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
			bool flag5 = clanId <= 0;
			obj10 = 0;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj9);
				object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v26+B8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v27+30]");
				Delegate obj16 = (Delegate)0;
				Delegate obj23 = default(Delegate);
				Action action2 = default(Action);
				Delegate obj30 = default(Delegate);
				Action<object> action3 = default(Action<object>);
				ClanServerConnector clanServerConnector = default(ClanServerConnector);
				while (true)
				{
					Delegate obj17 = Delegate.Remove(obj16, action);
					if ((object)obj17 != null)
					{
						Delegate obj18 = (Delegate)obj8;
						if (obj17 != obj8)
						{
							obj19 = 0;
							obj20 = null;
							break;
						}
					}
					object obj21 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X9_v12+B8]");
					object obj22 = (nint)0 + (nint)48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag6 = (object)obj23 == obj16;
					obj16 = obj23;
					if (!flag6)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					action2..ctor(this, (IntPtr)obj9);
					object obj24 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v32+B8]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v33+30]");
					Delegate obj26 = (Delegate)0;
					while (true)
					{
						Delegate obj27 = Delegate.Combine(obj26, action2);
						Delegate obj18;
						if ((object)obj27 != null)
						{
							obj18 = (Delegate)obj8;
							bool flag7 = obj27 == obj8;
							obj19 = 0;
							obj20 = null;
							if (!flag7)
							{
								break;
							}
						}
						object obj28 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X9_v17+B8]");
						object obj29 = (nint)0 + (nint)48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag8 = (object)obj30 == obj26;
						obj26 = obj30;
						obj19 = 0;
						obj20 = obj30;
						obj18 = obj27;
						if (!flag8)
						{
							continue;
						}
						object obj31 = typeof(Queue<string>) + 728;
						object obj32 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v6+E4]");
						bool flag9 = (nint)0 == 0;
						object obj33 = !flag9;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj34 = (nint)0 + (nint)1976;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						object obj35 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj36 = (nint)0 + (nint)912;
						action3..ctor((object)this, (IntPtr)obj36);
						clanServerConnector.GetMyClan(action3);
						return;
					}
					break;
				}
				goto IL_04de;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj9);
		object obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1376;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v18+B8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v19+30]");
		Delegate obj40 = (Delegate)0;
		Delegate obj44 = default(Delegate);
		while (true)
		{
			Delegate obj41 = Delegate.Remove(obj40, action4);
			if ((object)obj41 != null)
			{
				Delegate obj18 = (Delegate)obj8;
				if (obj41 != obj8)
				{
					break;
				}
			}
			object obj42 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X9_v7+B8]");
			object obj43 = (nint)0 + (nint)48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag10 = (object)obj44 == obj40;
			obj40 = obj44;
			if (!flag10)
			{
				continue;
			}
			ShowPlaceholder(show: true);
			return;
		}
		obj19 = 0;
		obj20 = null;
		goto IL_04de;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag11 = (object)sessionModel == null;
		object obj45 = !flag11;
		if (obj45 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	public void OpenCardPopup()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		//IL_007e: Expected O, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00c5: Expected I, but got O
		//IL_00db: Expected O, but got I
		if (_loadedModel != null)
		{
			clanUtils.OpenClanCardInfoPopup(_loadedModel);
			return;
		}
		object obj = typeof(Queue<string>) + 728;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)904;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CD1FBC");
	}

	private void OnMyMembershipChanged(ClanUserModel membership)
	{
		ReloadMyClan();
	}

	private void OnEmblemTierActivated()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0194: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8760]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v14+E4]");
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
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		if (localUser != null)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int clanId = SFSKammelnaUserExtensions.GetClanId(localUser2);
			if (clanId >= 1 && _loadedClanId == clanId)
			{
				LoadMyClan();
			}
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void ReloadMyClan()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0225: Expected I4, but got I8
		//IL_0194: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8761]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
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
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int num;
		if (localUser != null)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			num = SFSKammelnaUserExtensions.GetClanId(localUser2);
			if (num == _loadedClanId)
			{
				return;
			}
		}
		else
		{
			bool flag4 = 4294967295L == _loadedClanId;
			num = -1;
			if (flag4)
			{
				return;
			}
		}
		_loadedClanId = num;
		LoadMyClan();
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void RequestEmblem(int clanId, FileInfoModel emblem, int retriesLeft)
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
		//IL_00a0: Expected I, but got O
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0138: Expected I, but got O
		//IL_0167: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)3480;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = emblem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj4);
		Image img = target;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+18]");
		UIExtensions.LoadClanEmblem(img, 0, (FileInfoModel)obj6, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+28]");
		if ((nint)0 >= (nint)1)
		{
			object obj7 = typeof(SqlSingle[]) + 2376;
			object obj8 = (nint)0 + (nint)3488;
			object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action2 = default(Action);
			action2..ctor(obj2, (IntPtr)obj8);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action2);
		}
	}

	private void ShowPlaceholder(bool show)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8763]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = target;
			obj6 = target;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = target;
			obj6 = target;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01d2;
		IL_0132:
		placeholder.enabled = show;
		return;
		IL_010c:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_0132;
		}
		return;
		IL_023b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0132;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_01d2;
		IL_01d2:
		flag5 = (byte)((show ? 1u : 0u) ^ 1u) != 0;
		target.enabled = flag5;
		obj8 = placeholder;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		obj9 = placeholder;
		if (obj13 != null)
		{
			goto IL_010c;
		}
		goto IL_023b;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = placeholder;
		obj9 = placeholder;
		if (!flag11)
		{
			goto IL_010c;
		}
		goto IL_023b;
	}

	private void <OpenCardPopup>b__15_0(ClanModel model)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		object obj = this + 64;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-10]");
		((ClansSerializedUtils)0).OpenClanCardInfoPopup((ClanModel)obj);
	}
}
