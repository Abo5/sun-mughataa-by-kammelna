# ٠٥ — محرّك IAP مفكوكًا

[↩ الفهرس](README.md)

> الفصل [٠٣](03-المشتريات-داخل-التطبيق.md) وصف **خريطة** مسار الشراء، و[٠٤](04-واجهة-المتجر.md) وصف
> **الصفحة الرئيسية**. هذا الفصل ينزل إلى قاع الطبقة: **آلة حالة التهيئة** ·
> **مَن يستدعي `confirm` ومتى** · **المرشِّحات الثلاثة في `ProductStore`** ·
> **نقطة التبديل الذرّية للكتالوج** · **ومن أين يأتي الرقم الذي يراه المستخدم**.
> كل رقم هنا مفكوك من ARM64 في هذه الجلسة، لا منقولٌ عن Cpp2IL.

---

## ✅ ما تحقّقتُ منه بنفسي

| # | الدالّة / الحقيقة | العنوان | الأداة | اليقين |
|---|---|---|---|---|
| ١ | `IAPController.<InitializePurchasing>d__26::MoveNext` — الترتيب الكامل | `0x508F860` | `[BIN:]` capstone | ✅ |
| ٢ | فرع `Web` يرفع `ReadyState`، وفرع `Huawei` **لا يرفعه** | `0x508FB28` / `0x508FC44` | `[BIN:]` | ✅ |
| ٣ | نصّ «Platform is Huawei — served by the native plugin» حرفيًّا | `0x8D38108` | `[BIN:]` global-metadata.dat | ✅ |
| ٤ | `OnPurchasePending` = بناء `confirm` + **تأجيل** التحقّق إلى `ReadyState.CallWhenReady` | `0x508B03C` | `[BIN:]` | ✅ |
| ٥ | `confirm` = `m_StoreController.ConfirmPurchase(order)` | `0x508F2D0` | `[BIN:]` | ✅ |
| ٦ | `ValidateReceipt` = سجلّ + **نداء ذَيليّ** إلى `SubmitReceipt` | `0x508CD30` | `[BIN:]` | ✅ |
| ٧ | `OnServerError` يستدعي `confirm()` **عند `AlreadyProcessed=7002` فقط** | `0x508D8BC` | `[BIN:]` + `[ENUM:]` | ✅ |
| ٨ | `OnServerError` **يُهمل** وسيط `message` تمامًا | `0x508D868` | `[BIN:]` | ✅ |
| ٩ | `ProductStore.GetConsumableVersion` تُطابق بـ`List.Contains` (هوية مرجعيّة) | `0x509247C` | `[BIN:]` | ✅ |
| ١٠ | المرشِّحات الثلاثة: شكلها الكامل وترتيبها | `0x509094C` · `0x5090DD0` · `0x5091640` | `[BIN:]` | ✅ |
| ١١ | `Store::AssignStoreModels` — أربع كتابات ثم `true` | `0x4FEA7B0` | `[BIN:]` + `[CS:]` الحقول | ✅ |
| ١٢ | `StoreCardGroup::SetData` — **حَشو `pack` السالب** | `0x4FEF508` | `[BIN:]` | ✅ |
| ١٣ | `StoreDataHolder::SetTemplate` — جدول القوالب العشرة والأعمدة | `0x4FF3B6C` | `[BIN:]` | ✅ |
| ١٤ | السعر المعروض = **أرخص** قائمة · وسم الخصم = **أعلى `originalPrice`** | `0x4FF2144` · `0x4FF2544` | `[BIN:]` | ✅ |
| ١٥ | `SalesChannel` فيه **٣٦** عضوًا لا ٣٠ | — | `[ENUM:]` dump.cs | ✅ |
| ١٦ | `IsWebPurchasable` = `TwoCo(6) ‖ Urway(29) ‖ Moyasar(35)` | `0x50A82E4` | `[BIN:]` | ✅ |
| ١٧ | `SetItemAsDefault` ⇒ `api/GameStore/SetItemAsDefault/{id}` | `0x5276F98` | `[BIN:]` | ✅ |
| ١٨ | حقول `StoreBannerViewModel` · `UniqueStoreItem` · `Bundle` | — | `[CS:]` dump.cs | ✅ |
| ١٩ | `JsonProductDescriptionsDeserializer` في **`Unity.Purchasing.dll`** لا في كود اللعبة | `0x622A1E0` | `[CS:]` + DummyDll | ✅ |

**لم أتحقّق من**: أجساد `Tracker.PurchaseEvent`/`ResourceEvent` · أهداف `UnityEvent` في مشاهد
المتجر (لم أفتح حِزَم المشاهد في هذا الفصل) · `Store::AssembleStoreInfo` @`0x4FEABE4`.

---

## ⭐ خمس نتائج تسبق كل شيء

1. **⭐⭐⭐ `confirm()` (إنهاء معاملة المتجر) له مخرجان لا مخرج واحد**: نجاح الخادم،
   **وخطأ الخادم `AlreadyProcessed (7002)`**. هذا هو العلاج الصحيح لمشكلة الإيصال المكرّر
   الذي لا يُستهلَك أبدًا. انسخه.
2. **⭐⭐ التحقّق من الإيصال مؤجَّل بـ`OneShotEvent`**: `OnPurchasePending` لا يتحقّق فورًا،
   بل يسجّل `ReadyState.CallWhenReady(() => ValidateReceipt(order, confirm))`. ⇒ الإيصالات
   المعلّقة التي تصل قبل جهوزيّة المتجر **لا تُفقَد**. 🚩 وبالمقابل: **إن فشل `Connect()`
   بقي `IsReady = false` ⇒ لا يُتحقّق من أي إيصال أبدًا في تلك الجلسة.**
3. **⭐⭐ السعر المعروض وسِعرُ وسم الخصم يأتيان من قائمتَي بيع مختلفتين**:
   المعروض من `OrderBy(price).First()` (الأرخص)، والوسم من `OrderByDescending(originalPrice).First()`
   (الأعلى). 🚩 لو اختلفت الأسعار بين القنوات ظهر خصمٌ أكبر من الحقيقيّ.
4. **⭐⭐ `StoreCardGroup::SetData` يكتب في الكتالوج**: كل `StoreItem` بـ`pack == 0` يُمنَح
   **رقم رزمة سالبًا فريدًا** (`−1, −2, …`) ليصير رزمةً من عنصر واحد. حلٌّ أنيق، لكنه
   **تعديل بيانات داخل دالّة عرض**.
5. **⭐ `SalesChannel` فيه ٣٦ قناة لا ٣٠** — الستّ الجديدة كلّها بوّابات دفع سعوديّة/خليجيّة:
   `Mintroute=30 · SubBomb=31 · Tabby=32 · LikeCard=33 · Tamara=34 · Moyasar=35`.

---

## ١. التهيئة — `<InitializePurchasing>d__26::MoveNext` @`0x508F860` (2,824B) ✅

`InitializePurchasing` **ليست دالّة عاديّة**: هي `async void` بآلة حالة
`private struct IAPController.<InitializePurchasing>d__26 : IAsyncStateMachine`
(`<>1__state`@`0x0` · `<>t__builder`@`0x8` (`AsyncVoidMethodBuilder`) · `<>4__this`@`0x28` ·
`<>u__1`@`0x30` (`TaskAwaiter`)) ✅.

