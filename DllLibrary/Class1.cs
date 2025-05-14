using System.Diagnostics;

namespace DllLibrary
{
    public class RabotaChisly
    {
        
        public static bool PoYbivaniu(int n)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
            Trace.Listeners.Add(new ConsoleTraceListener());
            if(n == 0)
            {
                Debug.WriteLine("число равно 0");
                Trace.WriteLine("число равно 0");
                Trace.Flush();
                return false;
            }

            int count = 0;
            int copyN = n;
            while (copyN > 0) 
            {
                copyN /= 10;
                count++;
            }
            if (count == 4)
            {
                string str = n.ToString();
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i + 1] > str[i] || str[i] == str[i + 1])
                    {
                        Debug.WriteLine(n.ToString());
                        Debug.WriteLine("цифры расположены не по убыванию");
                        Debug.Flush();
                        Trace.WriteLine(n.ToString());
                        Trace.WriteLine("цифры расположены не по убыванию");
                        Trace.Flush();
                        return false;
                    }
                }

            }
            Debug.WriteLine(n.ToString());
            Debug.WriteLine("цифры расположены по убыванию");
            Debug.Flush();
            Trace.WriteLine(n.ToString());
            Trace.WriteLine("цифры расположены по убыванию");
            Trace.Flush();
            return true;
        }
    }
}
