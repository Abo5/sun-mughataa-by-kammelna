using System;
using System.Data;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;
using Sfs2X.Entities;

public class TournamentDataHolder : IGridViewItemData<int>, IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private string <template>k__BackingField;

	private int <columns>k__BackingField;

	public readonly Room tournamentRoom;

	public readonly TournamentRoomModel roomModel;

	private readonly string <titleText>k__BackingField;

	private readonly int <tournamentsCount>k__BackingField;

	public int index => <index>k__BackingField;

	public string template
	{
		get
		{
			return <template>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int columns
	{
		get
		{
			return <columns>k__BackingField;
		}
		private set
		{
			<columns>k__BackingField = value;
		}
	}

	public string titleText => <titleText>k__BackingField;

	public int tournamentsCount => <tournamentsCount>k__BackingField;

	public TournamentDataHolder(Room room, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 40;
		obj = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetTemplate();
	}

	public TournamentDataHolder(TournamentRoomModel model, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 48;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetTemplate();
	}

	public TournamentDataHolder(string title, int count, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 56;
		obj = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<tournamentsCount>k__BackingField = count;
		SetTemplate();
	}

	public TournamentDataHolder(int i)
	{
		<index>k__BackingField = i;
		SetTemplate();
	}

	private unsafe void SetTemplate()
	{
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_032f: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected O, but got Unknown
		//IL_071c: Expected I4, but got I8
		//IL_00cd: Expected I, but got O
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_03ab: Expected O, but got I4
		//IL_0561: Expected O, but got I
		//IL_03db: Expected I, but got O
		//IL_0406: Expected O, but got I
		//IL_0420: Expected O, but got I4
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_06ae: Expected O, but got I
		//IL_06c3: Expected I4, but got I8
		//IL_06cb: Expected O, but got Ref
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_02f4: Expected O, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_0786: Expected native int or pointer, but got O
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected O, but got Unknown
		//IL_075c: Expected O, but got I
		//IL_0775: Expected O, but got Ref
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		object obj;
		object obj3;
		if (tournamentRoom != null)
		{
			obj = this + 48;
			object obj2 = obj;
			bool flag = obj == null;
			obj3 = obj;
			if (!flag)
			{
				goto IL_003d;
			}
			goto IL_0085;
		}
		object obj4;
		if (<titleText>k__BackingField != null)
		{
			obj4 = "ThisIsFakeReceiptData" + 1432;
		}
		else
		{
			obj = this + 48;
			object obj2 = obj;
			bool flag2 = obj == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_003d;
			}
			obj4 = "Material with texture name \"" + 2520;
		}
		object obj6 = this + 24;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = -1;
		goto IL_0614;
		IL_0198:
		DateTime now = DateTime.Now;
		DateTime dateTime;
		bool flag3 = dateTime <= now;
		TournamentData tournamentData;
		object obj7;
		int num2;
		object obj8;
		TournamentStatus tournamentStatus;
		if (tournamentData.<Type>k__BackingField > TournamentType.Private)
		{
			if (tournamentData.<Type>k__BackingField != TournamentType.Mass)
			{
				if (tournamentData.<Type>k__BackingField != TournamentType.Official)
				{
					if (tournamentData.<Type>k__BackingField != TournamentType.OfficialMonthly)
					{
						goto IL_02d9;
					}
					obj7 = "ThisIsFakeReceiptData" + 1408;
					num2 = 0;
				}
				else
				{
					if (!flag3)
					{
						obj8 = "ThisIsFakeReceiptData" + 1416;
						num2 = 0;
						goto IL_0748;
					}
					if (tournamentData.<IsCluster>k__BackingField)
					{
						object obj9 = (??)tournamentData.<ClusterCapacity>k__BackingField & 1;
						if (obj9 != null)
						{
							if (tournamentStatus == TournamentStatus.Running)
							{
								obj7 = "ThisIsFakeReceiptData" + 1400;
								num2 = 0;
							}
							else
							{
								obj7 = "ThisIsFakeReceiptData" + 1384;
								num2 = 0;
							}
						}
						else
						{
							obj7 = "ThisIsFakeReceiptData" + 1392;
							num2 = 0;
						}
					}
					else
					{
						if (tournamentStatus != TournamentStatus.Scheduled)
						{
							obj8 = "ThisIsFakeReceiptData" + 1368;
							num2 = 0;
							goto IL_0748;
						}
						obj7 = "ThisIsFakeReceiptData" + 1376;
						num2 = 0;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EB6]");
				object obj10 = (nint)0 & (nint)1;
				bool flag4 = obj10 == null;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					_ = 1;
					if (tournamentData.<Type>k__BackingField != TournamentType.Mass)
					{
						goto IL_05a0;
					}
				}
				object obj12 = (??)tournamentData.<SubType>k__BackingField & 1;
				if (obj12 == null)
				{
					goto IL_05a0;
				}
				obj7 = "ThisIsFakeReceiptData" + 1360;
				num2 = 0;
			}
		}
		else
		{
			if (tournamentData.<Type>k__BackingField != TournamentType.Public)
			{
				if (tournamentData.<Type>k__BackingField != TournamentType.Private)
				{
					goto IL_02d9;
				}
			}
			else
			{
				object obj13 = (nint)0 + (nint)432;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304DE84");
				object obj14 = default(object);
				if (obj14 != null)
				{
					obj7 = "ThisIsFakeReceiptData" + 1336;
					num2 = 0;
					goto IL_069a;
				}
			}
			obj7 = "ThisIsFakeReceiptData" + 1424;
			num2 = 0;
		}
		goto IL_069a;
		IL_0614:
		<columns>k__BackingField = num;
		return;
		IL_077a:
		(object, int) tuple;
		object item;
		int item2;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (item, item2));
		object obj16 = default(object);
		object obj15 = obj16;
		num = num2;
		goto IL_06d0;
		IL_06d0:
		object obj17 = this + 24;
		obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0614;
		IL_05a0:
		obj8 = "ThisIsFakeReceiptData" + 1352;
		num2 = 0;
		goto IL_0748;
		IL_0171:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime <AvailabilityTime>k__BackingField;
		dateTime = <AvailabilityTime>k__BackingField;
		TournamentStatus tournamentStatus2;
		tournamentStatus = tournamentStatus2;
		TournamentData tournamentData2;
		tournamentData = tournamentData2;
		goto IL_0198;
		IL_003d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v57+18]");
		tournamentData2 = (TournamentData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v57+18]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		obj3 = obj;
		if (obj18 == null)
		{
			goto IL_0085;
		}
		goto IL_00e3;
		IL_0085:
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(tournamentRoom);
		object obj20;
		if (tournamentInfo != null)
		{
			object obj2 = obj3;
			bool flag6 = obj3 == null;
			nint num3 = unchecked((nint)null);
			tournamentData2 = tournamentInfo;
			if (!flag6)
			{
				goto IL_00e3;
			}
			TournamentStatus tournamentStatus3 = SFSKammelnaRoomExtensions.GetTournamentStatus(tournamentRoom);
			object obj19 = typeof(DataRelation) + 712;
			dateTime = tournamentInfo.<AvailabilityTime>k__BackingField;
			obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v35+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			tournamentStatus = tournamentStatus3;
			tournamentData = tournamentInfo;
			if (obj21 == null)
			{
				<AvailabilityTime>k__BackingField = tournamentInfo.<AvailabilityTime>k__BackingField;
				num3 = unchecked((nint)null);
				tournamentStatus2 = tournamentStatus3;
				tournamentData2 = tournamentInfo;
				goto IL_0171;
			}
			goto IL_0198;
		}
		return;
		IL_069a:
		item = obj7;
		object obj22 = (nint)0 + (nint)3928;
		object obj23 = obj22;
		item2 = -1;
		tuple = ((object, int))(&obj16);
		goto IL_077a;
		IL_02d9:
		global::<PrivateImplementationDetails>.ThrowSwitchExpressionException(tournamentData);
		item2 = 0;
		obj15 = 0;
		num = 0;
		goto IL_06d0;
		IL_0748:
		item = obj8;
		object obj24 = (nint)0 + (nint)3928;
		obj23 = obj24;
		item2 = 1;
		tuple = ((object, int))(&obj16);
		goto IL_077a;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v57+20]");
		tournamentStatus2 = TournamentStatus.Scheduled;
		object obj25 = typeof(DataRelation) + 712;
		<AvailabilityTime>k__BackingField = tournamentData2.<AvailabilityTime>k__BackingField;
		obj20 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v35+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		dateTime = tournamentData2.<AvailabilityTime>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v57+20]");
		tournamentStatus = TournamentStatus.Scheduled;
		tournamentData = tournamentData2;
		if (obj26 == null)
		{
			goto IL_0171;
		}
		goto IL_0198;
	}
}
