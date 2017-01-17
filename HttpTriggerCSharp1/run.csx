using System.Net;
// using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");

    // parse query parameter
    //string name = req.GetQueryNameValuePairs()
    //    .FirstOrDefault(q => string.Compare(q.Key, "name", true) == 0)
    //    .Value;

    // Get request body
    //dynamic data = await req.Content.ReadAsAsync<object>();

    // string jsonContent = await req.Content.ReadAsStringAsync();
    // dynamic data = JsonConvert.DeserializeObject(jsonContent);

    // Set name to query string or body data
    //name = name ?? data?.name;

    // return name == null
    //     ? req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a name on the query string or in the request body")
    //     : req.CreateResponse(HttpStatusCode.OK, "Hello " + name);

// {
//   "version": "1.0",
//   "response": {
//     "outputSpeech": {
//       "type": "PlainText",
//       "text": "Welcome to the Alexa Skills Kit, you can say hello"
//     },
//     "card": {
//       "type": "Simple",
//       "title": "HelloWorld",
//       "content": "Welcome to the Alexa Skills Kit, you can say hello"
//     },
//     "reprompt": {
//       "outputSpeech": {
//  "type": "PlainText",
//  "text": "Welcome to the Alexa Skills Kit, you can say hello"
//       }
//     },
//     "shouldEndSession": false
//   },
//   "sessionAttributes": {}
// }

    // return req.CreateResponse(HttpStatusCode.OK,
    //  new {version = "1.0" }
    // );

    return req.CreateResponse(HttpStatusCode.OK,
     new {
        version = "1.0",
        response = new {
            outputSpeech = new {
                type = "PlainText",
                text = "Hello Martin"
                },
            shouldEndSession = true
            },
        sessionAttributes = new {}
        }
    );
    //return req.CreateResponse(HttpStatusCode.OK);
    //return req.CreateResponse(HttpStatusCode.OK, "{\"version\":\"1.0\",\"response\":{\"outputSpeech\":{\"type\":\"PlainText\",\"text\":\"Hello Martin\"}}}");
}