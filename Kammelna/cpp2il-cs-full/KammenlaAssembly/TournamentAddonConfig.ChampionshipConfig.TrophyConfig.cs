using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;
using UnityEngine.Rendering;

public class TournamentAddonConfig
{
	public abstract class AddonConfig
	{
		private TournamentAddonAvailability <Availability>k__BackingField;

		protected TournamentAddonAvailability Availability
		{
			get
			{
				return <Availability>k__BackingField;
			}
			set
			{
				<Availability>k__BackingField = value;
			}
		}

		public abstract int CalculatePrice(string data);

		public bool IsAvailable(TournamentType type)
		{
			//IL_006a: Expected O, but got I4
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected I4, but got Unknown
			//IL_0037: Expected O, but got I4
			if (type != TournamentType.Private)
			{
				bool flag = type == TournamentType.Public;
				object obj = !flag;
				if (obj == null)
				{
					return (byte)(<Availability>k__BackingField & TournamentAddonAvailability.Public) != 0;
				}
				return false;
			}
			object obj2 = (int)<Availability>k__BackingField >> 1;
			object obj3 = obj2 & 1;
			return (byte)(obj3 & 1) != 0;
		}
	}

	public class SimpleConfig : AddonConfig
	{
		private int <Price>k__BackingField;

		private int Price
		{
			get
			{
				return <Price>k__BackingField;
			}
			set
			{
				<Price>k__BackingField = value;
			}
		}

