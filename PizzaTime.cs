using System.Diagnostics;
using UnityEditor;

namespace Editor
{
    public static class PizzaTime
    {
        [MenuItem("Pizza Time/Order Dominos")]
        public static void OrderDominos()
        {
            Process.Start("https://www.dominos.com");
        }
        
        [MenuItem("Pizza Time/Order Papa John's")]
        public static void OrderPapaJohn()
        {
            Process.Start("https://www.papajohns.com");
        }

        [MenuItem("Pizza Time/Order Pizza Hut")]
        public static void OrderPizzaHut()
        {
            Process.Start("https://www.pizzahut.com");
        }
    }
}
