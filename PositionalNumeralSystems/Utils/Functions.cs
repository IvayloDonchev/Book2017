using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Functions
    {
        public static int Pow(int a, int b)
        {
            int res = 1;
            for (int i = 1; i <= b; i++)
                res *= a;
            return res;
        }
        public static string FromDec(int n, int r)  // От десетична в r-ична
        {
            string sign = n >= 0 ? "" : "-";
            StringBuilder s = new StringBuilder();
            int d;
            n = Math.Abs(n);
            while (n != 0)
            {
                d = n % r;
                if (d > 9)
                    s.Insert(0, (char)(d + 'A' - 10)); // добавя в началото
                else
                    s.Insert(0, (char)(d + '0'));
                n /= r;
            }
            s.Insert(0, sign);
            return s.ToString();
        }
        public static int ToDec(string s, int r)    // От r-ична в десетична
        {
            int n = 0;
            int sign = 1;
            if (s[0] == '-')
            {
                sign = -1;
                s = s.Substring(1);
            }
            int l = s.Length;
            s = s.ToUpper();
            for (int i = 0; i < l; i++)
            {
                if (s[i] >= 'A')
                    n = n + (s[i] - 'A' + 10) * Pow(r, l - i - 1);
                else
                    n = n + (s[i] - '0') * Pow(r, l - i - 1);
            }
            return sign * n;
        }
    }
}