```csharp
// مفكوكة من 0x508F860، بالترتيب الحرفيّ للتعليمات
async void InitializePurchasing()
{
    Debug.Log("___# IAPController InitializePurchasing");           // 0x508FA70
    if (IsInitialized()) return;                                    // 0x508FA84 → SetResult

    ReadyState.IsReady = false;                                     // 0x508FA98  (w1 = 0)
    store = new ProductStore();                                     // 0x508FAB4 → static 0x20

    if (KUtil.GetPlatform() == Platform.Web) {                      // cmp w0,#3  @0x508FAF4
        Debug.Log("___# IAPController Return. Platform is Web");
        ReadyState.IsReady = true;                                  // 0x508FB28  (w1 = 1)  ⬅ يرفعها
        return;
    }
    if (KUtil.GetPlatform() == Platform.Huawei) {                   // cmp w8,#4  @0x508FC20
        Debug.Log("___# IAPController Return. Platform is Huawei — served by the native plugin");
        return;                                                     // 🚩 ولا يرفع ReadyState
    }

    Debug.Log("___# IAPController Set StoreController");            // 0x508FD88
    m_StoreController = UnityIAPServices.StoreController();         // 0x508FD94

    Debug.Log("___# IAPController Set StoreController Listeners");  // 0x508FDBC
    m_StoreController.OnStoreDisconnected     += OnStoreDisconnected;      // 0x508FE08
    m_StoreController.OnProductsFetched       += OnProductsFetched;        // 0x508FE54
    m_StoreController.OnProductsFetchFailed   += OnProductsFetchFailed;    // 0x508FEA0
    m_StoreController.OnPurchasesFetched      += OnPurchasesFetched;       // 0x508FEEC
    m_StoreController.OnPurchasesFetchFailed  += OnPurchasesFetchFailed;   // 0x508FF38
    m_StoreController.OnPurchasePending       += OnPurchasePending;        // 0x508FF84
    m_StoreController.OnPurchaseConfirmed     += OnPurchaseConfirmed;      // 0x508FFD0
    m_StoreController.OnPurchaseFailed        += OnPurchaseFailed;         // 0x509001C

    Debug.Log("___# IAPController StoreController connecting...");   // 0x5090040
    await m_StoreController.Connect();                              // 0x5090058 + TaskAwaiter

    Debug.Log("___# IAPController StoreController fetching products..."); // 0x508FB78
    var defs = BuildProductDefinitions();                           // 0x508FB88
    Debug.Log(string.Format("___# IAP requesting {0} products: ", defs.Count)
              + string.Join(", ", defs.Select(d => d.id)));         // b__26_0 · Join @0x508FCE4
    m_StoreController.FetchProducts(defs);                          // 0x508FD3C
}
catch (Exception e) {                                               // 0x50901AC
    KLogger.LogError("___# IAP store connection failed: " + e);      // 0x5090238
    ReadyState.IsReady = false;                                     // 0x5090250
}
```

### ⭐ ما يستحقّ النقل
* **ثمانية مستمعين تُسجَّل قبل `Connect()`** — لا بعده. صحيح: الاتصال قد يوصل إيصالات معلّقة
  في اللحظة نفسها.
* **`await Connect()` ثم `FetchProducts`** — لا استدعاء متوازٍ، ولا مهلة زمنيّة.
* الاستثناء يُلتقط ويُسجَّل ويُبتلع، **ولا يُمرَّر إلى `SetException`** (المسار @`0x5090328`
  محفوظ لاستثناءات إعادة الرمي فقط) ⇒ **الفشل صامت للمستخدم**.

### 🚩 عِلَّتان كامنتان

| العِلَّة | الدليل | الأثر |
|---|---|---|
| فرع `Huawei` **لا يرفع** `ReadyState.IsReady` بينما فرع `Web` يرفعه | `0x508FB28` مقابل `0x508FC44` | على بناء هواوي يبقى `CallWhenReady` معلّقًا للأبد ⇒ **إيصالات لا تُتحقَّق ولا تُستهلَك**. (ميّت على iOS — انظر [٠٣ §٧.٨](03-المشتريات-داخل-التطبيق.md)) |
| فشل `Connect()` ⇒ `IsReady = false` بلا إعادة محاولة | `0x5090250` | كل `OnPurchasePending` في الجلسة يُسجَّل ولا يُنفَّذ ⇒ **المستخدم دفع ولم يُمنَح، بلا رسالة** |

> ⚠️ **الفرعان `Web(3)` و`Huawei(4)` ميتان على iOS** لأن `KUtil.GetPlatform()` مُترجَمة
> إلى `mov w0,#2; ret` (انظر [`voice-spec`](../voice-spec/README.md)). لكنهما جزء من التصميم
> الأصليّ فوثّقتهما.

### `OnPlayBillingManagerConnected` @`0x5088AE8` (976B) ✅ — للمقارنة

```csharp
Debug.Log("___# GooglePlayBillingManager Connected");
string[] ids = ProductStore.AllRecurringSubscriptions
    .SelectMany(p => p.listings)                                    // b__35_0
    .Where(l => l.channelId == SalesChannel.GooglePlayRecurring)     // b__35_1: cmp w8,#0xd
    .Select(l => l.listingId)                                        // b__35_2: [x1,#0x18]
    .ToArray();
Debug.Log(string.Format("___# Promotional offer listings count: '{0}'", ids.Length));
m_GooglePlayBillingManager.FetchProducts(ids);
```
> ⭐ **المسار الثاني لا يمرّ بـ`BuildProductDefinitions` إطلاقًا** — له مرشِّحه الخاصّ بقناة
> واحدة (`13`). ⇒ **خطّان مستقلّان لجلب المنتجات في نفس الصنف.** ميّت على iOS.

---

## ٢. ⭐⭐⭐ دورة الشراء — مَن يستدعي `confirm` ومتى

### ٢.١ `OnPurchasePending` @`0x508B03C` (712B) ✅ — **مفكوكة بالكامل**

```csharp
private void OnPurchasePending(PendingOrder order)
{
    var dc = new <>c__DisplayClass54_0 { order = order, <>4__this = this };   // 0x508B0F0
    Debug.Log("___# OnPurchasePending called: with product: '"
              + order.CartOrdered.Items()[0].Product.definition.id + "'");    // 0x508B28C
    dc.confirm = dc.<OnPurchasePending>b__0;                                  // → الحقل 0x20
    this.ReadyState.CallWhenReady(dc.<OnPurchasePending>b__1);                // 0x508B2FC (ذَيليّ)
}
```
حقول المُغلِّف ✅: `PendingOrder order`@`0x10` · `IAPController <>4__this`@`0x18` · `Action confirm`@`0x20`.

```csharp
// b__0 @0x508F2D0
() => IAPController.m_StoreController.ConfirmPurchase(dc.order);   // ذَيليّ إلى 0x624DB34
// b__1 @0x508F338   (٤٠ بايتًا فقط)
() => dc.<>4__this.ValidateReceipt(dc.order, dc.confirm);          // ذَيليّ إلى 0x508CD30
```

