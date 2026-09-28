using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;

public class BalootPlayer : CardGamePlayer
{
	private List<string> <DeclaredProjects>k__BackingField;

	private List<Card> <ProjectsCards>k__BackingField;

	public List<string> DeclaredProjects
	{
		get
		{
			return <DeclaredProjects>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Card> ProjectsCards
	{
		get
		{
			return <ProjectsCards>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsRoundDoubler
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0241: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_027b: Expected O, but got I4
			//IL_02a5: Expected I4, but got O
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			//IL_00bc: Expected I, but got O
			//IL_00e5: Expected O, but got I4
			//IL_0119: Expected O, but got I
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected O, but got Unknown
			//IL_0185: Expected O, but got I4
			//IL_01b9: Expected O, but got I
			//IL_01f7: Expected O, but got I
			object obj = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD3]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_006f;
				}
			}
			_ = 1;
			KGame kGame = ((KPlayer)this).<Game>k__BackingField;
			bool flag2 = (object)((KPlayer)this).<Game>k__BackingField == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_0098;
			}
			goto IL_0289;
			IL_0297:
			InvalidCastException ex = new InvalidCastException();
			return (byte)(int)ex != 0;
			IL_0098:
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj8 = obj7;
			nint num = (nint)kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2 (Il2CppClass<KGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X1_v2+130]");
			bool flag3 = num2 < 0;
			object obj9 = !flag3;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2 (Il2CppClass<KGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X1_v2+130]");
				object obj11 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X10_v3-8]");
				if (0 == (nint)obj8)
				{
					object obj12 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2 (Il2CppClass<KGame>)+130]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X1_v3+130]");
					bool flag4 = num4 < 0;
					object obj14 = !flag4;
					object obj15 = ~obj14;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2 (Il2CppClass<KGame>)+C8]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X1_v3+130]");
						object obj16 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v12-8]");
						if (0 == (nint)obj13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13 (KGame)+180]");
							object obj17 = -((KPlayer)this).<Index>k__BackingField;
							return obj17 == null;
						}
					}
				}
			}
			goto IL_0297;
			IL_0289:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0297;
			IL_006f:
			kGame = ((KPlayer)this).<Game>k__BackingField;
			if ((object)((KPlayer)this).<Game>k__BackingField != null)
			{
				goto IL_0098;
			}
			goto IL_0289;
		}
	}

	public new BalootGame Game
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00df: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_0049: Expected O, but got I
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			//IL_014a: Expected I, but got O
			//IL_0173: Expected O, but got I4
			//IL_01a7: Expected O, but got I
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_0213: Expected O, but got I4
			//IL_0247: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD3]");
			object obj = (nint)0 & (nint)1;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					goto IL_0066;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8ADD]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0066;
				}
			}
			_ = 1;
			BalootGame balootGame = (BalootGame)((KPlayer)this).<Game>k__BackingField;
			bool flag2 = (object)((KPlayer)this).<Game>k__BackingField == null;
			BalootGame result = (BalootGame)((KPlayer)this).<Game>k__BackingField;
			if (!flag2)
			{
				goto IL_0126;
			}
			goto IL_0276;
			IL_0276:
			return result;
			IL_0126:
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj6 = obj5;
			nint num = (nint)balootGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v2+130]");
			bool flag3 = num2 < 0;
			object obj7 = !flag3;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v2+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X10_v4-8]");
				if (0 == (nint)obj6)
				{
					object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+130]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X1_v4+130]");
					bool flag4 = num4 < 0;
					object obj12 = !flag4;
					object obj13 = ~obj12;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+C8]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X1_v4+130]");
						object obj14 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8-8]");
						bool flag5 = 0 != (nint)obj11;
						result = balootGame;
						if (!flag5)
						{
							goto IL_0276;
						}
					}
				}
			}
			return (BalootGame)(object)new InvalidCastException();
			IL_0066:
			balootGame = (BalootGame)((KPlayer)this).<Game>k__BackingField;
			bool flag6 = (object)((KPlayer)this).<Game>k__BackingField == null;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				goto IL_0126;
			}
			result = (BalootGame)((KPlayer)this).<Game>k__BackingField;
			goto IL_0276;
		}
	}

	public BalootPlayer(BalootGame game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+B8]");
		object obj3 = 0;
		object obj4 = this + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base._showCards = true;
		base..ctor((KGame)game);
	}

	protected override void UpdatePlayerState(ISFSObject response)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_0380: Expected O, but got I
		//IL_007b: Expected O, but got I
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
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0265: Expected I, but got O
		//IL_0275: Expected O, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0132: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_0477: Expected O, but got I4
		//IL_02b0: Expected O, but got I
		//IL_03fb: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		base.UpdatePlayerState(response);
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 816;
		nint num = (nint)response;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v19-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00bc;
		}
		object obj5 = obj4 + 28;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_0370;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = default(object);
		object obj8 = obj9;
		goto IL_03eb;
		IL_021a:
		object obj10 = "placementId" + 536;
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		BalootPlayer balootPlayer;
		object obj12 = balootPlayer + 112;
		List<object> list;
		obj12 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num2 = (nint)response;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02f1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_02f1;
		}
		object obj15 = obj14 + 28;
		object obj16 = num2 + obj15;
		object obj17 = obj16 + 312;
		goto IL_0443;
		IL_02f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0443;
		IL_0443:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X0_v11] (should have been resolved before IL gen)");
		object obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj19 = !flag;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int index = ((KPlayer)this).<Index>k__BackingField - 1;
		ISFSArray data = default(ISFSArray);
		List<Card> list2 = CardUtils.DecodeCards(data, index);
		object obj20 = this + 120;
		obj20 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0370;
		IL_0370:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v5+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v5] (should have been resolved before IL gen)");
		object obj22 = default(object);
		balootPlayer = ((obj22 != null) ? this : null);
		if (obj22 != null)
		{
			object obj23 = typeof(System.IOAsyncCallback) + 960;
			object obj24 = ((KPlayer)this).<Index>k__BackingField - 1;
			object obj25 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v17+12E]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v17+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01c6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v17+B0]");
			object obj27 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X10_v14-8]");
				if (0 == (nint)obj23)
				{
					break;
				}
				obj27 += 16;
				obj26--;
				if ((nint)obj26 != 1)
				{
					continue;
				}
				goto IL_01c6;
			}
			object obj28 = obj27 + 49;
			object obj29 = obj25 + obj28;
			obj8 = obj29 + 312;
			goto IL_03eb;
		}
		list = null;
		balootPlayer = this;
		goto IL_021a;
		IL_03eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v18+8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X8_v18] (should have been resolved before IL gen)");
		IEnumerable<object> source = default(IEnumerable<object>);
		List<object> list3 = Enumerable.ToList(source);
		list = list3;
		goto IL_021a;
	}
}
