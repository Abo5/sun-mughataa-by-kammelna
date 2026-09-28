# دروس التعليم — البيانات الكاملة

> **المصدر**: أصول `TutorialGame` (ScriptableObject) داخل
> `extracted/Payload/كملنا.app/Data/Raw/aa/iOS/tutorials__1d0e74690ad13969267fb382db134225.bundle`
> — فُكّت بايتًا بايت، و**طول البايتات المُستهلَكة = طول الـraw بالضبط** لكل أصل ⇒ تحليل صحيح 100%.
>
> **تحقّق مستقلّ ثانٍ**: جداول `TutorialCards..cctor` @`0x520B8E4` (564 ورقة، تغطية 100%)
> أعطت **نفس** ورقة الأرض و`CheatingCases` و`catchMove` — تصادق المسارين.

> 🛑 **`TutorialCards` كود ميّت في هذا البناء** — لا شيء خارجه يقرأ حقوله. البيانات الحيّة
> من الأصول. أُبقي هنا للمرجع ولأنه يغطّي النوع `3 Catch` غير المشحون.

الترميز: `Suit*13 + Rank` · `Rank`: 2=0 … A=12 · `Suit`: ♠=0 ♥=1 ♣=2 ♦=3

---

## ١. جدول الدروس

| كود | `TutorialType` | اسم الأصل (ترتيب العرض) | `RoutingCommand` | الموزّع | الأرض | غشّ | `catchMove` | أزرار المزايدة | أزرار الإمساك |
|---|---|---|---|---|---|---|---|---|---|
| 1 | `Hokom` | **3-Hokom** | 11003 | 3 | ♦J | ✘ | 0 | `120` = حكم+أشكل+دبل+حكم‑مفتوح | `0` |
| 2 | `Sun` | **1-Sun** | 11001 | 1 | ♠7 | ✘ | 0 | `100` = باس+دبل+حكم‑مفتوح | `0` |
| 3 | `Catch` | — **غير مشحون** | — | — | ♠A* | — | 3* | — | — |
| 4 | `AdvancedHokom` | **4-Advanced Hokom** | 11003 | 3 | ♦J | ✘ | 0 | `100` | `0` |
| 5 | `AdvancedSun` | **2-Advanced Sun** | 11001 | 3 | ♥A | ✘ | 0 | `99` = صن+على‑الصن+دبل+حكم‑مفتوح | `0` |
| 6 | `CatchSun` | **5-Catch Sun** | 11002 | 3 | ♠7 | ✔ | 3 | `99` | `4` = كشف الأوراق |
| 7 | `CatchClosedDbl` | **6-Catch Closed Dbl** | 11002 | 2 | ♥K | ✔ | 2 | `40` = حكم+دبل | `4` |
| 8 | `CatchHokomCut` | **7-Catch Hokom Cut** | 11002 | 1 | ♠8 | ✔ | 4 | `-60` ⇒ باس+حكم‑مفتوح | `4` |
| 9 | `CatchHokomUp` | **8-Catch Hokom Up** | 11002 | 3 | ♣Q | ✔ | 3 | `-24` ⇒ حكم+دبل+حكم‑مفتوح | `4` |
| 10 | `CatchHokomHKMCut` | **9-Catch Hokom HKMCut** | 11002 | 3 | ♥8 | ✔ | 3 | `-24` | `4` |
| 11 | `CatchWrongSawa` | **10-Catch Wrong Sawa** | 11002 | 1 | ♠9 | ✔ | **5** | `-60` | `1` = صاوا خاطئة |
| 12 | `CatchWrongEkka` | **11-Catch Wrong Ekka** | 11002 | 0 | ♠K | ✔ | 4 | `4` = باس فقط | `2` = إكّة خاطئة |

\* من جداول `TutorialCards` القديمة فقط.

> ⚠️ **ترتيب العرض ≠ قيمة الـenum**: `AdvancedSun` هو النوع 5 لكنه الدرس **الثاني**،
> و`Hokom` هو النوع 1 لكنه الدرس **الثالث**.

**`RoutingCommand`**: `11001 = Tutorial_Sun` · `11002 = Tutorial_Catch` · `11003 = Tutorial_Hokom`

