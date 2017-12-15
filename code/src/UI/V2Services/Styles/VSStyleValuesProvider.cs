﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Windows;
using System.Windows.Media;

using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell;

namespace Microsoft.Templates.UI.V2Services
{
    public class VSStyleValuesProvider : IStyleValuesProvider
    {
        public VSStyleValuesProvider()
        {
            VSColorTheme.ThemeChanged += OnThemeChanged;
        }

        private void OnThemeChanged(ThemeChangedEventArgs e)
        {
            ThemeChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ThemeChanged;

        public Brush GetColor(string className, string memberName)
        {
            switch (className)
            {
                case "ThemedDialog":
                    return GetColorFromThemedDialog(memberName);
                case "CommonDocument":
                    return GetColorFromCommonDocument(memberName);
                case "CommonControls":
                    return GetColorFromCommonControls(memberName);
                case "ThemedCard":
                    return GetColorFromThemedCard(memberName);
                default:
                    throw new Exception($"Class name not recognized '{className}'");
            }
        }

        private Brush GetColorFromThemedDialog(string memberName)
        {
            switch (memberName)
            {
                case "WindowPanel":
                    return GetColor(ThemedDialogColors.WindowPanelColorKey);
                case "WindowBorder":
                    return GetColor(ThemedDialogColors.WindowBorderColorKey);
                case "HeaderText":
                    return GetColor(ThemedDialogColors.HeaderTextColorKey);
                case "Hyperlink":
                    return GetColor(ThemedDialogColors.HyperlinkColorKey);
                case "HyperlinkHover":
                    return GetColor(ThemedDialogColors.HyperlinkHoverColorKey);
                case "HyperlinkPressed":
                    return GetColor(ThemedDialogColors.HyperlinkPressedColorKey);
                case "HyperlinkDisabled":
                    return GetColor(ThemedDialogColors.HyperlinkDisabledColorKey);
                case "SelectedItemActive":
                    return GetColor(ThemedDialogColors.SelectedItemActiveColorKey);
                case "SelectedItemInactive":
                    return GetColor(ThemedDialogColors.SelectedItemInactiveColorKey);
                case "ListItemMouseOver":
                    return GetColor(ThemedDialogColors.ListItemMouseOverColorKey);
                case "ListItemDisabledText":
                    return GetColor(ThemedDialogColors.ListItemDisabledTextColorKey);
                case "GridHeadingBackground":
                    return GetColor(ThemedDialogColors.GridHeadingBackgroundColorKey);
                case "GridHeadingHoverBackground":
                    return GetColor(ThemedDialogColors.GridHeadingHoverBackgroundColorKey);
                case "GridHeadingText":
                    return GetColor(ThemedDialogColors.GridHeadingTextColorKey);
                case "GridHeadingHoverText":
                    return GetColor(ThemedDialogColors.GridHeadingHoverTextColorKey);
                case "GridLine":
                    return GetColor(ThemedDialogColors.GridLineColorKey);
                case "SectionDivider":
                    return GetColor(ThemedDialogColors.SectionDividerColorKey);
                case "WindowButton":
                    return GetColor(ThemedDialogColors.WindowButtonColorKey);
                case "WindowButtonHover":
                    return GetColor(ThemedDialogColors.WindowButtonHoverColorKey);
                case "WindowButtonDown":
                    return GetColor(ThemedDialogColors.WindowButtonDownColorKey);
                case "WindowButtonBorder":
                    return GetColor(ThemedDialogColors.WindowButtonBorderColorKey);
                case "WindowButtonHoverBorder":
                    return GetColor(ThemedDialogColors.WindowButtonHoverBorderColorKey);
                case "WindowButtonDownBorder":
                    return GetColor(ThemedDialogColors.WindowButtonDownBorderColorKey);
                case "WindowButtonGlyph":
                    return GetColor(ThemedDialogColors.WindowButtonGlyphColorKey);
                case "WindowButtonHoverGlyph":
                    return GetColor(ThemedDialogColors.WindowButtonHoverGlyphColorKey);
                case "WindowButtonDownGlyph":
                    return GetColor(ThemedDialogColors.WindowButtonDownGlyphColorKey);
                case "WizardFooter":
                    return GetColor(ThemedDialogColors.WizardFooterColorKey);
                case "HeaderTextSecondary":
                    return LightColorValues.Color_FF828282; // TODO: Replace this temporary value for a VS Color
                case "WizardFooterText":
                    return LightColorValues.Color_FF828282; // TODO: Replace this temporary value for a VS Color
                default:
                    throw new Exception($"The color key value '{memberName}' is not found");
            }
        }

        private Brush GetColorFromCommonDocument(string memberName)
        {
            switch (memberName)
            {
                case "ListItemText":
                    return GetColor(CommonDocumentColors.ListItemTextColorKey);
                case "ListItemTextDisabled":
                    return GetColor(CommonDocumentColors.ListItemTextDisabledColorKey);
                default:
                    throw new Exception($"The color key value '{memberName}' is not found");
            }
        }

        private Brush GetColorFromCommonControls(string memberName)
        {
            switch (memberName)
            {
                case "Button":
                    return GetColor(CommonControlsColors.ButtonColorKey);
                case "ButtonText":
                    return GetColor(CommonControlsColors.ButtonTextColorKey);
                case "ButtonBorder":
                    return GetColor(CommonControlsColors.ButtonBorderColorKey);

                case "ButtonDefault":
                    return GetColor(CommonControlsColors.ButtonDefaultColorKey);
                case "ButtonDefaultText":
                    return GetColor(CommonControlsColors.ButtonDefaultTextColorKey);
                case "ButtonBorderDefault":
                    return GetColor(CommonControlsColors.ButtonBorderDefaultColorKey);

                case "ButtonDisabled":
                    return GetColor(CommonControlsColors.ButtonDisabledColorKey);
                case "ButtonDisabledText":
                    return GetColor(CommonControlsColors.ButtonDisabledTextColorKey);
                case "ButtonBorderDisabled":
                    return GetColor(CommonControlsColors.ButtonBorderDisabledColorKey);

                case "ButtonFocused":
                    return GetColor(CommonControlsColors.ButtonFocusedColorKey);
                case "ButtonFocusedText":
                    return GetColor(CommonControlsColors.ButtonFocusedTextColorKey);
                case "ButtonBorderFocused":
                    return GetColor(CommonControlsColors.ButtonBorderFocusedColorKey);

                case "ButtonHover":
                    return GetColor(CommonControlsColors.ButtonHoverColorKey);
                case "ButtonHoverText":
                    return GetColor(CommonControlsColors.ButtonHoverTextColorKey);
                case "ButtonBorderHover":
                    return GetColor(CommonControlsColors.ButtonBorderHoverColorKey);

                case "ButtonPressed":
                    return GetColor(CommonControlsColors.ButtonPressedColorKey);
                case "ButtonPressedText":
                    return GetColor(CommonControlsColors.ButtonPressedTextColorKey);
                case "ButtonBorderPressed":
                    return GetColor(CommonControlsColors.ButtonBorderPressedColorKey);

                case "ComboBoxBackground":
                    return GetColor(CommonControlsColors.ComboBoxBackgroundColorKey);
                case "ComboBoxBackgroundDisabled":
                    return GetColor(CommonControlsColors.ComboBoxBackgroundDisabledColorKey);
                case "ComboBoxBackgroundFocused":
                    return GetColor(CommonControlsColors.ComboBoxBackgroundFocusedColorKey);
                case "ComboBoxBackgroundHover":
                    return GetColor(CommonControlsColors.ComboBoxBackgroundHoverColorKey);
                case "ComboBoxBackgroundPressed":
                    return GetColor(CommonControlsColors.ComboBoxBackgroundPressedColorKey);

                case "ComboBoxBorder":
                    return GetColor(CommonControlsColors.ComboBoxBorderColorKey);
                case "ComboBoxBorderDisabled":
                    return GetColor(CommonControlsColors.ComboBoxBorderDisabledColorKey);
                case "ComboBoxBorderFocused":
                    return GetColor(CommonControlsColors.ComboBoxBorderFocusedColorKey);
                case "ComboBoxBorderHover":
                    return GetColor(CommonControlsColors.ComboBoxBorderHoverColorKey);
                case "ComboBoxBorderPressed":
                    return GetColor(CommonControlsColors.ComboBoxBorderPressedColorKey);

                case "ComboBoxGlyph":
                    return GetColor(CommonControlsColors.ComboBoxGlyphColorKey);
                case "ComboBoxGlyphBackground":
                    return GetColor(CommonControlsColors.ComboBoxGlyphBackgroundColorKey);
                case "ComboBoxGlyphBackgroundDisabled":
                    return GetColor(CommonControlsColors.ComboBoxGlyphBackgroundDisabledColorKey);
                case "ComboBoxGlyphBackgroundFocused":
                    return GetColor(CommonControlsColors.ComboBoxGlyphBackgroundFocusedColorKey);
                case "ComboBoxGlyphBackgroundHover":
                    return GetColor(CommonControlsColors.ComboBoxGlyphBackgroundHoverColorKey);
                case "ComboBoxGlyphBackgroundPressed":
                    return GetColor(CommonControlsColors.ComboBoxGlyphBackgroundPressedColorKey);
                case "ComboBoxGlyphDisabled":
                    return GetColor(CommonControlsColors.ComboBoxGlyphDisabledColorKey);
                case "ComboBoxGlyphFocused":
                    return GetColor(CommonControlsColors.ComboBoxGlyphFocusedColorKey);
                case "ComboBoxGlyphHover":
                    return GetColor(CommonControlsColors.ComboBoxGlyphHoverColorKey);
                case "ComboBoxGlyphPressed":
                    return GetColor(CommonControlsColors.ComboBoxGlyphPressedColorKey);

                case "ComboBoxListBackground":
                    return GetColor(CommonControlsColors.ComboBoxListBackgroundColorKey);
                case "ComboBoxListBackgroundShadow":
                    return GetColor(CommonControlsColors.ComboBoxListBackgroundShadowColorKey);
                case "ComboBoxListBorder":
                    return GetColor(CommonControlsColors.ComboBoxListBorderColorKey);
                case "ComboBoxListItemBackgroundHover":
                    return GetColor(CommonControlsColors.ComboBoxListItemBackgroundHoverColorKey);
                case "ComboBoxListItemBorderHover":
                    return GetColor(CommonControlsColors.ComboBoxListItemBorderHoverColorKey);
                case "ComboBoxListItemText":
                    return GetColor(CommonControlsColors.ComboBoxListItemTextColorKey);
                case "ComboBoxListItemTextHover":
                    return GetColor(CommonControlsColors.ComboBoxListItemTextHoverColorKey);

                case "ComboBoxSelection":
                    return GetColor(CommonControlsColors.ComboBoxSelectionColorKey);

                case "ComboBoxSeparator":
                    return GetColor(CommonControlsColors.ComboBoxSeparatorColorKey);
                case "ComboBoxSeparatorDisabled":
                    return GetColor(CommonControlsColors.ComboBoxSeparatorDisabledColorKey);
                case "ComboBoxSeparatorFocused":
                    return GetColor(CommonControlsColors.ComboBoxSeparatorFocusedColorKey);
                case "ComboBoxSeparatorHover":
                    return GetColor(CommonControlsColors.ComboBoxSeparatorHoverColorKey);
                case "ComboBoxSeparatorPressed":
                    return GetColor(CommonControlsColors.ComboBoxSeparatorPressedColorKey);

                case "ComboBoxText":
                    return GetColor(CommonControlsColors.ComboBoxTextColorKey);
                case "ComboBoxTextDisabled":
                    return GetColor(CommonControlsColors.ComboBoxTextDisabledColorKey);
                case "ComboBoxTextFocused":
                    return GetColor(CommonControlsColors.ComboBoxTextFocusedColorKey);
                case "ComboBoxTextHover":
                    return GetColor(CommonControlsColors.ComboBoxTextHoverColorKey);
                case "ComboBoxTextInputSelection":
                    return GetColor(CommonControlsColors.ComboBoxTextInputSelectionColorKey);
                case "ComboBoxTextPressed":
                    return GetColor(CommonControlsColors.ComboBoxTextPressedColorKey);

                case "TextBoxBackground":
                    return GetColor(CommonControlsColors.TextBoxBackgroundColorKey);
                case "TextBoxBorder":
                    return GetColor(CommonControlsColors.TextBoxBorderColorKey);
                case "TextBoxText":
                    return GetColor(CommonControlsColors.TextBoxTextColorKey);

                case "TextBoxBackgroundDisabled":
                    return GetColor(CommonControlsColors.TextBoxBackgroundDisabledColorKey);
                case "TextBoxBorderDisabled":
                    return GetColor(CommonControlsColors.TextBoxBorderDisabledColorKey);
                case "TextBoxTextDisabled":
                    return GetColor(CommonControlsColors.TextBoxTextDisabledColorKey);

                case "TextBoxBackgroundFocused":
                    return GetColor(CommonControlsColors.TextBoxBackgroundFocusedColorKey);
                case "TextBoxBorderFocused":
                    return GetColor(CommonControlsColors.TextBoxBorderFocusedColorKey);
                case "TextBoxTextFocused":
                    return GetColor(CommonControlsColors.TextBoxTextFocusedColorKey);
                default:
                    throw new Exception($"The color key value '{memberName}' is not found");
            }
        }

        private Brush GetColorFromThemedCard(string memberName)
        {
            switch (memberName)
            {
                case "CardTitleText":
                    return LightColorValues.Color_FF1E1E1E; // TODO: Replace this temporary value for a VS Color
                case "CardDescriptionText":
                    return LightColorValues.Color_FF717171; // TODO: Replace this temporary value for a VS Color
                case "CardBackgroundDefault":
                    return LightColorValues.Color_FFFFFFFF; // TODO: Replace this temporary value for a VS Color
                case "CardBackgroundFocus":
                    return LightColorValues.Color_FFFFFFFF; // TODO: Replace this temporary value for a VS Color
                case "CardBackgroundHover":
                    return LightColorValues.Color_FFEFEFF2; // TODO: Replace this temporary value for a VS Color
                case "CardBackgroundPressed":
                    return LightColorValues.Color_FFEFEFF2; // TODO: Replace this temporary value for a VS Color
                case "CardBackgroundSelected":
                    return LightColorValues.Color_FFFFFFFF; // TODO: Replace this temporary value for a VS Color
                case "CardBackgroundDisabled":
                    return LightColorValues.Color_FFF5F5F5; // TODO: Replace this temporary value for a VS Color
                case "CardBorderDefault":
                    return LightColorValues.Color_FFBFBFBF; // TODO: Replace this temporary value for a VS Color
                case "CardBorderFocus":
                    return LightColorValues.Color_FF3399FF; // TODO: Replace this temporary value for a VS Color
                case "CardBorderHover":
                    return LightColorValues.Color_FF9A9A9A; // TODO: Replace this temporary value for a VS Color
                case "CardBorderPressed":
                    return LightColorValues.Color_FF007ACC; // TODO: Replace this temporary value for a VS Color
                case "CardBorderSelected":
                    return LightColorValues.Color_FF007ACC; // TODO: Replace this temporary value for a VS Color
                case "CardBorderDisabled":
                    return LightColorValues.Color_FFCCCEDB; // TODO: Replace this temporary value for a VS Color
                case "CardIcon":
                    return LightColorValues.Color_FF888D8F; // TODO: Replace this temporary value for a VS Color
                default:
                    throw new Exception($"The color key value '{memberName}' is not found");
            }
        }

        public Brush GetColor(ThemeResourceKey themeResourceKey)
        {
            var themeColor = VSColorTheme.GetThemedColor(themeResourceKey);
            return new SolidColorBrush(new Color()
            {
                A = themeColor.A,
                R = themeColor.R,
                G = themeColor.G,
                B = themeColor.B
            });
        }

        public double GetFontSize(string fontSizeResourceKey)
        {
            switch (fontSizeResourceKey)
            {
                case "Environment100PercentFontSize":
                    return GetVSFontSize(VsFonts.EnvironmentFontSizeKey);
                case "Environment111PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment111PercentFontSizeKey);
                case "Environment122PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment122PercentFontSizeKey);
                case "Environment133PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment133PercentFontSizeKey);
                case "Environment155PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment155PercentFontSizeKey);
                case "Environment200PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment200PercentFontSizeKey);
                case "Environment310PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment310PercentFontSizeKey);
                case "Environment330PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment330PercentFontSizeKey);
                case "Environment375PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment375PercentFontSizeKey);
                case "Environment90PercentFontSize":
                    return GetVSFontSize(VsFonts.Environment90PercentFontSizeKey);
                default:
                    throw new Exception($"The font size value '{fontSizeResourceKey}' is not found");
            }
        }

        public FontFamily GetFontFamily()
        {
            var fontFamily = Application.Current.FindResource(VsFonts.EnvironmentFontFamilyKey);
            if (fontFamily is FontFamily)
            {
                return fontFamily as FontFamily;
            }

            throw new Exception($"The font family is not valid.");
        }

        private double GetVSFontSize(object value)
        {
            var font = Application.Current.FindResource(value);
            if (font is double)
            {
                return (double)font;
            }

            throw new Exception($"The font size is not valid.");
        }
    }
}
