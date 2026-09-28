# مكوّنات `DOTweenAnimation` في مشهدَي جكارو

[↩ أرشيف جكارو](../README.md)

> هذه تغريدات **مُعرَّفة في المحرِّر** (لا في الكود). تغريدات الكود في
> [٠٨](../08-الأنيميشن-حركة-الجلول.md). ✅ كلها مقروءة من typetree.

## الخاصّة بجكارو ⭐

| العنصر | النوع | المدّة | التأخير | Ease | التكرار | القيمة النهائية | تشغيل تلقائي |
|---|---|---|---|---|---|---|---|
| `Jackaroo Options Panel` | Move | 0.30 | 0 | **OutQuad** | 0 / Restart | `(0, −12, 0)` | ✘ |
| `Jackaroo Burn Other Card Panel` | Move | 0.30 | 0 | **OutQuad** | 0 / Restart | `(0, −12, 0)` | ✘ |
| `Jackaroo Action Tip Panel` | Fade | 0.25 | 0 | **OutQuad** | 0 / Restart | `alpha 1.0` | ✘ |
| `lit background` | Fade | 1.00 | 0 | **InOutSine** | **∞ / Yoyo** | `alpha 1.0` | **✔** |

> ⭐ لوحتا الخيارات والحرق تنزلقان **١٢ وحدة لأسفل** في ٠.٣ ث بـ`OutQuad` — متطابقتان تمامًا.
> و«الخلفية المضيئة» تنبض بلا نهاية ذهابًا وإيابًا في ثانية واحدة، وهي **الوحيدة** ذات تشغيل تلقائي.

## الهاتف — الكلّ (19)

| العنصر | النوع | المدّة | التأخير | Ease | التكرار | القيمة النهائية | تلقائي |
|---|---|---|---|---|---|---|---|
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Jackaroo Options Panel` | Move | 0.3 | 0.0 | OutQuad | 0 / Restart | (0.0, -12.0, 0.0) | ✘ |
| `Jackaroo Action Tip Panel` | Fade | 0.25 | 0.0 | OutQuad | 0 / Restart | alpha 1.0 | ✘ |
| `Jackaroo Burn Other Card Panel` | Move | 0.3 | 0.0 | OutQuad | 0 / Restart | (0.0, -12.0, 0.0) | ✘ |
| `lit background` | Fade | 1.0 | 0.0 | InOutSine | ∞ / Yoyo | alpha 0.0 | ✔ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |

## التابلت — الكلّ (27)

| العنصر | النوع | المدّة | التأخير | Ease | التكرار | القيمة النهائية | تلقائي |
|---|---|---|---|---|---|---|---|
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Jackaroo Options Panel` | Move | 0.3 | 0.0 | OutQuad | 0 / Restart | (0.0, 38.0, 0.0) | ✘ |
| `Jackaroo Tip Panel` | Move | 0.25 | 0.0 | OutQuad | 1 / Restart | (0.0, -35.0, 0.0) | ✘ |
| `Jackaroo Action Tip Panel` | Fade | 0.25 | 0.0 | OutQuad | 0 / Restart | alpha 1.0 | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Jackaroo Burn Other Card Panel` | Move | 0.3 | 0.0 | OutQuad | 0 / Restart | (0.0, 38.0, 0.0) | ✘ |
| `lit background` | Fade | 1.0 | 0.0 | InOutSine | ∞ / Yoyo | alpha 0.0 | ✔ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Clubs` | Scale | 0.5 | 0.0 | OutQuad | ∞ / Yoyo | 1.5 (uniform) | ✔ |
| `Diamonds` | Scale | 0.5 | 0.1 | OutQuad | ∞ / Yoyo | 1.5 (uniform) | ✔ |
| `Spades` | Scale | 0.5 | 0.2 | OutQuad | ∞ / Yoyo | 1.5 (uniform) | ✔ |
| `Hearts` | Scale | 0.5 | 0.3 | OutQuad | ∞ / Yoyo | 1.5 (uniform) | ✔ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | InBack | 1 / Restart | 0.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | Scale | 0.3 | 0.0 | OutBack | 1 / Restart | 1.0 (uniform) | ✘ |
| `Rotation Loading one gameobject` | LocalRotate | 1.5 | 0.0 | Linear | ∞ / Restart | (0.0, 0.0, -360.0)° | ✘ |

> مؤشّرات التحميل (`Rotation Loading one gameobject`) نمط متكرّر ثابت:
> **Scale 0.3 ث `InBack`/`OutBack`** للظهور والاختفاء، و**LocalRotate 1.5 ث `Linear` بلا نهاية إلى `−360°`**.
