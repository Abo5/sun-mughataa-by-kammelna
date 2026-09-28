using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.UI;

public class PersonalizedStatsStrip : MonoBehaviour
{
	private TextMeshProUGUI textTitle;

	private TextMeshProUGUI textField;

	private TextMeshProUGUI textComparisonField;

	private GameObject textComparisionNotch;

	private Image statIcon;

	private Image gradientMask;

	private List<SpecificReportImage> specificTypeImages;

	private PersonalStatSpriteStore spriteStore;

	private PersonalReportTypeConfig _serverConfig;

	public void Initialize(PersonalizedStat stat, StatisticsReportType reportType, PersonalReportTypeConfig serverConfig = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_0089: Expected O, but got I4
		object obj = this + 96;
		obj = serverConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X21_v2-8]");
		ReportTypedSprite config = ((PersonalStatSpriteStore)0).GetConfig(stat.Metric);
		if (serverConfig != null)
		{
			bool flag = string.IsNullOrEmpty(serverConfig.<Title>k__BackingField);
			bool flag2 = !flag;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				TextMeshProExtensions.FixArabic(textTitle, serverConfig.<Title>k__BackingField);
				goto IL_00f9;
			}
		}
		else
		{
			bool flag3 = string.IsNullOrEmpty(null);
		}
		TextMeshProExtensions.Localize(text: config?.ReportTitle, textMesh: textTitle);
		goto IL_00f9;
		IL_00f9:
		string text = CraftMainReport(stat);
		TextMeshProExtensions.FixArabic(textField, text);
		GameObject gameObject;
		bool active;
		if (TryBuildComparison(stat, reportType, out var text2))
		{
			TextMeshProExtensions.FixArabic(textComparisonField, text2);
			gameObject = textComparisionNotch;
			active = true;
		}
		else
		{
			gameObject = textComparisionNotch;
			active = false;
		}
		gameObject.SetActive(active);
		ShowIcon(stat.Metric, config);
	}

	private unsafe bool TryBuildComparison(PersonalizedStat stat, StatisticsReportType reportType, out string text)
	{
		//IL_0124: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_061e: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01df: Expected O, but got I4
		//IL_04d3: Expected O, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0240: Expected O, but got I8
		//IL_0269: Expected O, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_031c: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0393: Expected O, but got I8
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_0402: Expected O, but got I4
		//IL_0412: Expected O, but got I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		ref string reference = ref *(string*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool result;
		StatisticsReportType statisticsReportType;
		string text3;
		NullReferenceException ex2;
		if (stat != null)
		{
			if (stat.Value >= 1)
			{
				bool flag = stat.PreviousValue < 1;
				result = false;
				if (!flag)
				{
					bool flag2 = stat.Value <= stat.PreviousValue;
					result = false;
					if (!flag2)
					{
						PersonalReportTypeConfig serverConfig = _serverConfig;
						string format;
						if (_serverConfig != null)
						{
							format = serverConfig.<VsLastTemplate>k__BackingField;
							bool flag3 = string.IsNullOrEmpty(serverConfig.<VsLastTemplate>k__BackingField);
							bool flag4 = !flag3;
							object obj = 0;
							if (!flag4)
							{
								goto IL_00f2;
							}
						}
						else
						{
							bool flag5 = string.IsNullOrEmpty(null);
							bool flag6 = !flag5;
							object obj2 = !flag6;
							object obj = 0;
							format = null;
							if (obj2 != null)
							{
								goto IL_00f2;
							}
						}
						object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v17+E4]");
						bool flag7 = (nint)0 == 0;
						object obj5 = !flag7;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num = Math.Max(stat.PreviousValue, 0);
						object obj6 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object arg = default(object);
						string text2 = string.Format(format, arg);
						object obj7 = typeof(SqlSingle[]) + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						string[] array = default(string[]);
						bool flag8 = array == null;
						statisticsReportType = StatisticsReportType.Weekly;
						text3 = (string)5;
						if (flag8)
						{
							goto IL_04aa;
						}
						if (array.Length != 0)
						{
							object obj8 = array + 32;
							obj8 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj9 = array.Length & 0xFFFFFFFEL;
							if (obj9 != null)
							{
								object obj10 = (nint)0 + (nint)3072;
								object obj11 = array + 40;
								obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
								object obj13 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v35+E4]");
								bool flag9 = (nint)0 == 0;
								object obj14 = !flag9;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object input = "m_StencilDeferredPS" + 2392;
								string text4 = LocalizationUtil.Localize((string)input);
								bool flag10 = array.Length < 2;
								object obj15 = !flag10;
								object obj16 = array.Length - 2;
								bool flag11 = obj16 == null;
								object obj17 = ~obj15;
								object obj18 = obj17 | flag11;
								if (obj18 == null)
								{
									object obj19 = array + 48;
									obj19 = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj20 = array.Length & 0xFFFFFFFCL;
									if (obj20 != null)
									{
										object obj21 = array + 56;
										obj21 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										PersonalizedStatsStrip personalizedStatsStrip = default(PersonalizedStatsStrip);
										string text5 = personalizedStatsStrip.CraftLastTime(reportType);
										bool flag12 = array.Length < 4;
										object obj22 = !flag12;
										object obj23 = array.Length - 4;
										bool flag13 = obj23 == null;
										object obj24 = ~obj22;
										object obj25 = obj24 | flag13;
										if (obj25 == null)
										{
											object obj26 = array + 64;
											obj26 = text5;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											string text6 = string.Concat(array);
											reference = ref *(string*)text6;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											return true;
										}
										IndexOutOfRangeException ex = new IndexOutOfRangeException();
										statisticsReportType = StatisticsReportType.Weekly;
										text3 = text5;
										ex2 = (NullReferenceException)(object)ex;
									}
									else
									{
										IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
										statisticsReportType = StatisticsReportType.Weekly;
										text3 = text4;
										ex2 = (NullReferenceException)(object)ex3;
									}
								}
								else
								{
									IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
									statisticsReportType = StatisticsReportType.Weekly;
									text3 = text4;
									ex2 = (NullReferenceException)(object)ex4;
								}
							}
							else
							{
								IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
								statisticsReportType = StatisticsReportType.Weekly;
								text3 = text2;
								ex2 = (NullReferenceException)(object)ex5;
							}
						}
						else
						{
							IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
							statisticsReportType = StatisticsReportType.Weekly;
							text3 = (string)5;
							ex2 = (NullReferenceException)(object)ex6;
						}
						goto IL_0582;
					}
				}
				goto IL_05db;
			}
			return false;
		}
		NullReferenceException ex7 = new NullReferenceException();
		statisticsReportType = reportType;
		text3 = null;
		goto IL_04aa;
		IL_0582:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result2 = default(bool);
		return result2;
		IL_00f2:
		result = false;
		goto IL_05db;
		IL_04aa:
		ex2 = new NullReferenceException();
		goto IL_0582;
		IL_05db:
		return result;
	}

	private void ShowIcon(PerformanceReportType statType, ReportTypedSprite localConfig)
	{
		//IL_0115: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		HideAllImages();
		Image slotToShow = GetSlotToShow(statType);
		if (localConfig != null)
		{
			slotToShow.sprite = localConfig.Sprite;
		}
		GameObject gameObject = slotToShow.gameObject;
		gameObject.SetActive(value: true);
		PersonalReportTypeConfig serverConfig = _serverConfig;
		FileInfoModel fileInfoModel;
		string text;
		object obj2;
		if (_serverConfig != null)
		{
			fileInfoModel = serverConfig.<Image>k__BackingField;
			if (serverConfig.<Image>k__BackingField != null)
			{
				text = fileInfoModel.<url>k__BackingField;
				bool flag = string.IsNullOrEmpty(fileInfoModel.<url>k__BackingField);
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj != null)
				{
					return;
				}
				obj2 = 0;
			}
			else
			{
				bool flag3 = string.IsNullOrEmpty(null);
				bool flag4 = !flag3;
				object obj3 = !flag4;
				text = null;
				obj2 = 1;
				if (obj3 != null)
				{
					return;
				}
			}
		}
		else
		{
			bool flag5 = string.IsNullOrEmpty(null);
			bool flag6 = !flag5;
			fileInfoModel = null;
			text = null;
			obj2 = 1;
			if (!flag6)
			{
				return;
			}
		}
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "not" + 3880;
		object arg = default(object);
		string imageId = string.Format((string)format, arg, text);
		bool flag7 = obj2 == null;
		object obj5 = !flag7;
		if (obj5 == null)
		{
			DateTime? timestamp = fileInfoModel.<lastModified>k__BackingField;
			UIExtensions.LoadImage(slotToShow, imageId, text, setNative: false, storeLocally: true, timestamp);
			return;
		}
		throw new NullReferenceException();
	}

	private string CraftMainReport(PersonalizedStat stat)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2456;
		string text = CraftCongrats(stat);
		string text2 = CraftBody(stat);
		string fallback = text + (string)obj + text2;
		PersonalReportTypeConfig serverConfig = _serverConfig;
		string template;
		if (_serverConfig != null)
		{
			template = serverConfig.<DescriptionTemplate>k__BackingField;
			if (stat != null)
			{
				goto IL_0067;
			}
		}
		else
		{
			bool flag = stat == null;
			object obj2 = !flag;
			template = null;
			if (obj2 != null)
			{
				goto IL_0067;
			}
		}
		return (string)(object)new NullReferenceException();
		IL_0067:
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return SafeFormat(template, arg, fallback);
	}

	private static string SafeFormat(string template, object arg, string fallback)
	{
		//IL_0027: Expected O, but got I4
		bool flag = string.IsNullOrEmpty(template);
		bool flag2 = !flag;
		object obj = !flag2;
		string result = fallback;
		if (obj == null)
		{
			string text = string.Format(template, arg);
			result = text;
		}
		return result;
	}

	private void HideAllImages()
	{
		//IL_0013: Expected O, but got I
		//IL_001f: Expected O, but got I
		//IL_0271: Expected I, but got O
		//IL_00c3: Expected I, but got O
		//IL_00e6: Expected O, but got I4
		//IL_01e2: Expected I, but got O
		//IL_012d: Expected I, but got O
		//IL_0194: Expected O, but got I4
		//IL_0087: Expected O, but got I
		//IL_0158: Expected I, but got O
		object obj2 = default(object);
		nint num = default(nint);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (specificTypeImages != null)
		{
			object obj = (nint)0 + (nint)1488;
			obj2 = (nint)0 + (nint)1480;
			List<object>.Enumerator enumerator = ((List<object>)(object)specificTypeImages).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj3 = default(object);
			List<object>.Enumerator enumerator5;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (true)
			{
				num = (nint)obj;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-58+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ stack_-58+18]");
						GameObject gameObject = ((Component)0).gameObject;
						if ((object)gameObject != null)
						{
							gameObject.SetActive(value: false);
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						num = unchecked((nint)null);
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
					}
				}
				else
				{
					NullReferenceException ex3 = new NullReferenceException();
				}
				enumerator3 = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				goto IL_029b;
			}
			num = (nint)obj2;
			enumerator2.Dispose();
			enumerator3 = enumerator4;
			enumerator5 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			goto IL_00eb;
		}
		goto IL_029b;
		IL_00eb:
		if ((object)statIcon != null)
		{
			GameObject gameObject2 = statIcon.gameObject;
			bool flag = (object)gameObject2 == null;
			num = unchecked((nint)null);
			if (!flag)
			{
				gameObject2.SetActive(value: false);
				return;
			}
		}
		goto IL_029b;
		IL_029b:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag2 = num != 1;
		OutOfMemoryException ex5 = (OutOfMemoryException)(object)ex4;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator3.Dispose();
			object obj4 = default(object);
			bool flag3 = obj4 == null;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj4;
			if (flag3)
			{
				goto IL_00eb;
			}
			ex5 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237FAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private Image GetSlotToShow(PerformanceReportType type)
	{
		//IL_016e: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_010b: Expected I4, but got O
		//IL_003b: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00bd: Expected I4, but got O
		bool flag = specificTypeImages == null;
		object obj = 152985600;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		PerformanceReportType performanceReportType = default(PerformanceReportType);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1488;
			obj = (nint)0 + (nint)1480;
			List<object>.Enumerator enumerator = ((List<object>)(object)specificTypeImages).GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				goto IL_0093;
			}
			object obj3 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj4 = 0;
			performanceReportType = (PerformanceReportType)obj2;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = performanceReportType != PerformanceReportType.Streak;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			performanceReportType = (PerformanceReportType)obj;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				goto IL_0093;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237FAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		Image result = default(Image);
		return result;
		IL_0093:
		return statIcon;
	}

	private string CraftCongrats(PersonalizedStat stat)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		if (stat != null && (object)spriteStore != null)
		{
			ReportTypedSprite config = spriteStore.GetConfig(stat.Metric);
			if (config != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5+E4]");
				if ((nint)0 != 0)
				{
					return LocalizationUtil.Localize(config.CongratsText);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return LocalizationUtil.Localize(config.CongratsText);
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private string CraftBody(PersonalizedStat stat)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00db: Expected I8, but got I4
		//IL_00b1: Expected I8, but got I4
		if (stat != null && (object)spriteStore != null)
		{
			ReportTypedSprite config = spriteStore.GetConfig(stat.Metric);
			if (config != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+E4]");
				if ((nint)0 != 0)
				{
					return LocalizationUtil.Localize(config.BodyText, stat.Value);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return LocalizationUtil.Localize(config.BodyText, stat.Value);
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private string CraftLastTime(StatisticsReportType type)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		object obj7;
		object input;
		if (type != StatisticsReportType.Weekly)
		{
			if (type != StatisticsReportType.Monthly)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1832;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				object actualValue = default(object);
				ex..ctor(paramName, actualValue, null);
				object obj4 = (nint)0 + (nint)3176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				return (string)(object)new OutOfMemoryException();
			}
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj6 = obj5;
			obj7 = "fetch_products" + 1416;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00e5;
			}
			input = obj7;
		}
		else
		{
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj6 = obj9;
			obj7 = "fetch_products" + 1424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			input = obj7;
			if (!flag2)
			{
				goto IL_00e5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return LocalizationUtil.Localize((string)input);
		IL_00e5:
		return LocalizationUtil.Localize((string)obj7);
	}
}
