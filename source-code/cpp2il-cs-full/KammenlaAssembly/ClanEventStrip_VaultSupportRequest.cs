using System;
using System.Data;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanEventStrip_VaultSupportRequest : ClanEventStrip
{
	private const string OPEN_KEY = "clan_support_request_open";

	private const string COMPLETE_KEY = "clan_support_request_complete";

	private ProgressMeter progressMeter;

	private Button addFundsButton;

	private Button supportersListButton;

	private ClansSerializedUtils clanUtils;

	public unsafe override void Initialize(ClanFeedModel model)
	{
		//IL_070c: Expected I4, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_0153: Expected O, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0337: Expected I4, but got O
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_038d: Expected I, but got O
		//IL_039d: Expected O, but got I
		//IL_0223: Expected I, but got O
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I4
		//IL_02fb: Expected I, but got O
		//IL_0303: Expected I4, but got O
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_052c: Expected O, but got I
		//IL_0534: Expected I, but got O
		//IL_0542: Expected I, but got O
		//IL_0564: Expected O, but got I4
		//IL_0569: Expected I4, but got O
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_065d: Expected O, but got I
		//IL_0665: Expected I, but got O
		//IL_0673: Expected I, but got O
		//IL_0592: Expected O, but got I4
		//IL_05a3: Expected I4, but got O
		//IL_0695: Expected O, but got I4
		//IL_069a: Expected I4, but got O
		bool flag = model == null;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		bool flag2 = (byte)(int)model != 0;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			ClanFeedData clanFeedData = model.Data;
			if (model.Data == null)
			{
				return;
			}
			object obj = typeof(UsageHint) + 712;
			object obj2 = obj;
			nint num2 = (nint)clanFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9+130]");
			bool flag3 = num3 < 0;
			object obj3 = !flag3;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9+130]");
			object obj5 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X9_v7-8]");
			if (0 != (nint)obj2)
			{
				return;
			}
			object obj6 = typeof(DataRelation) + 712;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime utcNow = DateTime.UtcNow;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+18]");
			bool flag5 = utcNow < (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
			if (num5 < 0)
			{
				object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj10 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array = default(object[]);
				bool flag6 = array == null;
				num = 0;
				object obj11 = default(object);
				flag2 = (byte)(&obj11) != 0;
				if (flag6)
				{
					goto IL_06bb;
				}
				object obj12 = default(object);
				bool flag7 = obj12 == null;
				bool flag8 = (byte)(&obj11) != 0;
				if (!flag7)
				{
					nint num6 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
					flag8 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag9 = ex == null;
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
					flag2 = false;
					if (flag9)
					{
						goto IL_06d7;
					}
				}
				bool flag10 = array.Length == 0;
				num = 0;
				flag2 = flag8;
				if (flag10)
				{
					goto IL_06c9;
				}
				object obj13 = array + 32;
				obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj14 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3984;
				TextMeshProExtensions.Localize(text, (string)obj14, array);
				object obj15 = 0;
				num = (nint)array;
				flag2 = (byte)(int)obj14 != 0;
			}
			else
			{
				object obj16 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3976;
				TextMeshProExtensions.Localize(text, (string)obj16);
				num = 0;
				flag2 = (byte)(int)obj16 != 0;
			}
			ProgressMeter progressMeter = this.progressMeter;
			if ((object)this.progressMeter != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
				flag2 = false;
				nint num7 = (nint)progressMeter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v15 (Il2CppClass<ProgressMeter>)+180]");
				object obj15 = 0;
				ProgressMeter obj17 = this.progressMeter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
				obj17.SetProgress((int)num8, 0);
				if ((object)addFundsButton != null)
				{
					GameObject gameObject = addFundsButton.gameObject;
					bool flag11 = (object)gameObject == null;
					flag2 = false;
					if (!flag11)
					{
						gameObject.SetActive(flag5);
						Button button = addFundsButton;
						bool flag12 = (object)addFundsButton == null;
						num = 0;
						flag2 = flag5;
						if (!flag12)
						{
							bool flag13 = button.m_OnClick == null;
							num = 0;
							flag2 = flag5;
							if (!flag13)
							{
								button.m_OnClick.RemoveAllListeners();
								bool flag14 = !flag5;
								num = 0;
								flag2 = false;
								if (flag14)
								{
									goto IL_05a8;
								}
								Button button2 = addFundsButton;
								bool flag15 = (object)addFundsButton == null;
								num = 0;
								flag2 = false;
								if (!flag15)
								{
									object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj19 = (nint)0 + (nint)976;
									num = (nint)obj19;
									UnityAction unityAction = default(UnityAction);
									unityAction..ctor(this, (IntPtr)obj19);
									bool flag16 = button2.m_OnClick == null;
									obj15 = 0;
									flag2 = (byte)(int)this != 0;
									if (!flag16)
									{
										button2.m_OnClick.AddListener(unityAction);
										obj15 = 0;
										num = 0;
										flag2 = (byte)(int)unityAction != 0;
										goto IL_05a8;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_06bb;
		IL_06c9:
		ex = new IndexOutOfRangeException();
		goto IL_06d7;
		IL_05a8:
		Button button3 = supportersListButton;
		if ((object)supportersListButton != null && button3.m_OnClick != null)
		{
			button3.m_OnClick.RemoveAllListeners();
			Button button4 = supportersListButton;
			bool flag17 = (object)supportersListButton == null;
			flag2 = false;
			if (!flag17)
			{
				object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj21 = (nint)0 + (nint)984;
				num = (nint)obj21;
				UnityAction unityAction2 = default(UnityAction);
				unityAction2..ctor(this, (IntPtr)obj21);
				bool flag18 = button4.m_OnClick == null;
				object obj15 = 0;
				flag2 = (byte)(int)this != 0;
				if (!flag18)
				{
					button4.m_OnClick.AddListener(unityAction2);
					return;
				}
			}
		}
		goto IL_06bb;
		IL_06bb:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_06c9;
		IL_06d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void OpenAddFunds()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85D5]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = clanUtils;
			obj6 = clanUtils;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = clanUtils;
			obj6 = clanUtils;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		clanUtils.OpenAddFundsBottomSheet();
		return;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
	}

	private void OpenSupporters()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_01b3: Expected O, but got I
		//IL_0165: Expected O, but got I
		//IL_01a1: Expected I8, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86DB]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			obj5 = clanUtils;
			obj6 = clanUtils;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = clanUtils;
			obj6 = clanUtils;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj6 != null)
		{
			goto IL_01a3;
		}
		return;
		IL_01a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip_VaultSupportRequest)+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanEventStrip_VaultSupportRequest)+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+18]");
			if ((nint)0 != 0)
			{
				ClansSerializedUtils clansSerializedUtils = clanUtils;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+10]");
				clansSerializedUtils.OpenVaultSupportersPopup(0L);
			}
		}
		return;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			return;
		}
		goto IL_01a3;
	}

	public ClanEventStrip_VaultSupportRequest()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