```csharp
// TutorialTypeExtensions.IsCatchTutorial @0x5220860
return t == 3 || (t >= 6 && t <= 12);
```

---

## ٢. دروس اللعب — الأيدي الكاملة

### الدرس ١ — `Sun` (النوع 2) · الأرض ♠7 · الموزّع 1
```
يد اللاعب   مرحلة1: ♣8 ♣A ♦K ♠Q ♠K     مرحلة2: ♥7 ♣10 ♠J      (8 أوراق)
cardsAI2 : ♥Q ♦7 ♦9 ♠A ♦Q ♦J ♣Q ♥K
cardsAI3 : ♥A ♦A ♦10 ♠7 ♥8 ♥9 ♣J ♠10
cardsAI4 : ♥J ♦8 ♣7 ♠9 ♣K ♣9 ♠8 ♥10
الأوراق المفروضة [عدد أوراق اليد]:
  [8] ♥7 · [7] ♦K · [6] ♠K · [5] ♠J · [4] ♣8 · [3] ♠Q · [2] ♣10 ♣A · [1] ♣10 ♣A
```

### الدرس ٢ — `AdvancedSun` (النوع 5) · الأرض ♥A · الموزّع 3
```
اليد   م1: ♦K ♦10 ♥J ♥K ♥10     م2: ♣9 ♠Q
cardsAI2 : ♦7 ♥8 ♠9 ♠J ♣8 ♣10 ♠A ♦A
cardsAI3 : ♦Q ♥Q ♠7 ♦9 ♠K ♣A ♣K ♣J
cardsAI4 : ♦8 ♥7 ♥9 ♣7 ♣Q ♦J ♠8 ♠10
المفروضة: [8]♦K [7]♥A [6]♥10 [5]♥K [4]♥J [3]♣9 [2]♦10 [1]♠Q
```

### الدرس ٣ — `Hokom` (النوع 1) · الأرض ♦J · الموزّع 3
```
اليد   م1: ♣J ♦9 ♦Q ♦A ♥A     م2: ♠J ♠10
cardsAI2 : ♦8 ♦K ♠9 ♠8 ♥7 ♣7 ♥8 ♥10
cardsAI3 : ♦10 ♦7 ♠A ♠K ♠Q ♠7 ♣9 ♣K
cardsAI4 : ♣8 ♥9 ♥J ♥Q ♣Q ♥K ♣10 ♣A
firstPhaseAi3 = ♣9 ♦7 ♦10 ♠7 ♠Q · secondPhaseAi3 = ♣K ♠K ♠A   (الشريك حقيقي، الآخران صوريّان)
المفروضة: [8][7] ♦J ♦9 ♦A · [6] ♠10 · [5] ♠J · [4] ♣J · [3][2][1] ♦Q ♥A ♦A ♦J ♦9 ♦A
```

### الدرس ٤ — `AdvancedHokom` (النوع 4) · الأرض ♦J · الموزّع 3
```
اليد   م1: ♠J ♦9 ♦8 ♣7 ♣9     م2: ♠7 ♠A ♠9
cardsAI2 : ♦K ♠Q ♥7 ♥8 ♣K ♣Q ♥10 ♥9
cardsAI3 : ♦J ♠K ♣8 ♥Q ♥J ♦7 ♦10 ♦A
cardsAI4 : ♦Q ♠10 ♠8 ♣J ♥K ♣10 ♣A ♥A
firstPhaseAi2 = ♥7 ♥8 ♠Q ♣Q ♦K · secondPhaseAi2 = ♥9 ♥10 ♣K
المفروضة: [8]♦8 [7]♠A [6]♠J [5]♠9 [4]♠7 [3]♣7 ♣9 [2]♦9 [1]♣7 ♣9
```

---

## ٣. دروس الإمساك

كلها `isCheating = true` · `tutorialErrors` **فارغة** · كل النصائح = `"try to find the cheater"`

