using System;
using Cpp2ILInjected;
using UnityEngine.Purchasing.Telemetry;

namespace Server.Models;

public class FriendlyChallengeConfig
{
	private bool <Enabled>k__BackingField;

	private int <FixedFee>k__BackingField;

	private TournamentConfig.PrizeCondition <PrizeCondition>k__BackingField;

	private int <MinimumPrize>k__BackingField;

	private float <PercentageFee>k__BackingField;

	private int <MaxScore>k__BackingField;

	private int <BestOf>k__BackingField;

	private long <ScoreLifetimeSeconds>k__BackingField;

	private long <LockDurationSeconds>k__BackingField;

	public bool Enabled
	{
		get
		{
			return <Enabled>k__BackingField;
		}
		set
		{
			<Enabled>k__BackingField = value;
		}
	}

	public int FixedFee
	{
		get
		{
			return <FixedFee>k__BackingField;
		}
		set
		{
			<FixedFee>k__BackingField = value;
		}
	}

	public TournamentConfig.PrizeCondition PrizeCondition
	{
		get
		{
			return <PrizeCondition>k__BackingField;
		}
		set
		{
			<PrizeCondition>k__BackingField = value;
		}
	}

	public int MinimumPrize
	{
		get
		{
			return <MinimumPrize>k__BackingField;
		}
		set
		{
			<MinimumPrize>k__BackingField = value;
		}
	}

	public float PercentageFee
	{
		get
		{
			return <PercentageFee>k__BackingField;
		}
		set
		{
			<PercentageFee>k__BackingField = value;
		}
	}

	public int MaxScore
	{
		get
		{
			return <MaxScore>k__BackingField;
		}
		set
		{
			<MaxScore>k__BackingField = value;
		}
	}

	public int BestOf
	{
		get
		{
			return <BestOf>k__BackingField;
		}
		set
		{
			<BestOf>k__BackingField = value;
		}
	}

	private long ScoreLifetimeSeconds
	{
		get
		{
			return <ScoreLifetimeSeconds>k__BackingField;
		}
		set
		{
			<ScoreLifetimeSeconds>k__BackingField = value;
		}
	}

	private long LockDurationSeconds
	{
		get
		{
			return <LockDurationSeconds>k__BackingField;
		}
		set
		{
			<LockDurationSeconds>k__BackingField = value;
		}
	}

	public TimeSpan ScoreLifetime
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_00d4: Expected F8, but got I8
			//IL_00de: Expected F8, but got I8
			//IL_0070: Expected F8, but got I8
			//IL_007a: Expected F8, but got I8
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B9E]");
			object obj2 = (nint)0 & (nint)1;
			double value;
			double value2;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				value = <ScoreLifetimeSeconds>k__BackingField;
				value2 = <ScoreLifetimeSeconds>k__BackingField;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				value = <ScoreLifetimeSeconds>k__BackingField;
				value2 = <ScoreLifetimeSeconds>k__BackingField;
				if (obj4 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return TimeSpan.FromSeconds(value2);
			IL_0088:
			return TimeSpan.FromSeconds(value);
		}
	}

	public TimeSpan LockDuration
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_00d4: Expected F8, but got I8
			//IL_00de: Expected F8, but got I8
			//IL_0070: Expected F8, but got I8
			//IL_007a: Expected F8, but got I8
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B9F]");
			object obj2 = (nint)0 & (nint)1;
			double value;
			double value2;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				value = <LockDurationSeconds>k__BackingField;
				value2 = <LockDurationSeconds>k__BackingField;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				value = <LockDurationSeconds>k__BackingField;
				value2 = <LockDurationSeconds>k__BackingField;
				if (obj4 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return TimeSpan.FromSeconds(value2);
			IL_0088:
			return TimeSpan.FromSeconds(value);
		}
	}

	public FriendlyChallengeConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00cf: Expected I4, but got I8
		//IL_010b: Expected O, but got I4
		//IL_0059: Invalid comparison between F8 and I8
		//IL_0123: Expected I8, but got F8
		//IL_014f: Invalid comparison between F8 and I8
		//IL_007d: Expected F8, but got I8
		//IL_0170: Expected I8, but got F8
		//IL_009c: Expected F8, but got I8
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531D8]");
		<FixedFee>k__BackingField = 0;
		<MinimumPrize>k__BackingField = 1000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [71755D8]");
		<MaxScore>k__BackingField = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromDays(4.000000000698492);
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		<ScoreLifetimeSeconds>k__BackingField = (long)((totalSeconds != 9.218868437227405E+18) ? totalSeconds : (-9.223372036854776E+18));
		TimeSpan timeSpan3 = TimeSpan.FromDays(4.000000000698492);
		double totalSeconds2 = timeSpan2.TotalSeconds;
		<LockDurationSeconds>k__BackingField = (long)((totalSeconds2 != 9.218868437227405E+18) ? totalSeconds2 : (-9.223372036854776E+18));
		base..ctor();
	}
}
