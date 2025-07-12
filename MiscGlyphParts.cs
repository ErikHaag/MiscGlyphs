using Quintessential;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using PartType = class_139;
using Permissions = enum_149;
using Texture = class_256;


namespace MiscGlyphs;
internal static class MiscGlyphParts
{
    // This isn't meant to be fancy, just a little demonstration to chuckle at.
    public static PartType Filtration;

    public static Texture filtrationBase = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/filtration_base");
    public static Texture bowl = class_238.field_1989.field_90.field_170;
    public static Texture hole = class_238.field_1989.field_90.field_255.field_293;
    public static Texture[] irisAnimation = class_238.field_1989.field_90.field_246;
    public static Texture irisRing = class_238.field_1989.field_90.field_228.field_271;
    public static Texture irisWell = class_238.field_1989.field_90.field_228.field_272;

    public static Texture filtrationGlow = Brimstone.API.GetTexture("textures/select/erikhaag/MiscGlyphs/triline_glow");
    public static Texture filtrationOutline = Brimstone.API.GetTexture("textures/select/erikhaag/MiscGlyphs/triline_outline");
    public static Texture filtrationIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/filtration");
    public static Texture filtrationIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/filtration_hover");

    public static HexIndex filterBowl = new(0, 0);
    public static HexIndex filterInput = new(-1, 0);
    public static HexIndex filterOutput = new(1, 0);


    public static PartType TrueCalcification;

    public static Texture trueCalcificationBase = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/true_calcification_base");
    public static Texture toSaltSymbol = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/symbol_to_salt");

    public static Texture trueCalcificationGlow = class_238.field_1989.field_97.field_382;
    public static Texture trueCalcificationOutline = class_238.field_1989.field_97.field_383;
    public static Texture trueCalcificationIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_calcification");
    public static Texture trueCalcificationIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_calcification_hover");

    public static HexIndex center = new(0, 0);

    public static PartType TrueDuplication;

    public static Texture trueDuplicationBase = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/true_duplication_base");
    public static Texture metalBowl = class_238.field_1989.field_90.field_255.field_292;
    public static Texture duplicationBond = class_238.field_1989.field_90.field_173;
    public static Texture saltSymbol = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/symbol_salt");

    public static Texture trueDuplicationGlow = class_238.field_1989.field_97.field_374;
    public static Texture trueDuplicationOutline = class_238.field_1989.field_97.field_375;
    public static Texture trueDuplicationIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_duplication");
    public static Texture trueDuplicationIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_duplication_hover");

    public static HexIndex subjectBowl = new(0, 0);
    public static HexIndex saltBowl = new(1, 0);

    //public static PartType Tripurification;
    //public static PartType SPTransformer;