| النوع | اليد م1 / م2 | AI2 | AI3 | AI4 | **`cheatingCases`** | المفروضة |
|---|---|---|---|---|---|---|
| **6** CatchSun | ♠J ♠9 ♠8 ♣7 ♦J / ♠Q ♥10 | ♣8 ♠A ♣9 | ♠10 ♠K ♦8 | ♦9 ♦7 ♥K | **♣8 ♠A** | [8]♠8 [7]♠9 |
| **7** CatchClosedDbl | ♠A ♥7 ♣A ♦Q ♦K / ♠10 ♦J ♦10 | ♥Q | ♥8 | ♥J ♣K | **♥J ♣K** | [8]♥7 |
| **8** CatchHokomCut | ♥8 ♥K ♣K ♣A ♦10 / ♠K ♦7 ♦A | ♣7 ♦Q ♠A | ♣J ♠9 ♠Q | ♣Q ♣8 ♠J ♦8 | **♦Q ♠A** | [8]♣A [7]♣K [6]♠K |
| **9** CatchHokomUp | ♠8 ♥K ♥A ♦10 ♦A / ♠Q ♣J | ♣7 ♣10 ♣8 | ♣A ♣K ♦9 | ♣9 ♠A ♦Q | **♣7 ♣10** | [8]♣Q [7]♠8 |
| **10** CatchHokomHKMCut | ♠10 ♥J ♥10 ♣9 ♦7 / ♥Q ♣K | ♣7 ♥A ♣8 | ♥9 ♠8 ♣10 | ♥7 ♥K ♦10 | **♣7 ♥A** | [8]♥J [7]♥10 |
| **11** CatchWrongSawa | ♠7 ♠A ♥9 ♣7 ♦Q / ♥Q ♣J ♣K | ♦10 ♠K ♠8 ♣8 | ♦7 ♠Q ♦9 ♣A | ♦8 ♠J ♠10 ♠9 | **♣Q ♣K** | [8]♦Q [7]♠7 [6]♠A [5]♣J |
| **12** CatchWrongEkka | ♥8 ♥K ♦7 ♠A ♦10 / ♣J ♦8 ♦A | ♠J ♠9 ♣10 ♣A | ♠Q ♠10 ♣9 ♣7 | ♠7 ♠8 ♣8 ♣K | **♣10 ♣A** | [8]♠A [7]♦7 [6]♣J |

### الأيدي المكشوفة في لوحة الاتهام (`hand1..hand4`)

| النوع | hand1 | hand2 | hand3 | hand4 |
|---|---|---|---|---|
| 6 | ♥10 ♦J ♣7 ♠7 ♠Q ♠J | ♥8 ♣K ♥A ♣Q ♣A | ♦10 ♣10 ♥9 ♥J ♥Q | ♦A ♣J ♥7 ♦Q ♦K |
| 7 | ♦7 ♦A ♥K ♣Q ♣A ♠J ♠Q | ♣10 ♠9 ♥A ♣9 ♠8 ♠K ♠7 | ♠10 ♠A ♦J ♦Q ♦K ♦10 ♣8 | ♥7 ♣7 ♥8 ♦8 ♦9 ♥9 |
| 8 | ♥8 ♥K ♦7 ♦10 ♦A | ♥7 ♥9 ♥10 ♥J ♥Q | ♥A ♣10 ♦J ♦K ♦9 | ♣9 ♠7 ♠8 ♠10 |
| 9 | ♠Q ♥K ♥A ♣J ♦10 ♦A | ♥7 ♥9 ♥10 ♥J ♥8 | ♦7 ♠J ♦J ♦K ♠K | ♦8 ♥Q ♠7 ♠9 ♠10 |
| 10 | ♠10 ♥8 ♥Q ♣9 ♣K ♦7 | ♠7 ♠9 ♠J ♠Q ♠K | ♦K ♦A ♣J ♣Q ♣A | ♦8 ♦9 ♦J ♦Q ♠A |
| 11 | ♣7 ♣K ♥9 ♥Q | ♣10 ♦J ♦K ♥8 | ♣9 ♥7 ♥J ♥10 | ♣Q ♦A ♥K ♥A |
| 12 | ♥8 ♥K ♦8 ♦10 ♦A | ♥7 ♥9 ♥J ♠K | ♣Q ♦9 ♥Q ♥10 | ♦J ♦Q ♦K ♥A |

