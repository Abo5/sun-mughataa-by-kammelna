using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.Rendering;

namespace Kammelna.Server.WebRequests;

public class ClientContext : IClientContext
{
	private const string BUILD_BLOB_HEADER = "X-Km-Build";

	private static readonly string BuildBlob;

	private GameType? <GameType>k__BackingField;

	private long? <TournamentId>k__BackingField;

	private TournamentType? <TournamentType>k__BackingField;

	public Games Game
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E858B]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Preferences.CurrentGame;
			IL_0074:
			return Preferences.CurrentGame;
		}
	}

	public string Version => UnityEngine.Device.Application.version;

	public Platform Platform
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E858C]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return KUtil.GetPlatform();
			IL_0074:
			return KUtil.GetPlatform();
		}
	}

	public GameType? GameType
	{
		get
		{
			return <GameType>k__BackingField;
		}
		set
		{
			<GameType>k__BackingField = value;
		}
	}

	public long? TournamentId
	{
		get
		{
			return <TournamentId>k__BackingField;
		}
		set
		{
			<TournamentId>k__BackingField = value;
		}
	}

	public TournamentType? TournamentType
	{
		get
		{
			return <TournamentType>k__BackingField;
		}
		set
		{
			<TournamentType>k__BackingField = value;
		}
	}

	public unsafe IEnumerable<(string, string)> GetRequestHeaders()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0028: Expected O, but got I
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected O, but got Unknown
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_1158: Expected O, but got Unknown
		//IL_1164: Expected O, but got I
		//IL_118e: Expected O, but got I4
		//IL_004f: Expected O, but got Ref
		//IL_0092: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_013e: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_023f: Expected O, but got I4
		//IL_0333: Expected O, but got I
		//IL_0343: Expected O, but got I
		//IL_0353: Expected O, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_038a: Expected O, but got I
		//IL_03a4: Expected O, but got I4
		//IL_03cc: Expected O, but got I
		//IL_11a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ac: Expected O, but got Unknown
		//IL_11d6: Expected O, but got I4
		//IL_0263: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02cf: Expected O, but got I
		//IL_02ef: Expected O, but got I4
		//IL_0437: Expected O, but got Ref
		//IL_0477: Expected O, but got I
		//IL_048c: Expected O, but got I
		//IL_031e: Expected O, but got I4
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I4
		//IL_05cb: Expected O, but got I
		//IL_05db: Expected O, but got I
		//IL_05eb: Expected O, but got I
		//IL_0622: Expected O, but got I4
		//IL_0642: Expected O, but got I
		//IL_0690: Expected O, but got I4
		//IL_06a6: Expected O, but got I
		//IL_0512: Expected O, but got I
		//IL_0534: Expected O, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		//IL_057e: Expected O, but got I4
		//IL_058f: Expected O, but got I4
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected O, but got Unknown
		//IL_08e8: Expected O, but got I4
		//IL_071f: Expected O, but got I
		//IL_072f: Expected O, but got I
		//IL_0750: Expected O, but got I
		//IL_076e: Expected O, but got I
		//IL_0783: Expected O, but got I
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		//IL_05b6: Expected O, but got I4
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07e5: Expected O, but got I4
		//IL_0935: Expected O, but got I
		//IL_0945: Expected O, but got I
		//IL_0955: Expected O, but got I
		//IL_0999: Expected O, but got I
		//IL_0a29: Expected O, but got I
		//IL_0809: Expected O, but got I
		//IL_082b: Expected O, but got I
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_0875: Expected O, but got I4
		//IL_0a55: Expected O, but got I4
		//IL_0a6e: Expected O, but got I4
		//IL_09cf: Expected O, but got I
		//IL_09f4: Expected O, but got I4
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0aa6: Expected O, but got I4
		//IL_089c: Expected O, but got I4
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Expected O, but got Unknown
		//IL_11f4: Expected O, but got I
		//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Expected O, but got Unknown
		//IL_122a: Expected O, but got I
		//IL_123f: Expected O, but got I
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected O, but got Unknown
		//IL_0ba2: Expected O, but got Ref
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected O, but got Unknown
		//IL_0d86: Expected O, but got Ref
		//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Expected O, but got Unknown
		//IL_0bea: Expected O, but got I
		//IL_0bff: Expected O, but got I
		//IL_0af4: Expected O, but got I4
		//IL_0f75: Expected O, but got Ref
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f91: Expected O, but got Unknown
		//IL_0dce: Expected O, but got I
		//IL_0de3: Expected O, but got I
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected O, but got Unknown
		//IL_0d35: Expected O, but got I4
		//IL_0fbd: Expected O, but got I
		//IL_0fd2: Expected O, but got I
		//IL_0c4d: Expected O, but got I4
		//IL_0b18: Expected O, but got I
		//IL_0b3a: Expected O, but got I
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected O, but got Unknown
		//IL_0e31: Expected O, but got I4
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Expected O, but got Unknown
		//IL_0f1c: Expected O, but got I4
		//IL_1020: Expected O, but got I4
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected O, but got Unknown
		//IL_10cc: Expected O, but got I4
		//IL_0c71: Expected O, but got I
		//IL_0c93: Expected O, but got I
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Expected O, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected O, but got Unknown
		//IL_0ce4: Expected O, but got I4
		//IL_0e55: Expected O, but got I
		//IL_0e77: Expected O, but got I
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Expected O, but got Unknown
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected O, but got Unknown
		//IL_0ecb: Expected O, but got I4
		//IL_1044: Expected O, but got I
		//IL_1066: Expected O, but got I
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3904;
		object obj4 = (nint)0 + (nint)3544;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<(object, object)> list = default(List<(object, object)>);
		list..ctor();
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object item = "fetch_products" + 2352;
		object obj6 = (nint)0 + (nint)3936;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		(object, object) tuple = default((object, object));
		string item2 = ((Enum)(&tuple)).ToString();
		(object, object) tuple2 = (item, item2);
		object obj9;
		object obj16;
		object obj24;
		object obj26;
		(object, object) tuple4;
		object obj27;
		object obj34 = default(object);
		object obj28;
		object obj29;
		(object, object) tuple5;
		if (list != null)
		{
			obj9 = (nint)0 + (nint)3552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
			object obj10 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
			if ((nint)0 != 0)
			{
				object item3 = "utf-32" + 456;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v5+18]");
				bool flag2 = num < 0;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
					object obj13 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
					object obj14 = num2 + 0;
					object obj15 = obj14 + 32;
					obj15 = tuple2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					list.AddWithResize(tuple2);
				}
				string version = UnityEngine.Device.Application.version;
				obj16 = obj6;
				(object, object) tuple3 = (item3, version);
				object obj17 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
				object obj18 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X9_v8+18]");
					bool flag3 = num3 < 0;
					object obj20 = !flag3;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
						object obj21 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
						object obj22 = num4 + 0;
						object obj23 = obj22 + 32;
						obj23 = tuple3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E858C]");
						object obj25 = (nint)0 & (nint)1;
						bool flag4 = obj25 == null;
						obj26 = version;
						tuple4 = ((object, object))0;
						if (flag4)
						{
							goto IL_03ea;
						}
						obj27 = obj24;
						obj28 = obj16;
						obj29 = version;
						tuple5 = ((object, object))0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v10+20]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v89+C0]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v90+70]");
						obj16 = 0;
						list.AddWithResize(tuple3);
						obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E858C]");
						object obj32 = (nint)0 & (nint)1;
						bool flag5 = obj32 == null;
						object obj33 = !flag5;
						obj26 = obj34;
						tuple4 = tuple3;
						obj27 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v90+70]");
						obj28 = 0;
						obj29 = obj34;
						tuple5 = tuple3;
						if (obj33 == null)
						{
							goto IL_03ea;
						}
					}
					goto IL_119c;
				}
			}
		}
		goto IL_10f6;
		IL_0d77:
		long? num5 = (long?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		string item4 = ((long?*)num5)->ToString();
		object item5 = "startPosition" + 3920;
		tuple = (item5, item4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
		object obj35 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		TournamentType? tournamentType;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v25+18]");
			bool flag6 = num6 < 0;
			object obj37 = !flag6;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj38 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj39 = num7 + 0;
				object obj40 = obj39 + 32;
				obj40 = tuple;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tournamentType = <TournamentType>k__BackingField;
				object obj41 = (??)<TournamentType>k__BackingField & 1;
				bool flag7 = obj41 == null;
				object obj42 = !flag7;
				if (obj42 != null)
				{
					goto IL_0f61;
				}
			}
			else
			{
				list.AddWithResize(tuple);
				tournamentType = <TournamentType>k__BackingField;
				object obj43 = (??)<TournamentType>k__BackingField & 1;
				bool flag8 = obj43 == null;
				object obj44 = !flag8;
				if (obj44 != null)
				{
					goto IL_0f61;
				}
			}
			goto IL_10f1;
		}
		goto IL_10f6;
		IL_09bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v80+B8]");
		object value = 0;
		bool flag9 = string.IsNullOrEmpty((string)value);
		bool flag10 = !flag9;
		object obj45 = 0;
		if (flag10)
		{
			goto IL_0a7c;
		}
		goto IL_0b5f;
		IL_0b93:
		System.Int32Enum? int32Enum = (System.Int32Enum?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 72));
		string item6 = ((System.Int32Enum?*)int32Enum)->ToString();
		object item7 = "fetch_products" + 2424;
		tuple = (item7, item6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
		object obj46 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X9_v30+18]");
			bool flag11 = num8 < 0;
			object obj48 = !flag11;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj49 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj50 = num9 + 0;
				object obj51 = obj50 + 32;
				obj51 = tuple;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = <TournamentId>k__BackingField;
				object obj52 = (??)<TournamentId>k__BackingField & 1;
				bool flag12 = obj52 == null;
				object obj53 = !flag12;
				if (obj53 != null)
				{
					goto IL_0d77;
				}
			}
			else
			{
				list.AddWithResize(tuple);
				_ = <TournamentId>k__BackingField;
				object obj54 = (??)<TournamentId>k__BackingField & 1;
				bool flag13 = obj54 == null;
				object obj55 = !flag13;
				if (obj55 != null)
				{
					goto IL_0d77;
				}
			}
			goto IL_0f2a;
		}
		goto IL_10f6;
		IL_0a7c:
		object obj57;
		object obj56 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v67+E4]");
		bool flag14 = (nint)0 == 0;
		object obj58 = !flag14;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj56 = obj57;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v67+B8]");
		object item8 = 0;
		object item9 = "WhiteSmoke" + 624;
		tuple = (item9, item8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
		object obj59 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X9_v34+18]");
			bool flag15 = num10 < 0;
			object obj61 = !flag15;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj62 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj63 = num11 + 0;
				object obj64 = obj63 + 32;
				obj64 = tuple;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				goto IL_0b5f;
			}
			list.AddWithResize(tuple);
			_ = <GameType>k__BackingField;
			object obj65 = (??)<GameType>k__BackingField & 1;
			bool flag16 = obj65 == null;
			object obj66 = !flag16;
			if (obj66 != null)
			{
				goto IL_0b93;
			}
			goto IL_0d43;
		}
		goto IL_10f6;
		IL_10f6:
		return (IEnumerable<(string, string)>)new NullReferenceException();
		IL_0687:
		object obj67 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F6]");
		object obj68 = (nint)0 & (nint)1;
		object obj69;
		object obj71;
		object obj72;
		object obj70;
		if (obj68 != null)
		{
			obj69 = "WhiteSmoke" + 632;
			obj70 = obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v34+E4]");
			bool flag17 = (nint)0 == 0;
			obj72 = obj69;
			object obj73 = obj70;
			if (!flag17)
			{
				goto IL_070f;
			}
		}
		else
		{
			_ = 1;
			obj69 = "WhiteSmoke" + 632;
			obj70 = obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v34+E4]");
			bool flag18 = (nint)0 == 0;
			object obj74 = !flag18;
			obj72 = obj69;
			object obj73 = obj70;
			if (obj74 != null)
			{
				goto IL_070f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj70 = obj71;
		obj69 = obj72;
		goto IL_070f;
		IL_0660:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj76;
		object obj75 = obj76;
		object obj78;
		object obj77 = obj78;
		(object, object) tuple7;
		(object, object) tuple6 = tuple7;
		goto IL_0687;
		IL_10f1:
		return (IEnumerable<(string, string)>)list;
		IL_070f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v34+B8]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v21+10]");
		object obj80 = 0;
		object obj81 = obj6;
		object item10 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v21+10]");
		(object, object) tuple8 = (item10, 0);
		object obj82 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
		object obj83 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		if ((nint)0 != 0)
		{
			obj57 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1496;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X9_v15+18]");
			bool flag19 = num12 < 0;
			object obj85 = !flag19;
			object obj91;
			object obj92;
			if (obj85 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj86 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj87 = num13 + 0;
				object obj88 = obj87 + 32;
				obj88 = tuple8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj89 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v80+E4]");
				bool flag20 = (nint)0 == 0;
				object obj90 = !flag20;
				if (obj90 != null)
				{
					goto IL_09bf;
				}
				obj91 = obj81;
				obj92 = obj80;
				(object, object) tuple9 = ((object, object))0;
				object obj93 = obj89;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v22+20]");
				object obj94 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v75+C0]");
				object obj95 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v76+70]");
				obj81 = 0;
				list.AddWithResize(tuple8);
				object obj89 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v80+E4]");
				bool flag21 = (nint)0 == 0;
				obj80 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v76+70]");
				obj91 = 0;
				obj92 = obj34;
				(object, object) tuple9 = tuple8;
				object obj93 = obj89;
				if (!flag21)
				{
					goto IL_09bf;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj96 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v77+B8]");
			object value2 = 0;
			bool flag22 = string.IsNullOrEmpty((string)value2);
			bool flag23 = !flag22;
			object obj97 = !flag23;
			obj81 = obj91;
			obj80 = obj92;
			obj45 = 0;
			if (obj97 == null)
			{
				goto IL_0a7c;
			}
			goto IL_0b5f;
		}
		goto IL_10f6;
		IL_0f2a:
		tournamentType = <TournamentType>k__BackingField;
		object obj98 = (??)<TournamentType>k__BackingField & 1;
		if (obj98 != null)
		{
			goto IL_0f61;
		}
		goto IL_10f1;
		IL_03ea:
		_ = 1;
		obj27 = obj24;
		obj28 = obj16;
		obj29 = obj26;
		tuple5 = tuple4;
		goto IL_119c;
		IL_0f61:
		System.Int32Enum? int32Enum2 = (System.Int32Enum?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
		string item11 = ((System.Int32Enum?*)int32Enum2)->ToString();
		object item12 = "startPosition" + 3928;
		tuple = (item12, item11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
		object obj99 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X9_v20+18]");
			bool flag24 = num14 < 0;
			object obj101 = !flag24;
			if (obj101 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj102 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj103 = num15 + 0;
				object obj104 = obj103 + 32;
				obj104 = tuple;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize(tuple);
			}
			goto IL_10f1;
		}
		goto IL_10f6;
		IL_119c:
		object item13 = "placementId" + 40;
		object obj105 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v19+E4]");
		bool flag25 = (nint)0 == 0;
		object obj106 = !flag25;
		if (obj106 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Platform platform = KUtil.GetPlatform();
		object obj107 = default(object);
		string text = ((Enum)(&obj107)).ToString();
		obj75 = obj6;
		(object, object) tuple10 = (item13, text);
		object obj108 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+1C]");
		object obj109 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
		if ((nint)0 != 0)
		{
			obj71 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X9_v12+18]");
			bool flag26 = num16 < 0;
			object obj111 = !flag26;
			if (obj111 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj112 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+10]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>)+18]");
				object obj113 = num17 + 0;
				object obj114 = obj113 + 32;
				obj114 = tuple10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj115 = obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v90+E4]");
				bool flag27 = (nint)0 == 0;
				object obj116 = !flag27;
				obj77 = text;
				tuple6 = ((object, object))0;
				if (obj116 == null)
				{
					obj76 = obj75;
					obj78 = text;
					tuple7 = ((object, object))0;
					goto IL_0660;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v14+20]");
				object obj117 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v82+C0]");
				object obj118 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v83+70]");
				obj76 = 0;
				list.AddWithResize(tuple10);
				object obj115 = obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v90+E4]");
				bool flag28 = (nint)0 == 0;
				object obj119 = !flag28;
				obj78 = obj34;
				tuple7 = tuple10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v83+70]");
				obj75 = 0;
				obj77 = obj34;
				tuple6 = tuple10;
				if (obj119 == null)
				{
					goto IL_0660;
				}
			}
			goto IL_0687;
		}
		goto IL_10f6;
		IL_0b5f:
		_ = <GameType>k__BackingField;
		object obj120 = (??)<GameType>k__BackingField & 1;
		if (obj120 != null)
		{
			goto IL_0b93;
		}
		goto IL_0d43;
		IL_0d43:
		_ = <TournamentId>k__BackingField;
		object obj121 = (??)<TournamentId>k__BackingField & 1;
		if (obj121 != null)
		{
			goto IL_0d77;
		}
		goto IL_0f2a;
	}

	static ClientContext()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		object obj = "AvailableVoices" + 2896;
		object obj2 = (nint)0 + (nint)2096;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF8ABC");
		TextAsset textAsset = default(TextAsset);
		bool flag = (object)textAsset == null;
		string text = null;
		if (!flag)
		{
			string text2 = textAsset.text;
			text = text2;
		}
		object obj4 = obj3;
		object obj5 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
