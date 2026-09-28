using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UI.Popups.Chat;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GiftBombCreationPopup : MonoBehaviour, IInitializable
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<int, string> <>9__44_0;

		public static Func<int, string> <>9__73_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <CreateSubOptions>b__44_0(int days)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0077: Expected O, but got I4
			//IL_0035: Expected I8, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "DNQUALIFIER" + 1456;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return LocalizationUtil.Localize((string)input, days);
		}

		internal string <CheckSubOptions>b__73_0(int days)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0077: Expected O, but got I4
			//IL_0035: Expected I8, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "DNQUALIFIER" + 1456;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return LocalizationUtil.Localize((string)input, days);
		}
	}

	private KDropMenu shardSubsOptions;

	private InputFieldTMProUGUI shardAces;

	private InputFieldTMProUGUI numberOfShardsSubs;

	private InputFieldTMProUGUI numberOfShardsAces;

	private InputFieldTMProUGUI bombMessage;

	private ComponentReference<SubBombNotifyClientPopupPreview> subBombPopupPreviewReference;

	private TextMeshProUGUI totalText;

	private TextMeshProUGUI instructionsText;

	private TextMeshProUGUI numberOfSubsGiftsTitle;

	private TextMeshProUGUI numberOfAcesGiftsTitle;

	private TextMeshProUGUI giftAcesValueTitle;

	private Button createBomb;

	private PopupUI popup;

	private TabsUI typeTab;

	private StoreSoundAlbum soundAlbum;

	private const string ConfirmCurrencyBombMessage = "confirm_currency_bomb_message";

	private const string SubOption = "SUBSCRIPTION DAYS";

	private const string SubDays = "Days";

	private const string BombMessage = "Bomb Message";

	private const string MutedMessage = "Can not send gift message while muted";

	private const string PlzFillShards = "please fill the number of shards";

	private const string PlzFillPrice = "please fill the shard price";

	private const string GiftInfoSubs = "{0} gifts will be distributed and can be claimed.Each gift has {1:N0} sub day costing {2:N0} aces.";

	private const string GiftInfoAces = "{0} gifts will be distributed and can be claimed.Each gift has {1:N0} aces in it.";

	private const int SubsTabIndex = 0;

	private const int AcesTabIndex = 1;

	private SubBombNotifyClientPopupPreview _subBombPopupPreview;

	private static GiftBombConfig GiftBombConfig
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00d4: Expected O, but got I4
			//IL_0114: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_009a;
			}
			goto IL_0122;
			IL_009a:
			return current.<GiftBomb>k__BackingField;
			IL_0122:
			return (GiftBombConfig)(object)new NullReferenceException();
			IL_0074:
			current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_009a;
			}
			goto IL_0122;
		}
	}

	private static bool IsEid
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0164: Expected I4, but got O
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7753]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
			IL_0156:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_011d:
			VisualsConfig <Visuals>k__BackingField = current.<Visuals>k__BackingField;
			if (current.<Visuals>k__BackingField != null)
			{
				return <Visuals>k__BackingField.<IsEid>k__BackingField;
			}
			goto IL_0156;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
		}
	}

	private bool IsSubsInputFieldsFilled
	{
		get
		{
			//IL_0288: Expected I4, but got O
			//IL_001f: Expected O, but got I8
			//IL_0039: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0071: Expected O, but got I
			//IL_0121: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_0257: Expected O, but got I4
			KDropMenu kDropMenu = shardSubsOptions;
			RemoteConfigModel current;
			if ((object)shardSubsOptions != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (KDropMenu)+34]");
				object obj = 0 & 0x80000000L;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_0274;
				}
				object obj3 = typeof(RegisteredWaitHandle) + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v15+E4]");
					if ((nint)0 != 0)
					{
						goto IL_00bb;
					}
				}
				else
				{
					_ = 1;
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						goto IL_00bb;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				current = RemoteConfig.Current;
				if (current != null)
				{
					goto IL_0164;
				}
			}
			goto IL_027a;
			IL_0164:
			GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
			if (current.<GiftBomb>k__BackingField != null)
			{
				int[] <SubShardDays>k__BackingField = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
				if (<GiftBomb>k__BackingField.<SubShardDays>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (KDropMenu)+34]");
					if ((nint)0 >= (nint)<SubShardDays>k__BackingField.Length)
					{
						goto IL_0274;
					}
					if ((object)numberOfShardsSubs != null)
					{
						string text = numberOfShardsSubs.Text;
						object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v13+E4]");
						bool flag3 = (nint)0 == 0;
						object obj9 = !flag3;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag4 = StringsExtensions.IsNullOrEmpty(text);
						return (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
					}
				}
			}
			goto IL_027a;
			IL_00bb:
			current = RemoteConfig.Current;
			bool flag5 = current == null;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_0164;
			}
			goto IL_027a;
			IL_027a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0274:
			return false;
		}
	}

	private bool IsAcesInputFieldsFilled
	{
		get
		{
			//IL_014c: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_0121: Expected O, but got I4
			if ((object)numberOfShardsAces != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				string text = numberOfShardsAces.Text;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+E4]");
				if ((nint)0 != 0)
				{
					if (StringsExtensions.IsNullOrEmpty(text))
					{
						goto IL_007f;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag = StringsExtensions.IsNullOrEmpty(text);
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						goto IL_007f;
					}
				}
				if ((object)shardAces != null)
				{
					string text2 = shardAces.Text;
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = StringsExtensions.IsNullOrEmpty(text2);
					return (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_007f:
			return false;
		}
	}

	private GiftBombType GiftBombType
	{
		get
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_009a: Expected O, but got I
			//IL_00b7: Expected I4, but got O
			switch (typeTab.ActiveTabIndex)
			{
			case 1:
				return GiftBombType.Currency;
			case 0:
				return GiftBombType.Subscription;
			default:
			{
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				ex..ctor();
				object obj2 = (nint)0 + (nint)3136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				OutOfMemoryException ex2 = new OutOfMemoryException();
				return (GiftBombType)ex2;
			}
			}
		}
	}

	private void Start()
	{
		RegisterEvents();
	}

	private void OnDestroy()
	{
		UnRegisterEvents();
	}

	private void RegisterEvents()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004e: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0093: Expected I, but got O
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00ea: Expected I, but got O
		//IL_00fb: Expected O, but got I
		//IL_0127: Expected I, but got O
		//IL_0138: Expected O, but got I
		//IL_0164: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_01a1: Expected I, but got O
		//IL_01b2: Expected O, but got I
		//IL_01de: Expected I, but got O
		//IL_01ef: Expected O, but got I
		//IL_021b: Expected I, but got O
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_025e: Expected O, but got I
		//IL_0276: Expected I, but got O
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_029b: Expected O, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02f2: Expected I, but got O
		//IL_031c: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_0387: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03f8: Expected I, but got O
		TabsUI tabsUI = typeTab;
		object obj = typeof(TypeConverter<ushort, char>) + 408;
		object obj2 = (nint)0 + (nint)3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction = default(UnityAction<int>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)968;
		tabsUI.OnTabChanged.AddListener(unityAction);
		KDropMenu kDropMenu = shardSubsOptions;
		object obj4 = (nint)0 + (nint)3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction2 = default(UnityAction<int>);
		unityAction2..ctor((object)this, (IntPtr)obj4);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj6 = (nint)0 + (nint)3072;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v5 (KDropMenu)+28]");
		((UnityEvent<int>)0).AddListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)3080;
		numberOfShardsSubs.OnValueChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)3088;
		numberOfShardsSubs.OnEndEdit += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj8);
		object obj9 = (nint)0 + (nint)3096;
		shardAces.OnValueChanged += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)3056;
		shardAces.OnEndEdit += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)3064;
		numberOfShardsAces.OnValueChanged += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj11);
		numberOfShardsAces.OnEndEdit += action6;
		Button button = createBomb;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj13 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj13);
		object obj14 = typeof(SqlSingle[]) + 2376;
		object obj15 = (nint)0 + (nint)3048;
		object obj16 = typeof(RegisteredWaitHandle) + 56;
		object obj17 = typeof(Queue<string>) + 848;
		button.m_OnClick.AddListener(unityAction3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj15);
		object obj18 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v33+E4]");
		bool flag = (nint)0 == 0;
		object obj19 = !flag;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj20 = (nint)0 + (nint)2200;
		RemoteConfig.OnChanged += action7;
		GameObject go = base.gameObject;
		object obj21 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v38+E4]");
		bool flag2 = (nint)0 == 0;
		object obj22 = !flag2;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj23 = (nint)0 + (nint)3128;
		object varName = "m_StencilDeferredPS" + 2520;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action8 = default(Action);
		action8..ctor(this, (IntPtr)obj23);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action8);
	}

	private void UnRegisterEvents()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004e: Expected O, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_00a0: Expected I, but got O
		//IL_00b1: Expected O, but got I
		//IL_00dd: Expected I, but got O
		//IL_00ee: Expected O, but got I
		//IL_011a: Expected I, but got O
		//IL_012b: Expected O, but got I
		//IL_0157: Expected I, but got O
		//IL_0168: Expected O, but got I
		//IL_0194: Expected I, but got O
		//IL_01a5: Expected O, but got I
		//IL_01d1: Expected I, but got O
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0214: Expected O, but got I
		//IL_022c: Expected I, but got O
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0251: Expected O, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0294: Expected I, but got O
		//IL_02be: Expected O, but got I4
		KDropMenu kDropMenu = shardSubsOptions;
		object obj = typeof(TypeConverter<ushort, char>) + 408;
		object obj2 = (nint)0 + (nint)3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction = default(UnityAction<int>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)984;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj5 = (nint)0 + (nint)3072;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (KDropMenu)+28]");
		((UnityEvent<int>)0).RemoveListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)3080;
		numberOfShardsSubs.OnValueChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)3088;
		numberOfShardsSubs.OnEndEdit -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)3096;
		shardAces.OnValueChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj8);
		object obj9 = (nint)0 + (nint)3056;
		shardAces.OnEndEdit -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)3064;
		numberOfShardsAces.OnValueChanged -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj10);
		numberOfShardsAces.OnEndEdit -= action6;
		Button button = createBomb;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj12 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj12);
		object obj13 = typeof(SqlSingle[]) + 2376;
		object obj14 = (nint)0 + (nint)3048;
		object obj15 = typeof(RegisteredWaitHandle) + 56;
		button.m_OnClick.RemoveListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj14);
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v30+E4]");
		bool flag = (nint)0 == 0;
		object obj17 = !flag;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action7;
	}

	public void Initialize()
	{
		Show();
	}

	public void Show()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		CreateSubOptions();
		Clear();
		SetInputPlaceHoldersToDefault();
		typeTab.Activate(0);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.SlideFromBottom();
		OnConfigChange();
		ITrackEvent trackEvent = TrackerLibrary.ChatGiftBombCreationViewed();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void Setup()
	{
		CreateSubOptions();
		Clear();
		SetInputPlaceHoldersToDefault();
		typeTab.Activate(0);
	}

	private void CreateSubOptions()
	{
		//IL_0016: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0067: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0238: Expected O, but got I4
		//IL_0306: Expected O, but got I
		//IL_0316: Expected O, but got I
		//IL_0338: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0370: Expected O, but got I
		//IL_0381: Expected I, but got O
		//IL_039f: Expected O, but got I
		//IL_02af: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7755]");
		object obj = (nint)0 & (nint)1;
		KDropMenu kDropMenu;
		object obj2;
		object obj4;
		KDropMenu kDropMenu2;
		if (obj != null)
		{
			kDropMenu = shardSubsOptions;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			kDropMenu2 = shardSubsOptions;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			kDropMenu = shardSubsOptions;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			kDropMenu2 = shardSubsOptions;
			if (obj6 != null)
			{
				goto IL_0096;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		kDropMenu = kDropMenu2;
		if (obj8 != null)
		{
			goto IL_00cb;
		}
		goto IL_01c3;
		IL_01e8:
		RemoteConfigModel current;
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		object obj9 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 280;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v5+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v10+8]");
		Func<int, object> selector = (Func<int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v10+8]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v16+B8]");
				obj12 = 0;
			}
			object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1928;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)2152;
			Func<int, object> func = default(Func<int, object>);
			func..ctor(obj12, (IntPtr)obj17);
			object obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v15+B8]");
			object obj19 = (nint)0 + (nint)8;
			obj19 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(<GiftBomb>k__BackingField.<SubShardDays>k__BackingField, selector);
		List<object> newItems = Enumerable.ToList(source);
		BaseDropMenu<object> baseDropMenu;
		baseDropMenu.SetupItems(newItems);
		return;
		IL_00cb:
		current = RemoteConfig.Current;
		bool flag7 = current == null;
		object obj20 = !flag7;
		baseDropMenu = (BaseDropMenu<object>)(object)kDropMenu;
		if (obj20 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01e8;
		IL_01c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		baseDropMenu = (BaseDropMenu<object>)(object)kDropMenu2;
		goto IL_01e8;
		IL_0096:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		kDropMenu2 = kDropMenu;
		if (!flag8)
		{
			goto IL_00cb;
		}
		goto IL_01c3;
	}

	private void SetInputPlaceHoldersToDefault()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_02fa: Expected O, but got I4
		//IL_02b7: Expected O, but got I4
		//IL_036b: Expected O, but got I
		//IL_041b: Expected O, but got I4
		//IL_03d8: Expected O, but got I4
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7756]");
		object obj2 = (nint)0 & (nint)1;
		InputFieldTMProUGUI inputFieldTMProUGUI;
		object obj3;
		object obj5;
		InputFieldTMProUGUI inputFieldTMProUGUI2;
		if (obj2 != null)
		{
			inputFieldTMProUGUI = numberOfShardsSubs;
			obj3 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			inputFieldTMProUGUI2 = numberOfShardsSubs;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			_ = 1;
			inputFieldTMProUGUI = numberOfShardsSubs;
			obj3 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			inputFieldTMProUGUI2 = numberOfShardsSubs;
			if (obj7 != null)
			{
				goto IL_009f;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v48+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		inputFieldTMProUGUI = inputFieldTMProUGUI2;
		if (obj9 != null)
		{
			goto IL_00dc;
		}
		goto IL_01d4;
		IL_0326:
		int num = default(int);
		string text = num.ToString();
		LocalizableText placeholder = TextMeshProExtensions.FixOnly(text);
		shardAces.SetPlaceholder(placeholder);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj10 = (nint)0 & (nint)1;
		if (obj10 != null)
		{
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03b5;
			}
		}
		else
		{
			_ = 1;
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v24+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 != null)
			{
				goto IL_03b5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0447;
		IL_0294:
		RemoteConfigModel current2 = RemoteConfig.Current;
		bool flag5 = current2 == null;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			goto IL_04ba;
		}
		goto IL_0326;
		IL_04ba:
		throw new NullReferenceException();
		IL_009f:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v48+E4]");
		bool flag6 = (nint)0 == 0;
		obj5 = obj3;
		inputFieldTMProUGUI2 = inputFieldTMProUGUI;
		if (!flag6)
		{
			goto IL_00dc;
		}
		goto IL_01d4;
		IL_01d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current3 = RemoteConfig.Current;
		obj3 = obj5;
		inputFieldTMProUGUI = inputFieldTMProUGUI2;
		goto IL_0207;
		IL_00dc:
		current3 = RemoteConfig.Current;
		bool flag7 = current3 == null;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			goto IL_04ba;
		}
		goto IL_0207;
		IL_0207:
		string text2 = num.ToString();
		LocalizableText placeholder2 = TextMeshProExtensions.FixOnly(text2);
		inputFieldTMProUGUI.SetPlaceholder(placeholder2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0294;
			}
		}
		else
		{
			_ = 1;
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v36+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 != null)
			{
				goto IL_0294;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current2 = RemoteConfig.Current;
		goto IL_0326;
		IL_03b5:
		current = RemoteConfig.Current;
		bool flag9 = current == null;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			goto IL_04ba;
		}
		goto IL_0447;
		IL_0447:
		string text3 = num.ToString();
		LocalizableText placeholder3 = TextMeshProExtensions.FixOnly(text3);
		object obj19 = "Material with texture name \"" + 3224;
		numberOfShardsAces.SetPlaceholder(placeholder3);
		int totalCost = GetTotalCost();
		string text4 = num.ToString((string)obj19);
		totalText.text = text4;
	}

	private void UpdateMuteState()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E766E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		MuteStatus muteStatus = SFSKammelnaUserExtensions.GetMuteStatus(localUser);
		bool interactable = muteStatus == MuteStatus.None;
		bombMessage.Interactable = interactable;
		object placeholder = "AvailableVoices" + 2400;
		object obj8 = "COORDINATE_TYPE_GCJ_02" + 1264;
		if (muteStatus != MuteStatus.None)
		{
			placeholder = obj8;
		}
		bombMessage.SetPlaceholder((string)placeholder);
		if (muteStatus != MuteStatus.None)
		{
			object text = (nint)0 + (nint)2000;
			bombMessage.Text = (string)text;
		}
		else
		{
			string text2 = bombMessage.Text;
			bombMessage.Text = text2;
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void UpdatePanel()
	{
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubsInstructionsText();
		}
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubmitButton();
			return;
		}
		UpdateAcesInstructionsText();
		UpdateSubmitButton();
	}

	private void UpdateInstructionsText()
	{
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubsInstructionsText();
		}
		if (GiftBombType == GiftBombType.Currency)
		{
			UpdateAcesInstructionsText();
		}
	}

	private unsafe void UpdateSubsInstructionsText()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0169: Expected I, but got O
		//IL_018b: Expected I, but got O
		//IL_01a1: Expected I, but got O
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_0311: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_0385: Expected I, but got O
		//IL_02dc: Expected I, but got O
		//IL_034e: Expected I, but got O
		//IL_03b6: Expected I, but got O
		//IL_03ed: Expected I, but got O
		//IL_041e: Expected O, but got I4
		//IL_0426: Expected I, but got O
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_048c: Expected O, but got I4
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0aac: Expected I8, but got I
		//IL_0515: Expected O, but got I8
		//IL_052d: Expected O, but got I4
		//IL_04b1: Expected I, but got O
		//IL_04e3: Expected O, but got I4
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0579: Expected O, but got I
		//IL_063a: Expected O, but got I4
		//IL_05e6: Expected O, but got I4
		//IL_06b8: Expected O, but got I4
		//IL_06c0: Expected I, but got O
		//IL_05fd: Expected O, but got I4
		//IL_0605: Expected I, but got O
		//IL_0678: Expected O, but got I4
		//IL_0680: Expected I, but got O
		//IL_06f2: Expected O, but got I4
		//IL_06fa: Expected I, but got O
		//IL_0732: Expected O, but got I4
		//IL_073a: Expected I, but got O
		//IL_076b: Expected O, but got I4
		//IL_0774: Expected O, but got I4
		//IL_077c: Expected I, but got O
		//IL_07a1: Expected O, but got I
		//IL_0862: Expected O, but got I4
		//IL_080e: Expected O, but got I4
		//IL_08d4: Expected O, but got I4
		//IL_08dc: Expected I, but got O
		//IL_0825: Expected O, but got I4
		//IL_082d: Expected I, but got O
		//IL_08a0: Expected O, but got I4
		//IL_08a8: Expected I, but got O
		//IL_08fa: Expected O, but got I4
		//IL_099d: Expected O, but got I4
		//IL_09ad: Expected O, but got I4
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected O, but got Unknown
		//IL_09db: Expected O, but got I4
		//IL_0931: Expected I, but got O
		//IL_0963: Expected O, but got I4
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Expected O, but got Unknown
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected O, but got Unknown
		TextMeshProUGUI textMesh;
		TextMeshProUGUI textMesh2;
		string text2;
		object[] array = default(object[]);
		object obj6;
		RemoteConfigModel current;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		nint num;
		if ((object)numberOfShardsSubs != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = numberOfShardsSubs.Text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				bool flag = StringsExtensions.IsNullOrEmpty(text);
				textMesh = instructionsText;
				bool flag2 = !flag;
				textMesh2 = instructionsText;
				if (!flag2)
				{
					goto IL_008f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = StringsExtensions.IsNullOrEmpty(text);
				textMesh = instructionsText;
				bool flag4 = !flag3;
				object obj3 = !flag4;
				textMesh2 = instructionsText;
				if (obj3 != null)
				{
					goto IL_008f;
				}
			}
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag5 = (object)numberOfShardsSubs == null;
			num = 3;
			if (!flag5)
			{
				text2 = numberOfShardsSubs.Text;
				bool flag6 = array == null;
				num = unchecked((nint)null);
				if (!flag6)
				{
					bool flag7 = text2 == null;
					nint num2 = unchecked((nint)null);
					if (!flag7)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag8 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						if (flag8)
						{
							goto IL_0a53;
						}
					}
					bool flag9 = array.Length == 0;
					num = num2;
					if (flag9)
					{
						goto IL_0a45;
					}
					object obj5 = array + 32;
					obj5 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj6 = typeof(RegisteredWaitHandle) + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
					object obj7 = (nint)0 & (nint)1;
					if (obj7 != null)
					{
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v67+E4]");
						if ((nint)0 != 0)
						{
							goto IL_02a3;
						}
					}
					else
					{
						_ = 1;
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v67+E4]");
						bool flag10 = (nint)0 == 0;
						object obj9 = !flag10;
						if (obj9 != null)
						{
							goto IL_02a3;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					current = RemoteConfig.Current;
					bool flag11 = current == null;
					num = (nint)text2;
					if (!flag11)
					{
						goto IL_035c;
					}
				}
			}
		}
		goto IL_0a37;
		IL_0a53:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_035c:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		bool flag12 = current.<GiftBomb>k__BackingField == null;
		num = (nint)text2;
		string text3;
		RemoteConfigModel current2;
		object obj15;
		if (!flag12)
		{
			KDropMenu kDropMenu = shardSubsOptions;
			bool flag13 = (object)shardSubsOptions == null;
			num = (nint)text2;
			if (!flag13)
			{
				int[] <SubShardDays>k__BackingField = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
				bool flag14 = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField == null;
				num = (nint)text2;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v5 (KDropMenu)+34]");
					bool flag15 = (nint)0 < (nint)<SubShardDays>k__BackingField.Length;
					object obj10 = !flag15;
					num = (nint)text2;
					if (obj10 == null)
					{
						int[] <SubShardDays>k__BackingField2 = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v5 (KDropMenu)+34]");
						object obj11 = <SubShardDays>k__BackingField2 + 0;
						object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
						object obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v21+E4]");
						bool flag16 = (nint)0 == 0;
						object obj14 = !flag16;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object input = "SERVICE_DISABLED" + 1344;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v15+20]");
						text3 = LocalizationUtil.Localize((string)input, 0L);
						bool flag17 = text3 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v15+20]");
						nint num4 = 0;
						if (!flag17)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag18 = ex == null;
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
							num = 0;
							if (flag18)
							{
								goto IL_0a53;
							}
						}
						object obj16 = array.Length & 0xFFFFFFFEL;
						bool flag19 = obj16 == null;
						obj15 = 0;
						num = num4;
						if (!flag19)
						{
							object obj17 = array + 40;
							obj17 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
							object obj18 = (nint)0 & (nint)1;
							if (obj18 != null)
							{
								object obj19 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v52+E4]");
								if ((nint)0 != 0)
								{
									goto IL_05c3;
								}
							}
							else
							{
								_ = 1;
								object obj19 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v52+E4]");
								bool flag20 = (nint)0 == 0;
								object obj20 = !flag20;
								if (obj20 != null)
								{
									goto IL_05c3;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							current2 = RemoteConfig.Current;
							bool flag21 = current2 == null;
							obj15 = 0;
							num = (nint)text3;
							if (!flag21)
							{
								goto IL_068e;
							}
							goto IL_0a37;
						}
					}
					goto IL_0a45;
				}
			}
		}
		goto IL_0a37;
		IL_02a3:
		current = RemoteConfig.Current;
		bool flag22 = current == null;
		object obj21 = !flag22;
		if (obj21 != null)
		{
			goto IL_035c;
		}
		num = (nint)text2;
		goto IL_0a37;
		IL_068e:
		GiftBombConfig <GiftBomb>k__BackingField2 = current2.<GiftBomb>k__BackingField;
		bool flag23 = current2.<GiftBomb>k__BackingField == null;
		obj15 = 0;
		num = (nint)text3;
		RemoteConfigModel current3;
		if (!flag23)
		{
			KDropMenu kDropMenu2 = shardSubsOptions;
			bool flag24 = (object)shardSubsOptions == null;
			obj15 = 0;
			num = (nint)text3;
			if (!flag24)
			{
				int[] <SubShardDays>k__BackingField3 = <GiftBomb>k__BackingField2.<SubShardDays>k__BackingField;
				bool flag25 = <GiftBomb>k__BackingField2.<SubShardDays>k__BackingField == null;
				obj15 = 0;
				num = (nint)text3;
				if (!flag25)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X9_v7 (KDropMenu)+34]");
					bool flag26 = (nint)0 < (nint)<SubShardDays>k__BackingField3.Length;
					object obj22 = !flag26;
					obj15 = 0;
					num = (nint)text3;
					if (obj22 != null)
					{
						goto IL_0a45;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
					object obj23 = (nint)0 & (nint)1;
					if (obj23 != null)
					{
						object obj24 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v40+E4]");
						if ((nint)0 != 0)
						{
							goto IL_07eb;
						}
					}
					else
					{
						_ = 1;
						object obj24 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v40+E4]");
						bool flag27 = (nint)0 == 0;
						object obj25 = !flag27;
						if (obj25 != null)
						{
							goto IL_07eb;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					current3 = RemoteConfig.Current;
					bool flag28 = current3 == null;
					obj15 = 0;
					num = (nint)text3;
					if (!flag28)
					{
						goto IL_08b6;
					}
				}
			}
		}
		goto IL_0a37;
		IL_008f:
		object text4 = "placementId" + 232;
		TextMeshProExtensions.Localize(textMesh, (string)text4);
		return;
		IL_0a45:
		ex = new IndexOutOfRangeException();
		goto IL_0a53;
		IL_05c3:
		current2 = RemoteConfig.Current;
		bool flag29 = current2 == null;
		object obj26 = !flag29;
		if (obj26 != null)
		{
			goto IL_068e;
		}
		obj15 = 0;
		num = (nint)text3;
		goto IL_0a37;
		IL_07eb:
		current3 = RemoteConfig.Current;
		bool flag30 = current3 == null;
		object obj27 = !flag30;
		if (obj27 != null)
		{
			goto IL_08b6;
		}
		obj15 = 0;
		num = (nint)text3;
		goto IL_0a37;
		IL_08b6:
		bool flag31 = current3.<GiftBomb>k__BackingField == null;
		obj15 = 0;
		num = (nint)text3;
		if (flag31)
		{
			goto IL_0a37;
		}
		object obj28 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj29 = default(object);
		bool flag32 = obj29 == null;
		object obj30 = default(object);
		nint num6 = (nint)(&obj30);
		if (!flag32)
		{
			nint num7 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
			num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag33 = ex == null;
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (flag33)
			{
				goto IL_0a53;
			}
		}
		bool flag34 = array.Length < 2;
		object obj31 = !flag34;
		object obj32 = array.Length - 2;
		bool flag35 = obj32 == null;
		object obj33 = ~obj31;
		object obj34 = obj33 | flag35;
		obj15 = 0;
		num = num6;
		if (obj34 == null)
		{
			object obj35 = array + 48;
			obj35 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text5 = "{0} color encoding is currently unsupported for outputting to HDR." + 80;
			TextMeshProExtensions.Localize(textMesh2, (string)text5, array);
			return;
		}
		goto IL_0a45;
		IL_0a37:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0a45;
	}

	private void UpdateAcesInstructionsText()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_00d6: Expected I, but got O
		//IL_0072: Expected I, but got O
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0253: Expected I, but got O
		//IL_0275: Expected I, but got O
		//IL_028b: Expected I, but got O
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0332: Expected I, but got O
		//IL_0363: Expected I, but got O
		//IL_03d4: Expected O, but got I8
		//IL_0379: Expected I, but got O
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		TextMeshProUGUI textMesh;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if ((object)numberOfShardsAces != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = numberOfShardsAces.Text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				bool flag = StringsExtensions.IsNullOrEmpty(text);
				bool flag2 = !flag;
				nint num = unchecked((nint)null);
				if (!flag2)
				{
					goto IL_0080;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = StringsExtensions.IsNullOrEmpty(text);
				bool flag4 = !flag3;
				object obj3 = !flag4;
				nint num = unchecked((nint)null);
				if (obj3 != null)
				{
					goto IL_0080;
				}
			}
			if ((object)shardAces != null)
			{
				string text2 = shardAces.Text;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+E4]");
				TextMeshProUGUI textMesh2;
				if ((nint)0 != 0)
				{
					bool flag5 = StringsExtensions.IsNullOrEmpty(text2);
					textMesh = instructionsText;
					bool flag6 = !flag5;
					textMesh2 = instructionsText;
					if (!flag6)
					{
						goto IL_0179;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag7 = StringsExtensions.IsNullOrEmpty(text2);
					textMesh = instructionsText;
					bool flag8 = !flag7;
					object obj5 = !flag8;
					textMesh2 = instructionsText;
					if (obj5 != null)
					{
						goto IL_0179;
					}
				}
				object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag9 = (object)numberOfShardsAces == null;
				nint num = 2;
				if (!flag9)
				{
					string text3 = numberOfShardsAces.Text;
					object[] array = default(object[]);
					bool flag10 = array == null;
					num = unchecked((nint)null);
					if (!flag10)
					{
						bool flag11 = text3 == null;
						nint num2 = unchecked((nint)null);
						if (!flag11)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag12 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
							num = 0;
							if (flag12)
							{
								goto IL_045b;
							}
						}
						bool flag13 = array.Length == 0;
						num = num2;
						if (!flag13)
						{
							object obj7 = array + 32;
							obj7 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag14 = (object)shardAces == null;
							num = (nint)text3;
							if (flag14)
							{
								goto IL_043f;
							}
							string text4 = shardAces.Text;
							bool flag15 = text4 == null;
							nint num4 = unchecked((nint)null);
							if (!flag15)
							{
								nint num5 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
								num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag16 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
								num = 0;
								if (flag16)
								{
									goto IL_045b;
								}
							}
							object obj8 = array.Length & 0xFFFFFFFEL;
							bool flag17 = obj8 == null;
							num = num4;
							if (!flag17)
							{
								object obj9 = array + 40;
								obj9 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object text5 = "{0} color encoding is currently unsupported for outputting to HDR." + 72;
								TextMeshProExtensions.Localize(textMesh2, (string)text5, array);
								return;
							}
						}
						goto IL_044d;
					}
				}
			}
		}
		goto IL_043f;
		IL_044d:
		ex = new IndexOutOfRangeException();
		goto IL_045b;
		IL_043f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_044d;
		IL_0080:
		object text6 = "placementId" + 232;
		TextMeshProExtensions.Localize(instructionsText, (string)text6);
		return;
		IL_0179:
		object text7 = "placementId" + 240;
		TextMeshProExtensions.Localize(textMesh, (string)text7);
		return;
		IL_045b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void UpdateSubmitButton()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		object obj = "Material with texture name \"" + 3224;
		int totalCost = GetTotalCost();
		int num = default(int);
		string text = num.ToString((string)obj);
		totalText.text = text;
		bool interactable;
		if (GiftBombType != GiftBombType.Currency)
		{
			bool isSubsInputFieldsFilled = IsSubsInputFieldsFilled;
			interactable = isSubsInputFieldsFilled;
		}
		else
		{
			bool isAcesInputFieldsFilled = IsAcesInputFieldsFilled;
			bool flag = (object)createBomb == null;
			object obj2 = !flag;
			interactable = isAcesInputFieldsFilled;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		createBomb.interactable = interactable;
	}

	private void Clear()
	{
		//IL_0037: Expected O, but got I
		((BaseDropMenu<object>)(object)shardSubsOptions).Disable();
		shardSubsOptions.SetSelectedIndex(0);
		object text = (nint)0 + (nint)2000;
		shardAces.Text = (string)text;
		numberOfShardsSubs.Text = (string)text;
		numberOfShardsAces.Text = (string)text;
		bombMessage.Text = (string)text;
		SetInputPlaceHoldersToDefault();
	}

	private void RemovePopup()
	{
		popup.SlideToBottom();
	}

	private void OnTabTypeChange(int tabIndex)
	{
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubsInstructionsText();
		}
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubmitButton();
			return;
		}
		UpdateAcesInstructionsText();
		UpdateSubmitButton();
	}

	private unsafe void OnSizeSubsChanged(int optionIndex)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_0261: Expected I, but got O
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0317: Expected O, but got I
		//IL_0372: Expected O, but got I4
		KDropMenu kDropMenu = shardSubsOptions;
		bool flag = (object)shardSubsOptions == null;
		int num = optionIndex;
		RemoteConfigModel current;
		if (!flag)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v30+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0097;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v30+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					goto IL_0097;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			bool flag3 = current == null;
			num = 1;
			if (!flag3)
			{
				goto IL_0152;
			}
		}
		goto IL_0392;
		IL_0152:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		bool flag4 = current.<GiftBomb>k__BackingField == null;
		num = 1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag4)
		{
			int[] <SubShardDays>k__BackingField = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
			bool flag5 = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField == null;
			num = 1;
			if (!flag5)
			{
				bool flag6 = optionIndex < <SubShardDays>k__BackingField.Length;
				object obj6 = !flag6;
				num = 1;
				if (obj6 == null)
				{
					object obj7 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array = default(object[]);
					bool flag7 = array == null;
					object obj8 = default(object);
					num = (int)(&obj8);
					if (flag7)
					{
						goto IL_0392;
					}
					object obj9 = default(object);
					bool flag8 = obj9 == null;
					int num2 = (int)(&obj8);
					if (!flag8)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag9 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						if (flag9)
						{
							goto IL_03ae;
						}
					}
					bool flag10 = array.Length == 0;
					num = num2;
					if (!flag10)
					{
						object text = "DNQUALIFIER" + 1456;
						object obj10 = array + 32;
						obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (KDropMenu)+58]");
						TextMeshProExtensions.Localize((TextMeshProUGUI)0, (string)text, array);
						if (GiftBombType != GiftBombType.Currency)
						{
							UpdateSubsInstructionsText();
						}
						GiftBombType giftBombType = GiftBombType;
						bool flag11 = giftBombType == GiftBombType.Currency;
						object obj11 = !flag11;
						if (obj11 == null)
						{
							UpdateAcesInstructionsText();
						}
						UpdateSubmitButton();
						return;
					}
				}
				goto IL_03a0;
			}
		}
		goto IL_0392;
		IL_03a0:
		ex = new IndexOutOfRangeException();
		goto IL_03ae;
		IL_0392:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03a0;
		IL_03ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0097:
		current = RemoteConfig.Current;
		bool flag12 = current == null;
		object obj12 = !flag12;
		if (obj12 != null)
		{
			goto IL_0152;
		}
		num = 1;
		goto IL_0392;
	}

	private void OnSizeAcesChanged(string value)
	{
		int num = ShortcutExtensions.DOKill(shardAces);
		shardAces.Text = value;
		UIExtensions.EnsureNumeric(shardAces, 100000.0);
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubsInstructionsText();
		}
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubmitButton();
			return;
		}
		UpdateAcesInstructionsText();
		UpdateSubmitButton();
	}

	private void OnCountSubsChanged(string value)
	{
		int num = ShortcutExtensions.DOKill(numberOfShardsSubs);
		numberOfShardsSubs.Text = value;
		UIExtensions.EnsureNumeric(numberOfShardsSubs, 10000.0);
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubsInstructionsText();
		}
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubmitButton();
			return;
		}
		UpdateAcesInstructionsText();
		UpdateSubmitButton();
	}

	private void OnCountAcesChanged(string value)
	{
		int num = ShortcutExtensions.DOKill(numberOfShardsAces);
		numberOfShardsAces.Text = value;
		UIExtensions.EnsureNumeric(numberOfShardsAces, 10000.0);
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubsInstructionsText();
		}
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubmitButton();
			return;
		}
		UpdateAcesInstructionsText();
		UpdateSubmitButton();
	}

	private unsafe void OnSizeAcesInputEndEdit(string value)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_02e9: Expected O, but got I
		//IL_03a1: Expected O, but got I4
		//IL_0356: Expected O, but got I4
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_05af: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_05e7: Expected O, but got I4
		//IL_0452: Expected O, but got I4
		//IL_0468: Expected O, but got I
		//IL_0518: Expected O, but got I4
		//IL_04d5: Expected O, but got I4
		string text = shardAces.Text;
		int result;
		bool flag = int.TryParse(text, out result);
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v68+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v68+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		GiftBombCreationPopup giftBombCreationPopup = (GiftBombCreationPopup)(object)current;
		goto IL_013a;
		IL_029b:
		RemoteConfigModel current2;
		GiftBombConfig <GiftBomb>k__BackingField = current2.<GiftBomb>k__BackingField;
		int <MinShardPrice>k__BackingField = <GiftBomb>k__BackingField.<MinShardPrice>k__BackingField;
		AnimateInputFieldError(shardAces, <GiftBomb>k__BackingField.<MinShardPrice>k__BackingField);
		goto IL_02d3;
		IL_020f:
		current2 = RemoteConfig.Current;
		bool flag3 = current2 == null;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_029b;
		}
		goto IL_056a;
		IL_056a:
		throw new NullReferenceException();
		IL_0099:
		RemoteConfigModel current3 = RemoteConfig.Current;
		bool flag4 = current3 == null;
		object obj6 = !flag4;
		giftBombCreationPopup = (GiftBombCreationPopup)(object)current3;
		if (obj6 != null)
		{
			goto IL_013a;
		}
		goto IL_056a;
		IL_013a:
		InputFieldTMProUGUI inputFieldTMProUGUI = giftBombCreationPopup.bombMessage;
		int num = result;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (InputFieldTMProUGUI)+14]");
		bool flag5 = (nint)num >= (nint)0;
		<MinShardPrice>k__BackingField = (int)(&result);
		if (!flag5)
		{
			LocalizableText notSufficientAcesMessage = giftBombCreationPopup.GetNotSufficientAcesMessage();
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v47+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(notSufficientAcesMessage, (Vector2)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v52+E4]");
				if ((nint)0 != 0)
				{
					goto IL_020f;
				}
			}
			else
			{
				_ = 1;
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v52+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 != null)
				{
					goto IL_020f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current2 = RemoteConfig.Current;
			goto IL_029b;
		}
		goto IL_02d3;
		IL_02d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0333;
			}
		}
		else
		{
			_ = 1;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v33+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 != null)
			{
				goto IL_0333;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current4 = RemoteConfig.Current;
		GiftBombCreationPopup giftBombCreationPopup2 = (GiftBombCreationPopup)(object)current4;
		goto IL_03d4;
		IL_04b2:
		RemoteConfigModel current5 = RemoteConfig.Current;
		bool flag9 = current5 == null;
		object obj16 = !flag9;
		if (obj16 != null)
		{
			goto IL_053e;
		}
		goto IL_056a;
		IL_053e:
		GiftBombConfig <GiftBomb>k__BackingField2 = current5.<GiftBomb>k__BackingField;
		AnimateInputFieldError(shardAces, <GiftBomb>k__BackingField2.<MaxShardPrice>k__BackingField);
		return;
		IL_03d4:
		InputFieldTMProUGUI inputFieldTMProUGUI2 = giftBombCreationPopup2.bombMessage;
		if (result <= (nint)((MonoBehaviour)inputFieldTMProUGUI2).m_CancellationTokenSource)
		{
			return;
		}
		LocalizableText maximumAcesMessage = giftBombCreationPopup2.GetMaximumAcesMessage();
		object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(maximumAcesMessage, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_04b2;
			}
		}
		else
		{
			_ = 1;
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v17+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 != null)
			{
				goto IL_04b2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current5 = RemoteConfig.Current;
		goto IL_053e;
		IL_0333:
		RemoteConfigModel current6 = RemoteConfig.Current;
		bool flag12 = current6 == null;
		object obj23 = !flag12;
		giftBombCreationPopup2 = (GiftBombCreationPopup)(object)current6;
		if (obj23 != null)
		{
			goto IL_03d4;
		}
		goto IL_056a;
	}

	private unsafe void OnCountSubsInputEndEdit(string value)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_02e6: Expected O, but got I
		//IL_039e: Expected O, but got I4
		//IL_0353: Expected O, but got I4
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_05af: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_01c2: Expected O, but got I
		//IL_0272: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_05e7: Expected O, but got I4
		//IL_0452: Expected O, but got I4
		//IL_0468: Expected O, but got I
		//IL_0518: Expected O, but got I4
		//IL_04d5: Expected O, but got I4
		string text = numberOfShardsSubs.Text;
		int result;
		bool flag = int.TryParse(text, out result);
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v68+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v68+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		GiftBombCreationPopup giftBombCreationPopup = (GiftBombCreationPopup)(object)current;
		goto IL_013a;
		IL_0298:
		RemoteConfigModel current2;
		GiftBombConfig <GiftBomb>k__BackingField = current2.<GiftBomb>k__BackingField;
		int <MinSubShardCount>k__BackingField = <GiftBomb>k__BackingField.<MinSubShardCount>k__BackingField;
		AnimateInputFieldError(numberOfShardsSubs, <GiftBomb>k__BackingField.<MinSubShardCount>k__BackingField);
		goto IL_02d0;
		IL_020c:
		current2 = RemoteConfig.Current;
		bool flag3 = current2 == null;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_0298;
		}
		goto IL_056a;
		IL_056a:
		throw new NullReferenceException();
		IL_0099:
		RemoteConfigModel current3 = RemoteConfig.Current;
		bool flag4 = current3 == null;
		object obj6 = !flag4;
		giftBombCreationPopup = (GiftBombCreationPopup)(object)current3;
		if (obj6 != null)
		{
			goto IL_013a;
		}
		goto IL_056a;
		IL_013a:
		InputFieldTMProUGUI inputFieldTMProUGUI = giftBombCreationPopup.bombMessage;
		bool flag5 = result >= (nint)inputFieldTMProUGUI.input;
		<MinSubShardCount>k__BackingField = (int)(&result);
		if (!flag5)
		{
			LocalizableText notSufficientSubsShardsMessage = giftBombCreationPopup.GetNotSufficientSubsShardsMessage();
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v47+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(notSufficientSubsShardsMessage, (Vector2)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v52+E4]");
				if ((nint)0 != 0)
				{
					goto IL_020c;
				}
			}
			else
			{
				_ = 1;
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v52+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 != null)
				{
					goto IL_020c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current2 = RemoteConfig.Current;
			goto IL_0298;
		}
		goto IL_02d0;
		IL_02d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0330;
			}
		}
		else
		{
			_ = 1;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v33+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 != null)
			{
				goto IL_0330;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current4 = RemoteConfig.Current;
		GiftBombCreationPopup giftBombCreationPopup2 = (GiftBombCreationPopup)(object)current4;
		goto IL_03d1;
		IL_04b2:
		RemoteConfigModel current5 = RemoteConfig.Current;
		bool flag9 = current5 == null;
		object obj16 = !flag9;
		if (obj16 != null)
		{
			goto IL_053e;
		}
		goto IL_056a;
		IL_053e:
		GiftBombConfig <GiftBomb>k__BackingField2 = current5.<GiftBomb>k__BackingField;
		AnimateInputFieldError(numberOfShardsSubs, <GiftBomb>k__BackingField2.<MaxSubShardCount>k__BackingField);
		return;
		IL_03d1:
		InputFieldTMProUGUI inputFieldTMProUGUI2 = giftBombCreationPopup2.bombMessage;
		int num = result;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (InputFieldTMProUGUI)+34]");
		if ((nint)num <= (nint)0)
		{
			return;
		}
		LocalizableText maximumSubsShardsMessage = giftBombCreationPopup2.GetMaximumSubsShardsMessage();
		object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(maximumSubsShardsMessage, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_04b2;
			}
		}
		else
		{
			_ = 1;
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v17+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 != null)
			{
				goto IL_04b2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current5 = RemoteConfig.Current;
		goto IL_053e;
		IL_0330:
		RemoteConfigModel current6 = RemoteConfig.Current;
		bool flag12 = current6 == null;
		object obj23 = !flag12;
		giftBombCreationPopup2 = (GiftBombCreationPopup)(object)current6;
		if (obj23 != null)
		{
			goto IL_03d1;
		}
		goto IL_056a;
	}

	private unsafe void OnCountAcesInputEndEdit(string value)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_02e6: Expected O, but got I
		//IL_039e: Expected O, but got I4
		//IL_0353: Expected O, but got I4
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_05af: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_01c2: Expected O, but got I
		//IL_0272: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_05e7: Expected O, but got I4
		//IL_0452: Expected O, but got I4
		//IL_0468: Expected O, but got I
		//IL_0518: Expected O, but got I4
		//IL_04d5: Expected O, but got I4
		string text = numberOfShardsAces.Text;
		int result;
		bool flag = int.TryParse(text, out result);
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v68+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v68+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		GiftBombCreationPopup giftBombCreationPopup = (GiftBombCreationPopup)(object)current;
		goto IL_013a;
		IL_0298:
		RemoteConfigModel current2;
		GiftBombConfig <GiftBomb>k__BackingField = current2.<GiftBomb>k__BackingField;
		int <MinShardCount>k__BackingField = <GiftBomb>k__BackingField.<MinShardCount>k__BackingField;
		AnimateInputFieldError(numberOfShardsAces, <GiftBomb>k__BackingField.<MinShardCount>k__BackingField);
		goto IL_02d0;
		IL_020c:
		current2 = RemoteConfig.Current;
		bool flag3 = current2 == null;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_0298;
		}
		goto IL_056a;
		IL_056a:
		throw new NullReferenceException();
		IL_0099:
		RemoteConfigModel current3 = RemoteConfig.Current;
		bool flag4 = current3 == null;
		object obj6 = !flag4;
		giftBombCreationPopup = (GiftBombCreationPopup)(object)current3;
		if (obj6 != null)
		{
			goto IL_013a;
		}
		goto IL_056a;
		IL_013a:
		InputFieldTMProUGUI inputFieldTMProUGUI = giftBombCreationPopup.bombMessage;
		bool flag5 = result >= (nint)inputFieldTMProUGUI.placeholder;
		<MinShardCount>k__BackingField = (int)(&result);
		if (!flag5)
		{
			LocalizableText notSufficientAcesShardsMessage = giftBombCreationPopup.GetNotSufficientAcesShardsMessage();
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v47+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(notSufficientAcesShardsMessage, (Vector2)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v52+E4]");
				if ((nint)0 != 0)
				{
					goto IL_020c;
				}
			}
			else
			{
				_ = 1;
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v52+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 != null)
				{
					goto IL_020c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current2 = RemoteConfig.Current;
			goto IL_0298;
		}
		goto IL_02d0;
		IL_02d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0330;
			}
		}
		else
		{
			_ = 1;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v33+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 != null)
			{
				goto IL_0330;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current4 = RemoteConfig.Current;
		GiftBombCreationPopup giftBombCreationPopup2 = (GiftBombCreationPopup)(object)current4;
		goto IL_03d1;
		IL_04b2:
		RemoteConfigModel current5 = RemoteConfig.Current;
		bool flag9 = current5 == null;
		object obj16 = !flag9;
		if (obj16 != null)
		{
			goto IL_053e;
		}
		goto IL_056a;
		IL_053e:
		GiftBombConfig <GiftBomb>k__BackingField2 = current5.<GiftBomb>k__BackingField;
		AnimateInputFieldError(numberOfShardsAces, <GiftBomb>k__BackingField2.<MaxShardCount>k__BackingField);
		return;
		IL_03d1:
		InputFieldTMProUGUI inputFieldTMProUGUI2 = giftBombCreationPopup2.bombMessage;
		int num = result;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v9 (InputFieldTMProUGUI)+2C]");
		if ((nint)num <= (nint)0)
		{
			return;
		}
		LocalizableText maximumAcesShardsMessage = giftBombCreationPopup2.GetMaximumAcesShardsMessage();
		object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(maximumAcesShardsMessage, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_04b2;
			}
		}
		else
		{
			_ = 1;
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v17+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 != null)
			{
				goto IL_04b2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current5 = RemoteConfig.Current;
		goto IL_053e;
		IL_0330:
		RemoteConfigModel current6 = RemoteConfig.Current;
		bool flag12 = current6 == null;
		object obj23 = !flag12;
		giftBombCreationPopup2 = (GiftBombCreationPopup)(object)current6;
		if (obj23 != null)
		{
			goto IL_03d1;
		}
		goto IL_056a;
	}

	private void SetNumericInput(InputFieldTMProUGUI inputField, string val)
	{
		int num = ShortcutExtensions.DOKill(inputField);
		inputField.Text = val;
	}

	private int GetTotalCost()
	{
		//IL_005b: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_04c7: Expected I4, but got O
		//IL_01f2: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_031d: Expected O, but got I
		//IL_03cd: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_0499: Expected O, but got I
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected I4, but got Unknown
		int result;
		object obj2;
		RemoteConfigModel current;
		if (GiftBombType != GiftBombType.Currency)
		{
			bool isSubsInputFieldsFilled = IsSubsInputFieldsFilled;
			bool flag = !isSubsInputFieldsFilled;
			result = (isSubsInputFieldsFilled ? 1 : 0);
			if (!flag)
			{
				object obj = 152989696;
				obj2 = typeof(RegisteredWaitHandle) + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v36+E4]");
					if ((nint)0 != 0)
					{
						goto IL_00cf;
					}
				}
				else
				{
					_ = 1;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v36+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 != null)
					{
						goto IL_00cf;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				current = RemoteConfig.Current;
				if (current != null)
				{
					goto IL_0235;
				}
				goto IL_04ab;
			}
		}
		else
		{
			bool isAcesInputFieldsFilled = IsAcesInputFieldsFilled;
			bool flag3 = !isAcesInputFieldsFilled;
			result = (isAcesInputFieldsFilled ? 1 : 0);
			if (!flag3)
			{
				if ((object)shardAces != null)
				{
					string text = shardAces.Text;
					int num = int.Parse(text);
					if ((object)numberOfShardsAces != null)
					{
						string text2 = numberOfShardsAces.Text;
						int num2 = int.Parse(text2);
						result = num2 * num;
						goto IL_04c7;
					}
				}
				goto IL_04ab;
			}
		}
		goto IL_04c7;
		IL_0235:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		RemoteConfigModel current2;
		if (current.<GiftBomb>k__BackingField != null)
		{
			KDropMenu kDropMenu = shardSubsOptions;
			if ((object)shardSubsOptions != null)
			{
				int[] <SubShardDays>k__BackingField = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
				if (<GiftBomb>k__BackingField.<SubShardDays>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v3 (KDropMenu)+34]");
					bool flag4 = (nint)0 < (nint)<SubShardDays>k__BackingField.Length;
					object obj6 = !flag4;
					if (obj6 != null)
					{
						goto IL_04b9;
					}
					int[] <SubShardDays>k__BackingField2 = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v3 (KDropMenu)+34]");
					object obj7 = <SubShardDays>k__BackingField2 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X20_v6+752]");
					object obj8 = (nint)0 & (nint)1;
					if (obj8 != null)
					{
						object obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v24+E4]");
						if ((nint)0 != 0)
						{
							goto IL_0367;
						}
					}
					else
					{
						_ = 1;
						object obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v24+E4]");
						bool flag5 = (nint)0 == 0;
						object obj10 = !flag5;
						if (obj10 != null)
						{
							goto IL_0367;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					current2 = RemoteConfig.Current;
					if (current2 != null)
					{
						goto IL_0410;
					}
				}
			}
		}
		goto IL_04ab;
		IL_0410:
		GiftBombConfig <GiftBomb>k__BackingField2 = current2.<GiftBomb>k__BackingField;
		if (current2.<GiftBomb>k__BackingField != null && (object)numberOfShardsSubs != null)
		{
			string text3 = numberOfShardsSubs.Text;
			int num3 = int.Parse(text3);
			int <SubBombOneDayAceToSub>k__BackingField = <GiftBomb>k__BackingField2.<SubBombOneDayAceToSub>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v7+20]");
			object obj11 = (nint)<SubBombOneDayAceToSub>k__BackingField * (nint)0;
			return obj11 * num3;
		}
		goto IL_04ab;
		IL_04ab:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04b9;
		IL_04b9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
		IL_0367:
		current2 = RemoteConfig.Current;
		bool flag6 = current2 == null;
		object obj12 = !flag6;
		if (obj12 != null)
		{
			goto IL_0410;
		}
		goto IL_04ab;
		IL_04c7:
		return result;
		IL_00cf:
		current = RemoteConfig.Current;
		bool flag7 = current == null;
		object obj13 = !flag7;
		if (obj13 != null)
		{
			goto IL_0235;
		}
		goto IL_04ab;
	}

	private LocalizableText GetNotSufficientAcesMessage()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0277: Expected I8, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_02e7: Expected I, but got O
		//IL_0319: Expected O, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7759]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_03bf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03cd;
		IL_03b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03bf;
		IL_03cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_01b8:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "AvailableVoices" + 3920;
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input, <GiftBomb>k__BackingField.<MinShardPrice>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag6 = array == null;
			object obj14 = 0;
			nint num = 1;
			if (!flag6)
			{
				bool flag7 = text == null;
				nint num2 = 1;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag8)
					{
						goto IL_03cd;
					}
				}
				bool flag9 = array.Length == 0;
				obj14 = 0;
				num = num2;
				if (!flag9)
				{
					object text2 = "getSecondRescanTask" + 1600;
					object obj15 = array + 32;
					obj15 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text2, array);
				}
				goto IL_03bf;
			}
		}
		goto IL_03b1;
	}

	private LocalizableText GetMaximumAcesMessage()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0277: Expected I8, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_02e7: Expected I, but got O
		//IL_0319: Expected O, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E775A]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_03bf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03cd;
		IL_03b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03bf;
		IL_03cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_01b8:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "AvailableVoices" + 3920;
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input, <GiftBomb>k__BackingField.<MaxShardPrice>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag6 = array == null;
			object obj14 = 0;
			nint num = 1;
			if (!flag6)
			{
				bool flag7 = text == null;
				nint num2 = 1;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag8)
					{
						goto IL_03cd;
					}
				}
				bool flag9 = array.Length == 0;
				obj14 = 0;
				num = num2;
				if (!flag9)
				{
					object text2 = "getSecondRescanTask" + 1608;
					object obj15 = array + 32;
					obj15 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text2, array);
				}
				goto IL_03bf;
			}
		}
		goto IL_03b1;
	}

	private LocalizableText GetNotSufficientSubsShardsMessage()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0277: Expected I8, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_02e7: Expected I, but got O
		//IL_0319: Expected O, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E775B]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_03bf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03cd;
		IL_03b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03bf;
		IL_03cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_01b8:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1904;
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input, <GiftBomb>k__BackingField.<MinSubShardCount>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag6 = array == null;
			object obj14 = 0;
			nint num = 1;
			if (!flag6)
			{
				bool flag7 = text == null;
				nint num2 = 1;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag8)
					{
						goto IL_03cd;
					}
				}
				bool flag9 = array.Length == 0;
				obj14 = 0;
				num = num2;
				if (!flag9)
				{
					object text2 = "getSecondRescanTask" + 1624;
					object obj15 = array + 32;
					obj15 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text2, array);
				}
				goto IL_03bf;
			}
		}
		goto IL_03b1;
	}

	private LocalizableText GetMaximumSubsShardsMessage()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0277: Expected I8, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_02e7: Expected I, but got O
		//IL_0319: Expected O, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E775C]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_03bf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03cd;
		IL_03b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03bf;
		IL_03cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_01b8:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1904;
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input, <GiftBomb>k__BackingField.<MaxSubShardCount>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag6 = array == null;
			object obj14 = 0;
			nint num = 1;
			if (!flag6)
			{
				bool flag7 = text == null;
				nint num2 = 1;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag8)
					{
						goto IL_03cd;
					}
				}
				bool flag9 = array.Length == 0;
				obj14 = 0;
				num = num2;
				if (!flag9)
				{
					object text2 = "getSecondRescanTask" + 1632;
					object obj15 = array + 32;
					obj15 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text2, array);
				}
				goto IL_03bf;
			}
		}
		goto IL_03b1;
	}

	private LocalizableText GetNotSufficientAcesShardsMessage()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0277: Expected I8, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_02e7: Expected I, but got O
		//IL_0319: Expected O, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E775D]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_03bf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03cd;
		IL_03b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03bf;
		IL_03cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_01b8:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1904;
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input, <GiftBomb>k__BackingField.<MinShardCount>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag6 = array == null;
			object obj14 = 0;
			nint num = 1;
			if (!flag6)
			{
				bool flag7 = text == null;
				nint num2 = 1;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag8)
					{
						goto IL_03cd;
					}
				}
				bool flag9 = array.Length == 0;
				obj14 = 0;
				num = num2;
				if (!flag9)
				{
					object text2 = "getSecondRescanTask" + 1624;
					object obj15 = array + 32;
					obj15 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text2, array);
				}
				goto IL_03bf;
			}
		}
		goto IL_03b1;
	}

	private LocalizableText GetMaximumAcesShardsMessage()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0277: Expected I8, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_02e7: Expected I, but got O
		//IL_0319: Expected O, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E775E]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_03bf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03cd;
		IL_03b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03bf;
		IL_03cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_01b8;
		}
		goto IL_03b1;
		IL_01b8:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1904;
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input, <GiftBomb>k__BackingField.<MaxShardCount>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag6 = array == null;
			object obj14 = 0;
			nint num = 1;
			if (!flag6)
			{
				bool flag7 = text == null;
				nint num2 = 1;
				if (!flag7)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag8)
					{
						goto IL_03cd;
					}
				}
				bool flag9 = array.Length == 0;
				obj14 = 0;
				num = num2;
				if (!flag9)
				{
					object text2 = "getSecondRescanTask" + 1632;
					object obj15 = array + 32;
					obj15 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text2, array);
				}
				goto IL_03bf;
			}
		}
		goto IL_03b1;
	}

	private void GiveInputDeniedFeedback(LocalizableText errorToast)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(errorToast, (Vector2)0, 0f);
	}

	private static void AnimateInputFieldError(InputFieldTMProUGUI inputField, int rightAmount)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0116: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_0179: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7672]");
		object obj3 = (nint)0 & (nint)1;
		RectTransform rectTransform;
		RectTransform rect;
		if (obj3 != null)
		{
			rectTransform = UIExtensions.rectTransform(inputField);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			rect = rectTransform;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			rectTransform = UIExtensions.rectTransform(inputField);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			rect = rectTransform;
			if (obj6 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AnimationExtensions.ErrorFeedback(rect);
		bool flag3 = (object)inputField == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00bb;
		IL_009b:
		AnimationExtensions.ErrorFeedback(rectTransform);
		goto IL_00bb;
		IL_00bb:
		inputField.AnimateValueChange(rightAmount, 0.3f, 0.6f);
	}

	private void OnConfigChange()
	{
		CheckSubOptions();
		CheckBombToggles();
		EidPreparation();
		SetInputPlaceHoldersToDefault();
		UpdateMuteState();
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubsInstructionsText();
		}
		if (GiftBombType != GiftBombType.Currency)
		{
			UpdateSubmitButton();
			return;
		}
		UpdateAcesInstructionsText();
		UpdateSubmitButton();
	}

	private void CheckSubOptions()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0155: Expected O, but got I4
		//IL_0219: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_024b: Expected O, but got I4
		//IL_02f4: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0283: Expected O, but got I
		//IL_0294: Expected I, but got O
		//IL_02b2: Expected O, but got I
		//IL_01cc: Expected O, but got I
		KDropMenu kDropMenu = shardSubsOptions;
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v23+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0079;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v23+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0079;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0105;
		IL_0105:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 280;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v11+10]");
		Func<int, object> selector = (Func<int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v11+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v17+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1928;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)2144;
			Func<int, object> func = default(Func<int, object>);
			func..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v16+B8]");
			object obj15 = (nint)0 + (nint)16;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> second = Enumerable.Select(<GiftBomb>k__BackingField.<SubShardDays>k__BackingField, selector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (KDropMenu)+98]");
		if (!Enumerable.SequenceEqual((IEnumerable<object>)0, second))
		{
			CreateSubOptions();
			Clear();
		}
		return;
		IL_0079:
		current = RemoteConfig.Current;
		bool flag5 = current == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0105;
	}

	private void CheckBombToggles()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_028e: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_033e: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_02fb: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_03c1: Expected O, but got I
		//IL_0471: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_04d6: Expected O, but got I
		//IL_0586: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_05f6: Expected O, but got I
		//IL_06cf: Expected O, but got I4
		//IL_0663: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v81+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v81+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0100;
		IL_0364:
		RemoteConfigModel current2;
		GiftBombConfig <GiftBomb>k__BackingField = current2.<GiftBomb>k__BackingField;
		TabsUI.Tab tab;
		tab.button.interactable = <GiftBomb>k__BackingField.<SubscriptionBombEnabled>k__BackingField;
		TabsUI.Tab tab2 = typeTab.get_Item(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 != null)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v43+E4]");
			if ((nint)0 != 0)
			{
				goto IL_040b;
			}
		}
		else
		{
			_ = 1;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v43+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_040b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current3 = RemoteConfig.Current;
		goto IL_0497;
		IL_02d8:
		current2 = RemoteConfig.Current;
		bool flag3 = current2 == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_0364;
		}
		goto IL_0747;
		IL_0747:
		throw new NullReferenceException();
		IL_0074:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_0100;
		}
		goto IL_0747;
		IL_0100:
		GiftBombConfig <GiftBomb>k__BackingField2 = current.<GiftBomb>k__BackingField;
		bool flag5 = !<GiftBomb>k__BackingField2.<SubscriptionBombEnabled>k__BackingField;
		object obj10 = !flag5;
		RemoteConfigModel current4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v69+E4]");
				if ((nint)0 != 0)
				{
					goto IL_019f;
				}
			}
			else
			{
				_ = 1;
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v69+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 != null)
				{
					goto IL_019f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current4 = RemoteConfig.Current;
			goto IL_022b;
		}
		goto IL_025f;
		IL_0640:
		RemoteConfigModel current5 = RemoteConfig.Current;
		bool flag7 = current5 == null;
		object obj14 = !flag7;
		if (obj14 != null)
		{
			goto IL_06f5;
		}
		goto IL_0747;
		IL_040b:
		current3 = RemoteConfig.Current;
		bool flag8 = current3 == null;
		object obj15 = !flag8;
		if (obj15 != null)
		{
			goto IL_0497;
		}
		goto IL_0747;
		IL_0520:
		RemoteConfigModel current6 = RemoteConfig.Current;
		bool flag9 = current6 == null;
		object obj16 = !flag9;
		if (obj16 != null)
		{
			goto IL_05ac;
		}
		goto IL_0747;
		IL_05ac:
		GiftBombConfig <GiftBomb>k__BackingField3 = current6.<GiftBomb>k__BackingField;
		if (<GiftBomb>k__BackingField3.<SubscriptionBombEnabled>k__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj17 = (nint)0 & (nint)1;
			if (obj17 != null)
			{
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0640;
				}
			}
			else
			{
				_ = 1;
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v19+E4]");
				bool flag10 = (nint)0 == 0;
				object obj19 = !flag10;
				if (obj19 != null)
				{
					goto IL_0640;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current5 = RemoteConfig.Current;
			goto IL_06f5;
		}
		TabsUI tabsUI = typeTab;
		int tabIndex = 1;
		goto IL_074e;
		IL_019f:
		current4 = RemoteConfig.Current;
		bool flag11 = current4 == null;
		object obj20 = !flag11;
		if (obj20 != null)
		{
			goto IL_022b;
		}
		goto IL_0747;
		IL_022b:
		GiftBombConfig <GiftBomb>k__BackingField4 = current4.<GiftBomb>k__BackingField;
		if (<GiftBomb>k__BackingField4.<CurrencyBombEnabled>k__BackingField)
		{
			goto IL_025f;
		}
		popup.SlideToBottom();
		return;
		IL_0497:
		GiftBombConfig <GiftBomb>k__BackingField5 = current3.<GiftBomb>k__BackingField;
		tab2.button.interactable = <GiftBomb>k__BackingField5.<CurrencyBombEnabled>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v31+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0520;
			}
		}
		else
		{
			_ = 1;
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v31+E4]");
			bool flag12 = (nint)0 == 0;
			object obj23 = !flag12;
			if (obj23 != null)
			{
				goto IL_0520;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current6 = RemoteConfig.Current;
		goto IL_05ac;
		IL_025f:
		tab = typeTab.get_Item(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
		object obj24 = (nint)0 & (nint)1;
		if (obj24 != null)
		{
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v55+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02d8;
			}
		}
		else
		{
			_ = 1;
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v55+E4]");
			bool flag13 = (nint)0 == 0;
			object obj26 = !flag13;
			if (obj26 != null)
			{
				goto IL_02d8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current2 = RemoteConfig.Current;
		goto IL_0364;
		IL_06f5:
		GiftBombConfig <GiftBomb>k__BackingField6 = current5.<GiftBomb>k__BackingField;
		if (<GiftBomb>k__BackingField6.<CurrencyBombEnabled>k__BackingField)
		{
			return;
		}
		tabsUI = typeTab;
		tabIndex = 0;
		goto IL_074e;
		IL_074e:
		tabsUI.Activate(tabIndex);
		Clear();
	}

	private void EidPreparation()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7761]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7753]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7753]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_019b:
		RemoteConfigModel current;
		VisualsConfig <Visuals>k__BackingField = current.<Visuals>k__BackingField;
		if (<Visuals>k__BackingField.<IsEid>k__BackingField)
		{
			object text = "Network Authentication Required" + 2528;
			TextMeshProExtensions.Localize(numberOfAcesGiftsTitle, (string)text);
			TextMeshProExtensions.Localize(numberOfSubsGiftsTitle, (string)text);
			object text2 = "Drop Menu Toggle" + 1968;
			TextMeshProExtensions.Localize(giftAcesValueTitle, (string)text2);
			Clear();
		}
		return;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_019b;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		goto IL_019b;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
	}

	private unsafe void ShowConfirmation()
	{
		//IL_00e8: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0055: Expected O, but got I
		//IL_006d: Expected I, but got O
		//IL_009c: Expected O, but got I4
		//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Expected O, but got Unknown
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Expected O, but got Unknown
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_0240: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		//IL_02a8: Expected I4, but got O
		//IL_02f0: Expected O, but got I
		//IL_03d0: Expected O, but got I4
		//IL_037d: Expected O, but got I4
		//IL_0438: Expected I4, but got O
		//IL_047f: Expected O, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected I4, but got Unknown
		//IL_04e5: Expected O, but got I4
		//IL_101f: Expected O, but got I4
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected I4, but got Unknown
		//IL_107d: Expected O, but got I4
		//IL_0552: Expected O, but got I
		//IL_0632: Expected O, but got I4
		//IL_05df: Expected O, but got I4
		//IL_069a: Expected I4, but got O
		//IL_06e2: Expected O, but got I
		//IL_07c2: Expected O, but got I4
		//IL_076f: Expected O, but got I4
		//IL_082a: Expected I4, but got O
		//IL_0871: Expected O, but got I
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected I4, but got Unknown
		//IL_08d7: Expected O, but got I4
		//IL_10c0: Expected O, but got I4
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Expected I4, but got Unknown
		//IL_111e: Expected O, but got I4
		//IL_1144: Unknown result type (might be due to invalid IL or missing references)
		//IL_1149: Expected O, but got Unknown
		//IL_1173: Expected O, but got I4
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected O, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected I4, but got Unknown
		//IL_096a: Expected O, but got I4
		//IL_09a8: Expected O, but got Ref
		//IL_09be: Expected I, but got O
		//IL_09ce: Expected O, but got I
		//IL_09f7: Expected O, but got I
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected O, but got Unknown
		//IL_0a6a: Expected O, but got Ref
		//IL_0adb: Expected O, but got I8
		//IL_0a80: Expected I, but got O
		//IL_0a90: Expected O, but got I
		//IL_0ab9: Expected O, but got I
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected O, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b34: Expected O, but got Unknown
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected O, but got Unknown
		//IL_0b74: Expected O, but got I
		//IL_0b82: Expected I, but got O
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected O, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected I4, but got Unknown
		//IL_0bba: Expected O, but got I4
		//IL_0bd4: Expected O, but got I4
		//IL_0bf0: Expected O, but got I4
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Expected O, but got Unknown
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Expected O, but got Unknown
		//IL_0c29: Expected I, but got O
		//IL_0c39: Expected O, but got I
		//IL_11d1: Expected O, but got I4
		//IL_11fa: Expected O, but got I4
		//IL_0c74: Expected O, but got I
		//IL_0d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected O, but got Unknown
		//IL_0d28: Expected O, but got I
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected O, but got Unknown
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0dbe: Expected I4, but got O
		//IL_0dce: Expected O, but got I
		//IL_0df0: Expected O, but got I4
		//IL_0e05: Expected O, but got I
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Expected O, but got Unknown
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0d63: Expected O, but got I
		//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected O, but got Unknown
		//IL_0e2f: Expected I, but got O
		//IL_0e3f: Expected O, but got I
		//IL_0ece: Expected O, but got I4
		//IL_0edc: Expected O, but got I4
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected O, but got Unknown
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected O, but got Unknown
		//IL_0f1a: Expected I4, but got O
		//IL_0f2a: Expected O, but got I
		//IL_0f4e: Expected O, but got I4
		//IL_0f5f: Expected O, but got I4
		//IL_0f74: Expected O, but got I
		//IL_0e7a: Expected O, but got I
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected O, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Expected O, but got Unknown
		//IL_1258: Expected O, but got I4
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected O, but got Unknown
		//IL_0e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7762]");
		int num = 0;
		if (GiftBombType != GiftBombType.Currency)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3600;
			object obj2 = (nint)0 + (nint)3024;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj4 = (nint)0 + (nint)2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v123+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
			return;
		}
		GiftBombType giftBombType = GiftBombType;
		bool flag2 = giftBombType == GiftBombType.Currency;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			return;
		}
		int num2;
		object obj8;
		RemoteConfigModel current;
		if ((object)shardAces != null)
		{
			string text = shardAces.Text;
			num2 = int.Parse(text);
			obj8 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj9 = (nint)0 & (nint)1;
			int num3;
			if (obj9 != null)
			{
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v109+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v109+E4]");
				bool flag3 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v109+E4]");
				num3 = 0;
				if (!flag3)
				{
					goto IL_01ca;
				}
			}
			else
			{
				_ = 1;
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v109+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v109+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v109+E4]");
				num3 = 0;
				if (obj11 != null)
				{
					goto IL_01ca;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			bool flag5 = current == null;
			num = num3;
			if (!flag5)
			{
				goto IL_029b;
			}
		}
		goto IL_0f82;
		IL_11a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v812 @ X8_v53] (should have been resolved before IL gen)");
		num = (int)((nint)0 + (nint)2352);
		string text3;
		string text4;
		string text2 = text3 + (string)((int*)num)->m_value + text4;
		LocalizableText localizableText = TextMeshProExtensions.FixOnly(text2);
		object obj12 = default(object);
		bool flag6 = obj12 == null;
		object obj13 = 0;
		string text5 = null;
		string text6 = text4;
		object obj18 = default(object);
		string text7;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag6)
		{
			object obj14 = typeof(System.IOAsyncCallback) + 384;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v58+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v58+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0dac;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v58+B0]");
			object obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X10_v15-8]");
				if (0 == (nint)obj14)
				{
					break;
				}
				obj18 = obj17 + 16;
				obj16--;
				bool flag7 = (nint)obj16 != 1;
				obj17 = obj18;
				if (flag7)
				{
					continue;
				}
				goto IL_0dac;
			}
			object obj19 = obj17 + 1;
			object obj20 = obj15 + obj19;
			object obj21 = obj20 + 312;
			num = (int)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v63+8]");
			text7 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v857 @ X0_v63] (should have been resolved before IL gen)");
			bool flag8 = ex == null;
			object obj22 = !flag8;
			obj18 = obj17;
			obj13 = 0;
			text5 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v63+8]");
			text6 = (string)0;
			if (obj22 != null)
			{
				goto IL_0e13;
			}
		}
		goto IL_0f82;
		IL_0dac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj23 = default(object);
		num = (int)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v60+8]");
		text7 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ X0_v60] (should have been resolved before IL gen)");
		bool flag9 = ex == null;
		obj13 = 0;
		text5 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v60+8]");
		text6 = (string)0;
		if (!flag9)
		{
			goto IL_0e13;
		}
		goto IL_0f82;
		IL_0e13:
		object obj24 = typeof(System.IOAsyncCallback) + 368;
		nint num4 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v62 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v62 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ebb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v62 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v12-8]");
			bool flag10 = 0 == (nint)obj24;
			obj13 = 0;
			text5 = null;
			text6 = text7;
			num = (int)num4;
			if (flag10)
			{
				break;
			}
			obj18 += 16;
			obj25--;
			if ((nint)obj25 != 1)
			{
				continue;
			}
			goto IL_0ebb;
		}
		goto IL_0f90;
		IL_0cbd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj27 = default(object);
		object obj26 = obj27;
		goto IL_11a5;
		IL_068d:
		RemoteConfigModel current2;
		num = (int)current2.<GiftBomb>k__BackingField;
		int num5;
		RemoteConfigModel current3;
		if (current2.<GiftBomb>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+28]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj28 = (nint)0 & (nint)1;
			int num6;
			if (obj28 != null)
			{
				object obj29 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v73+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v73+E4]");
				bool flag11 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v73+E4]");
				num6 = 0;
				if (!flag11)
				{
					goto IL_074c;
				}
			}
			else
			{
				_ = 1;
				object obj29 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v73+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v73+E4]");
				bool flag12 = (nint)0 == 0;
				object obj30 = !flag12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v73+E4]");
				num6 = 0;
				if (obj30 != null)
				{
					goto IL_074c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current3 = RemoteConfig.Current;
			bool flag13 = current3 == null;
			num = num6;
			if (!flag13)
			{
				goto IL_081d;
			}
		}
		goto IL_0f82;
		IL_05bc:
		current2 = RemoteConfig.Current;
		bool flag14 = current2 == null;
		object obj31 = !flag14;
		if (obj31 != null)
		{
			goto IL_068d;
		}
		goto IL_0f82;
		IL_01ca:
		current = RemoteConfig.Current;
		bool flag15 = current == null;
		object obj32 = !flag15;
		if (obj32 != null)
		{
			goto IL_029b;
		}
		goto IL_0f82;
		IL_029b:
		num = (int)current.<GiftBomb>k__BackingField;
		int num7;
		RemoteConfigModel current4;
		if (current.<GiftBomb>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+14]");
			num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj33 = (nint)0 & (nint)1;
			int num8;
			if (obj33 != null)
			{
				object obj34 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v97+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v97+E4]");
				bool flag16 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v97+E4]");
				num8 = 0;
				if (!flag16)
				{
					goto IL_035a;
				}
			}
			else
			{
				_ = 1;
				object obj34 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v97+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v97+E4]");
				bool flag17 = (nint)0 == 0;
				object obj35 = !flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v97+E4]");
				num8 = 0;
				if (obj35 != null)
				{
					goto IL_035a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current4 = RemoteConfig.Current;
			bool flag18 = current4 == null;
			num = num8;
			if (!flag18)
			{
				goto IL_042b;
			}
		}
		goto IL_0f82;
		IL_0ebb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj13 = 0;
		text5 = null;
		text6 = (string)9;
		object obj37 = default(object);
		object obj36 = obj37;
		goto IL_127b;
		IL_074c:
		current3 = RemoteConfig.Current;
		bool flag19 = current3 == null;
		object obj38 = !flag19;
		if (obj38 != null)
		{
			goto IL_081d;
		}
		goto IL_0f82;
		IL_0f90:
		object obj39 = obj18 + 9;
		object obj40 = num + obj39;
		obj36 = obj40 + 312;
		goto IL_127b;
		IL_127b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ X8_v4] (should have been resolved before IL gen)");
		return;
		IL_035a:
		current4 = RemoteConfig.Current;
		bool flag20 = current4 == null;
		object obj41 = !flag20;
		if (obj41 != null)
		{
			goto IL_042b;
		}
		goto IL_0f82;
		IL_042b:
		num = (int)current4.<GiftBomb>k__BackingField;
		int num15;
		if (current4.<GiftBomb>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+18]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+18]");
			object obj42 = (nint)num2 - (nint)0;
			bool flag21 = (nint)obj42 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+18]");
			int num9 = (int)((nint)num2 ^ (nint)0);
			int num10 = num2 ^ obj42;
			int num11 = num9 & num10;
			bool flag22 = num11 < 0;
			bool flag23 = flag21 == flag22;
			object obj43 = !flag23;
			object obj44 = ~obj43;
			if (obj44 == null)
			{
				num = num2;
			}
			object obj45 = num2 - num7;
			bool flag24 = (nint)obj45 < 0;
			int num12 = num2 ^ num7;
			int num13 = num2 ^ obj45;
			int num14 = num12 & num13;
			bool flag25 = num14 < 0;
			bool flag26 = flag24 == flag25;
			object obj46 = !flag26;
			object obj47 = ~obj46;
			if (obj47 != null)
			{
				num7 = num;
			}
			if ((object)numberOfShardsAces != null)
			{
				string text8 = numberOfShardsAces.Text;
				num15 = int.Parse(text8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
				object obj48 = (nint)0 & (nint)1;
				int num16;
				if (obj48 != null)
				{
					object obj49 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v85+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v85+E4]");
					bool flag27 = (nint)0 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v85+E4]");
					num16 = 0;
					if (!flag27)
					{
						goto IL_05bc;
					}
				}
				else
				{
					_ = 1;
					object obj49 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v85+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v85+E4]");
					bool flag28 = (nint)0 == 0;
					object obj50 = !flag28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v85+E4]");
					num16 = 0;
					if (obj50 != null)
					{
						goto IL_05bc;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				current2 = RemoteConfig.Current;
				bool flag29 = current2 == null;
				num = num16;
				if (!flag29)
				{
					goto IL_068d;
				}
			}
		}
		goto IL_0f82;
		IL_081d:
		num = (int)current3.<GiftBomb>k__BackingField;
		if (current3.<GiftBomb>k__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+2C]");
			int num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+2C]");
			object obj51 = (nint)num15 - (nint)0;
			bool flag30 = (nint)obj51 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v5 (System.Int32)+2C]");
			int num18 = (int)((nint)num15 ^ (nint)0);
			int num19 = num15 ^ obj51;
			int num20 = num18 & num19;
			bool flag31 = num20 < 0;
			bool flag32 = flag30 == flag31;
			object obj52 = !flag32;
			object obj53 = ~obj52;
			if (obj53 == null)
			{
				num17 = num15;
			}
			object obj54 = num15 - num5;
			bool flag33 = (nint)obj54 < 0;
			int num21 = num15 ^ num5;
			int num22 = num15 ^ obj54;
			int num23 = num21 & num22;
			bool flag34 = num23 < 0;
			bool flag35 = flag33 == flag34;
			object obj55 = !flag35;
			object obj56 = ~obj55;
			if (obj56 != null)
			{
				num5 = num17;
			}
			object obj57 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v22+E4]");
			bool flag36 = (nint)0 == 0;
			object obj59 = !flag36;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input = "com.unity.services.authentication.profile" + 504;
			text3 = LocalizationUtil.Localize((string)input);
			num = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj60 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array = default(object[]);
			if (array != null)
			{
				object obj61 = default(object);
				bool flag37 = obj61 == null;
				int num24 = default(int);
				object obj62 = (object)(&num24);
				IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
				object obj63;
				if (!flag37)
				{
					nint num25 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v71 (Il2CppClass<System.Object[]>)+40]");
					obj62 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag38 = ex2 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v71 (Il2CppClass<System.Object[]>)+40]");
					obj63 = 0;
					if (flag38)
					{
						goto IL_0fd4;
					}
				}
				if (array.Length != 0)
				{
					object obj64 = array + 32;
					obj64 = obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj65 = default(object);
					bool flag39 = obj65 == null;
					int num26 = default(int);
					obj62 = (object)(&num26);
					if (!flag39)
					{
						nint num27 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v70 (Il2CppClass<System.Object[]>)+40]");
						obj62 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag40 = ex2 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v70 (Il2CppClass<System.Object[]>)+40]");
						obj63 = 0;
						if (flag40)
						{
							goto IL_0fd4;
						}
					}
					object obj66 = array.Length & 0xFFFFFFFEL;
					if (obj66 != null)
					{
						int price = num5 * num7;
						object obj67 = array + 40;
						obj67 = obj65;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object input2 = "{0} color encoding is currently unsupported for outputting to HDR." + 72;
						text4 = LocalizationUtil.Localize((string)input2, array);
						object obj68 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj69 = (nint)0 + (nint)3040;
						Action action2 = default(Action);
						action2..ctor(this, (IntPtr)obj69);
						object obj70 = "AvailableVoices" + 3104;
						text6 = (string)obj70;
						num = (int)("COORDINATE_TYPE_GCJ_02" + 1864);
						text5 = (string)((int*)num)->m_value;
						IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreatePurchase(action2, price, (string)obj70, (string)((int*)num)->m_value);
						bool flag41 = popupWindowBuilderNeedsTitle == null;
						obj13 = 0;
						if (flag41)
						{
							goto IL_0f82;
						}
						object obj71 = typeof(System.IOAsyncCallback) + 392;
						object obj72 = "Complete" + 256;
						nint num28 = (nint)popupWindowBuilderNeedsTitle;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v52 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
						object obj73 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v52 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0cbd;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v52 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
						object obj74 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X10_v20-8]");
							if (0 == (nint)obj71)
							{
								break;
							}
							obj18 = obj74 + 16;
							obj73--;
							bool flag42 = (nint)obj73 != 1;
							obj74 = obj18;
							if (flag42)
							{
								continue;
							}
							goto IL_0cbd;
						}
						object obj75 = num28 + obj74;
						obj26 = obj75 + 312;
						obj18 = obj74;
						goto IL_11a5;
					}
				}
				ex2 = new IndexOutOfRangeException();
				obj63 = obj62;
				goto IL_0fd4;
			}
		}
		goto IL_0f82;
		IL_0fd4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0f82:
		ex = new NullReferenceException();
		goto IL_0f90;
	}

	private void CreateBomb()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I
		//IL_01ef: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_028d: Expected O, but got I4
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0316: Expected O, but got I4
		//IL_0347: Expected I8, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7673]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object subBombPopupPreview;
		UnityEngine.Object subBombPopupPreview2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			subBombPopupPreview = _subBombPopupPreview;
			subBombPopupPreview2 = _subBombPopupPreview;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			subBombPopupPreview = _subBombPopupPreview;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			subBombPopupPreview2 = _subBombPopupPreview;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = subBombPopupPreview2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (!flag4)
		{
			goto IL_017e;
		}
		goto IL_019b;
		IL_019b:
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = (nint)0 + (nint)2200;
		int totalCost = GetTotalCost();
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		if (totalCost > aces)
		{
			int totalCost2 = GetTotalCost();
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
			object obj15 = typeof(MemberAchievementClanFeedData) + 2608;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v8+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long remaining = totalCost2 - aces2;
			NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.GiftBomb);
		}
		else
		{
			SubmitTransaction();
		}
		return;
		IL_017e:
		_subBombPopupPreview.Hide();
		obj7 = obj6;
		obj8 = null;
		goto IL_019b;
		IL_0091:
		bool flag8 = subBombPopupPreview != null;
		bool flag9 = !flag8;
		object obj18 = !flag9;
		obj6 = 0;
		if (obj18 != null)
		{
			goto IL_017e;
		}
		obj7 = 0;
		obj8 = null;
		goto IL_019b;
	}

	private void SubmitTransaction()
	{
		//IL_000e: Expected O, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0038: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_039c: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0415: Expected O, but got I
		//IL_0441: Expected I, but got O
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		RemoteConfigModel current;
		int currencyPerPlayer;
		int num2;
		if (GiftBombType != GiftBombType.Currency)
		{
			object obj = 152989696;
			object obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v34+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0082;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v34+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_0082;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_01e6;
			}
		}
		else if ((object)shardAces != null)
		{
			string text = shardAces.Text;
			int num = int.Parse(text);
			GiftBombType giftBombType = GiftBombType;
			bool flag2 = giftBombType == GiftBombType.Currency;
			object obj6 = !flag2;
			currencyPerPlayer = num;
			num2 = num;
			if (obj6 == null)
			{
				goto IL_013a;
			}
			goto IL_02ff;
		}
		goto IL_0460;
		IL_013a:
		InputFieldTMProUGUI inputFieldTMProUGUI = numberOfShardsAces;
		bool flag3 = (object)numberOfShardsAces == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_0330;
		}
		goto IL_0460;
		IL_046e:
		throw new IndexOutOfRangeException();
		IL_01e6:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			KDropMenu kDropMenu = shardSubsOptions;
			if ((object)shardSubsOptions != null)
			{
				int[] <SubShardDays>k__BackingField = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
				if (<GiftBomb>k__BackingField.<SubShardDays>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v6 (KDropMenu)+34]");
					bool flag4 = (nint)0 < (nint)<SubShardDays>k__BackingField.Length;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						int[] <SubShardDays>k__BackingField2 = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v6 (KDropMenu)+34]");
						object obj9 = <SubShardDays>k__BackingField2 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v13+20]");
						currencyPerPlayer = 0;
						GiftBombType giftBombType2 = GiftBombType;
						bool flag5 = giftBombType2 == GiftBombType.Currency;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v13+20]");
						num2 = 0;
						if (flag5)
						{
							goto IL_013a;
						}
						goto IL_02ff;
					}
					goto IL_046e;
				}
			}
		}
		goto IL_0460;
		IL_0460:
		NullReferenceException ex = new NullReferenceException();
		goto IL_046e;
		IL_0330:
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		string text2 = inputFieldTMProUGUI.Text;
		int playersCount = int.Parse(text2);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody, dismissible: false);
		GiftBombType giftBombType3 = GiftBombType;
		if ((object)bombMessage != null)
		{
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj14 = (nint)0 + (nint)3032;
			string text3 = bombMessage.Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj14);
			KammelnaRequests.BuyBomb(giftBombType3, currencyPerPlayer, playersCount, text3, action);
			return;
		}
		goto IL_0460;
		IL_02ff:
		inputFieldTMProUGUI = numberOfShardsSubs;
		bool flag7 = (object)numberOfShardsSubs == null;
		currencyPerPlayer = num2;
		if (!flag7)
		{
			goto IL_0330;
		}
		goto IL_0460;
		IL_0082:
		current = RemoteConfig.Current;
		bool flag8 = current == null;
		object obj15 = !flag8;
		if (obj15 != null)
		{
			goto IL_01e6;
		}
		goto IL_0460;
	}

	private static void ShowError(string errorMsg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0079: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1512;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(errorMsg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	private void <CheckBombToggles>g__HandleToggleChange|74_0(int tabIndex)
	{
		typeTab.Activate(tabIndex);
		Clear();
	}

	private void <ShowConfirmation>b__76_0(SubBombNotifyClientPopupPreview previewPopup)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0369: Expected I, but got O
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0246: Expected O, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0299: Expected O, but got I4
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		RemoteConfigModel current;
		if ((object)previewPopup != null)
		{
			previewPopup.Init(unityAction);
			object obj3 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7752]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v22+E4]");
				if ((nint)0 != 0)
				{
					goto IL_00a6;
				}
			}
			else
			{
				_ = 1;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_00a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_014f;
			}
		}
		goto IL_033c;
		IL_00a6:
		current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_014f;
		}
		goto IL_033c;
		IL_033c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_034a;
		IL_034a:
		throw new IndexOutOfRangeException();
		IL_014f:
		GiftBombConfig <GiftBomb>k__BackingField = current.<GiftBomb>k__BackingField;
		if (current.<GiftBomb>k__BackingField != null)
		{
			KDropMenu kDropMenu = shardSubsOptions;
			if ((object)shardSubsOptions != null)
			{
				int[] <SubShardDays>k__BackingField = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
				if (<GiftBomb>k__BackingField.<SubShardDays>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v3 (KDropMenu)+34]");
					bool flag3 = (nint)0 < (nint)<SubShardDays>k__BackingField.Length;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						goto IL_034a;
					}
					if ((object)bombMessage != null)
					{
						object obj9 = typeof(Queue<string>) + 848;
						object obj10 = (nint)0 + (nint)2200;
						int[] <SubShardDays>k__BackingField2 = <GiftBomb>k__BackingField.<SubShardDays>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v3 (KDropMenu)+34]");
						object obj11 = <SubShardDays>k__BackingField2 + 0;
						string text = bombMessage.Text;
						object obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v12+E4]");
						bool flag4 = (nint)0 == 0;
						object obj13 = !flag4;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel = default(SessionModel);
						if ((object)sessionModel != null)
						{
							User localUser = sessionModel.LocalUser;
							string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+20]");
							previewPopup.Setup(0, text, dbId);
							object obj14 = this + 152;
							obj14 = previewPopup;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return;
						}
					}
				}
			}
		}
		goto IL_033c;
	}

	private void <SubmitTransaction>b__78_0(KammelnaResponseModel<bool> response)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_0104: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0234: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_028f: Expected O, but got I4
		//IL_02c8: Expected F8, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7675]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v38+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		goto IL_00f8;
		IL_00f8:
		object obj5 = (nint)0 + (nint)1048;
		if (response.Succeeded)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object title = "AvailableVoices" + 2392;
			object body = "WhiteSmoke" + 2160;
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
			object obj8 = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
			GiftBombType giftBombType = GiftBombType;
			string text = bombMessage.Text;
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v20+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = StringsExtensions.IsNullOrEmpty(text);
			int totalCost = GetTotalCost();
			bool withMessage = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
			ITrackEvent trackEvent = TrackerLibrary.ChatGiftBombBought(giftBombType, withMessage, totalCost);
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v23+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			string itemId = Tracker.ItemId(ResourceItemId.Bomb);
			int totalCost2 = GetTotalCost();
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Social, itemId, totalCost2, ResourceCurrency.Aces);
		}
		else
		{
			string errorMessage = response.ErrorMessage;
			ShowError(errorMessage);
		}
		popup.SlideToBottom();
		return;
		IL_0074:
		PopupWindow.DismissMessage();
		bool flag6 = response == null;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f8;
	}
}
