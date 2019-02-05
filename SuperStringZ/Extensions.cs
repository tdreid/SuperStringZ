using System;

namespace SuperStringZ.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Reports the zero-based index of the first of any several
        /// specified strings in this instance.
        /// </summary>
        /// <param name="this">The string upon which to act.</param>
        /// <param name="values">A list of parameters for which to search.</param>
        /// <returns>The zero-based index of the first occurrence.</returns>
        public static int FindFirstContained (
            this string @this, 
            params string[] values)
        {
            int index;
            foreach(string value in values)
            {
                index = @this.IndexOf(value);
                if ( index != -1)
                {
                    return @this.IndexOf(value);
                } 
            }
            return -1;
        }

        /// <summary>
        /// Reports the first of any several specified strings
        /// that occur in this instance. Returns a specified value
        /// if no such such string is found, an empty string by default.
        /// </summary>
        /// <param name="this">The string upon which to act.</param>
        /// <param name="defaultValue">
        /// An optional string to return if no other specified string
        /// is found.
        /// </param>
        /// <param name="values">A list of parameters for which to search.</param>
        /// <returns>The value of the first substring found, or the defaultValue</returns>
        public static string GetFirstContained(
            this string @this,
            string defaultValue = "",
            params string[] values)
        {
            foreach (string value in values)
            {
                if (@this.IndexOf(value) != -1)
                {
                    return value;
                }
            }
            return defaultValue;
        }
    }
}