> ⭐⭐ **هذا هو جواب السؤال المفتوح في [٠٣ §٨.٤](03-المشتريات-داخل-التطبيق.md)**:
> `confirm` **ليس** «إنهاء الشراء» المكتوب في مكانٍ ما، بل **مُغلِّف على
> `StoreController.ConfirmPurchase(order)`** يُبنى في `OnPurchasePending` ويُمرَّر يدًا بيد
> `ValidateReceipt → SubmitReceipt → OnServerSuccess/OnServerError`.
>
> ⭐⭐ و**التحقّق مؤجَّل**: `OneShotEvent.CallWhenReady` (`callbacks`@`0x10` · `_isReady`@`0x18`)
> ينفّذ فورًا إن كان جاهزًا، وإلّا **يصفّ النداء** حتى تُرفع الجهوزيّة. ⇒ إيصال معلّق من
> جلسةٍ سابقة يصل أثناء `Connect()` **لا يُهمَل**.

### ٢.٢ `ValidateReceipt` @`0x508CD30` (628B) ✅ — **سجلٌّ فقط**

```csharp
private void ValidateReceipt(PendingOrder order, Action confirm)
{
    Debug.Log("___# Receipt received: for = "
            + order.CartOrdered.Items()[0].Product.definition.id
            + "  and transactionID = " + order.Info.TransactionID);
    SubmitReceipt(order, confirm);        // 0x508CF9C:  b #0x508CFA4  ← نداء ذَيليّ
}
```
> 🛑 **تصحيح لـ[٠٣ §٣](03-المشتريات-داخل-التطبيق.md)**: المخطّط هناك يرسم
> `OnPurchasePending → ValidateReceipt → SubmitReceipt` وكأن `ValidateReceipt` تتحقّق.
> **لا تتحقّق من شيء.** اسمها مُضلِّل: ٦٢٨ بايتًا كلّها بناء سلسلة سجلّ، ثم **قفزة ذَيليّة**.
> التحقّق الحقيقيّ كلّه على الخادم. (والقفزة ذَيليّة ⇒ لو مسحتَ `bl` وحده لظننتَ
> `SubmitReceipt` بلا مستدعٍ — انظر قاعدة الكود الميت.)

### ٢.٣ ⭐⭐⭐ `OnServerError` @`0x508D868` (272B) ✅ — **المفتاح**

```csharp
private void OnServerError(ProductListingModel listingModel, Action confirm,
                           KammelnaError responseErrorCode, string message)
{
    if (responseErrorCode == KammelnaError.AlreadyProcessed)   // mov w8,#0x1B5A = 7002 @0x508D8BC
        confirm();                                            // 0x508D8D8 blr  ← يُنهي المعاملة!

    TrackerLibrary.DevPurchaseServerError(responseErrorCode.ToString());   // 0x508D90C
    Tracker.DesignEvent(…);                                                // 0x508D930
    OnPurchaseFailed(listingModel, responseErrorCode.GetFriendlyName());   // 0x508D958 → 0x508B594
}
```

| السلوك | الدليل | الحكم |
|---|---|---|
| `confirm()` على `7002` | `cmp w21, #0x1B5A` ثم `blr x8` | ⭐⭐⭐ **الصواب.** الخادم يقول «عالجتُه سابقًا» ⇒ استهلِك المعاملة وإلّا عادت للأبد |
| ثم **يُبلّغ بالفشل رغم ذلك** | لا قفزة بعد `confirm()`؛ يسقط إلى التتبّع | 🚩 المستخدم يرى «فشل» وقد مُنِح المحتوى فعلًا (مزامنة SFS تُصلحه لاحقًا) |
| وسيط `message` **غير مقروء** | `x4` لا يُلمَس في كل الـ272 بايتًا | 🚩 **رسالة الخادم تُرمى**، ويُستعمل `GetFriendlyName(code)` بدلها |

> ⭐ ومع [٠٣ §٧.٦](03-المشتريات-داخل-التطبيق.md) (`OnServerSuccess` @`0x508D4BC` يبدأ بـ`confirm()`)
> تُكتمل الصورة: **`confirm` له بابان فقط، كلاهما بعد ردّ الخادم:**
> ```
> نجاح           → confirm()  ثم  سجلّ  ثم  تتبّع  ثم  OnPurchaseCompleted
> خطأ 7002       → confirm()  ثم  تتبّع خطأ  ثم  OnPurchaseFailed
> أي خطأ آخر     → لا confirm  ⇒ المعاملة تبقى معلّقة وتُعاد المحاولة في الجلسة القادمة
> ```
> **انسخ هذه الثلاثيّة حرفيًّا.** هي الفرق بين «مال يضيع» و«مال يُستردّ».

### ٢.٤ 🟡 ترتيب `PurchaseProduct` ثم `ShowLoading` — **سهو على الأرجح، وغير ضارّ**

السؤال المفتوح في [٠٣ §٨.٥](03-المشتريات-داخل-التطبيق.md). ما أستطيع إثباته:

* في **كل** فروع `BuyProduct` الأخرى (StcPay · ويب · GooglePlayRecurring · هواوي) الفرع
  **ينتهي بـ`return`** بلا `ShowLoading` إطلاقًا — أي أن النافذة ليست جزءًا من العقد.
* في الفرع الافتراضيّ وحده: `m_StoreController.PurchaseProduct(p)` ثم
  `PopupWindow.ShowLoading("Loading", false)`.
* `PurchaseProduct` على Unity IAP **غير متزامنة**: تُسلّم الطلب إلى المتجر الأصليّ وتعود
  فورًا، والنتيجة تأتي عبر `OnPurchasePending`/`OnPurchaseFailed` في إطار لاحق.

> 🟡 **حكمي**: **سهو لا قصد، لكنه غير قابل للاستغلال.** لو كانت `PurchaseProduct` متزامنة
> لكان الترتيب عيبًا حقيقيًّا (نافذة تحميل تظهر بعد انتهاء العمل)؛ ولمّا كانت غير متزامنة
> فالفرق أطرٌ قليلة. **ما يدعم «السهو»**: أن `ShowLoading` تظهر **مرّة واحدة في الصنف كلّه**،
> وفي الفرع الأخير فقط، بعد السطر الذي يفعل العمل — وهو الموضع الذي يقع فيه السهو عادةً
> عند إضافة سطر في آخر الدالّة. **في إعادة البناء: اعرض التحميل أولًا، ثم ادفع الطلب.**
> ⚠️ ولا تنسَ أن `PopupWindow.DismissMessage()` تُنادى في `OnPurchaseCompleted` **و**في
> `OnPurchaseFailed` — فالنافذة تُغلق على المسارين، وهذا سليم.

---

## ٣. `ProductStore` — المرشِّحات والمطابقة

### ٣.١ ⭐⭐ المرشِّحات الثلاثة — الشكل الواحد ✅

الثلاثة `private static IEnumerable<ProductViewModel> Filter…(IEnumerable<ProductViewModel>)`،
وكلّها تبني **نسخة جديدة** من كل منتج بقوائم بيع مُصفّاة عبر المُنشئ
`ProductViewModel(ProductViewModel product, IEnumerable<ProductListingModel> listings)` @`0x51905EC` ✅.

