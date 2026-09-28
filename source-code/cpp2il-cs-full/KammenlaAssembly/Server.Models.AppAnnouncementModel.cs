using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using UnityEngine.Purchasing.Telemetry;
using Util.Extensions;

namespace Server.Models;

[Serializable]
public class AppAnnouncementModel : IClientFilterable
{
	private int <Id>k__BackingField;

	private string <Name>k__BackingField;

	private GameCategory <Game>k__BackingField;

	private AppAnnouncementType <Type>k__BackingField;

	private DateTime <ShowDate>k__BackingField;

	private DateTime <EndDate>k__BackingField;

	private TimeSpan? <DayCycleStart>k__BackingField;

	private TimeSpan? <DayCycleEnd>k__BackingField;

	private RoutingCommand <RoutingCommand>k__BackingField;

	private string <RoutingParam>k__BackingField;

	private List<AppAnnouncementTimingViewModel> <AnnouncementTimings>k__BackingField;

	private FileInfoModel <ButtonImage>k__BackingField;

	private List<ClientFilter> <Filters>k__BackingField;

	public int Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		set
		{
			<Id>k__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public GameCategory Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
		}
	}

	public AppAnnouncementType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	public DateTime ShowDate
	{
		get
		{
			return <ShowDate>k__BackingField;
		}
		set
		{
			<ShowDate>k__BackingField = value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			return <EndDate>k__BackingField;
		}
		set
		{
			<EndDate>k__BackingField = value;
		}
	}

	public TimeSpan? DayCycleStart
	{
		get
		{
			return <DayCycleStart>k__BackingField;
		}
		set
		{
			<DayCycleStart>k__BackingField = value;
		}
	}

	public TimeSpan? DayCycleEnd
	{
		get
		{
			return <DayCycleEnd>k__BackingField;
		}
		set
		{
			<DayCycleEnd>k__BackingField = value;
		}
	}

	public RoutingCommand RoutingCommand
	{
		get
		{
			return <RoutingCommand>k__BackingField;
		}
		set
		{
			<RoutingCommand>k__BackingField = value;
		}
	}

	public string RoutingParam
	{
		get
		{
			return <RoutingParam>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<AppAnnouncementTimingViewModel> AnnouncementTimings
	{
		get
		{
			return <AnnouncementTimings>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public FileInfoModel ButtonImage
	{
		get
		{
			return <ButtonImage>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<ClientFilter> Filters
	{
		get
		{
			return <Filters>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsActive()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0115: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_00c9: Expected I, but got O
		//IL_01a5: Expected O, but got I4
		//IL_0087: Expected I, but got O
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_0302: Expected O, but got I4
		if (<Game>k__BackingField == GameCategory.Common)
		{
			goto IL_00d7;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v40+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame = Preferences.CurrentGame;
			GameCategory gameCategory = GameCategoryExtensions.ToGameCategory(currentGame);
			if (<Game>k__BackingField == gameCategory)
			{
				nint num = unchecked((nint)null);
				goto IL_00d7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame2 = Preferences.CurrentGame;
			GameCategory gameCategory2 = GameCategoryExtensions.ToGameCategory(currentGame2);
			bool flag = <Game>k__BackingField != gameCategory2;
			nint num = unchecked((nint)null);
			if (!flag)
			{
				goto IL_00d7;
			}
		}
		goto IL_0200;
		IL_0200:
		return false;
		IL_00d7:
		object obj3 = typeof(DataRelation) + 712;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		bool flag3 = <ShowDate>k__BackingField > now;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			if (!(<EndDate>k__BackingField < now2))
			{
				object obj9 = (??)<DayCycleStart>k__BackingField & 1;
				if (obj9 != null)
				{
					object obj10 = (??)<DayCycleEnd>k__BackingField & 1;
					if (obj10 != null)
					{
						object obj11 = typeof(DataRelation) + 768;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v18+E4]");
						bool flag6 = (nint)0 == 0;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTimeOffset utcNow = DateTimeOffset.UtcNow;
						object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v22+E4]");
						bool flag7 = (nint)0 == 0;
						object obj16 = !flag7;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan offset = TimeSpan.FromHours(2.0000000002328306);
						DateTimeOffset dateTimeOffset2 = default(DateTimeOffset);
						DateTimeOffset dateTimeOffset = dateTimeOffset2.ToOffset(offset);
						TimeSpan timeOfDay = dateTimeOffset2.TimeOfDay;
						TimeSpan? timeSpan = default(TimeSpan?);
						TimeSpan value = timeSpan.Value;
						TimeSpan value2 = timeSpan.Value;
						return TimeSpanExtension.IsBetween(timeOfDay, value, value2);
					}
				}
				return true;
			}
		}
		goto IL_0200;
	}
}
