using Quintessential;

namespace MiscGlyphs;

public class MiscGlyphs : QuintessentialMod
{

    public const string FiltrationPermission = "MiscGlyphs:Filtration";
    public const string UnionPermission = "MiscGlyphs:Union";
    public const string SeverancePermission = "MiscGlyphs:Severance";
    public const string TrueCalcificationPermission = "MiscGlyphs:TrueCalification";
    public const string TrueDuplicationPermission = "MiscGlyphs:TrueDuplication";
    public const string MitosisPermission = "MiscGlyphs:Mitosis";
    public const string CDispersionPermission = "MiscGlyphs:CDispersion";
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
        QApi.AddPuzzlePermission(UnionPermission, "Glyph of Union", "Misc. Glyphs");
        QApi.AddPuzzlePermission(SeverancePermission, "Glyph of Severance", "Misc. Glyphs");
        QApi.AddPuzzlePermission(TrueCalcificationPermission, "Glyph of True Calcification", "Misc. Glyphs");
        QApi.AddPuzzlePermission(TrueDuplicationPermission, "Glyph of True Duplication", "Misc. Glyphs");
        QApi.AddPuzzlePermission(MitosisPermission, "Glyph of Mitosis", "Misc. Glyphs");
        QApi.AddPuzzlePermission(CDispersionPermission, "Glyph of Dispersion (C)", "Misc. Glyphs");
    }

    public override void Unload()
    {

    }
}