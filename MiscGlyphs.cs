using Quintessential;

namespace MiscGlyphs;

public class MiscGlyphs : QuintessentialMod
{

    public const string FiltrationPermission = "MiscGlyphs:Filtration";
    public const string TrueCalcificationPermission = "MiscGlyphs:TrueCalification";
    public const string TrueDuplicationPermission = "MiscGlyphs:TrueDuplication";
    public const string MitosisPermission = "MiscGlyphs:Mitosis";

    public override void Load()
    {

    }

    public override void PostLoad()
    {

    }

    public override void LoadPuzzleContent()
    {
        MiscGlyphParts.AddPartTypes();
        QApi.AddPuzzlePermission(FiltrationPermission, "Glyph of Filtration", "Misc. Glyphs");
        QApi.AddPuzzlePermission(TrueCalcificationPermission, "Glyph of True Calcification", "Misc. Glyphs");
        QApi.AddPuzzlePermission(TrueDuplicationPermission, "Glyph of True Duplication", "Misc. Glyphs");
        QApi.AddPuzzlePermission(MitosisPermission, "Glyph of Mitosis", "Misc. Glyphs");
    }

    public override void Unload()
    {

    }
}