using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;

public abstract class JsonLeaderboardSource : BaseLeaderboardSource
{
	private sealed class <>c__DisplayClass0_0
	{
		public Action<LeaderboardModel> successCallback;

		public Action useCacheCallback;

		public Action<string> onError;

		internal void <Load>b__0(ApiResponseModel<List<LeaderBoardPlayer>> response)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_007c: Expected O, but got I
			//IL_0095: Expected O, but got I
			if (response.Succeeded)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (ApiResponseModel`1<System.Collections.Generic.List`1<LeaderBoardPlayer>>)+20]");
				if ((nint)0 == 1)
				{
					object key = "Drop Menu Toggle" + 1624;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (ApiResponseModel`1<System.Collections.Generic.List`1<LeaderBoardPlayer>>)+30]");
					object value;
					bool flag = ((Dictionary<object, object>)0).TryGetValue(key, out value);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (ApiResponseModel`1<System.Collections.Generic.List`1<LeaderBoardPlayer>>)+40]");
					LeaderboardModel arg = LeaderboardModel.FromList((List<LeaderBoardPlayer>)0, (string)value);
					Actions.SafeInvoke((Action<object>)successCallback, arg);
				}
				else
				{
					Actions.SafeInvoke(useCacheCallback);
				}
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				Actions.SafeInvoke((Action<object>)onError, errorMessage);
			}
		}
	}

	public override void Load(GameObject lifecycle, Action<LeaderboardModel> successCallback, Action useCacheCallback, Action<string> onError)
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
		//IL_0097: Expected I, but got O
		//IL_01b4: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020e: Expected O, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_024d: Expected O, but got I4
		//IL_028b: Expected O, but got I
		//IL_02a0: Expected O, but got I
		//IL_02bf: Expected I, but got O
		//IL_0152: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = obj2 + 16;
		obj4 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = useCacheCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		string webPath = GetWebPath();
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
			object obj8 = (nint)0 & (nint)1;
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 == null)
			{
				goto IL_010c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 == null)
			{
				goto IL_010c;
			}
		}
		goto IL_01ee;
		IL_01ee:
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 160;
		object obj12 = (nint)0 + (nint)2496;
		object obj13 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v20+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+28]");
		string text = (string)0 + webPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object defaultValue = (nint)0 + (nint)2000;
		string eTagKey = base.ETagKey;
		string value = Prefs.GetString(eTagKey, (string)defaultValue);
		object key = "HH:mm:ss.ffZ" + 3384;
		object obj17 = (nint)0 + (nint)208;
		dictionary.Add(key, value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3106400");
		return;
		IL_010c:
		_ = 1;
		goto IL_01ee;
	}

	protected abstract string GetWebPath();
}
