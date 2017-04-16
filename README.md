# JsonRequest_DeserializeDemo
This is a API GET method demo that shows how JSON appears in the console and how to utilize NewtonSoft to target and deserialize fragments of the response.
This program a basic overview of collecting JSON data from a REST API. The data requested is from a wikiMedia API that returns information from a random wikipedia page. 
Requests are limited to 200 per their documentation. Additionally, Bing Image Search API code is in this project as a comment to demostrate the difference between an API
that requires a key. In this demo, NewtonSofts JSON.NET library will be used to parse the the response stream into readable objects which can be targetted and converted
into C# classes. Make sure you download NewtonSoft JSON.NET into your solution before you try to run it! throughout the demo, there are multiple writelines to allow the
to see what unformatted JSON responses look like and why they are difficult to target, what formatted JSON data looks like after being parsed by JSON.NET, and how it becomes
possible to instantiate/interact with a user defined object/class that has been populated by the extracted JSON data.

If I am missing anything or if there are any major bugs, please let me know! Thank you and have fun! (:







WikiMedia REST API link for pulling random pages to get some experience working with JSON data - https://en.wikipedia.org/api/rest_v1/#!/Page_content/get_page_random_format
NewtonSoft Documentation on Serializing and Deserializing JSON data - http://www.newtonsoft.com/json/help/html/SerializingJSON.htm
JSON Placeholder API that generated random JSON data for practice - http://jsonplaceholder.typicode.com/
