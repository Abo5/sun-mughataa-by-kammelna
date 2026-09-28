using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ChatMessageBubble : ChatMessageStrip
{
	private sealed class <>c__DisplayClass34_0
	{
		public bool hasDecoration;

		internal void <UpdateInk>b__0(GameObject go)
		{
			go.SetActive(hasDecoration);
		}
	}

	private float minTextWidth;

	private float maxTextWidth;

	private RectTransform content;

	private RectTransform avatarContainer;

	private AvatarInitializer _avatarInitializer;

	private TextMeshProUGUI usernameLabel;

	private TextMeshProUGUI messageTextMesh;

	private Button bubbleAction;

	private GameObject[] monthlyTrophyObjects;

	private GameObject bombRankGameObject;

	private GameObject bombFrameGameObject;

	private Image bombRankImage;

	private Image bombFrameImage;

	private BomberSprites bomber1;

	private BomberSprites bomber2;

	private BomberSprites bomber3;

	private HorizontalLayoutGroup layoutGroup;

	private Color adminNameColor;

	private Color adminMessageColor;

	private static readonly Color MonthlyTournamentWinnerMessageColor;

	private static readonly Vector3 TrophyAvatarScale;

	private Color normalNameColor;

	private Color normalMessageColor;

	private Color TeamOneColor;

	private Color TeamTwoColor;

	private Vector2 baseSize;

	private Vector2 baseTextSize;

	private HorizontalAlignmentOptions baseTextAlignment;

	private BaseChatbox manager;

	public override void Setup(ChatMessageDataHolder datum, bool firstTime)
	{
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		if (firstTime)
		{
			FirstTimeSetup();
		}
		Populate(datum);
	}

	private void FirstTimeSetup()
	{
		//IL_0016: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_011a: Expected F4, but got I4
		//IL_0149: Expected O, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0185: Expected O, but got F4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_030c: Expected I, but got O
		//IL_031c: Expected O, but got I
		//IL_0335: Expected O, but got F4
		//IL_0379: Expected O, but got I4
		//IL_03c1: Expected O, but got I4
		//IL_03ca: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_048a: Expected O, but got I4
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0411: Expected O, but got I
		//IL_041f: Expected I, but got O
		//IL_02b0: Expected O, but got I4
		//IL_04e1: Invalid comparison between F4 and I4
		//IL_04f0: Invalid comparison between F4 and I4
		//IL_0505: Expected O, but got F4
		//IL_0514: Expected O, but got F4
		//IL_0549: Expected O, but got I4
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_043f: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		string matchingTemplate = ((ChatMessageDataHolder)0).GetMatchingTemplate();
		gameObject.name = matchingTemplate;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = content.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		Rect rect2 = rectTransform.rect;
		Vector2 vector = default(Vector2);
		baseSize = vector;
		RectTransform rectTransform2 = messageTextMesh.rectTransform;
		Rect rect3 = rectTransform2.rect;
		object text = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1312;
		Vector2 preferredValues = messageTextMesh.GetPreferredValues((string)text, maxTextWidth, 79f);
		baseTextSize = vector;
		_ = 79;
		TextMeshProUGUI textMeshProUGUI = messageTextMesh;
		object obj4 = (nint)0 + (nint)392;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		baseTextAlignment = ((TMP_Text)textMeshProUGUI).m_HorizontalAlignment;
		Color color = textMeshProUGUI.color;
		normalMessageColor = (Color)maxTextWidth;
		_ = 79;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		BaseChatbox baseChatbox = default(BaseChatbox);
		manager = baseChatbox;
		object obj6 = this + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v9+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			bool flag2 = usernameLabel;
			bool flag3 = !flag2;
			object obj8 = !flag3;
			obj9 = 0;
			if (obj8 == null)
			{
				goto IL_022c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = usernameLabel;
			bool flag5 = !flag4;
			obj9 = 0;
			if (flag5)
			{
				goto IL_022c;
			}
		}
		TextMeshProUGUI textMeshProUGUI2 = usernameLabel;
		nint num = (nint)textMeshProUGUI2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v19 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A0]");
		obj9 = 0;
		Color color2 = textMeshProUGUI2.color;
		normalNameColor = (Color)maxTextWidth;
		_ = 79;
		UnityEngine.Object obj10 = bubbleAction;
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v39+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		UnityEngine.Object obj13 = bubbleAction;
		if (obj12 != null)
		{
			goto IL_026d;
		}
		goto IL_0391;
		IL_0391:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = obj13;
		bool flag8 = !flag7;
		object obj14 = 0;
		object obj15 = 0;
		if (!flag8)
		{
			goto IL_03d8;
		}
		goto IL_0444;
		IL_022c:
		obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v39+E4]");
		bool flag9 = (nint)0 == 0;
		obj10 = bubbleAction;
		obj13 = bubbleAction;
		if (!flag9)
		{
			goto IL_026d;
		}
		goto IL_0391;
		IL_0444:
		RectTransform rectTransform3 = UIExtensions.rectTransform(this);
		Rect rect4 = rectTransform3.rect;
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v32+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = baseSize - baseTextSize;
		float num2 = (float)vector - (float)obj18;
		float num3 = maxTextWidth - num2;
		bool flag11 = num3 < 0f;
		bool flag12 = num3 == 0f;
		object obj19 = maxTextWidth ^ num2;
		object obj20 = maxTextWidth ^ num3;
		object obj21 = obj19 & obj20;
		bool flag13 = (nint)obj21 < 0;
		bool flag14 = flag11 == flag13;
		object obj22 = !flag12;
		object obj23 = flag14 & obj22;
		object obj24 = ~obj23;
		if (obj24 != null)
		{
			num2 = maxTextWidth;
		}
		if (maxTextWidth < minTextWidth)
		{
			num2 = minTextWidth;
		}
		maxTextWidth = num2;
		return;
		IL_03d8:
		Button button = bubbleAction;
		object obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)288;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj26);
		button.m_OnClick.AddListener(unityAction);
		obj15 = 0;
		goto IL_0444;
		IL_026d:
		bool flag15 = obj10;
		bool flag16 = !flag15;
		object obj27 = !flag16;
		obj14 = 0;
		if (obj27 != null)
		{
			goto IL_03d8;
		}
		obj15 = 0;
		goto IL_0444;
	}

	private void Populate(ChatMessageDataHolder datum)
	{
		//IL_006c: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_009d: Expected O, but got I
		if (datum.<message>k__BackingField == null)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+18]");
			object obj2 = 0;
			TextMeshProUGUI input = messageTextMesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+20]");
			string value = TextMeshProExtensions.SanitizeHasCharacter(input, (string)0);
			if (string.IsNullOrEmpty(value))
			{
				datum.<listView>k__BackingField.RemoveLastMessage();
				return;
			}
			bubbleAction.interactable = true;
			Resize();
			UpdateText();
			UpdateInteractable();
			UpdateInk();
			AssignAvatar();
		}
	}

	private void Resize()
	{
		//IL_007b: Expected O, but got I
		//IL_0015: Expected O, but got I
		//IL_002c: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3+18]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+20]");
		Vector2 sizeForText = GetSizeForText((string)0);
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		float size = default(float);
		rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size);
		float size2 = default(float);
		content.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, size2);
	}

	private void UpdateText()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_015e: Expected O, but got I
		//IL_0173: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_01e7: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75FF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj5 = usernameLabel;
			obj6 = usernameLabel;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = usernameLabel;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = usernameLabel;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_01a6;
		IL_01a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4+18]");
		object obj9 = 0;
		TextMeshProUGUI input = messageTextMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v5+20]");
		string text = TextMeshProExtensions.SanitizeHasCharacter(input, (string)0);
		TextMeshProExtensions.FixArabic(messageTextMesh, text);
		string text2 = messageTextMesh.text;
		HorizontalAlignmentOptions horizontalAlignment = ((text2._stringLength >= 15) ? baseTextAlignment : HorizontalAlignmentOptions.Center);
		messageTextMesh.horizontalAlignment = horizontalAlignment;
		return;
		IL_014e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9+18]");
		object obj11 = 0;
		TextMeshProUGUI textMesh = usernameLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v10+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v10+28]");
		TextMeshProExtensions.SetUsername(textMesh, (string)num, isSubscribed: false, isVerified: false);
		goto IL_01a6;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_014e;
		}
		goto IL_01a6;
	}

	private void UpdateInk()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_057d: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0053: Expected O, but got I
		//IL_00a9: Expected O, but got I4
		//IL_0592: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_019d: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_05a2: Expected O, but got I4
		//IL_01ca: Expected O, but got I
		//IL_0246: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_0276: Expected O, but got I
		//IL_0286: Expected O, but got I
		//IL_0296: Expected O, but got I
		//IL_029e: Expected I, but got O
		//IL_02a9: Expected O, but got I
		//IL_0206: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_0218: Expected O, but got I4
		//IL_0221: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		//IL_035b: Expected O, but got I4
		//IL_02fb: Expected O, but got I4
		//IL_0304: Expected O, but got I4
		//IL_0482: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_0497: Expected O, but got I
		//IL_038e: Expected O, but got I
		//IL_031b: Expected O, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_04bc: Expected O, but got I
		//IL_04d3: Expected O, but got I
		//IL_0502: Expected I, but got O
		//IL_0526: Expected O, but got I
		//IL_053b: Expected O, but got I
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0609: Expected O, but got I4
		//IL_0612: Expected O, but got I4
		//IL_061b: Expected O, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I4
		//IL_0424: Expected O, but got I
		//IL_0434: Expected O, but got I
		//IL_0444: Expected O, but got I
		//IL_0454: Expected O, but got I
		//IL_0464: Expected O, but got I4
		//IL_046d: Expected O, but got I4
		//IL_05e1: Expected O, but got I4
		//IL_05ea: Expected O, but got I4
		//IL_05f3: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+18]");
		object obj4 = 0;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+10]");
		bool isPLayer = PlayerUtilities.IsPlayer((string)0);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = usernameLabel;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00f3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)usernameLabel)
			{
				goto IL_00f3;
			}
		}
		goto IL_0582;
		IL_0369:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v21+18]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v22+48]");
		if ((nint)0 == 3)
		{
			object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 880;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v20+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj10;
			}
			object obj13 = 16;
			object obj14 = 20;
			object obj15 = 24;
		}
		else
		{
			object obj16 = typeof(UsageHint) + 816;
			object obj11 = obj16;
			object obj13 = 12;
			object obj14 = 16;
			object obj15 = 20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v20+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X11_v4+v93 @ X10_v4]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X11_v4+v158 @ X9_v9]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X11_v4+v226 @ X8_v25]");
		object obj20 = 0;
		avatarContainer.localScale = (Vector3)0;
		Vector3 vector = (Vector3)0;
		goto IL_0472;
		IL_0472:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v15+18]");
		object obj22 = 0;
		object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj24 = (nint)0 + (nint)3176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v16+48]");
		object obj25 = -3;
		bool flag4 = obj25 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj24);
		ArraysExtensions.ForEach(monthlyTrophyObjects, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v19+18]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v20+48]");
		HandleTopWeeklyBomberImage(ChatInk.Clean);
		return;
		IL_00f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v35+18]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v36+48]");
		Color nameColor = GetNameColor(ChatInk.Clean, isPLayer);
		usernameLabel.color = (Color)0;
		goto IL_0582;
		IL_0582:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v8+18]");
		object obj31 = 0;
		TextMeshProUGUI textMeshProUGUI = messageTextMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v9+48]");
		object obj32 = -1;
		bool flag5 = obj32 == null;
		object obj33 = !flag5;
		object obj34 = ~obj33;
		bool flag6;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v9+48]");
			object obj35 = -4;
			flag6 = obj35 == null;
		}
		else
		{
			flag6 = true;
		}
		object obj36 = !flag6;
		if (obj36 == null)
		{
			bool flag7 = (object)textMeshProUGUI == null;
			object obj37 = !flag7;
			object obj38 = 272;
			object obj39 = 276;
			object obj40 = 280;
			object obj41 = 284;
			if (obj37 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			object obj38 = 304;
			object obj39 = 308;
			object obj40 = 312;
			object obj41 = 316;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+v85 @ X11_v2]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+v91 @ X10_v2]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+v325 @ X9_v3]");
		obj20 = 0;
		nint num = (nint)textMeshProUGUI;
		textMeshProUGUI.color = (Color)0;
		object obj42 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag8 = avatarContainer;
			bool flag9 = !flag8;
			object obj43 = !flag9;
			Vector3 vector2 = (Vector3)0;
			if (obj43 != null)
			{
				goto IL_0369;
			}
			vector = (Vector3)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = avatarContainer;
			bool flag11 = !flag10;
			Vector3 vector2 = (Vector3)0;
			vector = (Vector3)0;
			if (!flag11)
			{
				goto IL_0369;
			}
		}
		goto IL_0472;
	}

	private Color GetNameColor(ChatInk ink, bool isPLayer)
	{
		//IL_0015: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_004a: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		Color result;
		if (isPLayer)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v1 (ChatMessageBubble)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v1 (ChatMessageBubble)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v9+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v9+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v11+10]");
					int playerTeamID = PlayerUtilities.GetPlayerTeamID((string)0);
					result = ((playerTeamID != 1) ? ((Color)playerTeamID) : ((Color)playerTeamID));
					goto IL_0185;
				}
			}
			return (Color)new NullReferenceException();
		}
		if (ink == ChatInk.MonthlyWinner)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 880;
			result = (Color)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v2 (UnityEngine.Color)+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result = (Color)obj3;
			}
		}
		else
		{
			result = (Color)this;
		}
		goto IL_0185;
		IL_0185:
		return result;
	}

	private Color GetMessageColor(ChatInk ink)
	{
		if (ink == ChatInk.Bomber)
		{
		}
		if (ink == ChatInk.Bomber)
		{
		}
		if (ink == ChatInk.Bomber)
		{
		}
		if (ink == ChatInk.Bomber)
		{
		}
		if (ink == ChatInk.Admin)
		{
		}
		if (ink == ChatInk.Admin)
		{
		}
		if (ink == ChatInk.Admin)
		{
		}
		if (ink == ChatInk.Admin)
		{
		}
		return (Color)this;
	}

	private Vector3 GetAvatarScale(ChatInk ink)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		Vector3 result;
		if (ink == ChatInk.MonthlyWinner)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 880;
			result = (Vector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v2 (UnityEngine.Vector3)+E4]");
			bool flag = (nint)0 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result = (Vector3)obj;
			}
		}
		else
		{
			object obj3 = typeof(UsageHint) + 816;
			result = (Vector3)obj3;
		}
		return result;
	}

	private bool HasDecorations(ChatInk ink)
	{
		//IL_000e: Expected O, but got I4
		object obj = ink - 3;
		return obj == null;
	}

	private void HandleTopWeeklyBomberImage(ChatInk ink)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_019e: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_01e1: Expected O, but got I
		//IL_026f: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_0358: Expected O, but got I4
		//IL_02bd: Expected O, but got I
		//IL_02d8: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7601]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj5 = bombFrameGameObject;
			obj6 = bombFrameGameObject;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = bombFrameGameObject;
			obj6 = bombFrameGameObject;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		return;
		IL_02a2:
		ChatMessageBubble chatMessageBubble2;
		ChatMessageBubble chatMessageBubble = chatMessageBubble2;
		Image image = bombFrameImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X21_v5+18]");
		chatMessageBubble.AssignSprite(image, (Sprite)0);
		ChatMessageBubble chatMessageBubble3 = chatMessageBubble2;
		Image image2 = bombRankImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X21_v5+10]");
		chatMessageBubble3.AssignSprite(image2, (Sprite)0);
		return;
		IL_027d:
		object obj8;
		bool flag3 = obj8 == null;
		bool flag4;
		chatMessageBubble2 = (ChatMessageBubble)flag4;
		if (!flag3)
		{
			goto IL_02a2;
		}
		return;
		IL_014e:
		object obj9 = ink - 5;
		bool flag5 = (nint)obj9 < 2;
		object obj10 = !flag5;
		object obj11 = obj9 - 2;
		bool flag6 = obj11 == null;
		object obj12 = !flag6;
		object obj13 = obj10 & obj12;
		if (obj13 == null)
		{
			object obj14 = obj9 << 3;
			object obj15 = (object)this + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v9+E0]");
			obj8 = 0;
		}
		else
		{
			obj8 = 0;
		}
		bool flag7 = obj8 == null;
		bool active = !flag7;
		bombFrameGameObject.SetActive(active);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			flag4 = bombRankGameObject;
			bool flag8 = !flag4;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				goto IL_027d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag4 = bombRankGameObject;
			if (!flag4)
			{
				goto IL_027d;
			}
		}
		bool flag9 = obj8 == null;
		bool active2 = !flag9;
		bombRankGameObject.SetActive(active2);
		bool flag10 = obj8 == null;
		object obj18 = !flag10;
		chatMessageBubble2 = (ChatMessageBubble)(object)bombRankGameObject;
		if (obj18 == null)
		{
			return;
		}
		goto IL_02a2;
		IL_0091:
		bool flag11 = obj5;
		bool flag12 = !flag11;
		object obj19 = !flag12;
		if (obj19 == null)
		{
			return;
		}
		goto IL_014e;
	}

	private void AssignSprite(Image image, Sprite sprite)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e9: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		//IL_01d0: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7602]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = image != null;
		bool flag3 = !flag2;
		object obj5 = 0;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			goto IL_013b;
		}
		return;
		IL_013b:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!(sprite != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = sprite != null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				return;
			}
		}
		image.sprite = sprite;
		return;
		IL_0074:
		bool flag6 = image != null;
		bool flag7 = !flag6;
		object obj9 = !flag7;
		obj5 = 0;
		obj6 = null;
		if (obj9 == null)
		{
			return;
		}
		goto IL_013b;
	}

	private void AssignAvatar()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_00c7: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_00dd: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_0120: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7603]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object avatarInitializer;
		UnityEngine.Object avatarInitializer2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			avatarInitializer = _avatarInitializer;
			avatarInitializer2 = _avatarInitializer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			avatarInitializer = _avatarInitializer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			avatarInitializer2 = _avatarInitializer;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = avatarInitializer2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v7+18]");
		if (((ChatMessageData)0).HasUser)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+18]");
			AvatarData avatarData = (ChatMessageData)0;
			_avatarInitializer.Initialize(avatarData);
		}
		else
		{
			_avatarInitializer.InitializeAdmin();
		}
		return;
		IL_0091:
		if ((bool)avatarInitializer)
		{
			goto IL_00b7;
		}
	}

	private void AssignBubbleAction()
	{
		bubbleAction.interactable = true;
	}

	private void UpdateInteractable()
	{
		//IL_0089: Expected O, but got I
		//IL_0016: Expected O, but got I
		//IL_0044: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+18]");
		bool interactable;
		if (((ChatMessageData)0).HasUser)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+18]");
			bool isMyMessage = ((ChatMessageData)0).IsMyMessage;
			interactable = (byte)((isMyMessage ? 1u : 0u) ^ 1u) != 0;
		}
		else
		{
			interactable = false;
		}
		bubbleAction.interactable = interactable;
	}

	private void OnBubbleClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_0257: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7605]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			obj5 = manager;
			obj6 = manager;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = manager;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = manager;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		ChatMessageDataHolder messageData = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0160;
		IL_0160:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v3+2A]");
		if ((nint)0 == 1)
		{
			_ = 0;
			BaseChatbox baseChatbox = manager;
			baseChatbox.messageOptions.Hide();
			return;
		}
		_ = 1;
		Transform transform = messageTextMesh.transform;
		Vector3 position = transform.position;
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		Vector2 offsetMax = rectTransform.offsetMax;
		BaseChatbox baseChatbox2 = manager;
		ChatMessageOptions messageOptions = baseChatbox2.messageOptions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+40]");
		messageOptions.Show((Vector2)0, messageData);
		return;
		IL_0091:
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		messageData = null;
		if (!flag6)
		{
			return;
		}
		goto IL_0160;
	}

	private Vector2 GetSizeForText(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_00ca: Expected F4, but got I4
		//IL_00ea: Invalid comparison between F4 and I4
		//IL_00f9: Invalid comparison between F4 and I4
		//IL_0110: Expected O, but got F4
		//IL_011f: Expected O, but got F4
		//IL_0154: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0202: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7606]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text2 = LocalizationUtil.FixArabic(text);
		TMP_Text tMP_Text = messageTextMesh;
		bool flag2 = (object)messageTextMesh == null;
		object obj5 = !flag2;
		string text3 = text2;
		if (obj5 != null)
		{
			goto IL_00b2;
		}
		goto IL_0218;
		IL_00b2:
		Vector2 preferredValues = tMP_Text.GetPreferredValues(text3, maxTextWidth, 79f);
		float num = maxTextWidth - maxTextWidth;
		bool flag3 = num < 0f;
		bool flag4 = num == 0f;
		object obj6 = maxTextWidth ^ maxTextWidth;
		object obj7 = maxTextWidth ^ num;
		object obj8 = obj6 & obj7;
		bool flag5 = (nint)obj8 < 0;
		bool flag6 = flag3 == flag5;
		object obj9 = !flag4;
		object obj10 = flag6 & obj9;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
		}
		if (maxTextWidth < minTextWidth)
		{
		}
		return preferredValues;
		IL_0218:
		return (Vector2)new NullReferenceException();
		IL_0074:
		string text4 = LocalizationUtil.FixArabic(text);
		tMP_Text = messageTextMesh;
		bool flag7 = (object)messageTextMesh == null;
		text3 = text4;
		if (!flag7)
		{
			goto IL_00b2;
		}
		goto IL_0218;
	}

	public override float GetHeightForText(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0116: Expected O, but got I4
		//IL_00b0: Expected F4, but got I4
		//IL_00d1: Expected O, but got I
		//IL_0166: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7607]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text2 = LocalizationUtil.FixArabic(text);
		TMP_Text tMP_Text = messageTextMesh;
		bool flag2 = (object)messageTextMesh == null;
		object obj5 = !flag2;
		string text3 = text2;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0098;
		IL_0074:
		string text4 = LocalizationUtil.FixArabic(text);
		tMP_Text = messageTextMesh;
		text3 = text4;
		goto IL_0098;
		IL_0098:
		Vector2 preferredValues = tMP_Text.GetPreferredValues(text3, maxTextWidth, 79f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+164]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageBubble)+16C]");
		object obj6 = num - 0;
		return (float)obj6 + 79f;
	}

	public ChatMessageBubble()
	{
		//IL_0012: Expected F4, but got I
		//IL_0024: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_005a: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252EF8]");
		minTextWidth = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E1320]");
		adminNameColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F00]");
		adminMessageColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F10]");
		TeamOneColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F20]");
		TeamTwoColor = (Color)0;
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	static ChatMessageBubble()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 880;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F30]");
		obj3 = 0;
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v4+14]");
		object obj7 = (nint)0 * (nint)1060320051;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v4+C]");
		object obj9 = default(object);
		object obj8 = 0 * obj9;
	}
}
