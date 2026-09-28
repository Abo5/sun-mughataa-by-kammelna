using System;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

public static class PrizeTypeExtensions
{
	public static bool ShouldSplitBetweenWinners(TournamentPrizeType prizeType)
	{
		//IL_000e: Expected O, but got I4
		object obj = prizeType - 2;
		return obj == null;
	}

	public static string GetName(TournamentPrizeType prizeType)
	{
		//IL_013f: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0013: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0114: Expected O, but got I
		//IL_004d: Expected O, but got I4
		//IL_005d: Expected O, but got I
		object obj = prizeType - 1;
		bool flag = (nint)obj < 9;
		object obj2 = !flag;
		object obj3 = obj - 9;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 783 >> (int)obj;
			object obj7 = obj6 & 1;
			if (obj7 != null)
			{
				object obj8 = 139821056 + 3216;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v5+v43 @ X8_v3*8]");
				return (string)0;
			}
		}
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = "placementId" + 1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj12 = "Picking audio files is not supported on iOS" + 1920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		string message = default(string);
		ex..ctor(paramName, actualValue, message);
		object obj13 = (nint)0 + (nint)2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}
}
