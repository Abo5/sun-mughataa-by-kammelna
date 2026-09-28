using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine.Networking;
using UnityEngine.TextCore;

public abstract class UnityWebRequestAssetLoader : IAssetLoader
{
	private sealed class <LoadAsset>d__6<T> : IEnumerator<object>, IEnumerator, IDisposable where T : class
	{
		private int <>1__state;

		private object <>2__current;

		public UnityWebRequestAssetLoader <>4__this;

		public AssetLoadingModel<T> asset;

		private IRemoteAssetTypeAdaptor<T> <adaptor>5__2;

		private UnityWebRequest <assetRequest>5__3;

		private IEnumerator <operation>5__4;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadAsset>d__6(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_03f6: Expected I4, but got I8
			//IL_0add: Expected I4, but got O
			//IL_0265: Expected I4, but got I8
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Expected O, but got Unknown
			//IL_0417: Expected I, but got O
			//IL_0427: Expected O, but got I
			//IL_004a: Expected O, but got I4
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Expected O, but got Unknown
			//IL_04df: Expected O, but got I4
			//IL_04e8: Expected O, but got I4
			//IL_0462: Expected O, but got I
			//IL_0067: Expected I4, but got I8
			//IL_07af: Expected I, but got O
			//IL_07bf: Expected O, but got I
			//IL_0736: Unknown result type (might be due to invalid IL or missing references)
			//IL_073b: Expected O, but got Unknown
			//IL_0744: Unknown result type (might be due to invalid IL or missing references)
			//IL_0749: Expected O, but got Unknown
			//IL_075c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0761: Expected O, but got Unknown
			//IL_009c: Expected O, but got I
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_0103: Expected O, but got I4
			//IL_084e: Expected O, but got I4
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Expected O, but got Unknown
			//IL_047e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Expected O, but got Unknown
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected O, but got Unknown
			//IL_031a: Expected O, but got I4
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca0: Expected O, but got Unknown
			//IL_07fa: Expected O, but got I
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected O, but got Unknown
			//IL_0383: Expected O, but got I4
			//IL_03b6: Expected O, but got I
			//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Expected O, but got Unknown
			//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a20: Expected O, but got Unknown
			//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2d: Expected O, but got Unknown
			//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3b: Expected O, but got Unknown
			//IL_018d: Expected O, but got I
			//IL_01a3: Expected O, but got I
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_01cb: Expected O, but got I4
			//IL_0808: Unknown result type (might be due to invalid IL or missing references)
			//IL_080d: Expected O, but got Unknown
			//IL_0816: Unknown result type (might be due to invalid IL or missing references)
			//IL_081b: Expected O, but got Unknown
			//IL_0b14: Expected O, but got I
			//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b72: Expected O, but got Unknown
			//IL_0b94: Expected O, but got I
			//IL_0206: Expected O, but got I
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d0: Expected O, but got Unknown
			//IL_0884: Expected O, but got I
			//IL_0897: Unknown result type (might be due to invalid IL or missing references)
			//IL_089c: Expected O, but got Unknown
			//IL_08c6: Expected O, but got I4
			//IL_0869: Unknown result type (might be due to invalid IL or missing references)
			//IL_086e: Expected O, but got Unknown
			//IL_0621: Expected O, but got I
			//IL_0637: Expected O, but got I
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0645: Expected O, but got Unknown
			//IL_065f: Expected O, but got I4
			//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0904: Expected O, but got Unknown
			//IL_092e: Expected O, but got I4
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Expected O, but got Unknown
			//IL_0c0e: Expected I, but got O
			//IL_0c1e: Expected O, but got I
			//IL_095e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0963: Expected O, but got Unknown
			//IL_06f5: Expected O, but got I
			//IL_071b: Expected O, but got I4
			//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab2: Expected O, but got Unknown
			//IL_069a: Expected O, but got I
			//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a9: Expected O, but got Unknown
			//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4e: Expected O, but got Unknown
			//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5b: Expected O, but got Unknown
			//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a69: Expected O, but got Unknown
			//IL_0a79: Expected O, but got I
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Expected O, but got Unknown
			//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bb: Expected O, but got Unknown
			//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ef: Expected O, but got Unknown
			object obj26;
			object obj40;
			if (<>1__state != 2)
			{
				UnityWebRequestAssetLoader unityWebRequestAssetLoader = <>4__this;
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_0ac9;
					}
					<>1__state = -1;
					if (<>4__this != null)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v39 (Il2CppRgctx<UnityWebRequestAssetLoader+<LoadAsset>d__6`1>)+10]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X1_v26+50]");
						object obj3 = unityWebRequestAssetLoader + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1950");
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v366 @ X0_v59+8] (should have been resolved before IL gen)");
						object obj4 = typeof(RegisteredWaitHandle) + 32;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v62+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEE99C");
						object obj7 = this + 48;
						object obj8 = default(object);
						obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj9 = obj7;
						if (obj7 != null)
						{
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v49 (Il2CppRgctx<UnityWebRequestAssetLoader+<LoadAsset>d__6`1>)+20]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v49 (Il2CppRgctx<UnityWebRequestAssetLoader+<LoadAsset>d__6`1>)+20]");
							object obj11 = (nint)0 + (nint)309;
							object obj12 = obj11 & 1;
							bool flag3 = obj12 == null;
							object obj13 = !flag3;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
								object obj14 = default(object);
								obj10 = obj14;
							}
							object obj15 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v52+12E]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v52+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0247;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v52+B0]");
							object obj17 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X10_v25-8]");
								if (0 == (nint)obj10)
								{
									break;
								}
								obj17 += 16;
								obj16--;
								if ((nint)obj16 != 1)
								{
									continue;
								}
								goto IL_0247;
							}
							object obj18 = obj15 + obj17;
							object obj19 = obj18 + 312;
							goto IL_0b5d;
						}
					}
				}
				else
				{
					<>1__state = -1;
					if (<assetRequest>5__3 != null)
					{
						long responseCode = <assetRequest>5__3.responseCode;
						if (responseCode == 304)
						{
							AssetLoadingModel<T> assetLoadingModel = asset;
							if (asset != null)
							{
								object obj20 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
								object obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v46+E4]");
								bool flag4 = (nint)0 == 0;
								object obj22 = !flag4;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								FileUtils.UpdateLastWriteTime(assetLoadingModel.<LocalPath>k__BackingField);
								object obj23 = typeof(RegisteredWaitHandle) + 40;
								object obj24 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v49+E4]");
								bool flag5 = (nint)0 == 0;
								object obj25 = !flag5;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v36 (Il2CppRgctx<UnityWebRequestAssetLoader+<LoadAsset>d__6`1>)+38]");
								obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEF7C0");
								object obj27 = this + 64;
								object obj28 = default(object);
								obj27 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								goto IL_0bb9;
							}
						}
						else if (<assetRequest>5__3 != null)
						{
							UnityWebRequest.Result result = <assetRequest>5__3.result;
							if (result != UnityWebRequest.Result.Success)
							{
								goto IL_0ac9;
							}
							if (<assetRequest>5__3 != null)
							{
								DownloadHandler downloadHandler = <assetRequest>5__3.downloadHandler;
								if (downloadHandler != null)
								{
									byte[] data = downloadHandler.data;
									if (asset != null)
									{
										object obj29 = asset + 64;
										obj29 = data;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										IRemoteAssetTypeAdaptor<T> remoteAssetTypeAdaptor = <adaptor>5__2;
										if (<adaptor>5__2 != null)
										{
											nint num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v20 (Il2CppRgctx<UnityWebRequestAssetLoader+<LoadAsset>d__6`1>)+20]");
											object obj30 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v20 (Il2CppRgctx<UnityWebRequestAssetLoader+<LoadAsset>d__6`1>)+20]");
											object obj31 = (nint)0 + (nint)309;
											object obj32 = obj31 & 1;
											bool flag6 = obj32 == null;
											object obj33 = !flag6;
											if (obj33 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
												object obj34 = default(object);
												obj30 = obj34;
											}
											nint num6 = (nint)remoteAssetTypeAdaptor;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v23 (Il2CppClass<IRemoteAssetTypeAdaptor`1<T>>)+12E]");
											object obj35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v23 (Il2CppClass<IRemoteAssetTypeAdaptor`1<T>>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_06db;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v23 (Il2CppClass<IRemoteAssetTypeAdaptor`1<T>>)+B0]");
											object obj36 = (nint)0 + (nint)8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X10_v19-8]");
												if (0 == (nint)obj30)
												{
													break;
												}
												obj36 += 16;
												obj35--;
												if ((nint)obj35 != 1)
												{
													continue;
												}
												goto IL_06db;
											}
											object obj37 = obj36 + 1;
											object obj38 = num6 + obj37;
											object obj39 = obj38 + 312;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v41+8]");
											obj40 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v730 @ X0_v41] (should have been resolved before IL gen)");
											if (asset != null)
											{
												goto IL_0aa2;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_0acf;
			}
			<>1__state = -1;
			goto IL_0bb9;
			IL_0bb9:
			IEnumerator enumerator = <operation>5__4;
			object obj41;
			if (<operation>5__4 != null)
			{
				obj41 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num7 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04a3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj43 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X10_v11-8]");
					if (0 == (nint)obj41)
					{
						break;
					}
					obj43 += 16;
					obj42--;
					if ((nint)obj42 != 1)
					{
						continue;
					}
					goto IL_04a3;
				}
				object obj44 = num7 + obj43;
				object obj45 = obj44 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v484 @ X0_v17] (should have been resolved before IL gen)");
				object obj47 = default(object);
				object obj46 = obj47 & 1;
				if (obj46 != null)
				{
					goto IL_077e;
				}
				goto IL_0ac9;
			}
			goto IL_0acf;
			IL_04a3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v439 @ X0_v14] (should have been resolved before IL gen)");
			object obj49 = default(object);
			object obj48 = obj49 & 1;
			bool flag7 = obj48 == null;
			object obj50 = !flag7;
			obj26 = 0;
			if (obj50 != null)
			{
				goto IL_077e;
			}
			goto IL_0ac9;
			IL_0b5d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v649 @ X0_v69] (should have been resolved before IL gen)");
			object obj51 = this + 56;
			object obj52 = default(object);
			obj51 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X20_v9-10]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X20_v9-10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v55+20]");
				DateTime lastWriteTime = File.GetLastWriteTime((string)0);
				object obj54 = typeof(DataRelation) + 712;
				object obj55 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v76+E4]");
				bool flag8 = (nint)0 == 0;
				object obj56 = !flag8;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime2 = default(DateTime);
				DateTime dateTime = dateTime2.ToUniversalTime();
				object obj57 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
				object obj58 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X0_v80+E4]");
				bool flag9 = (nint)0 == 0;
				object obj59 = !flag9;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				object obj60 = "com.unity.services.authentication.profile" + 3352;
				DateTime dateTime3 = default(DateTime);
				string value = dateTime3.ToString((string)obj60, invariantCulture);
				if (obj51 != null)
				{
					object name = "HH:mm:ss.ffZ" + 3376;
					((UnityWebRequest)obj51).SetRequestHeader((string)name, value);
					if (obj51 != null)
					{
						UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = ((UnityWebRequest)obj51).SendWebRequest();
						object obj61 = this + 24;
						obj61 = unityWebRequestAsyncOperation;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						return true;
					}
				}
			}
			goto IL_0acf;
			IL_077e:
			IEnumerator enumerator2 = <operation>5__4;
			if (<operation>5__4 == null)
			{
				goto IL_0acf;
			}
			nint num8 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_083b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj63 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X10_v6-8]");
				if (0 == (nint)obj41)
				{
					break;
				}
				obj63 += 16;
				obj62--;
				if ((nint)obj62 != 1)
				{
					continue;
				}
				goto IL_083b;
			}
			object obj64 = obj63 + 1;
			object obj65 = num8 + obj64;
			object obj66 = obj65 + 312;
			goto IL_0c8b;
			IL_0247:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0b5d;
			IL_083b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj26 = 1;
			goto IL_0c8b;
			IL_0ac9:
			return false;
			IL_0c8b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v585 @ X0_v4] (should have been resolved before IL gen)");
			object obj67 = this + 24;
			object obj68 = default(object);
			obj67 = obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 2;
			return true;
			IL_0acf:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0aa2:
			object obj69 = asset + 72;
			object obj70 = default(object);
			obj69 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0ac9;
			IL_06db:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v38+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v703 @ X0_v38] (should have been resolved before IL gen)");
			bool flag10 = asset == null;
			object obj71 = !flag10;
			if (obj71 != null)
			{
				goto IL_0aa2;
			}
			goto IL_0acf;
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private const string IfModifiedSinceHeader = "If-Modified-Since";

	private const string HttpDateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

	public abstract bool IsLocalOnly { get; }

	protected abstract string GetAssetUrl<T>(AssetLoadingModel<T> asset) where T : class;

	public abstract void CacheLoadedAsset<T>(AssetLoadingModel<T> asset) where T : class;

	public virtual IEnumerator LoadAsset<T>(AssetLoadingModel<T> asset) where T : class
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b9: Expected I4, but got O
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00dc: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerator enumerator = default(IEnumerator);
		((<LoadAsset>d__6<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<LoadAsset>d__6<T> <LoadAsset>d__ = (<LoadAsset>d__6<T>)(enumerator + 32);
			<LoadAsset>d__ = (<LoadAsset>d__6<T>)(object)this;
			<LoadAsset>d__..ctor((int)this);
			<LoadAsset>d__6<T> <LoadAsset>d__2 = (<LoadAsset>d__6<T>)(enumerator + 40);
			<LoadAsset>d__2 = (<LoadAsset>d__6<T>)(object)asset;
			<LoadAsset>d__2..ctor((int)asset);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public virtual void DeleteAsset(string assetId, string localAssetPath)
	{
	}

	public void ResetEnvironment()
	{
	}
}
