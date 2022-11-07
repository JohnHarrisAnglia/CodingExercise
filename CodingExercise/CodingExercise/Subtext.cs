﻿namespace CodingExercise
{
    public class Subtext
    {
        public int[] Positions(string text, string subtextSearchTerm)
        {
            var result = new List<int>();

            var matchedWord = string.Empty;
            var subtextindex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (DoesSubtextExceedTextLength(text, subtextSearchTerm, i - subtextindex))
                {
                    return result.ToArray();
                }

                char subtextChar = char.ToUpperInvariant(subtextSearchTerm[subtextindex]);
                char textChar = char.ToUpperInvariant(text[i]);

                if (subtextChar == textChar)
                {
                    matchedWord = matchedWord + textChar.ToString();
                    subtextindex++;
                }
                else
                {
                    matchedWord = string.Empty;
                    subtextindex = 0;
                }

                if (matchedWord == subtextSearchTerm.ToUpperInvariant())
                {
                    result.Add(i - subtextSearchTerm.Length + 2);
                    matchedWord = string.Empty;
                    subtextindex = 0;
                }
            }

            return result.ToArray();
        }

        private static bool DoesSubtextExceedTextLength(string text, string subtextSearchTerm, int currentPosition)
        {
            return currentPosition + subtextSearchTerm.Length > text.Length;
        }
    }
}