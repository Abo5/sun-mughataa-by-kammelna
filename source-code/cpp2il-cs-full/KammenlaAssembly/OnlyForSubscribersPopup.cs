using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class OnlyForSubscribersPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass13_0
	{
		public TrackingFeature trackingFeature;

		public Sprite icon;

		public string text;

		public GameObject bottomTextObj;

		public GameObject bottomObj;

		public string context;

		internal void <Show>b__0(OnlyForSubscribersPopup instance)
		{
			instance.Popup(trackingFeature, icon, text, bottomTextObj, bottomObj, context);
		}
	}

	private static readonly AddressReference<OnlyForSubscribersPopup> Address;

	protected PopupUI popup;

	protected Button blocker;

	private Image featureIcon;

	private TextMeshProUGUI featureText;

	private GameObject featureBottomTextObject;

	private GameObject featureBottomObject;

	private Button weeklySubButton;

	private Button monthlySubButton;

	private Button yearlySubButton;

	private Sprite defaultIcon;

	private TrackingFeature _trackingFeature;

	private string _furtherContext;

	public static void Show(TrackingFeature trackingFeature, Sprite icon = null, string text = null, GameObject bottomTextObj = null, GameObject bottomObj = null, string context = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_0204: Expected O, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0228: Expected O, but got I
		//IL_0243: Expected I, but got O
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0175: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 3448;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2888;
		object obj5 = (nint)0 + (nint)112;
		object obj6 = obj2 + 24;
		obj6 = icon;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 40;
		obj8 = bottomTextObj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2 + 48;
		obj9 = bottomObj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj2 + 56;
		obj10 = context;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v21+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj3;
		}
		object obj13 = (nint)0 + (nint)2192;
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v21+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj16 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v24+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object action2 = "October" + 1072;
		object type = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+10]");
		ITrackEvent trackEvent = TrackerLibrary.OnlySubsPopupViewed(TrackingFeature.FirstUseExperience);
		object obj19 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		FirebaseTrack.Event((string)action2, (string)type);
	}

	private void Popup(TrackingFeature trackingFeature, Sprite icon, string text, GameObject bottomTextObj, GameObject bottomObj, string context)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013d: Expected O, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0203: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_025b: Expected O, but got I4
		//IL_0298: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_0613: Expected O, but got I
		//IL_0623: Expected O, but got I
		//IL_0639: Expected O, but got I
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_0661: Expected O, but got I4
		//IL_0671: Expected O, but got I
		//IL_02f4: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0337: Expected O, but got I
		//IL_06d3: Expected O, but got I
		//IL_06e3: Expected O, but got I
		//IL_06f9: Expected O, but got I
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_06ab: Expected O, but got I4
		//IL_037a: Expected O, but got I
		//IL_038a: Expected O, but got I
		//IL_03a0: Expected O, but got I
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03c8: Expected O, but got I4
		//IL_03d8: Expected O, but got I
		//IL_0405: Expected O, but got I
		//IL_0734: Expected O, but got I
		//IL_043e: Expected O, but got I
		//IL_0753: Expected O, but got I
		//IL_0763: Expected O, but got I
		//IL_0779: Expected O, but got I
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_07a1: Expected O, but got I4
		//IL_07b1: Expected O, but got I
		//IL_0473: Expected O, but got I
		//IL_0489: Expected O, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04b6: Expected O, but got I
		//IL_0813: Expected O, but got I
		//IL_0823: Expected O, but got I
		//IL_0839: Expected O, but got I
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected O, but got Unknown
		//IL_07eb: Expected O, but got I4
		//IL_04f9: Expected O, but got I
		//IL_0509: Expected O, but got I
		//IL_051f: Expected O, but got I
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_0547: Expected O, but got I4
		//IL_0557: Expected O, but got I
		//IL_0584: Expected O, but got I
		//IL_0874: Expected O, but got I
		//IL_05e1: Expected O, but got I4
		//IL_091e: Expected O, but got I4
		//IL_0927: Expected O, but got I4
		//IL_0958: Expected O, but got I4
		//IL_09b1: Expected O, but got I4
		//IL_0aeb: Expected O, but got I4
		//IL_09da: Expected O, but got I
		//IL_0a16: Expected O, but got I4
		//IL_0b3f: Expected O, but got I4
		//IL_0bc1: Expected O, but got I4
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected O, but got Unknown
		//IL_0bea: Expected O, but got I
		//IL_0c26: Expected O, but got I4
		//IL_0b87: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77D0]");
		object obj2 = (nint)0 & (nint)1;
		Image image;
		Image image2;
		if (obj2 != null)
		{
			_trackingFeature = trackingFeature;
			image = featureIcon;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v99+E4]");
			bool flag = (nint)0 == 0;
			image2 = featureIcon;
			if (!flag)
			{
				goto IL_0092;
			}
		}
		else
		{
			_ = 1;
			_trackingFeature = trackingFeature;
			image = featureIcon;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v99+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			image2 = featureIcon;
			if (obj4 != null)
			{
				goto IL_0092;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = icon;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		image = image2;
		if (obj5 != null)
		{
			goto IL_00c4;
		}
		goto IL_01a1;
		IL_04c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v26+E4]");
		if ((nint)0 != 0)
		{
			goto IL_04e9;
		}
		goto IL_07f9;
		IL_0b01:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7;
		object obj6 = obj7;
		goto IL_0b18;
		IL_0ac1:
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v43+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		obj6 = obj7;
		if (obj10 == null)
		{
			goto IL_0b01;
		}
		goto IL_0b18;
		IL_0092:
		bool flag6 = icon;
		bool flag7 = !flag6;
		image2 = image;
		if (!flag7)
		{
			goto IL_00c4;
		}
		goto IL_01a1;
		IL_01a1:
		Sprite sprite = defaultIcon;
		image = image2;
		goto IL_01b8;
		IL_00c4:
		bool flag8 = (object)image == null;
		object obj11 = !flag8;
		sprite = icon;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01b8;
		IL_01b8:
		obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		image.sprite = sprite;
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = StringsExtensions.IsNullOrEmpty(text);
		object obj14 = "SetRoomVariables request error" + 4080;
		bool flag11 = !flag10;
		object obj15 = !flag11;
		object obj16 = ~obj15;
		string text2 = (string)((obj16 != null) ? text : obj14);
		featureText.text = text2;
		TextMeshProExtensions.Localize(featureText);
		object obj17 = (nint)0 + (nint)3120;
		Transform transform = featureBottomTextObject.transform;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v5+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v5+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v9+10]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v9+10]");
			object obj21 = (nint)0 + (nint)309;
			object obj22 = obj21 & 1;
			bool flag12 = obj22 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v9+10]");
			object obj23 = 0;
			if (!flag12)
			{
				goto IL_0345;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v5+38]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v16+10]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v16+10]");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag13 = obj26 == null;
			object obj27 = !flag13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v16+10]");
			object obj23 = 0;
			if (obj27 != null)
			{
				goto IL_0345;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v14+E4]");
		bool flag14 = (nint)0 == 0;
		object obj28 = !flag14;
		if (obj28 != null)
		{
			goto IL_036a;
		}
		goto IL_06b9;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X24_v6+38]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v52+10]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v52+10]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag15 = obj32 == null;
		object obj33 = !flag15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v52+10]");
		object obj34 = 0;
		if (obj33 == null)
		{
			goto IL_0565;
		}
		goto IL_0574;
		IL_0a34:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag16 = bottomObj;
		bool flag17 = !flag16;
		object obj35 = obj7;
		Transform transform2 = null;
		if (!flag17)
		{
			goto IL_0a76;
		}
		goto IL_0ac1;
		IL_0a76:
		Transform transform3 = featureBottomObject.transform;
		int childCount = transform3.childCount;
		bool flag18 = childCount == 0;
		obj7 = obj35;
		transform2 = null;
		if (!flag18)
		{
			goto IL_0ac1;
		}
		Transform transform4 = featureBottomObject.transform;
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v53+E4]");
		bool flag19 = (nint)0 == 0;
		object obj37 = !flag19;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj38 = (nint)0 + (nint)544;
		obj6 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v43+E4]");
		bool flag20 = (nint)0 == 0;
		object obj39 = !flag20;
		if (obj39 == null)
		{
			obj7 = obj38;
			transform2 = transform4;
			goto IL_0b01;
		}
		goto IL_0b18;
		IL_0574:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v34+B8]");
		object except = 0;
		Transform transform5;
		UIExtensions.DestroyAllChildren(transform5, (GameObject[])except);
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v36+E4]");
		Transform transform6;
		if ((nint)0 != 0)
		{
			bool flag21 = bottomTextObj;
			bool flag22 = !flag21;
			object obj41 = !flag22;
			if (obj41 != null)
			{
				goto IL_08b3;
			}
			transform6 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag23 = bottomTextObj;
			bool flag24 = !flag23;
			transform6 = null;
			if (!flag24)
			{
				goto IL_08b3;
			}
		}
		goto IL_08f6;
		IL_0565:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0574;
		IL_0b18:
		bool flag25 = StringsExtensions.IsNullOrEmpty(context);
		bool flag26 = !flag25;
		object obj42 = !flag26;
		object obj43 = ~obj42;
		string text3 = ((obj43 != null) ? context : null);
		object obj44 = this + 120;
		obj44 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X19_v3-58]");
		((PopupUI)0).PopFromCenter(1f);
		return;
		IL_08b3:
		Transform transform7 = featureBottomTextObject.transform;
		int childCount2 = transform7.childCount;
		bool flag27 = childCount2 == 0;
		transform6 = null;
		if (!flag27)
		{
			goto IL_08f6;
		}
		Transform transform8 = featureBottomTextObject.transform;
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v74+E4]");
		bool flag28 = (nint)0 == 0;
		object obj46 = !flag28;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj47 = (nint)0 + (nint)544;
		obj35 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v59+E4]");
		bool flag29 = (nint)0 == 0;
		object obj49 = !flag29;
		obj7 = obj47;
		transform6 = transform8;
		if (obj49 != null)
		{
			goto IL_0935;
		}
		goto IL_0a34;
		IL_0935:
		bool flag30 = bottomObj;
		bool flag31 = !flag30;
		object obj50 = !flag31;
		if (obj50 != null)
		{
			goto IL_0a76;
		}
		obj7 = obj35;
		transform2 = null;
		goto IL_0ac1;
		IL_0345:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			goto IL_036a;
		}
		goto IL_06b9;
		IL_06b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v5+38]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+10]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+10]");
		object obj53 = (nint)0 + (nint)309;
		object obj54 = obj53 & 1;
		if (obj54 == null)
		{
			goto IL_03e6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+10]");
		object obj55 = 0;
		goto IL_03f5;
		IL_07f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X24_v6+38]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v23+10]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v23+10]");
		object obj57 = (nint)0 + (nint)309;
		object obj58 = obj57 & 1;
		if (obj58 == null)
		{
			goto IL_0565;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v23+10]");
		obj34 = 0;
		goto IL_0574;
		IL_036a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v5+38]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v61+10]");
		obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v61+10]");
		object obj60 = (nint)0 + (nint)309;
		object obj61 = obj60 & 1;
		bool flag32 = obj61 == null;
		object obj62 = !flag32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v61+10]");
		obj55 = 0;
		if (obj62 == null)
		{
			goto IL_03e6;
		}
		goto IL_03f5;
		IL_03e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_03f5;
		IL_03f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v22+B8]");
		object except2 = 0;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])except2);
		transform5 = featureBottomObject.transform;
		object obj63 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X24_v6+38]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X24_v6+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v21+10]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v21+10]");
			object obj66 = (nint)0 + (nint)309;
			object obj67 = obj66 & 1;
			bool flag33 = obj67 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v21+10]");
			object obj68 = 0;
			if (!flag33)
			{
				goto IL_04c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X24_v6+38]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+10]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+10]");
			object obj70 = (nint)0 + (nint)309;
			object obj71 = obj70 & 1;
			bool flag34 = obj71 == null;
			object obj72 = !flag34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+10]");
			object obj68 = 0;
			if (obj72 != null)
			{
				goto IL_04c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v26+E4]");
		bool flag35 = (nint)0 == 0;
		object obj73 = !flag35;
		if (obj73 != null)
		{
			goto IL_04e9;
		}
		goto IL_07f9;
		IL_08f6:
		obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v59+E4]");
		bool flag36 = (nint)0 == 0;
		obj35 = 0;
		obj7 = 0;
		if (!flag36)
		{
			goto IL_0935;
		}
		goto IL_0a34;
	}

	public void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_02c1: Expected I, but got O
		//IL_015a: Expected O, but got I4
		//IL_030c: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_031e: Expected O, but got I4
		//IL_0327: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_03c4: Expected O, but got I
		//IL_03d2: Expected I, but got O
		//IL_0493: Expected O, but got I4
		//IL_04a4: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		//IL_041d: Expected O, but got I4
		//IL_0426: Expected O, but got I4
		//IL_042f: Expected O, but got I4
		//IL_0438: Expected O, but got I4
		//IL_0449: Expected O, but got I4
		//IL_0227: Expected O, but got I
		//IL_0235: Expected I, but got O
		Button button = blocker;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		button.m_OnClick.AddListener(unityAction);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v7+E4]");
		UnityAction unityAction2;
		if ((nint)0 != 0)
		{
			bool flag = weeklySubButton;
			bool flag2 = !flag;
			object obj5 = !flag2;
			unityAction2 = null;
			UnityAction unityAction3 = null;
			if (obj5 == null)
			{
				goto IL_00d2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = weeklySubButton;
			bool flag4 = !flag3;
			unityAction2 = null;
			UnityAction unityAction3 = null;
			if (flag4)
			{
				goto IL_00d2;
			}
		}
		Button button2 = weeklySubButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)2176;
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj6);
		button2.m_OnClick.AddListener(unityAction4);
		UnityEngine.Object obj7 = monthlySubButton;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		object obj10 = 0;
		object obj11 = 0;
		object obj12 = 0;
		unityAction2 = unityAction4;
		object obj13 = 0;
		UnityEngine.Object obj14 = monthlySubButton;
		if (obj9 != null)
		{
			goto IL_0137;
		}
		goto IL_0350;
		IL_0202:
		Button button3 = yearlySubButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2184;
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj15);
		button3.m_OnClick.AddListener(unityAction5);
		return;
		IL_01d3:
		UnityEngine.Object obj16;
		bool flag6 = obj16;
		bool flag7 = !flag6;
		object obj17 = 0;
		if (!flag7)
		{
			goto IL_0202;
		}
		return;
		IL_0461:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj18;
		bool flag8 = obj18;
		bool flag9 = !flag8;
		object obj19 = !flag9;
		object obj20;
		obj10 = obj20;
		obj17 = 0;
		object obj21;
		obj11 = obj21;
		if (obj19 == null)
		{
			return;
		}
		goto IL_0202;
		IL_00d2:
		obj7 = monthlySubButton;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v13+E4]");
		bool flag10 = (nint)0 == 0;
		obj10 = 0;
		obj11 = 0;
		obj12 = 0;
		obj13 = 0;
		obj14 = monthlySubButton;
		if (!flag10)
		{
			goto IL_0137;
		}
		goto IL_0350;
		IL_0350:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj14;
		bool flag12 = !flag11;
		obj10 = obj12;
		UnityAction unityAction6 = null;
		obj11 = obj13;
		UnityAction unityAction7 = null;
		if (flag12)
		{
			goto IL_0182;
		}
		goto IL_039f;
		IL_0137:
		bool flag13 = obj7;
		bool flag14 = !flag13;
		object obj22 = !flag14;
		unityAction6 = null;
		obj12 = obj10;
		unityAction7 = null;
		obj13 = obj11;
		if (obj22 == null)
		{
			goto IL_0182;
		}
		goto IL_039f;
		IL_039f:
		Button button4 = monthlySubButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)2168;
		UnityAction unityAction8 = default(UnityAction);
		unityAction8..ctor(this, (IntPtr)obj23);
		button4.m_OnClick.AddListener(unityAction8);
		obj16 = yearlySubButton;
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v7+E4]");
		bool flag15 = (nint)0 == 0;
		object obj25 = !flag15;
		obj10 = 0;
		obj11 = 0;
		obj20 = 0;
		unityAction6 = unityAction8;
		obj21 = 0;
		obj18 = yearlySubButton;
		if (obj25 != null)
		{
			goto IL_01d3;
		}
		goto IL_0461;
		IL_0182:
		obj16 = yearlySubButton;
		obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v7+E4]");
		bool flag16 = (nint)0 == 0;
		obj20 = obj10;
		obj21 = obj11;
		obj18 = yearlySubButton;
		if (!flag16)
		{
			goto IL_01d3;
		}
		goto IL_0461;
	}

	private void OnSubscribeWeekly()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.OnlySubsPopupSubscribeClicked(_trackingFeature, TrackingOutcome.SubscribeWeeklyClicked, _furtherContext);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnSubscribeMonthly()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.OnlySubsPopupSubscribeClicked(_trackingFeature, TrackingOutcome.SubscribeMonthlyClicked, _furtherContext);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnSubscribeYearly()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.OnlySubsPopupSubscribeClicked(_trackingFeature, TrackingOutcome.SubscribeYearlyClicked, _furtherContext);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnBack()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77D5]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.OnlySubsPopupBackClicked(_trackingFeature);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.OnlySubsPopupBackClicked(_trackingFeature);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			trackEvent2 = trackEvent;
			if (obj5 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_0094:
		Tracker.DesignEvent(trackEvent);
	}

	static OnlyForSubscribersPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "October" + 800;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3104;
		object obj3 = typeof(MemberAchievementClanFeedData) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
