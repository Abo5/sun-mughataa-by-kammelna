using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Server.Models;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;

public static class UserInfo
{
	public class FTPreviousInfo
	{
		private int <TransFTLevel>k__BackingField;

		private int <TransFTStage>k__BackingField;

		private int <TransFTRoundsWon>k__BackingField;

		private int <TransFTHearts>k__BackingField;

		private int <PrevFTLevel>k__BackingField;

		private int <PrevFTStage>k__BackingField;

		private int <PrevFTRoundsWon>k__BackingField;

		private int <PrevFTHearts>k__BackingField;

		private bool <HeartAnimationShown>k__BackingField;

		private bool <BreadCrumbAnimationShown>k__BackingField;

		private int TransFTLevel
		{
			get
			{
				return <TransFTLevel>k__BackingField;
			}
			set
			{
				<TransFTLevel>k__BackingField = value;
			}
		}

		private int TransFTStage
		{
			get
			{
				return <TransFTStage>k__BackingField;
			}
			set
			{
				<TransFTStage>k__BackingField = value;
			}
		}

		private int TransFTRoundsWon
		{
			get
			{
				return <TransFTRoundsWon>k__BackingField;
			}
			set
			{
				<TransFTRoundsWon>k__BackingField = value;
			}
		}

		private int TransFTHearts
		{
			get
			{
				return <TransFTHearts>k__BackingField;
			}
			set
			{
				<TransFTHearts>k__BackingField = value;
			}
		}

		public int PrevFTLevel
		{
			get
			{
				return <PrevFTLevel>k__BackingField;
			}
			private set
			{
				<PrevFTLevel>k__BackingField = value;
			}
		}

		public int PrevFTStage
		{
			get
			{
				return <PrevFTStage>k__BackingField;
			}
			private set
			{
				<PrevFTStage>k__BackingField = value;
			}
		}

		public int PrevFTRoundsWon
		{
			get
			{
				return <PrevFTRoundsWon>k__BackingField;
			}
			private set
			{
				<PrevFTRoundsWon>k__BackingField = value;
			}
		}

		public int PrevFTHearts
		{
			get
			{
				return <PrevFTHearts>k__BackingField;
			}
			private set
			{
				<PrevFTHearts>k__BackingField = value;
			}
		}

		public bool HeartAnimationShown
		{
			get
			{
				return <HeartAnimationShown>k__BackingField;
			}
			set
			{
				<HeartAnimationShown>k__BackingField = value;
			}
		}

		public bool BreadCrumbAnimationShown
		{
			get
			{
				return <BreadCrumbAnimationShown>k__BackingField;
			}
			set
			{
				<BreadCrumbAnimationShown>k__BackingField = value;
			}
		}

