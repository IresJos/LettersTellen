using System;

namespace LettersTellen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            string letterVanHetAlfabet = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Voer de tekst in waarvan je de letterfrequentie wil weten.");
            Console.WriteLine("Nummers en leestekens zullen niet worden meegeteld.");
            string invoer = Console.ReadLine();
            for (int ab = 0; ab < invoer.Length; ab++)
            {
                switch (invoer[ab])
                {
                    case 'a':
                        a++;
                        break;
                    case 'b':
                        b++;
                        break;
                    case 'c':
                        c++;
                        break;
                    case 'd':
                        d++;
                        break;
                    case 'e':
                        e++;
                        break;
                    case 'f':
                        f++;
                        break;
                    case 'g':
                        g++;
                        break;
                    case 'h':
                        h++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'j':
                        j++;
                        break;
                    case 'k':
                        k++;
                        break;
                    case 'l':
                        l++;
                        break;
                    case 'm':
                        m++;
                        break;
                    case 'n':
                        n++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'p':
                        p++;
                        break;
                    case 'q':
                        q++;
                        break;
                    case 'r':
                        r++;
                        break;
                    case 's':
                        s++;
                        break;
                    case 't':
                        t++;
                        break;
                    case 'u':
                        u++;
                        break;
                    case 'v':
                        v++;
                        break;
                    case 'w':
                        w++;
                        break;
                    case 'x':
                        x++;
                        break;
                    case 'y':
                        y++;
                        break;
                    case 'z':
                        z++;
                        break;
                    default:
                        break;
                    case 'A':
                        a++;
                        break;
                    case 'B':
                        b++;
                        break;
                    case 'C':
                        c++;
                        break;
                    case 'D':
                        d++;
                        break;
                    case 'E':
                        e++;
                        break;
                    case 'F':
                        f++;
                        break;
                    case 'G':
                        g++;
                        break;
                    case 'H':
                        h++;
                        break;
                    case 'I':
                        i++;
                        break;
                    case 'J':
                        j++;
                        break;
                    case 'K':
                        k++;
                        break;
                    case 'L':
                        l++;
                        break;
                    case 'M':
                        m++;
                        break;
                    case 'N':
                        n++;
                        break;
                    case 'O':
                        o++;
                        break;
                    case 'P':
                        p++;
                        break;
                    case 'Q':
                        q++;
                        break;
                    case 'R':
                        r++;
                        break;
                    case 'S':
                        s++;
                        break;
                    case 'T':
                        t++;
                        break;
                    case 'U':
                        u++;
                        break;
                    case 'V':
                        v++;
                        break;
                    case 'W':
                        w++;
                        break;
                    case 'X':
                        x++;
                        break;
                    case 'Y':
                        y++;
                        break;
                    case 'Z':
                        z++;
                        break;
                }
            }
            for (int cd = 0; cd < 26; cd++)
            {
                switch (letterVanHetAlfabet[cd])
                {
                    case 'a':
                        if (a != 0)
                        {
                            Console.WriteLine("Het aantal a's in de tekst = " + a);
                        }
                        break;
                    case 'b':
                        if (b != 0)
                        {
                            Console.WriteLine("Het aantal b's in de tekst = " + b);
                        }
                        break;
                    case 'c':
                        if (c != 0)
                        {
                            Console.WriteLine("Het aantal c's in de tekst = " + c);
                        }
                        break;
                    case 'd':
                        if (d != 0)
                        {
                            Console.WriteLine("Het aantal d's in de tekst = " + d);
                        }
                        break;
                    case 'e':
                        if (e != 0)
                        {
                            Console.WriteLine("Het aantal e's in de tekst = " + e);
                        }
                        break;
                    case 'f':
                        if (f != 0)
                        {
                            Console.WriteLine("Het aantal f's in de tekst = " + f);
                        }
                        break;
                    case 'g':
                        if (g != 0)
                        {
                            Console.WriteLine("Het aantal g's in de tekst = " + g);
                        }
                        break;
                    case 'h':
                        if (h != 0)
                        {
                            Console.WriteLine("Het aantal h's in de tekst = " + h);
                        }
                        break;
                    case 'i':
                        if (i != 0)
                        {
                            Console.WriteLine("Het aantal i's in de tekst = " + i);
                        }
                        break;
                    case 'j':
                        if (j != 0)
                        {
                            Console.WriteLine("Het aantal j's in de tekst = " + j);
                        }
                        break;
                    case 'k':
                        if (k != 0)
                        {
                            Console.WriteLine("Het aantal k's in de tekst = " + k);
                        }
                        break;
                    case 'l':
                        if (l != 0)
                        {
                            Console.WriteLine("Het aantal l's in de tekst = " + l);
                        }
                        break;
                    case 'm':
                        if (m != 0)
                        {
                            Console.WriteLine("Het aantal m's in de tekst = " + m);
                        }
                        break;
                    case 'n':
                        if (n != 0)
                        {
                            Console.WriteLine("Het aantal n's in de tekst = " + n);
                        }
                        break;
                    case 'o':
                        if (o != 0)
                        {
                            Console.WriteLine("Het aantal o's in de tekst = " + o);
                        }
                        break;
                    case 'p':
                        if (p != 0)
                        {
                            Console.WriteLine("Het aantal p's in de tekst = " + p);
                        }
                        break;
                    case 'q':
                        if (q != 0)
                        {
                            Console.WriteLine("Het aantal q's in de tekst = " + q);
                        }
                        break;
                    case 'r':
                        if (r != 0)
                        {
                            Console.WriteLine("Het aantal r's in de tekst = " + r);
                        }
                        break;
                    case 's':
                        if (s != 0)
                        {
                            Console.WriteLine("Het aantal s's in de tekst = " + s);
                        }
                        break;
                    case 't':
                        if (t != 0)
                        {
                            Console.WriteLine("Het aantal t's in de tekst = " + t);
                        }
                        break;
                    case 'u':
                        if (u != 0)
                        {
                            Console.WriteLine("Het aantal u's in de tekst = " + u);
                        }
                        break;
                    case 'v':
                        if (v != 0)
                        {
                            Console.WriteLine("Het aantal v's in de tekst = " + v);
                        }
                        break;
                    case 'w':
                        if (w != 0)
                        {
                            Console.WriteLine("Het aantal w's in de tekst = " + w);
                        }
                        break;
                    case 'x':
                        if (x != 0)
                        {
                            Console.WriteLine("Het aantal x's in de tekst = " + x);
                        }
                        break;
                    case 'y':
                        if (y != 0)
                        {
                            Console.WriteLine("Het aantal y's in de tekst = " + y);
                        }
                        break;
                    case 'z':
                        if (z != 0)
                        {
                            Console.WriteLine("Het aantal z's in de tekst = " + z);
                        }
                        break;
                }
            }
        }
    }
}
