using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public sealed class ClaimAchievementRequest : BaseWebRequest<bool>
{
	private readonly string <AchievementId>k__BackingField;

	private readonly int <LevelId>k__BackingField;

	protected override HttpMethod Method => HttpMethod.POST;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "alignContent" + 720;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			return backendURL + (string)obj2;
		}
	}

	private string AchievementId => <AchievementId>k__BackingField;

	private int LevelId => <LevelId>k__BackingField;

	protected override Dictionary<string, object> QueryParams
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0035: Expected O, but got I
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<object, object> dictionary = default(Dictionary<object, object>);
			dictionary..ctor();
			if (dictionary != null)
			{
				object key = "___# Content push apply failed [{0}]: {1}" + 2928;
				object obj2 = (nint)0 + (nint)4088;
				object key2 = "java.io.FileOutputStream" + 2448;
				dictionary.Add(key, <AchievementId>k__BackingField);
				object obj3 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object value = default(object);
				dictionary.Add(key2, value);
				return (Dictionary<string, object>)(object)dictionary;
			}
			return (Dictionary<string, object>)(object)new NullReferenceException();
		}
	}

	public ClaimAchievementRequest(string achievementId, int levelId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		object obj = this + 48;
		obj = achievementId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