```csharp
// FilterRecurring @0x509094C (884B)
products.Where (p => p.IsSubscription)                                 // b__24_0 → get_IsSubscription @0x519052C
        .Select(p => new ProductViewModel(p,
                     p.listings.Where(l => l.isRecurring)))            // b__24_1 / b__24_4: [l+0x34]
        .Where (p => p.listings.Count > 0)                             // b__24_2
        .OrderBy(p => p.days);                                         // b__24_3: [p+0x24]

// FilterSubscriptionsInStoreHomePage @0x5091640 (884B)
products.Where (p => p.IsSubscription)                                 // b__26_0
        .Select(p => new ProductViewModel(p,
                     p.listings.Where(l => (l.isRecurring && !l.isHidden)
                                           || l.isPromotionActive)))   // b__26_4  ⭐
        .Where (p => p.listings.Count > 0)                             // b__26_2
        .OrderBy(p => p.days);                                         // b__26_3

// FilterConsumable @0x5090DD0 (912B)   ⚠️ لا بوّابة IsSubscription
products.Select(p => new ProductViewModel(p,
                     p.listings.Where(l => l.isConsumable)))           // b__25_0 / b__25_4: [l+0x35]
        .Where  (p => p.listings.Count > 0)                            // b__25_1
        .OrderBy(p => p.days)                                          // b__25_2: [p+0x24]
        .ThenBy (p => p.coins);                                        // b__25_3: [p+0x20]  ⭐
```

`b__26_4` مفكوكةً حرفًا بحرف @`0x5092F94`:
```asm
ldrb w8,[x1,#0x34] ; isRecurring
cmp  w8,#1 ; b.ne → 0x5092FB0        ← غير متكرّر ⇒ اذهب للاحتياط
ldrb w8,[x1,#0x36] ; isHidden
cmp  w8,#1 ; b.ne → return true      ← متكرّر وغير مخفيّ ⇒ اقبله
0x5092FB0: b #0x51901BC              ← get_isPromotionActive
```
⇒ `l => (l.isRecurring && !l.isHidden) || l.isPromotionActive` ✅

> ⭐⭐ **`isPromotionActive` يتجاوز `isHidden`**: العرض الترويجيّ الفعّال يُعرض في الصفحة
> الرئيسية **حتى لو كانت القائمة مخفيّة**. هذا هو المقصود بـ«العروض السرّية» في
> [٠٣ §١](03-المشتريات-داخل-التطبيق.md): تُشحن مخفيّة، **ويفتحها الخادم بعَلَم `isPromotionActive`
> لا بتحديث للتطبيق**.
>
> ⭐ **`FilterConsumable` وحدها بلا بوّابة اشتراك، وبـ`ThenBy(coins)`** — لأنها تخدم
> **باقات الآسات** (`days == 0`، فيرتّبها `coins` تصاعديًّا) **والاشتراكات المستهلَكة**
> (`days > 0`) في قائمة واحدة. ⇒ **الترتيب النهائيّ: الأيام ثم الآسات.** انسخه.
>
> ⚠️ `p.listings.Count > 0` بعد التصفية يستعمل `Count` على `List` المُنشأ — أي أن المُنشئ
> `ProductViewModel(p, listings)` **يُجمِّد** (`ToList`) لا يبقي تقييمًا مؤجَّلًا.

### ٣.٢ ✅ `GetConsumableVersion` @`0x509247C` (636B) — **السؤال المفتوح في [٠٣ §٨.٣](03-المشتريات-داخل-التطبيق.md)**

التوقيع الحقيقيّ `[CS:]`: **`public ProductListingModel GetConsumableVersion(ProductListingModel originalListing)`**
— **دالّة مثيل تأخذ القائمة نفسها**، لا `(store, listingId)`.

```csharp
public ProductListingModel GetConsumableVersion(ProductListingModel originalListing)
{
    if (originalListing == null)      return null;              // 0x509253C
    if (originalListing.isConsumable) return originalListing;   // 0x5092540 [+0x35] ⬅ يُعيدها كما هي

    var product = ProductStore.Products
        .FirstOrDefault(p => p != null && p.listings != null
                          && p.listings.Contains(originalListing));   // b__0 @0x5093458
    if (product == null) return null;                                 // 0x50925CC

    return product.listings
        .FirstOrDefault(l => l.isConsumable);                         // b__31_1 @0x5093150
}
```

| التفصيل | الإثبات |
|---|---|
| المُغلِّف | `<>c__DisplayClass31_0` — `originalListing`@`0x10` |
| المطابقة | **`List<ProductListingModel>.Contains`** @`0x3464A18` (نداء ذَيليّ من `0x50934B8`) |
| المصدر | الحقل الساكن `ProductStore.Products` (الإزاحة `0x8` في الحقول الساكنة) |
| الالتقاط | `FirstOrDefault<ProductViewModel>` @`0x2DC57DC` ثم `FirstOrDefault<ProductListingModel>` (نداء ذَيليّ @`0x50926F0`) |
| النسخة المستهلَكة | **أوّل** قائمة `isConsumable` — بلا ترتيب ولا تفضيل قناة |

> 🚩🚩 **`Contains` على `ProductListingModel` = مقارنة مراجع.** الصنف **لا يُلغي `Equals`
> ولا `GetHashCode`** (فحصتُ الصنف كلّه في `dump.cs`) ⇒ المطابقة **بهويّة الكائن**.
> فلو أُعيد تحميل الكتالوج (`AssignStoreModels` جديد) بين لحظة اختيار المستخدم ولحظة
> `BuyProduct`، صار المرجع القديم **غريبًا عن `Products` الجديدة** ⇒ `product == null`
> ⇒ `KLogger.LogError("BuyProductID: FAIL. There are no consumable version …")` **وإهداءٌ
> يفشل بلا سبب ظاهر**.
> ⚠️ وأخطر: **مرشِّحات §٣.١ تبني `ProductViewModel` جديدة بقوائم مُعاد استعمالها بالمرجع**
> — هذا وحده يحفظ الهويّة، لكنه يعني أن الكتالوج المفلتر والأصليّ **يتقاسمان كائنات القوائم**.
> **في إعادة البناء: طابِق بـ`listingId` (نصّ) لا بالمرجع.**

> ⭐ الاستدعاء الوحيد من [٠٣ §٧.٥](03-المشتريات-داخل-التطبيق.md): الإهداء يفرض النسخة
> المستهلَكة، لأن الاشتراك المتكرّر لا يُهدى (وهو ما يفسّر `_giftInfo = null` قبل
> `BuySubscription`).

### ٣.٣ 🚩 `ProductStore` — «مثيل» على حالة ساكنة

```csharp
public class ProductStore {                                     // TypeDefIndex 2420
    public static readonly Dictionary<ProductListingModel, ProductViewModel> ListingToProductMap; // static 0x0
    private static IEnumerable<ProductViewModel> Products;                                        // static 0x8
    // وكل المرشِّحات static، لكن GetListing/GetConsumableVersion/get_GoldenCards… دوالّ مثيل
}
```
و`LoadProducts` @`0x5091BD4` (300B): `products.ForEach(p => …)` يسجّل كل قائمة في
`ListingToProductMap` (عبر `Dictionary<ProductListingModel,ProductViewModel>.set_Item`) ثم
`Products = products`.

> 🚩 **`new ProductStore()` في `InitializePurchasing` عديم الأثر**: الصنف بلا حقل مثيل واحد.
> دوالّ المثيل تقرأ وتكتب حالةً ساكنة ⇒ **لا يمكن أن يتعايش متجران**، و«إعادة التهيئة»
> لا تُصفّر شيئًا. في إعادة البناء: إمّا `static` بصراحة، أو حالة حقيقيّة في المثيل.
> ⚠️ و`ListingToProductMap` مفتاحها **مرجع كائن** — نفس عِلَّة §٣.٢.

---

