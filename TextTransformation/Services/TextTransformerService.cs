using RestSharp;

namespace TextTransformation.Services
{
    public class TextTransformerService
    {
         private static RestClient spoonerismRestClient = new RestClient("http://spoonerismmicroservice/SpoonerismService/");
       

        public async Task<string> TransformText(string text)
        {
            var task = spoonerismRestClient.GetAsync<string>(new RestRequest("/Get?text=" + text));
            await task;
            return task.Result;
        }
    }
}
