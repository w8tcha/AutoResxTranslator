namespace AutoResxTranslator.Definitions
{
    /// <summary>
    /// The ms translation api.
    /// </summary>
    public class MsTranslationApi
    {
        /// <summary>
        /// The C# classes that represents the JSON returned by the Translator Text API.
        /// </summary>
        public class TranslationResult
        {
            /// <summary>
            /// Gets or sets the detected language.
            /// </summary>
            public DetectedLanguage DetectedLanguage { get; set; }

            /// <summary>
            /// Gets or sets the source text.
            /// </summary>
            public TextResult SourceText { get; set; }

            /// <summary>
            /// Gets or sets the translations.
            /// </summary>
            public Translation[] Translations { get; set; }
        }

        /// <summary>
        /// The detected language.
        /// </summary>
        public class DetectedLanguage
        {
            /// <summary>
            /// Gets or sets the language.
            /// </summary>
            public string Language { get; set; }

            /// <summary>
            /// Gets or sets the score.
            /// </summary>
            public float Score { get; set; }
        }

        /// <summary>
        /// The text result.
        /// </summary>
        public class TextResult
        {
            /// <summary>
            /// Gets or sets the text.
            /// </summary>
            public string Text { get; set; }

            /// <summary>
            /// Gets or sets the script.
            /// </summary>
            public string Script { get; set; }
        }

        /// <summary>
        /// The translation.
        /// </summary>
        public class Translation
        {
            /// <summary>
            /// Gets or sets the text.
            /// </summary>
            public string Text { get; set; }

            /// <summary>
            /// Gets or sets the transliteration.
            /// </summary>
            public TextResult Transliteration { get; set; }

            /// <summary>
            /// Gets or sets the to.
            /// </summary>
            public string To { get; set; }

            /// <summary>
            /// Gets or sets the alignment.
            /// </summary>
            public Alignment Alignment { get; set; }

            /// <summary>
            /// Gets or sets the sent len.
            /// </summary>
            public SentenceLength SentLen { get; set; }
        }

        /// <summary>
        /// The alignment.
        /// </summary>
        public class Alignment
        {
            public string Proj { get; set; }
        }

        /// <summary>
        /// The sentence length.
        /// </summary>
        public class SentenceLength
        {
            public int[] SrcSentLen { get; set; }

            public int[] TransSentLen { get; set; }
        }
    }
}