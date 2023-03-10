
namespace VendingMachine
{
    public static class Helper
    {
        static int tableWidth = 40;
        public static string DisplayIngredients(Coffee coffee)
        {
            string table = "\n" + PrintLine() + "\n";
            table += PrintRow("Ingredients", "Quantity") + "\n"; ;
            table += PrintLine() + "\n"; ;
            foreach (var ingredient in coffee.Ingredients)
            {
                table += PrintRow(ingredient.Key, ingredient.Value.ToString()) + "\n"; ;
            }
            table += PrintLine() + "\n"; ;
            return table;
        }

        public static string PrintLine()
        {
            return new string('-', tableWidth);
        }

        public static string PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            return row;
        }

        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