## ٤. ⭐⭐ `Store::AssignStoreModels` @`0x4FEA7B0` (1,076B) ✅ — نقطة التبديل

```csharp
private static bool AssignStoreModels()
{
    StoreInfoViewModel info = AssembleStoreInfo();               // 0x4FEA7E8
    if (info == null) return false;                              // 0x4FEA89C

    Store.StoreCategories = info.items                           // static 0x0
        .GroupBy   (i => i.category)                             // b__56_0 @0x4FEBE48: [i+0x14]
        .ToDictionary(g => g.Key,                                // b__56_1 @0x4FEBE60
                      g => g.ToList());                          // b__56_2 @0x4FEBF10
    ProductStore.LoadProducts(info.products);                    // 0x4FEAAEC
    Store.ProfileGifts = info.profileGifts;                      // static 0x8   @0x4FEAB2C
    Store.ItemGroups   = info.itemGroups;                         // static 0x10  @0x4FEAB74
    return true;                                                 // cset ne @0x4FEAB84
}
```

`[CS:]` النماذج:
```csharp
class StoreInfoViewModel {                        // TypeDefIndex 3366
    List<StoreItem>        items;        // 0x10
    List<ProductViewModel> products;     // 0x18
    List<ProfileGiftModel> profileGifts; // 0x20
    List<ItemGroup>        itemGroups;   // 0x28
}
// Store (MonoBehaviour) — الحقول الساكنة:
static Dictionary<ItemCategory, List<StoreItem>> StoreCategories; // 0x0
static List<ProfileGiftModel>                    ProfileGifts;    // 0x8
static List<ItemGroup>                           ItemGroups;      // 0x10
static readonly OneShotEvent                     readyStatus;     // 0x18
static Store                                     ActiveInstance;  // 0x20
static Action                                    OnLastStoreDateUpdated; // 0x28
```

> ⭐⭐ **الكتالوج كلّه يُستبدَل في أربع كتابات متتالية بلا قفل ولا نسخة وسيطة**، بعد بوّابة
> `null` واحدة. هذه هي **نقطة الالتزام (commit point)** الوحيدة للكتالوج في التطبيق كلّه:
> إمّا `AssembleStoreInfo` تُعيد نموذجًا كاملًا فيُبدَّل الأربعة، أو لا شيء يُمَسّ.
> **انسخ هذا النمط** — أفضل من تحديث أربع مجموعات على حِدَة.
>
> ⚠️ لكنّه **ليس ذرّيًّا فعليًّا**: بين الكتابة الأولى والرابعة أربع كتابات + حاجز GC، وأي
> قارئ على خيط آخر (أو `Populate` أثناء نفس الإطار) يمكن أن يرى **فئات جديدة وهدايا قديمة**.
> على خيط Unity الواحد لا يظهر الأثر؛ في نسختك أبدِل مرجعًا واحدًا لكائن حالة كامل.
>
> 🚩 `ToDictionary(g => g.Key, …)` بعد `GroupBy` آمنٌ بالبناء، لكن **العناصر بلا `category`
> صحيحة تتجمّع في مفتاحٍ مجهول** ولن يجدها `GetCategoryItems` — تُختفي بصمت.

---

## ٥. ⭐⭐⭐ `StoreCardGroup::SetData` @`0x4FEEEF4` (3,912B) — أكبر دالّة في الطبقة

`[CS:]` التوقيع: `public void SetData(IEnumerable<IGrouping<string, StoreItem>> groups)`
على `StoreCardGroup : UiGridView<StoreDataHolder, ListViewItem<StoreDataHolder, int>>`.
ومعها `Populate(IEnumerable<IGrouping<string, StoreItem>>)` @`0x4FE7B58` (مجرّد مُغلِّف).

```csharp
public void SetData(IEnumerable<IGrouping<string, StoreItem>> groups)
{
    var holders = new List<StoreDataHolder>();      // 0x4FEF0BC
    int index   = 0;                                 // w19
    int synth   = 0;                                 // str wzr,[sp,#0xc]  @0x4FEF14C

    foreach (var group in groups)                    // IEnumerable<IGrouping<string,StoreItem>>
    {
        // ① بوّابة: هل في الزمرة عنصر معروض أصلًا؟
        if (!group.Any(i => i.isActive && !i.isAdvertisement)) continue;   // b__0_0 · Any @0x4FEF320

        // ② مدخل العنوان
        var title = new StoreDataHolder { titleText = group.Key, index = index };  // 0x4FEF348/34C
        title.SetTemplate();                                                       // 0x4FEF35C
        holders.Add(title);

        // ③ ⭐⭐ حَشو أرقام الرُّزَم السالبة
        foreach (var item in group)                  // 0x4FEF3CC..0x4FEF520
            if (item.pack == 0)                      // ldr w8,[x0,#0x68]; cbnz → التالي
                item.pack = --synth;                 // −1, −2, −3 …   str w8,[x0,#0x68]

        // ④ الرُّزَم مرتَّبةً بأقدم Order فيها
        var packs = group.GroupBy(i => i.pack)                       // b__0_1: [i+0x68]
                         .OrderBy(pack => pack.Min(i => i.Order));   // b__0_2/b__0_3: [i+0x94]

        int n = index + 1;                                           // add w24, w19, #1
        foreach (var pack in packs)
        {
            // ⑤ تخطَّ الرزمة إن كان كل عنصر فيها مُعطَّلًا أو إعلانًا
            if (pack.All(i => !i.isActive || i.isAdvertisement)) continue;   // b__0_4 · All @0x4FEF8C8

            var items = pack.Where(i => i.isActive && !i.isAdvertisement)    // b__0_5
                            .OrderByDescending(i => i.virtualPrice)          // b__0_6: [i+0x28] ⭐
                            .ToList();

            var h = new StoreDataHolder { CardsItem = items, Subscription = null, index = n };
            h.SetTemplate();                                                 // 0x4FEFA64
            holders.Add(h);
            n++;
        }
        index = n;
    }
    // … ثم تسليم holders إلى الشبكة
}
```

### ⭐⭐ حَشو `pack` السالب — أهمّ سطرين في الدالّة
```asm
0x4FEF508  ldr  w8, [x0, #0x68]      ; item.pack
0x4FEF50C  cbnz w8, #0x4FEF440       ; له رزمة ⇒ اتركه
0x4FEF510  ldr  w8, [sp, #0xc]
0x4FEF514  sub  w8, w8, #1           ; −−synth
0x4FEF518  str  w8, [sp, #0xc]
0x4FEF51C  str  w8, [x0, #0x68]      ; item.pack = synth
```
> ⭐⭐ العنصر بلا رزمة (`pack == 0`) يصير **رزمةً من عنصر واحد** برقمٍ **سالب فريد**، فيمرّ
> بنفس مسار `GroupBy(pack)` بلا فرع خاصّ. **حلٌّ جميل جدًّا — انسخه** (لكن في **نسخة** من
> البيانات).
>
> 🚩 **لكنه يكتب في `StoreItem` نفسه** — كائن الكتالوج المشترك مع `Store.StoreCategories`
> و[`StoreHomePageGroup.Populate`](04-واجهة-المتجر.md) التي تُجمّع بـ`pack` كذلك.
> ⇒ **دالّة عرض تعدّل نموذج البيانات.** النتيجة ليست خاطئة (الاستدعاء الثاني يرى `pack != 0`
> فيتخطّى)، لكنها تعني أن **ترتيب فتح الشاشات يؤثّر في أرقام الرُّزَم**، وأن عدّاد `synth`
> **جارٍ عبر الزمر كلّها** (`sp+0xc` يُصفَّر مرّة واحدة @`0x4FEF14C`) لا يُصفَّر عند حدود الزمرة.
>
> ⚠️ `OrderByDescending(i => i.virtualPrice)` ⇒ **الأغلى أوّلًا داخل الرزمة.** قرار بيعيّ
> صريح، ومفاجئ مقابل `OrderBy` في كل مكان آخر.

