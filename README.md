# Alexa.NET.SoundLibrary
This package gives you a quick way of referencing the sound effects offered by Amazon in the [Alexa Skills Kit - Sound Library](https://developer.amazon.com/docs/custom-skills/ask-soundlibrary.html)

## Adding a sound effect to your response
```csharp
using Alexa.NET.Response.Ssml.SoundLibrary;
...
var speech = new Speech {Elements = new List<ISsml> { Human.Cough01 }};
return ResponseBuilder.Tell(speech);
```
