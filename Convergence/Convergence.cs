using Landfall.Haste;
using Landfall.Modding;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Localization;
using Zorro.Settings;

namespace Convergence;

[LandfallPlugin]
public class Program
{
    static Program()
    {
        Debug.Log("[Convergence] Loaded!");

        On.SaveSystem.Load += (orig) => {
            HasteSave save = orig();
            UnlockItems();
            return save;
        };
    }

    static void UnlockItems()
    {
        FactSystem.SetFact(new Fact("HypernovaBoots_ShowItem"), 1.0f);
        FactSystem.SetFact(new Fact("item_unlocked_HypernovaBoots"), 1.0f);

        FactSystem.SetFact(new Fact("DivinerCore_ShowItem"), 1.0f);
        FactSystem.SetFact(new Fact("item_unlocked_DivinerCore"), 1.0f);

        FactSystem.SetFact(new Fact("InductionVitamins_ShowItem"), 1.0f);
        FactSystem.SetFact(new Fact("item_unlocked_InductionVitamins"), 1.0f);
    }
}

/*
// The HasteSetting attribute is equivalent to
// GameHandler.Instance.SettingsHandler.AddSetting(new HelloSetting());
[HasteSetting]
public class HelloSetting : FloatSetting, IExposedSetting
{
    public override void ApplyValue() => Debug.Log($"Mod apply value {Value}");
    protected override float GetDefaultValue() => 120;
    protected override float2 GetMinMaxValue() => new(100, 200);
    public LocalizedString GetDisplayName() => new UnlocalizedString("mod setting!!");
    public string GetCategory() => SettingCategory.General;
}
*/