### ⭐⭐⭐ `StoreDataHolder::SetTemplate()` @`0x4FF3B6C` ✅ — جدول القوالب

`private void SetTemplate()` **بلا وسائط**: تستنطق حقول الحامل بالترتيب وتكتب
`template`@`0x18` و`columns`@`0x20`. **أوّل حقل غير فارغ يفوز.**

| # | الشرط | `template` (اسم القالب في المشهد) | `columns` |
|---|---|---|---|
| ١ | `BannerItem != null && Type == Wide(1)` | `"Store Wide Banner Item"` | **−1** |
| ٢ | `BannerItem != null && Type == Normal(0)` | `"Store Normal Banner Item"` | **6** |
| ٣ | `BannerList != null` | `"Store Banners"` | **−1** |
| ٤ | `titleText != null` | `"Items group Title"` | **−1** |
| ٥ | `CardsItem != null` | `"Store Card Item"` | **4** |
| ٦ | `RoomItem != null` | `"Store Room Item"` | **6** |
| ٧ | `GoldenCards != null ‖ Subscription != null` | `"Store Product Item"` | **4** |
| ٨ | `UniqueItem != null` | `"Unique Store Item"` | **−1** |
| ٩ | `PatternItem != null ‖ category == Patterns(4)` | `"Store Pattern Item"` | **6** |
| ١٠ | `BundleStoreItem != null` | `"Store Bundle Item"` | **−4** |
| — | لا شيء | **لا يُكتب template** (يبقى `null`) | — |

`[CS:]` **حقول `StoreDataHolder`** (TypeDefIndex 2009) ✅:
```csharp
int index;@0x10  string template;@0x18  int columns;@0x20  ItemCategory category;@0x24
List<StoreItem>  CardsItem;@0x28        List<StoreBannerViewModel> BannerList;@0x30
StoreBannerViewModel BannerItem;@0x38   StoreItem RoomItem;@0x40   StoreItem PatternItem;@0x48
ProductViewModel GoldenCards;@0x50      ProductViewModel Subscription;@0x58
UniqueStoreItem  UniqueItem;@0x60       Bundle BundleStoreItem;@0x68
ImageCacher.BannerSize Type;@0x70       string titleText;@0x78     int? tempId;@0x80
```

> ⭐⭐ **هذا هو «الاتحاد المُميَّز» (tagged union) الحقيقيّ للمتجر**: حاملٌ واحد بأربعة عشر
> حقلًا، **والنوع مستنتَجٌ من أيّها مُعبَّأ**، والقالب والأعمدة نتيجةٌ آليّة.
> ⇒ هذا سبب أن `StoreHomePageGroup.Populate` بلا بناء صريح للقوالب
> ([٠٤ §٣ب](04-واجهة-المتجر.md)): **المصانع العشرة `Init*` لا تختار قالبًا، `SetTemplate` تختاره.**
>
> ⚠️ **`columns` سلبيّ ليس خطأ**: `−1` = صفٌّ كامل (مدخل يمتدّ العرض)، و`−4` للرزمة
> (`Store Bundle Item`) قيمة ثالثة متميّزة. **احفظ الإشارة**، لا تعتبرها عدد أعمدة.
>
> 🚩 **العنصر الحادي عشر: لا افتراضيّ.** حامل فارغ يمرّ بصمت بـ`template == null`
> ⇒ **مدخل شبكة بلا قالب**. بخلاف `Populate` التي ترمي (انظر
> [٠٤ §٣ب](04-واجهة-المتجر.md) 🚩 النوع ٦)، هذه تسكت. في نسختك: سجّل تحذيرًا.
>
> ⚠️ **الترتيب حاسم**: `PatternItem` يُفحص **بعد** `UniqueItem` و`Subscription`،
> و`BannerItem` **قبل** كل شيء. حاملٌ بحقلين مُعبَّأين يأخذ الأعلى في الجدول.

---

## ٦. طبقة عرض السعر — من أين يأتي الرقم الذي يراه المستخدم

### ٦.١ ⭐⭐ `StoreProductUi::PopulateProduct` @`0x4FF1E7C` (1,796B) ✅

```csharp
// مفكوكة من تسلسل النداءات؛ الحقول من dump.cs
description.text = product.listings.First().description.FixArabic();          // 0x4FF2034
shortName  .text = product.listings.First().GetLocalizedShortName().FixArabic(); // 0x4FF207C/208C

SetConvertedPrice( listings.OrderBy(l => l.price).First() );                   // b__16_0: [l+0x30]  @0x4FF2158
stcPayExclusiveTag.SetActive( listings.TrueForAll(l => l.channelId.IsStcPay()) );  // b__16_1 @0x4FF2290
recurringTag      .SetActive( listings.TrueForAll(l => l.isRecurring) );           // b__16_2 [l+0x34] @0x4FF23C0
if ( listings.Any(l => l.isPromotionActive) ) …promotionTagNew…                    // b__16_3 @0x4FF24B4
UpdateDiscountTag( listings.OrderByDescending(l => l.originalPrice).First() );     // b__16_4: [l+0x38] @0x4FF255C
```

| الوسم | القاعدة | الدالّة |
|---|---|---|
| السعر | **أرخص** قائمة بـ`price` | `OrderBy(price).First()` @`0x4FF2144` |
| الخصم | القائمة ذات **أعلى `originalPrice`** | `OrderByDescending(originalPrice).First()` @`0x4FF2544` |
| «حصريّ STC Pay» | **كل** القوائم `IsStcPay` | `TrueForAll` @`0x4FF220C` |
| «متكرّر» | **كل** القوائم `isRecurring` | `TrueForAll` @`0x4FF233C` |
| «عرض» | **أيّ** قائمة `isPromotionActive` | `Any` @`0x4FF24B4` |

> 🚩🚩 **السعر والخصم من قائمتين مختلفتين، وبمفتاحين مختلفين** (`price` مقابل `originalPrice`).
> على iOS القوائم المتاحة قليلة فيتصادفان؛ لكن منتجًا بقوائم متعدّدة (وهو **التصميم المعلَن**
> في [٠٣ §٢](03-المشتريات-داخل-التطبيق.md): «منتج واحد ← عدّة listings») يمكن أن يعرض
> **سعر القناة الأرخص مع خصمٍ محسوب على أغلى قناة** ⇒ **خصمٌ ظاهريّ أكبر من الحقيقيّ.**
> **في إعادة البناء: اختر القائمة مرّةً واحدة، واحسب السعر والخصم منها هي.**
>
> ⚠️ `listings.First()` (لا `FirstOrDefault`) مرّتين للوصف والاسم ⇒ **منتجٌ بقائمة بيع
> فارغة يرمي `InvalidOperationException`**. المرشِّحات في §٣.١ تحمي بـ`Count > 0`،
> لكن المسارات التي لا تمرّ بها **غير محميّة**.
> ⚪ نصّ مرصود: `"___# Store listing is null"` @`0x…300` و`"SAR"` داخل `UpdateDiscountTag` @`0x4FF76F0`.
> ✅ `IsStcPay(s)` = `s == 26` حرفيًّا (`cmp w0,#0x1A; cset eq`) @`0x50A831C`.

