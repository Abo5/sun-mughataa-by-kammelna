using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine.TextCore;

namespace Kammelna.Server.WebRequests;

public sealed class TestSupportClientContext : IClientContext
{
	public const string TestKeyHeader = "X-Kammelna-Test-Key";

	private readonly IClientContext _inner;

	private readonly string _testKey;

	public Games Game
	{
		get
		{
			//IL_00f4: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			nint num;
			object obj3 = default(object);
			if (_inner != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
				num = (nint)inner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
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
				goto IL_00c1;
			}
			goto IL_00e6;
			IL_00e6:
			NullReferenceException ex = new NullReferenceException();
			return (Games)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v86 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_00c1;
			IL_00c1:
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v147 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_00e6;
		}
	}

	public string Version
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			nint num;
			object obj3 = default(object);
			if (_inner != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
				num = (nint)inner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
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
				goto IL_00c1;
			}
			goto IL_00f4;
			IL_00f4:
			return (string)(object)new NullReferenceException();
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v86 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_00c1;
			IL_00c1:
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v148 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_00f4;
		}
	}

	public Platform Platform
	{
		get
		{
			//IL_0102: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			nint num;
			object obj3 = default(object);
			if (_inner != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
				num = (nint)inner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
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
				goto IL_00c1;
			}
			goto IL_00f4;
			IL_00f4:
			NullReferenceException ex = new NullReferenceException();
			return (Platform)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v86 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_00c1;
			IL_00c1:
			object obj4 = obj3 + 2;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v148 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_00f4;
		}
	}

	public GameType? GameType
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			nint num;
			object obj3 = default(object);
			if (_inner != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
				num = (nint)inner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
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
				goto IL_00c1;
			}
			goto IL_00f4;
			IL_00f4:
			return (GameType?)new NullReferenceException();
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v86 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_00c1;
			IL_00c1:
			object obj4 = obj3 + 3;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v148 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_00f4;
		}
	}

	public long? TournamentId
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			nint num;
			object obj3 = default(object);
			if (_inner != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
				num = (nint)inner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
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
				goto IL_00c1;
			}
			goto IL_00f4;
			IL_00f4:
			return (long?)new NullReferenceException();
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v86 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_00c1;
			IL_00c1:
			object obj4 = obj3 + 4;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v148 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_00f4;
		}
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0135: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
			nint num = (nint)inner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v5-8]");
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
			object obj4 = obj3 + 5;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_011d;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_011d;
			IL_011d:
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v3+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public TournamentType? TournamentType
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			nint num;
			object obj3 = default(object);
			if (_inner != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
				num = (nint)inner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
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
				goto IL_00c1;
			}
			goto IL_00f4;
			IL_00f4:
			return (TournamentType?)new NullReferenceException();
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v86 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_00c1;
			IL_00c1:
			object obj4 = obj3 + 6;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v148 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_00f4;
		}
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0135: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			IClientContext inner = _inner;
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
			nint num = (nint)inner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
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
			object obj4 = obj3 + 7;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_011d;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_011d;
			IL_011d:
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v3+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public TestSupportClientContext(string testKey)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = this + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj4 = this + 24;
		obj4 = testKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public IEnumerable<(string, string)> GetRequestHeaders()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_01c1: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		IClientContext inner = _inner;
		object item;
		if (_inner != null)
		{
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1552;
			item = "WhiteSmoke" + 616;
			nint num = (nint)inner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IClientContext>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v5-8]");
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
				goto IL_00bc;
			}
			object obj4 = obj3 + 8;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0190;
		}
		return (IEnumerable<(string, string)>)new NullReferenceException();
		IL_0190:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ X0_v3] (should have been resolved before IL gen)");
		object item2 = _testKey;
		bool flag = _testKey == null;
		object obj7 = !flag;
		if (obj7 == null)
		{
			object obj8 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v10+90]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v11+B8]");
			object obj10 = 0;
			item2 = obj10;
		}
		(object, object) tuple = (item, item2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D7BC68");
		IEnumerable<(string, string)> result = default(IEnumerable<(string, string)>);
		return result;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0190;
	}
}