> ⭐ **`cheatingCases` ورقتان بالضبط لكل درس**: الأولى = الورقة الخاطئة التي لعبها الغشّاش،
> والثانية = الورقة التي كان يجب أن يلعبها. الإمساك يُحتسب صحيحًا **فقط إن اختار اللاعب
> كلتيهما**.

**الغشّ السلوكي** — `_gameAiCheatOption` (القيمة الوحيدة المشحونة):
درس 12 `CatchWrongEkka`: `{ roundIndex: 2, playerIndex: 1, aiCheatOption: WrongEkkah(1) }`
⇒ في الجولة 2 يُجبَر المقعد 1 على إعلان إكّة خاطئة. تُقرأ في
`TutorialGameController.CheckEkkah` @`0x521E60C`.

---

## ٤. النصائح ورسائل الخطأ

> المصدر الحيّ هو `LastTutorialGame.BodyTextTips[numberOfCards]` —
> **الحقول الساكنة `bodyTextTips_*` لا تُقرأ أبدًا**.

### درس `Sun` (2)

| المؤشّر | النصيحة | الخطأ |
|---|---|---|
| 8 | Play Seven it is the only Hearts you have, btw you have a project in your hand | You can't play {0} {1}, the floor Hearts and you have ones in your hand |
| 7 | Play King it is the Only Dimonds | You can't play {0} {1}, the floor diamonds… |
| 6 | Play King Speads give your team high poitnts | this is a valid card but you for tutorial purpose play the best card only |
| 5 | Play Jack Spead, they may have 10 or Ace | You can't play {0} {1}, the floor spades… — **حالة خاصّة: إن كانت ♠Q ⇒ "this is a valid card but…"** |
| 4 | Play 8 Clubs, you don't have Dimonds and give them low points | this is a valid card but… |
| 3 | Play Queen Speads, you don't have Dimonds and give them low points | this is a valid card but… |
| 2 | Play Ace or Ten they will anyway | — |
| 1 | play last card | — |
| 0 | the game is ended! | — |

### درس `AdvancedSun` (5)
`[8]` Play Diamonds king they may make tfrnek · `[7]` Don't play 10 diamonds because ace did not show
Play all hearts in order. this make you eat 5 times · `[6][5][4]` Play all hearts in order…
`[3]` Play clubs because your mate did not used ever · `[2]` Play ten of diamonds to get high points
`[1]` play last card · `[0]` the game is ended!
كل الأخطاء (9/9): `this is a valid card but you for tutorial purpose play the best card only`

### درس `Hokom` (1)
`[8]` Play any of the top 3 Diamonds they will take the eat · `[7]` Play any of the top 2 Diamonds…
`[6]` Play 10 because your mate have the ace that in his project · `[5]` Play Jack spades, it is the only spades you have
`[4]` Play Jack clubs, to get rid of it and play diamonds · `[3]` Play anything, all cards will eat hokom or ace
`[2]` Play anything, all cards will eat · `[1]` play last card · `[0]` the game is ended!

### درس `AdvancedHokom` (4)
`[8]` Play with eight of diamonds to remove hokom cards · `[7]` Play Ace of Spades to eat
`[6]` Play Jack of Spades because it is ekka and your teammate will not play with hokom
`[5]` Continue playing with Spades using the nine because it is ekka
`[4]` Continue playing with Spades using the seven because it is ekka
`[3]` You can play seven or nine of the clubs to make your teammate play hokom
`[2]` Play nine of diamonds it is the only diamonds you have · `[1]` play last card · `[0]` the game is ended!
**حالة خاصّة عند `[7]`**: إن كانت الفصيلة ≠ ♠ ⇒ `"You can't play {0} {1}, the floor spades…"`

### مفاتيح إضافية
`"Sun_Order"` · `"Hokom_Order"` · `"Take the Aklah before you continue play"` ·
`"buy floor card to detrmine playing type"` · `"not the best card"` ·
`"you cannot play this card"` · `"{0} {1}"` · `"try to find the cheater"`

**ألوان العنوان** ✅: `(1,1,1)` أبيض لـ`"not the best card"` · `(1,0,0)` **أحمر** لـ`"you cannot play this card"`
