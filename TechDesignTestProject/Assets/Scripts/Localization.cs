using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class Localization : MonoBehaviour
{
    public void SetLocalizationLanguage(int ID)
    {
        SetSelectLocale(LocalizationSettings.AvailableLocales.Locales[ID]);
    }

    private void SetSelectLocale(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }
}
