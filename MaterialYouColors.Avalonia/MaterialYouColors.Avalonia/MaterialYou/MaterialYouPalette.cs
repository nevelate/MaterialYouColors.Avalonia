
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Styling;
using MaterialColorUtilities.Palettes;
using MaterialColorUtilities.Schemes;
using System;

namespace MaterialYouColors.Avalonia.MaterialYou
{
    public class MaterialYouPalette : ResourceProvider
    {
        private bool invalidateColors = true;
        private bool appThemeChanged = false;

        private static readonly Color defaultSystemAccentColor = Color.FromRgb(0, 120, 215);
        private Color systemAccentColor;
        private Scheme<string> colors = null!;

        public override bool HasResources => true;

        public override bool TryGetResource(object key, ThemeVariant? theme, out object? value)
        {
            if (key is string colorKey)
            {
                //Primary
                if (colorKey.Equals("PrimaryColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Primary);
                    return true;
                }
                if (colorKey.Equals("OnPrimaryColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnPrimary);
                    return true;
                }
                if (colorKey.Equals("PrimaryContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.PrimaryContainer);
                    return true;
                }
                if (colorKey.Equals("OnPrimaryContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnPrimaryContainer);
                    return true;
                }

                //Secondary
                if (colorKey.Equals("SecondaryColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Secondary);
                    return true;
                }
                if (colorKey.Equals("OnSecondaryColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnSecondary);
                    return true;
                }
                if (colorKey.Equals("SecondaryContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SecondaryContainer);
                    return true;
                }
                if (colorKey.Equals("OnSecondaryContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnSecondaryContainer);
                    return true;
                }

                //Tertiary
                if (colorKey.Equals("TertiaryColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Tertiary);
                    return true;
                }
                if (colorKey.Equals("OnTertiaryColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnTertiary);
                    return true;
                }
                if (colorKey.Equals("TertiaryContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.TertiaryContainer);
                    return true;
                }
                if (colorKey.Equals("OnTertiaryContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnTertiaryContainer);
                    return true;
                }

                //Error
                if (colorKey.Equals("ErrorColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Error);
                    return true;
                }
                if (colorKey.Equals("OnErrorColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnError);
                    return true;
                }
                if (colorKey.Equals("ErrorContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.ErrorContainer);
                    return true;
                }
                if (colorKey.Equals("OnErrorContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnErrorContainer);
                    return true;
                }

                //Background
                if (colorKey.Equals("BackgroundColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Background);
                    return true;
                }
                if (colorKey.Equals("OnBackgroundColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnBackground);
                    return true;
                }

                //Outline
                if (colorKey.Equals("OutlineColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Outline);
                    return true;
                }
                if (colorKey.Equals("OutlineVariantColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OutlineVariant);
                    return true;
                }

                if (colorKey.Equals("ShadowColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Shadow);
                    return true;
                }

                //Inverse
                if (colorKey.Equals("InverseSurfaceColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.InverseSurface);
                    return true;
                }
                if (colorKey.Equals("InverseOnSurfaceColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.InverseOnSurface);
                    return true;
                }
                if (colorKey.Equals("InversePrimaryColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.InversePrimary);
                    return true;
                }

                //Surface
                if (colorKey.Equals("SurfaceColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Surface);
                    return true;
                }
                if (colorKey.Equals("OnSurfaceColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnSurface);
                    return true;
                }
                if (colorKey.Equals("SurfaceVariantColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceVariant);
                    return true;
                }
                if (colorKey.Equals("OnSurfaceVariantColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.OnSurfaceVariant);
                    return true;
                }

                if (colorKey.Equals("Surface1Color", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Surface1);
                    return true;
                }
                if (colorKey.Equals("Surface2Color", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Surface2);
                    return true;
                }
                if (colorKey.Equals("Surface3Color", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Surface3);
                    return true;
                }
                if (colorKey.Equals("Surface4Color", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Surface4);
                    return true;
                }
                if (colorKey.Equals("Surface5Color", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.Surface5);
                    return true;
                }

                if (colorKey.Equals("SurfaceDimColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceDim);
                    return true;
                }
                if (colorKey.Equals("SurfaceBrightColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceBright);
                    return true;
                }
                if (colorKey.Equals("SurfaceContainerLowestColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceContainerLowest);
                    return true;
                }
                if (colorKey.Equals("SurfaceContainerLowColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceContainerLow);
                    return true;
                }
                if (colorKey.Equals("SurfaceContainerColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceContainer);
                    return true;
                }
                if (colorKey.Equals("SurfaceContainerHighColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceContainerHigh);
                    return true;
                }
                if (colorKey.Equals("SurfaceContainerHighestColor", StringComparison.InvariantCulture))
                {
                    EnsureColors(theme);
                    value = Color.Parse(colors.SurfaceContainerHighest);
                    return true;
                }                
            }
            value = null;
            return false;
        }

        protected override void OnAddOwner(IResourceHost owner)
        {
            if (GetFromOwner(owner) is { } platformSettings)
            {
                platformSettings.ColorValuesChanged += PlatformSettingsOnColorValuesChanged;
            }

            App.Current.ActualThemeVariantChanged += ActualThemeVariantChanged;

            invalidateColors = true;
        }

        private void ActualThemeVariantChanged(object? sender, EventArgs e)
        {
            invalidateColors = true;
            appThemeChanged = true;
            Owner?.NotifyHostedResourcesChanged(ResourcesChangedEventArgs.Empty);
        }

        protected override void OnRemoveOwner(IResourceHost owner)
        {
            if (GetFromOwner(owner) is { } platformSettings)
            {
                platformSettings.ColorValuesChanged -= PlatformSettingsOnColorValuesChanged;
            }

            App.Current.ActualThemeVariantChanged -= ActualThemeVariantChanged;

            invalidateColors = true;
        }

        private void EnsureColors(ThemeVariant? theme)
        {
            if (invalidateColors)
            {
                invalidateColors = false;

                var platformSettings = GetFromOwner(Owner);

                systemAccentColor = platformSettings?.GetColorValues().AccentColor1 ?? defaultSystemAccentColor;

                uint seedColor = systemAccentColor.ToUInt32();
                CorePalette corePalette = CorePalette.Of(seedColor);
                Scheme<uint> scheme = null!;

                if (appThemeChanged)
                {
                    appThemeChanged = false;
                    theme = App.Current.ActualThemeVariant;
                }

                if (theme == ThemeVariant.Light) scheme = new LightSchemeMapper().Map(corePalette);
                else if (theme == ThemeVariant.Dark) scheme = new DarkSchemeMapper().Map(corePalette);

                colors = scheme.Convert(x => "#" + x.ToString("X")[2..]);
            }
        }

        private static IPlatformSettings? GetFromOwner(IResourceHost? owner)
        {
            return owner switch
            {
                Application app => app.PlatformSettings,
                Visual visual => TopLevel.GetTopLevel(visual)?.PlatformSettings,
                _ => null
            };
        }

        private void PlatformSettingsOnColorValuesChanged(object? sender, PlatformColorValues e)
        {
            invalidateColors = true;
            Owner?.NotifyHostedResourcesChanged(ResourcesChangedEventArgs.Empty);
        }
    }
}
