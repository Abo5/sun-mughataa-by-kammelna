using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class SFSConfig
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameConfiguration, Games> <>9__58_0;

		public static Func<GameConfiguration, bool> <>9__68_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal Games <get_AvailableGames>b__58_0(GameConfiguration g)
		{
			//IL_0035: Expected I4, but got O
			if (g != null)
			{
				return g.<Game>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Games)ex;
		}

		internal bool <SetServerExtraConfigs>b__68_0(GameConfiguration g)
		{
			//IL_0054: Expected I4, but got O
			if (g != null)
			{
				string currentZone = SFS.CurrentZone;
				return g.<Zone>k__BackingField == currentZone;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string ExtraConfigs = "extraConfigs";

	private string <ID>k__BackingField;

	private string <Name>k__BackingField;

	private int <MaxUsers>k__BackingField;

	private int <OnlineUsers>k__BackingField;

	private string <IP>k__BackingField;

	private int <Port>k__BackingField;

	private int <WebPort>k__BackingField;

	private bool <IsMain>k__BackingField;

	private bool <IsOnline>k__BackingField;

	private bool <IsFastTrack>k__BackingField;

	private bool <IsRestricted>k__BackingField;

	private List<GameConfiguration> <Games>k__BackingField;

	private LastRequestUpdateModel <LastRequestUpdates>k__BackingField;

	private readonly int <FTPlayMoreTimer>k__BackingField;

	public string ID
	{
		get
		{
			return <ID>k__BackingField;
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
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int MaxUsers
	{
		get
		{
			return <MaxUsers>k__BackingField;
		}
		set
		{
			<MaxUsers>k__BackingField = value;
		}
	}

	public int OnlineUsers
	{
		get
		{
			return <OnlineUsers>k__BackingField;
		}
		set
		{
			<OnlineUsers>k__BackingField = value;
		}
	}

	public string IP
	{
		get
		{
			return <IP>k__BackingField;
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

	public int Port
	{
		get
		{
			return <Port>k__BackingField;
		}
		set
		{
			<Port>k__BackingField = value;
		}
	}

	public int WebPort
	{
		get
		{
			return <WebPort>k__BackingField;
		}
		set
		{
			<WebPort>k__BackingField = value;
		}
	}

	public bool IsMain
	{
		get
		{
			return <IsMain>k__BackingField;
		}
		set
		{
			<IsMain>k__BackingField = value;
		}
	}

	public bool IsOnline
	{
		get
		{
			return <IsOnline>k__BackingField;
		}
		set
		{
			<IsOnline>k__BackingField = value;
		}
	}

	public bool IsFastTrack
	{
		get
		{
			return <IsFastTrack>k__BackingField;
		}
		set
		{
			<IsFastTrack>k__BackingField = value;
		}
	}

	public bool IsRestricted
	{
		get
		{
			return <IsRestricted>k__BackingField;
		}
		set
		{
			<IsRestricted>k__BackingField = value;
		}
	}

	public List<GameConfiguration> Games
	{
		get
		{
			return <Games>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int PlatformPort
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0097: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.WebGLPlayer)
			{
				object obj4 = 52;
			}
			else
			{
				object obj4 = 48;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SFSConfig)+v66 @ X8_v5]");
			return 0;
		}
	}

	public string DisplayName => <Name>k__BackingField;

	public bool IsOpen
	{
		get
		{
			//IL_0033: Expected O, but got I4
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected I4, but got Unknown
			if (<IsOnline>k__BackingField)
			{
				object obj = <OnlineUsers>k__BackingField - <MaxUsers>k__BackingField;
				bool flag = (nint)obj < 0;
				int num = <OnlineUsers>k__BackingField ^ <MaxUsers>k__BackingField;
				int num2 = <OnlineUsers>k__BackingField ^ obj;
				int num3 = num & num2;
				bool flag2 = num3 < 0;
				bool flag3 = flag == flag2;
				return !flag3;
			}
			return false;
		}
	}

	public bool IsRestrictedForUser
	{
		get
		{
			//IL_0139: Expected I4, but got O
			//IL_00af: Expected O, but got I4
			//IL_00d1: Expected O, but got I4
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			if (<IsRestricted>k__BackingField)
			{
				User mySelf = SFS.MySelf;
				bool flag = SFSKammelnaUserExtensions.IsSubscribed(mySelf);
				bool flag2 = !flag;
				bool result = true;
				if (!flag2)
				{
					User mySelf2 = SFS.MySelf;
					PlayerRank rank = SFSKammelnaUserExtensions.GetRank(mySelf2);
					if (rank == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					object obj = rank.<Rank>k__BackingField - 3;
					bool flag3 = (nint)obj < 0;
					object obj2 = rank.<Rank>k__BackingField ^ PlayerRank.Ranks.Advanced;
					object obj3 = rank.<Rank>k__BackingField ^ obj;
					object obj4 = obj2 & obj3;
					bool flag4 = (nint)obj4 < 0;
					bool flag5 = flag3 == flag4;
					bool flag6 = !flag5;
					result = flag6;
				}
				return result;
			}
			return false;
		}
	}

	public List<Games> AvailableGames
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00db: Expected O, but got I4
			//IL_0173: Expected O, but got I
			//IL_0183: Expected O, but got I
			//IL_01a5: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0113: Expected O, but got I
			//IL_0124: Expected I, but got O
			//IL_0142: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2440;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
			Func<object, System.Int32Enum> selector = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1312;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)1272;
				Func<object, System.Int32Enum> func = default(Func<object, System.Int32Enum>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<System.Int32Enum> source = Enumerable.Select(<Games>k__BackingField, selector);
			return (List<Games>)(object)Enumerable.ToList(source);
		}
	}

	public LastRequestUpdateModel LastRequestUpdates
	{
		get
		{
			return <LastRequestUpdates>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int FTPlayMoreTimer => <FTPlayMoreTimer>k__BackingField;

	public SFSConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LastRequestUpdateModel lastRequestUpdateModel = default(LastRequestUpdateModel);
		lastRequestUpdateModel..ctor();
		object obj2 = this + 72;
		obj2 = lastRequestUpdateModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<FTPlayMoreTimer>k__BackingField = 20;
		base..ctor();
	}

	public SFSConfig(ServerConfiguration server)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LastRequestUpdateModel lastRequestUpdateModel = default(LastRequestUpdateModel);
		lastRequestUpdateModel..ctor();
		object obj2 = this + 72;
		obj2 = lastRequestUpdateModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<FTPlayMoreTimer>k__BackingField = 20;
		base..ctor();
		object obj3 = this + 16;
		obj3 = server.<ID>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 24;
		obj4 = server.<Name>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<MaxUsers>k__BackingField = server.<MaxUsers>k__BackingField;
		object obj5 = this + 40;
		obj5 = server.<IP>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = this + 64;
		obj6 = server.<Games>k__BackingField;
		_ = server.<Port>k__BackingField;
		_ = server.<IsMain>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetServerExtraConfigs(ISFSObject data)
	{
		//IL_0815: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_017d: Expected I, but got O
		//IL_018d: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_0223: Expected I, but got O
		//IL_01c8: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0269: Expected I, but got O
		//IL_0279: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_030f: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0474: Expected I, but got O
		//IL_0498: Expected O, but got I4
		//IL_0531: Expected I, but got O
		//IL_0541: Expected O, but got I
		//IL_02b4: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected O, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_057c: Expected O, but got I
		//IL_06ae: Expected O, but got I
		//IL_06be: Expected O, but got I
		//IL_06e0: Expected O, but got I4
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected O, but got Unknown
		//IL_0642: Expected O, but got I4
		//IL_064b: Expected O, but got I4
		//IL_065c: Expected O, but got I4
		//IL_0761: Expected O, but got I
		//IL_03d6: Expected O, but got I
		//IL_03e6: Expected O, but got I
		//IL_0408: Expected O, but got I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_0720: Expected O, but got I4
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07cd: Expected O, but got I4
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected O, but got Unknown
		//IL_093c: Expected O, but got I
		//IL_094d: Expected I, but got O
		//IL_096b: Expected O, but got I
		//IL_0750: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71CC]");
		nint num = 0;
		bool flag = data == null;
		LastRequestUpdateModel lastRequestUpdateModel = (LastRequestUpdateModel)152989696;
		object obj;
		object obj2;
		object obj5;
		if (!flag)
		{
			obj = typeof(System.IOAsyncCallback) + 976;
			obj2 = "destinationTimeZone" + 3488;
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v31-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 = obj4 + 16;
				obj3--;
				bool flag2 = (nint)obj3 != 1;
				obj4 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_00d4;
			}
			object obj6 = obj4 + 1;
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v320 @ X0_v60] (should have been resolved before IL gen)");
			object obj9 = default(object);
			bool flag3 = obj9 == null;
			obj5 = obj4;
			if (!flag3)
			{
				goto IL_016d;
			}
			return;
		}
		goto IL_04ae;
		IL_08bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v635 @ X0_v22] (should have been resolved before IL gen)");
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LastRequestUpdateModel lastRequestUpdateModel2 = default(LastRequestUpdateModel);
		ISFSObject data2 = default(ISFSObject);
		lastRequestUpdateModel2..ctor(data2);
		object obj11 = this + 72;
		obj11 = lastRequestUpdateModel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<GameConfiguration> list = <Games>k__BackingField;
		object obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2440;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj15 = 0;
		LastRequestUpdateModel lastRequestUpdateModel3 = lastRequestUpdateModel2;
		object obj16 = 0;
		LastRequestUpdateModel lastRequestUpdateModel4 = lastRequestUpdateModel2;
		object obj17 = obj12;
		object obj18 = obj13;
		List<GameConfiguration> list2 = <Games>k__BackingField;
		if (obj14 != null)
		{
			goto IL_03c6;
		}
		goto IL_068c;
		IL_0351:
		list = <Games>k__BackingField;
		obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2440;
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		obj16 = obj15;
		lastRequestUpdateModel4 = lastRequestUpdateModel3;
		obj17 = obj12;
		obj18 = obj13;
		list2 = <Games>k__BackingField;
		if (!flag5)
		{
			goto IL_03c6;
		}
		goto IL_068c;
		IL_068c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v10+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v11+10]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v11+10]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		IEnumerable<object> enumerable = list2;
		IEnumerable<object> source = list2;
		if (obj20 == null)
		{
			goto IL_06fe;
		}
		goto IL_0755;
		IL_03c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v10+B8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v11+10]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v11+10]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		source = list;
		if (obj21 == null)
		{
			obj16 = obj15;
			lastRequestUpdateModel4 = lastRequestUpdateModel3;
			obj17 = obj12;
			enumerable = list;
			goto IL_06fe;
		}
		goto IL_0755;
		IL_0755:
		object obj22 = (nint)0 + (nint)832;
		object obj23 = Enumerable.FirstOrDefault(source, predicate);
		if (obj23 != null)
		{
			object obj24 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v6+E4]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v5 (System.Object)+10]");
			Preferences.CurrentGame = global::Games.Baloot;
		}
		return;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X0_v57] (should have been resolved before IL gen)");
		object obj27 = default(object);
		bool flag9 = obj27 == null;
		object obj28 = !flag9;
		if (obj28 == null)
		{
			return;
		}
		goto IL_016d;
		IL_016d:
		lastRequestUpdateModel = (LastRequestUpdateModel)obj2;
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0211;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v39 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v26-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 = obj30 + 16;
			obj29--;
			bool flag10 = (nint)obj29 != 1;
			obj30 = obj5;
			if (flag10)
			{
				continue;
			}
			goto IL_0211;
		}
		object obj31 = obj30 + 29;
		object obj32 = num3 + obj31;
		object obj33 = obj32 + 312;
		num = (nint)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v661 @ X0_v53] (should have been resolved before IL gen)");
		ISFSObject iSFSObject = default(ISFSObject);
		bool flag11 = iSFSObject == null;
		object obj34 = !flag11;
		obj5 = obj30;
		if (obj34 != null)
		{
			goto IL_024a;
		}
		goto IL_04ae;
		IL_02f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v46+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v712 @ X0_v46] (should have been resolved before IL gen)");
		object obj35 = default(object);
		bool flag12 = obj35 == null;
		object obj36 = !flag12;
		lastRequestUpdateModel3 = lastRequestUpdateModel;
		ISFSObject iSFSObject2 = iSFSObject;
		if (obj36 == null)
		{
			goto IL_0351;
		}
		goto IL_0529;
		IL_0529:
		nint num4 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05bd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj38 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X10_v10-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj38 += 16;
			obj37--;
			if ((nint)obj37 != 1)
			{
				continue;
			}
			goto IL_05bd;
		}
		object obj39 = obj38 + 29;
		object obj40 = num4 + obj39;
		object obj41 = obj40 + 312;
		goto IL_08bb;
		IL_05bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08bb;
		IL_06fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v10+E4]");
		bool flag13 = (nint)0 == 0;
		object obj42 = !flag13;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj43 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v17+B8]");
			obj19 = 0;
		}
		object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)1264;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj19, (IntPtr)obj45);
		object obj46 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v16+B8]");
		object obj47 = (nint)0 + (nint)16;
		obj47 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		source = enumerable;
		predicate = func;
		goto IL_0755;
		IL_0211:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj48 = default(object);
		num = (nint)obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v519 @ X0_v50] (should have been resolved before IL gen)");
		if (iSFSObject != null)
		{
			goto IL_024a;
		}
		goto IL_04ae;
		IL_04ae:
		iSFSObject2 = data;
		throw new NullReferenceException();
		IL_024a:
		obj2 = "java.io.FileOutputStream" + 3472;
		lastRequestUpdateModel = (LastRequestUpdateModel)obj2;
		num = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02f5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v23-8]");
			bool flag14 = 0 == (nint)obj;
			iSFSObject2 = iSFSObject;
			if (flag14)
			{
				break;
			}
			obj5 += 16;
			obj49--;
			if ((nint)obj49 != 1)
			{
				continue;
			}
			goto IL_02f5;
		}
		object obj50 = obj5 + 1;
		object obj51 = num + obj50;
		object obj52 = obj51 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v35+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ X0_v35] (should have been resolved before IL gen)");
		object obj53 = default(object);
		bool flag15 = obj53 == null;
		lastRequestUpdateModel3 = lastRequestUpdateModel;
		if (flag15)
		{
			goto IL_0351;
		}
		goto IL_0529;
	}
}
