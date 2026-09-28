using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server;

public static class JwtRefreshUtil
{
	[Serializable]
	private class ExpClaim
	{
		private long <exp>k__BackingField;

		public long exp
		{
			get
			{
				return <exp>k__BackingField;
			}
			set
			{
				<exp>k__BackingField = value;
			}
		}
	}

	public static void ApplyIfPresent(string refreshedJwt)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(refreshedJwt))
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1280;
			DateTime expiresAt = ReadExpiry(refreshedJwt);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TokenModel tokenModel = default(TokenModel);
			tokenModel..ctor(refreshedJwt, expiresAt);
			Authentication.AccessToken = tokenModel;
		}
	}

	private static DateTime ReadExpiry(string jwt)
	{
		//IL_045e: Expected O, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03f8: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0111: Unsupported input type for neg.
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected I4, but got Unknown
		//IL_0495: Expected O, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_016a: Expected O, but got I4
		//IL_017b: Expected I, but got O
		//IL_04be: Expected O, but got I4
		//IL_04cc: Expected I, but got O
		//IL_026f: Expected I, but got O
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02be: Expected O, but got I4
		//IL_02e7: Expected O, but got I
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_050f: Expected O, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0371: Expected O, but got I4
		//IL_039f: Expected I8, but got I
		string text = default(string);
		NullReferenceException ex;
		if (text != null)
		{
			string[] array = text.Split('.');
			if (array != null)
			{
				if (array.Length <= 1)
				{
					object obj = typeof(DataRelation) + 712;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v10+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime utcNow = DateTime.UtcNow;
					DateTime dateTime = default(DateTime);
					return dateTime.AddHours(4.000000000465661);
				}
				string text2 = array[1];
				bool flag2 = array[1] == null;
				object obj4 = 0;
				StringSplitOptions stringSplitOptions = StringSplitOptions.None;
				nint num = 46;
				if (flag2)
				{
					goto IL_0475;
				}
				object obj5 = -text2._stringLength;
				object obj6 = obj5 & 3;
				int num2 = text2._stringLength & 3;
				if (0 >= text2._stringLength)
				{
					num2 = 0 - obj6;
				}
				if (num2 != 0)
				{
					int count = 4 - num2;
					string text3 = ((string)null).CreateString('=', count);
					text2 += text3;
					bool flag3 = text2 == null;
					obj4 = 0;
					stringSplitOptions = StringSplitOptions.None;
					num = (nint)text3;
					if (flag3)
					{
						goto IL_0475;
					}
				}
				string text4 = text2.Replace('-', '+');
				if (text4 != null)
				{
					string s = text4.Replace('_', '/');
					object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v25+E4]");
					bool flag4 = (nint)0 == 0;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					byte[] bytes = Convert.FromBase64String(s);
					Encoding uTF = Encoding.UTF8;
					if (uTF != null)
					{
						nint num3 = (nint)uTF;
						string text5 = uTF.GetString(bytes);
						object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v33+E4]");
						bool flag5 = (nint)0 == 0;
						object obj12 = !flag5;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj13 = (nint)0 + (nint)48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
						object obj14 = default(object);
						if (obj14 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v36+10]");
							if ((nint)0 >= (nint)1)
							{
								object obj15 = typeof(DataRelation) + 768;
								object obj16 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v44+E4]");
								bool flag6 = (nint)0 == 0;
								object obj17 = !flag6;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v36+10]");
								DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(0L);
								DateTimeOffset dateTimeOffset2 = default(DateTimeOffset);
								return dateTimeOffset2.UtcDateTime;
							}
						}
						object obj18 = typeof(DataRelation) + 712;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v37+E4]");
						bool flag7 = (nint)0 == 0;
						object obj20 = !flag7;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime utcNow2 = DateTime.UtcNow;
						DateTime dateTime2 = default(DateTime);
						return dateTime2.AddHours(4.000000000465661);
					}
					ex = new NullReferenceException();
					obj4 = 0;
					stringSplitOptions = (StringSplitOptions)47;
					num = unchecked((nint)null);
				}
				else
				{
					ex = new NullReferenceException();
					obj4 = 0;
					stringSplitOptions = (StringSplitOptions)43;
					num = 45;
				}
			}
			else
			{
				ex = new NullReferenceException();
				object obj4 = 0;
				StringSplitOptions stringSplitOptions = StringSplitOptions.None;
				nint num = 46;
			}
		}
		else
		{
			ex = new NullReferenceException();
		}
		goto IL_0555;
		IL_0555:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		DateTime result = default(DateTime);
		return result;
		IL_0475:
		ex = new NullReferenceException();
		goto IL_0555;
	}

	private static string PadBase64(string s)
	{
		//IL_0030: Expected O, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_007f: Unsupported input type for neg.
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
		if (s != null)
		{
			object obj = -s._stringLength;
			object obj2 = obj & 3;
			int num = s._stringLength & 3;
			if (0 >= s._stringLength)
			{
				num = 0 - obj2;
			}
			if (num != 0)
			{
				int count = 4 - num;
				string text = ((string)null).CreateString('=', count);
				return s + text;
			}
			return s;
		}
		return (string)(object)new NullReferenceException();
	}
}
