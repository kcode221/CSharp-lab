using System;

namespace console
{
    class StrManip
    {

        public static string reverse(string s)
        {
            if (s.Length <= 1)
                return s;
            var arrs = s.ToCharArray();
            var slen = s.Length-1;
            var start = 0;
            while (start <= slen)
            {
                var temp = arrs[start];
                arrs[start] = arrs[slen];
                arrs[slen] = temp;
                start++;
                slen--;
            }
            return new String(arrs);
        }
    }
}