		public void UpdatePrevInfo()
		{
			if (<PrevFTLevel>k__BackingField != 0)
			{
				User mySelf = SFS.MySelf;
				int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(mySelf);
				if (<TransFTLevel>k__BackingField == fTLevel)
				{
					User mySelf2 = SFS.MySelf;
					int fTStage = SFSKammelnaUserExtensions.GetFTStage(mySelf2);
					if (<TransFTStage>k__BackingField == fTStage)
					{
						User mySelf3 = SFS.MySelf;
						int fTRoundsWon = SFSKammelnaUserExtensions.GetFTRoundsWon(mySelf3);
						if (<TransFTRoundsWon>k__BackingField == fTRoundsWon)
						{
							User mySelf4 = SFS.MySelf;
							int fTHearts = SFSKammelnaUserExtensions.GetFTHearts(mySelf4);
							if (<TransFTHearts>k__BackingField == fTHearts)
							{
								goto IL_0292;
							}
						}
					}
				}
				<PrevFTLevel>k__BackingField = <TransFTLevel>k__BackingField;
				User mySelf5 = SFS.MySelf;
				int fTLevel2 = SFSKammelnaUserExtensions.GetFTLevel(mySelf5);
				<TransFTLevel>k__BackingField = fTLevel2;
				<PrevFTStage>k__BackingField = <TransFTStage>k__BackingField;
				User mySelf6 = SFS.MySelf;
				int fTStage2 = SFSKammelnaUserExtensions.GetFTStage(mySelf6);
				<TransFTStage>k__BackingField = fTStage2;
				<PrevFTRoundsWon>k__BackingField = <TransFTRoundsWon>k__BackingField;
				User mySelf7 = SFS.MySelf;
				int fTRoundsWon2 = SFSKammelnaUserExtensions.GetFTRoundsWon(mySelf7);
				<TransFTRoundsWon>k__BackingField = fTRoundsWon2;
				<PrevFTHearts>k__BackingField = <TransFTHearts>k__BackingField;
				User mySelf8 = SFS.MySelf;
				int fTHearts2 = SFSKammelnaUserExtensions.GetFTHearts(mySelf8);
				<TransFTHearts>k__BackingField = fTHearts2;
				goto IL_0292;
			}
			User mySelf9 = SFS.MySelf;
			<PrevFTLevel>k__BackingField = (<TransFTLevel>k__BackingField = SFSKammelnaUserExtensions.GetFTLevel(mySelf9));
			User mySelf10 = SFS.MySelf;
			<PrevFTStage>k__BackingField = (<TransFTStage>k__BackingField = SFSKammelnaUserExtensions.GetFTStage(mySelf10));
			User mySelf11 = SFS.MySelf;
			<PrevFTRoundsWon>k__BackingField = (<TransFTRoundsWon>k__BackingField = SFSKammelnaUserExtensions.GetFTRoundsWon(mySelf11));
			User mySelf12 = SFS.MySelf;
			<PrevFTHearts>k__BackingField = (<TransFTHearts>k__BackingField = SFSKammelnaUserExtensions.GetFTHearts(mySelf12));
			return;
			IL_0292:
			<HeartAnimationShown>k__BackingField = false;
		}

