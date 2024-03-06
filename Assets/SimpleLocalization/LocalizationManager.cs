using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Assets.SimpleLocalization
{
	/// <summary>
	/// Localization manager.
	/// </summary>
    public static class LocalizationManager
    {
		/// <summary>
		/// Fired when localization changed.
		/// </summary>
        public static event Action LocalizationChanged = () => { };

	    public static readonly Dictionary<string, Dictionary<string, string>> Dictionary = new Dictionary<string, Dictionary<string, string>>();
        private static string _language = "English";

		/// <summary>
		/// Get or set language.
		/// </summary>
        public static string Language
        {
            get { return _language; }
            set { _language = Application.platform == RuntimePlatform.WebGLPlayer ? "English" : value; LocalizationChanged(); }
        }

		/// <summary>
		/// Set default language.
		/// </summary>
        public static void AutoLanguage()
        {
            Language = "English";
        }

		/// <summary>
		/// Read localization spreadsheets.
		/// </summary>
		public static void Read(string path = "Localization")
        {
            if (Dictionary.Count > 0) return;

            var textAssets = Resources.LoadAll<TextAsset>(path);

            foreach (var textAsset in textAssets)
            {
                var text = ReplaceMarkers(textAsset.text).Replace("\"\"", "[quotes]");
                var matches = Regex.Matches(text, "\"[\\s\\S]+?\"");

                foreach (Match match in matches)
                {
					text = text.Replace(match.Value, match.Value.Replace("\"", null).Replace(",", "[comma]").Replace("\n", "[newline]"));
                }

                var lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var languages = lines[0].Split(',').Select(i => i.Trim()).ToList();

                for (var i = 1; i < languages.Count; i++)
                {
                    if (!Dictionary.ContainsKey(languages[i]))
                    {
                        Dictionary.Add(languages[i], new Dictionary<string, string>());
                    }
                }

                for (var i = 1; i < lines.Length; i++)
                {
                    var columns = lines[i].Split(',').Select(j => j.Trim()).Select(j => j.Replace("[comma]", ",").Replace("[newline]", "\n").Replace("[quotes]", "\"")).ToList();
                    var key = columns[0];

	                if (key == "") continue;

                    for (var j = 1; j < languages.Count; j++)
                    {
                        Dictionary[languages[j]].Add(key, columns[j]);
                    }
                }
            }

            AutoLanguage();
        }

	    public static bool HasKey(string localizationKey)
	    {
		    return Dictionary[Language].ContainsKey(localizationKey);
	    }

	    /// <summary>
		/// Get localized value by localization key.
		/// </summary>
		public static string Localize(string localizationKey)
        {
			if (Dictionary.Count == 0)
	        {
		        Read();
	        }

			//if (!Dictionary.ContainsKey(Language)) throw new KeyNotFoundException("Language not found: " + Language);
            if (!Dictionary.ContainsKey(Language)) Language = "English";

			if (!Dictionary[Language].ContainsKey(localizationKey)) throw new KeyNotFoundException("Translation not found: " + localizationKey);

			if (Language == "English") return Dictionary[Language][localizationKey];

	        var missed = !Dictionary[Language].ContainsKey(localizationKey) || string.IsNullOrEmpty(Dictionary[Language][localizationKey]);

	        if (missed)
	        {
		        Debug.LogWarningFormat("Translation not found: {localizationKey} ({0}).", Language);

		        return Dictionary["English"].ContainsKey(localizationKey) ? Dictionary["English"][localizationKey] : localizationKey;
	        }

	        return Dictionary[Language][localizationKey];
		}

	    /// <summary>
	    /// Get localized value by localization key.
	    /// </summary>
		public static string Localize(string localizationKey, params object[] args)
        {
            var pattern = Localize(localizationKey);

            return string.Format(pattern, args);
        }

	    public static string GetChars()
	    {
		    var asset = Resources.Load<TextAsset>("Localization/Common");

		    if (asset == null) return "";

		    var chars = new List<char>();

		    foreach (var s in "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZАаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~Ξ ") if (!chars.Contains(s)) chars.Add(s);
		    foreach (var s in asset.text)
		    {
			    if (!chars.Contains(char.ToLower(s))) chars.Add(char.ToLower(s));
			    if (!chars.Contains(char.ToUpper(s))) chars.Add(char.ToUpper(s));
		    }

		    chars.Sort();

		    var text = new System.Text.StringBuilder();

		    foreach (var s in chars) text.Append(s);

		    return text.ToString();
	    }

	    private static string ReplaceMarkers(string text)
        {
            return text.Replace("[Newline]", "\n");
        }
    }
}