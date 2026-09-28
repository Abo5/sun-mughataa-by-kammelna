using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Libraries.AppCheck;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Kammelna.Server.WebRequests;

public class RefreshAuthTokenRequest : JsonWebRequest<RefreshTokenRequestModel, AuthModel>
{
	private readonly RefreshTokenRequestModel <PostData>k__BackingField;

	private const string SEGMENT_ID_CLAIM = "SegmentId";

	protected override HttpMethod Method => HttpMethod.POST;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "alignContent" + 1904;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			return backendURL + (string)obj2;
		}
	}

	protected override RefreshTokenRequestModel PostData => <PostData>k__BackingField;

	public RefreshAuthTokenRequest(string token, string deviceId, AppIntegrityRequestModel integrityModel)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		object obj = (nint)0 + (nint)360;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3888;
		((JsonWebRequest<object, object>)(object)this)..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj3 + 16;
		obj4 = token;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3 + 24;
		obj5 = deviceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3 + 32;
		obj6 = integrityModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = this + 48;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnSuccess()
	{
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_0023: Expected O, but got I
		//IL_0045: Expected O, but got I4
		//IL_0336: Expected O, but got I
		//IL_0346: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0360: Expected O, but got I
		//IL_0370: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_019d: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_01b2: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0215: Expected O, but got I4
		//IL_0250: Expected O, but got I
		//IL_02af: Expected O, but got I4
		((BaseWebRequest<object>)(object)this).OnSuccess();
		object key = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3176;
		TokenModel token = Authentication.GetToken((string)key);
		string text;
		if (token != null)
		{
			text = token.<Token>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
			bool flag = (nint)0 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				goto IL_02d6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
			object obj = 0;
			text = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+10]");
		Authentication.SetToken((TokenModel)0, (string)key);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v10+30]");
		object obj5 = 0;
		object key2 = "Read object reference Id '{0}' for {1}." + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+18]");
		Authentication.SetToken((TokenModel)0, (string)key2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v14+30]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v15+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v15+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v16+10]");
			string text2 = (string)0;
			string previousAccessToken = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v16+10]");
			RebaselineSegmentModelsIfChanged(previousAccessToken, (string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				goto IL_02d6;
			}
		}
		else
		{
			RebaselineSegmentModelsIfChanged(text, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
			object obj9 = 0;
			string text2 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v17+30]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v18+10]");
		object obj12 = 0;
		object obj13 = typeof(DataRelation) + 712;
		object obj14 = (nint)0 + (nint)2264;
		object obj15 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v19+18]");
		TimeSpan timeSpan = (DateTime)0 - now;
		DateTime now2 = DateTime.Now;
		DateTime value = now2 - timeSpan;
		DateTime? epoch = value;
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CachedModels.ClearLastUpdates(epoch);
		return;
		IL_02d6:
		throw new NullReferenceException();
	}

	private static void RebaselineSegmentModelsIfChanged(string previousAccessToken, string currentAccessToken)
	{
		//IL_0011: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		string accessToken = default(string);
		HashSet<string> hashSet = SegmentClaims(accessToken);
		HashSet<string> hashSet2 = SegmentClaims(currentAccessToken);
		object obj = (nint)0 + (nint)1144;
		if (!((HashSet<object>)(object)hashSet).SetEquals((IEnumerable<object>)hashSet2))
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object wireKey = "alignContent" + 2008;
			ContentSyncService.Rebaseline((string)wireKey);
			object wireKey2 = "not" + 184;
			ContentSyncService.Rebaseline((string)wireKey2);
		}
	}

	private static HashSet<string> SegmentClaims(string accessToken)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_0166: Expected O, but got I8
		//IL_07d0: Expected O, but got I4
		//IL_0801: Expected O, but got I4
		//IL_0812: Expected I4, but got O
		//IL_01bf: Expected I, but got O
		//IL_0829: Expected O, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_026b: Expected I, but got O
		//IL_0294: Expected O, but got I4
		//IL_0849: Expected O, but got I4
		//IL_0851: Expected I4, but got O
		//IL_02d2: Expected O, but got I
		//IL_02e2: Expected O, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_037e: Expected O, but got I
		//IL_0a1d: Expected O, but got I4
		//IL_039d: Expected I, but got O
		//IL_03ad: Expected O, but got I
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected O, but got Unknown
		//IL_03e8: Expected O, but got I
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_0868: Expected O, but got I4
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0670: Expected I, but got O
		//IL_0680: Expected O, but got I
		//IL_07a2: Expected O, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_04d2: Expected I, but got O
		//IL_04e2: Expected O, but got I
		//IL_06bb: Expected O, but got I
		//IL_051d: Expected O, but got I
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		//IL_07b9: Expected O, but got I4
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_0783: Expected O, but got I4
		//IL_078b: Expected I4, but got O
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_0619: Expected I4, but got O
		//IL_0632: Expected I4, but got O
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1688;
		object obj2 = (nint)0 + (nint)1080;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HashSet<object> hashSet = default(HashSet<object>);
		hashSet..ctor();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		char c;
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(accessToken);
			bool flag2 = !flag;
			c = '\0';
			if (flag2)
			{
				goto IL_00be;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(accessToken);
			bool flag4 = !flag3;
			object obj5 = !flag4;
			c = '\0';
			if (obj5 == null)
			{
				goto IL_00be;
			}
		}
		goto IL_0750;
		IL_0771:
		NullReferenceException ex = new NullReferenceException();
		object obj6 = 0;
		object obj7 = default(object);
		c = (char)(int)obj7;
		goto IL_0875;
		IL_0a54:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X0_v45+8]");
		c = '\0';
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v661 @ X0_v45] (should have been resolved before IL gen)");
		goto IL_0856;
		IL_00be:
		IEnumerator<JToken> enumerator;
		StringSplitOptions stringSplitOptions;
		if (accessToken != null)
		{
			string[] array = accessToken.Split('.');
			bool flag5 = array == null;
			obj6 = 0;
			stringSplitOptions = StringSplitOptions.None;
			c = '.';
			if (!flag5)
			{
				if (array.Length < 2)
				{
					goto IL_0750;
				}
				Encoding uTF = Encoding.UTF8;
				object obj8 = array.Length & 0xFFFFFFFEL;
				if (obj8 != null)
				{
					byte[] array2 = DecodeBase64Url(array[1]);
					if (uTF != null)
					{
						nint num = (nint)uTF;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v9 (Il2CppClass<System.Text.Encoding>)+380]");
						stringSplitOptions = StringSplitOptions.None;
						string json = uTF.GetString(array2);
						JObject jObject = JObject.Parse(json);
						if (jObject != null)
						{
							object propertyName = "SERVICE_DISABLED" + 2512;
							JToken jToken = jObject.get_Item((string)propertyName);
							if (jToken != null)
							{
								object obj9 = typeof(System.IOAsyncCallback) + 4064;
								object obj10 = obj9;
								nint num2 = (nint)jToken;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v14 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+130]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v5+130]");
								bool flag6 = num3 < 0;
								object obj11 = !flag6;
								object obj12 = ~obj11;
								stringSplitOptions = StringSplitOptions.None;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v14 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+C8]");
									nint num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v5+130]");
									object obj13 = num4 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X10_v6-8]");
									object obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X10_v6-8]");
									object obj15 = 0 - obj10;
									bool flag7 = obj15 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X10_v6-8]");
									bool flag8 = 0 != (nint)obj10;
									stringSplitOptions = StringSplitOptions.None;
									if (!flag8)
									{
										enumerator = ((JArray)jToken).GetEnumerator();
										object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
										object obj17 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 808;
										object obj18 = (nint)0 + (nint)1104;
										stringSplitOptions = StringSplitOptions.None;
										c = '\0';
										object obj24 = default(object);
										object obj29 = default(object);
										while (true)
										{
											bool flag9 = enumerator == null;
											obj6 = 0;
											if (flag9)
											{
												break;
											}
											nint num5 = (nint)enumerator;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
											object obj19 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_0465;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
											object obj20 = (nint)0 + (nint)8;
											bool flag10 = flag8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v26-8]");
												obj15 = 0 - obj16;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v26-8]");
												if (0 == (nint)obj16)
												{
													break;
												}
												obj14 = obj20 + 16;
												obj19--;
												obj15 = obj19 - 1;
												flag7 = obj15 == null;
												flag8 = (nint)obj19 != 1;
												obj20 = obj14;
												flag10 = flag8;
												if (flag8)
												{
													continue;
												}
												goto IL_0465;
											}
											object obj21 = num5 + obj20;
											object obj22 = obj21 + 312;
											obj14 = obj20;
											flag8 = flag10;
											goto IL_0949;
											IL_0465:
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
											stringSplitOptions = StringSplitOptions.None;
											goto IL_0949;
											IL_0949:
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v39+8]");
											c = '\0';
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v513 @ X0_v39] (should have been resolved before IL gen)");
											object obj23 = obj24 & 1;
											if (obj23 == null)
											{
												goto IL_0637;
											}
											if (enumerator == null)
											{
												goto IL_0790;
											}
											nint num6 = (nint)enumerator;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v31 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
											object obj25 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v31 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_059a;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v31 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
											object obj26 = (nint)0 + (nint)8;
											bool flag11 = flag8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X10_v21-8]");
												obj15 = 0 - obj17;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X10_v21-8]");
												if (0 == (nint)obj17)
												{
													break;
												}
												obj14 = obj26 + 16;
												obj25--;
												obj15 = obj25 - 1;
												flag7 = obj15 == null;
												flag8 = (nint)obj25 != 1;
												obj26 = obj14;
												flag11 = flag8;
												if (flag8)
												{
													continue;
												}
												goto IL_059a;
											}
											object obj27 = num6 + obj26;
											object obj28 = obj27 + 312;
											obj14 = obj26;
											flag8 = flag11;
											goto IL_09ce;
											IL_09ce:
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v52+8]");
											c = '\0';
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v653 @ X0_v52] (should have been resolved before IL gen)");
											if (obj29 != null)
											{
												object obj30 = obj29;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ X8_v34+168] (should have been resolved before IL gen)");
												if (hashSet != null)
												{
													stringSplitOptions = (StringSplitOptions)obj18;
													bool flag12 = hashSet.Add(obj7);
													c = (char)(int)obj7;
													continue;
												}
												goto IL_0771;
											}
											goto IL_07a7;
											IL_059a:
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
											stringSplitOptions = StringSplitOptions.None;
											goto IL_09ce;
										}
										goto IL_0763;
									}
								}
								object obj31 = jToken.ToString();
								if (hashSet == null)
								{
									ex = new NullReferenceException();
									obj6 = 0;
									c = (char)(int)obj31;
									goto IL_0875;
								}
								bool flag13 = hashSet.Add(obj31);
							}
							goto IL_0750;
						}
						ex = new NullReferenceException();
						obj6 = 0;
						c = '\0';
					}
					else
					{
						ex = new NullReferenceException();
						obj6 = 0;
						stringSplitOptions = StringSplitOptions.None;
						c = (char)(int)array2;
					}
				}
				else
				{
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					obj6 = 0;
					stringSplitOptions = StringSplitOptions.None;
					c = '.';
					ex = (NullReferenceException)(object)ex2;
				}
				goto IL_0875;
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0763;
		IL_0875:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		HashSet<string> result = default(HashSet<string>);
		return result;
		IL_07a7:
		ex = new NullReferenceException();
		obj6 = 0;
		goto IL_0875;
		IL_0856:
		OutOfMemoryException ex4 = new OutOfMemoryException();
		obj6 = 0;
		ex = (NullReferenceException)(object)ex4;
		goto IL_0875;
		IL_0750:
		return (HashSet<string>)(object)hashSet;
		IL_0790:
		ex = new NullReferenceException();
		obj6 = 0;
		goto IL_0875;
		IL_0637:
		if (enumerator != null)
		{
			object obj32 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num7 = (nint)enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v27 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v27 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06fc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v27 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Linq.JToken>>)+B0]");
			object obj34 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X10_v15-8]");
				if (0 == (nint)obj32)
				{
					break;
				}
				obj34 += 16;
				obj33--;
				if ((nint)obj33 != 1)
				{
					continue;
				}
				goto IL_06fc;
			}
			object obj35 = num7 + obj34;
			object obj36 = obj35 + 312;
			goto IL_0a54;
		}
		goto IL_0856;
		IL_0763:
		ex = new NullReferenceException();
		goto IL_0875;
		IL_06fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		stringSplitOptions = StringSplitOptions.None;
		goto IL_0a54;
	}

	private static byte[] DecodeBase64Url(string value)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00e3: Unsupported input type for neg.
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I4, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		string text = default(string);
		string text3;
		object obj;
		if (text != null)
		{
			string text2 = text.Replace('-', '+');
			if (text2 != null)
			{
				text3 = text2.Replace('_', '/');
				if (text3 != null)
				{
					obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj2 = -text3._stringLength;
					object obj3 = obj2 & 3;
					int num = text3._stringLength & 3;
					if (0 >= text3._stringLength)
					{
						num = 0 - obj3;
					}
					object obj4;
					string text4;
					char c;
					if (num != 2)
					{
						bool flag = num != 3;
						c = '/';
						text4 = (string)95;
						if (flag)
						{
							goto IL_0147;
						}
						obj4 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 800;
					}
					else
					{
						obj4 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 816;
					}
					text4 = (string)obj4;
					text3 += (string)obj4;
					c = '\0';
					goto IL_0147;
				}
			}
		}
		return (byte[])(object)new NullReferenceException();
		IL_0147:
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			return Convert.FromBase64String(text3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Convert.FromBase64String(text3);
	}

	protected override void OnError()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_002e: Expected O, but got I
		object format = "Read object reference Id '{0}' for {1}." + 1128;
		((BaseWebRequest<object>)(object)this).OnError();
		RefreshTokenRequestModel postData = PostData;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string reason = string.Format((string)format, arg);
		Authentication.Clear(reason);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.RefreshAuthTokenRequest)+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+14]");
		if ((nint)0 == 2008)
		{
			AppCheckManager.Clear();
		}
	}
}
