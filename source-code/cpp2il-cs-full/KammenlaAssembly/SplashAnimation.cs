using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class SplashAnimation : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<bool> <>9__17_0;

		public static Func<bool> <>9__18_0;

		public static Func<bool> <>9__20_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <LogoAnimation>b__17_0()
		{
			return IsPlaying;
		}

		internal bool <Switch>b__18_0()
		{
			return IsPlaying;
		}

		internal bool <HideImmediate>b__20_0()
		{
			return IsPlaying;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public RectTransform logo;

		public RectTransform originalParent;

		public SplashAnimation <>4__this;

		internal void <Switch>b__1()
		{
			logo.SetParent(originalParent);
			<>4__this.PrepareTransitionLoading();
		}
	}

	private sealed class <HideImmediate>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public SplashAnimation <>4__this;

		public Action callback;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <HideImmediate>d__20(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0191: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_030f: Expected I4, but got O
			//IL_003e: Expected I4, but got I8
			//IL_0061: Expected O, but got I4
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_00ad: Expected O, but got I4
			//IL_036d: Expected O, but got I
			//IL_037d: Expected O, but got I
			//IL_039f: Expected O, but got I4
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Expected O, but got Unknown
			//IL_00f4: Expected O, but got I4
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Expected O, but got Unknown
			//IL_03d7: Expected O, but got I
			//IL_03e8: Expected I, but got O
			//IL_0406: Expected O, but got I
			//IL_0124: Expected O, but got I
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected O, but got Unknown
			//IL_02a2: Expected O, but got I4
			SplashAnimation splashAnimation = <>4__this;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0338;
				}
				<>1__state = -1;
				bool isDone = IsDone;
				bool flag2 = !isDone;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					object obj3 = typeof(SkeletonBinary.SkeletonInput) + 672;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v20+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj4 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v20+B8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v17+18]");
					Func<bool> predicate = (Func<bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v17+18]");
					bool flag4 = (nint)0 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v20+E4]");
						bool flag5 = (nint)0 == 0;
						object obj8 = !flag5;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj9 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v23+B8]");
							obj6 = 0;
						}
						object obj10 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj11 = (nint)0 + (nint)672;
						Func<bool> func = default(Func<bool>);
						func..ctor(obj6, (IntPtr)obj11);
						object obj12 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v22+B8]");
						object obj13 = (nint)0 + (nint)24;
						obj13 = func;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						predicate = func;
					}
					object obj14 = typeof(UsageHint) + 1688;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					WaitWhile waitWhile = default(WaitWhile);
					waitWhile..ctor(predicate);
					object obj15 = this + 24;
					obj15 = waitWhile;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
			}
			else
			{
				<>1__state = -1;
			}
			if ((object)<>4__this != null && (object)splashAnimation.canvas != null)
			{
				GameObject gameObject = splashAnimation.canvas.gameObject;
				if ((object)gameObject != null)
				{
					gameObject.SetActive(value: false);
					if ((object)splashAnimation.logoAnimation != null)
					{
						GameObject gameObject2 = splashAnimation.logoAnimation.gameObject;
						if ((object)gameObject2 != null)
						{
							gameObject2.SetActive(value: false);
							<>4__this.PrepareTransitionLoading();
							object obj16 = typeof(RegisteredWaitHandle) + 3136;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v10+E4]");
							bool flag6 = (nint)0 == 0;
							object obj18 = !flag6;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							ScreenManager.AnimateTransitionIn();
							Action action = callback;
							if (callback != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							}
							goto IL_0338;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0338:
			return false;
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
			object obj2 = (nint)0 + (nint)704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <LogoAnimation>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public SplashAnimation <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LogoAnimation>d__17(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0441: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_00d3: Expected I4, but got I8
			//IL_041b: Expected I4, but got O
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_008c: Expected O, but got I4
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_01ec: Expected O, but got I
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_0243: Expected O, but got I4
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_0302: Expected O, but got I
			//IL_0312: Expected O, but got I
			//IL_0334: Expected O, but got I4
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Expected O, but got Unknown
			//IL_0280: Expected O, but got I
			//IL_0290: Expected O, but got I
			//IL_02b2: Expected O, but got I4
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Expected O, but got Unknown
			//IL_037f: Expected O, but got I4
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Expected O, but got Unknown
			//IL_04db: Expected O, but got I
			//IL_04e3: Expected I, but got O
			//IL_04f4: Expected I, but got O
			//IL_0512: Expected O, but got I
			//IL_0535: Expected I4, but got O
			//IL_03af: Expected O, but got I
			SplashAnimation splashAnimation = <>4__this;
			bool flag = <>1__state < 2;
			object obj = !flag;
			object obj9;
			object obj11;
			Func<bool> predicate;
			nint num2;
			int num;
			LoadSceneMode loadSceneMode;
			if (obj == null)
			{
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					int waitFrames = splashAnimation.waitFrames - 1;
					splashAnimation.waitFrames = waitFrames;
					if (splashAnimation.waitFrames > 0)
					{
						object obj2 = this + 24;
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						return true;
					}
					if ((object)splashAnimation.mainTheme != null)
					{
						splashAnimation.mainTheme.Play();
						if ((object)splashAnimation.logoAnimation != null)
						{
							bool flag2 = splashAnimation.logoAnimation.Play();
							object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
							object obj4 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11+B8]");
							object obj5 = 0;
							_ = 1;
							string name = ScenesEnumExtensions.GetName(Scenes.FetchServer);
							object obj6 = typeof(SqlSingle[]) + 3048;
							object obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v15+E4]");
							bool flag3 = (nint)0 == 0;
							object obj8 = !flag3;
							object key = name;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								key = name;
							}
							AsyncOperationHandle<SceneInstance> asyncOperationHandle = Addressables.LoadSceneAsync(key);
							obj9 = typeof(SkeletonBinary.SkeletonInput) + 672;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v22+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v22+B8]");
								obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v23+8]");
								predicate = (Func<bool>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v23+8]");
								bool flag4 = (nint)0 == 0;
								object obj12 = !flag4;
								num = 100;
								num2 = 1;
								loadSceneMode = LoadSceneMode.Single;
								if (obj12 == null)
								{
									goto IL_035d;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj10 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v22+B8]");
								obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v23+8]");
								predicate = (Func<bool>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v23+8]");
								bool flag5 = (nint)0 == 0;
								object obj13 = !flag5;
								num = 100;
								num2 = 1;
								loadSceneMode = LoadSceneMode.Single;
								if (obj13 == null)
								{
									goto IL_035d;
								}
							}
							goto IL_03b4;
						}
					}
				}
			}
			else
			{
				if (<>1__state != 2)
				{
					goto IL_0156;
				}
				<>1__state = -1;
				if ((object)<>4__this != null && (object)splashAnimation.loadingSection != null)
				{
					GameObject gameObject = splashAnimation.loadingSection.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(value: true);
						goto IL_0156;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0156:
			return false;
			IL_035d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v29+B8]");
				obj11 = 0;
			}
			object obj16 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)680;
			num2 = (nint)obj17;
			Func<bool> func = default(Func<bool>);
			func..ctor(obj11, (IntPtr)obj17);
			object obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v28+B8]");
			object obj19 = (nint)0 + (nint)8;
			obj19 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = 0;
			loadSceneMode = (LoadSceneMode)func;
			predicate = func;
			goto IL_03b4;
			IL_03b4:
			object obj20 = typeof(UsageHint) + 1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitWhile waitWhile = default(WaitWhile);
			waitWhile..ctor(predicate);
			object obj21 = this + 24;
			obj21 = waitWhile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 2;
			return true;
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
			object obj2 = (nint)0 + (nint)712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <Switch>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public SplashAnimation <>4__this;

		private <>c__DisplayClass18_0 <>8__1;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Switch>d__18(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_01e6: Expected I4, but got I8
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected O, but got Unknown
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_143d: Expected I4, but got O
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Expected O, but got Unknown
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Expected O, but got Unknown
			//IL_0040: Expected I4, but got I8
			//IL_0063: Expected O, but got I4
			//IL_0330: Expected O, but got I
			//IL_0340: Expected O, but got I
			//IL_0362: Expected O, but got I4
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Expected O, but got Unknown
			//IL_02bf: Expected O, but got I
			//IL_02cf: Expected O, but got I
			//IL_02f1: Expected O, but got I4
			//IL_0407: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Expected O, but got Unknown
			//IL_039c: Expected O, but got I4
			//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c2: Expected O, but got Unknown
			//IL_14d8: Expected O, but got I
			//IL_14e9: Expected I, but got O
			//IL_1507: Expected O, but got I
			//IL_03cc: Expected O, but got I
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_0461: Expected O, but got I4
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_047f: Expected O, but got Unknown
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_0525: Expected O, but got I4
			//IL_052f: Expected O, but got I4
			//IL_04d4: Expected O, but got I4
			//IL_147d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1482: Expected O, but got Unknown
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_063d: Expected O, but got Unknown
			//IL_0646: Expected O, but got I4
			//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cb: Expected O, but got Unknown
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f8: Expected O, but got Unknown
			//IL_0786: Unknown result type (might be due to invalid IL or missing references)
			//IL_078b: Expected O, but got Unknown
			//IL_07a3: Expected O, but got I
			//IL_0927: Unknown result type (might be due to invalid IL or missing references)
			//IL_092c: Expected O, but got Unknown
			//IL_093c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0941: Expected O, but got Unknown
			//IL_096f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0974: Expected O, but got Unknown
			//IL_0992: Unknown result type (might be due to invalid IL or missing references)
			//IL_0997: Expected O, but got Unknown
			//IL_0b02: Expected O, but got I4
			//IL_0b94: Expected O, but got I4
			//IL_0c26: Expected O, but got I4
			//IL_0cb8: Expected O, but got I4
			//IL_0d4a: Expected O, but got I4
			//IL_0ddc: Expected O, but got I4
			//IL_0fc4: Expected O, but got I4
			//IL_1022: Expected O, but got I4
			//IL_1079: Expected O, but got I
			//IL_117d: Expected O, but got I4
			//IL_1186: Expected F4, but got I4
			//IL_118e: Expected O, but got Ref
			//IL_119f: Expected F4, but got I4
			//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ab: Expected O, but got Unknown
			//IL_15d5: Expected O, but got I4
			//IL_1242: Expected F4, but got I
			//IL_1242: Expected O, but got I4
			//IL_111a: Expected O, but got I4
			//IL_1293: Expected F4, but got I
			//IL_1293: Expected O, but got I4
			//IL_12a3: Expected O, but got I
			//IL_1146: Expected O, but got I4
			//IL_12ff: Expected F4, but got I
			//IL_12ff: Expected O, but got I4
			//IL_135f: Expected F4, but got I
			//IL_135f: Expected O, but got I4
			//IL_13bf: Expected F4, but got I
			//IL_13bf: Expected O, but got I4
			//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e6: Expected O, but got Unknown
			//IL_13fc: Expected O, but got I
			//IL_140f: Expected I, but got O
			//IL_1420: Expected O, but got I
			SplashAnimation splashAnimation;
			object obj3;
			Transform transform3;
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					splashAnimation = <>4__this;
					<>1__state = -1;
					bool isDone = IsDone;
					bool flag = !isDone;
					object obj = !flag;
					if (obj == null)
					{
						if ((object)<>4__this != null && (object)splashAnimation.logoAnimation != null)
						{
							GameObject gameObject = splashAnimation.logoAnimation.gameObject;
							if ((object)gameObject != null)
							{
								gameObject.SetActive(value: false);
								object tag = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3608;
								GameObject gameObject2 = GameObject.FindWithTag((string)tag);
								if ((object)gameObject2 != null)
								{
									Transform transform = gameObject2.transform;
									if (<>8__1 != null)
									{
										if ((object)transform == null)
										{
											goto IL_0448;
										}
										object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
										Transform transform2 = ((transform != obj2) ? null : transform);
										obj3 = <>8__1 + 16;
										obj3 = transform2;
										if (transform == obj2)
										{
											transform3 = transform;
										}
										else
										{
											transform3 = null;
										}
										goto IL_15e3;
									}
								}
								else if (<>8__1 != null)
								{
									goto IL_0448;
								}
							}
						}
						goto IL_142f;
					}
				}
				goto IL_145c;
			}
			<>1__state = -1;
			object obj4 = typeof(SkeletonBinary.SkeletonInput) + 680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = default(object);
			obj5..ctor();
			object obj6 = this + 40;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8;
			object obj10;
			Func<bool> predicate;
			Func<bool> func;
			if (obj6 != null)
			{
				object obj7 = obj6 + 32;
				obj7 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj8 = typeof(SkeletonBinary.SkeletonInput) + 672;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v19+B8]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v14+10]");
					predicate = (Func<bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v14+10]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					func = (Func<bool>)(object)<>4__this;
					if (obj11 == null)
					{
						goto IL_037a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v19+B8]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v14+10]");
					predicate = (Func<bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v14+10]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					func = (Func<bool>)(object)<>4__this;
					if (obj12 == null)
					{
						goto IL_037a;
					}
				}
				goto IL_03d1;
			}
			goto IL_142f;
			IL_11b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			float num2;
			float num = num2;
			SlideAnimationHelper slideAnimationHelper;
			UnityEngine.Object obj13 = slideAnimationHelper;
			goto IL_158a;
			IL_142f:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_152e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>c__DisplayClass18_0 <>c__DisplayClass18_ = <>8__1;
			object obj27;
			if (<>8__1 != null && (object)<>c__DisplayClass18_.logo != null)
			{
				Transform root = <>c__DisplayClass18_.logo.root;
				<>c__DisplayClass18_.logo.SetParent(root);
				<>c__DisplayClass18_0 <>c__DisplayClass18_2 = <>8__1;
				if (<>8__1 != null && (object)<>c__DisplayClass18_2.logo != null)
				{
					Vector2 pivot = <>c__DisplayClass18_2.logo.pivot;
					<>c__DisplayClass18_0 <>c__DisplayClass18_3 = <>8__1;
					if (<>8__1 != null && (object)<>c__DisplayClass18_3.logo != null)
					{
						Vector2 anchoredPosition = <>c__DisplayClass18_3.logo.anchoredPosition;
						<>c__DisplayClass18_0 <>c__DisplayClass18_4 = <>8__1;
						if (<>8__1 != null && (object)<>c__DisplayClass18_4.originalParent != null)
						{
							object obj14 = typeof(UsageHint) + 744;
							object obj15 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v39+B8]");
							object obj16 = 0;
							Vector2 anchoredPosition2 = <>c__DisplayClass18_4.originalParent.anchoredPosition;
							<>c__DisplayClass18_0 <>c__DisplayClass18_5 = <>8__1;
							if (<>8__1 != null && (object)<>c__DisplayClass18_5.logo != null)
							{
								Vector2 anchorMax = <>c__DisplayClass18_5.logo.anchorMax;
								<>c__DisplayClass18_0 <>c__DisplayClass18_6 = <>8__1;
								if (<>8__1 != null && (object)<>c__DisplayClass18_6.logo != null)
								{
									Vector2 anchorMin = <>c__DisplayClass18_6.logo.anchorMin;
									<>c__DisplayClass18_0 <>c__DisplayClass18_7 = <>8__1;
									if (<>8__1 != null && (object)<>c__DisplayClass18_7.logo != null)
									{
										Vector2 sizeDelta = <>c__DisplayClass18_7.logo.sizeDelta;
										<>c__DisplayClass18_0 <>c__DisplayClass18_8 = <>8__1;
										if (<>8__1 != null && (object)<>c__DisplayClass18_8.logo != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v40+18]");
											object obj18 = default(object);
											object obj17 = 0 * obj18;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v40+1C]");
											object obj19 = 0 * obj18;
											object obj20 = obj18 + obj19;
											Vector3 localScale = <>c__DisplayClass18_8.logo.localScale;
											object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj22 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2432;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FD0BB4");
											if ((object)splashAnimation.animationLogo != null)
											{
												splashAnimation.animationLogo.SetParent(splashAnimation.canvas);
												<>c__DisplayClass18_0 <>c__DisplayClass18_9 = <>8__1;
												if (<>8__1 != null && (object)splashAnimation.animationLogo != null)
												{
													Transform parent = splashAnimation.animationLogo.parent;
													if ((object)<>c__DisplayClass18_9.logo != null)
													{
														<>c__DisplayClass18_9.logo.SetParent(parent, worldPositionStays: false);
														<>c__DisplayClass18_0 <>c__DisplayClass18_10 = <>8__1;
														if (<>8__1 != null && (object)splashAnimation.animationLogo != null)
														{
															Vector2 pivot2 = splashAnimation.animationLogo.pivot;
															if ((object)<>c__DisplayClass18_10.logo != null)
															{
																<>c__DisplayClass18_10.logo.pivot = (Vector2)0;
																<>c__DisplayClass18_0 <>c__DisplayClass18_11 = <>8__1;
																if (<>8__1 != null && (object)splashAnimation.animationLogo != null)
																{
																	Vector2 anchoredPosition3 = splashAnimation.animationLogo.anchoredPosition;
																	if ((object)<>c__DisplayClass18_11.logo != null)
																	{
																		<>c__DisplayClass18_11.logo.anchoredPosition = (Vector2)0;
																		<>c__DisplayClass18_0 <>c__DisplayClass18_12 = <>8__1;
																		if (<>8__1 != null && (object)splashAnimation.animationLogo != null)
																		{
																			Vector2 anchorMax2 = splashAnimation.animationLogo.anchorMax;
																			if ((object)<>c__DisplayClass18_12.logo != null)
																			{
																				<>c__DisplayClass18_12.logo.anchorMax = (Vector2)0;
																				<>c__DisplayClass18_0 <>c__DisplayClass18_13 = <>8__1;
																				if (<>8__1 != null && (object)splashAnimation.animationLogo != null)
																				{
																					Vector2 anchorMin2 = splashAnimation.animationLogo.anchorMin;
																					if ((object)<>c__DisplayClass18_13.logo != null)
																					{
																						<>c__DisplayClass18_13.logo.anchorMin = (Vector2)0;
																						<>c__DisplayClass18_0 <>c__DisplayClass18_14 = <>8__1;
																						if (<>8__1 != null && (object)splashAnimation.animationLogo != null)
																						{
																							Vector2 sizeDelta2 = splashAnimation.animationLogo.sizeDelta;
																							if ((object)<>c__DisplayClass18_14.logo != null)
																							{
																								<>c__DisplayClass18_14.logo.sizeDelta = (Vector2)0;
																								<>c__DisplayClass18_0 <>c__DisplayClass18_15 = <>8__1;
																								if (<>8__1 != null && (object)splashAnimation.animationLogo != null)
																								{
																									Vector3 localScale2 = splashAnimation.animationLogo.localScale;
																									if ((object)<>c__DisplayClass18_15.logo != null)
																									{
																										<>c__DisplayClass18_15.logo.localScale = (Vector3)0;
																										if ((object)splashAnimation.logoAnimation != null)
																										{
																											Transform transform4 = splashAnimation.logoAnimation.transform;
																											if ((object)splashAnimation.animationLogo != null)
																											{
																												splashAnimation.animationLogo.SetParent(transform4);
																												<>c__DisplayClass18_0 <>c__DisplayClass18_16 = <>8__1;
																												if (<>8__1 != null && (object)<>c__DisplayClass18_16.originalParent != null)
																												{
																													Transform root2 = <>c__DisplayClass18_16.originalParent.root;
																													if ((object)<>c__DisplayClass18_16.logo != null)
																													{
																														<>c__DisplayClass18_16.logo.SetParent(root2, worldPositionStays: false);
																														<>c__DisplayClass18_0 <>c__DisplayClass18_17 = <>8__1;
																														if (<>8__1 != null && (object)<>c__DisplayClass18_17.logo != null)
																														{
																															Vector2 sizeDelta3 = <>c__DisplayClass18_17.logo.sizeDelta;
																															<>c__DisplayClass18_0 <>c__DisplayClass18_18 = <>8__1;
																															if (<>8__1 != null && (object)<>c__DisplayClass18_18.logo != null)
																															{
																																Vector3 localScale3 = <>c__DisplayClass18_18.logo.localScale;
																																object obj23 = default(object);
																																if (obj23 != null)
																																{
																																	<>c__DisplayClass18_17.logo.sizeDelta = (Vector2)0;
																																	<>c__DisplayClass18_0 <>c__DisplayClass18_19 = <>8__1;
																																	if (<>8__1 != null && (object)<>c__DisplayClass18_19.logo != null)
																																	{
																																		<>c__DisplayClass18_19.logo.localScale = (Vector3)0;
																																		<>c__DisplayClass18_0 <>c__DisplayClass18_20 = <>8__1;
																																		if (<>8__1 != null && (object)<>c__DisplayClass18_20.logo != null)
																																		{
																																			object obj24 = (nint)0 + (nint)1144;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
																																			object obj25 = default(object);
																																			SlideAnimationHelper slideAnimationHelper2 = default(SlideAnimationHelper);
																																			if (obj25 == null)
																																			{
																																				object obj26 = obj27;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v79+E4]");
																																				bool flag4 = (nint)0 == 0;
																																				object obj28 = !flag4;
																																				num2 = 1.05360915E+09f;
																																				object obj29 = (object)(&slideAnimationHelper2);
																																				slideAnimationHelper = slideAnimationHelper2;
																																				num = 1.05360915E+09f;
																																				obj13 = slideAnimationHelper2;
																																				if (obj28 == null)
																																				{
																																					goto IL_11b5;
																																				}
																																				goto IL_158a;
																																			}
																																			if ((object)slideAnimationHelper2 != null)
																																			{
																																				slideAnimationHelper2.SlideIn();
																																				if ((object)slideAnimationHelper2 != null)
																																				{
																																					num = slideAnimationHelper2.duration;
																																					object obj26 = obj27;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v79+E4]");
																																					bool flag5 = (nint)0 == 0;
																																					object obj30 = !flag5;
																																					obj13 = slideAnimationHelper2;
																																					if (obj30 == null)
																																					{
																																						num2 = slideAnimationHelper2.duration;
																																						object obj29 = 0;
																																						slideAnimationHelper = slideAnimationHelper2;
																																						goto IL_11b5;
																																					}
																																					goto IL_158a;
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_142f;
			IL_158a:
			bool flag6 = obj13;
			object obj31 = typeof(RegisteredWaitHandle) + 3136;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X0_v103+E4]");
			bool flag7 = (nint)0 == 0;
			object obj33 = !flag7;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool withSlider = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
			ScreenManager.AnimateTransitionIn(withSlider);
			<>c__DisplayClass18_0 <>c__DisplayClass18_21 = <>8__1;
			if (<>8__1 != null)
			{
				RectTransform logo = <>c__DisplayClass18_21.logo;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v63+10]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPivot(logo, (Vector2)0, 0f);
				<>c__DisplayClass18_0 <>c__DisplayClass18_22 = <>8__1;
				if (<>8__1 != null)
				{
					RectTransform logo2 = <>c__DisplayClass18_22.logo;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v63+18]");
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPos(logo2, (Vector2)0, 0f);
					object obj34 = (nint)0 + (nint)2872;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					<>c__DisplayClass18_0 <>c__DisplayClass18_23 = <>8__1;
					if (<>8__1 != null)
					{
						RectTransform logo3 = <>c__DisplayClass18_23.logo;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v63+20]");
						TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOAnchorMax(logo3, (Vector2)0, 0f);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						<>c__DisplayClass18_0 <>c__DisplayClass18_24 = <>8__1;
						if (<>8__1 != null)
						{
							RectTransform logo4 = <>c__DisplayClass18_24.logo;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v63+28]");
							TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore4 = DOTweenModuleUI.DOAnchorMin(logo4, (Vector2)0, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							<>c__DisplayClass18_0 <>c__DisplayClass18_25 = <>8__1;
							if (<>8__1 != null)
							{
								RectTransform logo5 = <>c__DisplayClass18_25.logo;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v63+30]");
								TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = DOTweenModuleUI.DOSizeDelta(logo5, (Vector2)0, 0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
								object obj35 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj36 = (nint)0 + (nint)696;
								TweenCallback tweenCallback = default(TweenCallback);
								tweenCallback..ctor(<>8__1, (IntPtr)obj36);
								object obj37 = (nint)0 + (nint)2488;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
								goto IL_145c;
							}
						}
					}
				}
			}
			goto IL_142f;
			IL_037a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v19+E4]");
			bool flag8 = (nint)0 == 0;
			object obj38 = !flag8;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj39 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v20+B8]");
				obj10 = 0;
			}
			object obj40 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj41 = (nint)0 + (nint)688;
			Func<bool> func2 = default(Func<bool>);
			func2..ctor(obj10, (IntPtr)obj41);
			object obj42 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v19+B8]");
			object obj43 = (nint)0 + (nint)16;
			obj43 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = func2;
			predicate = func2;
			goto IL_03d1;
			IL_145c:
			return <>1__state == 0;
			IL_04e2:
			Interrupt();
			goto IL_145c;
			IL_03d1:
			object obj44 = typeof(UsageHint) + 1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitWhile waitWhile = default(WaitWhile);
			waitWhile..ctor(predicate);
			object obj45 = this + 24;
			obj45 = waitWhile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			goto IL_145c;
			IL_15e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>c__DisplayClass18_0 <>c__DisplayClass18_26 = <>8__1;
			if (<>8__1 != null)
			{
				obj27 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj46 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v29+E4]");
				if ((nint)0 != 0)
				{
					bool flag9 = <>c__DisplayClass18_26.logo == null;
					bool flag10 = !flag9;
					object obj47 = 0;
					if (!flag10)
					{
						goto IL_04e2;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag11 = <>c__DisplayClass18_26.logo == null;
					bool flag12 = !flag11;
					object obj48 = !flag12;
					object obj47 = 0;
					if (obj48 != null)
					{
						goto IL_04e2;
					}
				}
				<>c__DisplayClass18_0 <>c__DisplayClass18_27 = <>8__1;
				if (<>8__1 != null && (object)<>c__DisplayClass18_27.logo != null)
				{
					Transform parent2 = <>c__DisplayClass18_27.logo.parent;
					<>c__DisplayClass18_0 <>c__DisplayClass18_28;
					if ((object)parent2 != null)
					{
						object obj49 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
						if (parent2 == obj49)
						{
							<>c__DisplayClass18_27 = (<>c__DisplayClass18_0)(<>c__DisplayClass18_27 + 24);
							<>c__DisplayClass18_27 = (<>c__DisplayClass18_0)(object)parent2;
							bool flag13 = parent2 == obj49;
							<>c__DisplayClass18_28 = <>c__DisplayClass18_27;
							if (flag13)
							{
								goto IL_152e;
							}
						}
						throw new InvalidCastException();
					}
					<>c__DisplayClass18_28 = (<>c__DisplayClass18_0)(<>c__DisplayClass18_27 + 24);
					<>c__DisplayClass18_28 = (<>c__DisplayClass18_0)0;
					goto IL_152e;
				}
			}
			goto IL_142f;
			IL_0448:
			obj3 = <>8__1 + 16;
			obj3 = 0;
			transform3 = null;
			goto IL_15e3;
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
			object obj2 = (nint)0 + (nint)720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private int waitFrames = 3;

	private RectTransform canvas;

	private RectTransform animationLogo;

	private UnityEngine.Animation logoAnimation;

	private AudioSource mainTheme;

	private CanvasGroup loadingSection;

	private GameObject loadingLogo;

	private ElegantLoadingIndicator loader;

	private TextMeshProUGUI statusMessage;

	private static SplashAnimation _instance;

	private static bool _started;

	public static bool IsPlaying
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0047: Expected O, but got I
			//IL_0107: Expected O, but got I
			//IL_0139: Expected O, but got I4
			//IL_007c: Expected O, but got I
			//IL_01ac: Expected O, but got I
			//IL_0186: Expected O, but got I4
			//IL_024c: Expected I4, but got O
			//IL_022f: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CF9]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v9+B8]");
				object obj11 = 0;
				obj7 = (UnityEngine.Object)obj11;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				obj9 = (UnityEngine.Object)obj11;
				if (obj12 != null)
				{
					goto IL_00b9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj9 == null;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				goto IL_0194;
			}
			goto IL_0238;
			IL_0238:
			return true;
			IL_0194:
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5+8]");
			if ((nint)0 == 1)
			{
				object obj16 = obj15;
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6+38]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6+38]");
						return ((UnityEngine.Animation)0).isPlaying;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			goto IL_0238;
			IL_00b9:
			if (!(obj7 == null))
			{
				goto IL_0194;
			}
			goto IL_0238;
		}
	}

	public static bool IsDone
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0047: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0140: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_007c: Expected O, but got I
			//IL_01a4: Expected O, but got I
			//IL_024e: Expected I4, but got O
			//IL_01ff: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CFA]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+B8]");
				object obj11 = 0;
				obj7 = (UnityEngine.Object)obj11;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
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
			if (!flag3)
			{
				goto IL_00eb;
			}
			goto IL_018c;
			IL_00eb:
			return flag3;
			IL_018c:
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v3+B8]");
			object obj14 = 0;
			object obj15 = obj14;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v5+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v5+38]");
					GameObject gameObject = ((Component)0).gameObject;
					if ((object)gameObject != null)
					{
						bool activeSelf = gameObject.activeSelf;
						return (byte)((activeSelf ? 1u : 0u) ^ 1u) != 0;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00b9:
			flag3 = obj7 != null;
			bool flag4 = !flag3;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				goto IL_00eb;
			}
			goto IL_018c;
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_023c: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02f4: Expected O, but got I
		//IL_02b4: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DF2]");
		object obj4 = (nint)0 & (nint)1;
		UnityEngine.Object obj7;
		UnityEngine.Object obj9;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v22+B8]");
			object obj6 = 0;
			obj7 = (UnityEngine.Object)obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v19+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16+B8]");
			object obj11 = 0;
			obj7 = (UnityEngine.Object)obj11;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v19+E4]");
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
		object obj15 = 0;
		if (obj13 != null)
		{
			goto IL_00f2;
		}
		goto IL_01ec;
		IL_00f2:
		GameObject obj16 = base.gameObject;
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v20+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj16);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj16);
		return;
		IL_01ec:
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		object obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		UnityEngine.Object target = gameObject;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
		GameObject gameObject2 = loadingSection.gameObject;
		gameObject2.SetActive(value: false);
		object text = "LAK" + 2136;
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v10+B8]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v12+60]");
		TextMeshProExtensions.Localize((TextMeshProUGUI)0, (string)text);
		return;
		IL_00b9:
		bool flag6 = obj7 != null;
		bool flag7 = !flag6;
		obj14 = 0;
		obj15 = 0;
		if (!flag7)
		{
			goto IL_00f2;
		}
		goto IL_01ec;
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	private IEnumerator LogoAnimation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private IEnumerator Switch()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void PrepareTransitionLoading()
	{
		//IL_004f: Expected O, but got I4
		loadingLogo.SetActive(value: true);
		RectTransform gObject = UIExtensions.rectTransform(loadingSection);
		float? y = -200f;
		UIExtensions.MoveTo(gObject, isWorldPositions: false, (float?)(object)0, y);
	}

	private IEnumerator HideImmediate(Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 40;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public static void SwitchToScene()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = typeof(SkeletonBinary.SkeletonInput) + 704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 32;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = ((MonoBehaviour)obj3).StartCoroutine((IEnumerator)obj5);
	}

	public static void Interrupt(Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = typeof(SkeletonBinary.SkeletonInput) + 688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		_ = 0;
		object obj6 = obj5 + 32;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5 + 40;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = ((MonoBehaviour)obj3).StartCoroutine((IEnumerator)obj5);
	}

	public static void EndAnimation()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_007f: Expected O, but got I
		if (!IsDone)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+38]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(value: false);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+B8]");
			object obj6 = 0;
			((SplashAnimation)obj6).PrepareTransitionLoading();
		}
	}

	public static void StartLoading()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_0042: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_00a7: Expected O, but got I
		//IL_00ce: Expected O, but got I
		if (IsDone)
		{
			object text = "LAK" + 2136;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9+60]");
			TextMeshProExtensions.Localize((TextMeshProUGUI)0, (string)text);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v11+B8]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v13+28]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(value: true);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v14+B8]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v16+58]");
			((ElegantLoadingIndicator)0).ShowInitial(1f);
		}
	}

	public static void StopLoading()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_002a: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+28]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: false);
	}

	public static void SetStatusMessage(string status)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_002e: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1080;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+60]");
		TextMeshProExtensions.Localize((TextMeshProUGUI)0, status);
	}

	public static void AnimateTransition()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (IsDone)
		{
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				ScreenManager.AnimateTransitionIn();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ScreenManager.AnimateTransitionIn();
		}
		else
		{
			SwitchToScene();
		}
	}
}
