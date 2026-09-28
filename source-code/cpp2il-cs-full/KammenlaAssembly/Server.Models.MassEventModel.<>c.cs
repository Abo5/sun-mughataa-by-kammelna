using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

namespace Server.Models;

[Serializable]
public class MassEventModel
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MassEventStageViewModel, bool> <>9__74_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_ActiveStage>b__74_0(MassEventStageViewModel s)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01f3: Expected O, but got I4
			//IL_00a1: Expected O, but got I
			//IL_00b9: Expected O, but got I4
			//IL_0292: Expected O, but got I4
			//IL_0233: Expected O, but got I4
			//IL_014b: Expected O, but got I4
			//IL_024a: Expected O, but got I4
			//IL_018b: Expected O, but got I4
			//IL_02eb: Expected O, but got I4
			//IL_02f4: Expected O, but got I4
			DateTime dateTime = (DateTime)152989696;
			object obj = typeof(DataRelation) + 712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D65]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DateTime now = DateTime.Now;
			bool flag2 = s == null;
			object obj5 = !flag2;
			DateTime dateTime2;
			if (obj5 == null)
			{
				dateTime2 = (DateTime)152989696;
				throw new NullReferenceException();
			}
			goto IL_008b;
			IL_0312:
			bool flag3;
			return flag3;
			IL_0161:
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v22+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return dateTime2 < s.<FinishDate>k__BackingField;
			IL_008b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D66]");
			object obj8 = (nint)0 & (nint)1;
			bool flag5 = obj8 == null;
			object obj9 = 152989696;
			dateTime2 = now;
			DateTime <StartingDate>k__BackingField;
			DateTime <StartingDate>k__BackingField2;
			DateTime dateTime3;
			if (!flag5)
			{
				<StartingDate>k__BackingField = s.<StartingDate>k__BackingField;
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v2+E4]");
				bool flag6 = (nint)0 == 0;
				dateTime2 = now;
				<StartingDate>k__BackingField2 = s.<StartingDate>k__BackingField;
				dateTime3 = now;
				if (!flag6)
				{
					goto IL_0126;
				}
			}
			else
			{
				_ = 1;
				<StartingDate>k__BackingField = s.<StartingDate>k__BackingField;
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v2+E4]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				<StartingDate>k__BackingField2 = s.<StartingDate>k__BackingField;
				dateTime3 = dateTime2;
				if (obj11 != null)
				{
					goto IL_0126;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag3 = dateTime3 >= <StartingDate>k__BackingField2;
			bool flag8 = !flag3;
			object obj12 = !flag8;
			object obj13 = 0;
			DateTime dateTime4 = <StartingDate>k__BackingField2;
			dateTime2 = dateTime3;
			if (obj12 != null)
			{
				goto IL_0161;
			}
			goto IL_0312;
			IL_0126:
			flag3 = dateTime2 >= <StartingDate>k__BackingField;
			bool flag9 = !flag3;
			obj13 = 0;
			dateTime4 = <StartingDate>k__BackingField;
			if (!flag9)
			{
				goto IL_0161;
			}
			goto IL_0312;
			IL_007d:
			now = DateTime.Now;
			goto IL_008b;
		}
	}

	private IThemeColorProfile _cachedTheme;

	private long <Id>k__BackingField;

	private Games <Game>k__BackingField;

	private string <AssignedServerId>k__BackingField;

	private int? <AssignedRoomId>k__BackingField;

	private string <Name>k__BackingField;

	private string <Organizer>k__BackingField;

	private bool <IsRegisterByCode>k__BackingField;

	private DateTime <AvailabilityDate>k__BackingField;

	private DateTime <StartingDate>k__BackingField;

	private DateTime <RegistrationDeadline>k__BackingField;

	private DateTime <FinishDate>k__BackingField;

	private AppTheme <Theme>k__BackingField;

	private string <PhysicalFinalTitle>k__BackingField;

	private string <PhysicalFinalDescription>k__BackingField;

	private List<MassEventPrizeViewModel> <Prizes>k__BackingField;

	private List<MassEventSponsorBannerViewModel> <SponsorBanners>k__BackingField;

	private List<MassEventStageViewModel> <Stages>k__BackingField;

	private List<ImageInfoModel<ImageCacher.MassTournamentImageType>> <Images>k__BackingField;

	public long Id
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

	public Games Game
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

	public string AssignedServerId
	{
		get
		{
			return <AssignedServerId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int? AssignedRoomId
	{
		get
		{
			return <AssignedRoomId>k__BackingField;
		}
		set
		{
			<AssignedRoomId>k__BackingField = value;
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
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string Organizer
	{
		get
		{
			return <Organizer>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsRegisterByCode
	{
		get
		{
			return <IsRegisterByCode>k__BackingField;
		}
		set
		{
			<IsRegisterByCode>k__BackingField = value;
		}
	}

	public DateTime AvailabilityDate
	{
		get
		{
			return <AvailabilityDate>k__BackingField;
		}
		set
		{
			<AvailabilityDate>k__BackingField = value;
		}
	}

	public DateTime StartingDate
	{
		get
		{
			return <StartingDate>k__BackingField;
		}
		set
		{
			<StartingDate>k__BackingField = value;
		}
	}

	public DateTime RegistrationDeadline
	{
		get
		{
			return <RegistrationDeadline>k__BackingField;
		}
		set
		{
			<RegistrationDeadline>k__BackingField = value;
		}
	}

	public DateTime FinishDate
	{
		get
		{
			return <FinishDate>k__BackingField;
		}
		set
		{
			<FinishDate>k__BackingField = value;
		}
	}

	public AppTheme Theme
	{
		get
		{
			return <Theme>k__BackingField;
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

	public string PhysicalFinalTitle
	{
		get
		{
			return <PhysicalFinalTitle>k__BackingField;
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

	public string PhysicalFinalDescription
	{
		get
		{
			return <PhysicalFinalDescription>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 128;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<MassEventPrizeViewModel> Prizes
	{
		get
		{
			return <Prizes>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 136;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<MassEventSponsorBannerViewModel> SponsorBanners
	{
		get
		{
			return <SponsorBanners>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 144;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<MassEventStageViewModel> Stages
	{
		get
		{
			return <Stages>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 152;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<ImageInfoModel<ImageCacher.MassTournamentImageType>> Images
	{
		get
		{
			return <Images>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 160;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public MassEventStageViewModel ActiveStage
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2888;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BB7]");
			object obj3 = (nint)0 & (nint)1;
			List<MassEventStageViewModel> list;
			List<MassEventStageViewModel> list2;
			object obj4;
			if (obj3 != null)
			{
				list = <Stages>k__BackingField;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				list2 = <Stages>k__BackingField;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				list = <Stages>k__BackingField;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				list2 = <Stages>k__BackingField;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = list2;
			object obj10 = obj7;
			IEnumerable<object> source = list2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)656;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return (MassEventStageViewModel)Enumerable.FirstOrDefault(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = list;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = list;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	public bool IsRegistrationOpen
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0078: Expected O, but got I4
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			return <RegistrationDeadline>k__BackingField > now;
		}
	}

	public IThemeColorProfile GenerateTheme()
	{
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		object obj = this + 16;
		if (obj != null)
		{
			return (IThemeColorProfile)obj;
		}
		object obj2 = typeof(RegisteredWaitHandle) + 1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RuntimeThemeColorProfile runtimeThemeColorProfile = default(RuntimeThemeColorProfile);
		runtimeThemeColorProfile..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ThemeColorPalette themeColorPalette = default(ThemeColorPalette);
		themeColorPalette..ctor();
		AppTheme appTheme = <Theme>k__BackingField;
		if (<Theme>k__BackingField != null && themeColorPalette != null)
		{
			themeColorPalette.PrimaryColor = appTheme.<PrimaryColor>k__BackingField;
			themeColorPalette.PrimaryEffectColor = appTheme.<PrimaryEffectColor>k__BackingField;
			themeColorPalette.SecondaryColor = appTheme.<SecondaryColor>k__BackingField;
			themeColorPalette.SecondaryEffectColor = appTheme.<SecondaryEffectColor>k__BackingField;
			themeColorPalette.AccessoryColorOne = (Color)0;
			themeColorPalette.AccessoryColorTwo = (Color)0;
			AppTheme appTheme2 = <Theme>k__BackingField;
			if (<Theme>k__BackingField != null)
			{
				themeColorPalette.PrimaryTextColor = appTheme2.<PrimaryTextColor>k__BackingField;
				themeColorPalette.SecondaryTextColor = appTheme2.<SecondaryTextColor>k__BackingField;
				if (runtimeThemeColorProfile != null)
				{
					object obj4 = runtimeThemeColorProfile + 16;
					obj4 = themeColorPalette;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj = runtimeThemeColorProfile;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return runtimeThemeColorProfile;
				}
			}
		}
		return (IThemeColorProfile)new NullReferenceException();
	}

	public MassEventModel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 160;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