    public static void AddPartTypes()
    {
        Filtration = new()
        {
            field_1528 = "misc-glyph-filter", // ID
            field_1529 = class_134.method_253("Glyph of Filtration", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of filtration allows atoms to pass through if they match the atom in the bowl, or if the bowl is empty.", string.Empty), // Description
            field_1531 = 30, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = filtrationGlow, // Shadow/glow
            field_1550 = filtrationOutline, // Stroke/outline
            field_1547 = filtrationIcon, // Panel icon
            field_1548 = filtrationIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            {
                filterBowl,
                filterInput,
                filterOutput
            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MiscGlyphs.FiltrationPermission)
        };

        TrueCalcification = new()
        {
            field_1528 = "misc-glyph-true-calc", // ID
            field_1529 = class_134.method_253("Glyph of True Calcification", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of true calcification transmutes any atom into salt.", string.Empty), // Description
            field_1531 = 30, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = trueCalcificationGlow, // Shadow/glow
            field_1550 = trueCalcificationOutline, // Stroke/outline
            field_1547 = trueCalcificationIcon, // Panel icon
            field_1548 = trueCalcificationIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            {
                center
            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MiscGlyphs.TrueCalcificationPermission)
        };

        TrueDuplication = new()
        {
            field_1528 = "misc-glyph-true-dupl", // ID
            field_1529 = class_134.method_253("Glyph of True Duplication", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of true duplication turns salt into any atom by copying the essence of another free atom.", string.Empty), // Description
            field_1531 = 40, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = trueDuplicationGlow, // Shadow/glow
            field_1550 = trueDuplicationOutline, // Stroke/outline
            field_1547 = trueDuplicationIcon, // Panel icon
            field_1548 = trueDuplicationIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            {
                subjectBowl,
                saltBowl
            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MiscGlyphs.TrueDuplicationPermission)
        };

        QApi.AddPartTypeToPanel(Filtration, false);
        QApi.AddPartTypeToPanel(TrueCalcification, false);
        QApi.AddPartTypeToPanel(TrueDuplication, false);

        QApi.AddPartType(Filtration, static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.method_507().method_481(part);
            class_236 uco = editor.method_1989(part, pos);
            float time = editor.method_504();
            Vector2 offset = new(140f, 65f);

            renderer.method_523(filtrationBase, Vector2.Zero, offset, 0f);
            renderer.method_529(hole, filterInput, Vector2.Zero);
            renderer.method_529(bowl, filterBowl, Vector2.Zero);
            renderer.method_529(irisWell, filterOutput, Vector2.Zero);

            int irisFrame = 15;
            bool afterIrisOpens = false;
            AtomType outputAtom = pss.field_2743 ? pss.field_2744[0] : Brimstone.API.VanillaAtoms["salt"];
            Molecule risingAtom = Molecule.method_1121(outputAtom);

            Vector2 risingOffset = uco.field_1984 + class_187.field_1742.method_492(filterOutput).Rotated(uco.field_1985);

            if (pss.field_2743)
            {
                irisFrame = class_162.method_404((int)(class_162.method_411(1f, -1f, time) * 16f), 0, 15);
                afterIrisOpens = time > 0.5f;
                if (!afterIrisOpens)
                {
                    // show atom rising behind iris
                    Editor.method_925(risingAtom, risingOffset, new HexIndex(0, 0), 0f, 1f, time, 1f, false, null);
                }
            }
            renderer.method_529(irisAnimation[irisFrame], filterOutput, Vector2.Zero);
            renderer.method_528(irisRing, filterOutput, Vector2.Zero);
            if (pss.field_2743 && afterIrisOpens)
            {
                // show atom rising infront of iris
                Editor.method_925(risingAtom, risingOffset, new HexIndex(0, 0), 0f, 1f, time, 1f, false, null);
            }
        });

        QApi.AddPartType(TrueCalcification, static (part, pos, editor, renderer) =>
        {
            Vector2 offset = new(41f, 48f);
            renderer.method_523(trueCalcificationBase, Vector2.Zero, offset, 0f);
            renderer.method_529(bowl, center, Vector2.Zero);
            renderer.method_529(toSaltSymbol, center, Vector2.Zero);
        });

        QApi.AddPartType(TrueDuplication, static (part, pos, editor, renderer) =>
        {
            Vector2 offset = new(41f, 48f);
            renderer.method_523(trueDuplicationBase, Vector2.Zero, offset, 0f);
            renderer.method_529(bowl, subjectBowl, Vector2.Zero);
            renderer.method_529(metalBowl, saltBowl, Vector2.Zero);
            renderer.method_529(saltSymbol, saltBowl, Vector2.Zero);
            renderer.method_521(duplicationBond, new(-31f, 21f));
        });

        QApi.RunAfterCycle((sim, first) =>
        {
            SolutionEditorBase seb = sim.field_3818;
            Dictionary<Part, PartSimState> pss = sim.field_3821;
            List<Part> parts = seb.method_502().field_3919;

            foreach (Part part in parts)
            {
                PartType type = part.method_1159();
                if (type == Filtration)
                {
                    if (first && !pss[part].field_2743)
                    {
                        if (sim.FindAtomRelative(part, filterInput).method_99(out AtomReference input) && !input.field_2281 && !input.field_2282 && !sim.FindAtomRelative(part, filterOutput).method_1085())
                        {
                            // Input is singular, and not held.
                            // Output isn't blocked
                            bool passageAllowed = true;
                            if (sim.FindAtomRelative(part, filterBowl).method_99(out AtomReference filterer))
                            {
                                passageAllowed = input.field_2280 == filterer.field_2280;
                            }
                            if (passageAllowed)
                            {
                                // Delete the input
                                Brimstone.API.RemoveAtom(input);
                                // Play deletion animation
                                seb.field_3937.Add(new(seb, input.field_2278, input.field_2280));
                                Brimstone.API.AddSmallCollider(sim, part, filterOutput);
                                pss[part].field_2743 = true;
                                pss[part].field_2744 = new AtomType[1] { input.field_2280 };
                            }
                        }
                    }
                    else if (pss[part].field_2743)
                    {
                        // Spawn new atom
                        AtomType output = pss[part].field_2744[0];
                        Brimstone.API.AddAtom(sim, output, part, filterOutput);
                    }
                }
                else if (type == TrueCalcification)
                {
                    if (sim.FindAtomRelative(part, center).method_99(out AtomReference toCalc) && toCalc.field_2280 != Brimstone.API.VanillaAtoms["salt"])
                    {
                        // play calcification animation
                        Brimstone.API.ChangeAtom(toCalc, Brimstone.API.VanillaAtoms["salt"]);
                        toCalc.field_2279.field_2276 = new class_168(seb, (enum_7)0, (enum_132)0, toCalc.field_2280, class_238.field_1989.field_81.field_611, 30f);
                    }
                }
                else if (type == TrueDuplication)
                {
                    if (sim.FindAtomRelative(part, subjectBowl).method_99(out AtomReference subject) && subject.field_2280 != Brimstone.API.VanillaAtoms["salt"] && sim.FindAtomRelative(part, saltBowl).method_99(out AtomReference salt) && salt.field_2280 == Brimstone.API.VanillaAtoms["salt"])
                    {
                        Brimstone.API.ChangeAtom(salt, subject.field_2280);
                        salt.field_2279.field_2276 = new class_168(seb, (enum_7)0, (enum_132)0, Brimstone.API.VanillaAtoms["salt"], class_238.field_1989.field_81.field_612, 30f);
                    }
                }
            }
        });
    }
}
