using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Libraries.SafariBrowser;
using Newtonsoft.Json.Linq.JsonPath;
using Social;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class FirebaseHandler : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, string> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <ExtractWords>b__4_0(string s)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009f: Expected O, but got I
			//IL_00c9: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object toCheck = "not" + 344;
			object result = (nint)0 + (nint)2000;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.ContainsIgnoreCase(s, (string)toCheck);
			bool flag3 = !flag2;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				return (string)result;
			}
			return s;
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_018e: Expected I, but got O
		//IL_0114: Expected O, but got I4
		//IL_01b9: Expected I, but got O
		//IL_01df: Expected I, but got O
		//IL_0226: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68C5]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0122;
		IL_0122:
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj8 = (nint)0 + (nint)264;
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)272;
		object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj8);
		UnityEngine.Device.Application.deepLinkActivated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj10);
		SafariHandler.OnBrowserClosed += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj8);
		SafariHandler.OnCallback += action3;
		GameObject gameObject = base.gameObject;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		UnityEngine.Object target = gameObject;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
		return;
		IL_007d:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_0122;
	}

	private void Reset()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "___# Content push apply failed [{0}]: {1}" + 2376;
		base.name = (string)obj;
	}

	public void FacebookLoginCallback(string token)
	{
		//IL_005f: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		string[] array = ExtractWords(token);
		if (array.Length != 0 && array.Length != 1)
		{
			bool flag = array.Length < 2;
			object obj = !flag;
			object obj2 = array.Length - 2;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					SocialUtilities.FacebookLoginCallback(array[0], array[1], array[2]);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				SocialUtilities.FacebookLoginCallback(array[0], array[1], array[2]);
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public void GoogleLoginCallback(string token)
	{
		//IL_005f: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		string[] array = ExtractWords(token);
		if (array.Length != 0 && array.Length != 1)
		{
			bool flag = array.Length < 2;
			object obj = !flag;
			object obj2 = array.Length - 2;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null && array.Length != 3)
			{
				object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					SocialUtilities.GoogleLoginCallback(array[0], array[1], array[2], array[3]);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				SocialUtilities.GoogleLoginCallback(array[0], array[1], array[2], array[3]);
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static string[] ExtractWords(string token)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_013b: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I
		//IL_01b6: Expected I, but got O
		//IL_01d4: Expected O, but got I
		//IL_00d1: Expected O, but got I
		string text = default(string);
		if (text != null)
		{
			object obj = typeof(DebugUI.BitField) + 2768;
			string[] source = text.Split('|');
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+8]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)264;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<object> source2 = Enumerable.Select(source, selector);
			return (string[])Enumerable.ToArray(source2);
		}
		return (string[])(object)new NullReferenceException();
	}

	private void DeepLinkActivated(string link)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68CA]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TwitterRequests.HandleAuthResponse(link);
		return;
		IL_007d:
		TwitterRequests.HandleAuthResponse(link);
	}

	private void OnBrowserClosed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_00a6: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_02f0: Expected O, but got I
		//IL_030a: Expected O, but got I4
		//IL_026d: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_032a: Expected O, but got I
		//IL_0354: Expected O, but got I4
		//IL_02ba: Expected O, but got I
		//IL_02cf: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6976]");
		object obj3 = (nint)0 & (nint)1;
		string text;
		string text2;
		if (obj3 != null)
		{
			text = UnityEngine.Device.Application.absoluteURL;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v20+E4]");
			bool flag = (nint)0 == 0;
			text2 = text;
			if (!flag)
			{
				goto IL_008e;
			}
		}
		else
		{
			_ = 1;
			text = UnityEngine.Device.Application.absoluteURL;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			text2 = text;
			if (obj5 != null)
			{
				goto IL_008e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = text2 == null;
		object obj6 = !flag3;
		text = text2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008e;
		IL_0261:
		object obj7 = (nint)0 + (nint)2336;
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = obj7;
		object obj11 = obj8;
		if (!flag4)
		{
			goto IL_02aa;
		}
		goto IL_0372;
		IL_02aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v19+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v15+20]");
		string arg;
		Actions.SafeInvoke((Action<object>)0, arg);
		return;
		IL_008e:
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v24+B8]");
		object obj14 = 0;
		string text3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v25+8]");
		if (text3.StartsWith((string)0, StringComparison.InvariantCultureIgnoreCase))
		{
			return;
		}
		object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object input = "tournament_participate_warning_body_with_tickets_warning_daily" + 952;
		arg = LocalizationUtil.Localize((string)input);
		obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj18 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E697A]");
			object obj19 = (nint)0 & (nint)1;
			if (obj19 != null)
			{
				goto IL_0261;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E697A]");
			object obj20 = (nint)0 & (nint)1;
			bool flag6 = obj20 == null;
			object obj21 = !flag6;
			if (obj21 != null)
			{
				goto IL_0261;
			}
		}
		_ = 1;
		obj7 = (nint)0 + (nint)2336;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		obj10 = obj7;
		obj11 = obj8;
		if (obj22 != null)
		{
			goto IL_02aa;
		}
		goto IL_0372;
		IL_0372:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj9;
		obj7 = obj10;
		goto IL_02aa;
	}
}
