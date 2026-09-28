using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;

public class SFSRefreshStatusMonitor : Singleton<SFSRefreshStatusMonitor>
{
	protected override void OnAwake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object methodName = "Cannot populate JSON object onto type '{0}'." + 2472;
		object methodName2 = "Cannot populate JSON object onto type '{0}'." + 2456;
		GameObject gameObject = base.gameObject;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
		InvokeRepeating((string)methodName, 60f, 60f);
		InvokeRepeating((string)methodName2, 60f, 60f);
	}

	private void OnApplicationFocus(bool _)
	{
		CheckForGhostUser();
	}

	private void OnApplicationPause(bool _)
	{
		CheckForGhostUser();
	}

	private void CheckForGhostUser()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_028d: Expected O, but got I
		//IL_02b7: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_0356: Expected O, but got I4
		//IL_0300: Expected O, but got I4
		//IL_039c: Expected O, but got I4
		//IL_0103: Expected O, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_024d: Expected O, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71CF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2216;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v13+E4]");
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
			object obj4 = (nint)0 + (nint)2216;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v13+E4]");
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
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00b8;
		}
		goto IL_030e;
		IL_036c:
		_ = 1;
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v37+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		object obj13 = obj10;
		if (obj12 != null)
		{
			goto IL_01ca;
		}
		goto IL_03b2;
		IL_01ca:
		object obj14 = typeof(RegisteredWaitHandle) + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "___# Content push apply failed [{0}]: {1}" + 88;
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj15 = typeof(DataRelation) + 856;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v22+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		object message = text;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.LogError(message);
		SFS.ReestablishConnection();
		return;
		IL_031c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj18 = (nint)0 & (nint)1;
		bool flag6 = obj18 == null;
		object obj19 = !flag6;
		obj11 = obj2;
		if (obj19 != null)
		{
			goto IL_018d;
		}
		goto IL_036c;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_030e;
		IL_030e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_031c;
		IL_00b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v49+38]");
		if ((nint)0 == 7)
		{
			bool isConnected = SFS.IsConnected;
			bool flag7 = !isConnected;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				obj2 = typeof(RegisteredWaitHandle) + 3136;
				ex = (NullReferenceException)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v9 (System.NullReferenceException)+E4]");
				if ((nint)0 == 0)
				{
					goto IL_031c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
				object obj21 = (nint)0 & (nint)1;
				bool flag8 = obj21 == null;
				obj11 = obj2;
				if (!flag8)
				{
					goto IL_018d;
				}
				goto IL_036c;
			}
			return;
		}
		return;
		IL_018d:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v37+E4]");
		bool flag9 = (nint)0 == 0;
		obj13 = obj10;
		obj11 = obj2;
		if (!flag9)
		{
			goto IL_01ca;
		}
		goto IL_03b2;
		IL_03b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj11;
		goto IL_01ca;
	}

	public void CheckTicketsAndRefresh()
	{
		//IL_005e: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_0145: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_01c7: Expected O, but got I
		if (!SFS.IsConnected)
		{
			return;
		}
		User mySelf = SFS.MySelf;
		if (mySelf == null)
		{
			return;
		}
		User mySelf2 = SFS.MySelf;
		List<TicketRecord> allTickets = SFSKammelnaUserExtensions.GetAllTickets(mySelf2);
		bool flag = allTickets == null;
		object obj = 0;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			List<object>.Enumerator enumerator = ((List<object>)(object)allTickets).GetEnumerator();
			object obj2 = (nint)0 + (nint)2352;
			object obj3 = typeof(DataRelation) + 712;
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj4 = default(object);
			while (true)
			{
				obj = obj2;
				if (enumerator2.MoveNext())
				{
					if (obj4 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ stack_-58+14]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ stack_-58+18]");
					if (num == 0)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ stack_-58+20]");
					object obj5 = (nint)0 & (nint)1;
					if (obj5 == null)
					{
						continue;
					}
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v31+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime now = DateTime.Now;
					object obj8 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v35+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ stack_-58+28]");
					if (!((DateTime)0 < now))
					{
						continue;
					}
					SFS.SendRefreshStatus();
				}
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag4 = (nint)obj != 1;
		NullReferenceException ex3 = ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj10 = (nint)0 + (nint)2344;
			obj = obj10;
			enumerator3.Dispose();
			object obj11 = default(object);
			if (obj11 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj11;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2239990");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void CheckMuteStatusAndRefresh()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (!SFS.IsConnected)
		{
			return;
		}
		User mySelf = SFS.MySelf;
		if (mySelf == null)
		{
			return;
		}
		User mySelf2 = SFS.MySelf;
		MuteStatus muteStatus = SFSKammelnaUserExtensions.GetMuteStatus(mySelf2);
		if (muteStatus == MuteStatus.MutedByAdmin)
		{
			User mySelf3 = SFS.MySelf;
			DateTime? mutedUntil = SFSKammelnaUserExtensions.GetMutedUntil(mySelf3);
			object obj = (??)mutedUntil & 1;
			if (obj == null)
			{
				SFS.SendRefreshStatus();
			}
		}
	}

	public SFSRefreshStatusMonitor()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71D2]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2160;
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
			object obj4 = (nint)0 + (nint)2160;
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
}
