using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class BalootGame : CardGame
{
	public enum BalootGameMode
	{
		NotDetermined,
		Sun,
		Hokom,
		Ashkal
	}

	public enum BalootExtraGameMode
	{
		NotDetermined,
		Double,
		Triple,
		Four,
		Qahwa
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<BalootProject, int> <>9__56_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <PlayCard>b__56_0(BalootProject project)
		{
			return BalootProjectMethods.ServerValue(project);
		}
	}

	public const string DECLARED_PROJECTS = "dp";

	public const string PROJECTS_CARDS = "prcs";

	public const string GAME_MODE = "gm";

	public const string GAME_EXTRA_MODE = "gem";

	public const string HOKOM_CLOSE = "hc";

	public const string FLOOR_CARD = "fc";

	public const string ROUND_DOUPLER = "rd";

	public const string DECLARE_EKKA = "de";

	private Action<bool> m_OnEkkaDeclarationChanged;

	private BalootGameMode <GameMode>k__BackingField;

	private BalootExtraGameMode <ExtraGameMode>k__BackingField;

	private int <RoundDoubler>k__BackingField;

	private bool <IsHokomClosed>k__BackingField;

	private Card <FloorCard>k__BackingField;

	private ICardGameScores _balootScores;

	private ICardUtils _cardUtils;

	private readonly List<BalootProject> <ProjectsToDeclare>k__BackingField;

	private bool _isEkkaToBeDeclared;

	public new BalootPlayer MyPlayer
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_00c1: Expected O, but got I
			//IL_00db: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_0049: Expected O, but got I
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			//IL_0147: Expected I, but got O
			//IL_0170: Expected O, but got I4
			//IL_01a4: Expected O, but got I
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected O, but got Unknown
			//IL_0210: Expected O, but got I4
			//IL_0244: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AC8]");
			object obj = (nint)0 & (nint)1;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD8]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					goto IL_0066;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD8]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0066;
				}
			}
			_ = 1;
			KPlayer myPlayer = ((KGame)this).MyPlayer;
			bool flag2 = myPlayer == null;
			BalootPlayer result = (BalootPlayer)myPlayer;
			if (!flag2)
			{
				goto IL_0123;
			}
			goto IL_0273;
			IL_0273:
			return result;
			IL_0123:
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
			object obj6 = obj5;
			nint num = (nint)myPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v2 (Il2CppClass<KPlayer>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X1_v3+130]");
			bool flag3 = num2 < 0;
			object obj7 = !flag3;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v2 (Il2CppClass<KPlayer>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X1_v3+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v4-8]");
				if (0 == (nint)obj6)
				{
					object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v2 (Il2CppClass<KPlayer>)+130]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X1_v5+130]");
					bool flag4 = num4 < 0;
					object obj12 = !flag4;
					object obj13 = ~obj12;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v2 (Il2CppClass<KPlayer>)+C8]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X1_v5+130]");
						object obj14 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8-8]");
						bool flag5 = 0 != (nint)obj11;
						result = (BalootPlayer)myPlayer;
						if (!flag5)
						{
							goto IL_0273;
						}
					}
				}
			}
			return (BalootPlayer)(object)new InvalidCastException();
			IL_0066:
			myPlayer = ((KGame)this).MyPlayer;
			bool flag6 = myPlayer == null;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				goto IL_0123;
			}
			result = (BalootPlayer)myPlayer;
			goto IL_0273;
		}
	}

	public new BalootPlayer MyTeammate
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected O, but got Unknown
			//IL_00f2: Expected O, but got I4
			//IL_0126: Expected O, but got I
			int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(((KGame)this).<MySeatIndex>k__BackingField, 2, 1, 5);
			BalootPlayer playerByIndex = (BalootPlayer)GetPlayerByIndex(rotatedNextIndex);
			if (playerByIndex != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
				object obj2 = obj;
				nint num = (nint)playerByIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v2 (Il2CppClass<BalootPlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X1_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v2 (Il2CppClass<BalootPlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X1_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
					if (0 == (nint)obj2)
					{
						object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v2 (Il2CppClass<BalootPlayer>)+130]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X1_v6+130]");
						bool flag2 = num4 < 0;
						object obj8 = !flag2;
						object obj9 = ~obj8;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v2 (Il2CppClass<BalootPlayer>)+C8]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X1_v6+130]");
							object obj10 = num5 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10-8]");
							if (0 == (nint)obj7)
							{
								goto IL_014d;
							}
						}
					}
				}
				return (BalootPlayer)(object)new InvalidCastException();
			}
			goto IL_014d;
			IL_014d:
			return playerByIndex;
		}
	}

	public BalootGameMode GameMode
	{
		get
		{
			return <GameMode>k__BackingField;
		}
		private set
		{
			<GameMode>k__BackingField = value;
		}
	}

	public BalootExtraGameMode ExtraGameMode
	{
		get
		{
			return <ExtraGameMode>k__BackingField;
		}
		private set
		{
			<ExtraGameMode>k__BackingField = value;
		}
	}

	public int RoundDoubler
	{
		get
		{
			return <RoundDoubler>k__BackingField;
		}
		private set
		{
			<RoundDoubler>k__BackingField = value;
		}
	}

	public bool IsHokomClosed
	{
		get
		{
			return <IsHokomClosed>k__BackingField;
		}
		private set
		{
			<IsHokomClosed>k__BackingField = value;
		}
	}

	public Card FloorCard
	{
		get
		{
			return <FloorCard>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<FloorCard>k__BackingField = value;
			object obj = this + 392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public override IGameScores GameScores => _balootScores;

	public override ICardUtils GameCardUtils => _cardUtils;

	public bool IsSun
	{
		get
		{
			//IL_0014: Expected O, but got I8
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			object obj = (long)<GameMode>k__BackingField & 0xFFFFFFFDL;
			object obj2 = obj - 1;
			return obj2 == null;
		}
	}

	public bool IsHokom
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <GameMode>k__BackingField - 2;
			return obj == null;
		}
	}

	public List<BalootProject> ProjectsToDeclare => <ProjectsToDeclare>k__BackingField;

	public bool IsEkkaToBeDeclared
	{
		get
		{
			return _isEkkaToBeDeclared;
		}
		private set
		{
			bool flag = default(bool);
			_isEkkaToBeDeclared = flag;
			Actions.SafeInvoke(this.OnEkkaDeclarationChanged, flag);
		}
	}

	public event Action<bool> OnEkkaDeclarationChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Delegate obj2 = this.m_OnEkkaDeclarationChanged;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 368;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Delegate obj2 = this.m_OnEkkaDeclarationChanged;
			object obj5 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				if ((object)obj3 == null)
				{
					object obj4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj4 = obj5;
					if (obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj7 = this + 368;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj2;
				obj2 = obj8;
			}
			while (!flag2);
		}
	}

	protected override void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_046a: Expected O, but got I4
		//IL_0589: Expected O, but got I
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I
		//IL_004c: Expected I, but got O
		//IL_005c: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_04a2: Expected O, but got I4
		//IL_05d6: Expected O, but got I
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05f4: Expected O, but got I
		//IL_0616: Expected I, but got O
		//IL_0626: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_0130: Expected O, but got I8
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_04da: Expected O, but got I4
		//IL_0645: Expected O, but got I
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected O, but got Unknown
		//IL_0663: Expected O, but got I
		//IL_0685: Expected I, but got O
		//IL_0695: Expected O, but got I
		//IL_01b0: Expected O, but got I4
		//IL_01da: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0512: Expected O, but got I4
		//IL_06b4: Expected O, but got I
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_06d2: Expected O, but got I
		//IL_06f4: Expected I, but got O
		//IL_0704: Expected O, but got I
		//IL_0280: Expected O, but got I4
		//IL_02a2: Expected O, but got I8
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_056b: Expected O, but got I4
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1768;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+B8]");
		object obj6 = 0;
		KPlayer kPlayer = default(KPlayer);
		object obj7 = kPlayer + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		kPlayer..ctor(this);
		KPlayer[] array = default(KPlayer[]);
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9 (Il2CppClass<KPlayer[]>)+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj9 = default(object);
		bool flag2 = obj9 == null;
		object obj10 = 0;
		if (flag2)
		{
			goto IL_03e6;
		}
		if (array.Length != 0)
		{
			object obj11 = array + 32;
			obj11 = kPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v29+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v29+B8]");
			object obj14 = 0;
			KPlayer kPlayer2 = default(KPlayer);
			object obj15 = kPlayer2 + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v16+8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			kPlayer2..ctor(this);
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v18 (Il2CppClass<KPlayer[]>)+40]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag4 = obj9 == null;
			obj10 = 0;
			if (flag4)
			{
				goto IL_03e6;
			}
			object obj16 = array.Length & 0xFFFFFFFEL;
			if (obj16 != null)
			{
				object obj17 = array + 40;
				obj17 = kPlayer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v43+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v43+B8]");
				object obj20 = 0;
				KPlayer kPlayer3 = default(KPlayer);
				object obj21 = kPlayer3 + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v23+8]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				kPlayer3..ctor(this);
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v25 (Il2CppClass<KPlayer[]>)+40]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag6 = obj9 == null;
				obj10 = 0;
				if (flag6)
				{
					goto IL_03e6;
				}
				bool flag7 = array.Length < 2;
				object obj22 = !flag7;
				object obj23 = array.Length - 2;
				bool flag8 = obj23 == null;
				object obj24 = ~obj22;
				object obj25 = obj24 | flag8;
				if (obj25 == null)
				{
					object obj26 = array + 48;
					obj26 = kPlayer3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj27 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v57+E4]");
					bool flag9 = (nint)0 == 0;
					object obj28 = !flag9;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj27 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v57+B8]");
					object obj29 = 0;
					KPlayer kPlayer4 = default(KPlayer);
					object obj30 = kPlayer4 + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v30+8]");
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					kPlayer4..ctor(this);
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v32 (Il2CppClass<KPlayer[]>)+40]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag10 = obj9 == null;
					obj10 = 0;
					if (flag10)
					{
						goto IL_03e6;
					}
					object obj31 = array.Length & 0xFFFFFFFCL;
					if (obj31 != null)
					{
						object obj32 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2064;
						object obj33 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
						object obj34 = array + 56;
						obj34 = kPlayer4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						players = array;
						object obj35 = this + 256;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj36 = typeof(List<AdaptivePerformanceScaler>) + 1416;
						object obj37 = default(object);
						obj37..ctor();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						List<object> list = default(List<object>);
						list..ctor();
						object obj38 = obj37 + 16;
						obj38 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_balootScores = (ICardGameScores)obj37;
						object obj39 = this + 400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj40 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v83+E4]");
						bool flag11 = (nint)0 == 0;
						object obj41 = !flag11;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						CardUtils cardUtils = default(CardUtils);
						cardUtils..ctor((CardGame)this);
						_cardUtils = cardUtils;
						object obj42 = this + 408;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						((KGame)this).Init();
						return;
					}
				}
			}
		}
		goto IL_03fe;
		IL_03e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_03fe;
		IL_03fe:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	protected override void UpdateGameState(ISFSObject gameState)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0106: Expected I4, but got I8
		//IL_0134: Expected O, but got I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		object varName = "getSecondRescanTask" + 1696;
		object defaultValue = (nint)0 + (nint)2000;
		base.UpdateGameState(gameState);
		string text = SFSExtensions.Get(gameState, (string)varName, (string)defaultValue);
		object obj = "startPosition" + 1360;
		object varName2 = "fetch_products" + 2528;
		object varName3 = "getSecondRescanTask" + 2536;
		object varName4 = "destinationTimeZone" + 3904;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		BalootGameMode balootGameMode;
		if (text == (string)obj)
		{
			balootGameMode = BalootGameMode.Sun;
		}
		else
		{
			object obj3 = "getSecondRescanTask" + 3048;
			if (text == (string)obj3)
			{
				balootGameMode = BalootGameMode.Hokom;
			}
			else
			{
				object obj4 = "alignContent" + 2784;
				bool flag = text == (string)obj4;
				bool flag2 = !flag;
				object obj5 = !flag2;
				object obj6 = ~obj5;
				balootGameMode = ((obj6 == null) ? BalootGameMode.Ashkal : BalootGameMode.NotDetermined);
			}
		}
		object varName5 = "placementId" + 2368;
		<GameMode>k__BackingField = balootGameMode;
		string serverString = SFSExtensions.Get(gameState, (string)varName2, (string)defaultValue);
		BalootExtraGameMode balootExtraGameMode = ExtraGameModeFromString(serverString);
		<ExtraGameMode>k__BackingField = balootExtraGameMode;
		bool flag3 = SFSExtensions.Get(gameState, (string)varName3, defaultValue: false);
		<IsHokomClosed>k__BackingField = flag3;
		int intRepresentation = SFSExtensions.Get(gameState, (string)varName4, -1);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Card card = CardUtils.FromInt(intRepresentation);
		<FloorCard>k__BackingField = card;
		object obj9 = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = SFSExtensions.Get(gameState, (string)varName5, 0);
		<RoundDoubler>k__BackingField = num;
	}

	public override void PlayCard(CardGamePlayer player, Card card, int? gameActionItemId = null)
	{
		//IL_04cc: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_00af: Expected O, but got I
		//IL_00bf: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_0101: Expected O, but got I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0240: Expected I, but got O
		//IL_0250: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0521: Expected O, but got I
		//IL_0532: Expected I, but got O
		//IL_0550: Expected O, but got I
		//IL_0573: Expected O, but got I4
		//IL_028b: Expected O, but got I
		//IL_01f8: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_037a: Expected I, but got O
		//IL_038a: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_03c5: Expected O, but got I
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		nint num = (nint)this;
		CardGamePlayer player2 = default(CardGamePlayer);
		if (!base.CanPlayCard(player2, card))
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		string val = card.ToString();
		object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2400;
		SFSExtensions.Put(sFSObject, (string)key, val);
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2584;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v43+E4]");
		object obj4;
		Func<System.Int32Enum, int> selector;
		object obj9;
		object obj8;
		object obj6;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v43+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v42+8]");
			selector = (Func<System.Int32Enum, int>)0;
			object obj5 = "placementId" + 1024;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v42+8]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			obj8 = 0;
			if (obj7 == null)
			{
				obj9 = obj5;
				goto IL_01a6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v43+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v42+8]");
			selector = (Func<System.Int32Enum, int>)0;
			object obj10 = "placementId" + 1024;
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v42+8]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			obj8 = 0;
			obj6 = obj10;
			if (obj11 == null)
			{
				goto IL_01a6;
			}
		}
		goto IL_01fd;
		IL_01fd:
		IEnumerable<int> source = Enumerable.Select((IEnumerable<System.Int32Enum>)<ProjectsToDeclare>k__BackingField, selector);
		int[] array = Enumerable.ToArray(source);
		object obj12 = typeof(System.IOAsyncCallback) + 976;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02cc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X10_v14-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_02cc;
		}
		object obj15 = obj14 + 44;
		object obj16 = num2 + obj15;
		object obj17 = obj16 + 312;
		goto IL_05a4;
		IL_0603:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v558 @ X0_v34] (should have been resolved before IL gen)");
		goto IL_05bd;
		IL_05a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ X0_v17] (should have been resolved before IL gen)");
		List<BalootProject> list = <ProjectsToDeclare>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v20 (System.Collections.Generic.List`1<BalootProject>)+1C]");
		object obj18 = (nint)0 + (nint)1;
		_ = 0;
		object obj19 = (??)gameActionItemId & 1;
		if (obj19 == null)
		{
			goto IL_05bd;
		}
		int? num3 = default(int?);
		int value = num3.Value;
		object obj20 = "fetch_products" + 2336;
		nint num4 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v36 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v36 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0406;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v36 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X10_v9-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_0406;
		}
		object obj23 = obj22 + 35;
		object obj24 = num4 + obj23;
		object obj25 = obj24 + 312;
		goto IL_0603;
		IL_0406:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0603;
		IL_01a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v43+E4]");
		bool flag3 = (nint)0 == 0;
		object obj26 = !flag3;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v48+B8]");
			obj4 = 0;
		}
		object obj28 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)744;
		Func<System.Int32Enum, int> func = default(Func<System.Int32Enum, int>);
		func..ctor(obj4, (IntPtr)obj29);
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v47+B8]");
		object obj31 = (nint)0 + (nint)8;
		obj31 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		obj8 = 0;
		obj6 = obj9;
		goto IL_01fd;
		IL_02cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05a4;
		IL_05bd:
		if (<GameMode>k__BackingField == BalootGameMode.Hokom)
		{
			Room room = base.Room;
			if (SFSKammelnaRoomExtensions.IsCheatingAllowed(room) && _isEkkaToBeDeclared)
			{
				object key2 = "com.unity.services.authentication.profile" + 3384;
				SFSExtensions.Put(sFSObject, (string)key2, val: true);
			}
		}
		_isEkkaToBeDeclared = false;
		Actions.SafeInvoke(this.OnEkkaDeclarationChanged, arg: false);
		object command = "___# Content push apply failed [{0}]: {1}" + 2664;
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
	}

	public void ToggleEkkaDeclaration(bool isIkkaToBeDeclared)
	{
		bool flag = default(bool);
		_isEkkaToBeDeclared = flag;
		Actions.SafeInvoke(this.OnEkkaDeclarationChanged, flag);
	}

	public static BalootGameMode GameModeFromString(string serverString)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		object obj = "startPosition" + 1360;
		if (serverString == (string)obj)
		{
			return BalootGameMode.Sun;
		}
		object obj2 = "getSecondRescanTask" + 3048;
		if (serverString == (string)obj2)
		{
			return BalootGameMode.Hokom;
		}
		object obj3 = "alignContent" + 2784;
		bool flag = serverString == (string)obj3;
		bool flag2 = !flag;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return BalootGameMode.Ashkal;
		}
		return BalootGameMode.NotDetermined;
	}

	public static BalootExtraGameMode ExtraGameModeFromString(string serverString)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		object obj = "com.unity.services.authentication.profile" + 2776;
		if (serverString == (string)obj)
		{
			return BalootExtraGameMode.Double;
		}
		object obj2 = "startPosition" + 2136;
		if (serverString == (string)obj2)
		{
			return BalootExtraGameMode.Triple;
		}
		object obj3 = "destinationTimeZone" + 3544;
		if (serverString == (string)obj3)
		{
			return BalootExtraGameMode.Four;
		}
		object obj4 = "placementId" + 1856;
		bool flag = serverString == (string)obj4;
		bool flag2 = !flag;
		object obj5 = !flag2;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return BalootExtraGameMode.Qahwa;
		}
		return BalootExtraGameMode.NotDetermined;
	}

	protected override void EndGame(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Expected I, but got O
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1976;
		base.EndGame(data);
		Room room = base.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069DA8]");
		_ = 0;
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		nint num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ X8_v5 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
		Action<CardGameEndScores> onCardGameEnd = base.OnCardGameEnd;
		if (base.OnCardGameEnd != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ X8_v6 (System.Action`1<CardGameEndScores>)+18] (should have been resolved before IL gen)");
		}
		TrackEndGame((CardGameEndScores)obj2);
	}

	public override bool SpecialPlayAllowed(Card card)
	{
		//IL_0053: Expected O, but got I4
		if (card != null && <GameMode>k__BackingField == BalootGameMode.Hokom)
		{
			object obj = card.<Suit>k__BackingField - base.<TrumpSuit>k__BackingField;
			return obj == null;
		}
		return false;
	}

	public override int[] GetScores()
	{
		return null;
	}

	public BalootGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list = default(List<System.Int32Enum>);
		list..ctor();
		<ProjectsToDeclare>k__BackingField = (List<BalootProject>)(object)list;
		object obj2 = this + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		base.<Stage>k__BackingField = (CardGameStage)obj4;
		object obj5 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((KGame)this)..ctor();
	}
}
