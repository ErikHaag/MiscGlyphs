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

    // Greenfield
    public static PartType Filtration;

    public static Texture filtrationBase = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/filtration_base");
    public static Texture bowl = class_238.field_1989.field_90.field_170;
    public static Texture hole = class_238.field_1989.field_90.field_255.field_293;
    public static Texture[] irisAnimation = class_238.field_1989.field_90.field_246;
    public static Texture irisRing = class_238.field_1989.field_90.field_228.field_271;
    public static Texture irisWell = class_238.field_1989.field_90.field_228.field_272;

    public static Texture filtrationGlow = Brimstone.API.GetTexture("textures/select/erikhaag/MiscGlyphs/triline_glow");
    public static Texture filtrationStroke = Brimstone.API.GetTexture("textures/select/erikhaag/MiscGlyphs/triline_stroke");
    public static Texture filtrationIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/filtration");
    public static Texture filtrationIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/filtration_hover");

    public static readonly HexIndex filterBowl = new(0, 0);
    public static readonly HexIndex filterInput = new(-1, 0);
    public static readonly HexIndex filterOutput = new(1, 0);

    // Crazybot27
    public static PartType TrueCalcification;

    public static Texture trueCalcificationBase = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/true_calcification_base");
    public static Texture toSaltSymbol = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/symbol_to_salt");

    public static Texture trueCalcificationGlow = class_238.field_1989.field_97.field_382;
    public static Texture trueCalcificationStroke = class_238.field_1989.field_97.field_383;
    public static Texture trueCalcificationIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_calcification");
    public static Texture trueCalcificationIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_calcification_hover");

    public static readonly HexIndex center = new(0, 0);

    // Crazybot27
    public static PartType TrueDuplication;

    public static Texture trueDuplicationBase = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/true_duplication_base");
    public static Texture metalBowl = class_238.field_1989.field_90.field_255.field_292;
    public static Texture duplicationBond = class_238.field_1989.field_90.field_173;
    public static Texture saltSymbol = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/symbol_salt");

    public static Texture trueDuplicationGlow = class_238.field_1989.field_97.field_374;
    public static Texture trueDuplicationStroke = class_238.field_1989.field_97.field_375;
    public static Texture trueDuplicationIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_duplication");
    public static Texture trueDuplicationIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/true_duplication_hover");

    public static readonly HexIndex subjectBowl = new(0, 0);
    public static readonly HexIndex saltBowl = new(1, 0);

    // Crazybot27 
    public static PartType Mitosis;

    public static Texture mitosisBase = class_238.field_1989.field_90.field_160;
    public static Texture mitosisBond = class_238.field_1989.field_90.field_161;
    public static Texture mitosisBowl = class_238.field_1989.field_90.field_163;

    public static Texture mitosisIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/mitosis");
    public static Texture mitosisIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/mitosis_hover");

    public static readonly HexIndex irisBowl = new(1, 0);

    // Yosh
    public static PartType CDispersion;
    public static Texture cDispersionBase = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/dispersion_c_base");
    public static Texture cDispersionInput = class_238.field_1989.field_90.field_228.field_270;
    public static Texture quintessenceSymbol = class_238.field_1989.field_90.field_238.field_341;

    public static Texture cDisperionGlow = Brimstone.API.GetTexture("textures/select/erikhaag/MiscGlyphs/dispersion_c_glow");
    public static Texture cDisperionStroke = Brimstone.API.GetTexture("textures/select/erikhaag/MiscGlyphs/dispersion_c_stroke");
    public static Texture cDispersionIcon = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/dispersion_c");
    public static Texture cDispersionIconHover = Brimstone.API.GetTexture("textures/parts/erikhaag/MiscGlyphs/icons/dispersion_c_hover");

    public static readonly HexIndex quintessenceHex = new(0, 0);
    public static readonly HexIndex airHex = new(0, 1);
    public static readonly HexIndex earthHex = new(2, -1);
    public static readonly HexIndex fireHex = new(1, -1);
    public static readonly HexIndex waterHex = new(1, 1);



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
            field_1550 = filtrationStroke, // Stroke/outline
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
            field_1550 = trueCalcificationStroke, // Stroke/outline
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
            field_1550 = trueDuplicationStroke, // Stroke/outline
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

        Mitosis = new()
        {
            field_1528 = "misc-glyph-mitosis", // ID
            field_1529 = class_134.method_253("Glyph of Mitosis", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of mitosis clones an existing atom and bonds, creating an extrusion effect.", string.Empty), // Description
            field_1531 = 40, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = trueDuplicationGlow, // Shadow/glow
            field_1550 = trueDuplicationStroke, // Stroke/outline
            field_1547 = mitosisIcon, // Panel icon
            field_1548 = mitosisIconHover, // Hovered panel icon
            field_1538 = new class_222[1]
            {
                new(new HexIndex(0, 0), new HexIndex(1, 0), enum_126.Standard, struct_18.field_1431)
            },
            field_1540 = new HexIndex[]
            {
                subjectBowl,
                irisBowl
            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MiscGlyphs.MitosisPermission)
        };

        CDispersion = new()
        {
            field_1528 = "misc-glyph-cDispersion", // ID
            field_1529 = class_134.method_253("Glyph of Dispersion (C shaped)", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of dispersion transmutes one atom of quintessence into one atom of each of the four cardinal elements.", string.Empty), // Description
            field_1531 = 20, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = cDisperionGlow, // Shadow/glow
            field_1550 = cDisperionStroke, // Stroke/outline
            field_1547 = cDispersionIcon, // Panel icon
            field_1548 = cDispersionIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            {
                quintessenceHex,
                airHex,
                waterHex,
                fireHex,
                earthHex
            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MiscGlyphs.CDispersionPermission)
        };

        QApi.AddPartTypeToPanel(Filtration, false);
        QApi.AddPartTypeToPanel(TrueCalcification, false);
        QApi.AddPartTypeToPanel(TrueDuplication, false);
        QApi.AddPartTypeToPanel(Mitosis, false);
        QApi.AddPartTypeToPanel(CDispersion, false);

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
            renderer.method_523(trueDuplicationBase, Vector2.Zero, new Vector2(41f, 48f), 0f);
            renderer.method_529(bowl, subjectBowl, Vector2.Zero);
            renderer.method_529(metalBowl, saltBowl, Vector2.Zero);
            renderer.method_529(saltSymbol, saltBowl, Vector2.Zero);
            renderer.method_521(duplicationBond, new(-31f, 21f));
        });

        QApi.AddPartType(Mitosis, static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.method_507().method_481(part);
            class_236 uco = editor.method_1989(part, pos);
            float time = editor.method_504();

            int irisFrame = 15;
            bool afterIrisOpens = false;
            AtomType outputAtom = pss.field_2743 ? pss.field_2744[0] : Brimstone.API.VanillaAtoms["salt"];
            Molecule risingAtom = Molecule.method_1121(outputAtom);

            renderer.method_523(mitosisBase, new Vector2(0f, -1f), new Vector2(42f, 48f), 0f);
            renderer.method_528(mitosisBowl, subjectBowl, Vector2.Zero);
            renderer.method_528(irisWell, irisBowl, Vector2.Zero);

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
            renderer.method_529(irisAnimation[irisFrame], irisBowl, Vector2.Zero);
            renderer.method_528(irisRing, irisBowl, Vector2.Zero);
            if (pss.field_2743 && afterIrisOpens)
            {
                // show atom rising infront of iris
                Editor.method_925(risingAtom, risingOffset, new HexIndex(0, 0), 0f, 1f, time, 1f, false, null);
            }
            renderer.method_521(mitosisBond, new Vector2(-28f, 22f));
            renderer.method_531(class_238.field_1989.field_90.field_165, class_238.field_1989.field_90.field_166, new HexIndex(0, 0), 0f);
        });

        QApi.AddPartType(CDispersion, static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.method_507().method_481(part);
            class_236 uco = editor.method_1989(part, pos);
            float time = editor.method_504();

            renderer.method_523(cDispersionBase, Vector2.Zero, new Vector2(51f, 129f), 0f);
            renderer.method_529(cDispersionInput, quintessenceHex, Vector2.Zero);
            renderer.method_529(quintessenceSymbol, quintessenceHex, Vector2.Zero);
            int irisFrame = 15;
            bool afterIrisOpens = false;
            AtomType[] cardinalAtoms = new AtomType[4]
            {
                Brimstone.API.VanillaAtoms["air"],
                Brimstone.API.VanillaAtoms["water"],
                Brimstone.API.VanillaAtoms["fire"],
                Brimstone.API.VanillaAtoms["earth"]
            };

            HexIndex[] outputHexes = new HexIndex[4]
            {
                airHex,
                waterHex,
                fireHex,
                earthHex
            };

            Texture[][] cardinalIrises = new Texture[4][]
            {
                class_238.field_1989.field_90.field_247,
                class_238.field_1989.field_90.field_252,
                class_238.field_1989.field_90.field_249,
                class_238.field_1989.field_90.field_248
            };

            if (pss.field_2743)
            {
                irisFrame = class_162.method_404((int)(class_162.method_411(1f, -1f, time) * 16f), 0, 15);
                afterIrisOpens = time > 0.5f;
            }

            for (int i = 0; i < 4; i++)
            {
                HexIndex h = outputHexes[i];
                Vector2 risingOffset = uco.field_1984 + class_187.field_1742.method_492(h).Rotated(uco.field_1985);
                Molecule risingAtom = Molecule.method_1121(cardinalAtoms[i]);

                renderer.method_528(irisWell, h, Vector2.Zero);
                if (pss.field_2743 && !afterIrisOpens)
                {
                    // show atom rising behind iris
                    Editor.method_925(risingAtom, risingOffset, new HexIndex(0, 0), 0f, 1f, time, 1f, false, null);
                }
                renderer.method_529(cardinalIrises[i][irisFrame], h, Vector2.Zero);
                renderer.method_528(irisRing, h, Vector2.Zero);
                if (pss.field_2743 && afterIrisOpens)
                {
                    // show atom rising infront of iris
                    Editor.method_925(risingAtom, risingOffset, new HexIndex(0, 0), 0f, 1f, time, 1f, false, null);
                }
            }
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
                else if (type == Mitosis)
                {
                    if (first && !pss[part].field_2743)
                    {
                        if (sim.FindAtomRelative(part, subjectBowl).method_99(out AtomReference subject) && !sim.FindAtomRelative(part, irisBowl).method_1085())
                        {
                            Brimstone.API.AddSmallCollider(sim, part, irisBowl);
                            pss[part].field_2743 = true;
                            pss[part].field_2744 = new AtomType[1] { subject.field_2280 };
                        }
                    }
                    else if (pss[part].field_2743)
                    {
                        // Spawn new atom
                        AtomType output = pss[part].field_2744[0];
                        Brimstone.API.AddAtom(sim, output, part, filterOutput);
                    }
                }
                else if (type == CDispersion)
                {
                    HexIndex[] outputHexes = new HexIndex[4]
                    {
                        airHex,
                        waterHex,
                        fireHex,
                        earthHex
                    };

                    if (first && !pss[part].field_2743)
                    {
                        if (sim.FindAtomRelative(part, quintessenceHex).method_99(out AtomReference quintessence) && !quintessence.field_2281 && !quintessence.field_2282 && quintessence.field_2280 == Brimstone.API.VanillaAtoms["quintessence"])
                        {
                            bool blocked = false;
                            foreach (HexIndex h in outputHexes)
                            {
                                if (sim.FindAtomRelative(part, h).method_1085())
                                {
                                    blocked = true;
                                    break;
                                }
                            }
                            if (!blocked)
                            {
                                Brimstone.API.RemoveAtom(quintessence);
                                seb.field_3937.Add(new(seb, quintessence.field_2278, quintessence.field_2280));
                                pss[part].field_2743 = true;
                                foreach (HexIndex h in outputHexes)
                                {
                                    Brimstone.API.AddSmallCollider(sim, part, h);
                                }
                            }
                        }
                    }
                    else if (pss[part].field_2743)
                    {
                        AtomType[] cardinalAtoms = new AtomType[4]
                        {
                            Brimstone.API.VanillaAtoms["air"],
                            Brimstone.API.VanillaAtoms["water"],
                            Brimstone.API.VanillaAtoms["fire"],
                            Brimstone.API.VanillaAtoms["earth"]
                        };

                        for (int i = 0; i < 4; i++)
                        {
                            // Spawn new atom
                            Brimstone.API.AddAtom(sim, cardinalAtoms[i], part, outputHexes[i]);
                        }
                    }
                }
            }
        });
    }
}