### ٦.٢ `StoreBundleItemUI::PopulateProduct` @`0x4FED594` (1,896B) ✅

نفس قاعدة السعر **معكوسة الترتيب في الكود، مطابقة في المعنى**:
```csharp
var product = IAPController.Instance.GetProduct(bundle.ProductId);        // 0x4FED744
ThemeProvider.UpdateTheme( bundle.GenerateTheme() );                     // 0x4FED768/77C  ⭐
LoadImage(…);                                                            // 0x4FED784
dateTimeText.SetDate( bundle.ExpirationDate );                           // 0x4FED7A0
if ( listings.Any(l => l.isPromotionActive) ) …                           // b__21_0 @0x4FED85C
UpdateDiscountTag( listings.OrderByDescending(l => l.originalPrice).First() ); // b__21_1 [l+0x38]
SetConvertedPrice ( listings.OrderBy(l => l.price).First() );                  // b__21_2 [l+0x30]

foreach (var old in spawnedCards) Object.Destroy(old);                    // 0x4FEDA28
Array.Clear(…);                                                          // 0x4FEDA88
foreach (long itemId in product.itemIds) {                               // List<long> @0x30
    var go = Object.Instantiate(cardPrefab); go.SetActive(true);
    go.GetComponent<SingleBundleCard>().SetupForItem(itemId);             // 0x4FEDB8C
}
SetupExpirationState();                                                  // 0x4FEDBF4
```
> ⭐ **الرزمة تلوّن نفسها**: `Bundle.GenerateTheme()` @`0x50A8BC0` يبني `IThemeColorProfile`
> من أربعة ألوان يرسلها الخادم ⇒ **هويّة الرزمة البصريّة مدفوعة بالخادم بلا أصول جديدة**.
> (التفصيل في [`cosmetics-spec/01`](../cosmetics-spec/01-طبقة-عرض-التجميليات.md).)
> ⚠️ **`Destroy` ثم `Instantiate` لكل عنصر في كل تعبئة** — بلا تجميع (pooling). تمرير سريع
> على قائمة الرُّزَم = تخلّص وإنشاء متكرّران.

### ٦.٣ `StoreRoomItem::PopulateStoreItem` @`0x4FF8600` (880B) ✅ — **الأثاث إيجارٌ لا بيع**

```csharp
RoomItem.ResetContent();                                          // 0x4FF871C
DisableButtons();                                                 // 0x4FF872C
RoomItem.PopulateRoomItem(item);                                   // 0x4FF8760
priceText.SetPriceText( StorePricing.DiscountAmount(item) );        // 0x4FF8778 → 0x4FF6CAC
double days = TimeSpan.FromSeconds(item.duration).TotalDays;        // 0x4FF87D8/87E8  ⭐
rentText.Localize("Rent for {0} days", days);                       // 0x4FF886C
animatedBadge.SetActive( RoomItem.IsRoomAnimated );                 // 0x4FF88B4
SessionModel.LocalUser.Bind("r", () => …);                          // 0x4FF8920/893C
```
> ⭐ **`StoreItem.duration` بالثواني**، وتُحوَّل إلى أيام بـ`TimeSpan.FromSeconds(...).TotalDays`
> ⇒ **ثيمات الغرف مؤقَّتة**، والنصّ ⚪ `"Rent for {0} days"` يؤكّده.
> ⚠️ `TotalDays` **`double` بلا تقريب** ⇒ مدّة غير مضبوطة على أيام كاملة تظهر بكسور.
> ✅ السعر من `StorePricing.DiscountAmount` @`0x4FF6CAC` — نفس الدالّة المُدقَّقة في
> [٠٢](02-تدقيق-ARM64.md) (وفيها تصحيح `Math.Ceiling`). ⇒ **مسار سعر الأثاث موحَّد مع
> بقيّة العملة الافتراضيّة، لا مسار خاصّ.**
> ⭐ `VariableBinderExtensions.Bind(LocalUser, "r", …)` @`0x526C250`: **البطاقة تُعيد رسم
> نفسها عند تغيّر متغيّر المستخدم `"r"`** — لا استقصاء (polling).

### ٦.٤ `StoreRoomThemesGroup::Populate` @`0x4FE7B5C` (1,512B) و`StorePatternsGroup::Populate` @`0x4FF68E0` (884B) ✅

```csharp
// StoreRoomThemesGroup
themes.Where  (t => t.isActive && !t.isAdvertisement
                    && t.targetGames.MatchesCurrentGame())   // b__0_0 @0x4FF99B8 → 0x4EE0C18
      .OrderBy(t => t.Order)                                 // b__0_1: [t+0x94]
      … → StoreDataHolder { RoomItem = t } → SetTemplate()    // 0x4FE7FCC

// StorePatternsGroup — public void Populate(List<StoreItem> patterns)
holders.Add( عنوان );                                        // SetTemplate @0x4FF6A00
foreach (var p in patterns)
    if (p.isActive) holders.Add( new StoreDataHolder { PatternItem = p } );  // cmp w8,#1 @0x4FF6ACC
```
> ⭐⭐ **`GamesFlagExtensions.MatchesCurrentGame(item.targetGames)`** (`StoreItem.targetGames`@`0x98`)
> — **ثيمات الغرف مُقيَّدة باللعبة الحاليّة** (بلوت / طرنيب / جاكارو…) على مستوى العنصر.
> هذه **بوّابة تصفية غائبة تمامًا** عن `StoreCardGroup::SetData` و`StorePatternsGroup::Populate`
> 🚩 ⇒ **ظهر البطاقة والأنماط لا تُصفَّى باللعبة، والثيمات تُصفَّى.** تناقض يستحقّ القرار
> الواعي في نسختك.
> ⚠️ `StorePatternsGroup` يفحص `isActive` **وحده** — بلا `isAdvertisement` وبلا `targetGames`
> وبلا ترتيب. ⇒ **ترتيب الأنماط = ترتيب الخادم كما هو.**

---

## ٧. 🛑 محلّل أوصاف المنتجات — **كود محرّك لا كود لعبة**

`Stores.Util.JsonProductDescriptionsDeserializer::DeserializeProductDescriptions` @`0x622A1E0`
(1,116B) **ليس من كود «كملنا»**: التحقّق ✅ أنّه في **`Unity.Purchasing.dll`**
(TypeDefIndex 17261، والاسم موجود في `DummyDll/Unity.Purchasing.dll` وحده). فلا يُنسب إلى
مؤلّفي اللعبة ولا يُعاد بناؤه — لكنه **يوثّق عقد JSON الذي يُسلّمه مُلحَق المتجر الأصليّ**،
وهذا نافع:

```csharp
// مفكوكة من 0x622A1E0
var list = new List<ProductDescription>();
foreach (var entry in (List<object>)MiniJson.JsonDecode(json))     // 0x622A2F0
{
    var dict = (Dictionary<string, object>)entry;
    var metadata = dict["metadata"];                               // 0x622A400
    string storeSpecificId = dict["storeSpecificId"];              // 0x622A464
    dict.TryGetString("receipt",       out string receipt);        // 0x622A480
    dict.TryGetString("transactionId", out string transactionId);  // 0x622A49C
    list.Add(new ProductDescription(storeSpecificId, metadata, receipt, transactionId));  // 0x622A4F0
}
```

