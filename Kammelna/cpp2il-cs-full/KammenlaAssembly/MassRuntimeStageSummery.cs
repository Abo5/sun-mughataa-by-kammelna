using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;

[Serializable]
public class MassRuntimeStageSummery
{
	private int <ParticipantsCount>k__BackingField;

	public int ParticipantsCount
	{
		get
		{
			return <ParticipantsCount>k__BackingField;
		}
		set
		{
			<ParticipantsCount>k__BackingField = value;
		}
	}

	public static MassRuntimeStageSummery FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3776;
		object varName = "setMimeType" + 3496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int num = SFSExtensions.Get(data, (string)varName, 0);
		if (obj2 != null)
		{
			return (MassRuntimeStageSummery)obj2;
		}
		return (MassRuntimeStageSummery)(object)new NullReferenceException();
	}
}