		public static SimpleConfig FromJson(JObject data)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0034: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_01b7: Expected O, but got I4
			//IL_00a3: Expected I4, but got O
			//IL_00cd: Expected O, but got I4
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			//IL_01e5: Expected O, but got I4
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			int num;
			int val;
			if (data != null)
			{
				object obj3 = "Picking audio files is not supported on iOS" + 1544;
				object obj4 = (nint)0 + (nint)2264;
				object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				string text = (string)obj3;
				JToken value = data.GetValue((string)obj3, StringComparison.OrdinalIgnoreCase);
				if (value != null)
				{
					text = (string)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
					object obj6 = default(object);
					num = obj6 >> 32;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v17+E4]");
					bool flag = (nint)0 == 0;
					object obj8 = !flag;
					val = num;
					if (obj8 == null)
					{
						goto IL_00e3;
					}
				}
				else
				{
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v17+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					val = 0;
					if (obj9 == null)
					{
						num = 0;
						goto IL_00e3;
					}
				}
				goto IL_00fa;
			}
			goto IL_01ea;
			IL_00e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			val = num;
			goto IL_00fa;
			IL_00fa:
			int num2 = Math.Max(val, 0);
			if (obj2 != null)
			{
				object propertyName = "Added Tournament Prizes And Features" + 4056;
				JToken value2 = data.GetValue((string)propertyName, StringComparison.OrdinalIgnoreCase);
				if (value2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
					object obj11 = default(object);
					object obj10 = obj11 >> 32;
				}
				else
				{
					object obj10 = 0;
				}
				return (SimpleConfig)obj2;
			}
			goto IL_01ea;
			IL_01ea:
			return (SimpleConfig)(object)new NullReferenceException();
		}

		public override int CalculatePrice(string data)
		{
			return <Price>k__BackingField;
		}
	}

	public class ChampionshipConfig : AddonConfig
	{
		public class TrophyConfig
		{
			private string <Name>k__BackingField;

			private int <Price>k__BackingField;

			public string Name
			{
				get
				{
					return <Name>k__BackingField;
				}
				set
				{
					//IL_0006: Unknown result type (might be due to invalid IL or missing references)
					//IL_000b: Expected O, but got Unknown
					object obj = this + 16;
					obj = value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
			}

			public int Price
			{
				get
				{
					return <Price>k__BackingField;
				}
				set
				{
					<Price>k__BackingField = value;
				}
			}

			public static TrophyConfig FromJson(JToken token)
			{
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected O, but got Unknown
				//IL_0029: Expected I, but got O
				//IL_0052: Expected O, but got I4
				//IL_0086: Expected O, but got I
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Expected O, but got Unknown
				//IL_00c9: Expected O, but got I
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected O, but got Unknown
				//IL_036c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0371: Expected O, but got Unknown
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Expected O, but got Unknown
				//IL_021e: Expected O, but got I4
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Expected O, but got Unknown
				//IL_03a6: Expected O, but got I4
				//IL_03af: Expected O, but got I4
				//IL_01ac: Expected O, but got I4
				//IL_01bd: Expected O, but got I4
				//IL_01c6: Expected O, but got I4
				//IL_0245: Unknown result type (might be due to invalid IL or missing references)
				//IL_024a: Expected O, but got Unknown
				//IL_0259: Unknown result type (might be due to invalid IL or missing references)
				//IL_025e: Expected O, but got Unknown
				//IL_0267: Unknown result type (might be due to invalid IL or missing references)
				//IL_026c: Expected O, but got Unknown
				//IL_03f3: Expected O, but got I4
				//IL_02ca: Expected O, but got I
				//IL_02ea: Expected I4, but got O
				//IL_0314: Expected O, but got I4
				object obj8;
				object obj10;
				object obj12;
				string text3;
				string text2;
				object obj13;
				string text;
				object obj14;
				if (token != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 4088;
					object obj2 = obj;
					nint num = (nint)token;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X1_v2+130]");
					bool flag = num2 < 0;
					object obj3 = !flag;
					object obj4 = ~obj3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X1_v2+130]");
						object obj5 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9-8]");
						if (0 == (nint)obj2)
						{
							object propertyName = "Material with texture name \"" + 3600;
							object obj6 = (nint)0 + (nint)2000;
							object propertyName2 = "Unsupported map type" + 2376;
							JToken value = ((JObject)token).GetValue((string)propertyName, StringComparison.OrdinalIgnoreCase);
							bool flag2 = value == null;
							object obj7 = value;
							if (!flag2)
							{
								obj7 = Extensions.Value<object>(value);
							}
							obj8 = ((obj7 != null) ? obj7 : obj6);
							JToken value2 = ((JObject)token).GetValue((string)propertyName2, StringComparison.OrdinalIgnoreCase);
							if (value2 != null)
							{
								object obj9 = Extensions.Value<object>(value2);
								obj10 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1776;
								bool flag3 = string.IsNullOrEmpty((string)obj9);
								bool flag4 = !flag3;
								object obj11 = !flag4;
								obj12 = obj9;
								obj13 = 0;
								text = (string)5;
								obj14 = obj10;
								text2 = null;
								text3 = (string)obj8;
								if (obj11 == null)
								{
									goto IL_01e9;
								}
							}
							else
							{
								obj10 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1776;
								bool flag5 = string.IsNullOrEmpty(null);
								bool flag6 = !flag5;
								obj12 = null;
								if (flag6)
								{
									goto IL_01e9;
								}
								obj13 = 0;
								text = (string)5;
								obj14 = obj10;
								text2 = null;
								text3 = (string)obj8;
							}
							goto IL_0484;
						}
					}
					InvalidCastException ex = new InvalidCastException();
				}
				goto IL_0426;
				IL_0341:
				int val;
				int num4 = Math.Max(val, 0);
				object obj15 = default(object);
				return (TrophyConfig)obj15;
				IL_01e9:
				object obj16 = "[{0}]:{1}" + 912;
				text2 = (string)obj16;
				string text4 = (string)obj8 + (string)obj16 + (string)obj12;
				obj13 = 0;
				text = (string)obj12;
				obj14 = obj10;
				text3 = text4;
				goto IL_0484;
				IL_0484:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj15..ctor();
				int num5;
				if (obj15 != null)
				{
					object obj17 = "Picking audio files is not supported on iOS" + 1544;
					object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					object obj19 = obj15 + 16;
					obj19 = text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					string text5 = (string)obj17;
					JToken value3 = ((JObject)token).GetValue((string)obj17, StringComparison.OrdinalIgnoreCase);
					if (value3 != null)
					{
						object obj20 = (nint)0 + (nint)2264;
						text5 = (string)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
						object obj21 = default(object);
						num5 = obj21 >> 32;
						object obj22 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v24+E4]");
						bool flag7 = (nint)0 == 0;
						object obj23 = !flag7;
						val = num5;
						if (obj23 == null)
						{
							goto IL_032a;
						}
					}
					else
					{
						object obj22 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v24+E4]");
						bool flag8 = (nint)0 == 0;
						object obj24 = !flag8;
						val = 0;
						if (obj24 == null)
						{
							num5 = 0;
							goto IL_032a;
						}
					}
					goto IL_0341;
				}
				goto IL_0426;
				IL_0426:
				return (TrophyConfig)(object)new NullReferenceException();
				IL_032a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				val = num5;
				goto IL_0341;
			}
		}

		[Serializable]
		private sealed class <>c
		{
			public static readonly <>c <>9;

			public static Func<TrophyConfig, bool> <>9__13_0;

			public static Func<TrophyConfig, string> <>9__13_1;

			public static Func<IGrouping<string, TrophyConfig>, string> <>9__13_2;

			public static Func<IGrouping<string, TrophyConfig>, TrophyConfig> <>9__13_3;

			static <>c()
			{
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Expected O, but got Unknown
				object obj = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1768;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = default(object);
				obj2..ctor();
				object obj3 = obj;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}

			internal bool <FromJson>b__13_0(TrophyConfig config)
			{
				//IL_0050: Expected I4, but got O
				if (config != null)
				{
					bool flag = string.IsNullOrEmpty(config.<Name>k__BackingField);
					return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}

			internal string <FromJson>b__13_1(TrophyConfig config)
			{
				if (config != null)
				{
					return config.<Name>k__BackingField;
				}
				return (string)(object)new NullReferenceException();
			}

			internal string <FromJson>b__13_2(IGrouping<string, TrophyConfig> group)
			{
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Expected O, but got Unknown
				//IL_0021: Expected I, but got O
				//IL_0031: Expected O, but got I
				//IL_00cf: Expected O, but got I
				//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e6: Expected O, but got Unknown
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f4: Expected O, but got Unknown
				//IL_010c: Expected O, but got I
				//IL_006c: Expected O, but got I
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Expected O, but got Unknown
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Expected O, but got Unknown
				nint num;
				object obj3 = default(object);
				if (group != null)
				{
					object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1560;
					num = (nint)group;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, TournamentAddonConfig+ChampionshipConfig+TrophyConfig>>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, TournamentAddonConfig+ChampionshipConfig+TrophyConfig>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00ad;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, TournamentAddonConfig+ChampionshipConfig+TrophyConfig>>)+B0]");
					obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj3 += 16;
						obj2--;
						if ((nint)obj2 != 1)
						{
							continue;
						}
						goto IL_00ad;
					}
					goto IL_00d9;
				}
				goto IL_0116;
				IL_0116:
				return (string)(object)new NullReferenceException();
				IL_00ad:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				object obj5 = default(object);
				object obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
				goto IL_00d9;
				IL_00d9:
				object obj7 = num + obj3;
				object obj8 = obj7 + 312;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
				goto IL_0116;
			}

			internal TrophyConfig <FromJson>b__13_3(IGrouping<string, TrophyConfig> group)
			{
				return (TrophyConfig)Enumerable.First((IEnumerable<object>)group);
			}
		}

		private int? <CardBackID>k__BackingField;

		private int? <RoomThemeID>k__BackingField;

		private Dictionary<string, TrophyConfig> <Trophies>k__BackingField;

		public int? CardBackID
		{
			get
			{
				return <CardBackID>k__BackingField;
			}
			set
			{
				<CardBackID>k__BackingField = value;
			}
		}

		public int? RoomThemeID
		{
			get
			{
				return <RoomThemeID>k__BackingField;
			}
			set
			{
				<RoomThemeID>k__BackingField = value;
			}
		}

		public Dictionary<string, TrophyConfig> Trophies
		{
			get
			{
				return <Trophies>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 40;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public override int CalculatePrice(string data)
		{
			//IL_00a3: Expected I4, but got O
			if (data != null)
			{
				if (<Trophies>k__BackingField != null)
				{
					object value;
					bool flag = ((Dictionary<object, object>)(object)<Trophies>k__BackingField).TryGetValue((object)data, out value);
					bool flag2 = !flag;
					int result = (flag ? 1 : 0);
					if (!flag2)
					{
						if (value == null)
						{
							goto IL_0095;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ stack_-38_v3 (System.Object)+18]");
						result = 0;
					}
					return result;
				}
				goto IL_0095;
			}
			return 0;
			IL_0095:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		public static ChampionshipConfig FromJson(JObject data)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_006d: Expected O, but got I4
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_017e: Expected O, but got I
			//IL_01c2: Expected O, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I
			//IL_00b0: Expected O, but got I
			//IL_00bc: Expected O, but got I
			//IL_00d4: Expected I, but got O
			//IL_00e1: Expected I4, but got O
			//IL_0126: Expected O, but got I4
			//IL_012f: Expected O, but got I4
			//IL_0140: Expected O, but got I4
			//IL_0148: Expected I4, but got O
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Expected O, but got Unknown
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected O, but got Unknown
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected O, but got Unknown
			//IL_04ac: Expected O, but got I4
			//IL_09a3: Expected O, but got I
			//IL_09b3: Expected O, but got I
			//IL_09c3: Expected O, but got I
			//IL_09e5: Expected O, but got I4
			//IL_09ee: Expected O, but got I4
			//IL_0341: Expected O, but got I4
			//IL_04ed: Expected O, but got I
			//IL_04fd: Expected O, but got I
			//IL_050d: Expected O, but got I
			//IL_052f: Expected O, but got I4
			//IL_03a0: Expected O, but got I4
			//IL_05a4: Expected I, but got O
			//IL_041f: Expected O, but got I
			//IL_042f: Expected O, but got I
			//IL_043f: Expected O, but got I
			//IL_0461: Expected O, but got I4
			//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a10: Expected O, but got Unknown
			//IL_0a26: Expected O, but got I
			//IL_0a37: Expected I, but got O
			//IL_0a55: Expected O, but got I
			//IL_0a70: Expected O, but got I4
			//IL_0737: Expected O, but got I
			//IL_0747: Expected O, but got I
			//IL_0769: Expected O, but got I4
			//IL_0567: Expected O, but got I4
			//IL_03d0: Expected O, but got I
			//IL_05f2: Expected O, but got I
			//IL_0602: Expected O, but got I
			//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a91: Expected O, but got Unknown
			//IL_0aa7: Expected O, but got I
			//IL_0ab8: Expected I, but got O
			//IL_0ad6: Expected O, but got I
			//IL_0af9: Expected O, but got I4
			//IL_086e: Expected O, but got I
			//IL_087e: Expected O, but got I
			//IL_088e: Expected O, but got I
			//IL_08b0: Expected O, but got I4
			//IL_07a1: Expected O, but got I4
			//IL_0597: Expected O, but got I
			//IL_094b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0950: Expected O, but got Unknown
			//IL_0690: Expected O, but got I
			//IL_06a0: Expected O, but got I
			//IL_06b0: Expected O, but got I
			//IL_06d2: Expected O, but got I4
			//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1a: Expected O, but got Unknown
			//IL_0b30: Expected O, but got I
			//IL_0b38: Expected I, but got O
			//IL_0b49: Expected I, but got O
			//IL_0b67: Expected O, but got I
			//IL_08f8: Expected O, but got I4
			//IL_0800: Expected O, but got I4
			//IL_0811: Expected O, but got I4
			//IL_082a: Expected O, but got I4
			//IL_0832: Expected I, but got O
			//IL_07d1: Expected O, but got I
			//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b92: Expected O, but got Unknown
			//IL_0ba8: Expected O, but got I
			//IL_0bb9: Expected I, but got O
			//IL_0bd7: Expected O, but got I
			//IL_0928: Expected O, but got I
			object propertyName;
			List<object> source2;
			if (data != null)
			{
				object obj = "ThisIsFakeReceiptData" + 1976;
				object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3408;
				propertyName = "Cannot populate JSON object onto type '{0}'." + 1704;
				string text = (string)obj;
				JToken value = data.GetValue((string)obj, StringComparison.OrdinalIgnoreCase);
				bool flag = value == null;
				object obj3 = 0;
				StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
				string text2;
				object obj9;
				StringComparison stringComparison2;
				if (!flag)
				{
					object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2056;
					object obj5 = (nint)0 + (nint)3768;
					object obj6 = (nint)0 + (nint)3600;
					object obj7 = (nint)0 + (nint)2928;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, object> func = default(Func<object, object>);
					func..ctor((object)null, (IntPtr)obj5);
					stringComparison = (StringComparison)obj6;
					IEnumerable<object> source = Enumerable.Select(value, func);
					text = (string)obj7;
					List<object> list = Enumerable.ToList(source);
					bool flag2 = list == null;
					object obj8 = !flag2;
					obj3 = 0;
					source2 = list;
					obj9 = 0;
					stringComparison2 = (StringComparison)obj6;
					text2 = (string)obj7;
					if (obj8 != null)
					{
						goto IL_01b6;
					}
				}
				object obj10 = typeof(List<Tween>) + 1648;
				object obj11 = (nint)0 + (nint)2168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				text2 = (string)obj11;
				List<object> list2 = default(List<object>);
				list2..ctor();
				source2 = list2;
				obj9 = obj3;
				stringComparison2 = stringComparison;
				goto IL_01b6;
			}
			goto IL_096c;
			IL_062f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+E4]");
			bool flag3 = (nint)0 == 0;
			Func<object, object> func3;
			Func<object, object> func2 = func3;
			Func<object, object> func5;
			Func<object, object> func4 = func5;
			object obj13;
			object obj12 = obj13;
			nint num2;
			nint num = num2;
			Func<object, object> func6 = func3;
			object obj15;
			object obj14 = obj15;
			if (!flag3)
			{
				goto IL_0684;
			}
			goto IL_0850;
			IL_035f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17;
			object obj16 = obj17;
			string text4;
			string text3 = text4;
			goto IL_0997;
			IL_0850:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj17;
			object obj18 = (nint)0 + (nint)1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+B8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v17+20]");
			Func<object, object> elementSelector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v17+20]");
			bool flag4 = (nint)0 == 0;
			object obj20 = !flag4;
			Func<object, object> func7 = func4;
			Func<object, object> keySelector = func4;
			object obj21 = obj18;
			if (obj20 == null)
			{
				goto IL_08d6;
			}
			goto IL_092d;
			IL_01b6:
			object obj22 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = default(object);
			obj23..ctor();
			JToken value2 = data.GetValue((string)propertyName, StringComparison.OrdinalIgnoreCase);
			if (value2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
			}
			if (obj23 == null)
			{
				goto IL_096c;
			}
			object propertyName2 = "Read object reference Id '{0}' for {1}." + 3504;
			object obj24 = "Added Tournament Prizes And Features" + 4056;
			JToken value3 = data.GetValue((string)propertyName2, StringComparison.OrdinalIgnoreCase);
			if (value3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
			}
			obj17 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 1768;
			text3 = (string)obj24;
			JToken value4 = data.GetValue((string)obj24, StringComparison.OrdinalIgnoreCase);
			if (value4 != null)
			{
				text4 = (string)obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
				object obj26 = default(object);
				object obj25 = obj26 >> 32;
				object obj27 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v75+E4]");
				bool flag5 = (nint)0 == 0;
				object obj28 = !flag5;
				text3 = (string)obj22;
				obj16 = obj27;
				if (obj28 == null)
				{
					goto IL_035f;
				}
			}
			else
			{
				_ = 0;
				obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v17+E4]");
				bool flag6 = (nint)0 == 0;
				object obj29 = !flag6;
				if (obj29 == null)
				{
					text4 = (string)obj24;
					object obj27 = obj16;
					goto IL_035f;
				}
			}
			goto IL_0997;
			IL_092d:
			IEnumerable<IGrouping<object, object>> source3;
			Dictionary<object, object> dictionary = Enumerable.ToDictionary(source3, keySelector, elementSelector);
			object obj30 = obj23 + 40;
			obj30 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (ChampionshipConfig)obj23;
			IL_0997:
			object obj31 = (nint)0 + (nint)3944;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v17+B8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v54+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v54+8]");
			bool flag7 = (nint)0 == 0;
			object obj33 = !flag7;
			obj13 = 0;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v17+E4]");
				bool flag8 = (nint)0 == 0;
				object obj34 = !flag8;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj35 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v60+B8]");
					obj32 = 0;
				}
				object obj36 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 576;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj37 = (nint)0 + (nint)3736;
				Func<object, bool> func8 = default(Func<object, bool>);
				func8..ctor(obj32, (IntPtr)obj37);
				object obj38 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v59+B8]");
				object obj39 = (nint)0 + (nint)8;
				obj39 = func8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj13 = 0;
				predicate = func8;
			}
			IEnumerable<object> source4 = Enumerable.Where(source2, predicate);
			object obj40 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v57+E4]");
			object obj41;
			object obj42;
			object obj44;
			if ((nint)0 != 0)
			{
				obj41 = (nint)0 + (nint)1576;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v57+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v44+10]");
				func3 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v44+10]");
				bool flag9 = (nint)0 == 0;
				object obj43 = !flag9;
				if (obj43 == null)
				{
					obj44 = obj41;
					goto IL_0545;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj40 = obj17;
				obj44 = (nint)0 + (nint)1576;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v57+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v44+10]");
				func3 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v44+10]");
				bool flag10 = (nint)0 == 0;
				object obj45 = !flag10;
				obj41 = obj44;
				if (obj45 == null)
				{
					goto IL_0545;
				}
			}
			goto IL_059c;
			IL_096c:
			return (ChampionshipConfig)(object)new NullReferenceException();
			IL_059c:
			num2 = (nint)obj41;
			source3 = Enumerable.GroupBy(source4, func3);
			obj15 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+E4]");
			object obj46;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+B8]");
				obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v28+18]");
				func5 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v28+18]");
				bool flag11 = (nint)0 == 0;
				object obj47 = obj15;
				if (!flag11)
				{
					goto IL_062f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+B8]");
				obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v28+18]");
				func5 = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v28+18]");
				bool flag12 = (nint)0 == 0;
				object obj48 = !flag12;
				object obj47 = obj15;
				if (obj48 != null)
				{
					goto IL_062f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v44+E4]");
			bool flag13 = (nint)0 == 0;
			object obj49 = !flag13;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj50 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v35+B8]");
				obj46 = 0;
			}
			object obj51 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj52 = (nint)0 + (nint)3752;
			num2 = (nint)obj52;
			Func<object, object> func9 = default(Func<object, object>);
			func9..ctor(obj46, (IntPtr)obj52);
			object obj53 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v33+B8]");
			object obj54 = (nint)0 + (nint)24;
			obj54 = func9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj15 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+E4]");
			bool flag14 = (nint)0 == 0;
			object obj55 = !flag14;
			func5 = func9;
			obj13 = 0;
			func2 = func9;
			func4 = func9;
			obj12 = 0;
			num = (nint)obj52;
			func6 = func9;
			obj14 = obj15;
			if (obj55 != null)
			{
				goto IL_0684;
			}
			goto IL_0850;
			IL_0545:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v57+E4]");
			bool flag15 = (nint)0 == 0;
			object obj56 = !flag15;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj57 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v50+B8]");
				obj42 = 0;
			}
			object obj58 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj59 = (nint)0 + (nint)3744;
			Func<object, object> func10 = default(Func<object, object>);
			func10..ctor(obj42, (IntPtr)obj59);
			object obj60 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v49+B8]");
			object obj61 = (nint)0 + (nint)16;
			obj61 = func10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func3 = func10;
			obj13 = 0;
			obj41 = obj44;
			goto IL_059c;
			IL_08d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+E4]");
			bool flag16 = (nint)0 == 0;
			object obj62 = !flag16;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj63 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v23+B8]");
				obj19 = 0;
			}
			object obj64 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj65 = (nint)0 + (nint)3760;
			Func<object, object> func11 = default(Func<object, object>);
			func11..ctor(obj19, (IntPtr)obj65);
			object obj66 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v22+B8]");
			object obj67 = (nint)0 + (nint)32;
			obj67 = func11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func7;
			obj21 = obj18;
			elementSelector = func11;
			goto IL_092d;
			IL_0684:
			obj21 = (nint)0 + (nint)1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v33+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v17+20]");
			elementSelector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v17+20]");
			bool flag17 = (nint)0 == 0;
			object obj68 = !flag17;
			keySelector = func5;
			if (obj68 == null)
			{
				func7 = func5;
				obj18 = obj21;
				obj12 = obj13;
				num = num2;
				func6 = func2;
				goto IL_08d6;
			}
			goto IL_092d;
		}
	}

	public class TitleRestrictionConfig : AddonConfig
	{
		private string[] <AllowedTitles>k__BackingField;

		private int <Price>k__BackingField;

		private string[] AllowedTitles
		{
			get
			{
				return <AllowedTitles>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 24;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		private int Price
		{
			get
			{
				return <Price>k__BackingField;
			}
			set
			{
				<Price>k__BackingField = value;
			}
		}

		public override int CalculatePrice(string data)
		{
			return <Price>k__BackingField;
		}

		public static TitleRestrictionConfig FromJson(JObject data)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0034: Expected O, but got I
			//IL_0111: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_013c: Expected O, but got I4
			//IL_016d: Expected O, but got I4
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected O, but got Unknown
			//IL_014d: Expected O, but got I
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object propertyName = "Picking audio files is not supported on iOS" + 1544;
			object obj3 = (nint)0 + (nint)2264;
			JToken value = data.GetValue((string)propertyName, StringComparison.OrdinalIgnoreCase);
			if (value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
				object obj5 = default(object);
				object obj4 = obj5 >> 32;
			}
			else
			{
				bool flag = obj2 == null;
				object obj6 = !flag;
				object obj4 = 0;
				if (obj6 == null)
				{
					throw new NullReferenceException();
				}
			}
			object propertyName2 = "Added Tournament Prizes And Features" + 4056;
			object propertyName3 = "Added Tournament Prizes And Features" + 520;
			JToken value2 = data.GetValue((string)propertyName2, StringComparison.OrdinalIgnoreCase);
			if (value2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E02B2C");
				object obj8 = default(object);
				object obj7 = obj8 >> 32;
			}
			else
			{
				object obj7 = 0;
			}
			JToken value3 = data.GetValue((string)propertyName3, StringComparison.OrdinalIgnoreCase);
			object obj10;
			if (value3 != null)
			{
				object obj9 = (nint)0 + (nint)3920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E8ECD8");
				object obj11 = default(object);
				obj10 = obj11;
			}
			else
			{
				obj10 = 0;
			}
			object obj12 = obj2 + 24;
			obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (TitleRestrictionConfig)obj2;
		}

		public List<GameAchievementViewModel> GetAllowedTitles()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_0096: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			//IL_004e: Expected I, but got O
			object obj = typeof(SqlSingle[]) + 2360;
			object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
			object obj3 = (nint)0 + (nint)3632;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<GameAchievementViewModel> titles = AchievementsManager.Titles;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj3);
			IEnumerable<object> source = Enumerable.Where(titles, func);
			return (List<GameAchievementViewModel>)(object)Enumerable.ToList(source);
		}

		private bool <GetAllowedTitles>b__10_0(GameAchievementViewModel title)
		{
			//IL_0054: Expected I4, but got O
			if (<AllowedTitles>k__BackingField != null)
			{
				if (title != null)
				{
					return Enumerable.Contains((IEnumerable<object>)<AllowedTitles>k__BackingField, (object)title.<id>k__BackingField);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return true;
		}
	}

	public enum TournamentAddonAvailability
	{
		Disabled,
		Public,
		Private
	}

	private readonly Dictionary<TournamentAddonType, AddonConfig> <AddonConfigs>k__BackingField;

	private JObject <RawJson>k__BackingField;

	public Dictionary<TournamentAddonType, AddonConfig> AddonConfigs => <AddonConfigs>k__BackingField;

	public JObject RawJson
	{
		get
		{
			return <RawJson>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TournamentAddonConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj2 = this + 16;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	public TournamentAddonConfig(Dictionary<TournamentAddonType, AddonConfig> configs)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_003a: Expected O, but got I4
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj2 = this + 16;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj3 = configs != null;
		Dictionary<System.Int32Enum, object> dictionary2 = (Dictionary<System.Int32Enum, object>)(object)configs;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<System.Int32Enum, object> dictionary3 = default(Dictionary<System.Int32Enum, object>);
			dictionary3..ctor();
			dictionary2 = dictionary3;
		}
		obj2 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private static JToken Read(JObject data, string name)
	{
		if (data != null)
		{
			return data.GetValue(name, StringComparison.OrdinalIgnoreCase);
		}
		return (JToken)(object)new NullReferenceException();
	}
}