		public override string ToString()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0086: Expected O, but got I4
			//IL_00c0: Expected O, but got I8
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_014f: Expected O, but got I4
			//IL_0165: Expected O, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected O, but got Unknown
			//IL_0202: Expected O, but got I8
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected O, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected O, but got Unknown
			//IL_0291: Expected O, but got I4
			//IL_02a7: Expected O, but got I
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected O, but got Unknown
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Expected O, but got Unknown
			//IL_031c: Expected O, but got I4
			//IL_0332: Expected O, but got I
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Expected O, but got Unknown
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Expected O, but got Unknown
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected O, but got Unknown
			//IL_03d7: Expected O, but got I4
			//IL_03ed: Expected O, but got I
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Expected O, but got Unknown
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected O, but got Unknown
			//IL_047b: Expected O, but got I8
			//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6: Expected O, but got Unknown
			//IL_04fb: Expected O, but got I4
			//IL_0511: Expected O, but got I
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Expected O, but got Unknown
			//IL_054d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Expected O, but got Unknown
			//IL_05a7: Expected O, but got I4
			//IL_05bd: Expected O, but got I
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e2: Expected O, but got Unknown
			//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ff: Expected O, but got Unknown
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_060d: Expected O, but got Unknown
			//IL_0662: Expected O, but got I4
			//IL_0678: Expected O, but got I
			//IL_0698: Unknown result type (might be due to invalid IL or missing references)
			//IL_069d: Expected O, but got Unknown
			//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ba: Expected O, but got Unknown
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Expected O, but got Unknown
			//IL_071d: Expected O, but got I4
			//IL_0733: Expected O, but got I
			//IL_0753: Unknown result type (might be due to invalid IL or missing references)
			//IL_0758: Expected O, but got Unknown
			//IL_076f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0774: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			string[] array = default(string[]);
			if (array != null)
			{
				if (array.Length != 0)
				{
					object obj2 = "ThisIsFakeReceiptData" + 1952;
					object format = "LAK" + 2576;
					object obj3 = array + 32;
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj4 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object arg = default(object);
					string text = string.Format((string)format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X21_v6-8]");
					object obj5 = 0 & 0xFFFFFFFEL;
					if (obj5 != null)
					{
						object format2 = "SetRoomVariables request error" + 2480;
						object obj6 = array + 40;
						obj6 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object arg2 = default(object);
						string text2 = string.Format((string)format2, arg2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X21_v8-10]");
						bool flag = (nint)0 < (nint)2;
						object obj7 = !flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X21_v8-10]");
						object obj8 = -2;
						bool flag2 = obj8 == null;
						object obj9 = ~obj7;
						object obj10 = obj9 | flag2;
						if (obj10 == null)
						{
							object format3 = "WhiteSmoke" + 184;
							object obj11 = array + 48;
							obj11 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object arg3 = default(object);
							string text3 = string.Format((string)format3, arg3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X21_v10-18]");
							object obj12 = 0 & 0xFFFFFFFCL;
							if (obj12 != null)
							{
								object format4 = "HH:mm:ss.ffZ" + 608;
								object obj13 = array + 56;
								obj13 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object arg4 = default(object);
								string text4 = string.Format((string)format4, arg4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X21_v12-20]");
								bool flag3 = (nint)0 < (nint)4;
								object obj14 = !flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X21_v12-20]");
								object obj15 = -4;
								bool flag4 = obj15 == null;
								object obj16 = ~obj14;
								object obj17 = obj16 | flag4;
								if (obj17 == null)
								{
									object obj18 = array + 64;
									obj18 = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X21_v14-28]");
									bool flag5 = (nint)0 < (nint)5;
									object obj19 = !flag5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X21_v14-28]");
									object obj20 = -5;
									bool flag6 = obj20 == null;
									object obj21 = ~obj19;
									object obj22 = obj21 | flag6;
									if (obj22 == null)
									{
										object obj23 = "Picking audio files is not supported on iOS" + 1528;
										object obj24 = array + 72;
										obj24 = obj23;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
										object arg5 = default(object);
										string text5 = string.Format((string)format, arg5);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X21_v16-30]");
										bool flag7 = (nint)0 < (nint)6;
										object obj25 = !flag7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X21_v16-30]");
										object obj26 = -6;
										bool flag8 = obj26 == null;
										object obj27 = ~obj25;
										object obj28 = obj27 | flag8;
										if (obj28 == null)
										{
											object obj29 = array + 80;
											obj29 = text5;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
											object arg6 = default(object);
											string text6 = string.Format((string)format2, arg6);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X21_v18-38]");
											object obj30 = 0 & 0xFFFFFFF8L;
											if (obj30 != null)
											{
												object obj31 = array + 88;
												obj31 = text6;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
												object arg7 = default(object);
												string text7 = string.Format((string)format3, arg7);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X21_v20-40]");
												bool flag9 = (nint)0 < (nint)8;
												object obj32 = !flag9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X21_v20-40]");
												object obj33 = -8;
												bool flag10 = obj33 == null;
												object obj34 = ~obj32;
												object obj35 = obj34 | flag10;
												if (obj35 == null)
												{
													object obj36 = array + 96;
													obj36 = text7;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
													object arg8 = default(object);
													string text8 = string.Format((string)format4, arg8);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X21_v22-48]");
													bool flag11 = (nint)0 < (nint)9;
													object obj37 = !flag11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X21_v22-48]");
													object obj38 = -9;
													bool flag12 = obj38 == null;
													object obj39 = ~obj37;
													object obj40 = obj39 | flag12;
													if (obj40 == null)
													{
														object format5 = "HH:mm:ss.ffZ" + 600;
														object obj41 = array + 104;
														obj41 = text8;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
														object arg9 = default(object);
														string text9 = string.Format((string)format5, arg9);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X21_v24-50]");
														bool flag13 = (nint)0 < (nint)10;
														object obj42 = !flag13;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X21_v24-50]");
														object obj43 = -10;
														bool flag14 = obj43 == null;
														object obj44 = ~obj42;
														object obj45 = obj44 | flag14;
														if (obj45 == null)
														{
															object format6 = "AvailableVoices" + 1304;
															object obj46 = array + 112;
															obj46 = text9;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
															object arg10 = default(object);
															string text10 = string.Format((string)format6, arg10);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X21_v26-58]");
															bool flag15 = (nint)0 < (nint)11;
															object obj47 = !flag15;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X21_v26-58]");
															object obj48 = -11;
															bool flag16 = obj48 == null;
															object obj49 = ~obj47;
															object obj50 = obj49 | flag16;
															if (obj50 == null)
															{
																object obj51 = array + 120;
																obj51 = text10;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																return string.Concat(array);
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private static bool <FirstVisit>k__BackingField;

	private const string DoNotShowGameReplaysWarningString = "DoNotShowGameReplaysWarning";

	private static FTPreviousInfo <FTPreviousSavedInfo>k__BackingField;

	public static string Email
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			object key = "Complete" + 3512;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = Prefs.GetString((string)key, null);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(text);
			bool flag3 = !flag2;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				text = null;
			}
			return text;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Complete" + 3512;
			Prefs.SetString((string)key, value);
		}
	}

	public static string UserDbId
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			object key = "Complete" + 3504;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = Prefs.GetString((string)key, null);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(text);
			bool flag3 = !flag2;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				text = null;
			}
			return text;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Complete" + 3504;
			Prefs.SetString((string)key, value);
		}
	}

	public static bool AllowIdAnalytics
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 496;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Added Tournament Prizes And Features" + 496;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool SawOnboarding
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1872;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1872;
			Prefs.SetBool((string)key, value);
		}
	}

	public static string AppleHashedReceipt
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 1376;
			return Prefs.GetString((string)key, null);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 1376;
			Prefs.SetString((string)key, value);
		}
	}

	public static bool IsEligibleForAppStoreIntroOffer
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 112;
			return Prefs.GetBool((string)key, defaultValue: true);
		}
		set
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_015c: Expected O, but got I4
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_00a2: Expected O, but got I
			//IL_00bc: Expected O, but got I4
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_0199: Expected O, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E737D]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = "_InputUv1BufferOffset" + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E737C]");
			object obj7 = (nint)0 & (nint)1;
			if (obj7 == null)
			{
				goto IL_00d2;
			}
			object key = obj6;
			goto IL_01d9;
			IL_00d2:
			_ = 1;
			key = obj6;
			goto IL_01d9;
			IL_007d:
			obj6 = "_InputUv1BufferOffset" + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E737C]");
			object obj8 = (nint)0 & (nint)1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			key = obj6;
			if (obj9 == null)
			{
				goto IL_00d2;
			}
			goto IL_01d9;
			IL_01d9:
			bool flag3 = Prefs.GetBool((string)key, defaultValue: true);
			Prefs.SetBool((string)key, value);
			if (value != flag3)
			{
				object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					ContentPushService.NotifyClientFilterChanged();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				ContentPushService.NotifyClientFilterChanged();
			}
		}
	}

	public static DateTime LastIntroEligibilityCheck
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			//IL_017e: Expected O, but got I4
			//IL_0104: Expected O, but got I
			//IL_0111: Expected O, but got I
			//IL_009e: Expected O, but got I
			//IL_00ab: Expected O, but got I
			object key = "_InputUv1BufferOffset" + 176;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj2 = typeof(DataRelation) + 712;
			string text = Prefs.GetString((string)key, null);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(text);
			object obj5 = obj2;
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+B8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+10]");
					return (DateTime)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v15+B8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v5+10]");
				return (DateTime)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				return DateTime.Parse(text);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return DateTime.Parse(text);
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00e9: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_006a: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "_InputUv1BufferOffset" + 176;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = default(DateTime);
			string value2 = dateTime.ToString(invariantCulture);
			Prefs.SetString((string)key, value2);
		}
	}

	public static bool SawGameSwitchHubAfterNewGame
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1864;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1864;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool SawWhatsNewForJackaroo
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1880;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1880;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool ClickedOnEmotesButton
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 1992;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 1992;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool ClickedOnJackarooFireModeButton
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 2000;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "[{0}]:{1}" + 2000;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool IsNewPlayer
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_01e2: Expected O, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0228: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			//IL_00d7: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			object obj = typeof(UsageHint) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object key = "Complete" + 3512;
			string text = Prefs.GetString((string)key, null);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = StringsExtensions.IsNullOrEmpty(text);
			bool flag4 = !flag3;
			object obj7 = !flag4;
			object obj8 = ~obj7;
			string value = ((obj8 != null) ? text : null);
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v11+E4]");
			bool flag5;
			if ((nint)0 != 0)
			{
				flag5 = StringsExtensions.IsNullOrEmpty(value);
				bool flag6 = !flag5;
				object obj10 = !flag6;
				object obj11 = 0;
				if (obj10 == null)
				{
					goto IL_00ee;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag5 = StringsExtensions.IsNullOrEmpty(value);
				bool flag7 = !flag5;
				object obj11 = 0;
				if (flag7)
				{
					goto IL_00ee;
				}
			}
			if (Authentication.CanLogin())
			{
				return false;
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key2 = "_InputUv1BufferOffset" + 1872;
			bool flag9 = Prefs.GetBool((string)key2);
			return (byte)((flag9 ? 1u : 0u) ^ 1u) != 0;
			IL_00ee:
			return flag5;
		}
	}

	public static bool FirstVisit
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_009a: Expected I4, but got O
			//IL_0102: Expected O, but got I
			//IL_0107: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7286]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			return (byte)(int)obj8 != 0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			return (byte)(int)obj9 != 0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c5: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_00fd: Expected O, but got I
			//IL_0105: Expected O, but got I4
			object obj = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7287]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			obj7 = value;
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+B8]");
			object obj8 = 0;
			obj8 = value;
		}
	}

	public static bool LastGameWon
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 168;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 168;
			Prefs.SetBool((string)key, value);
		}
	}

	public static int RateUsWins
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1568;
			return Prefs.GetInt((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 1568;
			Prefs.SetInt((string)key, value);
		}
	}

	public static int TimePlayed
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 3128;
			return Prefs.GetInt((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "_InputUv1BufferOffset" + 3128;
			Prefs.SetInt((string)key, value);
		}
	}

	public static bool HasUnseenTournaments
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "HH:mm:ss.ffZ" + 920;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "HH:mm:ss.ffZ" + 920;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool ChoseTabletMode
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 784;
			return Prefs.HasKey((string)key);
		}
	}

	public static bool FinishedSunTutorial
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 160;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 160;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool FinishedHokomTutorial
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 152;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 152;
			Prefs.SetBool((string)key, value);
		}
	}

	public static long ChatLastUpdatedAt
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0022: Expected I8, but got I4
			object key = "Cannot populate JSON object onto type '{0}'." + 2336;
			return Prefs.GetLong((string)key, 0L);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Cannot populate JSON object onto type '{0}'." + 2336;
			Prefs.SetLong((string)key, value);
		}
	}

	public static bool WasSubscribedLastSession
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Unsupported map type" + 3664;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Unsupported map type" + 3664;
			Prefs.SetBool((string)key, value);
		}
	}

	public static bool DoNotShowGameReplaysWarning
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "DNQUALIFIER" + 3656;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "DNQUALIFIER" + 3656;
			Prefs.SetBool((string)key, value);
		}
	}

	public static FTPreviousInfo FTPreviousSavedInfo
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E729D]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (FTPreviousInfo)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (FTPreviousInfo)0;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(UsageHint) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static int LastJoinedTournamentRoomId
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0026: Expected I4, but got I8
			object key = "java.io.FileOutputStream" + 1192;
			return Prefs.GetInt((string)key, -1);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "java.io.FileOutputStream" + 1192;
			Prefs.SetInt((string)key, value);
		}
	}

	public static int LastJoinedMassTournamentRoomId
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0026: Expected I4, but got I8
			object key = "java.io.FileOutputStream" + 1200;
			return Prefs.GetInt((string)key, -1);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "java.io.FileOutputStream" + 1200;
			Prefs.SetInt((string)key, value);
		}
	}

	public static List<Tournament> CreatedTournaments
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0070: Expected O, but got I
			object key = "com.unity.services.authentication.profile" + 2000;
			object defaultValue = "WhiteSmoke" + 3896;
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object obj2 = (nint)0 + (nint)1080;
			string text = Prefs.GetString((string)key, (string)defaultValue);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
				List<Tournament> result = default(List<Tournament>);
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
			List<Tournament> result2 = default(List<Tournament>);
			return result2;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0081: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object key = "com.unity.services.authentication.profile" + 2000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string value2 = JsonMapper.ToJson(value);
			Prefs.SetString((string)key, value2);
		}
	}

	public static string ReferralToken
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1040;
			return Prefs.GetString((string)key, null);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1040;
			Prefs.SetString((string)key, value);
		}
	}

	public static string ReferralLink
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1032;
			return Prefs.GetString((string)key, null);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1032;
			Prefs.SetString((string)key, value);
		}
	}

	public static string ReferringUserToken
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1064;
			return Prefs.GetString((string)key, null);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1064;
			Prefs.SetString((string)key, value);
		}
	}

	public static string ReferringUserName
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1056;
			return Prefs.GetString((string)key, null);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Read object reference Id '{0}' for {1}." + 1056;
			Prefs.SetString((string)key, value);
		}
	}

	public static event Action OnFastTrackRecordUpdated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(UsageHint) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(UsageHint) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static void ClearAllCachedModels()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_048d: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0139: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0259: Expected O, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0319: Expected O, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_040a: Expected O, but got I4
		//IL_0413: Expected O, but got I4
		//IL_03ae: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		object key = "m_StencilDeferredPS" + 1824;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		ETagStorage.Clear();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(SqlSingle[]) + 2360;
		CachedModels.Clear();
		Prefs.DeleteKey((string)key);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(MemberAchievementClanFeedData) + 2704;
		PredictAndWinManager.ResetModels();
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		AchievementsManager.ResetModels();
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
		NotificationsManager.ResetModels();
		object obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v16+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		LeaderBoardManager.ResetModels();
		object obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v19+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		RecentGiftBombsManager.ResetModels();
		object obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		FriendsManager.ResetModels();
		object obj24 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v25+E4]");
		bool flag8 = (nint)0 == 0;
		object obj25 = !flag8;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj26 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		PlayerProfilesHandler.ResetModels();
		object obj27 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v28+E4]");
		bool flag9 = (nint)0 == 0;
		object obj28 = !flag9;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj29 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		CounterBubbleManager.ResetCounters();
		object obj30 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v31+E4]");
		if ((nint)0 != 0)
		{
			ReferralHandler.ClearReferralPreferences(complete: true);
			object obj31 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v32+E4]");
			bool flag10 = (nint)0 == 0;
			object obj32 = 0;
			if (!flag10)
			{
				goto IL_03bc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ReferralHandler.ClearReferralPreferences(complete: true);
			object obj31 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v32+E4]");
			bool flag11 = (nint)0 == 0;
			object obj33 = !flag11;
			object obj32 = 0;
			if (obj33 != null)
			{
				goto IL_03bc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Store.ResetModels(preserveSubscribers: true);
		return;
		IL_03bc:
		Store.ResetModels(preserveSubscribers: true);
	}

	public static void ClearCredentials()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object key = "Complete" + 3512;
		object reason = "Added Tournament Prizes And Features" + 3992;
		Prefs.DeleteKey((string)key);
		Authentication.Clear((string)reason);
	}

	public static void UpdateFastTrackRecord(List<string> data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_005b: Expected O, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_04f1: Expected O, but got I
		//IL_050b: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_03c9: Expected O, but got I
		//IL_0581: Expected O, but got I
		//IL_0591: Expected O, but got I
		//IL_05b3: Expected O, but got I4
		//IL_0549: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_0461: Expected O, but got I
		//IL_0471: Expected O, but got I
		//IL_042b: Expected O, but got I
		//IL_043b: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_04a6: Expected O, but got I
		//IL_04b6: Expected O, but got I
		//IL_04c6: Expected O, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0213: Expected O, but got I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02c3: Expected O, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_031b: Expected O, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		object obj = "fetch_products" + 1576;
		object obj2 = (nint)0 + (nint)3104;
		object obj3 = obj;
		object obj4 = obj2;
		bool flag = ((List<object>)(object)data).Contains(obj);
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = "fetch_products" + 1608;
			obj3 = obj6;
			obj4 = obj2;
			bool flag3 = ((List<object>)(object)data).Contains(obj6);
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				object obj8 = "fetch_products" + 1624;
				obj3 = obj8;
				obj4 = obj2;
				bool flag5 = ((List<object>)(object)data).Contains(obj8);
				bool flag6 = !flag5;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					object obj10 = "fetch_products" + 1600;
					obj3 = obj10;
					obj4 = obj2;
					bool flag7 = ((List<object>)(object)data).Contains(obj10);
					bool flag8 = !flag7;
					object obj11 = !flag8;
					if (obj11 == null)
					{
						object obj12 = "fetch_products" + 1592;
						obj3 = obj12;
						obj4 = obj2;
						bool flag9 = ((List<object>)(object)data).Contains(obj12);
						bool flag10 = !flag9;
						object obj13 = !flag10;
						if (obj13 == null)
						{
							object obj14 = "fetch_products" + 1688;
							obj3 = obj14;
							obj4 = obj2;
							bool flag11 = ((List<object>)(object)data).Contains(obj14);
							bool flag12 = !flag11;
							object obj15 = !flag12;
							if (obj15 == null)
							{
								object obj16 = "fetch_products" + 1696;
								obj3 = obj16;
								obj4 = obj2;
								bool flag13 = ((List<object>)(object)data).Contains(obj16);
								bool flag14 = !flag13;
								object obj17 = !flag14;
								if (obj17 == null)
								{
									object obj18 = "fetch_products" + 1616;
									obj3 = obj18;
									obj4 = obj2;
									bool flag15 = ((List<object>)(object)data).Contains(obj18);
									bool flag16 = !flag15;
									object obj19 = !flag16;
									if (obj19 == null)
									{
										object obj20 = "fetch_products" + 1584;
										obj3 = obj20;
										obj4 = obj2;
										bool flag17 = ((List<object>)(object)data).Contains(obj20);
										bool flag18 = !flag17;
										object obj21 = !flag18;
										if (obj21 == null)
										{
											object obj22 = "m_StencilDeferredPS" + 2672;
											obj3 = obj22;
											obj4 = obj2;
											if (!((List<object>)(object)data).Contains(obj22))
											{
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		object obj23 = typeof(UsageHint) + 72;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj25 = (nint)0 & (nint)1;
			if (obj25 != null)
			{
				goto IL_03e6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj26 = (nint)0 & (nint)1;
			bool flag19 = obj26 == null;
			object obj27 = !flag19;
			if (obj27 != null)
			{
				goto IL_03e6;
			}
		}
		_ = 1;
		object obj28 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v21+E4]");
		bool flag20 = (nint)0 == 0;
		object obj29 = !flag20;
		object obj30 = obj28;
		if (obj29 != null)
		{
			goto IL_041b;
		}
		goto IL_055f;
		IL_041b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v21+B8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v20+8]");
		FTPreviousInfo fTPreviousInfo = (FTPreviousInfo)0;
		goto IL_0440;
		IL_0440:
		fTPreviousInfo.UpdatePrevInfo();
		object obj32 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v16+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v17+10]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v17+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v18+18]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v18+40]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v18+28]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v137 @ X2_v5 (should have been resolved before IL gen)");
		}
		return;
		IL_055f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj38 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v11+B8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v10+8]");
		fTPreviousInfo = (FTPreviousInfo)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v10+8]");
		bool flag21 = (nint)0 == 0;
		object obj40 = !flag21;
		if (obj40 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0440;
		IL_03e6:
		obj28 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v21+E4]");
		bool flag22 = (nint)0 == 0;
		obj30 = obj28;
		if (!flag22)
		{
			goto IL_041b;
		}
		goto IL_055f;
	}

	static UserInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1536;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+B8]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
