# CloudTranslation

# How to use
```csharp
using System;
using Minami.CloudTranslation;

namespace Sample
{
  class Program
  {
    static void Main(string[] args)
    {
    var apiKey = "YOUR API KEY";
    var cloudTranslation = new CloudTranslationClient(apiKey);
	
    //Example of translation from English to Japanese
    var texts = new SourceTexts("Hello", "World"); //Variable length argument of string
    var target = "ja";
    var source = "en";
    
    var results = cloudTranslation.Translate(texts, target, source); //source can be omitted
    Console.WriteLine(results[0]); //Japanese translation of "Hello"
    Console.WriteLine(results[1]); //Japanese translation of "World"
    
    Console.ReadLine();
    }
  }
}
```
