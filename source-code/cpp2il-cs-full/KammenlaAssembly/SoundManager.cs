using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

internal class SoundManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass4_0
	{
		public SoundManager <>4__this;

		public SoundOptions options;

		internal void <PlaySoundsWithOptions>b__0(SingleSound s)
		{
			<>4__this.PlaySoundWithOptions(s, options);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public SoundManager <>4__this;

		public AudioClip clipToBePlayed;

		internal void <PlaySoundQueued>b__0()
		{
			SoundManager soundManager = <>4__this;
			soundManager._source.PlayOneShot(clipToBePlayed);
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public SingleSound clip;

		public SoundManager <>4__this;

		internal void <PlaySoundsQueued>b__0()
		{
			SoundManager soundManager = <>4__this;
			SingleSound singleSound = clip;
			soundManager._source.PlayOneShot(singleSound.clip);
		}
	}

	private AudioClip defaultClick;

	private DateTime _nextClipStartTime;

	private AudioSource _source;

	protected void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_023f: Expected I, but got O
		//IL_00a2: Expected I, but got O
		//IL_00c8: Expected I, but got O
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_025c: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_0104: Expected O, but got I
		object obj = (nint)0 + (nint)3608;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 680;
		object obj4 = (nint)0 + (nint)1752;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 176;
		object obj6 = (nint)0 + (nint)1760;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj9 = this + 48;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj4);
		SoundChannel.OnPlaySoundWithMode += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj6);
		SoundChannel.OnPlaySoundsWithMode += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1008;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+8]");
		Delegate obj16 = (Delegate)0;
		bool flag2;
		Delegate obj20 = default(Delegate);
		do
		{
			Delegate obj17 = Delegate.Combine(obj16, action3);
			if ((object)obj17 == null || obj17 == obj7)
			{
				object obj18 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v6+B8]");
				object obj19 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj20 == obj16;
				obj16 = obj20;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag2);
	}

	private void PlaySoundsWithOptions(SingleSound[] singleSound, SoundOptions options)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0097: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3424;
		object obj4 = (nint)0 + (nint)528;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = options;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(singleSound, action);
	}

	private void PlaySoundWithOptions(SingleSound singleSound, SoundOptions options)
	{
		//IL_0071: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I
		if (IsChannelMuted(options.channel))
		{
			return;
		}
		if (options.mode != SoundOptions.Mode.Queued)
		{
			bool flag = options.mode == SoundOptions.Mode.Instant;
			object obj = !flag;
			if (obj != null)
			{
				object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = "not" + 2016;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				SoundOptions actualValue = default(SoundOptions);
				ex..ctor(paramName, actualValue, null);
				object obj4 = (nint)0 + (nint)1752;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
			PlaySoundInstant(singleSound);
		}
		else
		{
			PlaySoundQueued(singleSound);
		}
	}

	private void PlaySoundInstant(SingleSound singleSound)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (singleSound == null)
		{
			object clip = this + 32;
			_source.PlayOneShot((AudioClip)clip);
		}
		else
		{
			object clip2 = singleSound + 24;
			_source.PlayOneShot((AudioClip)clip2);
		}
	}

	private void PlaySoundQueued(SingleSound clips)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		//IL_00fc: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0365: Expected O, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0224: Expected O, but got I4
		//IL_03a4: Expected I, but got O
		//IL_026b: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v9+E4]");
		object obj7;
		object obj6;
		if ((nint)0 != 0)
		{
			bool flag = clips == null;
			bool flag2 = !flag;
			obj6 = 0;
			obj7 = 0;
			if (!flag2)
			{
				goto IL_00b0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clips == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			obj6 = 0;
			obj7 = 0;
			if (obj8 != null)
			{
				goto IL_00b0;
			}
		}
		object obj9 = clips + 24;
		obj6 = obj7;
		goto IL_02f3;
		IL_02f3:
		object obj10 = typeof(DataRelation) + 712;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj12 = obj2 + 24;
		obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = _nextClipStartTime - now;
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v19+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = typeof(SqlSingle[]) + 2376;
		object obj19 = (nint)0 + (nint)536;
		object obj20 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		object obj21 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = Math.Max(totalSeconds, 0.0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj19);
		object obj23 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v27+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds((float)num, action);
		float length = ((AudioClip)obj12).length;
		float num2 = length + (float)num;
		DateTime dateTime = default(DateTime);
		DateTime nextClipStartTime = dateTime.AddSeconds(num2);
		_nextClipStartTime = nextClipStartTime;
		return;
		IL_00b0:
		obj9 = this + 32;
		goto IL_02f3;
	}

	private void OnStopSound()
	{
		_source.Stop();
	}

	public void PlaySoundsQueued(SingleSound[] clips)
	{
		//IL_000c: Expected O, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_0245: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		//IL_019c: Expected O, but got I4
		//IL_01da: Expected O, but got I4
		//IL_01e3: Expected F8, but got I4
		//IL_02a1: Expected F8, but got I4
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_0559: Expected O, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_031d: Expected O, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_0353: Expected O, but got I4
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0398: Expected O, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I
		//IL_03e5: Expected I, but got O
		//IL_03f6: Expected I, but got O
		//IL_0420: Expected O, but got I4
		//IL_04a9: Expected O, but got I
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I4
		//IL_04ec: Expected O, but got I4
		//IL_050d: Expected O, but got I4
		object obj = (nint)0 + (nint)2752;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)clips))
		{
			object obj2 = typeof(DataRelation) + 856;
			object message = "___# Content push apply failed [{0}]: {1}" + 1192;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v49+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogError(message);
			return;
		}
		object obj5 = typeof(DataRelation) + 712;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = _nextClipStartTime - now;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v10+E4]");
		double totalSeconds;
		TimeSpan timeSpan2 = default(TimeSpan);
		double val;
		object obj13;
		object obj12;
		if ((nint)0 != 0)
		{
			totalSeconds = timeSpan2.TotalSeconds;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v38+E4]");
			bool flag3 = (nint)0 == 0;
			obj12 = 0;
			val = totalSeconds;
			obj13 = 0;
			if (!flag3)
			{
				goto IL_01aa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			totalSeconds = timeSpan2.TotalSeconds;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v38+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj12 = 0;
			val = totalSeconds;
			obj13 = 0;
			if (obj14 != null)
			{
				goto IL_01aa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		double num = Math.Max(val, 0.0);
		bool flag5 = clips == null;
		double num2 = 0.0;
		obj12 = obj13;
		if (!flag5)
		{
			goto IL_02b7;
		}
		goto IL_0592;
		IL_01aa:
		num = Math.Max(totalSeconds, 0.0);
		bool flag6 = clips == null;
		object obj15 = !flag6;
		num2 = 0.0;
		if (obj15 != null)
		{
			goto IL_02b7;
		}
		goto IL_0592;
		IL_02b7:
		bool flag7 = clips.Length < 1;
		float num3 = (float)num;
		nint num4 = 0;
		double num5 = num;
		if (flag7)
		{
			goto IL_051b;
		}
		object obj16 = clips + 32;
		object obj17 = typeof(SqlSingle[]) + 2376;
		object obj18 = (nint)0 + (nint)544;
		object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj21 = default(object);
		object obj20 = obj21;
		nint num6 = 0;
		double num7 = num;
		object obj22 = 0;
		object obj23 = obj12;
		object obj25 = default(object);
		Action action = default(Action);
		while (true)
		{
			object obj24 = typeof(SkeletonBinary.SkeletonInput) + 584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj25..ctor();
			if (obj25 == null)
			{
				break;
			}
			object obj26 = obj25 + 24;
			obj26 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag8 = (nint)obj22 < clips.Length;
			object obj27 = !flag8;
			if (obj27 == null)
			{
				object obj28 = obj25 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X26_v5+v340 @ X25_v6*8]");
				obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				num4 = (nint)obj18;
				action..ctor(obj25, (IntPtr)obj18);
				object obj29 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v32+E4]");
				bool flag9 = (nint)0 == 0;
				object obj30 = !flag9;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Coroutine coroutine = CoroutineDummy.WaitForSeconds((float)num7, action);
				object obj31 = obj28;
				if (obj28 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v20+18]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v20+18]");
				num3 = ((AudioClip)0).length;
				num5 = num7 + (double)num3;
				obj22++;
				bool flag10 = (nint)obj22 < clips.Length;
				obj12 = 0;
				obj20 = 0;
				num = num3;
				num6 = num4;
				num7 = num5;
				obj23 = 0;
				if (flag10)
				{
					continue;
				}
				goto IL_051b;
			}
			goto IL_05a0;
		}
		goto IL_0592;
		IL_051b:
		object obj32 = typeof(DataRelation) + 712;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v17+E4]");
		bool flag11 = (nint)0 == 0;
		object obj34 = !flag11;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		DateTime nextClipStartTime = dateTime.AddSeconds(num5);
		_nextClipStartTime = nextClipStartTime;
		return;
		IL_05a0:
		throw new IndexOutOfRangeException();
		IL_0592:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05a0;
	}

	public void PlayRandomSound(AudioClip[] clips)
	{
		object clip = ArraysExtensions.Random((IList<object>)clips);
		_source.PlayOneShot((AudioClip)clip);
	}

	public static bool IsChannelMuted(SoundOptions.Channel channel)
	{
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0189: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_03a2: Expected O, but got I
		//IL_02f8: Expected O, but got I4
		//IL_03bf: Expected I4, but got O
		//IL_0112: Expected O, but got I4
		object obj12;
		object obj5;
		object obj11;
		bool flag3;
		object obj13;
		bool sFXSound;
		object obj14;
		bool flag4;
		object obj15;
		bool chatSound;
		switch (channel)
		{
		case SoundOptions.Channel.Gameplay:
			return true;
		case SoundOptions.Channel.SFX:
		{
			obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v34+E4]");
			if ((nint)0 != 0)
			{
				if (Preferences.GameSound)
				{
					goto IL_00e8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool gameSound3 = Preferences.GameSound;
				bool flag5 = !gameSound3;
				object obj17 = !flag5;
				if (obj17 != null)
				{
					goto IL_00e8;
				}
			}
			return true;
		}
		case SoundOptions.Channel.Master:
		{
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool gameSound2 = Preferences.GameSound;
			return (byte)((gameSound2 ? 1u : 0u) ^ 1u) != 0;
		}
		case SoundOptions.Channel.Notifications:
		{
			obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				if (Preferences.GameSound)
				{
					goto IL_0225;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool gameSound = Preferences.GameSound;
				bool flag = !gameSound;
				object obj7 = !flag;
				if (obj7 != null)
				{
					goto IL_0225;
				}
			}
			return true;
		}
		default:
			{
				object obj = typeof(SkeletonBinary.SkeletonInput) + 592;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2864;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				object actualValue = default(object);
				ex..ctor(paramName, actualValue, null);
				object obj4 = (nint)0 + (nint)1736;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				OutOfMemoryException ex2 = new OutOfMemoryException();
				return (byte)(int)ex2 != 0;
			}
			IL_00e8:
			obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v41+E4]");
			flag3 = (nint)0 == 0;
			obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			sFXSound = Preferences.SFXSound;
			return (byte)((sFXSound ? 1u : 0u) ^ 1u) != 0;
			IL_0225:
			obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v26+E4]");
			flag4 = (nint)0 == 0;
			obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			chatSound = Preferences.ChatSound;
			return (byte)((chatSound ? 1u : 0u) ^ 1u) != 0;
		}
	}
}