| المفتاح | الوصول | ملاحظة |
|---|---|---|
| `"storeSpecificId"` | `Dictionary.get_Item` | **إلزاميّ** — يرمي إن غاب |
| `"metadata"` | `Dictionary.get_Item` | **إلزاميّ** |
| `"receipt"` | `TryGetString` | اختياريّ |
| `"transactionId"` | `TryGetString` | اختياريّ |

> ⭐ يفسّر هذا نقطة التوافق الكبرى في [٠٣ §٧.٦](03-المشتريات-داخل-التطبيق.md):
> `storeSpecificId` هو **مفتاح الربط الوحيد** بين المتجر الأصليّ والكتالوج، ولمّا كان
> `BuildProductDefinitions` **لا يمرّر `storeSpecificId`** فـ`SKU الخادم == SKU المتجر`
> إلزامًا لا اختيارًا. ⚠️ **إن اختلفا انقطع الربط كلّه.**
> ⚠️ الحقلان الإلزاميّان يُقرآن بـ`get_Item` لا `TryGetValue` ⇒ **ردّ متجرٍ ناقص يرمي
> `KeyNotFoundException` داخل المحرّك، لا خطأً مُدارًا في اللعبة.**

---

## ٨. 🛑 تصحيحات لفصول سابقة

### 🛑 ١) `SalesChannel` فيه **٣٦** عضوًا لا ٣٠ — تصحيح لـ[٠٣ §٢](03-المشتريات-داخل-التطبيق.md)
`[ENUM:]` عدد `public const` في التعداد = **٣٦** بالضبط. الستّ الغائبة عن الفصل ٠٣:
```
Mintroute = 30 · SubBomb = 31 · Tabby = 32 · LikeCard = 33 · Tamara = 34 · Moyasar = 35
```
> ⭐ `Tabby` و`Tamara` بوّابتا **«اشترِ الآن وادفع لاحقًا»** سعوديّتان، و`LikeCard` بطاقات
> رقمية، و`Moyasar` بوّابة دفع. ⇒ **الأرشيف كان ناقصًا ستّ قنوات، كلّها نقدية حقيقيّة.**
> ✅ والدليل الثاني من كود الآلة: `IsWebPurchasable` @`0x50A82E4` تقبل **`35`** صراحةً:
> ```asm
> cmp w0, #0x1D ; mov w9, #0x23 ; ccmp w0, w9, #4, ne ; cset w9, eq
> cmp w0, #6    ; csel w0, w8, w9, eq
> ```
> ⇒ `IsWebPurchasable(s) == (s == TwoCo(6) || s == Urway(29) || s == Moyasar(35))`.
> **لو كان التعداد ينتهي عند ٢٩ لكان `0x23` كودًا ميّتًا** — وهو ليس كذلك.
> ✅ و`IsHuawei(s)` = `(uint)(s − 27) < 2` ⇒ `HuaweiGameStore(27) ‖ HuaweiRecurring(28)`.

### 🛑 ٢) `ValidateReceipt` لا تتحقّق من شيء
انظر §٢.٢. الاسم في [٠٣ §٣](03-المشتريات-داخل-التطبيق.md) يوحي بتحقّق عميليّ؛ **لا وجود له**.

### 🛑 ٣) توقيع `GetConsumableVersion`
[٠٣ §٧.٥](03-المشتريات-داخل-التطبيق.md) كتبها `GetConsumableVersion(store, listing.listingId)`.
الصواب `[CS:]` + `[BIN:]`: **`store.GetConsumableVersion(listing)`** — دالّة مثيل تأخذ
**الكائن** لا المعرّف، والمطابقة بـ`Contains` المرجعيّة (§٣.٢). الفرق جوهريّ لأنه يفسّر
عِلَّة الهويّة.

---

## ٩. ⭐ خلاصة لإعادة البناء

| القرار | القيمة المستخرجة | الحكم |
|---|---|---|
| ترتيب التهيئة | مستمعون (٨) **قبل** `Connect()`، ثم `await`، ثم `FetchProducts` | ✅ انسخه |
| جهوزيّة المتجر | `OneShotEvent` يصفّ نداءات ما قبل الجهوزيّة | ✅ انسخه |
| فشل الاتصال | `IsReady` يبقى `false` بلا إعادة محاولة ولا رسالة | 🚩 **أضف إعادة محاولة وإشعارًا** |
| `confirm` | `() => StoreController.ConfirmPurchase(order)` | ✅ |
| متى `confirm` | نجاح الخادم · **أو خطأ `AlreadyProcessed(7002)`** · وإلّا **لا** | ⭐⭐⭐ **أهمّ سطر ماليّ في الأرشيف** |
| رسالة خطأ الخادم | تُهمَل؛ يُعرض `GetFriendlyName(code)` | 🚩 اعرض رسالة الخادم |
| النسخة المستهلَكة | مطابقة **بمرجع الكائن** (`List.Contains`) | 🚩 **طابِق بـ`listingId`** |
| ترتيب الاشتراكات | `OrderBy(days)` | ✅ |
| ترتيب المستهلَكات | `OrderBy(days).ThenBy(coins)`، **بلا بوّابة اشتراك** | ✅ انسخه |
| العرض الترويجيّ | `isPromotionActive` **يتجاوز** `isHidden` | ⭐ انسخه |
| تبديل الكتالوج | أربع كتابات بعد بوّابة `null` واحدة | ⭐ اجعله **مرجعًا واحدًا** |
| حالة `ProductStore` | ساكنة كلّها، والمثيل صوريّ | 🚩 اختر واحدًا |
| العنصر بلا رزمة | `pack = −1, −2, …` فيصير رزمةً من واحد | ⭐⭐ انسخه — **على نسخة** |
| ترتيب الرُّزَم | `OrderBy(pack.Min(i => i.Order))` | ✅ |
| داخل الرزمة | `OrderByDescending(virtualPrice)` — **الأغلى أوّلًا** | ⭐ قرار بيعيّ واعٍ |
| اختيار القالب | استنطاق ١٠ حقول بالترتيب؛ `columns ∈ {−4, −1, 4, 6}` | ⭐⭐ انسخ الجدول |
| حامل بلا حقل | `template == null` بصمت | 🚩 سجّل تحذيرًا |
| السعر المعروض | `OrderBy(price).First()` | ⚠️ |
| وسم الخصم | `OrderByDescending(originalPrice).First()` | 🚩 **وحّد القائمة الواحدة** |
| وسوم «كلّها» | `TrueForAll` لـSTC Pay والتكرار · `Any` للعرض | ✅ منطق سليم |
| ثيمات الغرف | إيجار بـ`duration` بالثواني · تُصفَّى بـ`targetGames` | ⭐ |
| البطاقات والأنماط | **لا تُصفَّى** بـ`targetGames` | 🚩 تناقض — اختر بوعي |
| ربط SKU | `SKU الخادم == storeSpecificId == SKU المتجر` إلزامًا | ⚠️ لا تفصلهما |
| القنوات | **٣٦** قناة · الويب = `{6, 29, 35}` · هواوي = `{27, 28}` · STC Pay = `{26}` | ✅ |

---

[↩ الفهرس](README.md)
