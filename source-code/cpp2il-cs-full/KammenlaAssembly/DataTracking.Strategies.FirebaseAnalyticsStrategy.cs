using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Firebase.Analytics;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine.Purchasing.Telemetry;

namespace DataTracking.Strategies;

public class FirebaseAnalyticsStrategy : IAnalyticsStrategy
{
	private const string LogPrefix = "[Firebase] ";

	private const int MaxEventNameLength = 40;

	private const int MaxParamValueLength = 100;

	public unsafe void AdEvent(string adSDK, AdAction adAction, AdType adType, AdPlace adPlacement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0167: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_017d: Expected I, but got O
		//IL_018d: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_028b: Expected O, but got I8
		//IL_0230: Expected I, but got O
		//IL_0240: Expected O, but got I
		//IL_0269: Expected O, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_0302: Expected O, but got Ref
		//IL_037b: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_0318: Expected I, but got O
		//IL_0328: Expected O, but got I
		//IL_0351: Expected O, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0418: Expected O, but got Ref
		//IL_0489: Expected O, but got I8
		//IL_042e: Expected I, but got O
		//IL_043e: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_0500: Expected O, but got Ref
		//IL_0579: Expected O, but got I4
		//IL_0589: Expected O, but got I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_0516: Expected I, but got O
		//IL_0526: Expected O, but got I
		//IL_054f: Expected O, but got I
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_063f: Expected O, but got I4
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Expected O, but got Unknown
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Expected O, but got Unknown
		//IL_0c2a: Expected O, but got I4
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected O, but got Unknown
		//IL_067b: Expected O, but got I4
		//IL_068b: Expected O, but got I
		//IL_069b: Expected O, but got I
		//IL_074f: Expected I4, but got O
		//IL_06d5: Expected I, but got O
		//IL_06e5: Expected O, but got I
		//IL_070f: Expected I4, but got O
		//IL_071f: Expected O, but got I
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0787: Expected O, but got Ref
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_0858: Expected O, but got I8
		//IL_0878: Expected I4, but got O
		//IL_07ec: Expected I, but got O
		//IL_07fc: Expected O, but got I
		//IL_0826: Expected I4, but got O
		//IL_0836: Expected O, but got I
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected O, but got Unknown
		//IL_08b1: Expected O, but got Ref
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected O, but got Unknown
		//IL_098a: Expected O, but got I4
		//IL_099a: Expected O, but got I4
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected O, but got Unknown
		//IL_09d0: Expected I4, but got O
		//IL_0916: Expected I, but got O
		//IL_0926: Expected O, but got I
		//IL_0950: Expected I4, but got O
		//IL_0960: Expected O, but got I
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_0a09: Expected O, but got Ref
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected O, but got Unknown
		//IL_0ada: Expected O, but got I8
		//IL_0afa: Expected I4, but got O
		//IL_0a6e: Expected I, but got O
		//IL_0a7e: Expected O, but got I
		//IL_0aa8: Expected I4, but got O
		//IL_0ab8: Expected O, but got I
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected O, but got Unknown
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected O, but got Unknown
		//IL_0b66: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB3]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v98+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v98+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		return;
		IL_0bac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_011d:
		object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj7 = "WhiteSmoke" + 3120;
		bool flag3 = obj7 == null;
		string text = (string)5;
		object[] array = default(object[]);
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		string text2;
		if (!flag3)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag4 = ex2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			if (flag4)
			{
				goto IL_0bac;
			}
		}
		if (array.Length != 0)
		{
			text = (string)obj7;
			object obj8 = array + 32;
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (adSDK != null)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v65 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v65 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag5)
				{
					goto IL_0bac;
				}
			}
			object obj9 = array.Length & 0xFFFFFFFEL;
			if (obj9 != null)
			{
				object obj10 = array + 40;
				obj10 = adSDK;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = typeof(SqlSingle[]) + 2648;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj12 = default(object);
				bool flag6 = obj12 == null;
				AdAction adAction2 = default(AdAction);
				text = (string)(&adAction2);
				if (!flag6)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag7 = ex2 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag7)
					{
						goto IL_0bac;
					}
				}
				bool flag8 = array.Length < 2;
				object obj13 = !flag8;
				object obj14 = array.Length - 2;
				bool flag9 = obj14 == null;
				object obj15 = ~obj13;
				object obj16 = obj15 | flag9;
				if (obj16 == null)
				{
					object obj17 = array + 48;
					obj17 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj18 = typeof(SqlSingle[]) + 2816;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj19 = default(object);
					bool flag10 = obj19 == null;
					AdType adType2 = default(AdType);
					text = (string)(&adType2);
					if (!flag10)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag11 = ex2 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						if (flag11)
						{
							goto IL_0bac;
						}
					}
					object obj20 = array.Length & 0xFFFFFFFCL;
					if (obj20 != null)
					{
						object obj21 = array + 56;
						obj21 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj22 = typeof(SqlSingle[]) + 2768;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj23 = default(object);
						bool flag12 = obj23 == null;
						AdPlace adPlace = default(AdPlace);
						text = (string)(&adPlace);
						if (!flag12)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag13 = ex2 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
							text2 = (string)0;
							if (flag13)
							{
								goto IL_0bac;
							}
						}
						bool flag14 = array.Length < 4;
						object obj24 = !flag14;
						object obj25 = array.Length - 4;
						bool flag15 = obj25 == null;
						object obj26 = ~obj24;
						object obj27 = obj26 | flag15;
						if (obj27 == null)
						{
							object obj28 = array + 64;
							obj28 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1184;
							string text3 = string.Format((string)format, array);
							object obj29 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
							object obj30 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v27+E4]");
							bool flag16 = (nint)0 == 0;
							object obj31 = !flag16;
							object obj32 = text3;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj32 = text3;
							}
							KLogger.LogAnalytics(obj32);
							object obj33 = typeof(TypeConverter<ushort, char>) + 3440;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							object obj34 = "___# Content push apply failed [{0}]: {1}" + 3488;
							object name = "___# Content push apply failed [{0}]: {1}" + 3440;
							bool flag17 = adSDK == null;
							object obj35 = !flag17;
							string text4 = adSDK;
							if (obj35 == null)
							{
								object obj36 = 153100288 + 1024;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X9_v11+90]");
								object obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X9_v12+B8]");
								object obj38 = 0;
								text4 = (string)obj38;
							}
							object obj39 = typeof(MemberAchievementClanFeedData) + 3976;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Parameter parameter = default(Parameter);
							parameter..ctor((string)obj34, text4);
							bool flag18 = parameter == null;
							text = (string)obj34;
							Parameter[] array2 = default(Parameter[]);
							AdType adType3;
							AdAction adAction3;
							if (!flag18)
							{
								nint num6 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v61 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag19 = ex2 == null;
								adType3 = AdType.Rewarded;
								adAction3 = (AdAction)text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v61 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
								text2 = (string)0;
								if (flag19)
								{
									goto IL_0bac;
								}
							}
							bool flag20 = array2.Length == 0;
							adType3 = AdType.Rewarded;
							adAction3 = (AdAction)text4;
							if (!flag20)
							{
								object obj40 = array2 + 32;
								obj40 = parameter;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string text5 = ((Enum)(&adAction2)).ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj41 = "___# Content push apply failed [{0}]: {1}" + 3424;
								text = (string)obj41;
								Parameter parameter2 = default(Parameter);
								parameter2..ctor((string)obj41, text5);
								if (parameter2 != null)
								{
									nint num7 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v60 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
									text = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag21 = ex2 == null;
									adType3 = AdType.Rewarded;
									adAction3 = (AdAction)text5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v60 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
									text2 = (string)0;
									if (flag21)
									{
										goto IL_0bac;
									}
								}
								object obj42 = array2.Length & 0xFFFFFFFEL;
								bool flag22 = obj42 == null;
								adType3 = AdType.Rewarded;
								adAction3 = (AdAction)text5;
								if (!flag22)
								{
									object obj43 = array2 + 40;
									obj43 = parameter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									string text6 = ((Enum)(&adType2)).ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj44 = "___# Content push apply failed [{0}]: {1}" + 3504;
									text = (string)obj44;
									Parameter parameter3 = default(Parameter);
									parameter3..ctor((string)obj44, text6);
									if (parameter3 != null)
									{
										nint num8 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v59 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
										text = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag23 = ex2 == null;
										adType3 = AdType.Rewarded;
										adAction3 = (AdAction)text6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v59 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
										text2 = (string)0;
										if (flag23)
										{
											goto IL_0bac;
										}
									}
									bool flag24 = array2.Length < 2;
									object obj45 = !flag24;
									object obj46 = array2.Length - 2;
									bool flag25 = obj46 == null;
									object obj47 = ~obj45;
									object obj48 = obj47 | flag25;
									adType3 = AdType.Rewarded;
									adAction3 = (AdAction)text6;
									if (obj48 == null)
									{
										object obj49 = array2 + 48;
										obj49 = parameter3;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										string text7 = ((Enum)(&adPlace)).ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj50 = "___# Content push apply failed [{0}]: {1}" + 3472;
										text = (string)obj50;
										Parameter parameter4 = default(Parameter);
										parameter4..ctor((string)obj50, text7);
										if (parameter4 != null)
										{
											nint num9 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v58 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
											text = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag26 = ex2 == null;
											adType3 = AdType.Rewarded;
											adAction3 = (AdAction)text7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v58 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
											text2 = (string)0;
											if (flag26)
											{
												goto IL_0bac;
											}
										}
										object obj51 = array2.Length & 0xFFFFFFFCL;
										bool flag27 = obj51 == null;
										adType3 = AdType.Rewarded;
										adAction3 = (AdAction)text7;
										if (!flag27)
										{
											object obj52 = array2 + 56;
											obj52 = parameter4;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj53 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
											object obj54 = obj53;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v74+E4]");
											bool flag28 = (nint)0 == 0;
											object obj55 = !flag28;
											if (obj55 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											FirebaseAnalytics.LogEvent((string)name, array2);
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
		ex2 = new IndexOutOfRangeException();
		text2 = text;
		goto IL_0bac;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_011d;
	}

	public unsafe void PurchaseEvent(string shop, TrackerPurchase purchaseType, string itemId, double price, string currencyCode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0167: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_017d: Expected I, but got O
		//IL_018d: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_039b: Expected O, but got I8
		//IL_026c: Expected O, but got I
		//IL_027c: Expected O, but got I
		//IL_029e: Expected O, but got I4
		//IL_0330: Expected I, but got O
		//IL_0340: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_02bc: Expected O, but got I
		//IL_0478: Expected O, but got I4
		//IL_0488: Expected O, but got I4
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_040d: Expected I, but got O
		//IL_041d: Expected O, but got I
		//IL_044e: Expected O, but got I
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_051d: Expected O, but got Ref
		//IL_0596: Expected O, but got I8
		//IL_0533: Expected I, but got O
		//IL_0543: Expected O, but got I
		//IL_0574: Expected O, but got I
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_0673: Expected O, but got I4
		//IL_0683: Expected O, but got I4
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected O, but got Unknown
		//IL_0608: Expected I, but got O
		//IL_0618: Expected O, but got I
		//IL_0649: Expected O, but got I
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_06ed: Expected O, but got I4
		//IL_0713: Expected O, but got Ref
		//IL_0794: Expected O, but got I4
		//IL_07a4: Expected O, but got I4
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Expected O, but got Unknown
		//IL_0729: Expected I, but got O
		//IL_0739: Expected O, but got I
		//IL_076a: Expected O, but got I
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_0897: Expected O, but got I4
		//IL_08a7: Expected O, but got I4
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_082c: Expected I, but got O
		//IL_083c: Expected O, but got I
		//IL_086d: Expected O, but got I
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected O, but got Unknown
		//IL_0965: Expected O, but got I4
		//IL_1230: Expected O, but got I
		//IL_123f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1244: Expected O, but got Unknown
		//IL_1266: Expected O, but got I
		//IL_1275: Unknown result type (might be due to invalid IL or missing references)
		//IL_127a: Expected O, but got Unknown
		//IL_09ab: Expected O, but got I
		//IL_09cf: Expected O, but got I
		//IL_09e5: Expected I, but got O
		//IL_09f5: Expected O, but got I
		//IL_0a2f: Expected O, but got I
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected O, but got Unknown
		//IL_0aa5: Expected O, but got I
		//IL_0abf: Expected O, but got I4
		//IL_12ac: Expected O, but got I
		//IL_12cb: Expected O, but got I
		//IL_0b81: Expected O, but got I8
		//IL_0b9d: Expected I4, but got O
		//IL_0ae4: Expected O, but got I4
		//IL_0af4: Expected O, but got I
		//IL_0b04: Expected O, but got I
		//IL_0b19: Expected I, but got O
		//IL_0b29: Expected O, but got I
		//IL_0b4f: Expected I4, but got O
		//IL_0b5f: Expected O, but got I
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0ccb: Expected O, but got I
		//IL_0cdb: Expected O, but got I
		//IL_0d03: Expected O, but got I4
		//IL_0d25: Expected O, but got I
		//IL_0c08: Expected O, but got I
		//IL_0c18: Expected O, but got I
		//IL_0c52: Expected O, but got I
		//IL_0c6f: Expected O, but got I4
		//IL_0c7f: Expected O, but got I
		//IL_0c8f: Expected O, but got I
		//IL_0ca4: Expected I4, but got O
		//IL_0d54: Expected I4, but got O
		//IL_0e35: Expected O, but got I4
		//IL_0e45: Expected O, but got I4
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Expected O, but got Unknown
		//IL_0e77: Expected I4, but got O
		//IL_0dc5: Expected I, but got O
		//IL_0dd5: Expected O, but got I
		//IL_0dfb: Expected I4, but got O
		//IL_0e0b: Expected O, but got I
		//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e93: Expected O, but got Unknown
		//IL_0ebd: Expected O, but got I
		//IL_0f5b: Expected I4, but got O
		//IL_133c: Expected O, but got I
		//IL_135b: Expected O, but got I
		//IL_0ef7: Expected O, but got I4
		//IL_0f07: Expected O, but got I
		//IL_0f17: Expected O, but got I
		//IL_0f2c: Expected I4, but got O
		//IL_1025: Expected O, but got I8
		//IL_1041: Expected I4, but got O
		//IL_0fbd: Expected I, but got O
		//IL_0fcd: Expected O, but got I
		//IL_0ff3: Expected I4, but got O
		//IL_1003: Expected O, but got I
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected O, but got Unknown
		//IL_107a: Expected O, but got Ref
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected O, but got Unknown
		//IL_114f: Expected O, but got I4
		//IL_115f: Expected O, but got I4
		//IL_117f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Expected O, but got Unknown
		//IL_1191: Expected I4, but got O
		//IL_10df: Expected I, but got O
		//IL_10ef: Expected O, but got I
		//IL_1115: Expected I4, but got O
		//IL_1125: Expected O, but got I
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected O, but got Unknown
		//IL_11d4: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB4]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v130+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v130+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		return;
		IL_0328:
		object[] array = default(object[]);
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v91 (Il2CppClass<System.Object[]>)+40]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		bool flag3 = ex == null;
		string text3;
		string text2 = text3;
		string text4 = itemId;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v91 (Il2CppClass<System.Object[]>)+40]");
		string text5 = (string)0;
		if (!flag3)
		{
			goto IL_0387;
		}
		goto IL_11f0;
		IL_11da:
		ex = new IndexOutOfRangeException();
		text5 = text;
		goto IL_11f0;
		IL_12d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Parameter parameter = default(Parameter);
		string text6;
		string text7;
		parameter..ctor(text6, text7);
		bool flag4 = parameter == null;
		text = text6;
		Parameter[] array2 = default(Parameter[]);
		TrackerPurchase trackerPurchase;
		if (!flag4)
		{
			nint num2 = (nint)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v69 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex == null;
			text4 = null;
			trackerPurchase = (TrackerPurchase)text7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v69 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
			text5 = (string)0;
			if (flag5)
			{
				goto IL_11f0;
			}
		}
		bool flag6 = array2.Length < 2;
		object obj6 = !flag6;
		object obj7 = array2.Length - 2;
		bool flag7 = obj7 == null;
		object obj8 = ~obj6;
		object obj9 = obj8 | flag7;
		text4 = null;
		trackerPurchase = (TrackerPurchase)text7;
		object obj12;
		double num6 = default(double);
		if (obj9 == null)
		{
			object obj10 = array2 + 48;
			obj10 = parameter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v50+B8]");
			object obj13 = 0;
			string text8;
			if (string.IsNullOrEmpty(shop))
			{
				object obj14 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v66+90]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v67+B8]");
				object obj16 = 0;
				text8 = (string)obj16;
				string text9 = null;
				int num3 = (int)text7;
				int num4 = 0;
			}
			else
			{
				bool flag8 = shop._stringLength < 101;
				string text9 = null;
				int num3 = (int)text7;
				int num4 = 0;
				text8 = shop;
				if (!flag8)
				{
					string text10 = shop.Substring(0, 100);
					text9 = null;
					num3 = 100;
					num4 = 0;
					text8 = text10;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+1F8]");
			Parameter parameter2 = default(Parameter);
			parameter2..ctor((string)0, text8);
			bool flag9 = parameter2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+1F8]");
			text = (string)0;
			if (!flag9)
			{
				nint num5 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v63 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag10 = ex == null;
				text4 = null;
				trackerPurchase = (TrackerPurchase)text8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v63 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
				text5 = (string)0;
				if (flag10)
				{
					goto IL_11f0;
				}
			}
			object obj17 = array2.Length & 0xFFFFFFFCL;
			bool flag11 = obj17 == null;
			text4 = null;
			trackerPurchase = (TrackerPurchase)text8;
			if (!flag11)
			{
				object obj18 = array2 + 56;
				obj18 = parameter2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				string text11 = ((Enum)(&num6)).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj19 = "placementId" + 1648;
				text = (string)obj19;
				Parameter parameter3 = default(Parameter);
				parameter3..ctor((string)obj19, text11);
				if (parameter3 != null)
				{
					nint num7 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v62 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag12 = ex == null;
					text4 = null;
					trackerPurchase = (TrackerPurchase)text11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v62 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
					text5 = (string)0;
					if (flag12)
					{
						goto IL_11f0;
					}
				}
				bool flag13 = array2.Length < 4;
				object obj20 = !flag13;
				object obj21 = array2.Length - 4;
				bool flag14 = obj21 == null;
				object obj22 = ~obj20;
				object obj23 = obj22 | flag14;
				text4 = null;
				trackerPurchase = (TrackerPurchase)text11;
				if (obj23 == null)
				{
					object obj24 = array2 + 64;
					obj24 = parameter3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v34+88]");
					FirebaseAnalytics.LogEvent((string)0, array2);
					return;
				}
			}
		}
		goto IL_11da;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_011d;
		IL_011d:
		object obj25 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj26 = "WhiteSmoke" + 3120;
		bool flag15 = obj26 == null;
		text = (string)7;
		if (!flag15)
		{
			nint num8 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v94 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag16 = ex == null;
			text4 = itemId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v94 (Il2CppClass<System.Object[]>)+40]");
			text5 = (string)0;
			if (flag16)
			{
				goto IL_11f0;
			}
		}
		bool flag17 = array.Length == 0;
		text4 = itemId;
		if (!flag17)
		{
			text = (string)obj26;
			object obj27 = array + 32;
			obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
			object obj28 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v17+B8]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v93+88]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v93+88]");
				bool flag18 = (nint)0 == 0;
				object obj30 = !flag18;
				if (obj30 != null)
				{
					goto IL_0328;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v93+88]");
				text2 = (string)0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v128+B8]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v92+88]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v92+88]");
				bool flag19 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v92+88]");
				text2 = (string)0;
				if (!flag19)
				{
					goto IL_0328;
				}
			}
			goto IL_0387;
		}
		goto IL_11da;
		IL_0387:
		object obj33 = array.Length & 0xFFFFFFFEL;
		bool flag20 = obj33 == null;
		text4 = itemId;
		string text15;
		string text17;
		int num18;
		if (!flag20)
		{
			object obj34 = array + 40;
			obj34 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag21 = shop == null;
			text = text2;
			if (!flag21)
			{
				nint num9 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag22 = ex == null;
				text4 = itemId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
				text5 = (string)0;
				if (flag22)
				{
					goto IL_11f0;
				}
			}
			bool flag23 = array.Length < 2;
			object obj35 = !flag23;
			object obj36 = array.Length - 2;
			bool flag24 = obj36 == null;
			object obj37 = ~obj35;
			object obj38 = obj37 | flag24;
			text4 = itemId;
			if (obj38 == null)
			{
				object obj39 = array + 48;
				obj39 = shop;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj40 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1776;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string text12 = default(string);
				bool flag25 = text12 == null;
				TrackerPurchase trackerPurchase2 = default(TrackerPurchase);
				text = (string)(&trackerPurchase2);
				if (!flag25)
				{
					nint num10 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag26 = ex == null;
					text4 = itemId;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
					text5 = (string)0;
					if (flag26)
					{
						goto IL_11f0;
					}
				}
				object obj41 = array.Length & 0xFFFFFFFCL;
				bool flag27 = obj41 == null;
				text4 = itemId;
				if (!flag27)
				{
					object obj42 = array + 56;
					obj42 = text12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag28 = itemId == null;
					text = text12;
					if (!flag28)
					{
						nint num11 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag29 = ex == null;
						text4 = itemId;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
						text5 = (string)0;
						if (flag29)
						{
							goto IL_11f0;
						}
					}
					bool flag30 = array.Length < 4;
					object obj43 = !flag30;
					object obj44 = array.Length - 4;
					bool flag31 = obj44 == null;
					object obj45 = ~obj43;
					object obj46 = obj45 | flag31;
					text4 = itemId;
					if (obj46 == null)
					{
						object obj47 = array + 64;
						obj47 = itemId;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj48 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						string text13 = default(string);
						bool flag32 = text13 == null;
						text = (string)(&num6);
						if (!flag32)
						{
							nint num12 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag33 = ex == null;
							text4 = itemId;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
							text5 = (string)0;
							if (flag33)
							{
								goto IL_11f0;
							}
						}
						bool flag34 = array.Length < 5;
						object obj49 = !flag34;
						object obj50 = array.Length - 5;
						bool flag35 = obj50 == null;
						object obj51 = ~obj49;
						object obj52 = obj51 | flag35;
						text4 = itemId;
						if (obj52 == null)
						{
							object obj53 = array + 72;
							obj53 = text13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag36 = currencyCode == null;
							text = text13;
							if (!flag36)
							{
								nint num13 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v85 (Il2CppClass<System.Object[]>)+40]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag37 = ex == null;
								text4 = itemId;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v85 (Il2CppClass<System.Object[]>)+40]");
								text5 = (string)0;
								if (flag37)
								{
									goto IL_11f0;
								}
							}
							bool flag38 = array.Length < 6;
							object obj54 = !flag38;
							object obj55 = array.Length - 6;
							bool flag39 = obj55 == null;
							object obj56 = ~obj54;
							object obj57 = obj56 | flag39;
							text4 = itemId;
							if (obj57 == null)
							{
								object obj58 = array + 80;
								obj58 = currencyCode;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1208;
								string text14 = string.Format((string)format, array);
								object obj59 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
								object obj60 = obj59;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v32+E4]");
								bool flag40 = (nint)0 == 0;
								object obj61 = !flag40;
								object obj62 = text14;
								if (obj61 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj62 = text14;
								}
								KLogger.LogAnalytics(obj62);
								object obj63 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v33+B8]");
								object obj64 = 0;
								object obj65 = typeof(TypeConverter<ushort, char>) + 3440;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object obj66 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v37+B8]");
								object obj67 = 0;
								object obj68 = typeof(MemberAchievementClanFeedData) + 3976;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v38+360]");
								Parameter parameter4 = default(Parameter);
								double parameterValue = default(double);
								parameter4..ctor((string)0, parameterValue);
								bool flag41 = parameter4 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v38+360]");
								text = (string)0;
								if (!flag41)
								{
									nint num14 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v84 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
									text = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag42 = ex == null;
									text4 = itemId;
									trackerPurchase = TrackerPurchase.None;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v84 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
									text5 = (string)0;
									if (flag42)
									{
										goto IL_11f0;
									}
								}
								bool flag43 = array2.Length == 0;
								text4 = itemId;
								trackerPurchase = TrackerPurchase.None;
								if (!flag43)
								{
									object obj69 = array2 + 32;
									obj69 = parameter4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj70 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v41+B8]");
									object obj71 = 0;
									bool flag44 = currencyCode == null;
									object obj72 = !flag44;
									text15 = currencyCode;
									if (obj72 == null)
									{
										object obj73 = 153100288 + 1024;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v81+90]");
										object obj74 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v82+B8]");
										object obj75 = 0;
										text15 = (string)obj75;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v42+1A8]");
									Parameter parameter5 = default(Parameter);
									parameter5..ctor((string)0, text15);
									bool flag45 = parameter5 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v42+1A8]");
									text = (string)0;
									if (!flag45)
									{
										nint num15 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v79 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
										text = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag46 = ex == null;
										text4 = null;
										trackerPurchase = (TrackerPurchase)text15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v79 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
										text5 = (string)0;
										if (flag46)
										{
											goto IL_11f0;
										}
									}
									object obj76 = array2.Length & 0xFFFFFFFEL;
									bool flag47 = obj76 == null;
									text4 = null;
									trackerPurchase = (TrackerPurchase)text15;
									if (!flag47)
									{
										object obj77 = array2 + 40;
										obj77 = parameter5;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										object obj78 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v63+E4]");
										int num17;
										string text16;
										int num16;
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v63+B8]");
											object obj79 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v78+220]");
											text6 = (string)0;
											bool flag48 = string.IsNullOrEmpty(itemId);
											bool flag49 = !flag48;
											num16 = 0;
											num17 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v78+220]");
											text16 = (string)0;
											if (!flag49)
											{
												goto IL_0c60;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											object obj80 = obj12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v101+B8]");
											object obj81 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v72+220]");
											text6 = (string)0;
											bool flag50 = string.IsNullOrEmpty(itemId);
											bool flag51 = !flag50;
											object obj82 = !flag51;
											num16 = 0;
											num17 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v72+220]");
											text16 = (string)0;
											if (obj82 != null)
											{
												goto IL_0c60;
											}
										}
										bool flag52 = itemId._stringLength < 101;
										text17 = null;
										num18 = (int)text15;
										num16 = num17;
										text7 = itemId;
										text6 = text16;
										if (!flag52)
										{
											string text18 = itemId.Substring(0, 100);
											text17 = null;
											num18 = 100;
											num16 = 0;
											text7 = text18;
											text6 = text16;
										}
										goto IL_12d9;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_11da;
		IL_11f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_0c60:
		object obj83 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v75+90]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v76+B8]");
		object obj85 = 0;
		text7 = (string)obj85;
		text17 = null;
		num18 = (int)text15;
		goto IL_12d9;
	}

	public void DesignEvent(ITrackEvent trackEvent)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0161: Expected I, but got O
		//IL_0171: Expected O, but got I
		//IL_01fc: Expected I, but got O
		//IL_0d0f: Expected O, but got I4
		//IL_01ac: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_025a: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0270: Expected I, but got O
		//IL_0280: Expected O, but got I
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		//IL_0d81: Expected O, but got I4
		//IL_02bb: Expected O, but got I
		//IL_035c: Expected O, but got I4
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I8
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_041a: Expected O, but got I4
		//IL_0430: Expected O, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04bc: Expected O, but got I8
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_051b: Expected O, but got I4
		//IL_0531: Expected O, but got I
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected O, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_0dab: Expected O, but got I4
		//IL_0dbb: Expected O, but got I4
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Expected O, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_068f: Expected O, but got I4
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Expected O, but got Unknown
		//IL_06d2: Expected O, but got I
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Expected O, but got Unknown
		//IL_08eb: Expected O, but got I4
		//IL_08fb: Expected O, but got I
		//IL_090b: Expected O, but got I
		//IL_074b: Expected I, but got O
		//IL_0e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected O, but got Unknown
		//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea7: Expected O, but got Unknown
		//IL_0ed8: Expected O, but got I4
		//IL_0ee0: Expected I, but got O
		//IL_09a6: Expected O, but got I4
		//IL_07f8: Expected I, but got O
		//IL_0a64: Expected O, but got I4
		//IL_0a6c: Expected I, but got O
		//IL_0786: Expected I, but got O
		//IL_0796: Expected O, but got I
		//IL_07bc: Expected I, but got O
		//IL_07cc: Expected O, but got I
		//IL_09f2: Expected I, but got O
		//IL_0a02: Expected O, but got I
		//IL_0a24: Expected O, but got I4
		//IL_0a2c: Expected I, but got O
		//IL_0a3c: Expected O, but got I
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0aa1: Expected O, but got I4
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected O, but got Unknown
		//IL_0f36: Expected O, but got I4
		//IL_0ada: Expected I, but got O
		//IL_0868: Expected O, but got I4
		//IL_0878: Expected O, but got I
		//IL_0888: Expected O, but got I
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e44: Expected O, but got Unknown
		//IL_0be4: Expected O, but got I8
		//IL_0bfc: Expected O, but got I4
		//IL_0c0c: Expected I, but got O
		//IL_0b49: Expected O, but got I4
		//IL_0b70: Expected I, but got O
		//IL_0b80: Expected O, but got I
		//IL_0ba2: Expected O, but got I4
		//IL_0bb2: Expected I, but got O
		//IL_0bc2: Expected O, but got I
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0c41: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB5]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v94+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v94+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		if (trackEvent != null)
		{
			goto IL_011d;
		}
		return;
		IL_0c88:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0c96;
		IL_0cde:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v313 @ X0_v3] (should have been resolved before IL gen)");
		string text = default(string);
		bool flag2 = string.IsNullOrEmpty(text);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		string text2 = SanitizeEventName(text);
		bool flag4 = string.IsNullOrEmpty(text2);
		bool flag5 = !flag4;
		object obj6 = !flag5;
		if (obj6 != null)
		{
			return;
		}
		nint num = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02fc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v7 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		object obj9;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X10_v7-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_02fc;
		}
		object obj10 = obj8 + 6;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		goto IL_0d41;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num2 = unchecked((nint)null);
		goto IL_0cde;
		IL_0074:
		noPlayServices = KUtil.NoPlayServices;
		bool flag6 = trackEvent == null;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			return;
		}
		goto IL_011d;
		IL_011d:
		bool flag7 = !noPlayServices;
		object obj14 = !flag7;
		if (obj14 != null)
		{
			return;
		}
		obj9 = typeof(System.IOAsyncCallback) + 1816;
		nint num3 = (nint)trackEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v4 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v4 (Il2CppClass<DataTracking.ITrackEvent>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v4 (Il2CppClass<DataTracking.ITrackEvent>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X10_v12-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_01ed;
		}
		object obj17 = num3 + obj16;
		object obj18 = obj17 + 312;
		goto IL_0cde;
		IL_02fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 6;
		goto IL_0d41;
		IL_0d41:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v418 @ X0_v10] (should have been resolved before IL gen)");
		object obj19 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		bool flag8 = array == null;
		string text3 = (string)6;
		Parameter[] parameters;
		NullReferenceException ex2 = default(NullReferenceException);
		if (!flag8)
		{
			bool flag9 = array.Length == 0;
			text3 = (string)6;
			if (!flag9)
			{
				object obj20 = "WhiteSmoke" + 3128;
				text3 = (string)obj20;
				object obj21 = array + 32;
				obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X23_v7-8]");
				object obj22 = 0 & 0xFFFFFFFEL;
				if (obj22 != null)
				{
					object obj23 = array + 40;
					obj23 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X23_v9-10]");
					bool flag10 = (nint)0 < (nint)2;
					object obj24 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X23_v9-10]");
					object obj25 = -2;
					bool flag11 = obj25 == null;
					object obj26 = ~obj24;
					object obj27 = obj26 | flag11;
					text3 = text2;
					if (obj27 == null)
					{
						object obj28 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2408;
						text3 = (string)obj28;
						object obj29 = array + 48;
						obj29 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X23_v11-18]");
						object obj30 = 0 & 0xFFFFFFFCL;
						if (obj30 != null)
						{
							object obj31 = array + 56;
							obj31 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X23_v13-20]");
							bool flag12 = (nint)0 < (nint)4;
							object obj32 = !flag12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X23_v13-20]");
							object obj33 = -4;
							bool flag13 = obj33 == null;
							object obj34 = ~obj32;
							object obj35 = obj34 | flag13;
							text3 = text;
							if (obj35 == null)
							{
								object obj36 = "&action=sign-up" + 1032;
								object obj37 = array + 64;
								obj37 = obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								float? num4 = default(float?);
								object obj38 = (??)num4 & 1;
								float? num5 = default(float?);
								if (obj38 != null)
								{
									float value = num5.Value;
									float num6 = default(float);
									string text4 = num6.ToString();
									double num7 = value;
									text3 = text4;
								}
								else
								{
									object obj39 = "not" + 344;
									text3 = (string)obj39;
									num5 = num4;
								}
								bool flag14 = array.Length < 5;
								object obj40 = !flag14;
								object obj41 = array.Length - 5;
								bool flag15 = obj41 == null;
								object obj42 = ~obj40;
								object obj43 = obj42 | flag15;
								if (obj43 == null)
								{
									object obj44 = array + 72;
									obj44 = text3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									string text5 = string.Concat(array);
									object obj45 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
									object obj46 = obj45;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v30+E4]");
									bool flag16 = (nint)0 == 0;
									object obj47 = !flag16;
									object obj48 = text5;
									if (obj47 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj48 = text5;
									}
									KLogger.LogAnalytics(obj48);
									object obj49 = typeof(TypeConverter<ushort, char>) + 3440;
									if ((nint)num4 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										object obj50 = (nint)0 + (nint)112;
										float value2 = num5.Value;
										object obj51 = typeof(MemberAchievementClanFeedData) + 3976;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj52 = "utf-32" + 208;
										text3 = (string)obj52;
										Parameter parameter = default(Parameter);
										parameter..ctor((string)obj52, value2);
										Parameter[] array2 = default(Parameter[]);
										bool flag17 = array2 == null;
										double num7 = value2;
										num2 = unchecked((nint)null);
										if (!flag17)
										{
											bool flag18 = parameter == null;
											string text6 = (string)obj52;
											if (!flag18)
											{
												nint num8 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v66 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
												text6 = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag19 = ex2 == null;
												num7 = value2;
												num2 = unchecked((nint)null);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v66 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
												text3 = (string)0;
												if (flag19)
												{
													goto IL_0ca4;
												}
											}
											bool flag20 = array2.Length == 0;
											num7 = value2;
											num2 = unchecked((nint)null);
											text3 = text6;
											if (!flag20)
											{
												object obj53 = array2 + 32;
												obj53 = parameter;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												string text7;
												object obj57;
												if (string.IsNullOrEmpty(text))
												{
													object obj54 = 153100288 + 1024;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v63+90]");
													object obj55 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v64+B8]");
													object obj56 = 0;
													text7 = (string)obj56;
													int num9 = 0;
													int num10 = 0;
												}
												else
												{
													bool flag21 = text == null;
													num7 = value2;
													num2 = unchecked((nint)null);
													text3 = null;
													if (flag21)
													{
														goto IL_0c96;
													}
													bool flag22 = text._stringLength < 101;
													int num9 = 0;
													int num10 = 0;
													text7 = text;
													if (!flag22)
													{
														string text8 = text.Substring(0, 100);
														obj57 = 0;
														num9 = 100;
														num10 = 0;
														text7 = text8;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj58 = "placementId" + 2280;
												string text9 = (string)obj58;
												Parameter parameter2 = default(Parameter);
												parameter2..ctor((string)obj58, text7);
												if (parameter2 != null)
												{
													nint num11 = (nint)array2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v60 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
													text9 = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag23 = ex2 == null;
													obj57 = 0;
													num7 = value2;
													num2 = (nint)text7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v60 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
													text3 = (string)0;
													if (flag23)
													{
														goto IL_0ca4;
													}
												}
												object obj59 = array2.Length & 0xFFFFFFFEL;
												bool flag24 = obj59 == null;
												obj57 = 0;
												num7 = value2;
												num2 = (nint)text7;
												text3 = text9;
												if (!flag24)
												{
													object obj60 = array2 + 40;
													obj60 = parameter2;
													object obj61 = 0;
													num7 = value2;
													string text10 = text7;
													Parameter parameter3 = parameter2;
													parameters = array2;
													goto IL_0eee;
												}
											}
											goto IL_0c88;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										string text11;
										object obj57;
										if (string.IsNullOrEmpty(text))
										{
											object obj62 = 153100288 + 1024;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v46+90]");
											object obj63 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v47+B8]");
											object obj64 = 0;
											text11 = (string)obj64;
											int num12 = (int)num2;
											int num13 = 0;
										}
										else
										{
											bool flag25 = text == null;
											text3 = null;
											if (flag25)
											{
												goto IL_0c96;
											}
											bool flag26 = text._stringLength < 101;
											int num12 = (int)num2;
											int num13 = 0;
											text11 = text;
											if (!flag26)
											{
												string text12 = text.Substring(0, 100);
												obj57 = 0;
												num12 = 100;
												num13 = 0;
												text11 = text12;
											}
										}
										object obj65 = typeof(MemberAchievementClanFeedData) + 3976;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj66 = "placementId" + 2280;
										text3 = (string)obj66;
										Parameter parameter4 = default(Parameter);
										parameter4..ctor((string)obj66, text11);
										Parameter[] array3 = default(Parameter[]);
										bool flag27 = array3 == null;
										obj57 = 0;
										num2 = (nint)text11;
										if (!flag27)
										{
											bool flag28 = parameter4 == null;
											string text13 = (string)obj66;
											if (!flag28)
											{
												nint num14 = (nint)array3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v43 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
												text13 = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag29 = ex2 == null;
												obj57 = 0;
												num2 = (nint)text11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v43 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
												text3 = (string)0;
												if (flag29)
												{
													goto IL_0ca4;
												}
											}
											bool flag30 = array3.Length == 0;
											obj57 = 0;
											num2 = (nint)text11;
											text3 = text13;
											if (flag30)
											{
												goto IL_0c88;
											}
											object obj60 = array3 + 32;
											obj60 = parameter4;
											object obj61 = 0;
											string text10 = text11;
											Parameter parameter3 = parameter4;
											parameters = array3;
											goto IL_0eee;
										}
									}
									goto IL_0c96;
								}
							}
						}
					}
				}
			}
			goto IL_0c88;
		}
		goto IL_0c96;
		IL_0ca4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0c96:
		ex2 = new NullReferenceException();
		goto IL_0ca4;
		IL_0eee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj67 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj68 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v43+E4]");
		bool flag31 = (nint)0 == 0;
		object obj69 = !flag31;
		if (obj69 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FirebaseAnalytics.LogEvent(text2, parameters);
	}

	public unsafe void ResourceEvent(ResourceFlowType flowType, ResourceItemType type, string itemId, double amount, ResourceCurrency currency)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0184: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_0ef9: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		//IL_1015: Expected O, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I4
		//IL_01dd: Expected I, but got O
		//IL_01ed: Expected O, but got I
		//IL_021e: Expected O, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_030b: Expected O, but got I8
		//IL_02a8: Expected I, but got O
		//IL_02b8: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_034e: Expected O, but got I
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_0392: Expected O, but got Ref
		//IL_0413: Expected O, but got I4
		//IL_0423: Expected O, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_03a8: Expected I, but got O
		//IL_03b8: Expected O, but got I
		//IL_03e9: Expected O, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_04b8: Expected O, but got Ref
		//IL_0531: Expected O, but got I8
		//IL_04ce: Expected I, but got O
		//IL_04de: Expected O, but got I
		//IL_050f: Expected O, but got I
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_060e: Expected O, but got I4
		//IL_061e: Expected O, but got I4
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_05a3: Expected I, but got O
		//IL_05b3: Expected O, but got I
		//IL_05e4: Expected O, but got I
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0688: Expected O, but got I4
		//IL_06ae: Expected O, but got Ref
		//IL_072f: Expected O, but got I4
		//IL_073f: Expected O, but got I4
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_06c4: Expected I, but got O
		//IL_06d4: Expected O, but got I
		//IL_0705: Expected O, but got I
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_07d4: Expected O, but got Ref
		//IL_0855: Expected O, but got I4
		//IL_0865: Expected O, but got I4
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_07ea: Expected I, but got O
		//IL_07fa: Expected O, but got I
		//IL_082b: Expected O, but got I
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected O, but got Unknown
		//IL_0923: Expected O, but got I4
		//IL_0f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f24: Expected O, but got Unknown
		//IL_0f6b: Expected O, but got I
		//IL_0f75: Expected O, but got Ref
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected O, but got Unknown
		//IL_0fb0: Expected O, but got I
		//IL_099b: Expected O, but got I
		//IL_0a23: Expected I4, but got O
		//IL_09b1: Expected I, but got O
		//IL_09c1: Expected O, but got I
		//IL_09e7: Expected I4, but got O
		//IL_09f7: Expected O, but got I
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected O, but got Unknown
		//IL_0a69: Expected O, but got I
		//IL_0a91: Expected O, but got I
		//IL_0ab0: Expected O, but got I
		//IL_0b2f: Expected O, but got I8
		//IL_0ac6: Expected I, but got O
		//IL_0ad6: Expected O, but got I
		//IL_0b0d: Expected O, but got I
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0b92: Expected O, but got I
		//IL_0fd8: Expected O, but got I
		//IL_0ff7: Expected O, but got I
		//IL_0bcd: Expected O, but got I
		//IL_0bdd: Expected O, but got I
		//IL_0cf5: Expected O, but got I4
		//IL_0d05: Expected O, but got I4
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Expected O, but got Unknown
		//IL_0d37: Expected I4, but got O
		//IL_0c85: Expected I, but got O
		//IL_0c95: Expected O, but got I
		//IL_0cbb: Expected I4, but got O
		//IL_0ccb: Expected O, but got I
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected O, but got Unknown
		//IL_0d70: Expected O, but got Ref
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected O, but got Unknown
		//IL_0e3d: Expected O, but got I8
		//IL_0e59: Expected I4, but got O
		//IL_0dd5: Expected I, but got O
		//IL_0de5: Expected O, but got I
		//IL_0e0b: Expected I4, but got O
		//IL_0e1b: Expected O, but got I
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Expected O, but got Unknown
		//IL_0e9c: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB6]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v120+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v120+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		return;
		IL_0eb8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_011d:
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj8 = obj6;
		if (flowType == ResourceFlowType.Source)
		{
			object obj9 = 64;
		}
		else
		{
			object obj9 = 216;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v4+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj12 = "WhiteSmoke" + 3120;
		bool flag4 = obj12 == null;
		string text = (string)7;
		object[] array = default(object[]);
		string text2;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		string text3;
		if (!flag4)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v68 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex2 == null;
			text2 = itemId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v68 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			if (flag5)
			{
				goto IL_0eb8;
			}
		}
		bool flag6 = array.Length == 0;
		text2 = itemId;
		if (!flag6)
		{
			text = (string)obj12;
			object obj13 = array + 32;
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v5+v307 @ X21_v4]");
			if ((nint)0 != 0)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v67 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag7 = ex2 == null;
				text2 = itemId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v67 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				if (flag7)
				{
					goto IL_0eb8;
				}
			}
			object obj14 = array.Length & 0xFFFFFFFEL;
			bool flag8 = obj14 == null;
			text2 = itemId;
			if (!flag8)
			{
				object obj15 = array + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v5+v307 @ X21_v4]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj16 = typeof(RegisteredWaitHandle) + 912;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj17 = default(object);
				bool flag9 = obj17 == null;
				ResourceFlowType resourceFlowType = default(ResourceFlowType);
				text = (string)(&resourceFlowType);
				if (!flag9)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag10 = ex2 == null;
					text2 = itemId;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					if (flag10)
					{
						goto IL_0eb8;
					}
				}
				bool flag11 = array.Length < 2;
				object obj18 = !flag11;
				object obj19 = array.Length - 2;
				bool flag12 = obj19 == null;
				object obj20 = ~obj18;
				object obj21 = obj20 | flag12;
				text2 = itemId;
				if (obj21 == null)
				{
					object obj22 = array + 48;
					obj22 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj23 = typeof(RegisteredWaitHandle) + 936;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					string text4 = default(string);
					bool flag13 = text4 == null;
					ResourceItemType resourceItemType = default(ResourceItemType);
					text = (string)(&resourceItemType);
					if (!flag13)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v65 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag14 = ex2 == null;
						text2 = itemId;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v65 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						if (flag14)
						{
							goto IL_0eb8;
						}
					}
					object obj24 = array.Length & 0xFFFFFFFCL;
					bool flag15 = obj24 == null;
					text2 = itemId;
					if (!flag15)
					{
						object obj25 = array + 56;
						obj25 = text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag16 = itemId == null;
						text = text4;
						if (!flag16)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag17 = ex2 == null;
							text2 = itemId;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
							text3 = (string)0;
							if (flag17)
							{
								goto IL_0eb8;
							}
						}
						bool flag18 = array.Length < 4;
						object obj26 = !flag18;
						object obj27 = array.Length - 4;
						bool flag19 = obj27 == null;
						object obj28 = ~obj26;
						object obj29 = obj28 | flag19;
						text2 = itemId;
						if (obj29 == null)
						{
							object obj30 = array + 64;
							obj30 = itemId;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj31 = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object obj32 = default(object);
							bool flag20 = obj32 == null;
							double num6 = default(double);
							text = (string)(&num6);
							if (!flag20)
							{
								nint num7 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag21 = ex2 == null;
								text2 = itemId;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
								text3 = (string)0;
								if (flag21)
								{
									goto IL_0eb8;
								}
							}
							bool flag22 = array.Length < 5;
							object obj33 = !flag22;
							object obj34 = array.Length - 5;
							bool flag23 = obj34 == null;
							object obj35 = ~obj33;
							object obj36 = obj35 | flag23;
							text2 = itemId;
							if (obj36 == null)
							{
								object obj37 = array + 72;
								obj37 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj38 = typeof(RegisteredWaitHandle) + 896;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object obj39 = default(object);
								bool flag24 = obj39 == null;
								ResourceCurrency resourceCurrency = default(ResourceCurrency);
								text = (string)(&resourceCurrency);
								if (!flag24)
								{
									nint num8 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag25 = ex2 == null;
									text2 = itemId;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
									text3 = (string)0;
									if (flag25)
									{
										goto IL_0eb8;
									}
								}
								bool flag26 = array.Length < 6;
								object obj40 = !flag26;
								object obj41 = array.Length - 6;
								bool flag27 = obj41 == null;
								object obj42 = ~obj40;
								object obj43 = obj42 | flag27;
								text2 = itemId;
								if (obj43 == null)
								{
									object obj44 = array + 80;
									obj44 = obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1224;
									string text5 = string.Format((string)format, array);
									object obj45 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
									object obj46 = obj45;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v31+E4]");
									bool flag28 = (nint)0 == 0;
									object obj47 = !flag28;
									object obj48 = text5;
									if (obj47 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj48 = text5;
									}
									KLogger.LogAnalytics(obj48);
									object obj49 = typeof(TypeConverter<ushort, char>) + 3440;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									object obj50 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v57+E4]");
									object obj51;
									if ((nint)0 != 0)
									{
										obj51 = obj6;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj50 = obj6;
										obj51 = obj6;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v57+B8]");
									object obj52 = 0;
									object obj53 = default(object);
									string text6 = ((Enum)(&obj53)).ToString();
									object obj54 = typeof(MemberAchievementClanFeedData) + 3976;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v35+368]");
									Parameter parameter = default(Parameter);
									parameter..ctor((string)0, text6);
									bool flag29 = parameter == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v35+368]");
									text = (string)0;
									Parameter[] array2 = default(Parameter[]);
									ResourceItemType resourceItemType2;
									if (!flag29)
									{
										nint num9 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v61 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
										text = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag30 = ex2 == null;
										text2 = null;
										resourceItemType2 = (ResourceItemType)text6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v61 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
										text3 = (string)0;
										if (flag30)
										{
											goto IL_0eb8;
										}
									}
									bool flag31 = array2.Length == 0;
									text2 = null;
									resourceItemType2 = (ResourceItemType)text6;
									if (!flag31)
									{
										object obj55 = array2 + 32;
										obj55 = parameter;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										object obj56 = obj51;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v39+B8]");
										object obj57 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v40+360]");
										Parameter parameter2 = default(Parameter);
										double parameterValue = default(double);
										parameter2..ctor((string)0, parameterValue);
										bool flag32 = parameter2 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v40+360]");
										text = (string)0;
										if (!flag32)
										{
											nint num10 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v60 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
											text = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag33 = ex2 == null;
											text2 = null;
											resourceItemType2 = (ResourceItemType)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v60 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
											text3 = (string)0;
											if (flag33)
											{
												goto IL_0eb8;
											}
										}
										object obj58 = array2.Length & 0xFFFFFFFEL;
										bool flag34 = obj58 == null;
										text2 = null;
										resourceItemType2 = (ResourceItemType)0;
										if (!flag34)
										{
											object obj59 = array2 + 40;
											obj59 = parameter2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj60 = obj51;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v43+B8]");
											object obj61 = 0;
											string text7;
											if (string.IsNullOrEmpty(itemId))
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X26_v7+90]");
												object obj62 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v58+B8]");
												object obj63 = 0;
												text7 = (string)obj63;
												string text8 = null;
												int num11 = 0;
												int num12 = 0;
											}
											else
											{
												bool flag35 = itemId._stringLength < 101;
												string text8 = null;
												int num11 = 0;
												int num12 = 0;
												text7 = itemId;
												if (!flag35)
												{
													string text9 = itemId.Substring(0, 100);
													text8 = null;
													num11 = 100;
													num12 = 0;
													text7 = text9;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v44+220]");
											Parameter parameter3 = default(Parameter);
											parameter3..ctor((string)0, text7);
											bool flag36 = parameter3 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v44+220]");
											text = (string)0;
											if (!flag36)
											{
												nint num13 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v56 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
												text = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag37 = ex2 == null;
												text2 = null;
												resourceItemType2 = (ResourceItemType)text7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v56 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
												text3 = (string)0;
												if (flag37)
												{
													goto IL_0eb8;
												}
											}
											bool flag38 = array2.Length < 2;
											object obj64 = !flag38;
											object obj65 = array2.Length - 2;
											bool flag39 = obj65 == null;
											object obj66 = ~obj64;
											object obj67 = obj66 | flag39;
											text2 = null;
											resourceItemType2 = (ResourceItemType)text7;
											if (obj67 == null)
											{
												object obj68 = array2 + 48;
												obj68 = parameter3;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object obj69 = default(object);
												string text10 = ((Enum)(&obj69)).ToString();
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj70 = "https://www.kammelna.com/Home/Terms" + 3880;
												text = (string)obj70;
												Parameter parameter4 = default(Parameter);
												parameter4..ctor((string)obj70, text10);
												if (parameter4 != null)
												{
													nint num14 = (nint)array2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v55 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
													text = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag40 = ex2 == null;
													text2 = null;
													resourceItemType2 = (ResourceItemType)text10;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v55 (Il2CppClass<Firebase.Analytics.Parameter[]>)+40]");
													text3 = (string)0;
													if (flag40)
													{
														goto IL_0eb8;
													}
												}
												object obj71 = array2.Length & 0xFFFFFFFCL;
												bool flag41 = obj71 == null;
												text2 = null;
												resourceItemType2 = (ResourceItemType)text10;
												if (!flag41)
												{
													object obj72 = array2 + 56;
													obj72 = parameter4;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v5+v307 @ X21_v4]");
													FirebaseAnalytics.LogEvent((string)0, array2);
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
		}
		ex2 = new IndexOutOfRangeException();
		text3 = text;
		goto IL_0eb8;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_011d;
	}

	public void SetDimensions(DimensionsModel dimensions)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b8: Expected I, but got O
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0137: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I4
		//IL_026e: Expected O, but got I
		//IL_027f: Expected O, but got I
		//IL_029d: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02e0: Expected O, but got I
		//IL_0313: Expected O, but got I4
		//IL_0359: Expected O, but got I
		//IL_03e9: Expected O, but got I
		//IL_040b: Expected O, but got I
		//IL_04bf: Expected O, but got I4
		//IL_0386: Expected O, but got I
		//IL_0396: Expected O, but got I
		//IL_03ae: Expected O, but got I
		//IL_0434: Expected O, but got I
		string text = (string)(typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DB7]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			nint num = (nint)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v30 (Il2CppClass<System.String>)+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			nint num = (nint)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v30 (Il2CppClass<System.String>)+E4]");
			bool flag = (nint)0 == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		if (dimensions != null)
		{
			goto IL_011d;
		}
		return;
		IL_011d:
		bool flag2 = !noPlayServices;
		object obj3 = !flag2;
		if (obj3 != null)
		{
			return;
		}
		string[] dimensionArray = dimensions.DimensionArray;
		if (dimensions.DimensionArray == null)
		{
			return;
		}
		object obj4 = 153100288 + 1024;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1232;
		object arg = "WhiteSmoke" + 3120;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object format2 = "destinationTimeZone" + 280;
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 712;
		object obj7 = 0;
		DimensionsModel dimensionsModel = dimensions;
		object arg2 = default(object);
		object arg3 = default(object);
		while ((nint)obj7 < dimensionArray.Length)
		{
			object obj8 = (object)dimensionArray + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
			string text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
			bool flag3 = string.IsNullOrEmpty((string)0);
			bool flag4 = !flag3;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				object obj10 = obj7 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
				string text3 = string.Format((string)format, arg, arg2, 0);
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v8+E4]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				object obj13 = text3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = text3;
					dimensionsModel = dimensions;
				}
				KLogger.LogAnalytics(obj13);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string name = string.Format((string)format2, arg3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
				string property;
				if (string.IsNullOrEmpty((string)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X23_v7+90]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v12+B8]");
					object obj15 = 0;
					property = (string)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
					object obj16 = 0;
					int num2 = 0;
					int num3 = 0;
				}
				else
				{
					bool flag6 = text2._stringLength < 101;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
					object obj16 = 0;
					int num2 = 0;
					int num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
					property = (string)0;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v6+20]");
						string text4 = ((string)0).Substring(0, 100);
						obj16 = null;
						num2 = 100;
						num3 = 0;
						property = text4;
					}
				}
				object obj17 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v20+E4]");
				bool flag7 = (nint)0 == 0;
				object obj18 = !flag7;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				FirebaseAnalytics.SetUserProperty(name, property);
				object obj19 = obj10;
				object obj20 = obj10;
			}
			dimensionArray = dimensionsModel.DimensionArray;
			obj7++;
		}
		return;
		IL_0074:
		noPlayServices = KUtil.NoPlayServices;
		bool flag8 = dimensions == null;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			return;
		}
		goto IL_011d;
	}

	private static string SanitizeEventName(string raw)
	{
		//IL_0681: Expected O, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		//IL_05fb: Expected O, but got I
		//IL_061d: Expected O, but got I4
		//IL_0393: Expected O, but got I
		//IL_03a3: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_02da: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_03e6: Expected O, but got I4
		//IL_03ee: Expected O, but got I4
		//IL_03f6: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_0360: Expected O, but got I4
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_044e: Expected O, but got I4
		//IL_0457: Expected O, but got I4
		//IL_06a5: Expected O, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_049f: Expected O, but got I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_04e7: Expected O, but got I4
		//IL_0264: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		bool flag = string.IsNullOrEmpty(raw);
		bool flag2 = !flag;
		object obj = !flag2;
		string text = raw;
		if (obj != null)
		{
			goto IL_05c9;
		}
		bool flag3 = raw == null;
		string text2 = raw;
		StringBuilder stringBuilder = default(StringBuilder);
		string text3;
		string text4;
		object obj15;
		object obj16 = default(object);
		if (!flag3)
		{
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			stringBuilder..ctor(raw._stringLength);
			object obj3 = 153100288 + 1024;
			if (raw._stringLength >= 1)
			{
				bool flag4 = stringBuilder == null;
				text2 = raw;
				if (flag4)
				{
					char c = text2.get_Chars(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X23_v3+88]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v9+E4]");
					bool flag5 = (nint)0 == 0;
					object obj5 = !flag5;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = char.IsLetterOrDigit(c);
					return (string)(object)new NullReferenceException();
				}
				object obj6 = 0;
				int num = 0;
				do
				{
					char c2 = raw.get_Chars(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X23_v3+88]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v52+E4]");
					bool flag7;
					char value;
					bool flag9;
					if ((nint)0 != 0)
					{
						flag7 = char.IsLetterOrDigit(c2);
						bool flag8 = !flag7;
						object obj8 = !flag8;
						value = c2;
						if (obj8 == null)
						{
							flag9 = flag7;
							goto IL_0222;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag9 = char.IsLetterOrDigit(c2);
						bool flag10 = !flag9;
						object obj9 = !flag10;
						value = c2;
						flag7 = flag9;
						if (obj9 == null)
						{
							goto IL_0222;
						}
					}
					goto IL_0697;
					IL_0222:
					object obj10 = obj6 & 1;
					if (obj10 == null)
					{
						int length = stringBuilder.Length;
						if (length >= 1)
						{
							value = '_';
							flag7 = flag9;
							goto IL_0697;
						}
						obj6 = 0;
					}
					else
					{
						obj6 = 1;
					}
					goto IL_010c;
					IL_010c:
					num++;
					continue;
					IL_0697:
					obj6 = (flag7 ? 1 : 0) ^ 1;
					StringBuilder stringBuilder2 = stringBuilder.Append(value);
					goto IL_010c;
				}
				while (num < raw._stringLength);
			}
			bool flag11 = stringBuilder == null;
			text2 = raw;
			if (!flag11)
			{
				if (stringBuilder.Length == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X23_v3+90]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v11+B8]");
					object obj12 = 0;
					text = (string)obj12;
					goto IL_05c9;
				}
				char c3 = stringBuilder.get_Chars(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X23_v3+88]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13+E4]");
				if ((nint)0 != 0)
				{
					bool flag12 = char.IsLetter(c3);
					bool flag13 = !flag12;
					text3 = raw;
					text2 = raw;
					if (!flag13)
					{
						goto IL_0339;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag14 = char.IsLetter(c3);
					bool flag15 = !flag14;
					object obj14 = !flag15;
					text3 = (string)c3;
					text2 = (string)c3;
					if (obj14 != null)
					{
						goto IL_0339;
					}
				}
				object value2 = "java.io.FileOutputStream" + 472;
				StringBuilder stringBuilder3 = stringBuilder.Insert(0, (string)value2);
				text4 = stringBuilder.ToString();
				bool flag16 = text4 == null;
				obj15 = 0;
				obj16 = 0;
				if (!flag16)
				{
					goto IL_0465;
				}
			}
		}
		goto IL_05ce;
		IL_0465:
		object value3 = "fetch_products" + 312;
		bool flag17 = text4.StartsWith((string)value3);
		bool flag18 = !flag17;
		object obj17 = !flag18;
		if (obj17 == null)
		{
			object value4 = "getSecondRescanTask" + 1776;
			bool flag19 = text4.StartsWith((string)value4);
			bool flag20 = !flag19;
			object obj18 = !flag20;
			if (obj18 == null)
			{
				object value5 = "fetch_products" + 2328;
				bool flag21 = text4.StartsWith((string)value5);
				bool flag22 = !flag21;
				text = text4;
				if (flag22)
				{
					goto IL_058b;
				}
			}
		}
		object obj19 = "java.io.FileOutputStream" + 472;
		string text5 = (string)obj19 + text4;
		bool flag23 = text5 == null;
		text = text5;
		obj16 = obj15;
		text2 = text5;
		if (!flag23)
		{
			goto IL_058b;
		}
		goto IL_05ce;
		IL_05ce:
		throw new NullReferenceException();
		IL_0339:
		text4 = stringBuilder.ToString();
		bool flag24 = text4 == null;
		object obj20 = !flag24;
		obj15 = obj16;
		if (obj20 != null)
		{
			goto IL_0465;
		}
		text2 = text3;
		goto IL_05ce;
		IL_058b:
		if (text._stringLength >= 41)
		{
			return text.Substring(0, 40);
		}
		goto IL_05c9;
		IL_05c9:
		return text;
	}

	private static string TrimValue(string value)
	{
		//IL_0035: Expected O, but got I4
		//IL_0045: Expected O, but got I
		//IL_0055: Expected O, but got I
		if (string.IsNullOrEmpty(value))
		{
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v3+90]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v4+B8]");
			return (string)0;
		}
		if (value != null)
		{
			if (value._stringLength < 101)
			{
				return value;
			}
			return value.Substring(0, 100);
		}
		return (string)(object)new NullReferenceException();
	}
}
