using System;
using System.Data;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities.Data;

public class MassTournamentPlayerState
{
	private bool <IsRegistered>k__BackingField;

	private int <LastStageReached>k__BackingField;

	private int <TriesLeft>k__BackingField;

	private DateTime <NextTicketTime>k__BackingField;

	private int <ChampionshipPoints>k__BackingField;

	private MassEventNextStageEligibility <NextStageEligibility>k__BackingField;

	private string <UniqueId>k__BackingField;

	private string <EventBio>k__BackingField;

	public bool HasTries
	{
		get
		{
			//IL_006a: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = <TriesLeft>k__BackingField < 0;
			bool flag2 = <TriesLeft>k__BackingField == 0;
			int num = <TriesLeft>k__BackingField ^ <TriesLeft>k__BackingField;
			int num2 = <TriesLeft>k__BackingField & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public bool IsRegistered
	{
		get
		{
			return <IsRegistered>k__BackingField;
		}
		set
		{
			<IsRegistered>k__BackingField = value;
		}
	}

	public int LastStageReached
	{
		get
		{
			return <LastStageReached>k__BackingField;
		}
		set
		{
			<LastStageReached>k__BackingField = value;
		}
	}

	public int TriesLeft
	{
		get
		{
			return <TriesLeft>k__BackingField;
		}
		set
		{
			<TriesLeft>k__BackingField = value;
		}
	}

	public DateTime NextTicketTime
	{
		get
		{
			return <NextTicketTime>k__BackingField;
		}
		set
		{
			<NextTicketTime>k__BackingField = value;
		}
	}

	public int ChampionshipPoints
	{
		get
		{
			return <ChampionshipPoints>k__BackingField;
		}
		set
		{
			<ChampionshipPoints>k__BackingField = value;
		}
	}

	public MassEventNextStageEligibility NextStageEligibility
	{
		get
		{
			return <NextStageEligibility>k__BackingField;
		}
		set
		{
			<NextStageEligibility>k__BackingField = value;
		}
	}

	public string UniqueId
	{
		get
		{
			return <UniqueId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string EventBio
	{
		get
		{
			return <EventBio>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool ShouldRefreshTickets(MassEventStageViewModel stage)
	{
		//IL_013c: Expected I4, but got O
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		if (<IsRegistered>k__BackingField)
		{
			if (stage == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			if (<LastStageReached>k__BackingField >= stage.<Id>k__BackingField)
			{
				int num = <TriesLeft>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stage @ X1 (Server.Models.MassEventStageViewModel)+24]");
				if ((nint)num == 0)
				{
					object obj = (??)stage.<MaxTrails>k__BackingField & 1;
					if (obj != null)
					{
						goto IL_009e;
					}
				}
				object obj2 = typeof(DataRelation) + 712;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v10+E4]");
				if ((nint)0 != 0)
				{
					return <NextTicketTime>k__BackingField < stage.<FinishDate>k__BackingField;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return <NextTicketTime>k__BackingField < stage.<FinishDate>k__BackingField;
			}
		}
		goto IL_009e;
		IL_009e:
		return false;
	}

	public static MassTournamentPlayerState FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3824;
		object varName = "https://www.kammelna.com/Home/Terms" + 2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = SFSExtensions.Get(data, (string)varName, defaultValue: false);
		if (obj2 != null)
		{
			object varName2 = "startPosition" + 3384;
			object obj3 = typeof(DataRelation) + 712;
			object varName3 = "not" + 312;
			object varName4 = "java.io.FileOutputStream" + 3480;
			object varName5 = "m_StencilDeferredPS" + 2632;
			object obj4 = (nint)0 + (nint)136;
			object defaultValue = (nint)0 + (nint)2000;
			int num = SFSExtensions.Get(data, (string)varName2, 0);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			DateTime? defaultValue2 = now;
			DateTime? dateTime = SFSExtensions.Get(data, (string)varName3, defaultValue2);
			DateTime? dateTime2 = default(DateTime?);
			DateTime value = dateTime2.Value;
			int num2 = SFSExtensions.Get(data, (string)varName4, 0);
			int num3 = SFSExtensions.Get(data, (string)varName5, 0);
			object obj7 = "destinationTimeZone" + 2432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
			object varName6 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1280;
			string text = SFSExtensions.Get(data, (string)varName6, (string)defaultValue);
			object obj8 = obj2 + 48;
			obj8 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object varName7 = "destinationTimeZone" + 1296;
			string text2 = SFSExtensions.Get(data, (string)varName7, (string)defaultValue);
			object obj9 = obj2 + 56;
			obj9 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (MassTournamentPlayerState)obj2;
		}
		return (MassTournamentPlayerState)(object)new NullReferenceException();
	}
}
