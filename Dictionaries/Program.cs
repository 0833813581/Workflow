namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionaries are collections of data stored as Key-Value pairs
             * 
             * -> provide fast data access based on a unique key
             * 
             
                Dictionary dict<Key, Value> = new Dictionary<>();
                
            var dict = new Dictionary<Key, Value> 
                {
                    {"Key", "Value"}
                }
             */

            Dictionary<string, string> valuePairs = new Dictionary<string, string>();

            // adding values 
            valuePairs.Add("Computer Science", "Programming");
            valuePairs.Add("Law", "Criminology");
            valuePairs.Add("Education", "Teaching Practice");

            // add via index
            valuePairs["Engineering"] = "Mathematics";

            // set the value to empty to 'delete it'
            valuePairs["Education"] = "";
            // printing
            foreach (KeyValuePair<string, string> pair in valuePairs) { 
                Console.WriteLine($"Course: {pair.Key} | Module: {pair.Value}");
            }

            // check if dictionary contains key
            bool containsKey = valuePairs.ContainsKey("Education");

            if (containsKey)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            // remove - to delete keys
            valuePairs.Remove("Education");
            // printing
            foreach (KeyValuePair<string, string> pair in valuePairs)
            {
                Console.WriteLine($"Course: {pair.Key} | Module: {pair.Value}");
            }

            // return the number of items in the dict

            int items = valuePairs.Count;

            Console.WriteLine(items);

            valuePairs.Clear();

            int itemsb = valuePairs.Count;
            Console.WriteLine(itemsb);



        }
    }
}
