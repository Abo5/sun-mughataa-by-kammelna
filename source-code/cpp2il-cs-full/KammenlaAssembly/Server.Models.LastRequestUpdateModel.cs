using System;
using System.Data;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using Util;

namespace Server.Models;

public class LastRequestUpdateModel
{
	private const string UpcomingPredictions = "lup";

	private const string Achievements = "lua";

	private const string StoreHome = "lush";

	private const string MassEvents = "lum";

	private const string AppAnnouncements = "luaa";

	private const string Notifications = "lun";

	private const string ClientVisuals = "lucv";

	private const string REMOTE_CONFIG = "lurc";

	private const string Hints = "luh";

	private const string STORE_PRODUCTS = "lusp";

	private const string STORE_ITEMS = "lusi";

	private const string STORE_PROFILE_GIFTS = "luspg";

	private const string STORE_ITEM_GROUPS = "lusig";

	private const string LOGO_ELEMENTS = "lule";

	private readonly DateTime <UpcomingPredictionsRequestUpdate>k__BackingField;

	private readonly DateTime <AchievementsRequestUpdate>k__BackingField;

	private readonly DateTime <StoreHomeRequestUpdate>k__BackingField;

	private readonly DateTime <MassEventsRequestUpdate>k__BackingField;

	private readonly DateTime <AppAnnouncementsRequestUpdate>k__BackingField;

	private readonly DateTime <NotificationsRequestUpdate>k__BackingField;

	private readonly DateTime <ClientVisualsRequestUpdate>k__BackingField;

	private readonly DateTime <RemoteConfigRequestUpdate>k__BackingField;

	private readonly DateTime <HintsRequestUpdate>k__BackingField;

	private readonly DateTime <StoreProductsRequestUpdate>k__BackingField;

	private readonly DateTime <StoreItemsRequestUpdate>k__BackingField;

	private readonly DateTime <StoreProfileGiftsRequestUpdate>k__BackingField;

	private readonly DateTime <StoreItemGroupsRequestUpdate>k__BackingField;

	private readonly DateTime <LogoElementsRequestUpdate>k__BackingField;

	public DateTime UpcomingPredictionsRequestUpdate => <UpcomingPredictionsRequestUpdate>k__BackingField;

	public DateTime AchievementsRequestUpdate => <AchievementsRequestUpdate>k__BackingField;

	public DateTime StoreHomeRequestUpdate => <StoreHomeRequestUpdate>k__BackingField;

	public DateTime MassEventsRequestUpdate => <MassEventsRequestUpdate>k__BackingField;

	public DateTime AppAnnouncementsRequestUpdate => <AppAnnouncementsRequestUpdate>k__BackingField;

	public DateTime NotificationsRequestUpdate => <NotificationsRequestUpdate>k__BackingField;

	public DateTime ClientVisualsRequestUpdate => <ClientVisualsRequestUpdate>k__BackingField;

	public DateTime RemoteConfigRequestUpdate => <RemoteConfigRequestUpdate>k__BackingField;

	public DateTime HintsRequestUpdate => <HintsRequestUpdate>k__BackingField;

	public DateTime StoreProductsRequestUpdate => <StoreProductsRequestUpdate>k__BackingField;

	public DateTime StoreItemsRequestUpdate => <StoreItemsRequestUpdate>k__BackingField;

	public DateTime StoreProfileGiftsRequestUpdate => <StoreProfileGiftsRequestUpdate>k__BackingField;

	public DateTime StoreItemGroupsRequestUpdate => <StoreItemGroupsRequestUpdate>k__BackingField;

	public DateTime LogoElementsRequestUpdate => <LogoElementsRequestUpdate>k__BackingField;

