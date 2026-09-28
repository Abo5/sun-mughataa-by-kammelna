using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;

public class MiniGameRewardDescription
{
	private class Constants
	{
		public const string Name = "name";

		public const string Value = "value";

		public const string Type = "type";

		public const string Size = "size";

		public const string MinRank = "min_rank";

		public const string MaxRank = "max_rank";
	}

	private string <Name>k__BackingField;

	private int <Value>k__BackingField;

	private ProjectConditions <Conditions>k__BackingField;

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int Value
	{
		get
		{
			return <Value>k__BackingField;
		}
		private set
		{
			<Value>k__BackingField = value;
		}
	}

	public ProjectConditions Conditions
	{
		get
		{
			return <Conditions>k__BackingField;
		}
		private set
		{
			<Conditions>k__BackingField = value;
		}
	}

	public static MiniGameRewardDescription FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 816;
		object varName = "m_StencilDeferredPS" + 2872;
		object defaultValue = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		string text = SFSExtensions.Get(data, (string)varName, (string)defaultValue);
		if (obj2 != null)
		{
			object varName2 = "utf-32" + 208;
			object obj3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
			object obj4 = (nint)0 + (nint)152;
			object obj5 = "m_StencilDeferredPS" + 904;
			object obj6 = (nint)0 + (nint)160;
			object obj7 = "m_StencilDeferredPS" + 1784;
			object varName3 = "setMimeType" + 2664;
			object obj8 = obj2 + 16;
			obj8 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = SFSExtensions.Get(data, (string)varName2, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
			int size = SFSExtensions.Get(data, (string)varName3, 0);
			ProjectType type = default(ProjectType);
			Rank maxRank = default(Rank);
			Rank minRank = default(Rank);
			ProjectConditions projectConditions = new ProjectConditions(type, maxRank, minRank, size);
			return (MiniGameRewardDescription)obj2;
		}
		return (MiniGameRewardDescription)(object)new NullReferenceException();
	}
}
