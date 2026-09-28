using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine.TextCore;

public class LocalUnityWebRequestAssetLoader : UnityWebRequestAssetLoader
{
	private sealed class <LoadAsset>d__3<T> : IEnumerator<object>, IEnumerator, IDisposable where T : class
	{
		private int <>1__state;

		private object <>2__current;

		public AssetLoadingModel<T> asset;

		public LocalUnityWebRequestAssetLoader <>4__this;

		private IEnumerator <operation>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadAsset>d__3(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0113: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_0382: Expected I4, but got O
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			//IL_0134: Expected I, but got O
			//IL_0144: Expected O, but got I
			//IL_003e: Expected I4, but got I8
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01fa: Expected O, but got I4
			//IL_017f: Expected O, but got I
			//IL_0081: Expected O, but got I
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Expected O, but got Unknown
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Expected O, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected O, but got Unknown
			//IL_032a: Expected O, but got I4
			//IL_0239: Expected I, but got O
			//IL_0249: Expected O, but got I
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_02d8: Expected O, but got I4
			//IL_00d3: Expected O, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Expected O, but got Unknown
			//IL_0284: Expected O, but got I
			//IL_034f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0354: Expected O, but got Unknown
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Expected O, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Expected O, but got Unknown
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected O, but got Unknown
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Expected O, but got Unknown
			bool flag2;
			object obj2;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0338;
				}
				<>1__state = -1;
				AssetLoadingModel<T> assetLoadingModel = asset;
				if (asset != null)
				{
					string <LocalPath>k__BackingField = assetLoadingModel.<LocalPath>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v19 (AssetLoadingModel`1<T>)+28]");
					flag2 = ValidateCachedFile(<LocalPath>k__BackingField, (DateTime?)(object)0);
					if (!flag2)
					{
						goto IL_03a1;
					}
					if (<>4__this != null)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v21 (Il2CppRgctx<LocalUnityWebRequestAssetLoader+<LoadAsset>d__3`1>)+20]");
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB591C");
						object obj3 = this + 48;
						object obj4 = default(object);
						obj3 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						goto IL_03a6;
					}
				}
				goto IL_0374;
			}
			<>1__state = -1;
			goto IL_03a6;
			IL_0374:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0208:
			IEnumerator enumerator = <operation>5__2;
			if (<operation>5__2 == null)
			{
				goto IL_0374;
			}
			nint num2 = (nint)enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02c5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			object obj7;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X10_v6-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_02c5;
			}
			object obj8 = obj6 + 1;
			object obj9 = num2 + obj8;
			object obj10 = obj9 + 312;
			goto IL_0417;
			IL_0417:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ X0_v4] (should have been resolved before IL gen)");
			object obj11 = this + 24;
			object obj12 = default(object);
			obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
			IL_02c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj2 = 1;
			goto IL_0417;
			IL_01c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X0_v14] (should have been resolved before IL gen)");
			object obj14 = default(object);
			object obj13 = obj14 & 1;
			bool flag3 = obj13 == null;
			obj2 = 0;
			if (!flag3)
			{
				goto IL_0208;
			}
			goto IL_0338;
			IL_0338:
			flag2 = false;
			goto IL_03a1;
			IL_03a6:
			IEnumerator enumerator2 = <operation>5__2;
			if (<operation>5__2 != null)
			{
				obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num3 = (nint)enumerator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01c0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v5 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj16 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v11-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj16 += 16;
					obj15--;
					if ((nint)obj15 != 1)
					{
						continue;
					}
					goto IL_01c0;
				}
				object obj17 = num3 + obj16;
				object obj18 = obj17 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v290 @ X0_v17] (should have been resolved before IL gen)");
				object obj20 = default(object);
				object obj19 = obj20 & 1;
				bool flag4 = obj19 == null;
				object obj21 = !flag4;
				if (obj21 != null)
				{
					goto IL_0208;
				}
				goto IL_0338;
			}
			goto IL_0374;
			IL_03a1:
			return flag2;
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

	public override bool IsLocalOnly => true;

	protected override string GetAssetUrl<T>(AssetLoadingModel<T> asset)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		if (asset != null)
		{
			object obj = "fetch_products" + 136;
			return (string)obj + asset.<LocalPath>k__BackingField;
		}
		return (string)(object)new NullReferenceException();
	}

	public override IEnumerator LoadAsset<T>(AssetLoadingModel<T> asset)
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
		((<LoadAsset>d__3<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<LoadAsset>d__3<T> <LoadAsset>d__ = (<LoadAsset>d__3<T>)(enumerator + 40);
			<LoadAsset>d__ = (<LoadAsset>d__3<T>)(object)this;
			<LoadAsset>d__..ctor((int)this);
			<LoadAsset>d__3<T> <LoadAsset>d__2 = (<LoadAsset>d__3<T>)(enumerator + 32);
			<LoadAsset>d__2 = (<LoadAsset>d__3<T>)(object)asset;
			<LoadAsset>d__2..ctor((int)asset);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public override void CacheLoadedAsset<T>(AssetLoadingModel<T> asset)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00d1: Expected I, but got O
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_014f: Expected O, but got I
		if (asset == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [asset @ X1 (AssetLoadingModel`1<T>)+38]");
		if ((nint)0 != 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [asset @ X1 (AssetLoadingModel`1<T>)+48]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [asset @ X1 (AssetLoadingModel`1<T>)+40]");
		if ((nint)0 != 0)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)2976;
			Action action = default(Action);
			action..ctor(null, (IntPtr)obj2);
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string <LocalPath>k__BackingField = asset.<LocalPath>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [asset @ X1 (AssetLoadingModel`1<T>)+40]");
			FileUtils.SaveFile(<LocalPath>k__BackingField, (byte[])0, action);
		}
	}

	public override void DeleteAsset(string assetId, string localAssetPath)
	{
		File.Delete(localAssetPath);
	}

	private static bool ValidateCachedFile(string filePath, DateTime? timeStamp)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		bool flag = File.Exists(filePath);
		if (flag)
		{
			object obj = (??)timeStamp & 1;
			if (obj != null)
			{
				DateTime lastWriteTime = File.GetLastWriteTime(filePath);
				object obj2 = (nint)0 + (nint)2296;
				DateTime? dateTime = default(DateTime?);
				DateTime value = dateTime.Value;
				object obj3 = typeof(DataRelation) + 712;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = value > lastWriteTime;
				flag = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
			}
		}
		return flag;
	}

	private IEnumerator <>n__0<T>(AssetLoadingModel<T> asset) where T : class
	{
		AssetLoadingModel<T> asset2 = default(AssetLoadingModel<T>);
		if (this != null)
		{
			return base.LoadAsset(asset2);
		}
		return (IEnumerator)new NullReferenceException();
	}
}