	public DateTime StoreSplitRequestUpdate
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0097: Expected O, but got I4
			object obj = typeof(DataRelation) + 824;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = DateTimeUtil.Max(<StoreProductsRequestUpdate>k__BackingField, <StoreItemsRequestUpdate>k__BackingField);
			DateTime dateTime2 = DateTimeUtil.Max(<StoreProfileGiftsRequestUpdate>k__BackingField, <StoreItemGroupsRequestUpdate>k__BackingField);
			return DateTimeUtil.Max(dateTime, dateTime2);
		}
	}

	public LastRequestUpdateModel()
	{
	}

	public LastRequestUpdateModel(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I4
		//IL_0076: Expected I8, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_031a: Expected O, but got I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0346: Expected O, but got I4
		//IL_010d: Expected I8, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0387: Expected O, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03b3: Expected O, but got I4
		//IL_0128: Expected I8, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03f4: Expected O, but got I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0420: Expected O, but got I4
		//IL_0143: Expected I8, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0461: Expected O, but got I4
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_048d: Expected O, but got I4
		//IL_015e: Expected I8, but got I4
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04ce: Expected O, but got I4
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I4
		//IL_0179: Expected I8, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_053b: Expected O, but got I4
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_0567: Expected O, but got I4
		//IL_0194: Expected I8, but got I4
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_05a8: Expected O, but got I4
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05d4: Expected O, but got I4
		//IL_01af: Expected I8, but got I4
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_0615: Expected O, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_0641: Expected O, but got I4
		//IL_01ca: Expected I8, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_0682: Expected O, but got I4
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_06ae: Expected O, but got I4
		//IL_01e5: Expected I8, but got I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_06ef: Expected O, but got I4
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_071b: Expected O, but got I4
		//IL_0200: Expected I8, but got I4
		//IL_074d: Expected O, but got I4
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_0779: Expected O, but got I4
		//IL_021b: Expected I8, but got I4
		//IL_0236: Expected I8, but got I4
		//IL_0251: Expected I8, but got I4
		if (data != null)
		{
			object obj = "java.io.FileOutputStream" + 3592;
			object obj2 = (object)((??)SFSExtensions.Get(data, (string)obj, (DateTime?)(object)0) & 1) != null;
			DateTime dateTime = (DateTime)obj;
			if (obj2 == null)
			{
				dateTime = new DateTime(0L);
			}
			object obj3 = "java.io.FileOutputStream" + 3536;
			object obj4 = "java.io.FileOutputStream" + 3608;
			<UpcomingPredictionsRequestUpdate>k__BackingField = dateTime;
			object obj5 = (object)((??)SFSExtensions.Get(data, (string)obj3, (DateTime?)(object)0) & 1) != null;
			DateTime dateTime2 = (DateTime)obj3;
			if (obj5 == null)
			{
				dateTime2 = new DateTime(0L);
			}
			object obj6 = "java.io.FileOutputStream" + 3576;
			<AchievementsRequestUpdate>k__BackingField = dateTime2;
			DateTime? dateTime3 = SFSExtensions.Get(data, (string)obj4, (DateTime?)(object)0);
			object obj7 = (??)dateTime3 & 1;
			bool flag = obj7 == null;
			object obj8 = !flag;
			DateTime dateTime4 = (DateTime)obj4;
			if (obj8 == null)
			{
				dateTime4 = new DateTime(0L);
			}
			object obj9 = "java.io.FileOutputStream" + 3544;
			<StoreHomeRequestUpdate>k__BackingField = dateTime4;
			DateTime? dateTime5 = SFSExtensions.Get(data, (string)obj6, (DateTime?)(object)0);
			object obj10 = (??)dateTime5 & 1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			DateTime dateTime6 = (DateTime)obj6;
			if (obj11 == null)
			{
				dateTime6 = new DateTime(0L);
			}
			object obj12 = "java.io.FileOutputStream" + 3584;
			<MassEventsRequestUpdate>k__BackingField = dateTime6;
			DateTime? dateTime7 = SFSExtensions.Get(data, (string)obj9, (DateTime?)(object)0);
			object obj13 = (??)dateTime7 & 1;
			bool flag3 = obj13 == null;
			object obj14 = !flag3;
			DateTime dateTime8 = (DateTime)obj9;
			if (obj14 == null)
			{
				dateTime8 = new DateTime(0L);
			}
			object obj15 = "java.io.FileOutputStream" + 3552;
			<AppAnnouncementsRequestUpdate>k__BackingField = dateTime8;
			DateTime? dateTime9 = SFSExtensions.Get(data, (string)obj12, (DateTime?)(object)0);
			object obj16 = (??)dateTime9 & 1;
			bool flag4 = obj16 == null;
			object obj17 = !flag4;
			DateTime dateTime10 = (DateTime)obj12;
			if (obj17 == null)
			{
				dateTime10 = new DateTime(0L);
			}
			object obj18 = "java.io.FileOutputStream" + 3600;
			<NotificationsRequestUpdate>k__BackingField = dateTime10;
			DateTime? dateTime11 = SFSExtensions.Get(data, (string)obj15, (DateTime?)(object)0);
			object obj19 = (??)dateTime11 & 1;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			DateTime dateTime12 = (DateTime)obj15;
			if (obj20 == null)
			{
				dateTime12 = new DateTime(0L);
			}
			object obj21 = "java.io.FileOutputStream" + 3560;
			<ClientVisualsRequestUpdate>k__BackingField = dateTime12;
			DateTime? dateTime13 = SFSExtensions.Get(data, (string)obj18, (DateTime?)(object)0);
			object obj22 = (??)dateTime13 & 1;
			bool flag6 = obj22 == null;
			object obj23 = !flag6;
			DateTime dateTime14 = (DateTime)obj18;
			if (obj23 == null)
			{
				dateTime14 = new DateTime(0L);
			}
			object obj24 = "java.io.FileOutputStream" + 3632;
			<RemoteConfigRequestUpdate>k__BackingField = dateTime14;
			DateTime? dateTime15 = SFSExtensions.Get(data, (string)obj21, (DateTime?)(object)0);
			object obj25 = (??)dateTime15 & 1;
			bool flag7 = obj25 == null;
			object obj26 = !flag7;
			DateTime dateTime16 = (DateTime)obj21;
			if (obj26 == null)
			{
				dateTime16 = new DateTime(0L);
			}
			object obj27 = "java.io.FileOutputStream" + 3616;
			<HintsRequestUpdate>k__BackingField = dateTime16;
			DateTime? dateTime17 = SFSExtensions.Get(data, (string)obj24, (DateTime?)(object)0);
			object obj28 = (??)dateTime17 & 1;
			bool flag8 = obj28 == null;
			object obj29 = !flag8;
			DateTime dateTime18 = (DateTime)obj24;
			if (obj29 == null)
			{
				dateTime18 = new DateTime(0L);
			}
			object obj30 = "java.io.FileOutputStream" + 3640;
			<StoreProductsRequestUpdate>k__BackingField = dateTime18;
			DateTime? dateTime19 = SFSExtensions.Get(data, (string)obj27, (DateTime?)(object)0);
			object obj31 = (??)dateTime19 & 1;
			bool flag9 = obj31 == null;
			object obj32 = !flag9;
			DateTime dateTime20 = (DateTime)obj27;
			if (obj32 == null)
			{
				dateTime20 = new DateTime(0L);
			}
			object obj33 = "java.io.FileOutputStream" + 3624;
			<StoreItemsRequestUpdate>k__BackingField = dateTime20;
			DateTime? dateTime21 = SFSExtensions.Get(data, (string)obj30, (DateTime?)(object)0);
			object obj34 = (??)dateTime21 & 1;
			bool flag10 = obj34 == null;
			object obj35 = !flag10;
			DateTime dateTime22 = (DateTime)obj30;
			if (obj35 == null)
			{
				dateTime22 = new DateTime(0L);
			}
			object obj36 = "java.io.FileOutputStream" + 3568;
			<StoreProfileGiftsRequestUpdate>k__BackingField = dateTime22;
			DateTime? dateTime23 = SFSExtensions.Get(data, (string)obj33, (DateTime?)(object)0);
			object obj37 = (??)dateTime23 & 1;
			bool flag11 = obj37 == null;
			object obj38 = !flag11;
			DateTime dateTime24 = (DateTime)obj33;
			if (obj38 == null)
			{
				dateTime24 = new DateTime(0L);
			}
			<StoreItemGroupsRequestUpdate>k__BackingField = dateTime24;
			DateTime? dateTime25 = SFSExtensions.Get(data, (string)obj36, (DateTime?)(object)0);
			object obj39 = (??)dateTime25 & 1;
			bool flag12 = obj39 == null;
			object obj40 = !flag12;
			DateTime dateTime26 = (DateTime)obj36;
			if (obj40 == null)
			{
				dateTime26 = new DateTime(0L);
			}
			<LogoElementsRequestUpdate>k__BackingField = dateTime26;
		}
	}
}
