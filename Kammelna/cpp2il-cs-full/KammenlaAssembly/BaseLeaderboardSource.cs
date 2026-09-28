using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;

public abstract class BaseLeaderboardSource : ILeaderboardSource
{
	public abstract string Name { get; }

	public abstract string Title { get; }

	public abstract bool IsLive { get; }

	public abstract bool IsGameDependent { get; }

	private string ETagKey
	{
		get
		{
			//IL_00f3: Expected I, but got O
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0066: Expected O, but got I4
			nint num = (nint)this;
			if (IsGameDependent)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
				object format = "Drop Menu Toggle" + 1648;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object name = Name;
				object arg = default(object);
				return string.Format((string)format, arg, name);
			}
			object obj5 = "Drop Menu Toggle" + 1632;
			string name2 = Name;
			return (string)obj5 + name2;
		}
	}

	public abstract void Load(GameObject lifecycle, Action<LeaderboardModel> successCallback, Action useCacheCallback, Action<string> onError);

	public abstract void GetMyRanking(Action<LeaderBoardPlayer> callback);

	public string GetETag()
	{
		//IL_000c: Expected O, but got I
		object defaultValue = (nint)0 + (nint)2000;
		string eTagKey = ETagKey;
		return Prefs.GetString(eTagKey, (string)defaultValue);
	}

	public void SetETag(string newETag)
	{
		string eTagKey = ETagKey;
		Prefs.SetString(eTagKey, newETag);
	}

	public virtual string GetCacheFilePath()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01b7: Expected I, but got O
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_015f: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		nint num = (nint)this;
		bool isGameDependent = IsGameDependent;
		object obj2 = obj;
		if (isGameDependent)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1344;
			string cachePath = Config.CachePath;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object name = Name;
			object arg = default(object);
			return string.Format((string)format, cachePath, arg, name);
		}
		object obj8 = "java.io.FileOutputStream" + 1968;
		object obj9 = ", stale={0}" + 2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath2 = Config.CachePath;
		string name2 = Name;
		return cachePath2 + (string)obj8 + name2 + (string)obj9;
	}
}
