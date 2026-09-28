using System;
using System.Data;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class VaultTransactionStrip : ListViewItem<VaultTransactionDataHolder, int>
{
	private AvatarInitializer avatar;

	private TextMeshProUGUI amountText;

	private TextMeshProUGUI labelText;

	private TextMeshProUGUI dateText;

	private Color positiveColor;

	private Color negativeColor;

	public override void Setup(VaultTransactionDataHolder datum, bool firstTime)
	{
		//IL_004a: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_006a: Expected O, but got I
		bool firstTime2 = default(bool);
		while (true)
		{
			((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
			if (datum.<Supporter>k__BackingField != null)
			{
				break;
			}
			ClanVaultTransactionModel <Model>k__BackingField = datum.<Model>k__BackingField;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3 (Il2CppClass<VaultTransactionStrip>)+318]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3 (Il2CppClass<VaultTransactionStrip>)+320]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v71 @ X3_v2 (should have been resolved before IL gen)");
		}
		Initialize(datum.<Supporter>k__BackingField);
	}

	public virtual void Initialize(ClanVaultTransactionModel model)
	{
		//IL_042c: Expected I4, but got I8
		//IL_0446: Expected O, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Expected O, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_046e: Expected O, but got I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_018e: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0180: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_04ea: Expected O, but got I4
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_01c6: Expected O, but got I4
		//IL_0516: Expected I, but got O
		//IL_0521: Expected O, but got I
		//IL_01b8: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_0287: Expected O, but got I
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0367: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		TextMeshProUGUI textMeshProUGUI = amountText;
		int num = (int)(model.Delta & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		string text2;
		if (obj == null)
		{
			object format = "&action=sign-up" + 3392;
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			bool flag2 = (object)textMeshProUGUI == null;
			object obj3 = !flag2;
			text2 = text;
			if (obj3 == null)
			{
				goto IL_040e;
			}
		}
		else
		{
			object obj4 = "Material with texture name \"" + 3224;
			int num2 = default(int);
			string text3 = num2.ToString((string)obj4);
			text2 = text3;
		}
		nint num3 = (nint)textMeshProUGUI;
		textMeshProUGUI.text = text2;
		TextMeshProUGUI textMeshProUGUI2 = amountText;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = model.Delta + 1;
		bool flag3 = (nint)obj6 < 0;
		bool flag4 = obj6 == null;
		bool flag5 = !flag3;
		object obj7 = !flag4;
		object obj8 = flag5 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			object obj10 = 172;
		}
		else
		{
			object obj10 = 188;
		}
		bool flag6 = !flag3;
		object obj11 = !flag4;
		object obj12 = flag6 & obj11;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			object obj14 = 168;
		}
		else
		{
			object obj14 = 184;
		}
		bool flag7 = !flag3;
		object obj15 = !flag4;
		object obj16 = flag7 & obj15;
		object obj17 = ~obj16;
		if (obj17 == null)
		{
			object obj18 = 164;
		}
		else
		{
			object obj18 = 180;
		}
		bool flag8 = !flag3;
		object obj19 = !flag4;
		object obj20 = flag8 & obj19;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			object obj22 = 160;
		}
		else
		{
			object obj22 = 176;
		}
		nint num4 = (nint)textMeshProUGUI2;
		textMeshProUGUI2.color = (Color)0;
		object obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag9 = dateText;
			bool flag10 = !flag9;
			object obj24 = !flag10;
			if (obj24 != null)
			{
				goto IL_023a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)dateText)
			{
				goto IL_023a;
			}
		}
		goto IL_03b1;
		IL_03b1:
		GameObject gameObject = labelText.gameObject;
		gameObject.SetActive(value: true);
		string text4 = LabelKeyFor(model.Type);
		TextMeshProExtensions.Localize(labelText, text4);
		InitializeAvatar(model.UserId);
		return;
		IL_040e:
		throw new NullReferenceException();
		IL_023a:
		GameObject gameObject2 = dateText.gameObject;
		gameObject2.SetActive(value: true);
		object obj25 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86E6]");
		object obj26 = (nint)0 & (nint)1;
		object obj27;
		object obj29;
		if (obj26 != null)
		{
			obj27 = "utf-32" + 3016;
			object obj28 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v24+E4]");
			bool flag11 = (nint)0 == 0;
			obj29 = obj27;
			if (!flag11)
			{
				goto IL_02e8;
			}
		}
		else
		{
			_ = 1;
			obj27 = "utf-32" + 3016;
			object obj28 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v24+E4]");
			bool flag12 = (nint)0 == 0;
			object obj30 = !flag12;
			obj29 = obj27;
			if (obj30 != null)
			{
				goto IL_02e8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime = default(DateTime);
		string text5 = dateTime.ToString((string)obj29);
		goto IL_039d;
		IL_02e8:
		text5 = dateTime.ToString((string)obj27);
		bool flag13 = (object)dateText == null;
		object obj31 = !flag13;
		if (obj31 != null)
		{
			goto IL_039d;
		}
		goto IL_040e;
		IL_039d:
		dateText.text = text5;
		goto IL_03b1;
	}

	public unsafe void Initialize(ClanVaultSupporterModel supporter)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_005b: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_015c: Expected O, but got I4
		//IL_01c8: Expected I, but got O
		//IL_01f9: Expected I, but got O
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_041b: Expected I, but got O
		//IL_0424: Expected O, but got I4
		//IL_0280: Expected I, but got O
		//IL_032f: Expected I, but got O
		//IL_02cd: Expected I, but got O
		//IL_02dd: Expected O, but got I
		//IL_02fb: Expected I, but got O
		//IL_030b: Expected O, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		bool flag = supporter == null;
		string text = (string)(object)supporter;
		nint num2;
		if (!flag)
		{
			object obj = "Material with texture name \"" + 3224;
			TextMeshProUGUI textMeshProUGUI = amountText;
			text = (string)obj;
			int num = supporter + 48;
			string text2 = ((int*)num)->ToString((string)obj);
			bool flag2 = (object)amountText == null;
			num2 = unchecked((nint)null);
			if (!flag2)
			{
				nint num3 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				num2 = 0;
				amountText.text = text2;
				bool flag3 = (object)labelText == null;
				text = text2;
				if (!flag3)
				{
					GameObject gameObject = labelText.gameObject;
					bool flag4 = (object)gameObject == null;
					text = null;
					if (!flag4)
					{
						object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
						gameObject.SetActive(value: false);
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v9+E4]");
						if ((nint)0 != 0)
						{
							bool flag5 = dateText;
							bool flag6 = !flag5;
							object obj4 = !flag6;
							text = null;
							if (obj4 != null)
							{
								goto IL_01b2;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag7 = dateText;
							bool flag8 = !flag7;
							text = null;
							if (!flag8)
							{
								goto IL_01b2;
							}
						}
						goto IL_038d;
					}
				}
			}
		}
		goto IL_0398;
		IL_03b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_01b2:
		bool flag9 = (object)dateText == null;
		num2 = unchecked((nint)null);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag9)
		{
			GameObject gameObject2 = dateText.gameObject;
			bool flag10 = (object)gameObject2 == null;
			num2 = unchecked((nint)null);
			text = null;
			if (!flag10)
			{
				gameObject2.SetActive(value: true);
				object obj5 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				SinceTextFormat sinceTextFormat = default(SinceTextFormat);
				sinceTextFormat..ctor(DateTimeUnit.Seconds);
				bool flag11 = sinceTextFormat == null;
				num2 = unchecked((nint)null);
				text = (string)5;
				if (!flag11)
				{
					string formattedText = sinceTextFormat.GetFormattedText(supporter.LastTransactionDate);
					object[] array = default(object[]);
					bool flag12 = array == null;
					num2 = unchecked((nint)null);
					text = (string)supporter.LastTransactionDate;
					if (!flag12)
					{
						bool flag13 = formattedText == null;
						string text3 = (string)supporter.LastTransactionDate;
						if (!flag13)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
							text3 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag14 = ex == null;
							num2 = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							if (flag14)
							{
								goto IL_03b4;
							}
						}
						bool flag15 = array.Length == 0;
						num2 = unchecked((nint)null);
						text = text3;
						if (!flag15)
						{
							object obj7 = array + 32;
							obj7 = formattedText;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object text4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3608;
							TextMeshProExtensions.Localize(dateText, (string)text4, array);
							goto IL_038d;
						}
						goto IL_03a6;
					}
				}
			}
		}
		goto IL_0398;
		IL_03a6:
		ex = new IndexOutOfRangeException();
		goto IL_03b4;
		IL_038d:
		InitializeAvatar(supporter);
		return;
		IL_0398:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03a6;
	}

	private void InitializeAvatar(long? userId)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		object obj = (??)userId & 1;
		long? num = default(long?);
		bool flag6;
		if (obj != null)
		{
			long value = num.Value;
			bool flag = value < 0;
			bool flag2 = value == 0;
			long num2 = value ^ value;
			long num3 = value & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			bool flag5 = (byte)((flag4 & obj2) ? 1 : 0) != 0;
			flag6 = flag5;
		}
		else
		{
			flag6 = false;
		}
		GameObject gameObject = avatar.gameObject;
		gameObject.SetActive(flag6);
		if (flag6)
		{
			long value2 = num.Value;
			long num4 = default(long);
			string dbId = num4.ToString();
			avatar.InitializeFriendWithDbId(dbId);
		}
		else
		{
			avatar.Clear();
		}
	}

	private unsafe void InitializeAvatar(ClanVaultSupporterModel supporter)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected I8, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		GameObject gameObject = avatar.gameObject;
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		gameObject.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AvatarData avatarData = default(AvatarData);
		avatarData..ctor();
		long num = supporter + 16;
		string text = ((long*)num)->ToString();
		object obj2 = avatarData + 16;
		obj2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = avatarData + 24;
		obj3 = supporter.Name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = supporter.AvatarDate;
		avatar.Initialize(avatarData);
	}

	private static string LabelKeyFor(ClanVaultTransactionType type)
	{
		//IL_004b: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		object obj = type - 1;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		object obj3 = obj - 4;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 139821056 + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X9_v2+v39 @ X8_v3*8]");
			return (string)0;
		}
		return "___# Content push apply failed [{0}]: {1}" + 3736;
	}

	private static string FormatAmount(int delta)
	{
		//IL_007f: Expected I4, but got I8
		//IL_0099: Expected O, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		int num = (int)(delta & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			object format = "&action=sign-up" + 3392;
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			return string.Format((string)format, arg);
		}
		object obj3 = "Material with texture name \"" + 3224;
		int num2 = default(int);
		return num2.ToString((string)obj3);
	}

	private static string FormatDate(DateTime time)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = "utf-32" + 3016;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		return dateTime.ToString((string)obj2);
	}

	private static string FormatTimeAgo(DateTime time)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SinceTextFormat sinceTextFormat = default(SinceTextFormat);
		sinceTextFormat..ctor(DateTimeUnit.Seconds);
		if (sinceTextFormat != null)
		{
			return sinceTextFormat.GetFormattedText(time);
		}
		return (string)(object)new NullReferenceException();
	}

	public VaultTransactionStrip()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72535C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72535D0]");
		_ = 0;
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
