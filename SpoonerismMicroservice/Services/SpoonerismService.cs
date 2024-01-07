namespace SpoonerismMicroservice.Services
{
    public class SpoonerismService
    {
        public SpoonerismService() { }
        public string ApplySpoonerism(string text)
        {
            // Perform spoonerism transformation logic
            string[] words = text.Split(' ');

            if (words.Length >= 2)
            {
                // Swap the initial letter of the first two words
                string temp = words[0].Substring(0, 1);
                words[0] = words[1].Substring(0, 1) + words[0].Substring(1);
                words[1] = temp + words[1].Substring(1);
            }

            return string.Join(' ', words);
        }
    }
}
