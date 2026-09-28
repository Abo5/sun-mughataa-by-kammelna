using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Schema;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class AdInventory : ScriptableObject
{
	private sealed class <>c__DisplayClass2_0
	{
		public AdPlace adPlace;

		public AdType adType;

		public Platform targetPlatform;

		internal bool <GetAd>b__0(Ad ad)
		{
			//IL_0115: Expected I4, but got O
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			if ((object)ad != null)
			{
				if (ad.AdPlace == adPlace && ad.AdType == adType && ad.Platform == targetPlatform)
				{
					object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v4+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Games currentGame = Preferences.CurrentGame;
					object obj4 = ad.Game - currentGame;
					return obj4 == null;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private List<Ad> AllAds;

	public string GetAdId(AdPlace adPlace, AdType adType)
	{
		Ad ad = GetAd(adPlace, adType);
		bool flag = (object)ad == null;
		string result = (string)(object)ad;
		if (!flag)
		{
			result = ad.AdId;
		}
		return result;
	}

	public Ad GetAd(AdPlace adPlace, AdType adType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_014b: Expected I, but got O
		object obj = typeof(XmlSchemaInclude) + 4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 4048;
			object obj7 = (nint)0 + (nint)2480;
			Platform platform = KUtil.GetPlatform();
			if (platform == Platform.Huawei)
			{
				Platform platform2 = Platform.Android;
			}
			else
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Platform platform2 = KUtil.GetPlatform();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj7);
			return (Ad)Enumerable.FirstOrDefault(AllAds, func);
		}
		return (Ad)(object)new NullReferenceException();
	}
}
