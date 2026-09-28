using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using DG.Tweening;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class GameSoundManager : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<AudioSource> <>9__32_1;

		public static Action<AudioSource> <>9__32_2;

		public static Action<AudioSource> <>9__32_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <InitPooledAudioSources>b__32_1(AudioSource source)
		{
			source.Stop();
		}

		internal void <InitPooledAudioSources>b__32_2(AudioSource source)
		{
			source.Stop();
		}

		internal void <InitPooledAudioSources>b__32_3(AudioSource source)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0126: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			//IL_0167: Expected O, but got I4
			//IL_0170: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6587]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = source != null;
			bool flag3 = !flag2;
			object obj5 = !flag3;
			object obj6 = 0;
			if (obj5 == null)
			{
				return;
			}
			goto IL_00a4;
			IL_00a4:
			source.Stop();
			GameObject gameObject = source.gameObject;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
			return;
			IL_0074:
			bool flag4 = source != null;
			bool flag5 = !flag4;
			obj6 = 0;
			if (!flag5)
			{
				goto IL_00a4;
			}
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <>c__DisplayClass17_0
	{
		public GameSoundManager <>4__this;

		public List<int> actors;
	}

	private sealed class <ReturnAfter>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public float seconds;

		public GameSoundManager <>4__this;

		public AudioSource audioSource;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <ReturnAfter>d__35(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ab: Expected I4, but got I8
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_0040: Expected I4, but got I8
			//IL_0118: Expected I4, but got O
			//IL_008d: Expected O, but got I
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					GameSoundManager gameSoundManager = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this == null || gameSoundManager._pooledAudioSources == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					object obj = (nint)0 + (nint)3792;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C36B4");
				}
			}
			else
			{
				<>1__state = -1;
				object obj2 = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(seconds);
				object obj3 = this + 24;
				obj3 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<>1__state = 1;
			}
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <WaitAndPlaySound>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public float waitTime;

		public GameSoundManager <>4__this;

		public AudioClip clip;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WaitAndPlaySound>d__26(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a9: Expected I4, but got I8
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0040: Expected I4, but got I8
			//IL_0126: Expected I4, but got O
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					GameSoundManager gameSoundManager = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this == null || (object)gameSoundManager._audioSource == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					gameSoundManager._audioSource.PlayOneShot(clip);
				}
			}
			else
			{
				<>1__state = -1;
				object obj = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				float seconds = waitTime / 1.1488461E+09f;
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(seconds);
				object obj2 = this + 24;
				obj2 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<>1__state = 1;
			}
			return <>1__state == 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private static GameSoundManager _instance;

	private DateTime <endTime>k__BackingField;

	private AudioClip chatPing;

	private AudioClip cardPrepare;

	private List<AudioClip> cardSounds;

	private SoundActors _soundActors;

	private readonly Dictionary<int, SoundActor> _playerSounds;

	private KGame _game;

	private AudioSource _audioSource;

	private PooledObjectList<AudioSource> _pooledAudioSources;

	private GameObject _poolParentGameObject;

	public static GameSoundManager Instance
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0047: Expected O, but got I
			//IL_0127: Expected O, but got I
			//IL_0159: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			//IL_007c: Expected O, but got I
			//IL_01c8: Expected O, but got I
			//IL_0104: Expected O, but got I
			//IL_01a5: Expected O, but got I4
			//IL_01ae: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2192;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6577]");
			object obj4 = (nint)0 & (nint)1;
			UnityEngine.Object obj7;
			UnityEngine.Object obj9;
			if (obj4 != null)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v13+B8]");
				object obj6 = 0;
				obj7 = (UnityEngine.Object)obj6;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				obj9 = (UnityEngine.Object)obj6;
				if (!flag)
				{
					goto IL_00b9;
				}
			}
			else
			{
				_ = 1;
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v6+B8]");
				object obj11 = 0;
				obj7 = (UnityEngine.Object)obj11;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				obj9 = (UnityEngine.Object)obj11;
				if (obj12 != null)
				{
					goto IL_00b9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj9;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			object obj14 = 0;
			if (obj13 != null)
			{
				goto IL_00ec;
			}
			goto IL_01bc;
			IL_00ec:
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v10+B8]");
			return (GameSoundManager)0;
			IL_01bc:
			object obj16 = (nint)0 + (nint)72;
			object obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				GameSoundManager result = default(GameSoundManager);
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			GameSoundManager result2 = default(GameSoundManager);
			return result2;
			IL_00b9:
			bool flag5 = obj7;
			bool flag6 = !flag5;
			obj14 = 0;
			if (!flag6)
			{
				goto IL_00ec;
			}
			goto IL_01bc;
		}
	}

	public DateTime endTime
	{
		get
		{
			return <endTime>k__BackingField;
		}
		private set
		{
			<endTime>k__BackingField = value;
		}
	}

	private SoundActors SoundActors
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_011a: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0190: Expected O, but got I
			//IL_016e: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6578]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 64;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 64;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			obj4 = obj8;
			if (obj10 != null)
			{
				goto IL_00d2;
			}
			goto IL_0184;
			IL_00d2:
			return (SoundActors)obj4;
			IL_0184:
			object obj11 = (nint)0 + (nint)2040;
			string resourcesPath = SoundActors.ResourcesPath;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF8ABC");
			SoundActors soundActors = default(SoundActors);
			obj8 = soundActors;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return soundActors;
			IL_00a0:
			bool flag5 = obj5;
			bool flag6 = !flag5;
			obj8 = obj4;
			if (!flag6)
			{
				goto IL_00d2;
			}
			goto IL_0184;
		}
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_0200: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02db: Expected O, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0144: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_0252: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_037c: Expected O, but got I4
		//IL_03a5: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_03fb: Expected O, but got I
		//IL_0409: Expected I, but got O
		//IL_02fa: Expected O, but got I
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_033f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2192;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6622]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v29+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			obj9 = (UnityEngine.Object)obj6;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v20+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			obj9 = (UnityEngine.Object)obj11;
			if (obj12 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj9 != null;
		bool flag4 = !flag3;
		object obj13 = !flag4;
		object obj14 = 0;
		UnityEngine.Object obj15 = null;
		object obj16 = 0;
		if (obj13 != null)
		{
			goto IL_00f7;
		}
		goto IL_026e;
		IL_00f7:
		object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj18 = "Material with texture name \"" + 2888;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v59+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogError(obj18);
		GameObject obj21 = base.gameObject;
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v27+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj21);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj21);
		return;
		IL_026e:
		object obj23 = (nint)0 + (nint)928;
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = obj23;
		AudioSource audioSource = (AudioSource)(this + 88);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj27 = default(object);
		object obj26 = obj27 & 1;
		bool flag6 = obj26 == null;
		object obj28 = !flag6;
		if (obj28 == null)
		{
			GameObject gameObject = base.gameObject;
			object obj29 = (nint)0 + (nint)552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
			AudioSource audioSource2 = default(AudioSource);
			audioSource2.playOnAwake = false;
			_audioSource = audioSource2;
			object obj30 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj25 = 0;
			audioSource = audioSource2;
		}
		InitPooledAudioSources();
		object obj31 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj33 = (nint)0 + (nint)136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj34 = this + 80;
		object obj35 = default(object);
		obj34 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj36 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)2448;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj37);
		((KGame)obj34).OnGameInitialized += action;
		return;
		IL_00b9:
		bool flag8 = obj7 != null;
		bool flag9 = !flag8;
		obj14 = 0;
		obj15 = null;
		obj16 = 0;
		if (!flag9)
		{
			goto IL_00f7;
		}
		goto IL_026e;
	}

	public unsafe void SetSoundActors(List<int> actors, int myPlayerIndex)
	{
		//IL_047a: Expected O, but got Ref
		//IL_04a5: Expected I4, but got O
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_0409: Expected O, but got I
		//IL_0417: Expected I, but got O
		//IL_0432: Expected I, but got O
		//IL_043a: Expected I4, but got O
		//IL_043f: Expected I4, but got O
		//IL_0087: Expected O, but got I
		//IL_008f: Expected I4, but got O
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0112: Expected O, but got I4
		//IL_0191: Expected I4, but got O
		//IL_01ab: Expected O, but got I
		//IL_01b3: Expected I, but got O
		//IL_01ce: Expected I4, but got O
		//IL_03a6: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<>c__DisplayClass17_0 <>c__DisplayClass17_ = default(<>c__DisplayClass17_0);
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref <>c__DisplayClass17_, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = (object)_game == null;
		int num = myPlayerIndex;
		int num2 = (int)actors;
		if (!flag)
		{
			KPlayer playerByIndex = _game.GetPlayerByIndex(1);
			bool flag2 = playerByIndex == null;
			num = 0;
			num2 = 1;
			if (!flag2)
			{
				bool flag3 = _playerSounds == null;
				num = 0;
				num2 = 1;
				if (!flag3)
				{
					object obj2 = (nint)0 + (nint)1568;
					num2 = (int)obj2;
					((Dictionary<int, object>)(object)_playerSounds).Clear();
					bool flag4 = myPlayerIndex < 1;
					num = 0;
					if (flag4)
					{
						goto IL_01db;
					}
					SoundActors soundActors = SoundActors;
					object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v27+E4]");
					bool flag5 = (nint)0 == 0;
					object obj5 = !flag5;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string soundActor = Preferences.SoundActor;
					bool flag6 = (object)soundActors == null;
					num = 0;
					if (!flag6)
					{
						SoundActor actor = soundActors.GetActor(soundActor);
						bool flag7 = _playerSounds == null;
						num = 0;
						num2 = (int)soundActor;
						if (!flag7)
						{
							object obj6 = (nint)0 + (nint)1608;
							nint num3 = (nint)obj6;
							((Dictionary<int, object>)(object)_playerSounds).set_Item(myPlayerIndex, (object)actor);
							num = (int)actor;
							num2 = myPlayerIndex;
							goto IL_01db;
						}
					}
				}
			}
			else
			{
				object obj7 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)2456;
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj8);
				bool flag8 = (object)_game == null;
				nint num3 = unchecked((nint)null);
				num = (int)obj8;
				num2 = (int)this;
				if (!flag8)
				{
					_game.OnGameInitialized += action;
					return;
				}
			}
		}
		goto IL_03d4;
		IL_03d4:
		throw new NullReferenceException();
		IL_01db:
		if (actors != null)
		{
			int num4 = num;
			int num5 = num2;
			List<int> list = actors;
			int num6 = 0;
			bool flag12;
			do
			{
				int num7 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
				if ((nint)num7 < (nint)0)
				{
					bool flag9 = (object)_game == null;
					num = num4;
					num2 = num5;
					if (flag9)
					{
						break;
					}
					num2 = num6 + 1;
					KPlayer playerByIndex2 = _game.GetPlayerByIndex(num2);
					bool flag10 = playerByIndex2 == null;
					num = 0;
					if (flag10)
					{
						break;
					}
					bool isHuman = playerByIndex2.IsHuman;
					bool flag11 = !isHuman;
					num4 = 0;
					num5 = 0;
					if (!flag11)
					{
						<SetSoundActors>g__AssignSound|17_0(num6, ref <>c__DisplayClass17_);
						num4 = (int)(&<>c__DisplayClass17_);
						num5 = num6;
					}
					num6++;
					flag12 = actors == null;
					list = actors;
					num = num4;
					num2 = num5;
					continue;
				}
				int num8 = 0;
				object obj9;
				do
				{
					int num9 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v15 (System.Collections.Generic.List`1<System.Int32>)+18]");
					if ((nint)num9 < (nint)0)
					{
						<SetSoundActors>g__AssignSound|17_0(num8, ref <>c__DisplayClass17_);
						int num10 = num8 + 1;
						bool flag13 = actors == null;
						obj9 = !flag13;
						num = (int)(&<>c__DisplayClass17_);
						num2 = num8;
						list = actors;
						num8 = num10;
						continue;
					}
					return;
				}
				while (obj9 != null);
				break;
			}
			while (!flag12);
		}
		goto IL_03d4;
	}

	public int GetMyVoiceId()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_01ad: Expected I4, but got O
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E657A]");
		object obj3 = (nint)0 & (nint)1;
		SoundActors soundActors2;
		SoundActors soundActors3;
		if (obj3 != null)
		{
			SoundActors soundActors = SoundActors;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			soundActors2 = soundActors;
			soundActors3 = soundActors;
			if (!flag)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			SoundActors soundActors4 = SoundActors;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			soundActors2 = soundActors4;
			soundActors3 = soundActors4;
			if (obj5 != null)
			{
				goto IL_0097;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string soundActor = Preferences.SoundActor;
		bool flag3 = (object)soundActors3 == null;
		soundActors2 = soundActors3;
		if (!flag3)
		{
			goto IL_0167;
		}
		goto IL_019f;
		IL_019f:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0167:
		SoundActor actor = soundActors2.GetActor(soundActor);
		if ((object)actor != null)
		{
			return actor.id;
		}
		goto IL_019f;
		IL_0097:
		soundActor = Preferences.SoundActor;
		bool flag4 = (object)soundActors2 == null;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			goto IL_0167;
		}
		goto IL_019f;
	}

	public void PlaySounds(IEnumerable<string> sounds, int player)
	{
		//IL_0226: Expected O, but got I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected I4, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0101: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_015d: Expected O, but got I
		//IL_016e: Expected I, but got O
		//IL_017a: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I
		//IL_01c8: Expected I, but got O
		if (_playerSounds != null)
		{
			int count = ((Dictionary<int, object>)(object)_playerSounds).Count;
			int? num = count;
			object obj2 = default(object);
			object obj = player - obj2;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num2 = player ^ obj2;
			int num3 = player ^ obj;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			object obj4 = flag4 & obj3;
			if (sounds == null)
			{
				return;
			}
			object obj5 = obj4 & (object?)num;
			object obj6 = obj5 & 1;
			bool flag5 = obj6 == null;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				object obj8 = (nint)0 + (nint)1592;
				object obj9 = ((Dictionary<int, object>)(object)_playerSounds).get_Item(player);
				object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3544;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)1728;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj9, (IntPtr)obj11);
				object obj12 = (nint)0 + (nint)8;
				IEnumerable<object> source = Enumerable.Select(sounds, func);
				object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 240;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)3264;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)null, (IntPtr)obj14);
				IEnumerable<object> enumerable = Enumerable.Where(source, func2);
				if (enumerable != null)
				{
					PlaySounds((IEnumerable<AudioClip>)enumerable);
				}
			}
		}
		else
		{
			bool flag6 = sounds == null;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				throw new NullReferenceException();
			}
		}
	}

	public void PlaySound(string sound, int player, bool withDelay = true)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_019a: Expected O, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		if (_playerSounds != null)
		{
			int count = ((Dictionary<int, object>)(object)_playerSounds).Count;
			if (player > count)
			{
				return;
			}
			if (_playerSounds != null)
			{
				object obj = ((Dictionary<int, object>)(object)_playerSounds).get_Item(player);
				if (obj != null)
				{
					AudioClip audioClip = ((SoundActor)obj).GetAudioClip(sound);
					object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v12+E4]");
					if ((nint)0 != 0)
					{
						if (!audioClip)
						{
							return;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag = audioClip;
						bool flag2 = !flag;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							return;
						}
					}
					object obj5 = typeof(TypeConverter<ushort, char>) + 1744;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					IEnumerable<AudioClip> enumerable = default(IEnumerable<AudioClip>);
					if (enumerable != null)
					{
						object obj6 = enumerable + 32;
						obj6 = audioClip;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						PlaySounds(enumerable, withDelay);
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void PlaySound(BalootSound sound, int player, bool withDelay = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		PlaySound(friendlyName, player, withDelay);
	}

	public void PlaySound(GameSoundEffect gameSound, bool withDelay = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		AudioClip audioClip = GetAudioClip(gameSound);
		IEnumerable<AudioClip> enumerable = default(IEnumerable<AudioClip>);
		if (enumerable != null)
		{
			object obj2 = enumerable + 32;
			obj2 = audioClip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			PlaySounds(enumerable, withDelay);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void PlaySound(AudioClip clip, float volume)
	{
		_audioSource.PlayOneShot(clip, volume);
	}

	private void PlaySounds(IEnumerable<AudioClip> sounds, bool withDelay = true)
	{
		//IL_0016: Expected O, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected F8, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0345: Expected O, but got I4
		//IL_0de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dea: Expected O, but got Unknown
		//IL_02cd: Expected F8, but got I4
		//IL_0a9f: Expected I, but got O
		//IL_0ad1: Expected O, but got I4
		//IL_0ae2: Expected O, but got I4
		//IL_0377: Expected I, but got O
		//IL_03af: Expected O, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0145: Expected I, but got O
		//IL_0155: Expected O, but got I
		//IL_03fd: Expected O, but got I4
		//IL_0406: Expected F8, but got I4
		//IL_0420: Expected F8, but got I4
		//IL_0b3f: Expected O, but got I4
		//IL_0b48: Expected F8, but got I4
		//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8e: Expected O, but got Unknown
		//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Expected O, but got Unknown
		//IL_0db2: Expected O, but got I
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_0d02: Expected O, but got I
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected O, but got Unknown
		//IL_0b70: Expected F8, but got I4
		//IL_0bb0: Expected O, but got I4
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_04ba: Expected O, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_0e8b: Expected O, but got I
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea3: Expected O, but got Unknown
		//IL_04f5: Expected O, but got I
		//IL_083c: Expected O, but got I4
		//IL_0845: Expected O, but got I4
		//IL_0856: Expected O, but got I4
		//IL_0867: Expected O, but got I4
		//IL_0888: Expected O, but got I4
		//IL_0891: Expected O, but got I4
		//IL_0e3a: Expected O, but got I
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Expected O, but got Unknown
		//IL_0c69: Expected O, but got I4
		//IL_0c7a: Expected O, but got I4
		//IL_0f57: Expected O, but got I4
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_08cb: Expected O, but got I
		//IL_0bc7: Expected O, but got I4
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0526: Expected O, but got I
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_0cc1: Expected O, but got I4
		//IL_05ff: Expected O, but got I
		//IL_0fa9: Expected O, but got I
		//IL_0906: Expected O, but got I
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a2a: Expected O, but got I4
		//IL_0f75: Expected O, but got I
		//IL_09de: Expected O, but got I4
		//IL_063a: Expected O, but got I
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected O, but got Unknown
		//IL_0ed0: Expected O, but got I
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected O, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		//IL_092f: Expected O, but got I
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_066b: Expected O, but got I
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_079d: Expected O, but got I4
		//IL_0801: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6623]");
		object obj = (nint)0 & (nint)1;
		nint num2;
		nint num;
		if (obj != null)
		{
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v83+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v83+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v83+E4]");
			num2 = 0;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			object obj4 = typeof(DataRelation) + 712;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v83+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v83+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v83+E4]");
			num2 = 0;
			if (obj5 != null)
			{
				goto IL_0096;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		bool flag3 = !withDelay;
		double num3 = 0.0;
		DateTime dateTime = now;
		num = num2;
		dateTime = now;
		if (flag3)
		{
			goto IL_00dc;
		}
		goto IL_02f3;
		IL_0d7a:
		object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj7 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v1+8]");
		IEnumerator enumerator = (IEnumerator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X0_v1] (should have been resolved before IL gen)");
		object obj8 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 136;
		object obj9 = default(object);
		bool flag5 = default(bool);
		object obj13 = default(object);
		object obj15 = default(object);
		object obj25 = default(object);
		AudioClip audioClip = default(AudioClip);
		object obj28 = default(object);
		object obj42 = default(object);
		object obj47 = default(object);
		object obj11;
		double num5 = default(double);
		double num6 = default(double);
		bool flag9;
		while (true)
		{
			if (obj9 != null)
			{
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v23+12E]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_057a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v23+B0]");
				object obj12 = (nint)0 + (nint)8;
				bool flag4 = flag5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X10_v24-8]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X10_v24-8]");
					object obj14 = 0 - obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X10_v24-8]");
					if (0 == (nint)obj6)
					{
						break;
					}
					obj15 = obj12 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v23+12E]");
					obj11 = -1;
					obj14 = obj11 - 1;
					bool flag6 = obj14 == null;
					flag5 = (nint)obj11 != 1;
					flag4 = flag5;
					obj12 = obj15;
					if (flag5)
					{
						continue;
					}
					goto IL_057a;
				}
				obj11 = obj12;
				object obj16 = obj10 + obj12;
				object obj17 = obj16 + 312;
				flag5 = flag4;
				obj15 = obj12;
				goto IL_0e7a;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj18 = 0;
			goto IL_0c0e;
			IL_089f:
			object obj19 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj21;
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v19+12E]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v19+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0957;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v19+B0]");
			object obj22 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X10_v12-8]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X10_v12-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				obj15 = obj22 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v19+12E]");
				obj11 = -1;
				bool flag7 = (nint)obj11 != 1;
				obj22 = obj15;
				if (flag7)
				{
					continue;
				}
				goto IL_0957;
			}
			obj11 = obj22;
			object obj23 = obj20 + obj22;
			object obj24 = obj23 + 312;
			bool flag8 = flag9;
			obj15 = obj22;
			goto IL_0f99;
			IL_0f10:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v786 @ X0_v37] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj25..ctor();
			object obj26 = obj25 + 40;
			obj26 = this;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj27 = obj25 + 48;
			obj27 = audioClip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj25);
			bool flag10 = !withDelay;
			obj28 = obj25;
			flag9 = false;
			enumerator = (IEnumerator)obj25;
			if (flag10)
			{
				continue;
			}
			bool flag11 = (object)audioClip == null;
			object obj29 = obj13;
			obj18 = 0;
			object obj30 = obj25;
			flag8 = false;
			object obj31 = obj15;
			enumerator = (IEnumerator)obj25;
			if (!flag11)
			{
				float length = audioClip.length;
				float num4 = length * 1.1488461E+09f;
				num3 += (double)num4;
				num5 = 1148846080.0;
				num6 = num4;
				obj28 = obj25;
				flag9 = false;
				enumerator = null;
				continue;
			}
			goto IL_0bda;
			IL_0f99:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v27+8]");
			enumerator = (IEnumerator)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v799 @ X0_v27] (should have been resolved before IL gen)");
			obj29 = obj13;
			obj30 = obj28;
			obj31 = obj15;
			object obj33;
			object obj32 = obj33;
			object obj35;
			object obj34 = obj35;
			goto IL_0f3d;
			IL_0f3d:
			bool flag12 = obj34 == null;
			object obj36 = !flag12;
			if (obj36 == null)
			{
				if ((nint)obj32 != 6)
				{
					bool flag13 = obj32 == null;
					object obj37 = !flag13;
					if (obj37 != null)
					{
						return;
					}
				}
				object obj38 = typeof(DataRelation) + 712;
				object obj39 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v10+E4]");
				bool flag14 = (nint)0 == 0;
				object obj40 = !flag14;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double value = num3 * 9.216166277450983E+18;
				DateTime dateTime2 = dateTime.AddMilliseconds(value);
				<endTime>k__BackingField = dateTime2;
				return;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			goto IL_0bda;
			IL_057a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			flag9 = false;
			goto IL_0e7a;
			IL_0e7a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v33+8]");
			enumerator = (IEnumerator)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ X0_v33] (should have been resolved before IL gen)");
			object obj41 = obj42 & 1;
			if (obj41 != null)
			{
				if (obj9 != null)
				{
					object obj43 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v26+12E]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v26+12E]");
					if ((nint)0 == 0)
					{
						goto IL_06bf;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v26+B0]");
					object obj44 = (nint)0 + (nint)8;
					bool flag15 = flag5;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X10_v19-8]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X10_v19-8]");
						object obj14 = 0 - obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X10_v19-8]");
						if (0 == (nint)obj7)
						{
							break;
						}
						obj15 = obj44 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v26+12E]");
						obj11 = -1;
						obj14 = obj11 - 1;
						bool flag6 = obj14 == null;
						flag5 = (nint)obj11 != 1;
						flag15 = flag5;
						obj44 = obj15;
						if (flag5)
						{
							continue;
						}
						goto IL_06bf;
					}
					obj11 = obj44;
					object obj45 = obj43 + obj44;
					object obj46 = obj45 + 312;
					flag5 = flag15;
					obj15 = obj44;
					goto IL_0f10;
				}
				ex = new NullReferenceException();
				obj18 = 0;
				goto IL_0c0e;
			}
			bool flag16 = obj9 == null;
			obj18 = 0;
			obj33 = 6;
			obj21 = obj9;
			obj35 = 0;
			obj29 = obj13;
			obj18 = 0;
			obj30 = obj28;
			flag8 = flag9;
			obj31 = obj15;
			obj32 = 6;
			obj34 = 0;
			if (!flag16)
			{
				goto IL_089f;
			}
			goto IL_0f3d;
			IL_0c0e:
			if ((nint)enumerator != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj35 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag17 = obj9 == null;
			object obj48 = !flag17;
			obj18 = obj47;
			obj33 = 0;
			obj21 = obj9;
			if (obj48 != null)
			{
				goto IL_089f;
			}
			obj29 = obj13;
			obj18 = obj47;
			obj30 = obj28;
			flag8 = flag9;
			obj31 = obj15;
			obj32 = 0;
			obj34 = obj47;
			goto IL_0f3d;
			IL_06bf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			flag9 = false;
			goto IL_0f10;
			IL_0bda:
			ex = new NullReferenceException();
			obj13 = obj29;
			obj28 = obj30;
			flag9 = flag8;
			obj15 = obj31;
			goto IL_0c0e;
			IL_0957:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			flag8 = false;
			goto IL_0f99;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_044f:
		throw new NullReferenceException();
		IL_0129:
		object obj49 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2936;
		num = (nint)sounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.AudioClip>>)+12E]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.AudioClip>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0215;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.AudioClip>>)+B0]");
		object obj50 = (nint)0 + (nint)8;
		bool flag18 = flag5;
		bool flag19;
		double num7;
		double num8;
		object obj51;
		double num9;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v31-8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v31-8]");
			object obj14 = 0 - obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v31-8]");
			bool flag6 = 0 == (nint)obj49;
			num7 = num5;
			num8 = num6;
			obj51 = obj28;
			flag9 = flag19;
			flag5 = flag18;
			obj15 = obj50;
			num9 = num3;
			if (flag6)
			{
				break;
			}
			obj15 = obj50 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.AudioClip>>)+12E]");
			obj11 = -1;
			obj14 = obj11 - 1;
			flag6 = obj14 == null;
			flag5 = (nint)obj11 != 1;
			flag18 = flag5;
			obj50 = obj15;
			if (flag5)
			{
				continue;
			}
			goto IL_0215;
		}
		obj11 = obj15;
		object obj52 = num + obj15;
		object obj53 = obj52 + 312;
		num5 = num7;
		num6 = num8;
		obj28 = obj51;
		num3 = num9;
		goto IL_0d7a;
		IL_0096:
		now = DateTime.Now;
		bool flag20 = !withDelay;
		object obj54 = !flag20;
		num3 = 0.0;
		dateTime = now;
		dateTime = now;
		if (obj54 == null)
		{
			goto IL_00dc;
		}
		goto IL_02f3;
		IL_02f3:
		object obj55 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj56 = typeof(DataRelation) + 712;
		object obj57 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v39+E4]");
		bool flag21 = (nint)0 == 0;
		object obj58 = !flag21;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj28 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		TimeSpan timeSpan = <endTime>k__BackingField - now;
		object obj59 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v69+E4]");
		double totalMilliseconds;
		TimeSpan timeSpan2 = default(TimeSpan);
		double val;
		nint num11;
		if ((nint)0 != 0)
		{
			totalMilliseconds = timeSpan2.TotalMilliseconds;
			nint num10 = (nint)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v70 (Il2CppClass<System.Object>)+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v70 (Il2CppClass<System.Object>)+E4]");
			bool flag22 = (nint)0 == 0;
			val = totalMilliseconds;
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v70 (Il2CppClass<System.Object>)+E4]");
			num11 = 0;
			if (!flag22)
			{
				goto IL_03cd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			totalMilliseconds = timeSpan2.TotalMilliseconds;
			nint num10 = (nint)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v70 (Il2CppClass<System.Object>)+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v70 (Il2CppClass<System.Object>)+E4]");
			bool flag23 = (nint)0 == 0;
			object obj61 = !flag23;
			val = totalMilliseconds;
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v70 (Il2CppClass<System.Object>)+E4]");
			num11 = 0;
			if (obj61 != null)
			{
				goto IL_03cd;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num6 = Math.Max(val, 0.0);
		bool flag24 = sounds == null;
		object obj62 = !flag24;
		num5 = 0.0;
		flag19 = false;
		num3 = num6;
		if (obj62 != null)
		{
			goto IL_0129;
		}
		num7 = 0.0;
		num8 = num6;
		obj51 = obj28;
		flag9 = false;
		num9 = num6;
		num = num11;
		goto IL_044f;
		IL_00dc:
		bool flag25 = sounds == null;
		flag19 = withDelay;
		num7 = num5;
		num8 = num6;
		obj51 = obj28;
		flag9 = withDelay;
		num9 = num3;
		if (!flag25)
		{
			goto IL_0129;
		}
		goto IL_044f;
		IL_03cd:
		num6 = Math.Max(totalMilliseconds, 0.0);
		bool flag26 = sounds == null;
		object obj63 = !flag26;
		num5 = 0.0;
		flag19 = false;
		num3 = num6;
		num7 = 0.0;
		num8 = num6;
		obj51 = obj28;
		flag9 = false;
		num9 = num6;
		if (obj63 != null)
		{
			goto IL_0129;
		}
		goto IL_044f;
		IL_0215:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		flag9 = false;
		goto IL_0d7a;
	}

	private unsafe AudioClip GetAudioClip(GameSoundEffect gameSound)
	{
		//IL_003c: Expected O, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0094: Expected O, but got Ref
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		switch (gameSound)
		{
		default:
		{
			bool flag = gameSound == GameSoundEffect.CARD;
			object obj = !flag;
			if (obj == null)
			{
				return (AudioClip)ArraysExtensions.Random((IList<object>)cardSounds);
			}
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			object obj3 = default(object);
			string text = ((Enum)(&obj3)).ToString();
			object obj4 = "https://www.kammelna.com/Home/Terms" + 920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			string text2 = default(string);
			string message = text2 + text;
			object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = "fetch_products" + 2400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentException ex = default(ArgumentException);
			string paramName = default(string);
			ex..ctor(message, paramName);
			object obj7 = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (AudioClip)(object)new OutOfMemoryException();
		}
		case GameSoundEffect.CARD_PREPARE:
			return cardPrepare;
		case GameSoundEffect.CHAT_PING:
			return chatPing;
		}
	}

	private IEnumerator WaitAndPlaySound(float waitTime, AudioClip clip)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 48;
		obj4 = clip;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private AudioSource CreateAudioSource()
	{
		//IL_0011: Expected O, but got I
		GameObject gameObject = base.gameObject;
		if ((object)gameObject != null)
		{
			object obj = (nint)0 + (nint)552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
			AudioSource audioSource = default(AudioSource);
			if ((object)audioSource != null)
			{
				audioSource.playOnAwake = false;
				return audioSource;
			}
		}
		return (AudioSource)(object)new NullReferenceException();
	}

	private void OnVoiceActorsChanged()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_0285: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6580]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool multipleVoiceActors = Preferences.MultipleVoiceActors;
		KGame game = _game;
		bool flag2 = !multipleVoiceActors;
		object obj6 = !flag2;
		KGame game2 = _game;
		if (obj6 != null)
		{
			goto IL_00b7;
		}
		goto IL_018b;
		IL_00b7:
		Room room = game.Room;
		List<int> playersVoices = SFSKammelnaRoomExtensions.GetPlayersVoices(room);
		KGame game3 = _game;
		SetSoundActors(playersVoices, game3.<MySeatIndex>k__BackingField);
		return;
		IL_018b:
		object obj7 = (nint)0 + (nint)1608;
		int num = 0;
		while (true)
		{
			List<KPlayer> players = game2.Players;
			if (num < players._size)
			{
				SoundActors soundActors = SoundActors;
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string soundActor = Preferences.SoundActor;
				SoundActor actor = soundActors.GetActor(soundActor);
				num++;
				((Dictionary<int, object>)(object)_playerSounds).set_Item(num, (object)actor);
				game2 = _game;
				bool flag4 = (object)_game == null;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			break;
		}
		return;
		IL_007d:
		bool multipleVoiceActors2 = Preferences.MultipleVoiceActors;
		game = _game;
		bool flag5 = !multipleVoiceActors2;
		game2 = _game;
		if (!flag5)
		{
			goto IL_00b7;
		}
		goto IL_018b;
	}

	private void OnGameInitialized()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0060: Expected I, but got O
		GameObject go = base.gameObject;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2456;
		object varName = "placementId" + 1792;
		Room room = _game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go, room, (string)varName, action);
	}

	private void InitPooledAudioSources()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0136: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_0185: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0263: Expected O, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0289: Expected I, but got O
		//IL_0297: Expected I, but got O
		//IL_0236: Expected O, but got I4
		//IL_0551: Expected O, but got I
		//IL_0561: Expected O, but got I
		//IL_0583: Expected O, but got I4
		//IL_0336: Expected O, but got I4
		//IL_0344: Expected O, but got I4
		//IL_02d9: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_068c: Expected O, but got I
		//IL_069c: Expected O, but got I
		//IL_06be: Expected O, but got I4
		//IL_05bb: Expected O, but got I4
		//IL_037f: Expected O, but got I
		//IL_038f: Expected O, but got I
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_08c7: Expected O, but got I
		//IL_08cf: Expected I, but got O
		//IL_08e0: Expected I, but got O
		//IL_08fe: Expected O, but got I
		//IL_0716: Expected O, but got I4
		//IL_061a: Expected O, but got I4
		//IL_0623: Expected O, but got I4
		//IL_063c: Expected O, but got I4
		//IL_0644: Expected I, but got O
		//IL_05eb: Expected O, but got I
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0451: Expected O, but got I
		//IL_0461: Expected O, but got I
		//IL_0471: Expected O, but got I
		//IL_0493: Expected O, but got I4
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected O, but got Unknown
		//IL_093f: Expected O, but got I
		//IL_0947: Expected I, but got O
		//IL_0958: Expected I, but got O
		//IL_0976: Expected O, but got I
		//IL_0775: Expected O, but got I4
		//IL_077e: Expected O, but got I4
		//IL_079f: Expected O, but got I4
		//IL_07a7: Expected I, but got O
		//IL_0746: Expected O, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_04c3: Expected O, but got I4
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected O, but got Unknown
		//IL_0836: Expected O, but got I
		//IL_083e: Expected I, but got O
		//IL_084f: Expected I, but got O
		//IL_086d: Expected O, but got I
		//IL_0890: Expected O, but got I4
		//IL_04f3: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6582]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		object obj4;
		if (obj3 != null)
		{
			obj4 = this + 104;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v59+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 104;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v59+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7 == null;
		bool flag4 = !flag3;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		obj4 = obj8;
		object obj12 = 0;
		Transform transform = null;
		if (!flag4)
		{
			goto IL_01ae;
		}
		goto IL_0243;
		IL_0316:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = 0;
		object obj14 = this;
		object obj15 = 0;
		nint num2;
		nint num = num2;
		object obj16 = this;
		object obj18;
		object obj17 = obj18;
		Action<object> action2;
		Action<object> action = action2;
		if (!flag5)
		{
			goto IL_036f;
		}
		goto IL_066a;
		IL_07cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj19;
		obj18 = obj19;
		object obj20;
		obj13 = obj20;
		nint num3;
		num2 = num3;
		object obj21;
		obj14 = obj21;
		action2 = action;
		Action<object> action4;
		Action<object> action3 = action4;
		goto IL_0431;
		IL_03dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
		bool flag6 = (nint)0 == 0;
		obj20 = obj13;
		num3 = num2;
		obj21 = obj14;
		object obj22 = obj18;
		action = action2;
		action4 = action3;
		if (!flag6)
		{
			goto IL_0431;
		}
		goto IL_07cd;
		IL_00a0:
		bool flag7 = obj5 == null;
		bool flag8 = !flag7;
		object obj23 = !flag8;
		obj10 = 0;
		obj11 = null;
		if (obj23 != null)
		{
			goto IL_01ae;
		}
		obj12 = 0;
		transform = null;
		goto IL_0243;
		IL_01ae:
		object obj24 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
		object obj25 = "___# Content push apply failed [{0}]: {1}" + 2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GameObject gameObject = default(GameObject);
		gameObject..ctor((string)obj25);
		obj4 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform2 = ((GameObject)obj4).transform;
		Transform transform3 = base.transform;
		transform2.SetParent(transform3);
		obj12 = 0;
		transform = transform3;
		goto IL_0243;
		IL_066a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v8+10]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v8+10]");
		bool flag9 = (nint)0 == 0;
		object obj27 = !flag9;
		obj13 = obj15;
		num2 = num;
		obj14 = obj16;
		action2 = action;
		object obj28 = obj18;
		if (obj27 != null)
		{
			goto IL_03dc;
		}
		goto IL_06f4;
		IL_0243:
		object obj29 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2096;
		object obj30 = (nint)0 + (nint)2432;
		obj19 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		num2 = (nint)obj30;
		Func<object> func = default(Func<object>);
		func..ctor((object)this, (IntPtr)obj30);
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
		object obj31;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+B8]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v20+8]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v20+8]");
			bool flag10 = (nint)0 == 0;
			object obj32 = obj18;
			if (!flag10)
			{
				goto IL_0316;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+B8]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v20+8]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v20+8]");
			bool flag11 = (nint)0 == 0;
			object obj33 = !flag11;
			object obj32 = obj18;
			if (obj33 != null)
			{
				goto IL_0316;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj34 = !flag12;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v27+B8]");
			obj31 = 0;
		}
		object obj36 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)1912;
		num2 = (nint)obj37;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj31, (IntPtr)obj37);
		object obj38 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v25+B8]");
		object obj39 = (nint)0 + (nint)8;
		obj39 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
		bool flag13 = (nint)0 == 0;
		object obj40 = !flag13;
		obj13 = 0;
		obj14 = action5;
		action2 = action5;
		obj15 = 0;
		num = (nint)obj37;
		obj16 = action5;
		obj17 = obj18;
		action = action5;
		if (obj40 != null)
		{
			goto IL_036f;
		}
		goto IL_066a;
		IL_0431:
		object obj41 = typeof(List<Tween>) + 3000;
		object obj42 = (nint)0 + (nint)3776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+B8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v33+18]");
		Action<object> action6 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v33+18]");
		bool flag14 = (nint)0 == 0;
		object obj44 = !flag14;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
			bool flag15 = (nint)0 == 0;
			object obj45 = !flag15;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj46 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v39+B8]");
				obj43 = 0;
			}
			object obj47 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj48 = (nint)0 + (nint)1928;
			num2 = (nint)obj48;
			Action<object> action7 = default(Action<object>);
			action7..ctor(obj43, (IntPtr)obj48);
			object obj49 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v38+B8]");
			object obj50 = (nint)0 + (nint)24;
			obj50 = action7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action6 = action7;
			obj13 = 0;
			obj14 = action7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C3500");
		object obj51 = this + 96;
		object obj52 = default(object);
		obj51 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_06f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v8+E4]");
		bool flag16 = (nint)0 == 0;
		object obj53 = !flag16;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj54 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v15+B8]");
			obj26 = 0;
		}
		object obj55 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj56 = (nint)0 + (nint)1920;
		num2 = (nint)obj56;
		Action<object> action8 = default(Action<object>);
		action8..ctor(obj26, (IntPtr)obj56);
		object obj57 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v13+B8]");
		object obj58 = (nint)0 + (nint)16;
		obj58 = action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+E4]");
		bool flag17 = (nint)0 == 0;
		object obj59 = !flag17;
		obj13 = 0;
		obj14 = action8;
		action2 = action;
		action3 = action8;
		obj20 = 0;
		num3 = (nint)obj56;
		obj21 = action8;
		obj22 = obj18;
		action4 = action8;
		if (obj59 != null)
		{
			goto IL_0431;
		}
		goto IL_07cd;
		IL_036f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v31+B8]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v8+10]");
		action3 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v8+10]");
		bool flag18 = (nint)0 == 0;
		obj15 = obj13;
		num = num2;
		obj16 = obj14;
		obj28 = obj18;
		action = action2;
		if (!flag18)
		{
			goto IL_03dc;
		}
		goto IL_06f4;
	}

	public AudioSource PlayClipWithExtras(SingleSoundWithExtras singleSoundWithExtras, SoundOptions options, bool autoReturn = true)
	{
		if ((object)singleSoundWithExtras != null)
		{
			return PlayClipWithExtras(singleSoundWithExtras.clip, options, singleSoundWithExtras.<Volume>k__BackingField, singleSoundWithExtras.<Pitch>k__BackingField, singleSoundWithExtras.<Loop>k__BackingField, autoReturn);
		}
		return (AudioSource)(object)new NullReferenceException();
	}

	public AudioSource PlayClipWithExtras(AudioClip clip, SoundOptions options, float volume = 1f, float pitch = 1f, bool loop = false, bool autoReturn = true)
	{
		//IL_0031: Expected O, but got I4
		//IL_006f: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		AudioSource result;
		if (options != null)
		{
			bool flag = SoundManager.IsChannelMuted(options.channel);
			bool flag2 = !flag;
			object obj = !flag2;
			result = null;
			if (obj != null)
			{
				goto IL_0181;
			}
			if (_pooledAudioSources != null)
			{
				object obj2 = (nint)0 + (nint)3784;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C364C");
				AudioSource audioSource = default(AudioSource);
				if ((object)audioSource != null)
				{
					audioSource.clip = clip;
					audioSource.volume = volume;
					audioSource.pitch = pitch;
					audioSource.loop = loop;
					audioSource.Play();
					bool flag3 = !autoReturn;
					result = audioSource;
					if (!flag3)
					{
						if ((object)clip == null)
						{
							goto IL_0186;
						}
						float length = clip.length;
						object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 128;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj4 = default(object);
						obj4..ctor();
						_ = 0;
						object obj5 = obj4 + 40;
						obj5 = this;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj6 = obj4 + 48;
						obj6 = audioSource;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Coroutine coroutine = StartCoroutine((IEnumerator)obj4);
						result = audioSource;
					}
					goto IL_0181;
				}
			}
		}
		goto IL_0186;
		IL_0181:
		return result;
		IL_0186:
		return (AudioSource)(object)new NullReferenceException();
	}

	private IEnumerator ReturnAfter(AudioSource audioSource, float seconds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 48;
		obj4 = audioSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public GameSoundManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary = default(Dictionary<int, object>);
		dictionary..ctor();
		object obj2 = this + 72;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <SetSoundActors>g__AssignSound|17_0(int i, ref <>c__DisplayClass17_0 P_1)
	{
		//IL_006a: Expected O, but got I
		int key = i + 1;
		if (!((Dictionary<int, object>)(object)_playerSounds).ContainsKey(key))
		{
			SoundActors soundActors = SoundActors;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass17_0&)+8]");
			int id = ((List<int>)0).get_Item(i);
			Dictionary<int, object>.ValueCollection values = ((Dictionary<int, object>)(object)_playerSounds).Values;
			SoundActor uniqueOfSameGroup = soundActors.GetUniqueOfSameGroup(id, (IEnumerable<SoundActor>)(object)values);
			int key2 = i + 1;
			((Dictionary<int, object>)(object)_playerSounds).set_Item(key2, (object)uniqueOfSameGroup);
		}
	}

	private AudioSource <InitPooledAudioSources>b__32_0()
	{
		//IL_0011: Expected O, but got I
		if ((object)_poolParentGameObject != null)
		{
			object obj = (nint)0 + (nint)552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
			AudioSource result = default(AudioSource);
			return result;
		}
		return (AudioSource)(object)new NullReferenceException();
	}
}
